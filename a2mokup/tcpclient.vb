Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class tcpCommClient
    Public errMsg As String

    ' Define the delegate type
    Public Delegate Sub ClientCallbackDelegate(ByVal bytes() As Byte, ByVal dataChannel As Integer)
    ' Create Delegate pointer
    Public ClientCallbackObject As ClientCallbackDelegate
    Private continue_running As Boolean = False
    Private bytes() As Byte
    Private blockSize As UInt16
    Private IP As System.Net.IPAddress
    Private Port As Integer
    Private localAddr As IPAddress
    Private Client As TcpClient
    Private Stream As NetworkStream
    Private fileWriter As clsAsyncUnbuffWriter
    Private fileReader As FileStream
    Private FileBeingSentPath As String
    Private weHaveThePuck As Boolean = False
    Private isRunning As Boolean = False
    Private UserBytesToBeSentAvailable As Boolean = False
    Private UserBytesToBeSent As New MemoryStream
    Private UserOutputChannel As Byte
    Private SystemBytesToBeSentAvailable As Boolean = False
    Private SystemBytesToBeSent() As Byte
    Private SystemOutputChannel As Byte
    Private SendingFile As Boolean = False
    Private ReceivingFile As Boolean = False
    Private IncomingFileName As String
    Private IncomingFileSize As Int64 = 0
    Private outgoingFileSize As UInt64 = 0
    Private outgoingFileName As String
    Private fileBytesRecieved As Int64 = 0
    Private filebytesSent As Int64 = 0
    Private bytesSentThisSecond As Int32 = 0
    Private bytesReceivedThisSecond As Int32 = 0
    Private mbpsOneSecondAverage() As Int32
    Private ReceivedFilesFolder As String = Application.StartupPath & "\ReceivedFiles"
    Private userName As String
    Private password As String

    Private mbpsSyncObject As New AutoResetEvent(False)

    Private Function StrToByteArray(ByVal text As String) As Byte()
        Dim encoding As New System.Text.UTF8Encoding()
        StrToByteArray = encoding.GetBytes(text)
    End Function

    Public Shared Function BytesToString(ByVal data() As Byte) As String
        Dim enc As New System.Text.UTF8Encoding()
        BytesToString = enc.GetString(data)
    End Function

    Public Function isClientRunning() As Boolean
        Return isRunning
    End Function

    
    Public Function GetLocalIpAddress() As System.Net.IPAddress
        Dim strHostName As String
        Dim addresses() As System.Net.IPAddress

        strHostName = System.Net.Dns.GetHostName()
        addresses = System.Net.Dns.GetHostAddresses(strHostName)

        ' Find an IpV4 address
        For Each address As System.Net.IPAddress In addresses
            If address.ToString.Contains(".") Then
                Return address
            End If
        Next

        ' No IpV4 address? Return the loopback address.
        Return System.Net.IPAddress.Loopback
    End Function

    Public Sub New(ByRef callbackMethod As ClientCallbackDelegate)
        blockSize = 10000

        ' Initialize the delegate variable to point to the user's callback method.
        ClientCallbackObject = callbackMethod
    End Sub

    Public Sub Connect(ByVal IP_Address As String, ByVal prt As Integer)
        Port = prt
        IP = System.Net.IPAddress.Parse(IP_Address)
        continue_running = True

        Dim clientCommunicationThread As New Thread(AddressOf Run)
        clientCommunicationThread.Name = "ClientCommunication"
        clientCommunicationThread.Start()
    End Sub

    Public Sub StopRunning()
        continue_running = False
    End Sub

    Public Function GetBlocksize() As UInt16
        Return blockSize
    End Function

    Public Function SendBytes(ByVal bytes() As Byte, Optional ByVal channel As Byte = 1) As Boolean

        'If channel = 0 Or channel > 250 Then
        '    MsgBox("Data can not be sent using channel numbers less then 1 or greater then 250.", MsgBoxStyle.Critical, "TCP_Client")
        '    Exit Function
        'End If

        Do
            If Not UserBytesToBeSentAvailable Then
                'SyncLock 
                'UserBytesToBeSent()
                UserBytesToBeSent.Close()
                UserBytesToBeSent = Nothing
                UserBytesToBeSent = New MemoryStream(bytes)
                UserOutputChannel = channel
                UserBytesToBeSentAvailable = True
                'End SyncLock
                Exit Do
                Return 1
            End If
            Return 1
            If theClientIsStopping() Then Exit Function
            Application.DoEvents()
        Loop
        Return 1
    End Function

    Private Function RcvBytes(ByVal data() As Byte, Optional ByVal dataChannel As Integer = 1) As Boolean
        ' dataType: >0 = data channel, 251 and up = internal messages. 0 is an invalid channel number (it's the puck)

        If dataChannel < 1 Then
            RcvBytes = False
            Exit Function
        End If

        Try
            ClientCallbackObject(data, dataChannel)
        Catch ex As Exception
            RcvBytes = False

            ' An unexpected error.
            Debug.WriteLine("Unexpected error in Client\RcvBytes: " & ex.Message)
        End Try
        Return 1
    End Function

   
    Private Function SendExternalSystemMessage(ByVal message As String) As Boolean

        SystemBytesToBeSent = StrToByteArray(message)
        SystemOutputChannel = 254 ' Text messages / commands on channel 254
        SystemBytesToBeSentAvailable = True
        Return 1

    End Function

    

   

    Private Sub GetMoreFileBytesIfAvailable()
        Dim bytesRead As Integer

        If SendingFile And Not SystemBytesToBeSentAvailable Then
            Try
                If SystemBytesToBeSent.Length <> blockSize Then ReDim SystemBytesToBeSent(blockSize - 1)
                bytesRead = fileReader.Read(SystemBytesToBeSent, 0, blockSize)
                If bytesRead <> blockSize Then ReDim Preserve SystemBytesToBeSent(bytesRead - 1)

                If bytesRead > 0 Then
                    SystemOutputChannel = 252 ' File transfer from client to server
                    SystemBytesToBeSentAvailable = True
                    filebytesSent += bytesRead
                Else

                    ReDim SystemBytesToBeSent(blockSize - 1)
                    SendExternalSystemMessage("<-Done") ' Send the server a completion notice.
                    SystemMessage("<-Done")
                    SendingFile = False

                    ' Clean up
                    fileReader.Close()
                    fileReader = Nothing
                    GC.GetTotalMemory(True)
                End If
            Catch ex As Exception
                SendExternalSystemMessage("ERR: " & ex.Message)

                ' We're finished.
                ReDim SystemBytesToBeSent(blockSize - 1)
                SendingFile = False
                fileReader.Close()
            End Try
        End If

    End Sub


    Private Sub HandleIncomingSystemMessages(ByVal bytes() As Byte, ByVal channel As Int32)

        If channel = 254 Then ' Text commands / messages passed between server and client
            Dim message As String = BytesToString(bytes)
            Dim tmp As String = ""
            
            ' Get File Request: The client wants us to send them a file.
            

            'If message = "->Done" Then
            '    'FinishReceivingTheFile()
            '    SystemMessage("->Done")
            'End If

            ' We've been notified that no file data will be forthcoming.

        ElseIf channel = 251 Then ' reserved.

        End If
    End Sub

    Private Function HandleOutgoingInternalSystemMessage() As Boolean
        Dim tmp(1) As Byte
        HandleOutgoingInternalSystemMessage = False
        Dim _size As Integer

        GetMoreFileBytesIfAvailable()

        ' Handle outgoing system stuff here
        If SystemBytesToBeSentAvailable = True Then
            HandleOutgoingInternalSystemMessage = True
            If SystemBytesToBeSent.Length > blockSize Then
                ' Send Channel
                tmp(0) = SystemOutputChannel
                Stream.Write(tmp, 0, 1)
                bytesSentThisSecond += 1

                ' Send packet size
                _size = blockSize
                tmp = BitConverter.GetBytes(_size)
                Stream.Write(tmp, 0, 2)
                bytesSentThisSecond += 2

                ' Send packet
                Stream.Write(GetSome(SystemBytesToBeSent, blockSize, SystemBytesToBeSentAvailable), 0, _size)
                bytesSentThisSecond += _size
            Else
                ' Send Channel
                tmp(0) = SystemOutputChannel
                Stream.Write(tmp, 0, 1)
                bytesSentThisSecond += 1

                ' Send packet size
                _size = SystemBytesToBeSent.Length
                tmp = BitConverter.GetBytes(_size)
                Stream.Write(tmp, 0, 2)
                bytesSentThisSecond += 2

                ' Send packet
                Stream.Write(SystemBytesToBeSent, 0, _size)
                bytesSentThisSecond += _size
                SystemBytesToBeSentAvailable = False
            End If
        End If

    End Function

    Private Function HandleOutgoingUserData() As Boolean
        Dim tmp(1) As Byte
        Dim _size As UShort
        Dim notify As Boolean = False
        Static packet(0) As Byte

        If UserBytesToBeSentAvailable = True Then
            SyncLock UserBytesToBeSent
                Try
                    If (UserBytesToBeSent.Length - UserBytesToBeSent.Position) > blockSize Then
                        ' Send Channel
                        tmp(0) = UserOutputChannel
                        Stream.Write(tmp, 0, 1)

                        ' Send packet size
                        _size = blockSize
                        tmp = BitConverter.GetBytes(_size)
                        Stream.Write(tmp, 0, 2)

                        ' Send packet
                        If packet.Length <> _size Then ReDim packet(_size - 1)
                        UserBytesToBeSent.Read(packet, 0, _size)
                        'Client.NoDelay = True
                        Stream.Write(packet, 0, _size)
                        bytesSentThisSecond += 3 + _size

                        ' Check to see if we've sent it all...
                        If UserBytesToBeSent.Length = UserBytesToBeSent.Position Then
                            UserBytesToBeSentAvailable = False
                            notify = True
                        End If
                    Else
                        ' Send Channel
                        tmp(0) = UserOutputChannel
                        Stream.Write(tmp, 0, 1)

                        ' Send packet size
                        _size = Convert.ToUInt16(UserBytesToBeSent.Length - UserBytesToBeSent.Position)
                        tmp = BitConverter.GetBytes(_size)
                        Stream.Write(tmp, 0, 2)

                        ' Send packet
                        If packet.Length <> _size Then ReDim packet(_size - 1)
                        UserBytesToBeSent.Read(packet, 0, _size)
                        'Client.NoDelay = True
                        Stream.Write(packet, 0, _size)
                        bytesSentThisSecond += 3 + _size

                        UserBytesToBeSentAvailable = False
                        notify = True
                    End If
                Catch ex As Exception
                    ' Report error attempting to send user data.
                    Debug.WriteLine("Unexpected error in TcpCommClient\HandleOutgoingUserData: " & ex.Message)
                End Try
            End SyncLock

            ' Notify the user that the packet has been sent.
            If notify Then SystemMessage("UBS:" & UserOutputChannel)

            Return True
        Else
            Return False
        End If

    End Function

   
    Private Function GetSome(ByRef bytes() As Byte, ByVal chunkToBreakOff As Integer, _
                             ByRef bytesToBeSentAvailable As Boolean, _
                             Optional ByVal theseAreUserBytes As Boolean = False) As Byte()

        Dim tmp(chunkToBreakOff - 1) As Byte
        Array.Copy(bytes, 0, tmp, 0, chunkToBreakOff)
        GetSome = tmp

        If bytes.Length = chunkToBreakOff Then
            bytesToBeSentAvailable = False
            If theseAreUserBytes Then SystemMessage("UBS")
        Else
            Dim tmp2(bytes.Length - chunkToBreakOff - 1) As Byte
            Array.Copy(bytes, chunkToBreakOff, tmp2, 0, bytes.Length - chunkToBreakOff)
            bytes = tmp2
        End If

    End Function

    Private Sub SystemMessage(ByVal MsgText As String)
        RcvBytes(StrToByteArray(MsgText), 255)
    End Sub

    ' Check to see if our app is closing (set in FormClosing event)
    Private Function theClientIsStopping() As Boolean

        If continue_running = False Then
            theClientIsStopping = True
        Else
            theClientIsStopping = False
        End If

    End Function

    

    Private Sub Run()

        Dim puck(1) As Byte : puck(0) = 0
        Dim theBuffer(blockSize - 1) As Byte
        Dim tmp(1) As Byte
        Dim dataChannel As Integer = 0
        Dim packetSize As UShort = 0
        Dim bytesread As Integer
        Dim userOrSystemSwitcher As Integer = 0
        Dim PercentUsage As Short = -1
        Dim connectionLossTimer As Date

        'Dim CPUutil As New CpuMonitor
        'CPUutil.Start()

        Try

            Client = New TcpClient
            Client.Connect(IP, Port)

            ' Connection Accepted.
            Stream = Client.GetStream()

            ' Set the send and receive buffers to the maximum
            ' size allowable in this application...
            Client.Client.ReceiveBufferSize = 65535
            Client.Client.SendBufferSize = 65535

            ' no delay on partially filled packets...
            ' Send it all as fast as possible.
            Client.NoDelay = True

            ' Pass a message up to the user about our status.
            SystemMessage("Connected.")
            isRunning = True

            ' Start the communication loop
            Do
                ' Check to see if our app is shutting down.
                If theClientIsStopping() Then Exit Do

                ' Normal communications...
                If weHaveThePuck Then
                    ' Send user data if there is any to be sent.
                    userOrSystemSwitcher += 1
                    Select Case userOrSystemSwitcher
                        Case 1
                            HandleOutgoingUserData()
                        Case 2
                            HandleOutgoingInternalSystemMessage()
                    End Select
                    If userOrSystemSwitcher > 1 Then userOrSystemSwitcher = 0

                    ' After sending our data, send the puck
                    Stream.Write(puck, 0, 1)

                    ' Uncomment this to see control bit traffic as part of your Mbps 
                    'bytesSentThisSecond += 1
                    weHaveThePuck = False

                End If

                If theBuffer.Length < 2 Then ReDim theBuffer(1)

                ' Read in the control byte.
                Stream.Read(theBuffer, 0, 1)
                dataChannel = theBuffer(0)

                If dataChannel = 0 Then
                    weHaveThePuck = True
                Else
                    ' It's not the puck: It's an incoming packet.

                    ' Get the packet size:
                    tmp(0) = Convert.ToByte(Stream.ReadByte)
                    tmp(1) = Convert.ToByte(Stream.ReadByte)
                    packetSize = BitConverter.ToUInt16(tmp, 0)
                    If theBuffer.Length <> packetSize Then ReDim theBuffer(packetSize - 1)
                    bytesReceivedThisSecond += 2

                    ' Get the packet:
                    connectionLossTimer = Now
                    Do
                        ' Check to see if we're stopping...
                        If theClientIsStopping() Then Exit Do
                        ' Read bytes in...
                        bytesread += Stream.Read(theBuffer, bytesread, (packetSize - bytesread))

                        ' If it takes longer then 3 seconds to get a packet, we've lost connection.
                        If connectionLossTimer.AddSeconds(3) < Now Then Exit Try

                    Loop While bytesread < packetSize
                    bytesread = 0

                    ' Record bytes read for throttling...
                    bytesReceivedThisSecond += packetSize

                    ' Handle the packet...
                    If dataChannel > 250 Then
                        ' this is an internal system packet
                        HandleIncomingSystemMessages(theBuffer, dataChannel)
                    Else
                        ' Hand data off to the calling thread.
                        RcvBytes(theBuffer, dataChannel)
                    End If

                    If theClientIsStopping() Then Exit Do
                End If


            Loop
        Catch ex As Exception
            ' An unexpected error.
            Debug.WriteLine("Unexpected error in Client\Run: " & ex.Message)
        End Try

        Try
            fileWriter.Close()
        Catch ex As Exception
        End Try

        Try
            'CPUutil.StopWatcher()
            Client.Client.Close()
            SystemMessage("Disconnected.")
        Catch ex As Exception
            ' An unexpected error.
            Debug.WriteLine("Unexpected error in Client\theClientIsStopping: " & ex.Message)
        End Try

        isRunning = False

    End Sub
    
   
End Class
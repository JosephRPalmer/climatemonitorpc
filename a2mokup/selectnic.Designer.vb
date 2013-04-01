<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectnic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.possiblenic = New System.Windows.Forms.ComboBox()
        Me.setnic = New System.Windows.Forms.Button()
        Me.formtext = New System.Windows.Forms.Label()
        Me.refreshniclist = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'possiblenic
        '
        Me.possiblenic.FormattingEnabled = True
        Me.possiblenic.Location = New System.Drawing.Point(12, 48)
        Me.possiblenic.Name = "possiblenic"
        Me.possiblenic.Size = New System.Drawing.Size(305, 21)
        Me.possiblenic.TabIndex = 0
        '
        'setnic
        '
        Me.setnic.Location = New System.Drawing.Point(158, 75)
        Me.setnic.Name = "setnic"
        Me.setnic.Size = New System.Drawing.Size(159, 23)
        Me.setnic.TabIndex = 1
        Me.setnic.Text = "Set"
        Me.setnic.UseVisualStyleBackColor = True
        '
        'formtext
        '
        Me.formtext.AutoSize = True
        Me.formtext.Location = New System.Drawing.Point(12, 13)
        Me.formtext.Name = "formtext"
        Me.formtext.Size = New System.Drawing.Size(250, 13)
        Me.formtext.TabIndex = 2
        Me.formtext.Text = "Select the network interface you wish to connect to"
        '
        'refreshniclist
        '
        Me.refreshniclist.Location = New System.Drawing.Point(15, 75)
        Me.refreshniclist.Name = "refreshniclist"
        Me.refreshniclist.Size = New System.Drawing.Size(137, 22)
        Me.refreshniclist.TabIndex = 3
        Me.refreshniclist.Text = "Refresh"
        Me.refreshniclist.UseVisualStyleBackColor = True
        '
        'selectnic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 114)
        Me.Controls.Add(Me.refreshniclist)
        Me.Controls.Add(Me.formtext)
        Me.Controls.Add(Me.setnic)
        Me.Controls.Add(Me.possiblenic)
        Me.Name = "selectnic"
        Me.Text = "Select Network Interface"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents possiblenic As System.Windows.Forms.ComboBox
    Friend WithEvents setnic As System.Windows.Forms.Button
    Friend WithEvents formtext As System.Windows.Forms.Label
    Friend WithEvents refreshniclist As System.Windows.Forms.Button
End Class

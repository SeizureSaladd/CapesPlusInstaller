<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
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
        Me.FormSkin1 = New CapesPlusInstaller.FormSkin()
        Me.pbSuccess = New System.Windows.Forms.PictureBox()
        Me.FlatButton1 = New CapesPlusInstaller.FlatButton()
        Me.msgLbl = New CapesPlusInstaller.FlatLabel()
        Me.pbError = New System.Windows.Forms.PictureBox()
        Me.titleLbl = New CapesPlusInstaller.FlatLabel()
        Me.FormSkin1.SuspendLayout()
        CType(Me.pbSuccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.pbSuccess)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.msgLbl)
        Me.FormSkin1.Controls.Add(Me.pbError)
        Me.FormSkin1.Controls.Add(Me.titleLbl)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.RoyalBlue
        Me.FormSkin1.Font = New System.Drawing.Font("LOVES", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(471, 223)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Capes+"
        '
        'pbSuccess
        '
        Me.pbSuccess.BackColor = System.Drawing.Color.Transparent
        Me.pbSuccess.Image = Global.CapesPlusInstaller.My.Resources.Resources.success
        Me.pbSuccess.Location = New System.Drawing.Point(12, 59)
        Me.pbSuccess.Name = "pbSuccess"
        Me.pbSuccess.Size = New System.Drawing.Size(50, 50)
        Me.pbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSuccess.TabIndex = 4
        Me.pbSuccess.TabStop = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.RoyalBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("LOVES", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton1.Location = New System.Drawing.Point(353, 177)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton1.TabIndex = 3
        Me.FlatButton1.Text = "OK"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'msgLbl
        '
        Me.msgLbl.BackColor = System.Drawing.Color.Transparent
        Me.msgLbl.Font = New System.Drawing.Font("LOVES", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgLbl.ForeColor = System.Drawing.Color.White
        Me.msgLbl.Location = New System.Drawing.Point(68, 129)
        Me.msgLbl.Name = "msgLbl"
        Me.msgLbl.Size = New System.Drawing.Size(391, 58)
        Me.msgLbl.TabIndex = 2
        Me.msgLbl.Text = "FlatLabel2"
        '
        'pbError
        '
        Me.pbError.BackColor = System.Drawing.Color.Transparent
        Me.pbError.Image = Global.CapesPlusInstaller.My.Resources.Resources._Error
        Me.pbError.Location = New System.Drawing.Point(12, 59)
        Me.pbError.Name = "pbError"
        Me.pbError.Size = New System.Drawing.Size(50, 50)
        Me.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbError.TabIndex = 1
        Me.pbError.TabStop = False
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.BackColor = System.Drawing.Color.Transparent
        Me.titleLbl.Font = New System.Drawing.Font("LOVES", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.ForeColor = System.Drawing.Color.White
        Me.titleLbl.Location = New System.Drawing.Point(68, 81)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(129, 21)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "FlatLabel1"
        '
        'Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 223)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Message"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MsgBox"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.pbSuccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents pbError As PictureBox
    Friend WithEvents titleLbl As FlatLabel
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents msgLbl As FlatLabel
    Friend WithEvents pbSuccess As PictureBox
End Class

Public Class updater
    Dim downloaded As Boolean = False

    Public Function download()
        Try
            My.Computer.Network.DownloadFile("http://35.225.73.246/installer/CapesPlusInstaller.exe", FlatTextBox1.Text)
            downloaded = True
            If downloaded Then
                complete()
            End If
        Catch ex As Exception

        End Try

    End Function

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Function complete()
        Dim result As DialogResult = MessageBox.Show("Update Downloaded! Please Use New Version!", "Update Complete", MessageBoxButtons.OK)
        If (result = DialogResult.OK) Then

            Process.Start(FlatTextBox1.Text)

            Application.Exit()
            End
        End If
    End Function

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            FlatTextBox1.Text = SaveFileDialog.FileName + ".exe"
            Timer1.Start()
        End If
    End Sub

    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(Me.Width, 140)
        SaveFileDialog.Filter = "Application File (*.exe)|"
        FlatButton1.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Do Until Me.Size.Height >= 205
            Me.Size = New Size(Me.Width, Me.Height + 1)
        Loop
        Timer1.Stop()
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        download()
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
End Class
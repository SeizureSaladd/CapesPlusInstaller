Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1

    Dim errorB As Boolean = False
    Dim title As String = ""
    Dim msg As String = ""


    <DllImport("gdi32")>
    Public Shared Function AddFontResource(ByVal lpFileName As String) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As Integer, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Shared Function WriteProfileString(ByVal lpszSection As String, ByVal lpszKeyName As String, ByVal lpszString As String) As Integer
    End Function




    Public Function showMsg(err As Boolean, title As String, msg As String)
        If err Then
            Message.pbError.Show()
            Message.pbSuccess.Hide()
        Else
            Message.pbSuccess.Show()
            Message.pbError.Hide()
        End If

        Message.msgLbl.Text = msg
        Message.titleLbl.Text = title
        Message.ShowDialog()
    End Function

    Dim loc As New Point(213, 64)
    Dim loc2 As New Point(213, 398)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If System.IO.File.Exists("C:\Windows\Fonts\LOVES.ttf") Then
        Else

            Try
                My.Computer.Network.DownloadFile("http://35.225.73.246/installer/LOVES.TTF", "C:\Windows\Fonts\LOVES.ttf")
                Dim Ret As Integer
                Dim Res As Integer
                Dim FontPath As String
                Const WM_FONTCHANGE As Integer = &H1D
                Const HWND_BROADCAST As Integer = &HFFFF
                FontPath = "C:\Windows\Fonts" & "\" & "LOVES.ttf"
                Ret = AddFontResource(FontPath)
                Res = SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0)
                Ret = WriteProfileString("fonts", "LOVES" & " (TrueType)", "LOVES.ttf")

                System.Windows.Forms.Application.Restart()

            Catch ex As Exception

            End Try
            '
        End If
        Me.Size = New Size(675, 400)



        Dim Xpos As Integer = (Panel1.Width / 2) - (PictureBox1.Width / 2)
        Me.PictureBox1.Location = New Point(Xpos, 0)

        Dim Xpos1 As Integer = (pnlInstall.Width / 2) - (PictureBox4.Width / 2)
        PictureBox4.Location = New Point(Xpos1, PictureBox4.Location.Y)

        Dim Xpos2 As Integer = (pnlInstall.Width / 2) - (PictureBox3.Width / 2)
        PictureBox3.Location = New Point(Xpos2, PictureBox3.Location.Y)

        Dim Xpos3 As Integer = (pnlInstall.Width / 2) - (FlatLabel1.Width / 2)
        FlatLabel1.Location = New Point(Xpos3, FlatLabel1.Location.Y)

        Dim Xpos4 As Integer = (pnlInstall.Width / 2) - (InstallBtn.Width / 2)
        InstallBtn.Location = New Point(Xpos4, InstallBtn.Location.Y)


        Dim Xpos5 As Integer = (pnlInstall.Width / 2) - (uninstallBtn.Width / 2)
        uninstallBtn.Location = New Point(Xpos5, uninstallBtn.Location.Y)



        'Home

        Dim Xpos6 As Integer = (pnlHome.Width / 2) - (FlatLabel6.Width / 2)
        FlatLabel6.Location = New Point(Xpos6 - 16, FlatLabel6.Location.Y)

        Dim Xpos7 As Integer = (pnlHome.Width / 2) - (FlatLabel3.Width / 2)
        FlatLabel3.Location = New Point(Xpos7 + 33, FlatLabel3.Location.Y)

        Dim Xpos9 As Integer = (pnlHome.Width / 2) - (PictureBox5.Width / 2)
        PictureBox5.Location = New Point(Xpos9, PictureBox5.Location.Y)

        Dim Xpos10 As Integer = (pnlHome.Width / 2) - (PictureBox6.Width / 2)
        PictureBox6.Location = New Point(Xpos10, PictureBox6.Location.Y)


        'Socials
        Dim Xpos11 As Integer = (pnlCredits.Width / 2) - (PictureBox8.Width / 2)
        PictureBox8.Location = New Point(Xpos11, PictureBox8.Location.Y)

        Dim Xpos12 As Integer = (pnlCredits.Width / 2) - (PictureBox7.Width / 2)
        PictureBox7.Location = New Point(Xpos12, PictureBox7.Location.Y)

        'LABLES
        Dim Xpos13 As Integer = (pnlCredits.Width / 2) - (FlatLabel2.Width / 2)
        FlatLabel2.Location = New Point(Xpos13, FlatLabel2.Location.Y)

        'Btn
        Dim Xpos14 As Integer = (pnlCredits.Width / 2) - (FlatButton1.Width / 2)
        FlatButton1.Location = New Point(Xpos14, FlatButton1.Location.Y)

        Dim Xpos15 As Integer = (pnlCredits.Width / 2) - (FlatButton5.Width / 2)
        FlatButton5.Location = New Point(Xpos15, FlatButton5.Location.Y)

        Dim usersURL As String = "http://35.225.73.246/data/AmountOfCapes.txt"
        Dim usersWc As New System.Net.WebClient
        Dim resUsers As String = usersWc.DownloadString(usersURL)

        cpeUsersLbl.Text = "Capes+ Users: " + resUsers
        FlatLabel6.Text = "Capes+ Users: " + resUsers


        Dim verURL As String = "http://35.225.73.246/installer/version.php"


        Dim wc As New System.Net.WebClient
        Dim version As String = wc.DownloadString(verURL)
        FlatLabel3.Text = "Version: " + status.Text.Replace("Version: ", "")
        If Not status.Text.Replace("Version: ", "") = version Then
            'New update avaliable.
            Dim result As DialogResult = MessageBox.Show("There is A New Update! Would You Like To Update It.", "Outdated Version", MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then
                Me.Hide()
                updater.ShowDialog()

            ElseIf (result = DialogResult.No) Then

            End If

        End If

    End Sub


    Public Function FileLocation() As String


        Return Environment.GetFolderPath(Environment.SpecialFolder.System) + "/drivers/etc/hosts"
    End Function

    Public Sub AppendLine(ByVal ip As String, ByVal url As String, Optional ByVal comment As String = "#no comment")
        Dim path As String = FileLocation()



        'If Not String.IsNullOrWhiteSpace(path) Then
        IO.File.AppendAllLines(path, {String.Format("{0} {1} {2}", ip.ToString, url, comment)})
        'End If

    End Sub

    Public Function checkIfExists()
        Dim allLines As String = ""


        For Each line As String In File.ReadLines(FileLocation)
            allLines = allLines + line + vbNewLine
        Next line



        If allLines.Contains("35.225.73.246 s.optifine.net #CapesPlus") Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function remove()
        Dim newLines As String = ""


        For Each line As String In File.ReadLines(FileLocation)
            If line.Contains("35.225.73.246 s.optifine.net #CapesPlus") Then

            Else
                newLines = newLines + line + vbNewLine
            End If



        Next line

        Dim objWriter As New System.IO.StreamWriter(FileLocation, False)
        objWriter.WriteLine(newLines)
        objWriter.Close()


    End Function

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles InstallBtn.Click

        If checkIfExists() Then
            showMsg(True, "Error", "You Already Have Capes+ Installed")

        Else
            AppendLine("35.225.73.246", "s.optifine.net", "#CapesPlus")
            showMsg(False, "Success", "Capes+ Installed Successfully")

        End If


    End Sub

    Private Sub uninstallBtn_Click(sender As Object, e As EventArgs) Handles uninstallBtn.Click
        If checkIfExists() Then
            'They have it installed
            remove()
            showMsg(False, "Success", "Capes+ Uninstalled Successfully")
        Else
            showMsg(True, "Error", "You Do Not Have Capes+ Installed")
        End If
    End Sub

    Private Sub FlatLabel3_Click(sender As Object, e As EventArgs) Handles FlatLabel3.Click

    End Sub

    Private Sub FlatLabel4_Click(sender As Object, e As EventArgs) Handles FlatLabel4.Click

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Process.Start("https://discord.gg/bYwR786kPf")
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Process.Start("https://www.tiktok.com/@capesplus")
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        pnlHome.Location = loc
        pnlInstall.Location = loc2
        pnlCredits.Location = loc2
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        pnlHome.Location = loc2
        pnlInstall.Location = loc
        pnlCredits.Location = loc2

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        pnlHome.Location = loc2
        pnlInstall.Location = loc2
        pnlCredits.Location = loc
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
End Class

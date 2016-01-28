Public Class frmMain

    Public Structure ChmodRights
        Public octRights As Integer
        Public txtRights As String
    End Structure


    Private Sub chkUserRead_CheckedChanged(sender As Object, e As EventArgs) Handles chkUserRead.CheckedChanged
        CalcOct()


    End Sub

    Private Sub chkUserExecute_CheckedChanged(sender As Object, e As EventArgs) Handles chkUserExecute.CheckedChanged
        CalcOct()

    End Sub


    Private Sub chkUserWrite_CheckedChanged(sender As Object, e As EventArgs) Handles chkUserWrite.CheckedChanged
        CalcOct()

    End Sub

    Private Sub chkGroupRead_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroupRead.CheckedChanged
        CalcOct()

    End Sub
    Private Sub chkGroupWrite_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroupWrite.CheckedChanged
        CalcOct()

    End Sub

    Private Sub chkGroupExecute_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroupExecute.CheckedChanged
        CalcOct()

    End Sub



    Private Sub chkEveryoneRead_CheckedChanged(sender As Object, e As EventArgs) Handles chkEveryoneRead.CheckedChanged
        CalcOct()

    End Sub

    Private Sub chkEveryoneWrite_CheckedChanged(sender As Object, e As EventArgs) Handles chkEveryoneWrite.CheckedChanged
        CalcOct()

    End Sub

    Private Sub chkEveryoneExecute_CheckedChanged(sender As Object, e As EventArgs) Handles chkEveryoneExecute.CheckedChanged
        CalcOct()

    End Sub


    Public Function CalcOct() As ChmodRights

        Dim FileRights As ChmodRights

        Dim OctUser As ChmodRights
        Dim OctGroup As ChmodRights
        Dim OctOther As ChmodRights



        OctUser = valUser()


        OctGroup = valGroup()

        OctOther = valOther()

        FileRights.octRights = OctUser.octRights & OctGroup.octRights & OctOther.octRights
        txtOctal.Text = FileRights.octRights

        FileRights.txtRights = OctUser.txtRights & OctGroup.txtRights & OctOther.txtRights
        txtRwx.Text = FileRights.txtRights

        txtOctCommand.Text = "sudo chmod " & FileRights.octRights & " "
        txtrwxCmd.Text = "currently not supported"

    End Function


    Private Function valUser() As ChmodRights

        Dim UserRead As Boolean
        Dim UserWrite As Boolean
        Dim userExecute As Boolean

        Dim octUser As ChmodRights


        If chkUserRead.Checked Then
            UserRead = True
        Else
            UserRead = False
        End If

        If chkUserWrite.Checked Then
            UserWrite = True
        Else
            UserWrite = False
        End If

        If chkUserExecute.Checked Then
            userExecute = True
        Else
            userExecute = False
        End If

        octUser.octRights = 0
        octUser.txtRights = ""
        If UserRead = True Then
            octUser.octRights = octUser.octRights + 4
            octUser.txtRights = octUser.txtRights & "r"
        Else
            octUser.octRights = octUser.octRights + 0
            octUser.txtRights = octUser.txtRights & "-"
        End If

        If UserWrite = True Then
            octUser.octRights = octUser.octRights + 2
            octUser.txtRights = octUser.txtRights & "w"
        Else
            octUser.octRights = octUser.octRights + 0
            octUser.txtRights = octUser.txtRights & "-"
        End If



        If userExecute = True Then
            octUser.octRights = octUser.octRights + 1
            octUser.txtRights = octUser.txtRights & "x"
        Else
            octUser.octRights = octUser.octRights + 0
            octUser.txtRights = octUser.txtRights & "-"

        End If

        Return OctUser


    End Function

    Private Function valGroup() As ChmodRights

        Dim GroupRead As Boolean
        Dim GroupWrite As Boolean
        Dim GroupExecute As Boolean

        Dim OctGroup As ChmodRights


        If chkGroupRead.Checked Then
            GroupRead = True

        Else
            GroupRead = False
        End If

        If chkGroupWrite.Checked Then
            GroupWrite = True
        Else
            GroupWrite = False
        End If

        If chkGroupExecute.Checked Then
            GroupExecute = True
        Else
            GroupExecute = False
        End If

        OctGroup.octRights = 0
        OctGroup.txtRights = ""
        If GroupRead = True Then
            OctGroup.octRights = OctGroup.octRights + 4
            OctGroup.txtRights = OctGroup.txtRights & "r"
        Else
            OctGroup.octRights = OctGroup.octRights + 0
            OctGroup.txtRights = OctGroup.txtRights & "-"
        End If

        If GroupWrite = True Then
            OctGroup.octRights = OctGroup.octRights + 2
            OctGroup.txtRights = OctGroup.txtRights & "w"
        Else
            OctGroup.octRights = OctGroup.octRights + 0
            OctGroup.txtRights = OctGroup.txtRights & "-"
        End If

        If GroupExecute = True Then
            OctGroup.octRights = OctGroup.octRights + 1
            OctGroup.txtRights = OctGroup.txtRights & "x"
        Else
            OctGroup.octRights = OctGroup.octRights + 0
            OctGroup.txtRights = OctGroup.txtRights & "-"
        End If

        Return OctGroup


    End Function


    Private Function valOther() As ChmodRights

        Dim OtherRead As Boolean
        Dim OtherWrite As Boolean
        Dim otherExecute As Boolean

        Dim OctOther As ChmodRights

        If chkEveryoneRead.Checked Then
            OtherRead = True
        Else
            OtherRead = False
        End If

        If chkEveryoneWrite.Checked Then
            OtherWrite = True
        Else
            OtherWrite = False
        End If

        If chkEveryoneExecute.Checked Then
            otherExecute = True
        Else
            otherExecute = False
        End If

        OctOther.octRights = 0
        OctOther.txtRights = ""

        If OtherRead = True Then
            OctOther.octRights = OctOther.octRights + 4
            OctOther.txtRights = OctOther.txtRights & "r"
        Else
            OctOther.octRights = OctOther.octRights + 0
            OctOther.txtRights = OctOther.txtRights & "-"
        End If

        If OtherWrite = True Then
            OctOther.octRights = OctOther.octRights + 2
            OctOther.txtRights = OctOther.txtRights & "w"
        Else
            OctOther.octRights = OctOther.octRights + 0
            OctOther.txtRights = OctOther.txtRights & "-"
        End If

        If otherExecute = True Then
            OctOther.octRights = OctOther.octRights + 1

            OctOther.txtRights = OctOther.txtRights & "x"
        Else
            OctOther.octRights = OctOther.octRights + 0
            OctOther.txtRights = OctOther.txtRights & "-"
        End If

        Return OctOther


    End Function

    Private Sub btnOct_Click(sender As Object, e As EventArgs) Handles btnOct.Click
        Clipboard.SetText(txtOctal.Text)
    End Sub

    Private Sub btnRwx_Click(sender As Object, e As EventArgs) Handles btnRwx.Click
        Clipboard.SetText(txtRwx.Text)
    End Sub

    Private Sub btnOctCmd_Click(sender As Object, e As EventArgs) Handles btnOctCmd.Click
        Clipboard.SetText(txtOctCommand.Text)
    End Sub

    Private Sub btnrwxCmd_Click(sender As Object, e As EventArgs) Handles btnrwxCmd.Click
        Clipboard.SetText(txtrwxCmd.Text)
    End Sub
End Class

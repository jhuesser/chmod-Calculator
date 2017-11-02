Public Class frmMain

    '---------------------------------
    '   Objects
    '---------------------------------
    Private _calc As CoreComps
    '----------------------------------

    Private Sub chkUserRead_CheckedChanged(sender As Object, e As EventArgs) Handles chkUserRead.CheckedChanged
        _calc.CalcOct()


    End Sub

    Private Sub chkUserExecute_CheckedChanged(sender As Object, e As EventArgs) Handles chkUserExecute.CheckedChanged
        _calc.CalcOct()

    End Sub


    Private Sub chkUserWrite_CheckedChanged(sender As Object, e As EventArgs) Handles chkUserWrite.CheckedChanged
        _calc.CalcOct()

    End Sub

    Private Sub chkGroupRead_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroupRead.CheckedChanged
        _calc.CalcOct()

    End Sub
    Private Sub chkGroupWrite_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroupWrite.CheckedChanged
        _calc.CalcOct()

    End Sub

    Private Sub chkGroupExecute_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroupExecute.CheckedChanged
        _calc.CalcOct()

    End Sub



    Private Sub chkEveryoneRead_CheckedChanged(sender As Object, e As EventArgs) Handles chkEveryoneRead.CheckedChanged
        _calc.CalcOct()

    End Sub

    Private Sub chkEveryoneWrite_CheckedChanged(sender As Object, e As EventArgs) Handles chkEveryoneWrite.CheckedChanged
        _calc.CalcOct()

    End Sub

    Private Sub chkEveryoneExecute_CheckedChanged(sender As Object, e As EventArgs) Handles chkEveryoneExecute.CheckedChanged
        _calc.CalcOct()

    End Sub


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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create new Instance of calc
        _calc = New CoreComps

        ' Set its properties
        ' Checkboxes
        _calc.ChkEveryoneExecute = chkEveryoneExecute
        _calc.ChkEveryoneRead = chkEveryoneRead
        _calc.ChkEveryoneWrite = chkEveryoneWrite
        _calc.ChkGroupExecute = chkGroupExecute
        _calc.ChkGroupRead = chkGroupRead
        _calc.ChkGroupWrite = chkGroupWrite
        _calc.ChkUserExecute = chkUserExecute
        _calc.ChkUserRead = chkUserRead
        _calc.ChkUserWrite = chkUserWrite

        ' Textboxes
        _calc.TxtOctal = txtOctal
        _calc.TxtOctCommand = txtOctCommand
        _calc.TxtRwx = txtRwx
        _calc.TxtrwxCmd = txtrwxCmd
    End Sub
End Class

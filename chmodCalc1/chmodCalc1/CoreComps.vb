Public Class CoreComps
    Implements IDisposable

    Private _txtOctal As TextBox
    Private _txtRwx As TextBox
    Private _txtOctCommand As TextBox
    Private _txtrwxCmd As TextBox
    Private _chkUserRead As CheckBox
    Private _chkUserWrite As CheckBox
    Private _chkUserExecute As CheckBox
    Private _chkGroupRead As CheckBox
    Private _chkGroupWrite As CheckBox
    Private _chkGroupExecute As CheckBox
    Private _chkEveryoneRead As CheckBox
    Private _chkEveryoneWrite As CheckBox
    Private _chkEveryoneExecute As CheckBox

    Public Property TxtOctal As TextBox
        Get
            Return _txtOctal
        End Get
        Set(value As TextBox)
            _txtOctal = value
        End Set
    End Property

    Public Property TxtRwx As TextBox
        Get
            Return _txtRwx
        End Get
        Set(value As TextBox)
            _txtRwx = value
        End Set
    End Property

    Public Property TxtOctCommand As TextBox
        Get
            Return _txtOctCommand
        End Get
        Set(value As TextBox)
            _txtOctCommand = value
        End Set
    End Property

    Public Property TxtrwxCmd As TextBox
        Get
            Return _txtrwxCmd
        End Get
        Set(value As TextBox)
            _txtrwxCmd = value
        End Set
    End Property

    Public Property ChkUserRead As CheckBox
        Get
            Return _chkUserRead
        End Get
        Set(value As CheckBox)
            _chkUserRead = value
        End Set
    End Property

    Public Property ChkUserWrite As CheckBox
        Get
            Return _chkUserWrite
        End Get
        Set(value As CheckBox)
            _chkUserWrite = value
        End Set
    End Property

    Public Property ChkUserExecute As CheckBox
        Get
            Return _chkUserExecute
        End Get
        Set(value As CheckBox)
            _chkUserExecute = value
        End Set
    End Property

    Public Property ChkGroupRead As CheckBox
        Get
            Return _chkGroupRead
        End Get
        Set(value As CheckBox)
            _chkGroupRead = value
        End Set
    End Property

    Public Property ChkGroupWrite As CheckBox
        Get
            Return _chkGroupWrite
        End Get
        Set(value As CheckBox)
            _chkGroupWrite = value
        End Set
    End Property

    Public Property ChkGroupExecute As CheckBox
        Get
            Return _chkGroupExecute
        End Get
        Set(value As CheckBox)
            _chkGroupExecute = value
        End Set
    End Property

    Public Property ChkEveryoneRead As CheckBox
        Get
            Return _chkEveryoneRead
        End Get
        Set(value As CheckBox)
            _chkEveryoneRead = value
        End Set
    End Property

    Public Property ChkEveryoneWrite As CheckBox
        Get
            Return _chkEveryoneWrite
        End Get
        Set(value As CheckBox)
            _chkEveryoneWrite = value
        End Set
    End Property

    Public Property ChkEveryoneExecute As CheckBox
        Get
            Return _chkEveryoneExecute
        End Get
        Set(value As CheckBox)
            _chkEveryoneExecute = value
        End Set
    End Property

    Public Sub New()
        _chkEveryoneExecute = New CheckBox
        _chkEveryoneRead = New CheckBox
        _chkEveryoneWrite = New CheckBox
        _chkGroupExecute = New CheckBox
        _chkGroupRead = New CheckBox
        _chkGroupWrite = New CheckBox
        _chkUserExecute = New CheckBox
        _chkUserRead = New CheckBox
        _chkUserWrite = New CheckBox

        _txtOctal = New TextBox
        _txtOctCommand = New TextBox
        _txtRwx = New TextBox
        _txtrwxCmd = New TextBox
    End Sub

    Public Structure ChmodRights
        Public octRights As Integer
        Public txtRights As String
    End Structure

    Public Structure textRights
        Public user As String
        Public group As String
        Public other As String
    End Structure

    Public Function CalcOct() As ChmodRights

        Dim FileRights As ChmodRights

        Dim OctUser As ChmodRights
        Dim OctGroup As ChmodRights
        Dim OctOther As ChmodRights
        Dim finalRights As textRights


        OctUser = valUser()


        OctGroup = valGroup()

        OctOther = valOther()

        FileRights.octRights = OctUser.octRights & OctGroup.octRights & OctOther.octRights
        _txtOctal.Text = FileRights.octRights

        FileRights.txtRights = OctUser.txtRights & OctGroup.txtRights & OctOther.txtRights
        _txtRwx.Text = FileRights.txtRights

        _txtOctCommand.Text = "sudo chmod " & FileRights.octRights & " "

        finalRights.user = cutRights(OctUser.txtRights)
        finalRights.group = cutRights(OctGroup.txtRights)
        finalRights.other = cutRights(OctOther.txtRights)

        If finalRights.user IsNot "" And finalRights.group IsNot "" And finalRights.other IsNot "" Then
            _txtrwxCmd.Text = "sudo chmod u+" & finalRights.user & " g+" & finalRights.group & " o+" & finalRights.other

        ElseIf finalRights.user Is "" And finalRights.group IsNot "" And finalRights.other IsNot "" Then
            _txtrwxCmd.Text = "sudo chmod g+" & finalRights.group & " o+" & finalRights.other


        ElseIf finalRights.user IsNot "" And finalRights.group Is "" And finalRights.other IsNot "" Then
            _txtrwxCmd.Text = "sudo chmod u+" & finalRights.user & " o+" & finalRights.other

        ElseIf finalRights.user IsNot "" And finalRights.group IsNot "" And finalRights.other Is "" Then
            _txtrwxCmd.Text = "sudo chmod u+" & finalRights.user & " g+" & finalRights.group

        ElseIf finalRights.user Is "" And finalRights.group Is "" And finalRights.other IsNot "" Then
            _txtrwxCmd.Text = "sudo chmod o+" & finalRights.other

        ElseIf finalRights.user Is "" And finalRights.group IsNot "" And finalRights.other Is "" Then
            _txtrwxCmd.Text = "sudo chmod g+" & finalRights.group

        ElseIf finalRights.user IsNot "" And finalRights.group Is "" And finalRights.other Is "" Then
            _txtrwxCmd.Text = "sudo chmod u+" & finalRights.user

        End If



    End Function


    Private Function valUser() As ChmodRights

        Dim UserRead As Boolean
        Dim UserWrite As Boolean
        Dim userExecute As Boolean

        Dim octUser As ChmodRights


        If _chkUserRead.Checked Then
            UserRead = True
        Else
            UserRead = False
        End If

        If _chkUserWrite.Checked Then
            UserWrite = True
        Else
            UserWrite = False
        End If

        If _chkUserExecute.Checked Then
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

        Return octUser


    End Function

    Private Function valGroup() As ChmodRights

        Dim GroupRead As Boolean
        Dim GroupWrite As Boolean
        Dim GroupExecute As Boolean

        Dim OctGroup As ChmodRights


        If _chkGroupRead.Checked Then
            GroupRead = True

        Else
            GroupRead = False
        End If

        If _chkGroupWrite.Checked Then
            GroupWrite = True
        Else
            GroupWrite = False
        End If

        If _chkGroupExecute.Checked Then
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

        If _chkEveryoneRead.Checked Then
            OtherRead = True
        Else
            OtherRead = False
        End If

        If _chkEveryoneWrite.Checked Then
            OtherWrite = True
        Else
            OtherWrite = False
        End If

        If _chkEveryoneExecute.Checked Then
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

    Private Function cutRights(Rights As String)



        Rights = Rights.Replace("-", "")


        Return Rights

    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' Dient zur Erkennung redundanter Aufrufe.

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                _chkEveryoneExecute = Nothing
                _chkEveryoneRead = Nothing
                _chkEveryoneWrite = Nothing
                _chkGroupExecute = Nothing
                _chkGroupRead = Nothing
                _chkGroupWrite = Nothing
                _chkUserExecute = Nothing
                _chkUserRead = Nothing
                _chkUserWrite = Nothing

                _txtOctal = Nothing
                _txtOctCommand = Nothing
                _txtRwx = Nothing
                _txtrwxCmd = Nothing
            End If


            ' TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalize() weiter unten überschreiben.
            ' TODO: große Felder auf Null setzen.
        End If
        disposedValue = True
    End Sub

    ' TODO: Finalize() nur überschreiben, wenn Dispose(disposing As Boolean) weiter oben Code zur Bereinigung nicht verwalteter Ressourcen enthält.
    'Protected Overrides Sub Finalize()
    '    ' Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(disposing As Boolean) weiter oben ein.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Dieser Code wird von Visual Basic hinzugefügt, um das Dispose-Muster richtig zu implementieren.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(disposing As Boolean) weiter oben ein.
        Dispose(True)
        ' TODO: Auskommentierung der folgenden Zeile aufheben, wenn Finalize() oben überschrieben wird.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class

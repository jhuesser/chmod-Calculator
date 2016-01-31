<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblEveryone = New System.Windows.Forms.Label()
        Me.chkUserRead = New System.Windows.Forms.CheckBox()
        Me.chkUserWrite = New System.Windows.Forms.CheckBox()
        Me.chkUserExecute = New System.Windows.Forms.CheckBox()
        Me.chkGroupExecute = New System.Windows.Forms.CheckBox()
        Me.chkGroupWrite = New System.Windows.Forms.CheckBox()
        Me.chkGroupRead = New System.Windows.Forms.CheckBox()
        Me.chkEveryoneExecute = New System.Windows.Forms.CheckBox()
        Me.chkEveryoneWrite = New System.Windows.Forms.CheckBox()
        Me.chkEveryoneRead = New System.Windows.Forms.CheckBox()
        Me.txtOctal = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.btnOct = New System.Windows.Forms.Button()
        Me.lblrwx = New System.Windows.Forms.Label()
        Me.txtRwx = New System.Windows.Forms.TextBox()
        Me.btnRwx = New System.Windows.Forms.Button()
        Me.lblCommands = New System.Windows.Forms.Label()
        Me.txtOctCommand = New System.Windows.Forms.TextBox()
        Me.btnOctCmd = New System.Windows.Forms.Button()
        Me.txtrwxCmd = New System.Windows.Forms.TextBox()
        Me.btnrwxCmd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(13, 13)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(84, 37)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "User"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.Location = New System.Drawing.Point(103, 13)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(107, 37)
        Me.lblGroup.TabIndex = 1
        Me.lblGroup.Text = "Group"
        '
        'lblEveryone
        '
        Me.lblEveryone.AutoSize = True
        Me.lblEveryone.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEveryone.Location = New System.Drawing.Point(216, 13)
        Me.lblEveryone.Name = "lblEveryone"
        Me.lblEveryone.Size = New System.Drawing.Size(97, 37)
        Me.lblEveryone.TabIndex = 2
        Me.lblEveryone.Text = "Other"
        '
        'chkUserRead
        '
        Me.chkUserRead.AutoSize = True
        Me.chkUserRead.Location = New System.Drawing.Point(20, 54)
        Me.chkUserRead.Name = "chkUserRead"
        Me.chkUserRead.Size = New System.Drawing.Size(52, 17)
        Me.chkUserRead.TabIndex = 3
        Me.chkUserRead.Text = "Read"
        Me.chkUserRead.UseVisualStyleBackColor = True
        '
        'chkUserWrite
        '
        Me.chkUserWrite.AutoSize = True
        Me.chkUserWrite.Location = New System.Drawing.Point(20, 77)
        Me.chkUserWrite.Name = "chkUserWrite"
        Me.chkUserWrite.Size = New System.Drawing.Size(51, 17)
        Me.chkUserWrite.TabIndex = 4
        Me.chkUserWrite.Text = "Write"
        Me.chkUserWrite.UseVisualStyleBackColor = True
        '
        'chkUserExecute
        '
        Me.chkUserExecute.AutoSize = True
        Me.chkUserExecute.Location = New System.Drawing.Point(20, 101)
        Me.chkUserExecute.Name = "chkUserExecute"
        Me.chkUserExecute.Size = New System.Drawing.Size(65, 17)
        Me.chkUserExecute.TabIndex = 5
        Me.chkUserExecute.Text = "Execute"
        Me.chkUserExecute.UseVisualStyleBackColor = True
        '
        'chkGroupExecute
        '
        Me.chkGroupExecute.AutoSize = True
        Me.chkGroupExecute.Location = New System.Drawing.Point(110, 101)
        Me.chkGroupExecute.Name = "chkGroupExecute"
        Me.chkGroupExecute.Size = New System.Drawing.Size(65, 17)
        Me.chkGroupExecute.TabIndex = 8
        Me.chkGroupExecute.Text = "Execute"
        Me.chkGroupExecute.UseVisualStyleBackColor = True
        '
        'chkGroupWrite
        '
        Me.chkGroupWrite.AutoSize = True
        Me.chkGroupWrite.Location = New System.Drawing.Point(110, 77)
        Me.chkGroupWrite.Name = "chkGroupWrite"
        Me.chkGroupWrite.Size = New System.Drawing.Size(51, 17)
        Me.chkGroupWrite.TabIndex = 7
        Me.chkGroupWrite.Text = "Write"
        Me.chkGroupWrite.UseVisualStyleBackColor = True
        '
        'chkGroupRead
        '
        Me.chkGroupRead.AutoSize = True
        Me.chkGroupRead.Location = New System.Drawing.Point(110, 54)
        Me.chkGroupRead.Name = "chkGroupRead"
        Me.chkGroupRead.Size = New System.Drawing.Size(52, 17)
        Me.chkGroupRead.TabIndex = 6
        Me.chkGroupRead.Text = "Read"
        Me.chkGroupRead.UseVisualStyleBackColor = True
        '
        'chkEveryoneExecute
        '
        Me.chkEveryoneExecute.AutoSize = True
        Me.chkEveryoneExecute.Location = New System.Drawing.Point(223, 101)
        Me.chkEveryoneExecute.Name = "chkEveryoneExecute"
        Me.chkEveryoneExecute.Size = New System.Drawing.Size(65, 17)
        Me.chkEveryoneExecute.TabIndex = 11
        Me.chkEveryoneExecute.Text = "Execute"
        Me.chkEveryoneExecute.UseVisualStyleBackColor = True
        '
        'chkEveryoneWrite
        '
        Me.chkEveryoneWrite.AutoSize = True
        Me.chkEveryoneWrite.Location = New System.Drawing.Point(223, 77)
        Me.chkEveryoneWrite.Name = "chkEveryoneWrite"
        Me.chkEveryoneWrite.Size = New System.Drawing.Size(51, 17)
        Me.chkEveryoneWrite.TabIndex = 10
        Me.chkEveryoneWrite.Text = "Write"
        Me.chkEveryoneWrite.UseVisualStyleBackColor = True
        '
        'chkEveryoneRead
        '
        Me.chkEveryoneRead.AutoSize = True
        Me.chkEveryoneRead.Location = New System.Drawing.Point(223, 54)
        Me.chkEveryoneRead.Name = "chkEveryoneRead"
        Me.chkEveryoneRead.Size = New System.Drawing.Size(52, 17)
        Me.chkEveryoneRead.TabIndex = 9
        Me.chkEveryoneRead.Text = "Read"
        Me.chkEveryoneRead.UseVisualStyleBackColor = True
        '
        'txtOctal
        '
        Me.txtOctal.Location = New System.Drawing.Point(79, 135)
        Me.txtOctal.Name = "txtOctal"
        Me.txtOctal.ReadOnly = True
        Me.txtOctal.Size = New System.Drawing.Size(209, 20)
        Me.txtOctal.TabIndex = 12
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(17, 142)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(32, 13)
        Me.lblNumber.TabIndex = 13
        Me.lblNumber.Text = "Octal"
        '
        'btnOct
        '
        Me.btnOct.Location = New System.Drawing.Point(291, 133)
        Me.btnOct.Name = "btnOct"
        Me.btnOct.Size = New System.Drawing.Size(75, 23)
        Me.btnOct.TabIndex = 14
        Me.btnOct.Text = "Copy"
        Me.btnOct.UseVisualStyleBackColor = True
        '
        'lblrwx
        '
        Me.lblrwx.AutoSize = True
        Me.lblrwx.Location = New System.Drawing.Point(22, 174)
        Me.lblrwx.Name = "lblrwx"
        Me.lblrwx.Size = New System.Drawing.Size(23, 13)
        Me.lblrwx.TabIndex = 15
        Me.lblrwx.Text = "rwx"
        '
        'txtRwx
        '
        Me.txtRwx.Location = New System.Drawing.Point(79, 168)
        Me.txtRwx.Name = "txtRwx"
        Me.txtRwx.ReadOnly = True
        Me.txtRwx.Size = New System.Drawing.Size(209, 20)
        Me.txtRwx.TabIndex = 16
        '
        'btnRwx
        '
        Me.btnRwx.Location = New System.Drawing.Point(291, 165)
        Me.btnRwx.Name = "btnRwx"
        Me.btnRwx.Size = New System.Drawing.Size(75, 23)
        Me.btnRwx.TabIndex = 17
        Me.btnRwx.Text = "Copy"
        Me.btnRwx.UseVisualStyleBackColor = True
        '
        'lblCommands
        '
        Me.lblCommands.AutoSize = True
        Me.lblCommands.Location = New System.Drawing.Point(17, 212)
        Me.lblCommands.Name = "lblCommands"
        Me.lblCommands.Size = New System.Drawing.Size(59, 13)
        Me.lblCommands.TabIndex = 18
        Me.lblCommands.Text = "Commands"
        '
        'txtOctCommand
        '
        Me.txtOctCommand.Location = New System.Drawing.Point(79, 205)
        Me.txtOctCommand.Name = "txtOctCommand"
        Me.txtOctCommand.ReadOnly = True
        Me.txtOctCommand.Size = New System.Drawing.Size(209, 20)
        Me.txtOctCommand.TabIndex = 19
        '
        'btnOctCmd
        '
        Me.btnOctCmd.Location = New System.Drawing.Point(291, 202)
        Me.btnOctCmd.Name = "btnOctCmd"
        Me.btnOctCmd.Size = New System.Drawing.Size(75, 23)
        Me.btnOctCmd.TabIndex = 20
        Me.btnOctCmd.Text = "Copy"
        Me.btnOctCmd.UseVisualStyleBackColor = True
        '
        'txtrwxCmd
        '
        Me.txtrwxCmd.Location = New System.Drawing.Point(79, 231)
        Me.txtrwxCmd.Name = "txtrwxCmd"
        Me.txtrwxCmd.ReadOnly = True
        Me.txtrwxCmd.Size = New System.Drawing.Size(209, 20)
        Me.txtrwxCmd.TabIndex = 21
        '
        'btnrwxCmd
        '
        Me.btnrwxCmd.Location = New System.Drawing.Point(291, 231)
        Me.btnrwxCmd.Name = "btnrwxCmd"
        Me.btnrwxCmd.Size = New System.Drawing.Size(75, 23)
        Me.btnrwxCmd.TabIndex = 22
        Me.btnrwxCmd.Text = "Copy"
        Me.btnrwxCmd.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 265)
        Me.Controls.Add(Me.btnrwxCmd)
        Me.Controls.Add(Me.txtrwxCmd)
        Me.Controls.Add(Me.btnOctCmd)
        Me.Controls.Add(Me.txtOctCommand)
        Me.Controls.Add(Me.lblCommands)
        Me.Controls.Add(Me.btnRwx)
        Me.Controls.Add(Me.txtRwx)
        Me.Controls.Add(Me.lblrwx)
        Me.Controls.Add(Me.btnOct)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.txtOctal)
        Me.Controls.Add(Me.chkEveryoneExecute)
        Me.Controls.Add(Me.chkEveryoneWrite)
        Me.Controls.Add(Me.chkEveryoneRead)
        Me.Controls.Add(Me.chkGroupExecute)
        Me.Controls.Add(Me.chkGroupWrite)
        Me.Controls.Add(Me.chkGroupRead)
        Me.Controls.Add(Me.chkUserExecute)
        Me.Controls.Add(Me.chkUserWrite)
        Me.Controls.Add(Me.chkUserRead)
        Me.Controls.Add(Me.lblEveryone)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "chmod Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents lblEveryone As Label
    Friend WithEvents chkUserRead As CheckBox
    Friend WithEvents chkUserWrite As CheckBox
    Friend WithEvents chkUserExecute As CheckBox
    Friend WithEvents chkGroupExecute As CheckBox
    Friend WithEvents chkGroupWrite As CheckBox
    Friend WithEvents chkGroupRead As CheckBox
    Friend WithEvents chkEveryoneExecute As CheckBox
    Friend WithEvents chkEveryoneWrite As CheckBox
    Friend WithEvents chkEveryoneRead As CheckBox
    Friend WithEvents txtOctal As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents btnOct As Button
    Friend WithEvents lblrwx As Label
    Friend WithEvents txtRwx As TextBox
    Friend WithEvents btnRwx As Button
    Friend WithEvents lblCommands As Label
    Friend WithEvents txtOctCommand As TextBox
    Friend WithEvents btnOctCmd As Button
    Friend WithEvents txtrwxCmd As TextBox
    Friend WithEvents btnrwxCmd As Button
End Class

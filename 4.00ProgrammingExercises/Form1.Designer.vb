<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloagain
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
        Me.lblEnteryourname = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnSayhello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnteryourname
        '
        Me.lblEnteryourname.AutoSize = True
        Me.lblEnteryourname.Location = New System.Drawing.Point(12, 28)
        Me.lblEnteryourname.Name = "lblEnteryourname"
        Me.lblEnteryourname.Size = New System.Drawing.Size(88, 13)
        Me.lblEnteryourname.TabIndex = 0
        Me.lblEnteryourname.Text = "Enter Your Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'lblHello
        '
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(12, 59)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(198, 42)
        Me.lblHello.TabIndex = 2
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSayhello
        '
        Me.btnSayhello.Location = New System.Drawing.Point(73, 115)
        Me.btnSayhello.Name = "btnSayhello"
        Me.btnSayhello.Size = New System.Drawing.Size(75, 23)
        Me.btnSayhello.TabIndex = 3
        Me.btnSayhello.Text = "Say Hello"
        Me.btnSayhello.UseVisualStyleBackColor = True
        '
        'frmHelloagain
        '
        Me.AcceptButton = Me.btnSayhello
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 161)
        Me.Controls.Add(Me.btnSayhello)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEnteryourname)
        Me.Name = "frmHelloagain"
        Me.Text = "Hello Again"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnteryourname As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblHello As Label
    Friend WithEvents btnSayhello As Button
End Class

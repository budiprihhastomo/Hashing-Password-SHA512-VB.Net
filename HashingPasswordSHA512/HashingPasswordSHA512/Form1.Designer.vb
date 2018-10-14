<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lbGenerate = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.lbHashing = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.richTextHashing = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hashing64 = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGenerate.Location = New System.Drawing.Point(242, 69)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(85, 32)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate It !"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(12, 72)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(215, 24)
        Me.txtPassword.TabIndex = 1
        '
        'lbGenerate
        '
        Me.lbGenerate.AutoSize = True
        Me.lbGenerate.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGenerate.Location = New System.Drawing.Point(7, 9)
        Me.lbGenerate.Name = "lbGenerate"
        Me.lbGenerate.Size = New System.Drawing.Size(278, 25)
        Me.lbGenerate.TabIndex = 2
        Me.lbGenerate.Text = "Password Hashing SHA512"
        '
        'lbPassword
        '
        Me.lbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassword.Location = New System.Drawing.Point(12, 121)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(315, 34)
        Me.lbPassword.TabIndex = 3
        Me.lbPassword.Text = "Password :"
        '
        'lbHashing
        '
        Me.lbHashing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHashing.Location = New System.Drawing.Point(12, 155)
        Me.lbHashing.Name = "lbHashing"
        Me.lbHashing.Size = New System.Drawing.Size(315, 21)
        Me.lbHashing.TabIndex = 3
        Me.lbHashing.Text = "Hashing :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 362)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(339, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(322, 17)
        Me.ToolStripStatusLabel1.Text = "Created By : Budi Prih Hastomo | SMK Negeri 2 Karanganyar"
        '
        'richTextHashing
        '
        Me.richTextHashing.Location = New System.Drawing.Point(15, 179)
        Me.richTextHashing.Name = "richTextHashing"
        Me.richTextHashing.ReadOnly = True
        Me.richTextHashing.Size = New System.Drawing.Size(312, 66)
        Me.richTextHashing.TabIndex = 5
        Me.richTextHashing.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ToBase64 :"
        '
        'Hashing64
        '
        Me.Hashing64.Location = New System.Drawing.Point(15, 285)
        Me.Hashing64.Name = "Hashing64"
        Me.Hashing64.ReadOnly = True
        Me.Hashing64.Size = New System.Drawing.Size(312, 66)
        Me.Hashing64.TabIndex = 5
        Me.Hashing64.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 384)
        Me.Controls.Add(Me.Hashing64)
        Me.Controls.Add(Me.richTextHashing)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbHashing)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbGenerate)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnGenerate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Hash Password "
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lbGenerate As System.Windows.Forms.Label
    Friend WithEvents lbPassword As System.Windows.Forms.Label
    Friend WithEvents lbHashing As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents richTextHashing As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Hashing64 As System.Windows.Forms.RichTextBox

End Class

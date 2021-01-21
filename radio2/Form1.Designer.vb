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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radWinnipeg = New System.Windows.Forms.RadioButton()
        Me.radSydney = New System.Windows.Forms.RadioButton()
        Me.radLondon = New System.Windows.Forms.RadioButton()
        Me.radChicago = New System.Windows.Forms.RadioButton()
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lblInfo3 = New System.Windows.Forms.Label()
        Me.lblInfo4 = New System.Windows.Forms.Label()
        Me.btnVisit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radChicago)
        Me.GroupBox1.Controls.Add(Me.radLondon)
        Me.GroupBox1.Controls.Add(Me.radSydney)
        Me.GroupBox1.Controls.Add(Me.radWinnipeg)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(216, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 273)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destination"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblInfo4)
        Me.GroupBox2.Controls.Add(Me.lblInfo3)
        Me.GroupBox2.Controls.Add(Me.lblInfo2)
        Me.GroupBox2.Controls.Add(Me.lblInfo1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(658, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 273)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Attractions"
        '
        'radWinnipeg
        '
        Me.radWinnipeg.AutoSize = True
        Me.radWinnipeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWinnipeg.Location = New System.Drawing.Point(6, 35)
        Me.radWinnipeg.Name = "radWinnipeg"
        Me.radWinnipeg.Size = New System.Drawing.Size(93, 24)
        Me.radWinnipeg.TabIndex = 0
        Me.radWinnipeg.TabStop = True
        Me.radWinnipeg.Text = "Winnipeg"
        Me.radWinnipeg.UseVisualStyleBackColor = True
        '
        'radSydney
        '
        Me.radSydney.AutoSize = True
        Me.radSydney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSydney.Location = New System.Drawing.Point(6, 77)
        Me.radSydney.Name = "radSydney"
        Me.radSydney.Size = New System.Drawing.Size(79, 24)
        Me.radSydney.TabIndex = 1
        Me.radSydney.TabStop = True
        Me.radSydney.Text = "Sydney"
        Me.radSydney.UseVisualStyleBackColor = True
        '
        'radLondon
        '
        Me.radLondon.AutoSize = True
        Me.radLondon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLondon.Location = New System.Drawing.Point(6, 119)
        Me.radLondon.Name = "radLondon"
        Me.radLondon.Size = New System.Drawing.Size(81, 24)
        Me.radLondon.TabIndex = 2
        Me.radLondon.TabStop = True
        Me.radLondon.Text = "London"
        Me.radLondon.UseVisualStyleBackColor = True
        '
        'radChicago
        '
        Me.radChicago.AutoSize = True
        Me.radChicago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChicago.Location = New System.Drawing.Point(6, 161)
        Me.radChicago.Name = "radChicago"
        Me.radChicago.Size = New System.Drawing.Size(85, 24)
        Me.radChicago.TabIndex = 3
        Me.radChicago.TabStop = True
        Me.radChicago.Text = "Chicago"
        Me.radChicago.UseVisualStyleBackColor = True
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo1.Location = New System.Drawing.Point(7, 34)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(134, 20)
        Me.lblInfo1.TabIndex = 0
        Me.lblInfo1.Text = "Maples Collegiate"
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo2.Location = New System.Drawing.Point(7, 76)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(80, 20)
        Me.lblInfo2.TabIndex = 1
        Me.lblInfo2.Text = "The Forks"
        '
        'lblInfo3
        '
        Me.lblInfo3.AutoSize = True
        Me.lblInfo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo3.Location = New System.Drawing.Point(7, 118)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(121, 20)
        Me.lblInfo3.TabIndex = 2
        Me.lblInfo3.Text = "Osborne Village"
        '
        'lblInfo4
        '
        Me.lblInfo4.AutoSize = True
        Me.lblInfo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo4.Location = New System.Drawing.Point(7, 160)
        Me.lblInfo4.Name = "lblInfo4"
        Me.lblInfo4.Size = New System.Drawing.Size(194, 20)
        Me.lblInfo4.TabIndex = 3
        Me.lblInfo4.Text = "Museum of Human Rights"
        '
        'btnVisit
        '
        Me.btnVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisit.Location = New System.Drawing.Point(-2, 367)
        Me.btnVisit.Name = "btnVisit"
        Me.btnVisit.Size = New System.Drawing.Size(1161, 82)
        Me.btnVisit.TabIndex = 2
        Me.btnVisit.Text = "VISIT!"
        Me.btnVisit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 445)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVisit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radChicago As System.Windows.Forms.RadioButton
    Friend WithEvents radLondon As System.Windows.Forms.RadioButton
    Friend WithEvents radSydney As System.Windows.Forms.RadioButton
    Friend WithEvents radWinnipeg As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInfo4 As System.Windows.Forms.Label
    Friend WithEvents lblInfo3 As System.Windows.Forms.Label
    Friend WithEvents lblInfo2 As System.Windows.Forms.Label
    Friend WithEvents lblInfo1 As System.Windows.Forms.Label
    Friend WithEvents btnVisit As System.Windows.Forms.Button

End Class

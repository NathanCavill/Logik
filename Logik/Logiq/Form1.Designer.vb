<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.CheckBoxA = New System.Windows.Forms.CheckBox()
        Me.CheckBoxB = New System.Windows.Forms.CheckBox()
        Me.RadioButtonAND = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOR = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNOT = New System.Windows.Forms.RadioButton()
        Me.RadioButtonXOR = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myriad Pro", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logik"
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(20, 110)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(190, 41)
        Me.ButtonCalculate.TabIndex = 1
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'CheckBoxA
        '
        Me.CheckBoxA.AutoSize = True
        Me.CheckBoxA.Location = New System.Drawing.Point(20, 62)
        Me.CheckBoxA.Name = "CheckBoxA"
        Me.CheckBoxA.Size = New System.Drawing.Size(33, 17)
        Me.CheckBoxA.TabIndex = 2
        Me.CheckBoxA.Text = "A"
        Me.CheckBoxA.UseVisualStyleBackColor = True
        '
        'CheckBoxB
        '
        Me.CheckBoxB.AutoSize = True
        Me.CheckBoxB.Location = New System.Drawing.Point(20, 86)
        Me.CheckBoxB.Name = "CheckBoxB"
        Me.CheckBoxB.Size = New System.Drawing.Size(33, 17)
        Me.CheckBoxB.TabIndex = 3
        Me.CheckBoxB.Text = "B"
        Me.CheckBoxB.UseVisualStyleBackColor = True
        '
        'RadioButtonAND
        '
        Me.RadioButtonAND.AutoSize = True
        Me.RadioButtonAND.Location = New System.Drawing.Point(232, 62)
        Me.RadioButtonAND.Name = "RadioButtonAND"
        Me.RadioButtonAND.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonAND.TabIndex = 4
        Me.RadioButtonAND.TabStop = True
        Me.RadioButtonAND.Text = "AND"
        Me.RadioButtonAND.UseVisualStyleBackColor = True
        '
        'RadioButtonOR
        '
        Me.RadioButtonOR.AutoSize = True
        Me.RadioButtonOR.Location = New System.Drawing.Point(232, 133)
        Me.RadioButtonOR.Name = "RadioButtonOR"
        Me.RadioButtonOR.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonOR.TabIndex = 5
        Me.RadioButtonOR.TabStop = True
        Me.RadioButtonOR.Text = "XOR"
        Me.RadioButtonOR.UseVisualStyleBackColor = True
        '
        'RadioButtonNOT
        '
        Me.RadioButtonNOT.AutoSize = True
        Me.RadioButtonNOT.Location = New System.Drawing.Point(232, 110)
        Me.RadioButtonNOT.Name = "RadioButtonNOT"
        Me.RadioButtonNOT.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonNOT.TabIndex = 6
        Me.RadioButtonNOT.TabStop = True
        Me.RadioButtonNOT.Text = "NOT"
        Me.RadioButtonNOT.UseVisualStyleBackColor = True
        '
        'RadioButtonXOR
        '
        Me.RadioButtonXOR.AutoSize = True
        Me.RadioButtonXOR.Location = New System.Drawing.Point(232, 85)
        Me.RadioButtonXOR.Name = "RadioButtonXOR"
        Me.RadioButtonXOR.Size = New System.Drawing.Size(41, 17)
        Me.RadioButtonXOR.TabIndex = 7
        Me.RadioButtonXOR.TabStop = True
        Me.RadioButtonXOR.Text = "OR"
        Me.RadioButtonXOR.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "About This Application"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(370, 165)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButtonXOR)
        Me.Controls.Add(Me.RadioButtonNOT)
        Me.Controls.Add(Me.RadioButtonOR)
        Me.Controls.Add(Me.RadioButtonAND)
        Me.Controls.Add(Me.CheckBoxB)
        Me.Controls.Add(Me.CheckBoxA)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents CheckBoxA As CheckBox
    Friend WithEvents CheckBoxB As CheckBox
    Friend WithEvents RadioButtonAND As RadioButton
    Friend WithEvents RadioButtonOR As RadioButton
    Friend WithEvents RadioButtonNOT As RadioButton
    Friend WithEvents RadioButtonXOR As RadioButton
    Friend WithEvents Button1 As Button
End Class

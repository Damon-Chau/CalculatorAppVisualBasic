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
        Me.subtractRB = New System.Windows.Forms.RadioButton()
        Me.multiplyRB = New System.Windows.Forms.RadioButton()
        Me.divideRB = New System.Windows.Forms.RadioButton()
        Me.addRB = New System.Windows.Forms.RadioButton()
        Me.userinput1Textbox = New System.Windows.Forms.TextBox()
        Me.userinput2Textbox = New System.Windows.Forms.TextBox()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.symbolLbl = New System.Windows.Forms.Label()
        Me.answerLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'subtractRB
        '
        Me.subtractRB.AutoSize = True
        Me.subtractRB.Location = New System.Drawing.Point(3, 95)
        Me.subtractRB.Name = "subtractRB"
        Me.subtractRB.Size = New System.Drawing.Size(65, 17)
        Me.subtractRB.TabIndex = 1
        Me.subtractRB.TabStop = True
        Me.subtractRB.Text = "Subtract"
        Me.subtractRB.UseVisualStyleBackColor = True
        '
        'multiplyRB
        '
        Me.multiplyRB.AutoSize = True
        Me.multiplyRB.Location = New System.Drawing.Point(82, 72)
        Me.multiplyRB.Name = "multiplyRB"
        Me.multiplyRB.Size = New System.Drawing.Size(60, 17)
        Me.multiplyRB.TabIndex = 2
        Me.multiplyRB.TabStop = True
        Me.multiplyRB.Text = "Multiply"
        Me.multiplyRB.UseVisualStyleBackColor = True
        '
        'divideRB
        '
        Me.divideRB.AutoSize = True
        Me.divideRB.Location = New System.Drawing.Point(82, 95)
        Me.divideRB.Name = "divideRB"
        Me.divideRB.Size = New System.Drawing.Size(55, 17)
        Me.divideRB.TabIndex = 3
        Me.divideRB.TabStop = True
        Me.divideRB.Text = "Divide"
        Me.divideRB.UseVisualStyleBackColor = True
        '
        'addRB
        '
        Me.addRB.AutoSize = True
        Me.addRB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addRB.Location = New System.Drawing.Point(3, 72)
        Me.addRB.Name = "addRB"
        Me.addRB.Size = New System.Drawing.Size(44, 17)
        Me.addRB.TabIndex = 0
        Me.addRB.TabStop = True
        Me.addRB.Text = "Add"
        Me.addRB.UseVisualStyleBackColor = False
        '
        'userinput1Textbox
        '
        Me.userinput1Textbox.Location = New System.Drawing.Point(3, 13)
        Me.userinput1Textbox.Name = "userinput1Textbox"
        Me.userinput1Textbox.Size = New System.Drawing.Size(269, 20)
        Me.userinput1Textbox.TabIndex = 4
        '
        'userinput2Textbox
        '
        Me.userinput2Textbox.Location = New System.Drawing.Point(3, 28)
        Me.userinput2Textbox.Name = "userinput2Textbox"
        Me.userinput2Textbox.Size = New System.Drawing.Size(269, 20)
        Me.userinput2Textbox.TabIndex = 5
        '
        'calculateBtn
        '
        Me.calculateBtn.Location = New System.Drawing.Point(143, 72)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(75, 23)
        Me.calculateBtn.TabIndex = 6
        Me.calculateBtn.Text = "Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(143, 101)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 7
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'symbolLbl
        '
        Me.symbolLbl.AutoSize = True
        Me.symbolLbl.Location = New System.Drawing.Point(0, 51)
        Me.symbolLbl.Name = "symbolLbl"
        Me.symbolLbl.Size = New System.Drawing.Size(0, 13)
        Me.symbolLbl.TabIndex = 9
        '
        'answerLbl
        '
        Me.answerLbl.AutoSize = True
        Me.answerLbl.Location = New System.Drawing.Point(210, 51)
        Me.answerLbl.Name = "answerLbl"
        Me.answerLbl.Size = New System.Drawing.Size(0, 13)
        Me.answerLbl.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.answerLbl)
        Me.Controls.Add(Me.symbolLbl)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.calculateBtn)
        Me.Controls.Add(Me.userinput2Textbox)
        Me.Controls.Add(Me.userinput1Textbox)
        Me.Controls.Add(Me.divideRB)
        Me.Controls.Add(Me.multiplyRB)
        Me.Controls.Add(Me.subtractRB)
        Me.Controls.Add(Me.addRB)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addRB As RadioButton
    Friend WithEvents subtractRB As RadioButton
    Friend WithEvents multiplyRB As RadioButton
    Friend WithEvents divideRB As RadioButton
    Friend WithEvents userinput1Textbox As TextBox
    Friend WithEvents userinput2Textbox As TextBox
    Friend WithEvents calculateBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents symbolLbl As Label
    Friend WithEvents answerLbl As Label
End Class

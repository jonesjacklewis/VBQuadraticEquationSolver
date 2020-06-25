<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QESolver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QESolver))
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtC = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.LblXSqaured = New System.Windows.Forms.Label()
        Me.LblX = New System.Windows.Forms.Label()
        Me.LblB = New System.Windows.Forms.Label()
        Me.LblA = New System.Windows.Forms.Label()
        Me.LblC = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.LblAnswerText = New System.Windows.Forms.Label()
        Me.LblText = New System.Windows.Forms.Label()
        Me.LblXOne = New System.Windows.Forms.Label()
        Me.LblXTwo = New System.Windows.Forms.Label()
        Me.LblNoSoloutions = New System.Windows.Forms.Label()
        Me.txtDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtA
        '
        Me.TxtA.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TxtA.Location = New System.Drawing.Point(354, 81)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(71, 20)
        Me.TxtA.TabIndex = 0
        '
        'TxtC
        '
        Me.TxtC.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TxtC.Location = New System.Drawing.Point(354, 202)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(71, 20)
        Me.TxtC.TabIndex = 2
        '
        'TxtB
        '
        Me.TxtB.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TxtB.Location = New System.Drawing.Point(354, 144)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(71, 20)
        Me.TxtB.TabIndex = 1
        '
        'LblXSqaured
        '
        Me.LblXSqaured.AutoSize = True
        Me.LblXSqaured.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblXSqaured.Location = New System.Drawing.Point(519, 64)
        Me.LblXSqaured.Name = "LblXSqaured"
        Me.LblXSqaured.Size = New System.Drawing.Size(39, 37)
        Me.LblXSqaured.TabIndex = 3
        Me.LblXSqaured.Text = "x²"
        '
        'LblX
        '
        Me.LblX.AutoSize = True
        Me.LblX.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblX.Location = New System.Drawing.Point(519, 128)
        Me.LblX.Name = "LblX"
        Me.LblX.Size = New System.Drawing.Size(30, 37)
        Me.LblX.TabIndex = 4
        Me.LblX.Text = "x"
        '
        'LblB
        '
        Me.LblB.AutoSize = True
        Me.LblB.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblB.Location = New System.Drawing.Point(277, 128)
        Me.LblB.Name = "LblB"
        Me.LblB.Size = New System.Drawing.Size(32, 37)
        Me.LblB.TabIndex = 4
        Me.LblB.Text = "b"
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblA.Location = New System.Drawing.Point(277, 65)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(32, 37)
        Me.LblA.TabIndex = 4
        Me.LblA.Text = "a"
        '
        'LblC
        '
        Me.LblC.AutoSize = True
        Me.LblC.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblC.Location = New System.Drawing.Point(277, 185)
        Me.LblC.Name = "LblC"
        Me.LblC.Size = New System.Drawing.Size(30, 37)
        Me.LblC.TabIndex = 4
        Me.LblC.Text = "c"
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(350, 253)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalc.TabIndex = 4
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'LblAnswerText
        '
        Me.LblAnswerText.AutoSize = True
        Me.LblAnswerText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.LblAnswerText.Location = New System.Drawing.Point(351, 303)
        Me.LblAnswerText.Name = "LblAnswerText"
        Me.LblAnswerText.Size = New System.Drawing.Size(60, 18)
        Me.LblAnswerText.TabIndex = 6
        Me.LblAnswerText.Text = "Answer"
        '
        'LblText
        '
        Me.LblText.AutoSize = True
        Me.LblText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.LblText.Location = New System.Drawing.Point(318, 20)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(158, 18)
        Me.LblText.TabIndex = 6
        Me.LblText.Text = "Enter numbers below:"
        '
        'LblXOne
        '
        Me.LblXOne.AutoSize = True
        Me.LblXOne.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.LblXOne.Location = New System.Drawing.Point(352, 324)
        Me.LblXOne.Name = "LblXOne"
        Me.LblXOne.Size = New System.Drawing.Size(24, 22)
        Me.LblXOne.TabIndex = 6
        Me.LblXOne.Text = "x₁"
        '
        'LblXTwo
        '
        Me.LblXTwo.AutoSize = True
        Me.LblXTwo.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.LblXTwo.Location = New System.Drawing.Point(352, 346)
        Me.LblXTwo.Name = "LblXTwo"
        Me.LblXTwo.Size = New System.Drawing.Size(24, 22)
        Me.LblXTwo.TabIndex = 6
        Me.LblXTwo.Text = "x₂"
        '
        'LblNoSoloutions
        '
        Me.LblNoSoloutions.AutoSize = True
        Me.LblNoSoloutions.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.LblNoSoloutions.Location = New System.Drawing.Point(304, 346)
        Me.LblNoSoloutions.Name = "LblNoSoloutions"
        Me.LblNoSoloutions.Size = New System.Drawing.Size(172, 22)
        Me.LblNoSoloutions.TabIndex = 6
        Me.LblNoSoloutions.Text = "No Real Soloutions"
        Me.LblNoSoloutions.Visible = False
        '
        'txtDecimalPlaces
        '
        Me.txtDecimalPlaces.Location = New System.Drawing.Point(356, 402)
        Me.txtDecimalPlaces.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtDecimalPlaces.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDecimalPlaces.Name = "txtDecimalPlaces"
        Me.txtDecimalPlaces.Size = New System.Drawing.Size(120, 20)
        Me.txtDecimalPlaces.TabIndex = 3
        Me.txtDecimalPlaces.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Decimal Places"
        '
        'QESolver
        '
        Me.AcceptButton = Me.BtnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDecimalPlaces)
        Me.Controls.Add(Me.LblText)
        Me.Controls.Add(Me.LblXTwo)
        Me.Controls.Add(Me.LblNoSoloutions)
        Me.Controls.Add(Me.LblXOne)
        Me.Controls.Add(Me.LblAnswerText)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.LblA)
        Me.Controls.Add(Me.LblC)
        Me.Controls.Add(Me.LblB)
        Me.Controls.Add(Me.LblX)
        Me.Controls.Add(Me.LblXSqaured)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtC)
        Me.Controls.Add(Me.TxtA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QESolver"
        Me.Text = "Quadratic Equation Solver"
        CType(Me.txtDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtA As TextBox
    Friend WithEvents TxtC As TextBox
    Friend WithEvents TxtB As TextBox
    Friend WithEvents LblXSqaured As Label
    Friend WithEvents LblX As Label
    Friend WithEvents LblB As Label
    Friend WithEvents LblA As Label
    Friend WithEvents LblC As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents LblAnswerText As Label
    Friend WithEvents LblText As Label
    Friend WithEvents LblXOne As Label
    Friend WithEvents LblXTwo As Label
    Friend WithEvents LblNoSoloutions As Label
    Friend WithEvents txtDecimalPlaces As NumericUpDown
    Friend WithEvents Label1 As Label
End Class

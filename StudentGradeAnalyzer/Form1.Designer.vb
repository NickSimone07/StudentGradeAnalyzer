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
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(189, 346)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(264, 67)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import File"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(1104, 681)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(395, 108)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1215, 821)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(164, 106)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstStudents
        '
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.ItemHeight = 37
        Me.lstStudents.Location = New System.Drawing.Point(117, 424)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(384, 411)
        Me.lstStudents.TabIndex = 3
        '
        'lblLowest
        '
        Me.lblLowest.AutoSize = True
        Me.lblLowest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLowest.Location = New System.Drawing.Point(806, 706)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(118, 37)
        Me.lblLowest.TabIndex = 4
        Me.lblLowest.Text = "Lowest"
        '
        'lblHighest
        '
        Me.lblHighest.AutoSize = True
        Me.lblHighest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHighest.Location = New System.Drawing.Point(806, 784)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(125, 37)
        Me.lblHighest.TabIndex = 5
        Me.lblHighest.Text = "Highest"
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(1104, 423)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(395, 200)
        Me.btnAddStudent.TabIndex = 6
        Me.btnAddStudent.Text = "Add Student (Do this first)"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(752, 376)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(291, 44)
        Me.txtName.TabIndex = 7
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(752, 489)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(291, 44)
        Me.txtGrade.TabIndex = 8
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAverage.Location = New System.Drawing.Point(806, 635)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(135, 37)
        Me.lblAverage.TabIndex = 9
        Me.lblAverage.Text = "Average"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(604, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(604, 489)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(660, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(979, 101)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Student Grade Analyzer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(630, 635)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 37)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Average"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(647, 706)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 37)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Lowest"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(647, 784)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 37)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Highest"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1620, 248)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(344, 132)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(2926, 1133)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lblLowest)
        Me.Controls.Add(Me.lstStudents)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnImport)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImport As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstStudents As ListBox
    Friend WithEvents lblLowest As Label
    Friend WithEvents lblHighest As Label
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
End Class

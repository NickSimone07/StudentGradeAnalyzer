Imports System.IO
Imports System.Xml

Public Class Form1
    ' Define a structure to hold student records
    Structure Student
        Public Name As String
        Public Grade As Double
    End Structure

    ' Declare a list to store the student records
    Dim studentList As New List(Of Student)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the initial state of the form
        ClearForm()
    End Sub

    Private Sub ClearForm()
        ' Clear all textboxes and labels
        txtName.Clear()
        txtGrade.Clear()
        lblAverage.Text = ""
        lblHighest.Text = ""
        lblLowest.Text = ""
        lstStudents.Items.Clear()
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        ' Validate and process the user input
        If ValidateInput() Then
            Dim newStudent As Student
            newStudent.Name = txtName.Text
            newStudent.Grade = CDbl(txtGrade.Text)

            ' Add the student to the list
            studentList.Add(newStudent)

            ' Update the student list display
            lstStudents.Items.Add(newStudent.Name)

            ' Clear the textboxes
            txtName.Clear()
            txtGrade.Clear()

            ' Focus on the name textbox
            txtName.Focus()
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        ' Validate the user input for student name and grade
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a valid student name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim grade As Double
        If Not Double.TryParse(txtGrade.Text, grade) Then
            MessageBox.Show("Please enter a valid numeric grade.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If grade < 0 Or grade > 100 Then
            MessageBox.Show("Please enter a valid grade between 0 and 100.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        ' Import student data from a file
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to XML files
        openFileDialog.Filter = "XML Files|*.xml"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                LoadDataFromXml(openFileDialog.FileName)
                MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occurred while importing the data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LoadDataFromXml(xmlFilePath As String)
        ' Load data from XML file and populate the studentList
        Try
            Dim doc As New XmlDocument()
            doc.Load(xmlFilePath)

            studentList.Clear()
            lstStudents.Items.Clear()

            Dim studentNodes As XmlNodeList = doc.SelectNodes("/students/student")
            For Each studentNode As XmlNode In studentNodes
                Dim newStudent As Student
                newStudent.Name = studentNode.SelectSingleNode("name").InnerText
                newStudent.Grade = CDbl(studentNode.SelectSingleNode("grade").InnerText)

                studentList.Add(newStudent)
                lstStudents.Items.Add(newStudent.Name)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculate statistics based on the student data
        If studentList.Count > 0 Then
            ' Calculate average grade
            Dim totalGrade As Double = 0
            For Each student In studentList
                totalGrade += student.Grade
            Next
            Dim averageGrade As Double = totalGrade / studentList.Count
            lblAverage.Text = averageGrade.ToString("F2")

            ' Find highest and lowest grades
            Dim highestGrade As Double = Double.MinValue
            Dim lowestGrade As Double = Double.MaxValue
            For Each student In studentList
                If student.Grade > highestGrade Then
                    highestGrade = student.Grade
                End If
                If student.Grade < lowestGrade Then
                    lowestGrade = student.Grade
                End If
            Next
            lblHighest.Text = highestGrade.ToString("F2")
            lblLowest.Text = lowestGrade.ToString("F2")
        Else
            MessageBox.Show("No student records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged
        ' Display the selected student's grade
        If lstStudents.SelectedIndex >= 0 Then
            Dim selectedStudent As Student = studentList(lstStudents.SelectedIndex)
            MessageBox.Show("Selected student's grade: " & selectedStudent.Grade.ToString("F2"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the form and student list
        ClearForm()
        studentList.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save student data to an XML file
        Dim saveFileDialog As New SaveFileDialog()

        ' Set the filter to XML files
        saveFileDialog.Filter = "XML Files|*.xml"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                SaveDataToXml(saveFileDialog.FileName)
                MessageBox.Show("Data saved successfully to XML.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving data to XML. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SaveDataToXml(xmlFilePath As String)
        ' Save studentList data to XML file
        Try
            Dim doc As New XmlDocument()
            doc.LoadXml("<students></students>")

            Dim rootElement As XmlElement = doc.DocumentElement

            For Each student As Student In studentList
                Dim studentElement As XmlElement = doc.CreateElement("student")

                Dim nameElement As XmlElement = doc.CreateElement("name")
                nameElement.InnerText = student.Name
                studentElement.AppendChild(nameElement)

                Dim gradeElement As XmlElement = doc.CreateElement("grade")
                gradeElement.InnerText = student.Grade.ToString()
                studentElement.AppendChild(gradeElement)

                rootElement.AppendChild(studentElement)
            Next

            doc.Save(xmlFilePath)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
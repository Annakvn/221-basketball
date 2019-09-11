' Project name:         Basketball Project
' Project purpose:      Display a team's total score
' Created/revised by:   Anna Kovneva on February 16,2017

Option Explicit On
Option Infer Off
Option Strict On
Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays score

        Dim numPt2 As Integer
        Dim numPt3 As Integer
        Dim numFree As Integer
        Dim totalPt2 As Integer
        Dim totalPt3 As Integer
        Dim totalScore As Integer

        'store user input in variables 
        Integer.TryParse(pt2TextBox.Text, numPt2)
        Integer.TryParse(pt3TextBox.Text, numPt3)
        Integer.TryParse(freeTextBox.Text, numFree)

        'perform calculations
        totalPt2 = numPt2 * 2
        totalPt3 = numPt3 * 3
        totalScore = totalPt2 + totalPt3 + numFree

        'display total score
        totalLabel.Text = totalScore.ToString

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clear user input and total score
        pt2TextBox.Text = String.Empty
        pt3TextBox.Text = String.Empty
        freeTextBox.Text = String.Empty
        totalLabel.Text = String.Empty
        pt2TextBox.Focus()

    End Sub
End Class

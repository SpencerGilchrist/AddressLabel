Option Strict On
Option Explicit On
'Spencer Gilchrist
'RCET 0265
'Display label
Public Class Form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'This simply ends the program
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Validation()
        'Displays a multi-line Formatted text
        DisplayLabel.Text = FirstNameTextBox.Text & vbNewLine _
        & LastNameTextBox.Text & vbNewLine _
        & StreetAddressTextBox.Text & vbNewLine _
        & CityTextBox.Text & vbNewLine _
        & StateTextBox.Text & vbNewLine _
        & ZipTextBox.Text
        'All this does is allow us to not have a super 
        'Long line in the way of the rest of the program

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        CityTextBox.Text = ""
        DisplayLabel.Text = ""
    End Sub

    Function Validation() As Boolean
        Dim Status As Boolean = False

        'This looks to see if there is any empty fields and promts the user
        'I know this looks bad but it works so... yeah.
        If ZipTextBox.Text = "" Then
            Status = False
            ZipTextBox.BackColor = Color.Red
        Else
            Status = True
            ZipTextBox.BackColor = Color.White
        End If

        If StateTextBox.Text = "" Then
            Status = False
            StateTextBox.BackColor = Color.Red
        Else
            Status = True
            StateTextBox.BackColor = Color.White
        End If

        If CityTextBox.Text = "" Then
            Status = False
            CityTextBox.BackColor = Color.Red
        Else
            Status = True
            CityTextBox.BackColor = Color.White
        End If

        If StreetAddressTextBox.Text = "" Then
            Status = False
            StreetAddressTextBox.BackColor = Color.Red
        Else
            Status = True
            StreetAddressTextBox.BackColor = Color.White
        End If

        If LastNameTextBox.Text = "" Then
            Status = False
            LastNameTextBox.BackColor = Color.Red
        Else
            Status = True
            LastNameTextBox.BackColor = Color.White
        End If

        If FirstNameTextBox.Text = "" Then
            Status = False
            FirstNameTextBox.BackColor = Color.Red
        Else
            Status = True
            FirstNameTextBox.BackColor = Color.White
        End If
        Return Status
    End Function

End Class


Public Class Form1
    Private Sub btnDisplayRowWise_Click(sender As Object, e As EventArgs) Handles btnDisplayRowWise.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(0, 1) = "Jacinda"
        astPeople(0, 2) = "Ada"
        astPeople(0, 3) = "Albert"
        astPeople(0, 4) = "Mahatma"
        astPeople(0, 5) = "Vincent"

        astPeople(1, 0) = "Obama"
        astPeople(1, 1) = "Adern"
        astPeople(1, 2) = "Lovelace"
        astPeople(1, 3) = "Einstein"
        astPeople(1, 4) = "Gandi"
        astPeople(1, 5) = "van Gogh"

        astPeople(2, 0) = "Male"
        astPeople(2, 1) = "Female"
        astPeople(2, 2) = "Female"
        astPeople(2, 3) = "Male"
        astPeople(2, 4) = "Male"
        astPeople(2, 5) = "Male"

        astPeople(3, 0) = "American"
        astPeople(3, 1) = "New Zealand"
        astPeople(3, 2) = "British"
        astPeople(3, 3) = "Swish"
        astPeople(3, 4) = "Indian"
        astPeople(3, 5) = "Dutch"

        astPeople(4, 0) = "President"
        astPeople(4, 1) = "Prime Minister"
        astPeople(4, 2) = "Mathematician"
        astPeople(4, 3) = "Scientist"
        astPeople(4, 4) = "Lawyer"
        astPeople(4, 5) = "Artist"

        For i = 0 To 4
            For x = 0 To 5
                MsgBox(astPeople(i, x))
            Next
        Next
    End Sub

    Private Sub BtnColumnWise_Click(sender As Object, e As EventArgs) Handles BtnColumnWise.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(0, 1) = "Jacinda"
        astPeople(0, 2) = "Ada"
        astPeople(0, 3) = "Albert"
        astPeople(0, 4) = "Mahatma"
        astPeople(0, 5) = "Vincent"

        astPeople(1, 0) = "Obama"
        astPeople(1, 1) = "Adern"
        astPeople(1, 2) = "Lovelace"
        astPeople(1, 3) = "Einstein"
        astPeople(1, 4) = "Gandi"
        astPeople(1, 5) = "van Gogh"

        astPeople(2, 0) = "Male"
        astPeople(2, 1) = "Female"
        astPeople(2, 2) = "Female"
        astPeople(2, 3) = "Male"
        astPeople(2, 4) = "Male"
        astPeople(2, 5) = "Male"

        astPeople(3, 0) = "American"
        astPeople(3, 1) = "New Zealand"
        astPeople(3, 2) = "British"
        astPeople(3, 3) = "Swish"
        astPeople(3, 4) = "Indian"
        astPeople(3, 5) = "Dutch"

        astPeople(4, 0) = "President"
        astPeople(4, 1) = "Prime Minister"
        astPeople(4, 2) = "Mathematician"
        astPeople(4, 3) = "Scientist"
        astPeople(4, 4) = "Lawyer"
        astPeople(4, 5) = "Artist"

        For x = 0 To 5
            For i = 0 To 4
                MsgBox(astPeople(i, x))
            Next
        Next
    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(0, 1) = "Jacinda"
        astPeople(0, 2) = "Ada"
        astPeople(0, 3) = "Albert"
        astPeople(0, 4) = "Mahatma"
        astPeople(0, 5) = "Vincent"

        astPeople(1, 0) = "Obama"
        astPeople(1, 1) = "Adern"
        astPeople(1, 2) = "Lovelace"
        astPeople(1, 3) = "Einstein"
        astPeople(1, 4) = "Gandi"
        astPeople(1, 5) = "van Gogh"

        astPeople(2, 0) = "Male"
        astPeople(2, 1) = "Female"
        astPeople(2, 2) = "Female"
        astPeople(2, 3) = "Male"
        astPeople(2, 4) = "Male"
        astPeople(2, 5) = "Male"

        astPeople(3, 0) = "American"
        astPeople(3, 1) = "New Zealand"
        astPeople(3, 2) = "British"
        astPeople(3, 3) = "Swish"
        astPeople(3, 4) = "Indian"
        astPeople(3, 5) = "Dutch"

        astPeople(4, 0) = "President"
        astPeople(4, 1) = "Prime Minister"
        astPeople(4, 2) = "Mathematician"
        astPeople(4, 3) = "Scientist"
        astPeople(4, 4) = "Lawyer"
        astPeople(4, 5) = "Artist"

        Dim stTable As String
        stTable = " "

        For x = 0 To 5
            For i = 0 To 4
                stTable = stTable & astPeople(i, x) & " ,"
            Next
            stTable = stTable & vbNewLine
        Next
        MsgBox(stTable)

    End Sub

    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(0, 1) = "Jacinda"
        astPeople(0, 2) = "Ada"
        astPeople(0, 3) = "Albert"
        astPeople(0, 4) = "Mahatma"
        astPeople(0, 5) = "Vincent"

        astPeople(1, 0) = "Obama"
        astPeople(1, 1) = "Adern"
        astPeople(1, 2) = "Lovelace"
        astPeople(1, 3) = "Einstein"
        astPeople(1, 4) = "Gandi"
        astPeople(1, 5) = "van Gogh"

        astPeople(2, 0) = "Male"
        astPeople(2, 1) = "Female"
        astPeople(2, 2) = "Female"
        astPeople(2, 3) = "Male"
        astPeople(2, 4) = "Male"
        astPeople(2, 5) = "Male"

        astPeople(3, 0) = "American"
        astPeople(3, 1) = "New Zealand"
        astPeople(3, 2) = "British"
        astPeople(3, 3) = "Swish"
        astPeople(3, 4) = "Indian"
        astPeople(3, 5) = "Dutch"

        astPeople(4, 0) = "President"
        astPeople(4, 1) = "Prime Minister"
        astPeople(4, 2) = "Mathematician"
        astPeople(4, 3) = "Scientist"
        astPeople(4, 4) = "Lawyer"
        astPeople(4, 5) = "Artist"

        Dim isFound As Boolean
        isFound = False
        Dim stName As String
        stName = InputBox("Input the person's name you wish to search for")

        For y = 0 To 5
            If astPeople(0, y).ToUpper = stName.ToUpper Then
                isFound = True
            End If
        Next
        If isFound = False Then
            MsgBox("The person you queried does not exist in this database")
        Else
            MsgBox("Person exists in this data sheet")
        End If

    End Sub
End Class

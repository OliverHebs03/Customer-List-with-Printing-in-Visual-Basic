Imports System.Text
Imports System.Windows.Forms.MonthCalendar

'Version 0.1
'Name: Supplier List
'Author: Oliver Heberle
'Purpose: For a Software sac, Case study purpose is for the program to act as a way to store suppliers in a list

Public Class Form1

    ' Array to hold customer records in comma-separated format
    Dim arrSupplierList(1) As String

    ' Index to track the number of entries added to the array
    Dim intIndex As Integer = 0

    ' Stores the filename for saving or opening files
    Dim strFilename As String = ""

    '==========================[ FORM RESET FUNCTION ]==========================
    Private Sub ClearForm()
        ' Clear all text boxes
        txtbName.Clear()
        txtbABNACN.Clear()

        ' Uncheck all quality radio buttons
        rbtnCompany.Checked = False
        rbtnPartnership.Checked = False
        rbtnSoleTrader.Checked = False

        ' Reset dropdown to no selection
        cbState.SelectedIndex = -1
    End Sub

    '==========================[ CLEAR BUTTON ]==========================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm() 'Calls clear form funtion when button pressed
    End Sub

    '==========================[ ADD CUSTOMER BUTTON ]==========================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Combine form inputs into a single comma-separated string
            arrSupplierList(intIndex) = txtbName.Text & "|" & cbState.Text & "|" & txtbABNACN.Text & "|" & GetStructure()
            intIndex += 1 ' Move to next index in array
        Catch ex As IndexOutOfRangeException
            ' Resize array if limit exceeded (dynamic expansion)
            ReDim Preserve arrSupplierList(arrSupplierList.Length)
            ' Add data again after resizing
            arrSupplierList(intIndex) = txtbName.Text & "|" & cbState.Text & "|" & txtbABNACN.Text & "|" & GetStructure()
            intIndex += 1
        End Try

        ' Reset the form and return focus to first field
        ClearForm()
        txtbName.Focus()
    End Sub

    '==========================[ STRUCTURE HELPER FUNCTION ]==========================
    ' Returns selected structure value based on which radio button is checked
    Private Function GetStructure() As String
        If rbtnCompany.Checked Then Return "Company"
        If rbtnPartnership.Checked Then Return "Partnership"
        If rbtnSoleTrader.Checked Then Return "Sole Trader"
        Return "" ' No selection
    End Function

    '==========================[ SAVE TO FILE OPTION ]==========================
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ' Prompt user with Save File dialog
        sfdFilename.Filter = "Text Files|*.txt|All Files|*.*"
        If sfdFilename.ShowDialog() = DialogResult.OK Then
            strFilename = sfdFilename.FileName

            ' Ensure the file has a .txt extension
            If Not strFilename.ToLower().EndsWith(".txt") Then
                strFilename &= ".txt"
            End If

            ' Call function to write data to file
            SaveToFile(strFilename)
        End If
    End Sub

    ' Actually writes the customer data to the specified file
    Private Sub SaveToFile(path As String)
        ' Trim any unused array elements
        ReDim Preserve arrSupplierList(intIndex - 1)

        ' Open file and write each customer record line-by-line
        Using writer As New IO.StreamWriter(path)
            writer.WriteLine("Name,State,ABN/ACN,Structure") ' Write text header
            For Each line In arrSupplierList
                writer.WriteLine(line)
            Next
        End Using
    End Sub

    '==========================[ OPEN FILE OPTION ]==========================
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' Prompt user with Open File dialog
        ofdFilename.Filter = "Text Files|*.txt|All Files|*.*"
        If ofdFilename.ShowDialog() = DialogResult.OK Then
            strFilename = ofdFilename.FileName

            ' Read file line-by-line
            Using reader As New IO.StreamReader(strFilename)
                Dim isFirstLine As Boolean = True

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()

                    ' Skip header line
                    If isFirstLine Then
                        isFirstLine = False
                        Continue While
                    End If

                    ' Resize array if needed
                    If intIndex >= arrSupplierList.Length Then
                        ReDim Preserve arrSupplierList(arrSupplierList.Length)
                    End If

                    ' Add record to array
                    arrSupplierList(intIndex) = line
                    intIndex += 1
                End While
            End Using

            ' Show first record on the form
            DisplayRecord(arrSupplierList(0))
        End If
    End Sub

    '==========================[ DISPLAY A RECORD ON FORM ]==========================
    Private Sub DisplayRecord(record As String)
        Dim fields = record.Split(","c)

        ' Set values in form fields
        txtbName.Text = fields(0)
        txtbABNACN.Text = fields(2)


        ' Set appropriate state radio button
        Select Case fields(3)
            Case "Company" : rbtnCompany.Checked = True
            Case "Partnership" : rbtnPartnership.Checked = True
            Case "Sole Trader" : rbtnSoleTrader.Checked = True
        End Select

        ' Set state combo box
        cbState.Text = fields(1)
    End Sub

    '==========================[ NEW FILE OPTION ]==========================
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Reset all state and clear form
        ReDim arrSupplierList(1)
        intIndex = 0
        strFilename = ""
        ClearForm()
    End Sub
    '==========================[ EXIT APPLICATION ]==========================
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End ' Closes the application
    End Sub
    '==========================[ SEARCH FUNCTION ]==========================
    ' Looks through all records for a match in the specified field
    Private Sub SearchRecord(keyword As String, fieldIndex As Integer)
        For Each record In arrSupplierList
            Dim fields = record.Split(","c)
            ' Case-insensitive match
            If fields(fieldIndex).Trim().ToUpper() = keyword.Trim().ToUpper() Then
                DisplayRecord(record)
                Return
            End If
        Next

        ' If no match found
        MessageBox.Show("Record not found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
    End Sub

    '==========================[ SEARCH BY NAME ]==========================
    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        Dim keyword As String = InputBox("Enter Name to search")
        SearchRecord(keyword, 0) ' 0 = Name field
    End Sub

    '==========================[ SEARCH BY STATE ]==========================
    Private Sub btnState_Click(sender As Object, e As EventArgs) Handles btnState.Click
        Dim keyword As String = InputBox("Enter a state is search")
        SearchRecord(keyword.ToUpper(), 1) ' 1 = State field
    End Sub

    '==========================[ SEARCH BY ABN/ACN ]==========================
    Private Sub btnABNACN_Click(sender As Object, e As EventArgs) Handles btnABNACN.Click
        Dim keyword As String = InputBox("Enter an ABN or ACN to search")
        SearchRecord(keyword, 2) ' 2 = AVN/ACN field
    End Sub
    '==========================[ SEARCH BY STRUCTURE ]==========================
    Private Sub btnStructure_Click(sender As Object, e As EventArgs) Handles btnStructure.Click
        Dim keyword As String = InputBox("Enter Structure to search")
        SearchRecord(keyword.ToUpper(), 3) ' 3 = Structure field
    End Sub
    '==========================[ PRINT PREVIEW OPTION ]==========================
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        ' Set print orientation and show preview window
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    '==========================[ PRINTING THE CUSTOMER LIST ]==========================
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Ensure array doesn't contain empty slots
        ReDim Preserve arrSupplierList(intIndex - 1)

        ' Define fonts for print layout
        Dim TitleFont As New Font("Arial", 18, FontStyle.Bold)
        Dim HeaderFont As New Font("Arial", 10, FontStyle.Bold)
        Dim BodyFont As New Font("Calibri", 10)

        ' Initial vertical position for printing
        Dim yPosition As Integer = 60

        ' Define x-coordinates for each column
        Dim xName = 50
        Dim xState = 200
        Dim xABNACN = 300
        Dim xStructure = 420


        ' Print title and header row
        e.Graphics.DrawString("Supplier List", TitleFont, Brushes.DarkGreen, xName, 20)
        e.Graphics.DrawString("Name", HeaderFont, Brushes.Black, xName, yPosition)
        e.Graphics.DrawString("State", HeaderFont, Brushes.Black, xState, yPosition)
        e.Graphics.DrawString("ABN/ACN", HeaderFont, Brushes.Black, xABNACN, yPosition)
        e.Graphics.DrawString("Structure", HeaderFont, Brushes.Black, xStructure, yPosition)


        yPosition += 25 ' Space between headers and records

        ' Print each customer record
        For i = 0 To intIndex - 1
            Dim data = arrSupplierList(i).Split(","c)
            If data.Length = 4 Then ' Ensure complete record
                e.Graphics.DrawString(data(0), BodyFont, Brushes.Black, xName, yPosition)
                e.Graphics.DrawString(data(1), BodyFont, Brushes.Black, xState, yPosition)
                e.Graphics.DrawString(data(2), BodyFont, Brushes.Black, xABNACN, yPosition)
                e.Graphics.DrawString(data(3), BodyFont, Brushes.Black, xStructure, yPosition)
                yPosition += 20 ' Move to next line
            End If
        Next
    End Sub
End Class


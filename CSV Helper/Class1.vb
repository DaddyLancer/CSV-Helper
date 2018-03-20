Imports System
Imports System.IO
Imports System.Net
Imports System.Data
Imports System.Data.OleDb
Imports System.Threading
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports System.Windows
Imports System.Deployment.Application


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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MessagesTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MessagesTextBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(882, 411)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 343)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(876, 24)
        Me.ProgressBar1.TabIndex = 0
        '
        'MessagesTextBox
        '
        Me.MessagesTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagesTextBox.Location = New System.Drawing.Point(3, 241)
        Me.MessagesTextBox.Name = "MessagesTextBox"
        Me.MessagesTextBox.Size = New System.Drawing.Size(876, 96)
        Me.MessagesTextBox.TabIndex = 1
        Me.MessagesTextBox.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(876, 232)
        Me.DataGridView1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 373)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(876, 35)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Open CSV File"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 411)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents MessagesTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class


Public Class Form1

    Dim DebugEnable As Boolean = False
    Dim s_UNSET As String = ""
    Dim Console As Integer = 1
    Dim INDENT As String = "        "
    Dim TIMESPEC As String = "dd-mmm-yy hh:MM"

    Private Sub Do_Initialize(sender As Object, e As EventArgs) Handles MyBase.Load

        PrintLine("Click the OPEN CSV FILE button to browse a .csv file.")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' I just knocked up this Windows Form environment for testing, you must replace it with a proper one :-)
        ' Place a .csv file called TestFile.csv in your "MyDocuments" folder ....

        Dim MyInputFile As String
        Dim MyDocumentsFolder = System.Environment.SpecialFolder.MyDocuments
        Dim MyOpenFileDialog As New OpenFileDialog()
        Dim MyDataTable As New DataTable

        PrintLine("CSV File Handling Test Application.")

        ' Your initialization code goes here

        PrintIndent1("Select a .csv file containing a header column called Publication Number.")

        ' InitialDirectory will be the default MyDocumnents initially, that is set in the opening Global declarations
        ' However the user may change the directory path in the OpenFileDialog, and if so we capture the new
        ' directory and assumen it will be the working directory subsequently.  

        MyOpenFileDialog.InitialDirectory = MyDocumentsFolder
        MyOpenFileDialog.Filter = "All files|*.*|CSV Files (*.csv)|*.csv"
        MyOpenFileDialog.FilterIndex = 2
        MyOpenFileDialog.RestoreDirectory = True
        MyOpenFileDialog.SupportMultiDottedExtensions = False
        MyOpenFileDialog.Title = "Select a .csv file containing a header column called Publication Number."

        If MyOpenFileDialog.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            PrintIndent1("No input file was selected. Please try again!")
            Exit Sub
        End If
        MyInputFile = MyOpenFileDialog.FileName
        PrintIndent1("File " & MyInputFile & " was selected.")

        ' This opens a .csv file, looking for a header row with one column called "Publication Number"

        If Not CSV_To_Table(MyInputFile, MyDataTable, False, "", False) Then
            PrintIndent1("We could not find your .csv file.")
            Exit Sub
        End If

        Application.DoEvents()
        DataGridView1.DataSource = MyDataTable
        DataGridView1.Show()
        Application.DoEvents()
        PrintIndent1("The .csv file contents are displayed in the DataGridView.")
        Exit Sub

    End Sub

    ' File to DataTable procedures

    Private Function CSV_To_Table(FilePathName As String, ByRef MyDataTable As DataTable,
                                  HasHeader As Boolean, HeadingIdentifier As String,
                                  Optional ProcessHeader As Boolean = False) As Boolean

        ' CSV_To_Table reads a .csv file into a datatable.
        ' Original functionality by Reed Kimble published here:
        '
        ' http://social.msdn.microsoft.com/Forums/en-US/vblanguage/thread/4c376915-f0cd-4411-affb-e825c9b1c524/
        '
        ' The following modifications written by Rob Sherratt,
        '       1. "hasHeader" modifications to allow for header row in the csv files.
        '       2. Exception handling.
        '       3. Resolves problem that some names in the header row may be duplicates.
        '       4. Added validation for presence of HeaderIndexName in the header of the csv file.
        '       5. Added comment token ";" to allow commented .csv files to be read.
        '       6. Added test for blank line at the end of the file.
        '       7. Added narrative PrintLine statements for the user.
        '       8. Discard preamble rows until the header row is found containing the string HeadingIdentifier.
        '       9. Added ignoreHeader flag to allow partial file loading from Relecura while ignoring successive headers.

        Try
            Dim LineArray() As String
            Dim LineCount As Integer = 0
            Dim ProgressCount As Integer = 0
            Dim ProgressStep As Integer = 0
            Dim c As Integer
            Dim FoundPatentHeader As Boolean = False
            Dim Info As FileInfo = New FileInfo(FilePathName)

            ' 4th April 2013 - modification to test for zero length files.  

            If System.IO.File.Exists(FilePathName) And Info.Length > 0 Then

                Dim parser As New Microsoft.VisualBasic.FileIO.TextFieldParser(FilePathName)
                parser.Delimiters = New String() {";"}
                parser.HasFieldsEnclosedInQuotes = False 'use if data may contain delimiters 
                parser.TextFieldType = FileIO.FieldType.Delimited
                parser.TrimWhiteSpace = True
                'parser.CommentTokens = New String() {";"} ' Modification #4

                Dim HeaderFlag As Boolean = False
                If HasHeader Then HeaderFlag = True

                While Not parser.EndOfData
                    LineArray = parser.ReadFields

                    ' Note: parser.ReadFields will return GetType(dbNULL) and store it in LineArray for
                    ' all CSV records which are not set, i.e. ",," with no field value specified.

                    ' Modification #8 Ignore preamble lines in the file until a header row is found with
                    ' and equivalent name PublicationNumber is found.
                    FoundPatentHeader = True
                    If Not FoundPatentHeader Then
                        For c = 0 To LineArray.GetLength(0) - 1

                            ' 30th Apr 2013 - Modified to call Get_Equivalents()

                            If Not String.IsNullOrWhiteSpace(LineArray(c).ToString) Then
                                If LineArray(c).ToString.Equals(HeadingIdentifier) Then
                                    FoundPatentHeader = True
                                    Exit For 'c
                                End If
                            End If
                        Next c
                    End If

                    If FoundPatentHeader Then

                        LineCount += 1
                        ProgressCount += 1
                        ProgressStep += 1

                        ' Modification #9 for concatenation of multiple Relecura .csv files; we ignore
                        ' header rows in all but the first .csv file.

                        If HeaderFlag And Not ProcessHeader Then
                            HeaderFlag = False
                        Else

                            If Add_CSV_To_Table(LineCount, LineArray, MyDataTable, HeaderFlag) Then
                                HeaderFlag = False

                            Else ' an error has occurred when parsing the line of data

                                PrintError1("There was a problem while parsing the row of data from the .csv file.")
                                PrintError2("This occured at .csv line record (" & LineCount & ").")
                                parser.Close()
                                parser.Dispose()
                                parser = Nothing
                                Return False
                            End If
                        End If
                    End If
                End While

                If FoundPatentHeader Then
                    PrintDebug("Finished processing (" & LineCount - 1 & ") patents from the .csv file.")
                Else
                    PrintError1("The .csv file did not contain a valid " & HeadingIdentifier & " header row.")
                    PrintError2("No records from the .csv file have been read.")
                End If

                parser.Close()
                parser.Dispose()
                parser = Nothing
                Return True
            End If

            PrintError1("A problem ocurred, the file """ & FilePathName & """ contains no data.")
            Return False

        Catch ex As Exception
            PrintException(ex.ToString)
            Return False
        End Try
    End Function

    Private Function Add_CSV_To_Table(LineCount As Integer, ItemArray() As String,
                                      ByRef MyDataTable As DataTable, HeaderFlag As Boolean) As Boolean

        ' Ensures a datatable can hold an array of values and then adds a new row.
        ' Modified by Rob Sherratt to not allow resizing once the header row has been 
        ' written to the data table. This avoids DBNull records being created.

        Try
            Dim ColumnCount As Integer = MyDataTable.Columns.Count

            ' 16th Apr 2013 - Modification to ensure that there are no isolated LF characters
            ' without accompanying CR, otherwise will create problems viewing.

            For i As Integer = 0 To ItemArray.GetLength(0) - 1
                ItemArray(i) = Replace(Replace(CStr(ItemArray(i)), vbCrLf, vbLf), vbLf, vbCrLf)
            Next i

            ' ColumnCount will be 0 the first time we call Add_CSV_To_TABLE, and non zero
            ' afterwards.  If it's zero then we add columns to MyDataTable.

            If ColumnCount = 0 Then

                ' If there is a header row in the .csv file then we use it to create the
                ' column headings.  There is no way in a .csv file to distinguish between
                ' a header row and a normal row of data, so the HeaderFlag has to be set
                ' in software, either the programmer or the user making the decision.

                If HeaderFlag Then

                    ' Added functionality by Rob Sherratt to ensure there are no duplicate
                    ' names (or null column names) in the .csv file.  This can otherwise
                    ' be a problem since column names for DataTables must be unique otherwise
                    ' system exceptions can be generated at a later stage.

                    If Resolve_Column_Name_Problems(ItemArray) Then

                        For i As Integer = 0 To ItemArray.GetLength(0) - 1
                            MyDataTable.Columns.Add(ItemArray(i).ToString, GetType(String))
                        Next i
                        Return True

                    Else
                        ' If Resolve_duplicate_Names returns an error, we can not proceed.

                        Return False
                    End If

                Else
                    ' If there is no header in the .csv file, then we create dummy Column name 
                    ' headings starting "Column1", up to "ColumnXX".

                    For i As Integer = 0 To ItemArray.GetLength(0) - 1
                        MyDataTable.Columns.Add("Column " & (1 + i).ToString, GetType(String))
                    Next i

                End If
                Return True
            End If 'ColumnCount

            ' Modified the following test which was "=" to "<=" to accommodate errors in .csv file
            ' format from Thomson Innovation.

            If ItemArray.GetLength(0) <= MyDataTable.Columns.Count Then
                If ItemArray.GetLength(0).Equals(0) Then
                    PrintError1("A zero length record was detected in the .csv file")
                Else
                    MyDataTable.Rows.Add(ItemArray)
                End If
            Else
                ' Extra code to accommodate illegal .csv file format from Thomson Innovation.
                ' They do not have the correct number of commas in some data rows.

                For n = 1 To ItemArray.GetLength(0) - MyDataTable.Columns.Count
                    MyDataTable.Columns.Add("Column " & (n).ToString, GetType(String))
                Next n
                If ItemArray.GetLength(0).Equals(0) Then
                    PrintError1("A zero length record was detected in the .csv file")
                Else
                    MyDataTable.Rows.Add(ItemArray)
                End If
            End If

            Return True

        Catch ex As Exception
            PrintException(ex.ToString)
            Return False
        End Try
    End Function

    Private Function Resolve_Column_Name_Problems(ByRef NameArray() As String) As Boolean

        ' Resolves the possibility of duplicated names by appending "Duplicate x" postfixed to any duplicates.
        ' Resolved blank column names by creating a name "Blank Column x".

        ' 6th May 2013 - #131 - Commas in a column name cause a system exception to be thrown when the 
        '       user attempts to sort using a column name with a comma.

        ' 18th Jul 2013 - #212 - Parentheses in a column name prevent the column of data being stored in a SQL database.

        ' 27th Jul 2012 - #228 - Replaced PrintWarning messages and replaced with PrintIndent2 messages

        Dim i, n As Integer
        Dim DuplicateID As Integer = 1
        Dim IsProblem As Boolean = False

        Try
            PrintIndent1("Checking for any problematic column headings.")
            For n = 0 To NameArray.GetLength(0) - 1

                NameArray(n) = ToPrintable(NameArray(n))

                ' 9th Mar 2013 : Remove any control characters e.g. CrLf etc from the column name
                ' 6th May 2013 - #131 - Resolve_Duplicate_Names has been modified to remove any commas 
                '       from the column name.

                If InStr(NameArray(n), ",") > 0 Then
                    PrintIndent2("For heading """ & NameArray(n) &
                                  """, we removed the comma(s).")
                    NameArray(n) = Replace(NameArray(n), ",", "")
                    IsProblem = True
                End If

                ' 18th Jul 2013 - #212 - Parentheses in a column name prevent the column of data being stored in a SQL database.

                If InStr(NameArray(n), "(") > 0 Or InStr(NameArray(n), ")") > 0 Then
                    PrintIndent2("For heading """ & NameArray(n) &
                                  """, we replaced parentheses with ""{  }"".")
                    NameArray(n) = Replace(Replace(NameArray(n), "(", "{"), ")", "}")
                    IsProblem = True
                End If

                ' Resolve blank column names

                If String.IsNullOrWhiteSpace(NameArray(n)) Then
                    NameArray(n) = "Blank Column " & n
                    PrintIndent2("We renamed a blank heading to """ & NameArray(n) & """")
                    IsProblem = True

                Else ' Resolve duplicated column names

                    DuplicateID = 0
                    For i = n + 1 To NameArray.GetLength(0) - 1
                        If NameArray(i) = NameArray(n) Then
                            DuplicateID += 1
                            NameArray(i) = NameArray(i) & " Duplicate " & DuplicateID
                            PrintIndent2("We renamed a duplicated column to """ & NameArray(i) & """")
                            IsProblem = True
                        End If
                    Next i
                End If
            Next n

            If Not IsProblem Then
                PrintIndent2("There were no problems with column headings.")
            Else
                PrintIndent2("There were problems with some column headings, which we resolved.")
            End If
            Return True

        Catch ex As Exception
            PrintException(ex.ToString)
            Return False
        End Try
    End Function

    ' DataTable to File procedures

    Private Function Table_To_CSV(SourceTable As DataTable, FileName As String,
                                    Optional HasHeader As Boolean = True) As Boolean

        ' TableToCSV : Saves a DataTable as a .csv file.
        ' Original functionality by Reed Kimble published here:
        ' http://social.msdn.microsoft.com/Forums/en-US/vblanguage/thread/4c376915-f0cd-4411-affb-e825c9b1c524/
        '
        ' Re-written by Rob Sherratt,
        '       1. "hasHeader" modifications to allow for header row in the csv files.
        '       2. Exception handling.
        '       3. Resolved problem with original functionality generating .csv files that could not be parsed later.
        '               Fields containing a line-break, double-quote, and/or commas should be quoted. (If they are not, 
        '               the file will likely be impossible to process correctly). A (double) quote character in a field 
        '               must be represented by two (double) quote characters.
        '       4. Bug found in dimensioning NameArray was adding an extra row.

        Const COMMA As String = ","
        Dim ShortFileName As String

        Try
            Dim sb As New System.Text.StringBuilder

            If HasHeader Then

                ' Process the Header row for the .csv file by getting column names

                Dim NameArray(SourceTable.Columns.Count - 1) As Object

                For i As Integer = 0 To SourceTable.Columns.Count - 1

                    NameArray(i) = SourceTable.Columns(i).ColumnName

                    ' Protect against any uninitialized column headings.  This should never
                    ' occur and is indicative of a coding error elsewhere, so generate a 
                    ' warning message for diagnostic reasons.

                    If String.IsNullOrEmpty(NameArray(i).ToString) Then
                        PrintWarning1("An uninitialized column heading was found in column (" & i & ").")
                    End If

                Next i

                sb.AppendLine(String.Join(COMMA, Array_To_CSV(NameArray)))

            End If

            Dim RowCount As Integer = 0
            Me.ProgressBar1.Maximum = SourceTable.Rows.Count

            For Each SourceRow As DataRow In SourceTable.Rows
                sb.AppendLine(String.Join(COMMA, Array_To_CSV(SourceRow.ItemArray)))

                Me.ProgressBar1.Value = RowCount
                Application.DoEvents()
                RowCount += 1

            Next SourceRow

            System.IO.File.WriteAllText(FileName, sb.ToString)

            ' 5th Mar 2013 - modification to report short file name instead of full path

            ShortFileName = FileName.Substring(FileName.LastIndexOf("\"c) + 1)
            PrintIndent1("The file """ & ShortFileName & """ has been created.")

            Me.ProgressBar1.Value = 0
            Application.DoEvents()
            Return True

        Catch ex As Exception
            PrintException(ex.ToString)
            Return False
        End Try
    End Function

    Private Function Array_To_CSV(ByRef ObjectArray() As Object) As String()

        ' Processes all rows in StringArray, converting them into records suitable for 
        ' writing to a CSV file. Returns the results in a StringArray() the same size as StringArray()

        Const QUOTE As String = """"
        Const CR As String = Chr(13)
        Const LF As String = Chr(10)
        Const COMMA As String = ","
        Dim StringItem As String
        Dim StringArray(ObjectArray.GetLength(0) - 1) As String
        Dim hasComma As Integer
        Dim hasNewLine As Integer
        Dim hasReturn As Integer

        For n As Integer = 0 To ObjectArray.GetLength(0) - 1

            ' Any Quotes in a record must be double Quoted in the CSV file.

            StringItem = Replace(ObjectArray(n).ToString, QUOTE, QUOTE & QUOTE)

            ' If the record has any of a comma, CR or LF character, then the 
            ' record must be "protected" by wrapping Quotes round it.

            hasComma = InStr(StringItem, COMMA)
            hasNewLine = InStr(StringItem, LF)
            hasReturn = InStr(StringItem, CR)
            If (hasComma > 0) Or (hasNewLine > 0) Or (hasReturn > 0) Then
                StringArray(n) = QUOTE & StringItem & QUOTE
            Else
                StringArray(n) = StringItem
            End If
        Next n
        Return StringArray

    End Function

    ' String Manipulation and Textbox Writing Low Level Functions

    Private Function ToPrintable(MyString As String) As String

        MyString = ToASCII_Printable(MyString)
        MyString = ToTruncateSpace(MyString)
        Return MyString

    End Function

    Private Function ToPrintableNoSpace(MyString As String) As String

        MyString = ToASCII_Printable(MyString)
        MyString = ToNoSpace(MyString)
        Return MyString

    End Function

    Private Function ToAlphaNumericNoSpace(MyString As String) As String

        MyString = ToAlphaNumeric(MyString)
        MyString = ToNoSpace(MyString)
        Return MyString

    End Function

    Private Function ToTruncateSpace(MyString As String) As String

        ' Truncates a string to remove all leading and trailing white space.
        ' Also replace multiple spaces with single space

        While InStr(MyString, "  ") > 0
            MyString = Replace(MyString, "  ", " ")
        End While

        If Not String.IsNullOrEmpty(MyString) Then Return MyString.Trim()
        Return ""

    End Function

    Private Function ToNoSpace(MyString As String) As String

        ' Reduces a string to only non-space characters

        Return Replace(MyString, " ", "") ' strip spaces

    End Function

    Private Function ToASCII_Printable(MyString As String) As String

        ' Removes non-printable characters from MyString including CR and LF characters
        ' First replace CRLF, LF and TAB with a space to avoid joining two words together from adjacent lines.

        Try
            If Len(MyString) = 0 Then Return ""

            MyString = Replace(Replace(MyString, vbCrLf, " "), vbLf, " ")
            MyString = Replace(MyString, vbTab, " ")

            ' 30th Apr 2013 - added processing to remove all NON ASCII  32 >= sChr >= 126

            Dim OutStr As String = ""
            Dim n As Integer
            Dim sChr As String = ""

            If Len(MyString) = 0 Then Return ""

            For n = 1 To Len(MyString)
                sChr = Mid(MyString, n, 1)

                If (sChr >= " ") And (sChr <= "~") Then
                    OutStr = OutStr & sChr
                End If
            Next n

            ' 27th Mar 2013 - added removal of multiple spaces due to formatting issue with some Relecura claims text.
            ' 26th Apr 2013 - iterate until all double spaces are removed.

            While InStr(OutStr, "  ") > 0
                OutStr = Replace(OutStr, "  ", " ")
            End While

            Return OutStr

        Catch ex As Exception
            PrintException(ex.ToString)
            Return s_UNSET
        End Try
    End Function

    Private Function ToAlphaNumeric(MyString As String) As String

        ' Removes everything from MyString except Alphabetic, Numeric and Space characters

        ' Use Rexex pattern matching "^[a-zA-Z0-9 ]+$" to test if the character is alphanumeric
        '    ^   : start of Regex string
        '    [   : beginning of character group
        '    a-z : any lowercase letter
        '    A-Z : any uppercase letter
        '    0-9 : any digit
        '    _   : underscore
        '        : space
        '    ]   : end of character group
        '    *   : zero or more of the given characters
        '    +   : one of the given characters
        '    $   : end of Regex string

        Dim n As Integer
        Dim sChr As String = ""
        Dim OutStr As String = ""

        If Len(MyString) = 0 Then Return ""

        For n = 1 To Len(MyString)
            sChr = Mid(MyString, n, 1)
            If (System.Text.RegularExpressions.Regex.IsMatch(sChr, "^[a-zA-Z0-9_ ]+$")) Then
                OutStr = OutStr & sChr
            End If
        Next n

        ' Replace multiple spaces with single space

        While InStr(OutStr, "  ") > 0
            OutStr = Replace(OutStr, "  ", " ")
        End While

        ' Trim the result of any leading and trailing spaces

        OutStr = Trim(OutStr)
        Return OutStr

    End Function

    ' User Interface Console and TextBox Handling Low Level Functions

    Private Sub PrintArray(ArrayStr() As String)

        ' 26th Jul 2013 - #228 - Print array of text strings.

        Dim n As Integer
        Dim Len As Integer = ArrayStr.GetLength(0) - 1
        For n = 0 To ArrayStr.GetLength(0) - 1
            Select Case n
                Case Len
                    PrintString(ArrayStr(n) & vbCrLf)
                Case Else
                    PrintString(ArrayStr(n) & ", ")
            End Select
        Next n
        Exit Sub
    End Sub

    Private Sub PrintLine(Optional TextString As String = "", Optional TextBox As Integer = 1, Optional ErrorColor As Boolean = False)

        ' Writes a line to one of the application's TextBox forms.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        Select Case TextBox
            Case Console
                If ErrorColor Then
                    MessagesTextBox.SelectionColor = Color.DarkRed
                Else
                    MessagesTextBox.SelectionColor = Color.Black
                End If
                MessagesTextBox.AppendText(DateTime.Now.ToString(TIMESPEC) & INDENT & TextString & vbCrLf)
                MessagesTextBox.SelectionStart = MessagesTextBox.TextLength
                MessagesTextBox.ScrollToCaret()

        End Select
        Exit Sub
    End Sub

    Private Sub PrintIndent1(ByRef TextString As String, Optional TextBox As Integer = 1, Optional ErrorColor As Boolean = False)

        ' Prints an indented message in standardized format.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        PrintLine(INDENT & TextString, TextBox, ErrorColor)
        Exit Sub
    End Sub

    Private Sub PrintIndent2(ByRef TextString As String, Optional TextBox As Integer = 1, Optional ErrorColor As Boolean = False)

        ' Prints a double indented message in standardized format.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        PrintLine(INDENT & INDENT & TextString, TextBox, ErrorColor)
        Exit Sub
    End Sub

    Private Sub PrintStart(Optional TextString As String = "", Optional TextBox As Integer = 1, Optional ErrorColor As Boolean = False)

        ' Writes a string to one of the application's TextBox forms, without VbCrLf.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        Select Case TextBox
            Case Console
                If ErrorColor Then
                    MessagesTextBox.SelectionColor = Color.DarkRed
                Else
                    MessagesTextBox.SelectionColor = Color.Black
                End If
                MessagesTextBox.AppendText(DateTime.Now.ToString(TIMESPEC) & INDENT & TextString)

        End Select
        Exit Sub
    End Sub

    Private Sub PrintPart(Optional TextString As String = "", Optional TextBox As Integer = 1, Optional ErrorColor As Boolean = False)

        ' Writes a string to one of the application's TextBox forms, without VbCrLf.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        Select Case TextBox
            Case Console
                If ErrorColor Then
                    MessagesTextBox.SelectionColor = Color.DarkRed
                Else
                    MessagesTextBox.SelectionColor = Color.Black
                End If
                PrintString(TextString)

        End Select
        Exit Sub
    End Sub

    Private Sub PrintFinal(Optional TextString As String = "", Optional TextBox As Integer = 1, Optional ErrorColor As Boolean = False)

        ' Writes a string to one of the application's TextBox forms, without VbCrLf.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        PrintString(TextString & vbCrLf, TextBox, ErrorColor)
        Exit Sub
    End Sub

    Private Sub PrintError1(ByRef TextString As String, Optional TextBox As Integer = 1)

        ' Prints a single line error message in standardized format.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        PrintIndent1("Error: " & TextString, TextBox, True)
        Exit Sub
    End Sub

    Private Sub PrintError2(ByRef TextString As String, Optional TextBox As Integer = 1)

        ' Prints the end of a multi-line error message in standardized format.
        ' Assumes use of PrintIndent1 for extra lines of text.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        PrintIndent2(TextString, TextBox, True)
        Exit Sub
    End Sub

    Private Sub PrintWarning1(ByRef TextString As String, Optional TextBox As Integer = 1)

        ' Prints a single line warning message in standardized format.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        PrintIndent1("Warning: " & TextString, TextBox, True)
        Exit Sub
    End Sub

    Private Sub PrintWarning2(ByRef TextString As String, Optional TextBox As Integer = 1)

        ' Prints the end of a multi-line warning message in standardized format.
        ' Assumes use of PrintIndent1 for extra lines of text.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        PrintIndent2(TextString, TextBox, True)
        Exit Sub
    End Sub

    Private Sub PrintException(ByRef TextString As String, Optional TextBox As Integer = 1)

        ' Prints an exception error report in standardized format, then exits from IPW.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        PrintIndent1("Exception: The following error was not anticipated, and a code fix is necessary: ", TextBox, True)
        PrintString(vbCrLf, TextBox, True)
        PrintString(TextString, TextBox, True)
        PrintString(vbCrLf & vbCrLf, TextBox, True)

        Exit Sub
    End Sub

    Private Sub PrintString(Optional TextString As String = "", Optional TextBox As Integer = 1, Optional ErrorColor As Boolean = False)

        ' Outputs a string to one of the application's TextBox forms.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        Select Case TextBox

            Case Console
                If ErrorColor Then
                    MessagesTextBox.SelectionColor = Color.DarkRed
                Else
                    MessagesTextBox.SelectionColor = Color.Black
                End If
                MessagesTextBox.AppendText(TextString)
                MessagesTextBox.SelectionStart = MessagesTextBox.TextLength
                MessagesTextBox.ScrollToCaret()

        End Select
        Exit Sub
    End Sub

    Private Sub PrintDebug(Optional TextString As String = "", Optional TextBox As Integer = 1)

        ' Writes a Debug trace line to one of the application's TextBox forms.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        If DebugEnable Then
            PrintLine("Debug: " & TextString, TextBox)
        End If
        Exit Sub
    End Sub

    Private Sub PrintDebugStart(Optional TextString As String = "", Optional TextBox As Integer = 1)

        ' Writes a Debug trace string to one of the application's TextBox forms.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        If DebugEnable Then
            Select Case TextBox
                Case Console
                    MessagesTextBox.AppendText(DateTime.Now.ToString(TIMESPEC) & INDENT & "Debug: " & TextString)
                    MessagesTextBox.SelectionStart = MessagesTextBox.TextLength
                    MessagesTextBox.ScrollToCaret()
            End Select
        End If
        Exit Sub
    End Sub

    Private Sub PrintDebugPart(Optional TextString As String = "", Optional TextBox As Integer = 1)

        ' Writes a Debug trace partial string to one of the application's TextBox forms.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        If DebugEnable Then
            PrintString(TextString, TextBox)
        End If
        Exit Sub
    End Sub

    Private Sub PrintDebugFinal(Optional TextString As String = "", Optional TextBox As Integer = 1)

        ' Writes a Debug trace string to one of the application's TextBox forms.
        ' 5th July 2013 - #198 - Modified Print Library to print Errors etc in Red

        If DebugEnable Then
            PrintString(TextString & vbCrLf, TextBox)
        End If
        Exit Sub
    End Sub

End Class
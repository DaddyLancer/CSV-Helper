Imports System.Text.RegularExpressions

Public Class Form2
    Dim NodeTree As New Nodes
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NodeTree.AddNode(Node.Depths.Major, "main", "none", "/root")
        btnListLines.PerformClick()
        'btnPopulate.PerformClick()
    End Sub
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
#If comment Then
    Private Function DivideLines()
        Dim RegexBranch As New Regex("(?<=BRANCH\s).*\/\d*-\d*\/\w+")
        Dim RegexMinor As New Regex("(?<=\H)(\/\d*-\d*\/\w+)")
        Dim RegexMajor As New Regex("\/\d*-\d.(?!\/)")

        Dim strCurrentLine As String = ""
        Dim intMinorsInMajor As Integer
        Dim intBranchesInMinor As Integer
        Dim intLinesInBranch As Integer

        For line = 0 To lstAllLines.Items.Count

            If RegexMajor.IsMatch(lstAllLines.Items(line).ToString) Then
                Dim Majors As New List(Of Major)()
                Dim Major As New Major(RegexMajor.Match(lstAllLines.Items(line)).Value)
            End If
        Next

        Dim Minors As New List(Of Minor)()
        For i As Integer = 0 To intMinorsInMajor
            Dim Minor As New Minor()
            Minor.Name = ""
            Dim NewBranch As New List(Of BranchDetails)()
            For j As Integer = 0 To intBranchesInMinor
                Dim BranchDetail As New BranchDetails()
                For k As Integer = 0 To intLinesInBranch
                    Dim _Cylinders As New List(Of String)
                    Dim _Tees As New List(Of String)
                    Dim _Elbows As New List(Of String)
                    Dim _Flanges As New List(Of String)
                    Dim _Gaskets As New List(Of String)
                    Dim _Reducers As New List(Of String)
                    Dim _Valves As New List(Of String)

                    With strCurrentLine
                        If .Contains("Elbow") Then
                            _Elbows.Add(strCurrentLine)
                        ElseIf .Contains("Cylinder") Then
                            _Cylinders.Add(strCurrentLine)
                        ElseIf .Contains("Tee") Then
                            _Tees.Add(strCurrentLine)
                        ElseIf .Contains("Flange") Then
                            _Flanges.Add(strCurrentLine)
                        ElseIf .Contains("Gasket") Then
                            _Gaskets.Add(strCurrentLine)
                        ElseIf .Contains("Reducer") Then
                            _Reducers.Add(strCurrentLine)
                        ElseIf .Contains("Valve") Then
                            _Valves.Add(strCurrentLine)
                        End If
                    End With

                    BranchDetail.Cylinders = _Cylinders
                    BranchDetail.Tees = _Tees
                    BranchDetail.Elbows = _Elbows
                    BranchDetail.Flanges = _Flanges
                    BranchDetail.Gaskets = _Gaskets
                    BranchDetail.Reducers = _Reducers
                    BranchDetail.Valves = _Valves
                Next
                Minor.BranchDetailLine.Add(BranchDetail)
            Next
            Minors.Add(Minor)
        Next
    End Function
#End If

    Private Sub btnPopulate_Click(sender As Object, e As EventArgs) Handles btnPopulate.Click
        Dim RegMajor As New Regex("(\/\d*;)")
        Dim RegMinor As New Regex("(\/\d*)(-\d.)(?!\/)")
        Dim RegBranch As New Regex("\/\d*-\d*\/\w+", RegexOptions.IgnoreCase)
        Dim RegBranchDetails As New Regex("(gasket|flange|valve|reducer|tee|elbow|attachment)\s?\d.?\s?of branch\s", RegexOptions.IgnoreCase)
        Populate(lstAllLines, TreeView1)
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim opnFile As New OpenFileDialog With {
            .Filter = "Comma Delimited Files (.csv / .txt)|*.csv;*.txt",
            .DefaultExt = ".csv",
            .Multiselect = False,
            .AddExtension = True
        }
        Dim filePath As String
        If opnFile.ShowDialog = DialogResult.OK Then
            filePath = opnFile.FileName
            Dim fileStream As New IO.StreamReader(opnFile.OpenFile)
            While Not fileStream.EndOfStream
                Try
                    lstAllLines.Items.Add(fileStream.ReadLine)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End While
        End If
    End Sub

    Private Sub btnListLines_Click(sender As Object, e As EventArgs) Handles btnListLines.Click
        If txtPaste.TextLength > 0 Then
            Dim strLines As String()
            strLines = txtPaste.Lines
            For i = 0 To UBound(strLines)
                If strLines(i) <> "" Then
                    lstAllLines.Items.Add(strLines(i))
                End If
            Next
        End If
    End Sub
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    Public Function Populate(ByVal StringListBox As ListBox, ByVal TargetTreeView As TreeView)
        Dim RegMajor As New Regex("(\/\d*;)")
        Dim RegMinor As New Regex("(\/\d*)(-\d.)(?!\/)")
        Dim RegBranch As New Regex("\/\d*-\d*\/\w+", RegexOptions.IgnoreCase)
        Dim RegBranchDetails As New Regex("(gasket|flange|valve|reducer|tee|elbow|attachment)\s?\d.?\s?of branch\s", RegexOptions.IgnoreCase)
        Dim UsedIndexes As New List(Of Integer)

        Dim MasterNodes As New List(Of String())
        Dim MinorNodes As New List(Of String())
        Dim BranchNodes As New List(Of String())
        Dim BranchDetailNodes As New List(Of String())

        Dim curMa = 0
        Dim curMi = 0
        Dim curBra = 0
        Dim curDet = 0

        NodeTree = New Nodes


        If StringListBox.Items.Count <= 0 Then
            'Return "Target listbox has no strings"
        End If
        If TargetTreeView.Nodes.Count > 0 Then
            'Debug.Print(NodeTree.)
            'Return "Target Treeview should be empty!"
        End If


        Try
            For i = 0 To StringListBox.Items.Count - 1
                Dim strLine = StringListBox.Items(i).ToString
                If RegMajor.IsMatch(strLine) Then
                    Dim MatchNode = Strings.Trim(RegMajor.Match(strLine).Value).Trim(CChar(";"))
                    Dim NewNode = New TreeNode With {
                            .Name = i,
                            .Text = MatchNode
                        }
                    TargetTreeView.Nodes.Add(NewNode)
                    'Dim Path = TargetTreeView.Nodes.IndexOf(NewNode).ToString
                    'Dim Major As New Major(MatchNode, Path)
                    'NodeTree.AddNode(Node.Depths.Major, MatchNode)
                    curMa = curMa + 1
                    If curMi > 0 Then
                        curMi = 0
                        curBra = 0
                        curDet = 0
                    End If
                ElseIf RegMinor.IsMatch(strLine) Then
                    Dim MatchNode = RegMinor.Match(strLine)
                    Dim NewNode As New TreeNode With {
                            .Name = i,
                            .Text = MatchNode.Value
                        }
                    TargetTreeView.Nodes(curMa - 1).Nodes.Add(NewNode)
                    'Dim Path = TargetTreeView.Nodes.Find(MatchNode.Value, True).First.FullPath
                    'Dim Minor As New Minor(MatchNode.Value,)
                    'NodeTree.AddNode(Node.Depths.Minor,MatchNode.Value)
                    curMi = curMi + 1
                    If curBra > 0 Then
                        curDet = 0
                        curBra = 0
                    End If
                ElseIf RegBranch.IsMatch(strLine) And RegBranchDetails.IsMatch(strLine) = False Then
                    Dim MatchNode = RegBranch.Match(strLine)
                    Dim NewNode As New TreeNode With {
                    .Name = i,
                    .Text = MatchNode.Value
                    }
                    UsedIndexes.Add(i)
                    BranchNodes.Add({NewNode.Name, NewNode.Text, NewNode.Level.ToString})
                    TargetTreeView.Nodes(curMa - 1).Nodes(curMi - 1).Nodes.Add(NewNode)

                    'Dim branch As New Branch(Minor)

                    curBra = curBra + 1

                    If curDet > 0 Then
                        curDet = 0
                    End If
                ElseIf RegBranchDetails.IsMatch(strLine) Then
                    Dim MatchNode = strLine
                    Dim NewNode As New TreeNode With {
                    .Name = i,
                    .Text = strLine
                }
                    UsedIndexes.Add(i)
                    BranchDetailNodes.Add({NewNode.Name, NewNode.Text, NewNode.Level.ToString})
                    TargetTreeView.Nodes(curMa - 1).Nodes(curMi - 1).Nodes(curBra - 1).Nodes.Add(NewNode)
                    curDet = curDet + 1
                Else
                    Debug.Print("No RegEx Match for " & StringListBox.Items(i) & " - at line " & i)
                End If
            Next
        Catch ex As Exception
        End Try
        If TargetTreeView.Nodes.Count > 0 Then
            'Return "Success!"
        Else
            'Return "Failure"
        End If
    End Function

    Public Function AddBranchDetail(ByVal Parent As Branch, ByVal _Tees As List(Of String), ByVal _Flanges As List(Of String),
                                                            ByVal _Elbows As List(Of String), ByVal _Gaskets As List(Of String),
                                                            ByVal _Reducers As List(Of String), ByVal _Valves As List(Of String))

        Dim BranchDetails As New BranchDetails(Parent)
        BranchDetails.Gaskets = _Gaskets
        BranchDetails.Elbows = _Elbows
        BranchDetails.Flanges = _Flanges
        BranchDetails.Tees = _Tees
        BranchDetails.Valves = _Valves
        BranchDetails.Reducers = _Reducers


    End Function


    Public Function AddMinor(ByVal Name As String, ByVal Parent As Major)
        Dim Minor As New Minor(Name, Parent)
        MinorList.Add(Minor)
    End Function
    Public Function AddMajor(ByVal Name As String)
        Dim Major As New Major(Name)
        MajorList.Add(Major)
    End Function

    Public MajorList As New List(Of Major)()
    Public MinorList As New List(Of Minor)()
    Public BranchList As New List(Of Branch)()
    Public BranchDetailList As New List(Of BranchDetails)()
#If comment Then
    Public Sub BranchDivider()
        Dim strCurrentLine As String = ""
        Dim intMinorsInMajor As Integer = 0
        Dim intBranchesInMinor As Integer = 0
        Dim intLinesInBranch As Integer = 0

        Dim Minors As New List(Of Minor)()
        For i As Integer = 0 To intMinorsInMajor
            Dim Minor As New Minor
            Minor.Name = ""
            Dim NewBranch As New List(Of BranchDetails)()
            For j As Integer = 0 To intBranchesInMinor
                Dim BranchDetail As New BranchDetails()
                For k As Integer = 0 To intLinesInBranch
                    Dim _Cylinders As New List(Of String)
                    Dim _Tees As New List(Of String)
                    Dim _Elbows As New List(Of String)
                    Dim _Flanges As New List(Of String)
                    Dim _Gaskets As New List(Of String)
                    Dim _Reducers As New List(Of String)
                    Dim _Valves As New List(Of String)

                    With strCurrentLine
                        If .Contains("Elbow") Then
                            _Elbows.Add(strCurrentLine)
                        ElseIf .Contains("Cylinder") Then
                            _Cylinders.Add(strCurrentLine)
                        ElseIf .Contains("Tee") Then
                            _Tees.Add(strCurrentLine)
                        ElseIf .Contains("Flange") Then
                            _Flanges.Add(strCurrentLine)
                        ElseIf .Contains("Gasket") Then
                            _Gaskets.Add(strCurrentLine)
                        ElseIf .Contains("Reducer") Then
                            _Reducers.Add(strCurrentLine)
                        ElseIf .Contains("Valve") Then
                            _Valves.Add(strCurrentLine)
                        End If
                    End With

                    BranchDetail.Cylinders = _Cylinders
                    BranchDetail.Tees = _Tees
                    BranchDetail.Elbows = _Elbows
                    BranchDetail.Flanges = _Flanges
                    BranchDetail.Gaskets = _Gaskets
                    BranchDetail.Reducers = _Reducers
                    BranchDetail.Valves = _Valves
                Next
                Minor.BranchDetailLine.Add(BranchDetail)
            Next
            Minors.Add(Minor)
        Next
    End Sub
#End If



    'Saves the Treeview Nodes to a binary file
    Private Sub SaveNodes(ByVal filePath As String)
        Dim tmp As New List(Of TNode)
        For Each n As TreeNode In TreeView1.Nodes
            Dim tninfo As New TNode
            tninfo.tn = n
            tmp.Add(tninfo)
        Next
        Using fs As IO.FileStream = IO.File.Open(filePath, IO.FileMode.Create)
            Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
            bf.Serialize(fs, tmp)
        End Using
    End Sub
    'Loads the Treeview Nodes from the binary file
    Private Sub LoadNodes(ByVal filePath As String)
        Dim tmp As New List(Of TNode)
        Using fs As IO.FileStream = IO.File.Open(filePath, IO.FileMode.Open)
            Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
            tmp = CType(bf.Deserialize(fs), List(Of TNode))
        End Using
        For Each n As TNode In tmp
            TreeView1.Nodes.Add(n.tn)
        Next
    End Sub

    Private Sub btnMajors_Click(sender As Object, e As EventArgs) Handles btnMajors.Click
        NodeTree.AddNode(Node.Depths.Major, "Major 1", "/root", "haiii")
        NodeTree.AddNode(Node.Depths.Minor, "Minor 1", "haiii", "")
        NodeTree.AddNode(Node.Depths.Branch, "Branch 1")
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        TextBox1.Text = TreeView1.SelectedNode.FullPath
    End Sub

    Private Sub btnMinors_Click(sender As Object, e As EventArgs) Handles btnMinors.Click

        Debug.Print(NodeTree.CountNodes)
    End Sub
End Class


<Serializable()>
Public Class TNode
    Public tn As TreeNode
End Class
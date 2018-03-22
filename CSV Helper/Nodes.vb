Public Class Nodes
    Implements IEnumerable

    Private AllNodes As New List(Of Node)
    Private allnodesindex As New List(Of Integer)
    Public Sub AddNode(ByVal Depth As Node.Depths, ByVal Name As String, Optional ByVal ParentPath As String = "root", Optional ByVal NodePath As String = vbNullString)

        Try
            Dim ParentMatch = From s In AllNodes
                              Where s.NodePath = ParentPath
                              Select s

            'ParentMatch = vbNull
            'WhereSelectListIterator`2[CSV_Helper.Node,CSV_Helper.Node]'


            AllNodes.Add(New Node With {.Depth = Depth, .NodePath = NodePath, .Parent = ParentMatch})
        Catch ex As Exception
            Debug.Print(ex.ToString)
            AllNodes.Add(New Node With {.Depth = Depth, .NodePath = NodePath, .ID = Name})
        End Try



    End Sub


    Public ReadOnly Property CountNodes
        Get
            Return AllNodes.Count
        End Get
    End Property

    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException()

    End Function

    Private Iterator Function CountByDepth(ByVal Depth As Node.Depths) As IEnumerable
        Dim count As Integer
        For Each node As Node In AllNodes
            If node.Depth = Depth Then
                count = count + 1
                Yield node.NodePath
            End If
        Next
        Yield count
    End Function

End Class



Public Class Node
    Public Enum Depths
        Major
        Minor
        Branch
    End Enum

    Public Property NodePath As String
    Public Property Depth As Depths
    Public Property Parent As Node
    Public Property ID As String

End Class
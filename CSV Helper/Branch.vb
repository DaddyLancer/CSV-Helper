Public Class Branch
    Implements IEnumerable

    Private ItemList As New List(Of Item)
    Private Parent As Minor

    Public Sub New(ByVal Parent As Minor, Optional ByVal NodePath As String = vbNullString)
        Me.Parent = Parent
    End Sub

    Public Sub AddItem(ByVal Type As Item.Types, Optional ByVal NodePath As String = vbNullString)
        ItemList.Add(New Item With {.Type = Type})
    End Sub

    Private Iterator Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator

    End Function

    Public Iterator Function GetNodePaths() As IEnumerator
        For Each item As Item In ItemList
            Yield item.NodePath
        Next
    End Function

    Public ReadOnly Property Flanges As IEnumerable
        Get
            Return CountByType(Item.Types.Flange)
        End Get
    End Property

    Public ReadOnly Property Gaskets As IEnumerable
        Get
            Return CountByType(Item.Types.Gasket)
        End Get
    End Property

    Public ReadOnly Property Elbows As IEnumerable
        Get
            Return CountByType(Item.Types.Elbow)
        End Get
    End Property

    Public ReadOnly Property Tees As IEnumerable
        Get
            Return CountByType(Item.Types.Tee)
        End Get
    End Property

    Public ReadOnly Property Valves As IEnumerable
        Get
            Return CountByType(Item.Types.Valve)
        End Get
    End Property

    Public ReadOnly Property Reducers As IEnumerable
        Get
            Return CountByType(Item.Types.Reducer)
        End Get
    End Property

    Public ReadOnly Property Attachment As IEnumerable
        Get
            Return CountByType(Item.Types.Attachment)
        End Get
    End Property

    Public ReadOnly Property Cylinders As IEnumerable
        Get
            Return CountByType(Item.Types.Cylinder)
        End Get
    End Property

    Private Iterator Function CountByType(ByVal ItemType As Item.Types) As IEnumerable
        Dim count As Integer
        For Each item As Item In ItemList
            If (item.Type = ItemType) Then
                count = count + 1
                'Yield item.NodePath
            End If
        Next
        Yield count
    End Function

End Class


Public Class Item
    Public Enum Types
        Attachment
        Cylinder
        Elbow
        Flange
        Gasket
        Reducer
        Tee
        Valve
    End Enum

    Public Property NodePath As String
    Public Property Type As Types
End Class
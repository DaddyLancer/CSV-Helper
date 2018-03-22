Public Class Major
    Private _Minors As New List(Of Minor)

    Public Sub New(ByVal Name As String, Optional ByVal NodePath As String = vbNullString)
        Me.Name = Name
        Me.NodePath = NodePath
    End Sub

    Public Property NodePath() As String
    Public Property Name() As String

    Public Property Minors() As List(Of Minor)
        Get
            Return _Minors
        End Get
        Set(value As List(Of Minor))
            _Minors = value
        End Set
    End Property

End Class
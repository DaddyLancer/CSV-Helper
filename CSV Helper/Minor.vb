Public Class Minor

    Public Sub New(ByVal Name As String, ByVal Parent As Major, Optional ByVal NodePath As String = vbNullString)
        ParentMajor = Parent
        Me.Name = Name
    End Sub
    Public Property Name() As String

    Public ReadOnly Property ParentName() As String
        Get
            Return ParentMajor.Name
        End Get
    End Property

    Public Property ParentMajor() As Major
        Get
            Return _ParentMajor
        End Get
        Set(value As Major)
            _ParentMajor = value
        End Set
    End Property
    Private _ParentMajor As Major

    Public Property Branches() As List(Of Branch)

    Public Property Branch() As Branch()
        Get
            Return _Branch
        End Get
        Set(value As Branch())
            _Branch = value
        End Set
    End Property
    Private _Branch As Branch()

End Class
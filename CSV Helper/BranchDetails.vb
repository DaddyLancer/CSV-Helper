Public Class BranchDetails




    Public Sub New(ByVal Parent As Branch)
        Me.Parent = Parent
    End Sub

    Public Property Parent() As Branch
        Set(value As Branch)
            _Parent = value
        End Set
        Get
            Return _Parent
        End Get
    End Property
    Private _Parent As Branch

    Public ReadOnly Property ParentO()
        Get
            Return Parent
        End Get
    End Property


    Public Property Flanges() As List(Of String)
        Set(value As List(Of String))
            _Flanges = value
        End Set
        Get
            Return _Flanges
        End Get
    End Property
    Private _Flanges As List(Of String)

    Public Property Elbows() As List(Of String)
        Set(value As List(Of String))
            _Elbows = value
        End Set
        Get
            Return _Elbows
        End Get
    End Property
    Private _Elbows As List(Of String)

    Public Property Tees() As List(Of String)
        Set(value As List(Of String))
            _Tees = value
        End Set
        Get
            Return _Tees
        End Get
    End Property
    Private _Tees As List(Of String)

    Public Property Reducers() As List(Of String)
        Set(value As List(Of String))
            _Reducers = value
        End Set
        Get
            Return _Reducers
        End Get
    End Property
    Private _Reducers As List(Of String)

    Public Property Valves() As List(Of String)
        Set(value As List(Of String))
            _Valves = value
        End Set
        Get
            Return _Valves
        End Get
    End Property
    Private _Valves As List(Of String)

    Public Property Gaskets() As List(Of String)
        Set(value As List(Of String))
            _Gaskets = value
        End Set
        Get
            Return _Gaskets
        End Get
    End Property
    Private _Gaskets As List(Of String)

    Public Property Cylinders() As List(Of String)
        Set(value As List(Of String))
            _Cylinders = value
        End Set
        Get
            Return _Cylinders
        End Get
    End Property
    Private _Cylinders As List(Of String)

End Class

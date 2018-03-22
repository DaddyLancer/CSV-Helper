'Author: Aeonhack
'
'Toggle just about any object to and from a byte() array using
'these two simple methods.

'Sample Usage:
'<Serializable()> Class Customer
'    Public First, Last As String, Age As Integer
'    Sub New(ByVal _first As String, ByVal _last As String, ByVal _age As Integer)
'        First = _first : Last = _last : Age = _age
'    End Sub
'End Class

'Serialize our object, converting it into a byte array. After this
'process is complete you may do some of the following things to it:
'encrypt, compress, and/or write it to the HDD.

'Dim Data = Serialize(New Customer("John", "Connor", 19))

'This is not limited to custom classes, you could use it on things
'such as strings, arrays, controls, forms, or anything
'that has the <Serializable()> attribute applied to it.

'If you want to get your object back into it's original state we
'simply pass the "(Of Type)(Data())" to our Deserialize function.

'Dim John = Deserialize(Of Customer)(Data)
Imports System.Runtime.Serialization.Formatters.Binary
Class Serialize
    Shared Function Serialize(ByVal data As Object) As Byte()
        If TypeOf data Is Byte() Then Return data
        Using M As New IO.MemoryStream : Dim F As New BinaryFormatter : F.Serialize(M, data) : Return M.ToArray() : End Using
    End Function
    Shared Function Deserialize(Of T)(ByVal data As Byte()) As T
        Using M As New IO.MemoryStream(data, False) : Return CType((New BinaryFormatter).Deserialize(M), T) : End Using
    End Function
End Class

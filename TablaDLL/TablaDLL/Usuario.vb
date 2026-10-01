Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Usuario
    Private cad As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub
    Public Function Loguear(ByVal usuario As String, ByVal pass As String) As Boolean
        Dim sql As String
        sql = "select * from usuario"
        sql = sql + " where usuario =" + "'" + usuario + "'"
        sql = sql + " and password =" + "'" + pass + "'"
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        If t.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

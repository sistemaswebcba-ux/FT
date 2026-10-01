Imports System.Data
Imports Microsoft.ApplicationBlocks.Data
Public Class MenuPrincipal
    Private cad As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub
    Public Function GetMenuPrincipal() As DataTable
        Dim sql As String = "select * from menuprincipal"
        Return SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
    End Function
End Class

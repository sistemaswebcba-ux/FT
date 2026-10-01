Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Menu
    Public cad As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function MenuGetbyTorneo(ByVal IdTorneo As Integer) As DataTable
        Dim sql As String
        sql = "select * from menu where IdTorneo =" + IdTorneo.ToString()
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function



End Class

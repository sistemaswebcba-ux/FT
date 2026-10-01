Imports System.Data
Imports Microsoft.ApplicationBlocks.Data
Public Class Torneo
    Private cad As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function TorneoGetbyId(ByVal IdTorneo As Integer) As DataTable
        Dim sql As String
        sql = "select * from torneo where Idtorneo =" + IdTorneo.ToString()
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function TorneoAll() As DataTable
        Dim sql As String
        sql = "select * from torneo "
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function TorneoGetArchivos()
        Dim sql As String
        sql = "select * from torneo where Archivar ='S' order by IdTorneo desc"
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

End Class

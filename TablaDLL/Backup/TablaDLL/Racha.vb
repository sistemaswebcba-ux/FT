Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Racha
    Public cad As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function RachaPositivaGet(ByVal IdTorneo As Integer) As DataTable
        Dim sql As String
        
        sql = "select r.*,e.foto"
        sql = sql + " from racha r,equipo e"
        sql = sql + " where r.idequipo = e.idequipo"
        sql = sql + " and idtorneo=" + IdTorneo.ToString()
        sql = sql + " and tipo =1"
        sql = sql + " order by puntos desc"
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function RachaNegativaGet(ByVal IdTorneo As Integer) As DataTable
        Dim sql As String

        sql = "select r.*,e.foto"
        sql = sql + " from racha r,equipo e"
        sql = sql + " where r.idequipo = e.idequipo"
        sql = sql + " and idtorneo=" + IdTorneo.ToString()
        sql = sql + " and tipo = 2"
        sql = sql + " order by puntos desc"

        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function
End Class

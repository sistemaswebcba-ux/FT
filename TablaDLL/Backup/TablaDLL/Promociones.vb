Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Promociones
    Public cad As String
    Private sql As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function PromocionesGetbyCategoria(ByVal Categoria As Integer) As DataTable
        sql = " select p.*,l.equipo as local ,v.equipo as visitante,"
        sql = sql + "t.torneo,t.temporada"
        sql = sql + " from dbo.Promociones p, equipo l,equipo v,torneo t"
        sql = sql + " where p.idlocal = l.idequipo"
        sql = sql + " and p.idvisitante=v.idequipo"
        sql = sql + " and p.IdTorneo=t.IdTorneo"
        sql = sql + " and p.categoria = " + Categoria.ToString()
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

End Class

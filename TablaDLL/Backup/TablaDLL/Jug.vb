Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Jug
    Public cad As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub
    Public Function Goleadores(ByVal idtorneo As Integer)
        Dim sql As String
        sql = "select j.nombre, count(idjugada) as goles,e.equipo"
        sql = sql + " from goles g,jug j,equipo e"
        sql = sql + " where g.idjugador=j.id"
        sql = sql + " and g.idequipo = e.idequipo"
        sql = sql + " and idtorneo =" + idtorneo.ToString()
        sql = sql + " and g.IdJugada <> 5"
        sql = sql + " group by j.nombre,e.equipo"
        sql = sql + " order by 2 desc"
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function
End Class

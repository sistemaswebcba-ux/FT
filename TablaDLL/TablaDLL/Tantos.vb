Imports System.Data
Imports Microsoft.ApplicationBlocks.Data

Public Class Tantos
    Public cad As String
    Public sql As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function Goles(ByVal IdPartido) As DataTable
        sql = "select f.idlocal,l.equipo as local,l.foto as fotol, f.gl, f.idvisitante, v.equipo as visitante , f.gv,v.foto as fotov, f.fechapartido"
        sql = sql + " from fixture f,equipo l,equipo v"
        sql = sql + " where f.idlocal= l.idequipo"
        sql = sql + " and f.idvisitante = v.idequipo "
        sql = sql + " and idpartido =" + IdPartido.ToString()
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function GolesDetallados(ByVal IdPartido)
        sql = "select g.*,e.equipo,j.nombre,ju.jugada"
        sql = sql + " from goles g,jug j,jugada ju,equipo e"
        sql = sql + " where g.idjugador=j.id"
        sql = sql + " and g.idjugada =ju.id"
        sql = sql + " and g.idequipo=e.idequipo"
        sql = sql + " and idpartido=" + IdPartido.ToString()
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function TablaGetGolesaFavor(ByVal IdTorneo As Integer)
        Dim obj As New Tabla()
        Dim dv As New DataView()
        dv = obj.TablaGral(IdTorneo)
        Dim vista As New DataView()
        dv.Sort = "GF desc"
        Dim i As Integer
        i = 1
        For Each fila As DataRowView In dv
            fila.Item("pos") = i
            i = i + 1
        Next
        Return dv
    End Function

    Public Function TablaGetGolesenContra(ByVal IdTorneo As Integer)
        Dim obj As New Tabla()
        Dim dv As New DataView()
        dv = obj.TablaGral(IdTorneo)
        Dim vista As New DataView()
        dv.Sort = "GC desc"
        Dim i As Integer
        i = 1
        For Each fila As DataRowView In dv
            fila.Item("pos") = i
            i = i + 1
        Next
        Return dv
    End Function


End Class

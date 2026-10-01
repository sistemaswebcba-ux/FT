Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Equipo
    Public cad As String
    Public Function EquiposGetAll(ByVal Categoria As Integer)
        Dim t As New DataTable
        Dim sql As String
        sql = "select * from equipo where categoria=" + Categoria.ToString()
        sql = sql + " order by equipo"
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function EquipoGetbyId(ByVal IdEquipo As Integer) As DataTable
        Dim t As DataTable
        Dim sql As String
        sql = "select * from equipo where idequipo=" + IdEquipo.ToString()
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function EquiposGetAllbyZona(ByVal Categoria As Integer, ByVal Zona As Integer)
        Dim t As New DataTable
        Dim sql As String
        sql = "select * from equipo where categoria=" + Categoria.ToString()
        sql = sql + " and Zona=" + Zona.ToString()
        sql = sql + " order by equipo"
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function EquiposGetbyEquiposxTorneo(ByVal IdTorneo As Integer) As DataTable
        Dim sql As String
        sql = "select e.*"
        sql = sql + " from EquiposxTorneo et,equipo e"
        sql = sql + " where et.idequipo = e.idequipo"
        sql = sql + " and et.idtorneo=" + IdTorneo.ToString()
        sql = sql + " order by e.equipo"
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

End Class

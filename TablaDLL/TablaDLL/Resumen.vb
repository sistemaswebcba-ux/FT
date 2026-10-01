Imports System.Data
Imports Microsoft.ApplicationBlocks.Data
Public Class Resumen
    Public Function GetResumenxCondicion(ByVal Condicion As String, ByVal IdTorneo As Integer) As Integer
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim sql As String = ""
        sql = "select sum(" + Condicion + ")"
        sql = sql + " from fixture "
        sql = sql + " where IdTorneo =" + IdTorneo.ToString()
        sql = sql + " and jugo =1"
        sql = sql + " and " + Condicion + "=1"
        Dim resul As Integer = 0
        resul = SqlHelper.ExecuteScalar(cad, CommandType.Text, sql)
        Return resul
    End Function

    Public Function GetResumenxGoles(ByVal Condicion As String, ByVal IdTorneo As Integer) As Integer
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim sql As String = ""
        sql = "select sum(" + Condicion + ")"
        sql = sql + " from fixture "
        sql = sql + " where IdTorneo =" + IdTorneo.ToString()
        sql = sql + " and jugo =1"
        Dim resul As Integer = 0
        resul = SqlHelper.ExecuteScalar(cad, CommandType.Text, sql)
        Return resul
    End Function

    Public Function GetResumenxResultados(ByVal IdTorneo As Integer) As DataTable
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim sql As String = ""
        sql = "select gl,gv,count(IdTorneo) as can"
        sql = sql + " from fixture "
        sql = sql + " where IdTorneo =" + IdTorneo.ToString()
        sql = sql + " and jugo =1"
        sql = sql + " group by gl,gv"
        sql = sql + " order by can desc"

        Dim resul As DataTable
        resul = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return resul
    End Function

    Public Function GetResumenxEquipoLocal(ByVal IdEquipo As Integer, ByVal IdTorneo As Integer) As DataTable
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim sql As String = ""
        sql = "select gl,gv,count(IdTorneo) as can"
        sql = sql + " from fixture "
        sql = sql + " where IdTorneo =" + IdTorneo.ToString()
        sql = sql + " and jugo =1"
        sql = sql + " and IdLocal =" + IdEquipo.ToString()
        sql = sql + " group by gl,gv"
        sql = sql + " order by can desc"

        Dim resul As DataTable
        resul = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return resul
    End Function

    Public Function GetResumenxEquipoVisitante(ByVal IdEquipo As Integer, ByVal IdTorneo As Integer) As DataTable
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim sql As String = ""
        sql = "select gl,gv,count(IdTorneo) as can"
        sql = sql + " from fixture "
        sql = sql + " where IdTorneo =" + IdTorneo.ToString()
        sql = sql + " and jugo =1"
        sql = sql + " and IdVisitante =" + IdEquipo.ToString()
        sql = sql + " group by gl,gv"
        sql = sql + " order by can desc"
        Dim resul As DataTable
        resul = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return resul
    End Function


End Class

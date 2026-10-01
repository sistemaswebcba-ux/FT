Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Fixture
    Public cad As String
    Public sql As String

    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function FixtureGetbyFecha(ByVal idtorneo As Integer, ByVal fecha As Integer) As DataTable
        sql = "select f.*,l.idequipo as idlocal,l.equipo as local,l.foto as fotol,v.idequipo as idvisitante,v.equipo as visitante,v.foto as fotov"

        sql = sql + " from fixture f,equipo l,equipo v"
        sql = sql + " where f.idlocal = l.idequipo"
        sql = sql + " and f.idvisitante = v.idequipo"
        sql = sql + " and IdTorneo=" + idtorneo.ToString()
        sql = sql + " and fecha=" + fecha.ToString()
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function FixtureGetbyTorneo(ByVal idtorneo As Integer) As DataTable
        sql = "select f.*,l.idequipo,l.equipo as local,l.foto,v.idequipo,v.equipo as visitante"
        sql = sql + " ,l.foto as FotoL,v.foto as FotoV"
        sql = sql + " from fixture f,equipo l,equipo v"
        sql = sql + " where f.idlocal = l.idequipo"
        sql = sql + " and f.idvisitante = v.idequipo"
        sql = sql + " and IdTorneo=" + idtorneo.ToString()

        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function MaxFecha(ByVal idTorneo As Integer) As Integer
        sql = "Select  isnull(max(fecha),0)"
        sql = sql + " from Fixture"
        sql = sql + " where idTorneo = " + idTorneo.ToString()
        sql = sql + " and jugo=1"
        Dim fecha As Integer
        fecha = Convert.ToInt16(SqlHelper.ExecuteScalar(cad, CommandType.Text, sql))
        If fecha > 0 Then
            fecha = fecha - 1
        End If
        Return fecha
    End Function

    Public Function FixtureGetbyEquipo(ByVal IdTorneo As Integer, ByVal IdEquipo As Integer) As DataTable
        sql = " select f.idpartido, f.fecha,l.equipo as local, f.gl,v.equipo as visitante,f.gv,f.fechapartido,f.jugo"
        sql = sql + " from fixture f,equipo l,equipo v"
        sql = sql + " where f.idlocal=l.idequipo"
        sql = sql + " and f.idvisitante = v.idequipo"
        sql = sql + " and(f.idlocal=" + IdEquipo.ToString()
        sql = sql + " or f.idvisitante=" + IdEquipo.ToString()
        sql = sql + " )and f.idtorneo=" + IdTorneo.ToString()
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function GetFixtureParaSimular(ByVal IdTorneo As String) As DataTable
        Dim fecha As Integer
        fecha = MaxFecha(IdTorneo)
        fecha = fecha + 1
        Dim sql As String
        sql = "select * from fixture where fecha =" + fecha.ToString()
        sql = sql + " and jugo =0"
        sql = sql + " and IdTorneo=" + IdTorneo.ToString()
        'linea nueva
        sql = sql + " and idlocal <> idvisitante"
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        If t.Rows.Count = 0 Then
            fecha = fecha + 1
        End If
        sql = " select f.*,l.equipo as local,v.equipo as visitante  from fixture f,equipo l,equipo v "
        sql = sql + " where f.idlocal =l.idequipo "
        sql = sql + " and f.idvisitante = v.idequipo "
        sql = sql + " and f.fecha =" + fecha.ToString()
        sql = sql + " and f.idtorneo =" + IdTorneo.ToString()
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

    Public Function GetFixtureByMinitorneo(ByVal v() As Integer, ByVal can As Integer, ByVal idtorneo As Integer) As DataView
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim sql As String
        Dim t As New DataTable
        Dim t1, t2 As DataTable
        t.Columns.Add("IdPartido")
        t.Columns.Add("Fecha")
        t.Columns.Add("IdLocal")
        t.Columns.Add("IdVisitante")
        t.Columns.Add("Gl")
        t.Columns.Add("Gv")
        t.Columns.Add("Local")
        t.Columns.Add("Visitante")
        t.Columns.Add("FechaPartido")
        Dim i, j, k, ban As Integer
        ban = 0
        For i = 0 To can - 1
            For j = 0 To can - 1
                If i <> j Then
                    sql = "select f.*,l.equipo as local,v.equipo as visitante from fixture f,equipo l,equipo v"
                    sql = sql + " where f.idlocal =l.idequipo "
                    sql = sql + " and f.idvisitante = v.idequipo"
                    sql = sql + " and idlocal =" + v(i).ToString()
                    sql = sql + " and idvisitante =" + v(j).ToString()
                    sql = sql + " and IdTorneo =" + idtorneo.ToString()
                    sql = sql + " and jugo =1"
                    t1 = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
                    If t1.Rows.Count > 0 Then
                        For k = 0 To t.Rows.Count - 1
                            If t.Rows(k)("idlocal").ToString() = v(i).ToString() And t.Rows(k)("idvisitante").ToString() = v(j).ToString() Then
                                ban = 1
                            End If
                        Next
                        If ban = 0 Then
                            Dim r As DataRow
                            r = t.NewRow
                            r("IdLocal") = t1.Rows(0)("IdLocal").ToString()
                            r("IdVisitante") = t1.Rows(0)("IdVisitante").ToString()
                            r("Fecha") = t1.Rows(0)("fecha").ToString()
                            r("FechaPartido") = t1.Rows(0)("FechaPartido").ToString()
                            r("Gl") = t1.Rows(0)("Gl").ToString()
                            r("Gv") = t1.Rows(0)("Gv").ToString()
                            r("Local") = t1.Rows(0)("Local").ToString()
                            r("Visitante") = t1.Rows(0)("Visitante").ToString()
                            t.Rows.Add(r)
                            ban = 0
                        End If

                    End If
                End If
                next
        Next
        'sql = "select f.*,l.equipo as local,v.equipo as visitante from fixture f,equipo l,equipo v"
        'sql = sql + " where f.idlocal =l.idequipo "
        'sql = sql + " and f.idvisitante = v.idequipo"
        'sql = sql + " and idlocal =" + v(j).ToString()
        'sql = sql + " and idvisitante =" + v(i).ToString()
        'sql = sql + " and IdTorneo =" + idtorneo.ToString()
        't1 = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        'If t1.Rows.Count > 0 Then
        'Dim r As DataRow
        'r = t.NewRow
        'r("IdLocal") = t1.Rows(0)("IdLocal").ToString()
        'r("IdVisitante") = t1.Rows(0)("IdVisitante").ToString()
        'r("Fecha") = t1.Rows(0)("fecha").ToString()
        'r("FechaPartido") = t1.Rows(0)("FechaPartido").ToString()
        'r("Gl") = t1.Rows(0)("Gl").ToString()
        'r("Gv") = t1.Rows(0)("Gv").ToString()
        'r("Local") = t1.Rows(0)("Local").ToString()
        'r("Visitante") = t1.Rows(0)("Visitante").ToString()
        't.Rows.Add(r)


                
        Dim dv As DataView
        dv = t.DefaultView
        dv.Sort = "fecha"
        Return dv
    End Function

    Public Function GetCantidaddeFechasxTorneo(ByVal idTorneo As Integer) As Integer
        Dim sql As String
        sql = "select count(distinct fecha)"
        sql = sql + " from fixture f"
        sql = sql + " where f.idtorneo =" + idTorneo.ToString()
        Dim can As Integer
        can = Convert.ToInt32(SqlHelper.ExecuteScalar(cad, CommandType.Text, sql))
        Return can
    End Function

End Class

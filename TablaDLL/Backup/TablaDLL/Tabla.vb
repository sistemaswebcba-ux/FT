Imports System.Data
Imports Microsoft.ApplicationBlocks.Data
Public Class Tabla

    Public Function TablaGral(ByVal idTorneoSeleccionado As Integer) As DataView
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim tl, tv As DataTable
        tl = SqlHelper.ExecuteDataset(cad, "TablaLocalGet", idTorneoSeleccionado).Tables(0)
        tv = SqlHelper.ExecuteDataset(cad, "TablaVisitanteGet", idTorneoSeleccionado).Tables(0)
        tl = CompletarTabla(tl, idTorneoSeleccionado)
        tv = CompletarTabla(tv, idTorneoSeleccionado)
        Dim i, j As Integer
        For i = 0 To tl.Rows.Count - 1
            For j = 0 To tv.Rows.Count - 1
                If tl.Rows(i)("idequipo").ToString() = tv.Rows(j)("idequipo").ToString() Then
                    tl.Rows(i)("PTS") = Convert.ToInt16(tl.Rows(i)("PTS")) + Convert.ToInt16(tv.Rows(j)("PTS"))
                    tl.Rows(i)("PJ") = Convert.ToInt16(tl.Rows(i)("PJ")) + Convert.ToInt16(tv.Rows(j)("PJ"))
                    tl.Rows(i)("G") = Convert.ToInt16(tl.Rows(i)("G")) + Convert.ToInt16(tv.Rows(j)("G"))
                    tl.Rows(i)("E") = Convert.ToInt16(tl.Rows(i)("E")) + Convert.ToInt16(tv.Rows(j)("E"))
                    tl.Rows(i)("P") = Convert.ToInt16(tl.Rows(i)("P")) + Convert.ToInt16(tv.Rows(j)("P"))
                    tl.Rows(i)("GF") = Convert.ToInt16(tl.Rows(i)("GF")) + Convert.ToInt16(tv.Rows(j)("GF"))
                    tl.Rows(i)("GC") = Convert.ToInt16(tl.Rows(i)("GC")) + Convert.ToInt16(tv.Rows(j)("GC"))
                    tl.Rows(i)("DIF") = Convert.ToInt16(tl.Rows(i)("DIF")) + Convert.ToInt16(tv.Rows(j)("DIF"))
                End If
            Next
        Next
        tl.Select("", "pts desc", DataViewRowState.CurrentRows)
        'Dim DV As New DataView(tl, "", "PTS DESC", DataViewRowState.CurrentRows)
        Dim vista As New DataView()
        tl.DefaultView.Sort = "pts desc,dif desc,gf desc"
        vista = tl.DefaultView

        i = 1
        For Each fila As DataRowView In vista
            fila.Item("pos") = i
            i = i + 1
        Next
        'Grilla.DataSource = vista
        Return vista

    End Function

    Public Function CargarTablaL(ByVal idTorneoSeleccionado As Integer) As DataTable
        Dim cad As String
        Dim con As New Conexion()
        cad = con.Cadena()
        Dim t As DataTable
        Dim i As Integer
        i = 1
        Dim r As DataRow
        t = SqlHelper.ExecuteDataset(cad, "TablaLocalGet", idTorneoSeleccionado).Tables(0)
        For Each r In t.Rows
            r("pos") = i
            i = i + 1
        Next
        Return t
    End Function

    Public Function CargarTablaV(ByVal idTorneoSeleccionado As Integer) As DataTable
        Dim cad As String
        Dim con As New Conexion()
        cad = con.Cadena()
        Dim t As DataTable
        Dim i As Integer
        i = 1
        Dim r As DataRow
        t = SqlHelper.ExecuteDataset(cad, "TablaVisitanteGet", idTorneoSeleccionado).Tables(0)
        For Each r In t.Rows
            r("pos") = i
            i = i + 1
        Next
        Return t
    End Function

    Public Function CargarTablaTiempos(ByVal idTorneoSeleccionado As Integer, ByVal tiempo As Integer) As DataView
        Dim cad As String
        Dim con As New Conexion()
        cad = con.Cadena()
        Dim tl, tv As DataTable
        Dim idtorneo As Integer
        idtorneo = idTorneoSeleccionado
        tl = SqlHelper.ExecuteDataset(cad, "TablaLocalGetxTiempo", idtorneo, tiempo).Tables(0)
        tv = SqlHelper.ExecuteDataset(cad, "TablaVisitanteGetxTiempo", idtorneo, tiempo).Tables(0)
        Dim i, j As Integer
        For i = 0 To tl.Rows.Count - 1
            For j = 0 To tv.Rows.Count - 1
                If tl.Rows(i)("idequipo").ToString() = tv.Rows(j)("idequipo").ToString() Then
                    tl.Rows(i)("PTS") = Convert.ToInt16(tl.Rows(i)("PTS")) + Convert.ToInt16(tv.Rows(j)("PTS"))
                    tl.Rows(i)("PJ") = Convert.ToInt16(tl.Rows(i)("PJ")) + Convert.ToInt16(tv.Rows(j)("PJ"))
                    tl.Rows(i)("G") = Convert.ToInt16(tl.Rows(i)("G")) + Convert.ToInt16(tv.Rows(j)("G"))
                    tl.Rows(i)("E") = Convert.ToInt16(tl.Rows(i)("E")) + Convert.ToInt16(tv.Rows(j)("E"))
                    tl.Rows(i)("P") = Convert.ToInt16(tl.Rows(i)("P")) + Convert.ToInt16(tv.Rows(j)("P"))
                    tl.Rows(i)("GF") = Convert.ToInt16(tl.Rows(i)("GF")) + Convert.ToInt16(tv.Rows(j)("GF"))
                    tl.Rows(i)("GC") = Convert.ToInt16(tl.Rows(i)("GC")) + Convert.ToInt16(tv.Rows(j)("GC"))
                    tl.Rows(i)("DIF") = Convert.ToInt16(tl.Rows(i)("DIF")) + Convert.ToInt16(tv.Rows(j)("DIF"))
                End If
            Next
        Next
        tl.Select("", "pts desc", DataViewRowState.CurrentRows)
        'Dim DV As New DataView(tl, "", "PTS DESC", DataViewRowState.CurrentRows)
        Dim vista As New DataView()
        tl.DefaultView.Sort = "pts desc,dif desc"
        vista = tl.DefaultView

        i = 1
        For Each fila As DataRowView In vista
            fila.Item("pos") = i
            i = i + 1
        Next
        Return vista
    End Function

    Public Function cargarporfechas(ByVal idTorneoSeleccionado As Integer, ByVal fechaDesde As Integer, ByVal fechaHasta As Integer) As DataView
        Dim tl, tv As DataTable
        Dim cad As String
        Dim con As New Conexion()
        cad = con.Cadena()
        tl = SqlHelper.ExecuteDataset(cad, "TablaLocalGetxFechas", idTorneoSeleccionado, fechaDesde, fechaHasta).Tables(0)
        tl = CompletarTabla(tl, idTorneoSeleccionado)
        tv = SqlHelper.ExecuteDataset(cad, "TablaVisitanteGetxFechas", idTorneoSeleccionado, fechaDesde, fechaHasta).Tables(0)
        tv = CompletarTabla(tv, idTorneoSeleccionado)
        Dim i, j As Integer
        For i = 0 To tl.Rows.Count - 1
            For j = 0 To tv.Rows.Count - 1
                If tl.Rows(i)("idequipo").ToString() = tv.Rows(j)("idequipo").ToString() Then
                    tl.Rows(i)("PTS") = Convert.ToInt16(tl.Rows(i)("PTS")) + Convert.ToInt16(tv.Rows(j)("PTS"))
                    tl.Rows(i)("PJ") = Convert.ToInt16(tl.Rows(i)("PJ")) + Convert.ToInt16(tv.Rows(j)("PJ"))
                    tl.Rows(i)("G") = Convert.ToInt16(tl.Rows(i)("G")) + Convert.ToInt16(tv.Rows(j)("G"))
                    tl.Rows(i)("E") = Convert.ToInt16(tl.Rows(i)("E")) + Convert.ToInt16(tv.Rows(j)("E"))
                    tl.Rows(i)("P") = Convert.ToInt16(tl.Rows(i)("P")) + Convert.ToInt16(tv.Rows(j)("P"))
                    tl.Rows(i)("GF") = Convert.ToInt16(tl.Rows(i)("GF")) + Convert.ToInt16(tv.Rows(j)("GF"))
                    tl.Rows(i)("GC") = Convert.ToInt16(tl.Rows(i)("GC")) + Convert.ToInt16(tv.Rows(j)("GC"))
                    tl.Rows(i)("DIF") = Convert.ToInt16(tl.Rows(i)("DIF")) + Convert.ToInt16(tv.Rows(j)("DIF"))
                End If
            Next
        Next
        tl.Select("", "pts desc", DataViewRowState.CurrentRows)
        'Dim DV As New DataView(tl, "", "PTS DESC", DataViewRowState.CurrentRows)
        Dim vista As New DataView()
        tl.DefaultView.Sort = "pts desc,dif desc"
        vista = tl.DefaultView

        i = 1
        For Each fila As DataRowView In vista
            fila.Item("pos") = i
            i = i + 1
        Next
        Return vista
    End Function

    Private Function CompletarTabla(ByVal t As DataTable, ByVal idTorneoSeleccionado As Integer) As DataTable
        Dim tequipos As DataTable
        Dim sql As String = ""
        sql = "select et.*,e.equipo from EquiposxTorneo et,equipo e"
        sql = sql + " where et.idequipo = e.idequipo"
        sql = sql + " and idtorneo =" + idTorneoSeleccionado.ToString()
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        tequipos = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Dim ban As Integer = 0
        For i As Integer = 0 To tequipos.Rows.Count - 1
            For j As Integer = 0 To t.Rows.Count - 1
                If (t.Rows(j)("IdEquipo").ToString() = tequipos.Rows(i)("IdEquipo").ToString()) Then
                    ban = 1
                End If
            Next
            If (ban = 0) Then
                'no esta el equipo debo agregarlo
                Dim r As DataRow
                r = t.NewRow
                r("IdEquipo") = tequipos.Rows(i)("IdEquipo")
                r("PTS") = 0
                r("PJ") = 0
                r("G") = 0
                r("E") = 0
                r("P") = 0
                r("GF") = 0
                r("GC") = 0
                r("DIF") = 0
                r("EQUIPO") = tequipos.Rows(i)("Equipo")
                t.Rows.Add(r)
            End If
            ban = 0
        Next
        Return t


    End Function

    Public Function CargarTablaAnual(ByVal IdTorneo1 As Integer, ByVal fd1 As Integer, ByVal fh1 As Integer, ByVal IdTorneo2 As Integer, ByVal fd2 As Integer, ByVal fh2 As Integer)
        Dim tl, tv, tl2, tv2 As DataTable
        Dim cad As String
        Dim con As New Conexion()
        cad = con.Cadena()
        tl = SqlHelper.ExecuteDataset(cad, "TablaLocalGetxFechas", IdTorneo2, fd2, fh2).Tables(0)
        tv = SqlHelper.ExecuteDataset(cad, "TablaVisitanteGetxFechas", IdTorneo2, fd2, fh2).Tables(0)
        Dim i, j As Integer
        For i = 0 To tl.Rows.Count - 1
            For j = 0 To tv.Rows.Count - 1
                If tl.Rows(i)("idequipo").ToString() = tv.Rows(j)("idequipo").ToString() Then
                    tl.Rows(i)("PTS") = Convert.ToInt16(tl.Rows(i)("PTS")) + Convert.ToInt16(tv.Rows(j)("PTS"))
                    tl.Rows(i)("PJ") = Convert.ToInt16(tl.Rows(i)("PJ")) + Convert.ToInt16(tv.Rows(j)("PJ"))
                    tl.Rows(i)("G") = Convert.ToInt16(tl.Rows(i)("G")) + Convert.ToInt16(tv.Rows(j)("G"))
                    tl.Rows(i)("E") = Convert.ToInt16(tl.Rows(i)("E")) + Convert.ToInt16(tv.Rows(j)("E"))
                    tl.Rows(i)("P") = Convert.ToInt16(tl.Rows(i)("P")) + Convert.ToInt16(tv.Rows(j)("P"))
                    tl.Rows(i)("GF") = Convert.ToInt16(tl.Rows(i)("GF")) + Convert.ToInt16(tv.Rows(j)("GF"))
                    tl.Rows(i)("GC") = Convert.ToInt16(tl.Rows(i)("GC")) + Convert.ToInt16(tv.Rows(j)("GC"))
                    tl.Rows(i)("DIF") = Convert.ToInt16(tl.Rows(i)("DIF")) + Convert.ToInt16(tv.Rows(j)("DIF"))
                End If
            Next
        Next
        tl2 = SqlHelper.ExecuteDataset(cad, "TablaLocalGetxFechas", IdTorneo1, fd1, fh1).Tables(0)
        tv2 = SqlHelper.ExecuteDataset(cad, "TablaVisitanteGetxFechas", IdTorneo1, fd1, fh1).Tables(0)
        
        For i = 0 To tl.Rows.Count - 1
            For j = 0 To tv.Rows.Count - 1
                If tl2.Rows(i)("idequipo").ToString() = tv2.Rows(j)("idequipo").ToString() Then
                    tl2.Rows(i)("PTS") = Convert.ToInt16(tl2.Rows(i)("PTS")) + Convert.ToInt16(tv2.Rows(j)("PTS"))
                    tl2.Rows(i)("PJ") = Convert.ToInt16(tl2.Rows(i)("PJ")) + Convert.ToInt16(tv2.Rows(j)("PJ"))
                    tl2.Rows(i)("G") = Convert.ToInt16(tl2.Rows(i)("G")) + Convert.ToInt16(tv2.Rows(j)("G"))
                    tl2.Rows(i)("E") = Convert.ToInt16(tl2.Rows(i)("E")) + Convert.ToInt16(tv2.Rows(j)("E"))
                    tl2.Rows(i)("P") = Convert.ToInt16(tl2.Rows(i)("P")) + Convert.ToInt16(tv2.Rows(j)("P"))
                    tl2.Rows(i)("GF") = Convert.ToInt16(tl2.Rows(i)("GF")) + Convert.ToInt16(tv2.Rows(j)("GF"))
                    tl2.Rows(i)("GC") = Convert.ToInt16(tl2.Rows(i)("GC")) + Convert.ToInt16(tv2.Rows(j)("GC"))
                    tl2.Rows(i)("DIF") = Convert.ToInt16(tl2.Rows(i)("DIF")) + Convert.ToInt16(tv2.Rows(j)("DIF"))

                End If
            Next
        Next
        Dim encontro As Integer
        encontro = 0
        For i = 0 To tl.Rows.Count - 1
            For j = 0 To tl2.Rows.Count - 1
                If tl.Rows(i)("idequipo").ToString() = tl2.Rows(j)("idequipo").ToString() Then
                    tl.Rows(i)("PTS") = Convert.ToInt16(tl.Rows(i)("PTS")) + Convert.ToInt16(tl2.Rows(j)("PTS"))
                    tl.Rows(i)("PJ") = Convert.ToInt16(tl.Rows(i)("PJ")) + Convert.ToInt16(tl2.Rows(j)("PJ"))
                    tl.Rows(i)("G") = Convert.ToInt16(tl.Rows(i)("G")) + Convert.ToInt16(tl2.Rows(j)("G"))
                    tl.Rows(i)("E") = Convert.ToInt16(tl.Rows(i)("E")) + Convert.ToInt16(tl2.Rows(j)("E"))
                    tl.Rows(i)("P") = Convert.ToInt16(tl.Rows(i)("P")) + Convert.ToInt16(tl2.Rows(j)("P"))
                    tl.Rows(i)("GF") = Convert.ToInt16(tl.Rows(i)("GF")) + Convert.ToInt16(tl2.Rows(j)("GF"))
                    tl.Rows(i)("GC") = Convert.ToInt16(tl.Rows(i)("GC")) + Convert.ToInt16(tl2.Rows(j)("GC"))
                    tl.Rows(i)("DIF") = Convert.ToInt16(tl.Rows(i)("DIF")) + Convert.ToInt16(tl2.Rows(j)("DIF"))
                    encontro = 1
                End If
               
            Next
            ''If encontro = 0 Then
            ''    Dim r2 As DataRow
            ''    r2 = tl.NewRow
            ''    r2("IdEquipo") = tl2.Rows(j)("idequipo").ToString()
            ''    r2("PTS") = tl2.Rows(j)("idequipo").ToString()
            ''    r2("PJ") = tl2.Rows(j)("idequipo").ToString()
            ''    r2("G") = tl2.Rows(j)("G").ToString()
            ''    r2("E") = tl2.Rows(j)("E").ToString()
            ''    r2("P") = tl2.Rows(j)("P").ToString()
            ''    r2("GF") = tl2.Rows(j)("GF").ToString()
            ''    r2("GC") = tl2.Rows(j)("GC").ToString()
            ''    r2("DIF") = tl2.Rows(j)("DIF").ToString()
            ''    r2("Equipo") = tl2.Rows(j)("Equipo").ToString()
            ''    tl.Rows.Add(r2)
            ''Else
            ''    encontro = 0
            ''End If
        Next
        tl.Select("", "pts desc", DataViewRowState.CurrentRows)
        'Dim DV As New DataView(tl, "", "PTS DESC", DataViewRowState.CurrentRows)
        Dim vista As New DataView()
        tl.DefaultView.Sort = "pts desc,dif desc"
        vista = tl.DefaultView

        i = 1
        For Each fila As DataRowView In vista
            fila.Item("pos") = i
            i = i + 1
        Next
        Return vista
    End Function

    Public Function TablaPromedios(ByVal IdTorneo As Integer) As DataView
        Dim t As DataTable
        Dim cad As String
        Dim PTS, PJ, i As Integer
        Dim prom As Decimal
        Dim con As New Conexion()
        cad = con.Cadena()
        t = SqlHelper.ExecuteDataset(cad, "PromediosGet", IdTorneo).Tables(0)
        For i = 0 To t.Rows.Count - 1
            PTS = Convert.ToInt16(t.Rows(i)("PTS"))
            PJ = Convert.ToInt16(t.Rows(i)("PJ"))
            prom = PTS / PJ
            t.Rows(i)("prom") = prom
        Next
        Dim dv As New DataView
        t.DefaultView.Sort = "PROM DESC"
        dv = t.DefaultView
        i = 1
        For Each fila As DataRowView In dv
            fila.Item("pos") = i
            i = i + 1
            fila.Item("prom") = Mid(fila.Item("prom").ToString(), 1, 5)
            'fila.Item("t1") = Replace(fila.Item("t1").ToString(), "0", "-")
            'fila.Itelicm("t2") = Replace(fila.Item("t2").ToString(), "0", "-")
            'fila.Item("t3") = Replace(fila.Item("t3").ToString(), "0", "-")
        Next
        Return dv
    End Function

    Public Function PromediosFuturos(ByVal idtorneoAnterior As Integer, ByVal idtorneoActual As Integer, ByVal temporadaAnterior As String, ByVal temporadaActual As String) As DataView
        Dim tabla As New DataTable()
        tabla.Columns.Add("Pos")
        tabla.Columns.Add("idequipo")
        tabla.Columns.Add("equipo")
        tabla.Columns.Add("PuntosAnterior")
        tabla.Columns.Add("PuntosActual")
        tabla.Columns.Add("Puntos")
        tabla.Columns.Add("Pj")
        tabla.Columns.Add("Promedio")
        Dim sql As String
        sql = "select e.idequipo,e.equipo "
        sql = sql + " from Equiposxtorneo et, Equipo e"
        sql = sql + " where et.idequipo = e.idequipo"
        sql = sql + " and et.idtorneo=" + idtorneoActual.ToString()
        Dim tequipo As New DataTable()
        Dim oconexion As New Conexion()
        tequipo = SqlHelper.ExecuteDataset(oconexion.Cadena(), CommandType.Text, sql).Tables(0)
        Dim i As Integer
        Dim idequipo, equipo As String
        For i = 0 To tequipo.Rows.Count - 1
            idequipo = tequipo.Rows(i)("idequipo").ToString()
            equipo = tequipo.Rows(i)("equipo").ToString()
            Dim r As DataRow
            r = tabla.NewRow
            r("Pos") = ""
            r("idequipo") = idequipo
            r("equipo") = equipo
            r("PuntosAnterior") = ""
            r("PuntosActual") = ""
            r("Puntos") = ""
            r("Pj") = ""
            r("Promedio") = ""
            tabla.Rows.Add(r)
        Next
        Dim puntosAnterior, puntosActual As Integer
        For i = 0 To tabla.Rows.Count - 1
            idequipo = Convert.ToInt32(tabla.Rows(i)("idequipo"))
            puntosAnterior = GetPuntos(idequipo, idtorneoAnterior)
            puntosActual = GetPuntos(idequipo, idtorneoActual)
            tabla.Rows(i)("PuntosAnterior") = puntosAnterior.ToString()
            tabla.Rows(i)("PuntosActual") = puntosActual.ToString()
            tabla.Rows(i)("Puntos") = (puntosAnterior + puntosActual).ToString()
            tabla.Rows(i)("Pj") = GetPartidosJugados(idequipo, idtorneoAnterior, idtorneoActual)
            tabla.Rows(i)("Promedio") = (Convert.ToInt32(tabla.Rows(i)("Puntos")) / Convert.ToInt32(tabla.Rows(i)("Pj"))).ToString()
        Next
        Dim vista As New DataView()
        tabla.DefaultView.Sort = "Promedio desc"
        vista = tabla.DefaultView
        i = 1
        For Each fila As DataRowView In vista
            fila.Item("pos") = i
            i = i + 1
        Next
        Return vista
    End Function

    Private Function GetPuntos(ByVal idequipo As Integer, ByVal idtorneo As Integer) As Integer
        Dim sql As String
        sql = "select (isnull((select sum(pl) from fixture where idlocal =" + idequipo.ToString() + " and idtorneo =" + idtorneo.ToString() + "),0)"
        sql = sql + "+isnull((select sum(pv) from fixture where idvisitante =" + idequipo.ToString() + " and idtorneo =" + idtorneo.ToString() + "),0))"
        Dim ocon As New Conexion()
        Return Convert.ToInt32(SqlHelper.ExecuteScalar(ocon.Cadena(), CommandType.Text, sql))
    End Function

    Private Function GetPartidosJugados(ByVal idequipo As Integer, ByVal idtorneoAnterior As Integer, ByVal idtorneoActual As Integer) As Integer
        Dim sql As String
        Dim pj As Integer
        sql = "select (isnull((select count(idpartido) from fixture where idlocal =" + idequipo.ToString() + " and idtorneo =" + idtorneoAnterior.ToString() + " and jugo =1),0) "
        sql = sql + "+isnull((select count(idpartido) from fixture where idvisitante =" + idequipo.ToString() + " and idtorneo =" + idtorneoAnterior.ToString() + "and jugo=1),0)) "
        Dim ocon As New Conexion()
        pj = Convert.ToInt32(SqlHelper.ExecuteScalar(ocon.Cadena(), CommandType.Text, sql))
        sql = "select (isnull((select count(idpartido) from fixture where idlocal =" + idequipo.ToString() + " and idtorneo =" + idtorneoActual.ToString() + " and jugo =1),0) "
        sql = sql + "+isnull((select count(idpartido) from fixture where idvisitante =" + idequipo.ToString() + " and idtorneo =" + idtorneoActual.ToString() + "and jugo=1),0)) "
        pj = pj + Convert.ToInt32(SqlHelper.ExecuteScalar(ocon.Cadena(), CommandType.Text, sql))
        Return pj
    End Function

    Public Function Tendencias(ByVal idTorneoSeleccionado As Integer) As DataView
        Dim sql As String
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim tl, tv As DataTable
        tl = SqlHelper.ExecuteDataset(cad, "TablaLocalGet", idTorneoSeleccionado).Tables(0)
        tv = SqlHelper.ExecuteDataset(cad, "TablaVisitanteGet", idTorneoSeleccionado).Tables(0)
        Dim i, j As Integer
        For i = 0 To tl.Rows.Count - 1
            For j = 0 To tv.Rows.Count - 1
                If tl.Rows(i)("idequipo").ToString() = tv.Rows(j)("idequipo").ToString() Then
                    tl.Rows(i)("PTS") = Convert.ToInt16(tl.Rows(i)("PTS")) + Convert.ToInt16(tv.Rows(j)("PTS"))
                    tl.Rows(i)("PJ") = Convert.ToInt16(tl.Rows(i)("PJ")) + Convert.ToInt16(tv.Rows(j)("PJ"))
                    tl.Rows(i)("G") = Convert.ToInt16(tl.Rows(i)("G")) + Convert.ToInt16(tv.Rows(j)("G"))
                    tl.Rows(i)("E") = Convert.ToInt16(tl.Rows(i)("E")) + Convert.ToInt16(tv.Rows(j)("E"))
                    tl.Rows(i)("P") = Convert.ToInt16(tl.Rows(i)("P")) + Convert.ToInt16(tv.Rows(j)("P"))
                    tl.Rows(i)("GF") = Convert.ToInt16(tl.Rows(i)("GF")) + Convert.ToInt16(tv.Rows(j)("GF"))
                    tl.Rows(i)("GC") = Convert.ToInt16(tl.Rows(i)("GC")) + Convert.ToInt16(tv.Rows(j)("GC"))
                    tl.Rows(i)("DIF") = Convert.ToInt16(tl.Rows(i)("DIF")) + Convert.ToInt16(tv.Rows(j)("DIF"))
                End If
            Next
        Next
        'seguir aqui
        sql = "select max(fecha) from fixture where idtorneo=" + idTorneoSeleccionado.ToString()
        sql = sql + " and jugo=1"
        Dim fechaActual, fechaAnterior As Integer
        fechaActual = Convert.ToInt16(SqlHelper.ExecuteScalar(cad, CommandType.Text, sql))
        fechaAnterior = fechaActual - 5
        tl.Columns.Add("Ten")
        tl.Columns.Add("Pre")
        Dim idequipo As Integer
        Dim pre As Integer
        Dim PtsTen As Integer
        For i = 0 To tl.Rows.Count - 1
            idequipo = Convert.ToInt16(tl.Rows(i)("idequipo"))

            'PtsTen = Convert.ToInt16(SqlHelper.ExecuteScalar(cad, "Tendencias", idTorneoSeleccionado, idequipo, 22, 32))
            'PtsTen = Convert.ToInt16(SqlHelper.ExecuteScalar(cad, "Tendencias", idTorneoSeleccionado, idequipo, fechaMenosDiez, fechaActual))
            PtsTen = Convert.ToInt16(SqlHelper.ExecuteScalar(cad, "Tendencias", idTorneoSeleccionado, idequipo, fechaAnterior, fechaActual))
            ' pre = (PtsTen * 6) / 10
            pre = (PtsTen * (38 - fechaActual)) / 5
            tl.Rows(i)("Ten") = PtsTen
            tl.Rows(i)("Pre") = pre
            tl.Rows(i)("pts") = Convert.ToInt16(tl.Rows(i)("pts")) + Convert.ToInt16(tl.Rows(i)("pre"))
        Next
        tl.Select("", "pts desc", DataViewRowState.CurrentRows)
        'Dim DV As New DataView(tl, "", "PTS DESC", DataViewRowState.CurrentRows)
        Dim vista As New DataView()
        tl.DefaultView.Sort = "pts desc,dif desc"
        vista = tl.DefaultView

        i = 1
        For Each fila As DataRowView In vista
            fila.Item("pos") = i
            i = i + 1
        Next
        Return vista
    End Function

    Public Function MiniTorneos(ByVal v() As Integer, ByVal can As Integer, ByVal idtorneo As Integer) As DataTable
        Dim sql As String
        'Dim v(5) As Integer
        'v(0) = 1
        'v(1) = 14
        'v(2) = 13
        'v(3) = 38
        'v(4) = 18
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        'Dim sql As String
        ' Dim v(5) As Integer
        ' v(0) = 1
        ' v(1) = 14
        ' v(2) = 13
        'v(3) = 38
        'v(4) = 18
        'Dim idtorneo As Integer
        'idtorneo = 2
        Dim t As New DataTable
        t.Columns.Add("IdEquipo")
        t.Columns.Add("Pos")
        t.Columns.Add("Equipo")
        t.Columns.Add("PTS")
        t.Columns.Add("PJ")
        t.Columns.Add("G")
        t.Columns.Add("E")
        t.Columns.Add("P")
        t.Columns.Add("GF")
        t.Columns.Add("GC")
        t.Columns.Add("DIF")
        Dim tb As New DataTable
        Dim i, j, k As Integer
        'inicializo el t
        For i = 0 To can - 1
            sql = "select equipo from equipo where idequipo=" + v(i).ToString()
            Dim r As DataRow
            r = t.NewRow()
            r("idequipo") = v(i)
            r("equipo") = SqlHelper.ExecuteScalar(cad, CommandType.Text, sql).ToString()
            r("PTS") = 0
            r("PJ") = 0
            r("G") = 0
            r("E") = 0
            r("P") = 0
            r("GF") = 0
            r("GC") = 0
            r("DIF") = 0
            t.Rows.Add(r)
        Next

        For i = 0 To can - 1
            For j = 0 To can - 1
                If i <> j Then
                    sql = "select idlocal,gl,gv,pl,Ganol,EmpateL,PerdioL from fixture where idlocal=" + v(i).ToString()
                    sql = sql + " and idvisitante =" + v(j).ToString()
                    sql = sql + " and idtorneo=" + idtorneo.ToString()
                    sql = sql + " and jugo=1"
                    tb = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
                    If tb.Rows.Count > 0 Then
                        For k = 0 To t.Rows.Count - 1
                            If t.Rows(k)("IdEquipo").ToString() = tb.Rows(0)("IdLocal").ToString() Then
                                t.Rows(k)("PTS") = Convert.ToInt16(t.Rows(k)("PTS")) + Convert.ToInt16(tb.Rows(0)("Pl"))
                                t.Rows(k)("G") = Convert.ToInt16(t.Rows(k)("G")) + Convert.ToInt16(tb.Rows(0)("GanoL"))
                                t.Rows(k)("E") = Convert.ToInt16(t.Rows(k)("E")) + Convert.ToInt16(tb.Rows(0)("EmpateL"))
                                t.Rows(k)("P") = Convert.ToInt16(t.Rows(k)("P")) + Convert.ToInt16(tb.Rows(0)("PerdioL"))
                                t.Rows(k)("GF") = Convert.ToInt16(t.Rows(k)("GF")) + Convert.ToInt16(tb.Rows(0)("Gl"))
                                t.Rows(k)("GC") = Convert.ToInt16(t.Rows(k)("GC")) + Convert.ToInt16(tb.Rows(0)("Gv"))
                                t.Rows(k)("PJ") = Convert.ToInt16(t.Rows(k)("G")) + Convert.ToInt16(t.Rows(k)("E")) + Convert.ToInt16(t.Rows(k)("P"))
                                t.Rows(k)("DIF") = Convert.ToInt16(t.Rows(k)("GF")) - Convert.ToInt16(t.Rows(k)("GC"))
                            End If
                        Next
                    End If
                    sql = "select idvisitante,gv,gl,pv,GanoV,EmpateV,PerdioV from fixture where idlocal=" + v(j).ToString()
                    sql = sql + " and idvisitante =" + v(i).ToString()
                    sql = sql + " and idtorneo=" + idtorneo.ToString()
                    sql = sql + " and jugo=1"
                    tb = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
                    If tb.Rows.Count > 0 Then
                        For k = 0 To t.Rows.Count - 1
                            If t.Rows(k)("IdEquipo").ToString() = tb.Rows(0)("IdVisitante").ToString() Then
                                t.Rows(k)("PTS") = Convert.ToInt16(t.Rows(k)("PTS")) + Convert.ToInt16(tb.Rows(0)("Pv"))
                                t.Rows(k)("G") = Convert.ToInt16(t.Rows(k)("G")) + Convert.ToInt16(tb.Rows(0)("Ganov"))
                                t.Rows(k)("E") = Convert.ToInt16(t.Rows(k)("E")) + Convert.ToInt16(tb.Rows(0)("EmpateV"))
                                t.Rows(k)("P") = Convert.ToInt16(t.Rows(k)("P")) + Convert.ToInt16(tb.Rows(0)("PerdioV"))
                                t.Rows(k)("GF") = Convert.ToInt16(t.Rows(k)("GF")) + Convert.ToInt16(tb.Rows(0)("Gv"))
                                t.Rows(k)("GC") = Convert.ToInt16(t.Rows(k)("GC")) + Convert.ToInt16(tb.Rows(0)("Gl"))
                                t.Rows(k)("PJ") = Convert.ToInt16(t.Rows(k)("G")) + Convert.ToInt16(t.Rows(k)("E")) + Convert.ToInt16(t.Rows(k)("P"))
                                t.Rows(k)("DIF") = Convert.ToInt16(t.Rows(k)("GF")) - Convert.ToInt16(t.Rows(k)("GC"))
                            End If
                        Next
                    End If
                End If
            Next
        Next
        sql = " delete from Temporal"
        SqlHelper.ExecuteNonQuery(cad, CommandType.Text, sql)
        For i = 0 To t.Rows.Count - 1
            sql = "insert into Temporal(IdEquipo,Equipo,PTS,PJ,G,E,P,GF,GC,DIF)"
            sql = sql + "values("
            sql = sql + t.Rows(i)("IdEquipo").ToString() + ","
            sql = sql + "'" + t.Rows(i)("Equipo").ToString() + "'" + ","
            sql = sql + t.Rows(i)("PTS").ToString() + ","
            sql = sql + t.Rows(i)("PJ").ToString() + ","
            sql = sql + t.Rows(i)("G").ToString() + ","
            sql = sql + t.Rows(i)("E").ToString() + ","
            sql = sql + t.Rows(i)("P").ToString() + ","
            sql = sql + t.Rows(i)("GF").ToString() + ","
            sql = sql + t.Rows(i)("GC").ToString() + ","
            sql = sql + t.Rows(i)("DIF").ToString() + ")"
            SqlHelper.ExecuteNonQuery(cad, CommandType.Text, sql)
        Next
        sql = "select * from Temporal order by pts desc,dif desc"
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        'Dim vista As New DataView()
        't.DefaultView.Sort = "PTS DESC,dif desc"

        ''tl.DefaultView.Sort = "pts desc,dif desc"
        ''vista = tl.DefaultView
        ''tl.DefaultView.Sort = "pts desc,dif desc"
        'vista = t.DefaultView
        Return t
    End Function

    Public Function TablaResumida(ByVal IdTorneo As Integer, ByVal IdEquipo As Integer) As DataTable
        Dim sql As String
        sql = " select 'Local' as condicion, isnull((sum(GanoL) + sum(EmpateL)+sum(PerdioL)),0) pj, "
        sql = sql + " isnull(sum(pl),0) pts,"
        sql = sql + " isnull(sum(GanoL),0) g,isnull(sum(EmpateL),0) e,isnull(sum(PerdioL),0) p,isnull(sum(Gl),0) gf,isnull(sum(gv),0) gc,"
        sql = sql + " isnull((sum(Gl)-sum(gv)),0) dif "
        sql = sql + " from Fixture "
        sql = sql + " where idlocal = " + IdEquipo.ToString()
        sql = sql + " and idtorneo=" + IdTorneo.ToString()
        sql = sql + " and jugo =1"
        sql = sql + " UNION"
        sql = sql + " select 'Visitante' as condicion, isnull((sum(Ganov) + sum(Empatev)+sum(Perdiov)),0) pj, "
        sql = sql + " isnull(sum(pl),0) pts,"
        sql = sql + "isnull(sum(Ganov),0) g,isnull(sum(Empatev),0) e,isnull(sum(Perdiov),0) p,isnull(sum(Gv),0) gf,isnull(sum(gl),0) gc,"
        sql = sql + "isnull((sum(gv)-sum(gl)),0) dif"
        sql = sql + " from fixture where idvisitante=" + IdEquipo.ToString()
        sql = sql + " and idtorneo=" + IdTorneo.ToString()
        sql = sql + " and jugo =1"
        Dim t As New DataTable
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Dim r As DataRow
        r = t.NewRow
        r(0) = "General"
        r(1) = Convert.ToInt16(t.Rows(0)(1)) + Convert.ToInt16(t.Rows(1)(1))
        r(2) = Convert.ToInt16(t.Rows(0)(2)) + Convert.ToInt16(t.Rows(1)(2))
        r(3) = Convert.ToInt16(t.Rows(0)(3)) + Convert.ToInt16(t.Rows(1)(3))
        r(4) = Convert.ToInt16(t.Rows(0)(4)) + Convert.ToInt16(t.Rows(1)(4))
        r(5) = Convert.ToInt16(t.Rows(0)(5)) + Convert.ToInt16(t.Rows(1)(5))
        r(6) = Convert.ToInt16(t.Rows(0)(6)) + Convert.ToInt16(t.Rows(1)(6))
        r(7) = Convert.ToInt16(t.Rows(0)(7)) + Convert.ToInt16(t.Rows(1)(7))
        r(8) = r(6) - r(7)
        t.Rows.Add(r)
        Return t
    End Function

    Public Function Simulador(ByVal idTorneoSeleccionado As Integer) As DataView
        Dim con As New Conexion()
        'Dim cad As String
        'cad = "Data Source=CEBA-8A765F94E1\SQLEXPRESS;Initial Catalog=FT;Integrated Security=True"
        'cad = "Data Source=localhost\sqlexpress;Initial Catalog=FT;Integrated Security=True"
        Dim cad As String
        cad = con.Cadena()
        Dim tl, tv As DataTable
        tl = SqlHelper.ExecuteDataset(cad, "TablaLocalGet", idTorneoSeleccionado).Tables(0)
        tv = SqlHelper.ExecuteDataset(cad, "TablaVisitanteGet", idTorneoSeleccionado).Tables(0)
        Dim i, j As Integer
        For i = 0 To tl.Rows.Count - 1
            For j = 0 To tv.Rows.Count - 1
                If tl.Rows(i)("idequipo").ToString() = tv.Rows(j)("idequipo").ToString() Then
                    tl.Rows(i)("PTS") = Convert.ToInt16(tl.Rows(i)("PTS")) + Convert.ToInt16(tv.Rows(j)("PTS"))
                    tl.Rows(i)("PJ") = Convert.ToInt16(tl.Rows(i)("PJ")) + Convert.ToInt16(tv.Rows(j)("PJ"))
                    tl.Rows(i)("G") = Convert.ToInt16(tl.Rows(i)("G")) + Convert.ToInt16(tv.Rows(j)("G"))
                    tl.Rows(i)("E") = Convert.ToInt16(tl.Rows(i)("E")) + Convert.ToInt16(tv.Rows(j)("E"))
                    tl.Rows(i)("P") = Convert.ToInt16(tl.Rows(i)("P")) + Convert.ToInt16(tv.Rows(j)("P"))
                    tl.Rows(i)("GF") = Convert.ToInt16(tl.Rows(i)("GF")) + Convert.ToInt16(tv.Rows(j)("GF"))
                    tl.Rows(i)("GC") = Convert.ToInt16(tl.Rows(i)("GC")) + Convert.ToInt16(tv.Rows(j)("GC"))
                    tl.Rows(i)("DIF") = Convert.ToInt16(tl.Rows(i)("DIF")) + Convert.ToInt16(tv.Rows(j)("DIF"))
                End If
            Next
        Next
        Dim fechasTotal As Integer
        Dim fechasRestan As Integer
        Dim s As String = "select count(idequipo) from equiposxtorneo where idtorneo=" + idTorneoSeleccionado.ToString()
        tl.Columns.Add("p7")
        tl.Columns.Add("promedio7")
        tl.Columns.Add("fechasRestantes")
        tl.Columns.Add("pjfut")
        tl.Columns.Add("sim")
        fechasTotal = 2 * (Convert.ToInt16(SqlHelper.ExecuteScalar(cad, CommandType.Text, s)) - 1)
        ''
        Dim sim As Integer
        Dim prom As Decimal
        Dim pj, idequipo As Integer
        For i = 0 To tl.Rows.Count - 1
            pj = Convert.ToInt16(tl.Rows(i)("pj").ToString())
            idequipo = Convert.ToInt16(tl.Rows(i)("IdEquipo").ToString())
            'If idequipo = 1 Then
            Dim p3 As Integer
            p3 = PuntosFut(idequipo, idTorneoSeleccionado, pj, fechasTotal)
            tl.Rows(i)("p7") = p3
            tl.Rows(i)("promedio7") = p3 / 7
            prom = p3 / 7
            tl.Rows(i)("fechasRestantes") = fechasTotal - pj
            sim = Convert.ToInt16(tl.Rows(i)("pts")) + prom * (fechasTotal - pj)
            tl.Rows(i)("pjfut") = Convert.ToInt16(tl.Rows(i)("fechasRestantes")) + Convert.ToInt16(tl.Rows(i)("pj"))
            tl.Rows(i)("sim") = sim
            'End If
        Next
        ''
        tl.Select("", "pts desc", DataViewRowState.CurrentRows)
        'Dim DV As New DataView(tl, "", "PTS DESC", DataViewRowState.CurrentRows)
        Dim vista As New DataView()
        'tl.DefaultView.Sort = "pts desc,dif desc,gf desc"
        tl.DefaultView.Sort = "sim desc"
        vista = tl.DefaultView

        i = 1
        For Each fila As DataRowView In vista
            fila.Item("pos") = i
            i = i + 1
        Next
        'Grilla.DataSource = vista
        Return vista

    End Function

    Private Function PuntosFut(ByVal IdEquipo As Integer, ByVal IdTorneo As Integer, ByVal pj As Integer, ByVal fechasTotal As Integer) As Integer
        Dim con As New Conexion()
        Dim pjmenos7 As Integer
        Dim cad As String
       

        cad = con.Cadena()
        pjmenos7 = pj - 6
        Dim i As Integer
        Dim pl, pv As Integer
        pl = 0
        pv = 0
        Dim sql As String
        sql = "select sum(pl) from fixture where idlocal=" + IdEquipo.ToString()
        sql = sql + " and idtorneo=" + IdTorneo.ToString()
        sql = sql + " and fecha >=" + pjmenos7.ToString()
        sql = sql + " and fecha <=" + pj.ToString()
        pl = Convert.ToInt16(SqlHelper.ExecuteScalar(cad, CommandType.Text, sql))
        sql = "select sum(pv) from fixture where idvisitante=" + IdEquipo.ToString()
        sql = sql + " and idtorneo=" + IdTorneo.ToString()
        sql = sql + " and fecha >=" + pjmenos7.ToString()
        sql = sql + " and fecha <=" + pj.ToString()
        pv = Convert.ToInt16(SqlHelper.ExecuteScalar(cad, CommandType.Text, sql))
        Return (pl + pv)
    End Function

End Class

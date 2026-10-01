Imports tabla
Imports System.Data
Imports Microsoft.ApplicationBlocks.Data
Public Class Visitas
    Public cad As String
    Public Sub New()
        Dim o As New Conexion()
        cad = o.Cadena()
    End Sub
    Public Sub ContarPagina(ByVal pagina As String)
        Dim sql As String
        sql = "update Visitas set Total = Total + 1"
        sql = sql + " where Pagina =" + "'" + pagina + "'"
        SqlHelper.ExecuteNonQuery(cad, CommandType.Text, sql)
    End Sub

    Public Function VisitasGetbyPagina(ByVal pagina As String) As Long
        Dim sql As String
        sql = "select total from visitas where pagina =" + "'" + pagina + "'"
        Dim can As Long
        can = Convert.ToInt64(SqlHelper.ExecuteScalar(cad, CommandType.Text, sql).ToString())
        Return can
    End Function

    Public Sub ContarVisitasxDia()
        SqlHelper.ExecuteNonQuery(cad, CommandType.StoredProcedure, "Visitas2DiaAdd")

    End Sub

    Public Sub RegistrarVisitasPorItem(ByVal IdTorneo As Integer, ByVal Item As String)
        Dim con As New Conexion()
        Dim cad As String
        cad = con.Cadena()
        Dim sql As String = "select total from VisitasPorItem where IdTorneo =" + IdTorneo.ToString()
        sql = sql + " and Item =" + "'" + Item + "'"
        Dim t As DataTable
        Dim ban As Integer = 0
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Dim total As Integer = 0
        If t.Rows.Count > 0 Then
            total = t.Rows(0)("Total")
            ban = 1
            total = total + 1
            sql = "update VisitasPorItem "
            sql = sql + " set Total =" + total.ToString()
            sql = sql + " where Item =" + "'" + Item + "'"
            sql = sql + " and IdTorneo =" + IdTorneo.ToString()
            SqlHelper.ExecuteNonQuery(cad, CommandType.Text, sql)
        Else
            total = 0
        End If
        total = total + 1
        If (ban = 0) Then
            sql = "insert into VisitasPorItem(IdTorneo,Item,Total)"
            sql = sql + " values(" + IdTorneo.ToString()
            sql = sql + "," + " '" + Item + "'"
            sql = sql + "," + total.ToString() + ")"
            SqlHelper.ExecuteNonQuery(cad, CommandType.Text, sql)
        End If
    End Sub

End Class

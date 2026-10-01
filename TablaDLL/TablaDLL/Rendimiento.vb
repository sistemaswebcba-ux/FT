Imports System.Data
Imports Microsoft.ApplicationBlocks.Data
Public Class Rendimiento
    Public Sub InsertarRendimiento(ByVal IdTorneo As Integer, ByVal fecha As Integer)
        Dim sql As String
        Dim cad As String
        Dim con As New Conexion()
        cad = con.Cadena()
        sql = "delete from Rendimiento where IdTorneo =" + IdTorneo.ToString()
        sql = sql + " and fecha =" + fecha.ToString()
        SqlHelper.ExecuteNonQuery(cad, CommandType.Text, sql)
        Dim tb As New DataView()
        Dim objTabla As New Tabla()
        tb = objTabla.cargarporfechas(IdTorneo, 1, fecha)
        Dim t As DataTable = tb.ToTable
        Dim IdEquipo, Posicion As Integer
        Dim i As Integer

        For i = 0 To t.Rows.Count - 1
            IdEquipo = t.Rows(i)("IdEquipo")
            Posicion = t.Rows(i)("Pos")
            sql = "insert into Rendimiento(IdTorneo,IdEquipo,Posicion,fecha)"
            sql = sql + "values(" + IdTorneo.ToString()
            sql = sql + "," + IdEquipo.ToString()
            sql = sql + "," + Posicion.ToString()
            sql = sql + "," + fecha.ToString()
            sql = sql + ")"
            SqlHelper.ExecuteNonQuery(cad, CommandType.Text, sql)
        Next

       
    End Sub

    Public Function GetRendimientoxEquipo(ByVal IdEquipo As Integer, ByVal IdTorneo As Integer) As DataTable
        Dim t As New DataTable
        Dim sql As String
        Dim cad As String
        Dim con As New Conexion()
        cad = con.Cadena()
        sql = "select * from Rendimiento where IdTorneo =" + IdTorneo.ToString()
        sql = sql + " and IdEquipo=" + IdEquipo.ToString()
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

End Class

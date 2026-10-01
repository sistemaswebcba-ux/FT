Imports System.Data
Imports Microsoft.ApplicationBlocks.Data
Public Class Noticia
    Public cad As String

    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function NoticiaGetbyCategoria(ByVal cat As Integer)
        Dim sql As String
        sql = " select n.*,e.foto from noticia n,equipo e  where n.IdEquipo=e.IdEquipo and n.categoria=" + cat.ToString()
        sql = sql + " order by n.fecha desc"
        Dim t As DataTable
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

End Class

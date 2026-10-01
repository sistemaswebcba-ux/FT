Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class LabelPromedio
    Public cad As String
    Public sql As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function GetLabelPromedioxTorneo(ByVal IdTorneo As Integer) As DataTable
        sql = "select * from LabelPromedio where IdTorneo=" + IdTorneo.ToString()
        Dim t As New DataTable()
        t = SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
        Return t
    End Function

End Class

Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Diferencias
    Private cad As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub

    Public Function GetDiferenciasxTorneo(ByVal IdTorneo As Integer)
        Dim sql As String
        sql = "select * from diferencias where idtorneo =" + IdTorneo.ToString()
        Return SqlHelper.ExecuteDataset(cad, CommandType.Text, sql).Tables(0)
    End Function
End Class

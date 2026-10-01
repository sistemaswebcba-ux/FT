Imports Microsoft.ApplicationBlocks.Data
Imports System.Data
Public Class Partido
    Private cad As String
    Public Sub New()
        Dim con As New Conexion()
        cad = con.Cadena()
    End Sub
    Public Sub CargarResultado(ByVal idpartido As Integer, ByVal gl As Integer, ByVal gv As Integer, ByVal pl As Integer, ByVal pv As Integer, ByVal GanoL As Integer, ByVal GanoV As Integer, ByVal EmpateL As Integer, ByVal EmpateV As Integer, ByVal PerdioL As Integer, ByVal PerdioV As Integer)
        Dim fechaPartido As String
        fechaPartido = Date.Now.Day().ToString() + "/" + Date.Now.Month().ToString() + "/" + Date.Now.Year().ToString()
        Dim Sql As String
        Sql = "update fixture"
        Sql = Sql + " set gl=" + gl.ToString()
        Sql = Sql + ",gv =" + gv.ToString()
        Sql = Sql + ",pl=" + pl.ToString()
        Sql = Sql + ",pv =" + pv.ToString()
        Sql = Sql + ",GanoL =" + GanoL.ToString()
        Sql = Sql + ",GanoV =" + GanoV.ToString()
        Sql = Sql + ",EmpateL =" + EmpateL.ToString()
        Sql = Sql + ",EmpateV =" + EmpateV.ToString()
        Sql = Sql + ",PerdioL =" + PerdioL.ToString()
        Sql = Sql + ",PerdioV =" + PerdioV.ToString()
        Sql = Sql + ", jugo=1"
        Sql = Sql + ",FechaPartido =" + "'" + fechaPartido.ToString() + "'"
        Sql = Sql + " where idpartido=" + idpartido.ToString()
        SqlHelper.ExecuteNonQuery(cad, CommandType.Text, Sql)
    End Sub

End Class

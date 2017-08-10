Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion
    Private strConexion_ As String
    Private objConexion_ As SqlConnection

    Public Property strConexion() As String
        Get
            Return strConexion_
        End Get
        Set(ByVal value As String)
            strConexion_ = value
        End Set
    End Property

    Public Property objConexion() As SqlConnection
        Get
            Return objConexion_
        End Get
        Set(ByVal value As SqlConnection)
            objConexion_ = value
        End Set
    End Property

    Protected Function Abrir()
        Try
            strConexion = "Data Source=localhost\SQLEXPRESS; DataBase=Alumnos; Trusted_Connection=True"
            objConexion = New SqlConnection(strConexion)
            objConexion.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function Cerrar()
        Try
            If objConexion.State = ConnectionState.Open Then
                objConexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class

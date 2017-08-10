Imports System.Data
Imports System.Data.SqlClient
Public Class Alumno
    Inherits Conexion

    Private id_ As Integer
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Private Documento_ As String
    Public Property Documento() As Integer

        Get
            Return Documento_
        End Get
        Set(ByVal value As Integer)
            Documento_ = value
        End Set
    End Property

    Private ApeyNom_ As String
    Public Property ApeyNom() As String

        Get
            Return ApeyNom_
        End Get
        Set(ByVal value As String)

            ApeyNom_ = value
        End Set
    End Property

    Private direccion_ As String
    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property

    Private CPostal_ As Integer

    Public Property CPostal() As Integer
        Get
            Return CPostal_
        End Get
        Set(ByVal value As Integer)
            CPostal_ = value
        End Set
    End Property

    Private Email_ As String
    Public Property Email() As String
        Get
            Return Email_
        End Get
        Set(ByVal value As String)
            Email_ = value
        End Set
    End Property

    Private FNacimiento_ As Date
    Public Property FNacimiento() As Date
        Get
            Return FNacimiento_
        End Get
        Set(ByVal value As Date)
            FNacimiento_ = value
        End Set
    End Property
    Public Function AlumnoTraerTab(ByVal tabla As DataGridView)
        Abrir()

        Dim objComando As New SqlCommand("AlumnoTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("id").Width = 50
        tabla.Columns("Documento").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("ApeyNom").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("CPostal").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("FNacimiento").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Function

    Public Function AlumnoInsertar(ByVal Alumno As Alumno) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("AlumnoInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Documento", Alumno.Documento)
            objComando.Parameters.AddWithValue("@ApeyNom", Alumno.ApeyNom)
            objComando.Parameters.AddWithValue("@Direccion", Alumno.direccion)
            objComando.Parameters.AddWithValue("@CPostal", Alumno.CPostal)
            objComando.Parameters.AddWithValue("@Email", Alumno.Email)
            objComando.Parameters.AddWithValue("@FNacimiento", "2017-06-30")
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Function
    Public Function BorrarAlumno(ByVal idAlumno As Integer) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("AlumnoEliminar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", id)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Cerrar()
        End Try

    End Function
    Public Function AlumnoRecuperar(ByVal idAlumno As Integer) As Alumno

        Try
            Abrir()
            Dim Alumno As New Alumno
            Dim objComando As New SqlCommand("AlumnoRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", idAlumno)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                Alumno.id = objDataTable.Rows(0).Item("Id")
                Alumno.Documento = objDataTable.Rows(0).Item("Documento")
                Alumno.ApeyNom = objDataTable.Rows(0).Item("ApeyNom")
                Alumno.direccion = objDataTable.Rows(0).Item("Direccion")
                Alumno.CPostal = objDataTable.Rows(0).Item("CPostal")
                Alumno.Email = objDataTable.Rows(0).Item("Email")
                Alumno.FNacimiento = objDataTable.Rows(0).Item("FNacimiento")
                Return Alumno
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Function

    Public Function AlumnoModificar(ByVal Alumno As Alumno) As Boolean

        Try
            Abrir()
            Dim objComando As New SqlCommand("AlumnoModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", Alumno.id)
            objComando.Parameters.AddWithValue("@Documento", Alumno.Documento)
            objComando.Parameters.AddWithValue("@ApeyNom", Alumno.ApeyNom)
            objComando.Parameters.AddWithValue("@Direccion", Alumno.direccion)
            objComando.Parameters.AddWithValue("@CPostal", Alumno.CPostal)
            objComando.Parameters.AddWithValue("@Email", Alumno.Email)
            objComando.Parameters.AddWithValue("@FNacimiento", Alumno.FNacimiento)

            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Cerrar()
        End Try

    End Function

End Class

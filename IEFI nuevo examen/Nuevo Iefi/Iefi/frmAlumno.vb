
Public Class frmAlumno

    Private Modificar_ As Boolean
    Public Property Modificar() As Boolean
        Get
            Return Modificar_
        End Get
        Set(ByVal value As Boolean)
            Modificar_ = value
        End Set
    End Property

    Private idAlumno_ As Integer
    Public Property idAlumno() As Integer
        Get
            Return idAlumno_
        End Get
        Set(ByVal value As Integer)
            idAlumno_ = value
        End Set
    End Property

    Dim Alumno As New Alumno

    Private Sub frmAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Modificar = True Then
            Me.Text = "Modificar Alumno"

            Alumno = Alumno.AlumnoRecuperar(idAlumno)
            txtId.Text = Alumno.id
            txtDocumento.Text = Alumno.Documento
            txtApeyNom.Text = Alumno.ApeyNom
            txtDireccion.Text = Alumno.direccion
            txtCPostal.Text = Alumno.CPostal
            txtEmail.Text = Alumno.Email

        Else
            Me.Text = "Agregar Alumno"

            txtId.Text = Nothing
            txtDocumento.Text = Nothing
            txtApeyNom.Text = Nothing
            txtDireccion.Text = Nothing
            txtCPostal.Text = Nothing
            txtEmail.Text = Nothing

        End If
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        Alumno.ApeyNom = txtApeyNom.Text
        Alumno.Documento = txtDocumento.Text
        Alumno.direccion = txtDireccion.Text
        Alumno.CPostal = txtCPostal.Text
        Alumno.Email = txtEmail.Text

        If modificar = True Then
            If Alumno.AlumnoModificar(Alumno) = True Then
                MsgBox("Se Modifico correctamente el alumno.")
                Alumno.AlumnoTraerTab(lstAlumno.dgvAlumno)
            Else
                MsgBox("Error al modificar el alumno." + Chr(13) + "Pruebelo mas tarde.")
            End If
        Else
            If Alumno.AlumnoInsertar(Alumno) = True Then
                MsgBox("Se agrego el alumno de forma correcta.")
                Alumno.AlumnoTraerTab(lstAlumno.dgvAlumno)
            Else
                MsgBox("Error al agregar alumno." + Chr(13) + "Pruebe mas tarde.")
            End If
        End If
        Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Close()
    End Sub

End Class

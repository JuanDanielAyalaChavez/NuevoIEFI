Public Class lstAlumno

    Dim Alumno As New Alumno

    Private Sub lstAlumno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Alumno.AlumnoTraerTab(dgvAlumno)

    End Sub

    Private Sub Modificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Editar()

    End Sub

    Private Sub dgvAlumno_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlumno.CellDoubleClick
        Editar()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If dgvAlumno.Rows.Count <> 0 Then
            Alumno.id = dgvAlumno.Item("id", dgvAlumno.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Esta seguro de borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If Alumno.BorrarAlumno(Alumno.id) Then
                    MessageBox.Show("Se ha borrado correctamente el alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Alumno.AlumnoTraerTab(dgvAlumno)
                Else
                    MessageBox.Show("Se ha borrado correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Private Sub Editar()
        frmAlumno.modificar = True
        If dgvAlumno.Rows.Count <> 0 Then
            frmAlumno.idAlumno = dgvAlumno.Item("id", dgvAlumno.CurrentRow.Index).Value
            frmAlumno.ShowDialog()
        End If
    End Sub

    Private Sub Insertar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Insertar.Click
        frmAlumno.modificar = False
        frmAlumno.idAlumno = 0
        frmAlumno.ShowDialog()
    End Sub

    Private Sub Salir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub
End Class
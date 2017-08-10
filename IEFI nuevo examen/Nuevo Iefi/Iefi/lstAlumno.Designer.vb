<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstAlumno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvAlumno = New System.Windows.Forms.DataGridView
        Me.Insertar = New System.Windows.Forms.Button
        Me.Modificar = New System.Windows.Forms.Button
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Salir = New System.Windows.Forms.Button
        CType(Me.dgvAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAlumno
        '
        Me.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumno.Location = New System.Drawing.Point(12, 12)
        Me.dgvAlumno.Name = "dgvAlumno"
        Me.dgvAlumno.Size = New System.Drawing.Size(523, 182)
        Me.dgvAlumno.TabIndex = 0
        '
        'Insertar
        '
        Me.Insertar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Insertar.Location = New System.Drawing.Point(39, 200)
        Me.Insertar.Name = "Insertar"
        Me.Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Insertar.TabIndex = 1
        Me.Insertar.Text = "Agregar"
        Me.Insertar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Modificar.Location = New System.Drawing.Point(136, 200)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Modificar.TabIndex = 2
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Eliminar.Location = New System.Drawing.Point(88, 238)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Salir.Location = New System.Drawing.Point(460, 238)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'lstAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 268)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Insertar)
        Me.Controls.Add(Me.dgvAlumno)
        Me.Name = "lstAlumno"
        Me.Text = "lstAlumno"
        CType(Me.dgvAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAlumno As System.Windows.Forms.DataGridView
    Friend WithEvents Insertar As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEmpleados
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
        Me.txtBuscarEmpleados = New System.Windows.Forms.TextBox()
        Me.lblBuscarEnpleados = New System.Windows.Forms.Label()
        Me.grbBuscar = New System.Windows.Forms.DataGridView()
        Me.idempleados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puestolaboral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        CType(Me.grbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarEmpleados
        '
        Me.txtBuscarEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarEmpleados.Location = New System.Drawing.Point(85, 21)
        Me.txtBuscarEmpleados.Name = "txtBuscarEmpleados"
        Me.txtBuscarEmpleados.Size = New System.Drawing.Size(685, 20)
        Me.txtBuscarEmpleados.TabIndex = 5
        '
        'lblBuscarEnpleados
        '
        Me.lblBuscarEnpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuscarEnpleados.AutoSize = True
        Me.lblBuscarEnpleados.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEnpleados.Location = New System.Drawing.Point(12, 25)
        Me.lblBuscarEnpleados.Name = "lblBuscarEnpleados"
        Me.lblBuscarEnpleados.Size = New System.Drawing.Size(56, 16)
        Me.lblBuscarEnpleados.TabIndex = 4
        Me.lblBuscarEnpleados.Text = "Buscar:"
        '
        'grbBuscar
        '
        Me.grbBuscar.AllowUserToAddRows = False
        Me.grbBuscar.AllowUserToDeleteRows = False
        Me.grbBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbBuscar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idempleados, Me.codigo, Me.nombre, Me.puestolaboral, Me.direccion, Me.telefono, Me.email})
        Me.grbBuscar.Location = New System.Drawing.Point(15, 47)
        Me.grbBuscar.Name = "grbBuscar"
        Me.grbBuscar.ReadOnly = True
        Me.grbBuscar.Size = New System.Drawing.Size(773, 355)
        Me.grbBuscar.TabIndex = 3
        '
        'idempleados
        '
        Me.idempleados.DataPropertyName = "idempleados"
        Me.idempleados.HeaderText = "ID"
        Me.idempleados.Name = "idempleados"
        Me.idempleados.ReadOnly = True
        Me.idempleados.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'puestolaboral
        '
        Me.puestolaboral.DataPropertyName = "puestolaboral"
        Me.puestolaboral.HeaderText = "PUESTO LABORAL"
        Me.puestolaboral.Name = "puestolaboral"
        Me.puestolaboral.ReadOnly = True
        Me.puestolaboral.Width = 150
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 150
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(583, 444)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(196, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(358, 444)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(196, 23)
        Me.btnSeleccionar.TabIndex = 6
        Me.btnSeleccionar.Text = "Seleccionar Empleado"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'frmBuscarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 504)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.txtBuscarEmpleados)
        Me.Controls.Add(Me.lblBuscarEnpleados)
        Me.Controls.Add(Me.grbBuscar)
        Me.Name = "frmBuscarEmpleados"
        Me.Text = "frmBuscarEmpleados"
        CType(Me.grbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarEmpleados As TextBox
    Friend WithEvents lblBuscarEnpleados As Label
    Friend WithEvents grbBuscar As DataGridView
    Friend WithEvents idempleados As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents puestolaboral As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSeleccionar As Button
End Class

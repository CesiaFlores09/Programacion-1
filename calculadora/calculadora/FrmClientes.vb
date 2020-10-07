﻿Public Class FrmClientes
    Dim objconexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()

    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("clientes")
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        txtCodigo.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
        txtNombre.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
        txtDireccion.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
        txtTelefono.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
        txtEmail.Text = dataTable.Rows(posicion).ItemArray(5).ToString()

        lblRegistroClientes.Text = posicion + 1 & " de" & dataTable.Rows.Count



    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro", "Registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Nuevo" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            habDescontroles(False)
        Else
            habDescontroles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Cancelar"
        End If
    End Sub
    Sub habDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            habDescontroles(False)
        Else
            habDescontroles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub
End Class
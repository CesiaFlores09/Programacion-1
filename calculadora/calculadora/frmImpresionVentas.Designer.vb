﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpresionVentas
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bd_empresaDataSet = New calculadora.bd_empresaDataSet()
        Me.impresionVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.impresionVentasTableAdapter = New calculadora.bd_empresaDataSetTableAdapters.impresionVentasTableAdapter()
        CType(Me.bd_empresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.impresionVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsImpresionVtas"
        ReportDataSource1.Value = Me.impresionVentasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "calculadora.ifmVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(761, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'bd_empresaDataSet
        '
        Me.bd_empresaDataSet.DataSetName = "bd_empresaDataSet"
        Me.bd_empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'impresionVentasBindingSource
        '
        Me.impresionVentasBindingSource.DataMember = "impresionVentas"
        Me.impresionVentasBindingSource.DataSource = Me.bd_empresaDataSet
        '
        'impresionVentasTableAdapter
        '
        Me.impresionVentasTableAdapter.ClearBeforeFill = True
        '
        'frmImpresionVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmImpresionVentas"
        Me.Text = "Impresion de la Venta"
        CType(Me.bd_empresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.impresionVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents impresionVentasBindingSource As BindingSource
    Friend WithEvents bd_empresaDataSet As bd_empresaDataSet
    Friend WithEvents impresionVentasTableAdapter As bd_empresaDataSetTableAdapters.impresionVentasTableAdapter
End Class

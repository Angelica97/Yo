Imports System.Data.SqlClient
Public Class Form1
    Private Sub Datagrid()

        DgvCliente.Rows.Add()
        Dim cantfilas = DgvCliente.Rows.Count - (1)
        DgvCliente(0, cantfilas).Value = txtIdcliente.Text
        DgvCliente(1, cantfilas).Value = txtCliente.Text
        DgvCliente(2, cantfilas).Value = txtArticulo.Text
        DgvCliente(3, cantfilas).Value = txtCanCliente.Text
        DgvCliente(4, cantfilas).Value = DtpCompra.Text
    End Sub

    Private Sub DatagridArticulo()

        DgvArticulos.Rows.Add()
        Dim cantfilas = DgvArticulos.Rows.Count - 1
        DgvArticulos(0, cantfilas).Value = txtidArticulo.Text
        DgvArticulos(1, cantfilas).Value = txtnomArticulo.Text
        DgvArticulos(2, cantfilas).Value = txtcanArticulo.Text
        DgvArticulos(3, cantfilas).Value = DtpEntrada.Text
    End Sub


    'Private Sub DataViewArticulosActu()
    '    'Dim cantarticu As Double = txtcanArticulo.Text
    '    'Dim cantclien As Double = txtCanCliente.Text

    '    Dim codeCliente As Double = txtcanArticulo.Text - txtCanCliente.Text

    '    Dim yaaaaa = DgvActuArticulos.Rows.Add()
    '    Dim cantfilas = DgvActuArticulos.Rows.Count - 1
    '    DgvActuArticulos(0, cantfilas).Value = txtidArticulo.Text
    '    DgvActuArticulos(1, cantfilas).Value = txtnomArticulo.Text
    '    DgvActuArticulos(2, cantfilas).Value = codeCliente
    '    DgvActuArticulos(3, cantfilas).Value = DtpEntrada.Text

    'End Sub

    Private artCliente As String


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        Dim numArticulos As Double
        Datagrid()


        numArticulos = txtCanCliente.Text
        artCliente = InputBox("Precio delarticulo") * numArticulos

        dgvVentas.Rows.Add()
        Dim Cantfilas = dgvVentas.Rows.Count - 1
        dgvVentas(0, Cantfilas).Value = txtIdcliente.Text
        dgvVentas(1, Cantfilas).Value = txtArticulo.Text
        dgvVentas(2, Cantfilas).Value = txtCanCliente.Text
        dgvVentas(3, Cantfilas).Value = DtpCompra.Text
        dgvVentas(4, Cantfilas).Value = artCliente
        MsgBox("Se registro correctamente")

        'DataViewArticulosActu()

        txtIdcliente.Text = ""
        txtCliente.Text = ""
        txtArticulo.Text = ""
        txtCanCliente.Text = ""

    End Sub


    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        DatagridArticulo()
        MsgBox("Se registro correctamente")
        txtidArticulo.Text = ""
        txtnomArticulo.Text = ""
        txtcanArticulo.Text = ""
    End Sub


End Class

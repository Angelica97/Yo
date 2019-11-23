Public Class Form1

    Private Sub activarControles()
        txtCliente.Enabled = False
        txtMonto.Enabled = False
        btnAperturarCuenta.Enabled = False
        btnRetiros.Enabled = True
        btnDepósitos.Enabled = True
    End Sub

    Private Sub desactivarControles()
        txtCliente.Enabled = True
        txtMonto.Enabled = True
        btnAperturarCuenta.Enabled = True
        btnRetiros.Enabled = False
        btnDepósitos.Enabled = False
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub
    Private monto As Double


    Private Sub btnAperturarCuenta_Click(sender As Object, e As EventArgs) Handles btnAperturarCuenta.Click

        Dim cliente As String
        cliente = txtCliente.Text
        monto = Val(txtMonto.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("El monto no puede ser menor que cero", "Gestión de ahorros,", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function leer(mensaje As String) As Double
        Dim cantidad As Double
        cantidad = InputBox("Ingrese monto a" + mensaje, "Gestion de ahorros", "0", 100, 0)
        Return cantidad
    End Function
    Private Sub mostrar()
        txtSaldo.Text = monto
    End Sub

    Private Sub btnDepósitos_Click(sender As Object, e As EventArgs) Handles btnDepósitos.Click
        Dim Depositos As Double
        Depositos = leer("depositar")
        monto = monto + Depositos
        lstDepósitos.Items.Add(Depositos)
        mostrar()
    End Sub

    Private Sub btnRetiros_Click(sender As Object, e As EventArgs) Handles btnRetiros.Click
        Dim Retiros As Double
        Retiros = leer("Retirar")
        If (Retiros <= monto) Then
            monto = monto - Retiros
            lstRetiros.Items.Add(Retiros)
            mostrar()
        Else
            MessageBox.Show("No se puede retirar una cantidad mayor al monto actual", "gestion de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        desactivarControles()
        lstDepósitos.Items.Clear()
        lstRetiros.Items.Clear()
        txtMonto.Clear()
        txtSaldo.Clear()
        txtCliente.Clear()

    End Sub
End Class

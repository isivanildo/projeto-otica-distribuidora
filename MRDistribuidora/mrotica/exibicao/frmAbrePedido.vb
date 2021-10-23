Public Class frmAbrePedido

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If (txtFilial.Text <> String.Empty) And (txtPedido.Text <> String.Empty) Then
            Dim f As New frmPedido
            Try
                f._num_pedido = CInt(txtPedido.Text)
                f._id_filial = CInt(txtFilial.Text)
            Catch ex As Exception
                Exit Sub
            End Try
            f.origem = "editar"
            f.Show()
        Else
            MessageBox.Show("Verifique a filial e o número do pedido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtFilial_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFilial.KeyPress
        If Not IsNumeric(e.KeyChar) And (Not e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Campo só permite valor númerico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtPedido_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPedido.KeyPress
        If Not IsNumeric(e.KeyChar) And (Not e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Campo só permite valor númerico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
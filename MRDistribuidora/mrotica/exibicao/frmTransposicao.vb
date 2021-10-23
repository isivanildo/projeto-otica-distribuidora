Public Class frmTransposicao

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


    Private Sub txtODEixo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtODEixo.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Vairáveis utilizadas no calculo do olho direito
            Dim odEsf As Double = CDbl(txtODEsf.Text)
            Dim odCil As Double = CDbl(txtODCil.Text)
            Dim odeixo As Double = CDbl(txtODEixo.Text)
            Dim somaodEsf As Double

            'Instruções referente ao olho direito
            If CDbl(txtODCil.Text) > 0 Then
                somaodEsf = odEsf + odCil
                txtODCil.Text = (-1) * odCil
            Else
                somaodEsf = odEsf + odCil
            End If

            txtODEsf.Text = somaodEsf

            If odeixo > 90 Then
                odeixo = odeixo - 90
                txtODEixo.Text = odeixo
                Exit Sub
            End If

            If odeixo < 90 Then
                odeixo = odeixo + 90
                txtODEixo.Text = odeixo
                Exit Sub
            End If

            If odeixo = 90 Then
                odeixo = odeixo - 90
                txtODEixo.Text = odeixo
                Exit Sub
            End If
            txtODEixo.Text = odeixo
            gbDados.Focus()
        End If
    End Sub

    Private Sub txtOEEixo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOEEixo.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Vairáveis utilizadas no calculo do olho esquerdo
            Dim oeEsf As Double = CDbl(txtOEEsf.Text)
            Dim oeCil As Double = CDbl(txtOECil.Text)
            Dim oeeixo As Double = CDbl(txtOEEixo.Text)
            Dim somaoeEsf As Double

            'Instruções referente ao olho esquerdo
            If CDbl(txtOECil.Text) > 0 Then
                somaoeEsf = oeEsf + oeCil
                txtOECil.Text = (-1) * oeCil
            Else
                somaoeEsf = oeEsf + oeCil
            End If

            txtOEEsf.Text = somaoeEsf

            If oeeixo > 90 Then
                oeeixo = oeeixo - 90
                txtOEEixo.Text = oeeixo
                Exit Sub
            End If

            If oeeixo < 90 Then
                oeeixo = oeeixo + 90
                txtOEEixo.Text = oeeixo
                Exit Sub
            End If

            If oeeixo = 90 Then
                oeeixo = oeeixo - 90
                txtOEEixo.Text = oeeixo
                Exit Sub
            End If
            gbDados.Focus()
        End If
    End Sub
End Class
Public Class brOS
#Region "Validacao"

    Public Function valida_Esf_PERTO(ByVal esf As Object, ByVal ad As Object, ByVal ci As Object, ByVal tipo As Integer) As Boolean
        If tipo = tipo_Receita.VISAO_simples_longe Then
            Return True
        End If
        If IsNumeric(esf) = False Then
            Return False
        Else
            If esf < 0 Then
                If (-1 * (CDbl(esf) Mod 0.25)) > 0 Then
                    Return False
                End If
            Else
                If (CDbl(esf) Mod 0.25) > 0 Then
                    Return False
                End If
            End If
            Return True
        End If

    End Function
    Public Function valida_cil_Perto(ByVal ci As Object, ByVal ad As Object, ByVal esf As Object, ByVal tipo As Integer, ByRef ctlEixo As System.Windows.Forms.Control) As Boolean
        If tipo = tipo_Receita.VISAO_simples_longe Then
            Return True
        End If
        If ci = Nothing Then
            Return False
        End If
        If IsNumeric(ci) = False Then
            Return False
        Else
            If ci = 0 Then
                ctlEixo.Enabled = False
            Else
                ctlEixo.Enabled = True
            End If
            If ci > 0 Then
                Return False
            End If
            If (-1 * (CDbl(ci) Mod 0.25)) > 0 Then
                Return False
            End If
        End If
        Return True
    End Function

#End Region

End Class

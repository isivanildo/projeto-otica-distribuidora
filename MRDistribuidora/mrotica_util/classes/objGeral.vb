Imports System.Windows.Forms
Public Class objGeral

    Public Shared Property TipoReg As Char

    Public Sub AtivaControles(ByVal controle As Control)
        For Each ctl As Control In controle.Controls
            If TypeOf ctl Is TextBox Then ctl.Enabled = True
            If TypeOf ctl Is TextBox Then DirectCast(ctl, TextBox).CharacterCasing = CharacterCasing.Upper
            If TypeOf ctl Is GroupBox Then ctl.Enabled = True
            If TypeOf ctl Is ComboBox Then ctl.Enabled = True

            If objGeral.TipoReg = "N"c Then
                If TypeOf ctl Is TextBox Then ctl.Text = ""
                If TypeOf ctl Is RadioButton Then DirectCast(ctl, RadioButton).Checked = False
                If TypeOf ctl Is TreeView Then DirectCast(ctl, TreeView).Enabled = True
            End If

            If ctl.Controls.Count > 0 Then
                AtivaControles(ctl)
            End If
        Next
    End Sub

    Public Sub DestativaControles(ByVal controle As Control)
        For Each ctl As Control In controle.Controls
            If TypeOf ctl Is TextBox Then ctl.Enabled = False
            If TypeOf ctl Is GroupBox Then ctl.Enabled = False
            If TypeOf ctl Is ComboBox Then ctl.Enabled = False
            If TypeOf ctl Is TreeView Then DirectCast(ctl, TreeView).Enabled = False

            If ctl.Controls.Count > 0 Then
                DestativaControles(ctl)
            End If
        Next
    End Sub

    Public Sub AcaoBotoes(ByVal controle As ToolStrip, ByVal acao As String)
        For Each item As ToolStripItem In controle.Items

            If acao = "Novo" Then

                Select Case item.Name
                    Case "btnNovo"
                        item.Enabled = False
                    Case "btnSalvar"
                        item.Enabled = True
                    Case "btnAlterar"
                        item.Enabled = False
                    Case "btnExcluir"
                        item.Enabled = False
                    Case "btnCancelar"
                        item.Enabled = True
                    Case "btnSair"
                        item.Enabled = False
                End Select
            ElseIf acao = "Salvar" Then

                Select Case item.Name
                    Case "btnNovo"
                        item.Enabled = True
                    Case "btnSalvar"
                        item.Enabled = False
                    Case "btnAlterar"
                        item.Enabled = True
                    Case "btnExcluir"
                        item.Enabled = False
                    Case "btnCancelar"
                        item.Enabled = False
                    Case "btnSair"
                        item.Enabled = True
                End Select
            ElseIf acao = "Alterar" Then

                Select Case item.Name
                    Case "btnNovo"
                        item.Enabled = False
                    Case "btnSalvar"
                        item.Enabled = True
                    Case "btnAlterar"
                        item.Enabled = False
                    Case "btnExcluir"
                        item.Enabled = True
                    Case "btnCancelar"
                        item.Enabled = True
                    Case "btnSair"
                        item.Enabled = False
                End Select
            ElseIf (acao = "Excluir") OrElse (acao = "Cancelar") Then

                Select Case item.Name
                    Case "btnNovo"
                        item.Enabled = True
                    Case "btnSalvar"
                        item.Enabled = False
                    Case "btnAlterar"
                        item.Enabled = True
                    Case "btnExcluir"
                        item.Enabled = False
                    Case "btnCancelar"
                        item.Enabled = False
                    Case "btnSair"
                        item.Enabled = True
                End Select
            End If
        Next
    End Sub

    Public Shared Function AspasSQL(ByVal texto As String) As String
        If Not String.IsNullOrEmpty(texto) Then
            texto = "'" & texto & "'"
        Else
            texto = "NULL"
        End If

        Return texto
    End Function

    Public Shared Function NumeroSQL(ByVal texto As Integer?) As String
        Dim resultado As String = String.Empty

        If texto IsNot Nothing Then
            resultado = texto.Value.ToString()
        Else
            resultado = "NULL"
        End If

        Return resultado
    End Function

    Public Shared Function DataSQL(ByVal valor As String) As String
        Dim resultado As String

        If Not String.IsNullOrEmpty(valor) Then
            Dim data As DateTime = Convert.ToDateTime(valor)
            Dim formato As String = data.Year + data.Month.ToString().PadLeft(2, "0"c) + data.Day.ToString().PadLeft(2, "0"c)
            resultado = "'" & formato & "'"
        Else
            resultado = "NULL"
        End If

        Return resultado
    End Function

    Public Shared Function ValorMoeda(ByVal valor As Decimal?) As String
        Dim resultado As String = String.Empty

        If valor.HasValue Then
            resultado = valor.ToString().Replace(",", ".")
        Else
            resultado = valor.GetValueOrDefault().ToString()
        End If

        Return resultado
    End Function

    Public Shared Function FormataNumero(ByVal texto As String) As Integer?
        Dim resultado As Integer? = Nothing

        If Not String.IsNullOrEmpty(texto) Then
            resultado = Convert.ToInt32(texto)
        Else
            resultado = Nothing
        End If

        Return resultado
    End Function

    Public Shared Function ValidaCampoNumerico(ByVal valor As String) As Boolean
        Dim caracter As Char() = valor.ToCharArray()

        For Each car As Char In caracter
            If Not Char.IsDigit(car) Then Return False
        Next

        Return True
    End Function

End Class

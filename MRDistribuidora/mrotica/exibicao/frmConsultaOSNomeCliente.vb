Imports mrotica_util
Public Class frmConsultaOSNomeCliente
    Dim os As New ObjOS
    Private Sub frmConsultaOSNomeCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub carrega_grd()

        Dim TStb As New DataGridTableStyle
        grdOS.DataSource = os.OS_nome_cliente(txtNome.Text)
        TStb.MappingName = grdOS.DataSource.tablename


        Dim cFil As New DataGridTextBoxColumn
        With cFil
            .MappingName = "cod_cliente"
            .HeaderText = "cod. Cliente"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cFil)

        Dim cOS As New DataGridTextBoxColumn
        With cOS
            .MappingName = "doc_cliente"
            .HeaderText = "Doc Cliente"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cOS)

        Dim cOBS As New DataGridTextBoxColumn
        With cOBS
            .MappingName = "observacao"
            .HeaderText = "observação"
            .Width = 400
        End With
        TStb.GridColumnStyles.Add(cOBS)
        Dim cOSL As New DataGridTextBoxColumn
        With cOSL
            .MappingName = "cod_os"
            .HeaderText = "Os Lab."
        End With
        TStb.GridColumnStyles.Add(cOSL)

        grdOS.TableStyles.Clear()
        grdOS.TableStyles.Add(TStb)
    End Sub

    Private Sub txtNome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    carrega_grd()
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub

    Private Sub grdOS_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdOS.DoubleClick
        Dim r As New rptAndamentos
        Dim f As New frmRpt
        Dim fil, ios As Integer
        Try
            fil = grdOS.Item(grdOS.CurrentRowIndex, 0)
            ios = grdOS.Item(grdOS.CurrentRowIndex, 1)
            r.DataSource = os.andamentos_os_otica(fil, ios)
            os = New ObjOS(ios, fil, "")
            r.xfilial = os.id_filial
            r.xos = os.cod_os
            f.Relat(r)
            f.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class
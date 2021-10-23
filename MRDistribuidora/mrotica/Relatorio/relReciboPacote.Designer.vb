<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class relReciboPacote
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relReciboPacote))
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.codigocliente = New DevExpress.XtraReports.Parameters.Parameter()
        Me.codigofilial = New DevExpress.XtraReports.Parameters.Parameter()
        Me.codigopacote = New DevExpress.XtraReports.Parameters.Parameter()
        Me.LineTotalCalcField = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.detailTable = New DevExpress.XtraReports.UI.XRTable()
        Me.detailTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.quantity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.unitPrice = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productDescription = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.vendorTable = New DevExpress.XtraReports.UI.XRTable()
        Me.vendorNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorContactNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorContactName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorAddressRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorAddress = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorCityRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorCity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorCountryRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorCountry = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.customerNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerAddressRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerAddress = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerCityRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerCity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerCountryRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerCountry = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.xrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.invoiceInfoTable = New DevExpress.XtraReports.UI.XRTable()
        Me.invoiceNumberRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceNumber = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDateRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceTotalTable = New DevExpress.XtraReports.UI.XRTable()
        Me.invoiceTotalTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.total2Caption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceTotalTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.total2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.totalTable = New DevExpress.XtraReports.UI.XRTable()
        Me.totalCaptionRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.totalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.total = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrPanel3 = New DevExpress.XtraReports.UI.XRPanel()
        Me.headerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.headerTableRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productNameCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.quantityCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.unitPriceCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineTotalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceTotalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "winlaboConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        QueryParameter1.Name = "codigocliente"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?codigocliente", GetType(Integer))
        QueryParameter2.Name = "codigofilial"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?codigofilial", GetType(Integer))
        QueryParameter3.Name = "codigopacote"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("?codigopacote", GetType(Integer))
        CustomSqlQuery1.Parameters.Add(QueryParameter1)
        CustomSqlQuery1.Parameters.Add(QueryParameter2)
        CustomSqlQuery1.Parameters.Add(QueryParameter3)
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'codigocliente
        '
        resources.ApplyResources(Me.codigocliente, "codigocliente")
        Me.codigocliente.Name = "codigocliente"
        Me.codigocliente.Type = GetType(Integer)
        Me.codigocliente.ValueInfo = "0"
        '
        'codigofilial
        '
        resources.ApplyResources(Me.codigofilial, "codigofilial")
        Me.codigofilial.Name = "codigofilial"
        Me.codigofilial.Type = GetType(Integer)
        Me.codigofilial.ValueInfo = "0"
        '
        'codigopacote
        '
        resources.ApplyResources(Me.codigopacote, "codigopacote")
        Me.codigopacote.Name = "codigopacote"
        Me.codigopacote.Type = GetType(Integer)
        Me.codigopacote.ValueInfo = "0"
        '
        'LineTotalCalcField
        '
        Me.LineTotalCalcField.DataMember = "Query"
        resources.ApplyResources(Me.LineTotalCalcField, "LineTotalCalcField")
        Me.LineTotalCalcField.Expression = "[preco_produto] * [qtde_produto]"
        Me.LineTotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.LineTotalCalcField.Name = "LineTotalCalcField"
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "Query"
        resources.ApplyResources(Me.CalculatedField1, "CalculatedField1")
        Me.CalculatedField1.Expression = "[preco_final_produto] * [qtde_produto]"
        Me.CalculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.detailTable})
        resources.ApplyResources(Me.Detail, "Detail")
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "baseControlStyle"
        '
        'xrLine1
        '
        resources.ApplyResources(Me.xrLine1, "xrLine1")
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.StylePriority.UseForeColor = False
        '
        'detailTable
        '
        resources.ApplyResources(Me.detailTable, "detailTable")
        Me.detailTable.Name = "detailTable"
        Me.detailTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.detailTableRow1, Me.detailTableRow2})
        Me.detailTable.StylePriority.UseBorderColor = False
        Me.detailTable.StylePriority.UseBorders = False
        Me.detailTable.StylePriority.UseFont = False
        '
        'detailTableRow1
        '
        Me.detailTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productName, Me.quantity, Me.unitPrice, Me.lineTotal})
        resources.ApplyResources(Me.detailTableRow1, "detailTableRow1")
        Me.detailTableRow1.Name = "detailTableRow1"
        '
        'productName
        '
        Me.productName.Borders = DevExpress.XtraPrinting.BorderSide.None
        resources.ApplyResources(Me.productName, "productName")
        Me.productName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[descricao_prod]")})
        Me.productName.Name = "productName"
        Me.productName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 15, 0, 100.0!)
        Me.productName.StylePriority.UseBackColor = False
        Me.productName.StylePriority.UseBorders = False
        Me.productName.StylePriority.UseFont = False
        Me.productName.StylePriority.UsePadding = False
        Me.productName.StylePriority.UseTextAlignment = False
        '
        'quantity
        '
        resources.ApplyResources(Me.quantity, "quantity")
        Me.quantity.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qtde_produto]")})
        Me.quantity.Name = "quantity"
        Me.quantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.quantity.RowSpan = 2
        Me.quantity.StylePriority.UseBackColor = False
        Me.quantity.StylePriority.UseBorders = False
        Me.quantity.StylePriority.UseFont = False
        Me.quantity.StylePriority.UsePadding = False
        Me.quantity.StylePriority.UseTextAlignment = False
        '
        'unitPrice
        '
        resources.ApplyResources(Me.unitPrice, "unitPrice")
        Me.unitPrice.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[preco_final_produto]")})
        Me.unitPrice.Name = "unitPrice"
        Me.unitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.unitPrice.RowSpan = 2
        Me.unitPrice.StylePriority.UseBackColor = False
        Me.unitPrice.StylePriority.UseBorders = False
        Me.unitPrice.StylePriority.UseFont = False
        Me.unitPrice.StylePriority.UsePadding = False
        Me.unitPrice.StylePriority.UseTextAlignment = False
        '
        'lineTotal
        '
        resources.ApplyResources(Me.lineTotal, "lineTotal")
        Me.lineTotal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[preco_final_produto]*[qtde_produto]")})
        Me.lineTotal.Name = "lineTotal"
        Me.lineTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.lineTotal.RowSpan = 2
        Me.lineTotal.StylePriority.UseBackColor = False
        Me.lineTotal.StylePriority.UseBorders = False
        Me.lineTotal.StylePriority.UseFont = False
        Me.lineTotal.StylePriority.UseForeColor = False
        Me.lineTotal.StylePriority.UsePadding = False
        Me.lineTotal.StylePriority.UseTextAlignment = False
        '
        'detailTableRow2
        '
        Me.detailTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productDescription, Me.detailTableCell1, Me.detailTableCell2, Me.detailTableCell5})
        resources.ApplyResources(Me.detailTableRow2, "detailTableRow2")
        Me.detailTableRow2.Name = "detailTableRow2"
        '
        'productDescription
        '
        resources.ApplyResources(Me.productDescription, "productDescription")
        Me.productDescription.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[descricao_prod]")})
        Me.productDescription.Name = "productDescription"
        Me.productDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 15, 100.0!)
        Me.productDescription.StylePriority.UseBackColor = False
        Me.productDescription.StylePriority.UseBorders = False
        Me.productDescription.StylePriority.UseFont = False
        Me.productDescription.StylePriority.UseForeColor = False
        Me.productDescription.StylePriority.UsePadding = False
        '
        'detailTableCell1
        '
        resources.ApplyResources(Me.detailTableCell1, "detailTableCell1")
        Me.detailTableCell1.Name = "detailTableCell1"
        Me.detailTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.detailTableCell1.StylePriority.UsePadding = False
        Me.detailTableCell1.StylePriority.UseTextAlignment = False
        '
        'detailTableCell2
        '
        resources.ApplyResources(Me.detailTableCell2, "detailTableCell2")
        Me.detailTableCell2.Name = "detailTableCell2"
        Me.detailTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.detailTableCell2.StylePriority.UsePadding = False
        Me.detailTableCell2.StylePriority.UseTextAlignment = False
        '
        'detailTableCell5
        '
        resources.ApplyResources(Me.detailTableCell5, "detailTableCell5")
        Me.detailTableCell5.Name = "detailTableCell5"
        Me.detailTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.detailTableCell5.StylePriority.UseFont = False
        Me.detailTableCell5.StylePriority.UsePadding = False
        Me.detailTableCell5.StylePriority.UseTextAlignment = False
        '
        'TopMargin
        '
        resources.ApplyResources(Me.TopMargin, "TopMargin")
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        '
        'BottomMargin
        '
        resources.ApplyResources(Me.BottomMargin, "BottomMargin")
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1})
        resources.ApplyResources(Me.GroupHeader2, "GroupHeader2")
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.StyleName = "baseControlStyle"
        Me.GroupHeader2.StylePriority.UseBackColor = False
        Me.GroupHeader2.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'xrPanel1
        '
        Me.xrPanel1.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        resources.ApplyResources(Me.xrPanel1, "xrPanel1")
        Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vendorTable, Me.customerTable, Me.vendorLogo})
        Me.xrPanel1.Name = "xrPanel1"
        Me.xrPanel1.StylePriority.UseBackColor = False
        '
        'vendorTable
        '
        resources.ApplyResources(Me.vendorTable, "vendorTable")
        Me.vendorTable.Name = "vendorTable"
        Me.vendorTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.vendorNameRow, Me.vendorContactNameRow, Me.vendorAddressRow, Me.vendorCityRow, Me.vendorCountryRow})
        '
        'vendorNameRow
        '
        Me.vendorNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorName})
        resources.ApplyResources(Me.vendorNameRow, "vendorNameRow")
        Me.vendorNameRow.Name = "vendorNameRow"
        '
        'vendorName
        '
        resources.ApplyResources(Me.vendorName, "vendorName")
        Me.vendorName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[razao_social]")})
        Me.vendorName.Name = "vendorName"
        Me.vendorName.StylePriority.UseFont = False
        Me.vendorName.StylePriority.UseTextAlignment = False
        '
        'vendorContactNameRow
        '
        Me.vendorContactNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorContactName})
        resources.ApplyResources(Me.vendorContactNameRow, "vendorContactNameRow")
        Me.vendorContactNameRow.Name = "vendorContactNameRow"
        '
        'vendorContactName
        '
        resources.ApplyResources(Me.vendorContactName, "vendorContactName")
        Me.vendorContactName.Name = "vendorContactName"
        Me.vendorContactName.StylePriority.UseFont = False
        Me.vendorContactName.StylePriority.UseTextAlignment = False
        '
        'vendorAddressRow
        '
        Me.vendorAddressRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorAddress})
        resources.ApplyResources(Me.vendorAddressRow, "vendorAddressRow")
        Me.vendorAddressRow.Name = "vendorAddressRow"
        '
        'vendorAddress
        '
        resources.ApplyResources(Me.vendorAddress, "vendorAddress")
        Me.vendorAddress.Name = "vendorAddress"
        Me.vendorAddress.StylePriority.UseFont = False
        Me.vendorAddress.StylePriority.UseTextAlignment = False
        '
        'vendorCityRow
        '
        Me.vendorCityRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorCity})
        resources.ApplyResources(Me.vendorCityRow, "vendorCityRow")
        Me.vendorCityRow.Name = "vendorCityRow"
        '
        'vendorCity
        '
        resources.ApplyResources(Me.vendorCity, "vendorCity")
        Me.vendorCity.Name = "vendorCity"
        Me.vendorCity.StylePriority.UseFont = False
        Me.vendorCity.StylePriority.UseTextAlignment = False
        '
        'vendorCountryRow
        '
        Me.vendorCountryRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorCountry})
        resources.ApplyResources(Me.vendorCountryRow, "vendorCountryRow")
        Me.vendorCountryRow.Name = "vendorCountryRow"
        '
        'vendorCountry
        '
        resources.ApplyResources(Me.vendorCountry, "vendorCountry")
        Me.vendorCountry.Name = "vendorCountry"
        Me.vendorCountry.StylePriority.UseFont = False
        Me.vendorCountry.StylePriority.UseTextAlignment = False
        '
        'customerTable
        '
        Me.customerTable.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
        resources.ApplyResources(Me.customerTable, "customerTable")
        Me.customerTable.Name = "customerTable"
        Me.customerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.customerNameRow, Me.customerAddressRow, Me.customerCityRow, Me.customerCountryRow})
        '
        'customerNameRow
        '
        Me.customerNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerName})
        resources.ApplyResources(Me.customerNameRow, "customerNameRow")
        Me.customerNameRow.Name = "customerNameRow"
        '
        'customerName
        '
        Me.customerName.CanShrink = True
        resources.ApplyResources(Me.customerName, "customerName")
        Me.customerName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[razao_social]")})
        Me.customerName.Name = "customerName"
        Me.customerName.StylePriority.UseFont = False
        Me.customerName.StylePriority.UsePadding = False
        Me.customerName.StylePriority.UseTextAlignment = False
        '
        'customerAddressRow
        '
        Me.customerAddressRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerAddress})
        resources.ApplyResources(Me.customerAddressRow, "customerAddressRow")
        Me.customerAddressRow.Name = "customerAddressRow"
        '
        'customerAddress
        '
        Me.customerAddress.CanShrink = True
        resources.ApplyResources(Me.customerAddress, "customerAddress")
        Me.customerAddress.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[endereco]")})
        Me.customerAddress.Name = "customerAddress"
        Me.customerAddress.StylePriority.UseFont = False
        Me.customerAddress.StylePriority.UseTextAlignment = False
        '
        'customerCityRow
        '
        Me.customerCityRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerCity})
        resources.ApplyResources(Me.customerCityRow, "customerCityRow")
        Me.customerCityRow.Name = "customerCityRow"
        '
        'customerCity
        '
        resources.ApplyResources(Me.customerCity, "customerCity")
        Me.customerCity.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[municipio]")})
        Me.customerCity.Name = "customerCity"
        Me.customerCity.StylePriority.UseFont = False
        Me.customerCity.StylePriority.UseTextAlignment = False
        '
        'customerCountryRow
        '
        Me.customerCountryRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerCountry})
        resources.ApplyResources(Me.customerCountryRow, "customerCountryRow")
        Me.customerCountryRow.Name = "customerCountryRow"
        '
        'customerCountry
        '
        resources.ApplyResources(Me.customerCountry, "customerCountry")
        Me.customerCountry.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fones]")})
        Me.customerCountry.Name = "customerCountry"
        Me.customerCountry.StylePriority.UseFont = False
        Me.customerCountry.StylePriority.UseTextAlignment = False
        '
        'vendorLogo
        '
        resources.ApplyResources(Me.vendorLogo, "vendorLogo")
        Me.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
        Me.vendorLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("vendorLogo.ImageSource"))
        Me.vendorLogo.Name = "vendorLogo"
        Me.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.vendorLogo.StylePriority.UseBorderColor = False
        Me.vendorLogo.StylePriority.UseBorders = False
        Me.vendorLogo.StylePriority.UsePadding = False
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel2})
        resources.ApplyResources(Me.SubBand1, "SubBand1")
        Me.SubBand1.Name = "SubBand1"
        '
        'xrPanel2
        '
        Me.xrPanel2.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        resources.ApplyResources(Me.xrPanel2, "xrPanel2")
        Me.xrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.invoiceInfoTable, Me.invoiceTotalTable})
        Me.xrPanel2.Name = "xrPanel2"
        Me.xrPanel2.StylePriority.UseBackColor = False
        '
        'invoiceInfoTable
        '
        resources.ApplyResources(Me.invoiceInfoTable, "invoiceInfoTable")
        Me.invoiceInfoTable.Name = "invoiceInfoTable"
        Me.invoiceInfoTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.invoiceNumberRow, Me.invoiceDateRow})
        '
        'invoiceNumberRow
        '
        Me.invoiceNumberRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceNumber})
        resources.ApplyResources(Me.invoiceNumberRow, "invoiceNumberRow")
        Me.invoiceNumberRow.Name = "invoiceNumberRow"
        '
        'invoiceNumber
        '
        Me.invoiceNumber.CanGrow = False
        resources.ApplyResources(Me.invoiceNumber, "invoiceNumber")
        Me.invoiceNumber.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cod_pacote]")})
        Me.invoiceNumber.Name = "invoiceNumber"
        Me.invoiceNumber.StylePriority.UseFont = False
        Me.invoiceNumber.StylePriority.UseTextAlignment = False
        '
        'invoiceDateRow
        '
        Me.invoiceDateRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceDate})
        resources.ApplyResources(Me.invoiceDateRow, "invoiceDateRow")
        Me.invoiceDateRow.Name = "invoiceDateRow"
        '
        'invoiceDate
        '
        Me.invoiceDate.CanGrow = False
        resources.ApplyResources(Me.invoiceDate, "invoiceDate")
        Me.invoiceDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[data]")})
        Me.invoiceDate.Name = "invoiceDate"
        Me.invoiceDate.StylePriority.UseFont = False
        Me.invoiceDate.StylePriority.UseTextAlignment = False
        '
        'invoiceTotalTable
        '
        Me.invoiceTotalTable.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
        resources.ApplyResources(Me.invoiceTotalTable, "invoiceTotalTable")
        Me.invoiceTotalTable.Name = "invoiceTotalTable"
        Me.invoiceTotalTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.invoiceTotalTableRow1, Me.invoiceTotalTableRow2})
        '
        'invoiceTotalTableRow1
        '
        Me.invoiceTotalTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.total2Caption})
        resources.ApplyResources(Me.invoiceTotalTableRow1, "invoiceTotalTableRow1")
        Me.invoiceTotalTableRow1.Name = "invoiceTotalTableRow1"
        '
        'total2Caption
        '
        resources.ApplyResources(Me.total2Caption, "total2Caption")
        Me.total2Caption.Name = "total2Caption"
        Me.total2Caption.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 10, 0, 100.0!)
        Me.total2Caption.StylePriority.UseBackColor = False
        Me.total2Caption.StylePriority.UseFont = False
        Me.total2Caption.StylePriority.UseForeColor = False
        Me.total2Caption.StylePriority.UsePadding = False
        Me.total2Caption.StylePriority.UseTextAlignment = False
        '
        'invoiceTotalTableRow2
        '
        Me.invoiceTotalTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.total2})
        resources.ApplyResources(Me.invoiceTotalTableRow2, "invoiceTotalTableRow2")
        Me.invoiceTotalTableRow2.Name = "invoiceTotalTableRow2"
        '
        'total2
        '
        resources.ApplyResources(Me.total2, "total2")
        Me.total2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([preco_final_produto]*[qtde_produto])")})
        Me.total2.Name = "total2"
        Me.total2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 5, 100.0!)
        Me.total2.StylePriority.UseBackColor = False
        Me.total2.StylePriority.UseFont = False
        Me.total2.StylePriority.UseForeColor = False
        Me.total2.StylePriority.UsePadding = False
        Me.total2.StylePriority.UseTextAlignment = False
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.totalTable})
        resources.ApplyResources(Me.GroupFooter1, "GroupFooter1")
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PrintAtBottom = True
        Me.GroupFooter1.StyleName = "baseControlStyle"
        '
        'totalTable
        '
        resources.ApplyResources(Me.totalTable, "totalTable")
        Me.totalTable.Name = "totalTable"
        Me.totalTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.totalCaptionRow, Me.totalRow})
        Me.totalTable.StylePriority.UseBackColor = False
        '
        'totalCaptionRow
        '
        Me.totalCaptionRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.totalCaption})
        resources.ApplyResources(Me.totalCaptionRow, "totalCaptionRow")
        Me.totalCaptionRow.Name = "totalCaptionRow"
        '
        'totalCaption
        '
        resources.ApplyResources(Me.totalCaption, "totalCaption")
        Me.totalCaption.Name = "totalCaption"
        Me.totalCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.totalCaption.StylePriority.UseBackColor = False
        Me.totalCaption.StylePriority.UseFont = False
        Me.totalCaption.StylePriority.UseForeColor = False
        Me.totalCaption.StylePriority.UsePadding = False
        Me.totalCaption.StylePriority.UseTextAlignment = False
        '
        'totalRow
        '
        Me.totalRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.total})
        resources.ApplyResources(Me.totalRow, "totalRow")
        Me.totalRow.Name = "totalRow"
        '
        'total
        '
        resources.ApplyResources(Me.total, "total")
        Me.total.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([LineTotalCalcField])")})
        Me.total.Name = "total"
        Me.total.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.total.StylePriority.UseBackColor = False
        Me.total.StylePriority.UseFont = False
        Me.total.StylePriority.UseForeColor = False
        Me.total.StylePriority.UsePadding = False
        Me.total.StylePriority.UseTextAlignment = False
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel3})
        resources.ApplyResources(Me.GroupHeader1, "GroupHeader1")
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("cod_pacote", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        Me.GroupHeader1.StyleName = "baseControlStyle"
        '
        'xrPanel3
        '
        Me.xrPanel3.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        resources.ApplyResources(Me.xrPanel3, "xrPanel3")
        Me.xrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.headerTable})
        Me.xrPanel3.Name = "xrPanel3"
        Me.xrPanel3.StylePriority.UseBackColor = False
        '
        'headerTable
        '
        resources.ApplyResources(Me.headerTable, "headerTable")
        Me.headerTable.Name = "headerTable"
        Me.headerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.headerTableRow})
        Me.headerTable.StylePriority.UseFont = False
        Me.headerTable.StylePriority.UsePadding = False
        '
        'headerTableRow
        '
        Me.headerTableRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productNameCaption, Me.quantityCaption, Me.unitPriceCaption, Me.lineTotalCaption})
        resources.ApplyResources(Me.headerTableRow, "headerTableRow")
        Me.headerTableRow.Name = "headerTableRow"
        '
        'productNameCaption
        '
        resources.ApplyResources(Me.productNameCaption, "productNameCaption")
        Me.productNameCaption.Name = "productNameCaption"
        Me.productNameCaption.StylePriority.UseBackColor = False
        Me.productNameCaption.StylePriority.UseFont = False
        Me.productNameCaption.StylePriority.UseForeColor = False
        Me.productNameCaption.StylePriority.UsePadding = False
        Me.productNameCaption.StylePriority.UseTextAlignment = False
        '
        'quantityCaption
        '
        resources.ApplyResources(Me.quantityCaption, "quantityCaption")
        Me.quantityCaption.Name = "quantityCaption"
        Me.quantityCaption.StylePriority.UseBackColor = False
        Me.quantityCaption.StylePriority.UseFont = False
        Me.quantityCaption.StylePriority.UseForeColor = False
        Me.quantityCaption.StylePriority.UseTextAlignment = False
        '
        'unitPriceCaption
        '
        resources.ApplyResources(Me.unitPriceCaption, "unitPriceCaption")
        Me.unitPriceCaption.Name = "unitPriceCaption"
        Me.unitPriceCaption.StylePriority.UseBackColor = False
        Me.unitPriceCaption.StylePriority.UseBorderColor = False
        Me.unitPriceCaption.StylePriority.UseBorders = False
        Me.unitPriceCaption.StylePriority.UseFont = False
        Me.unitPriceCaption.StylePriority.UseForeColor = False
        Me.unitPriceCaption.StylePriority.UseTextAlignment = False
        '
        'lineTotalCaption
        '
        resources.ApplyResources(Me.lineTotalCaption, "lineTotalCaption")
        Me.lineTotalCaption.Name = "lineTotalCaption"
        Me.lineTotalCaption.StylePriority.UseBackColor = False
        Me.lineTotalCaption.StylePriority.UseBorderColor = False
        Me.lineTotalCaption.StylePriority.UseBorders = False
        Me.lineTotalCaption.StylePriority.UseFont = False
        Me.lineTotalCaption.StylePriority.UseForeColor = False
        Me.lineTotalCaption.StylePriority.UseTextAlignment = False
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'CalculatedField2
        '
        Me.CalculatedField2.DataMember = "Query"
        resources.ApplyResources(Me.CalculatedField2, "CalculatedField2")
        Me.CalculatedField2.Expression = "[preco_final_produto] * [qtde_produto]"
        Me.CalculatedField2.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'relReciboPacote
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.GroupFooter1, Me.GroupHeader1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1, Me.CalculatedField2})
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource1
        resources.ApplyResources(Me, "$this")
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.codigocliente, Me.codigofilial, Me.codigopacote})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle})
        Me.Version = "18.2"
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceTotalTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents codigocliente As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents codigofilial As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents codigopacote As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents LineTotalCalcField As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents detailTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents quantity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents unitPrice As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents vendorTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents vendorNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorContactNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorContactName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorAddressRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorAddress As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorCityRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorCity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorCountryRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorCountry As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents customerNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerAddressRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerAddress As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerCityRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerCity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerCountryRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerCountry As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents xrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents invoiceInfoTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents invoiceNumberRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceNumber As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDateRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceTotalTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents invoiceTotalTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents total2Caption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceTotalTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents total2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents totalTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents totalCaptionRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents totalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents total As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrPanel3 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents headerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents headerTableRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productNameCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents quantityCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents unitPriceCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineTotalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents CalculatedField2 As DevExpress.XtraReports.UI.CalculatedField
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Panel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnToArchived = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btnToPending = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btnToVerified = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btnToEdit = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnToLoans = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ActiveLoans = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TotalEarnings = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CurrentMoney = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminPanelDatagridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminPanelDatagrid1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2ShadowPanel3.SuspendLayout()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.AdminPanelDatagridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminPanelDatagrid1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.btnToArchived)
        Me.Guna2Panel1.Controls.Add(Me.btnToPending)
        Me.Guna2Panel1.Controls.Add(Me.btnToVerified)
        Me.Guna2Panel1.Controls.Add(Me.btnToEdit)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2DataGridView1)
        Me.Guna2Panel1.Controls.Add(Me.btnToLoans)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1484, 598)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnToArchived
        '
        Me.btnToArchived.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToArchived.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToArchived.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToArchived.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToArchived.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToArchived.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnToArchived.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnToArchived.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.btnToArchived.ForeColor = System.Drawing.Color.White
        Me.btnToArchived.Location = New System.Drawing.Point(1260, 396)
        Me.btnToArchived.Name = "btnToArchived"
        Me.btnToArchived.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnToArchived.Size = New System.Drawing.Size(164, 132)
        Me.btnToArchived.TabIndex = 15
        Me.btnToArchived.Text = "Archived Accounts"
        '
        'btnToPending
        '
        Me.btnToPending.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToPending.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToPending.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToPending.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToPending.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToPending.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnToPending.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnToPending.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.btnToPending.ForeColor = System.Drawing.Color.White
        Me.btnToPending.Location = New System.Drawing.Point(875, 396)
        Me.btnToPending.Name = "btnToPending"
        Me.btnToPending.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnToPending.Size = New System.Drawing.Size(164, 132)
        Me.btnToPending.TabIndex = 14
        Me.btnToPending.Text = "Pending Verification"
        '
        'btnToVerified
        '
        Me.btnToVerified.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToVerified.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToVerified.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToVerified.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToVerified.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToVerified.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnToVerified.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnToVerified.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.btnToVerified.ForeColor = System.Drawing.Color.White
        Me.btnToVerified.Location = New System.Drawing.Point(1073, 396)
        Me.btnToVerified.Name = "btnToVerified"
        Me.btnToVerified.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnToVerified.Size = New System.Drawing.Size(164, 132)
        Me.btnToVerified.TabIndex = 13
        Me.btnToVerified.Text = "Verified Accounts"
        '
        'btnToEdit
        '
        Me.btnToEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnToEdit.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnToEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.btnToEdit.ForeColor = System.Drawing.Color.White
        Me.btnToEdit.Location = New System.Drawing.Point(1073, 175)
        Me.btnToEdit.Name = "btnToEdit"
        Me.btnToEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnToEdit.Size = New System.Drawing.Size(164, 132)
        Me.btnToEdit.TabIndex = 12
        Me.btnToEdit.Text = "Update Current Fund"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(39, 84)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(166, 26)
        Me.Guna2HtmlLabel4.TabIndex = 11
        Me.Guna2HtmlLabel4.Text = "Pending Loans :"
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.865546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 50
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.865546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(39, 116)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(796, 427)
        Me.Guna2DataGridView1.TabIndex = 10
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.865546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.865546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "transacID"
        Me.Column1.HeaderText = "Transaction ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "accID"
        Me.Column4.HeaderText = "Account ID"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "principal"
        Me.Column2.HeaderText = "Loan Amount"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "interest"
        Me.Column5.HeaderText = "Interest"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "total"
        Me.Column6.HeaderText = "Total Amount with Interest"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'btnToLoans
        '
        Me.btnToLoans.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToLoans.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToLoans.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToLoans.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToLoans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToLoans.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnToLoans.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnToLoans.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.btnToLoans.ForeColor = System.Drawing.Color.White
        Me.btnToLoans.Location = New System.Drawing.Point(875, 175)
        Me.btnToLoans.Name = "btnToLoans"
        Me.btnToLoans.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnToLoans.Size = New System.Drawing.Size(164, 132)
        Me.btnToLoans.TabIndex = 4
        Me.btnToLoans.Text = "Loans"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.Guna2ShadowPanel3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ShadowPanel2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(9, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Guna2Panel2.Size = New System.Drawing.Size(1438, 65)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Guna2ShadowPanel3
        '
        Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Controls.Add(Me.ActiveLoans)
        Me.Guna2ShadowPanel3.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(1063, 3)
        Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(350, 61)
        Me.Guna2ShadowPanel3.TabIndex = 20
        '
        'ActiveLoans
        '
        Me.ActiveLoans.BackColor = System.Drawing.Color.Transparent
        Me.ActiveLoans.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.89076!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveLoans.Location = New System.Drawing.Point(223, 17)
        Me.ActiveLoans.Name = "ActiveLoans"
        Me.ActiveLoans.Size = New System.Drawing.Size(63, 25)
        Me.ActiveLoans.TabIndex = 11
        Me.ActiveLoans.Text = "00000"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(72, 16)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(145, 26)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "Active Loans :"
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2ShadowPanel2.Controls.Add(Me.TotalEarnings)
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(528, 3)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(430, 61)
        Me.Guna2ShadowPanel2.TabIndex = 19
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(15, 17)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(328, 26)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "Predicted Earnings Next Month : "
        '
        'TotalEarnings
        '
        Me.TotalEarnings.BackColor = System.Drawing.Color.Transparent
        Me.TotalEarnings.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.89076!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalEarnings.Location = New System.Drawing.Point(349, 17)
        Me.TotalEarnings.Name = "TotalEarnings"
        Me.TotalEarnings.Size = New System.Drawing.Size(63, 25)
        Me.TotalEarnings.TabIndex = 3
        Me.TotalEarnings.Text = "00000"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.CurrentMoney)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(30, 3)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(350, 61)
        Me.Guna2ShadowPanel1.TabIndex = 18
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(18, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(236, 26)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Current Fund Amount :"
        '
        'CurrentMoney
        '
        Me.CurrentMoney.BackColor = System.Drawing.Color.Transparent
        Me.CurrentMoney.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.89076!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentMoney.Location = New System.Drawing.Point(260, 16)
        Me.CurrentMoney.Name = "CurrentMoney"
        Me.CurrentMoney.Size = New System.Drawing.Size(63, 25)
        Me.CurrentMoney.TabIndex = 1
        Me.CurrentMoney.Text = "00000"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.LightGray
        Me.Guna2ControlBox1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1413, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(34, 28)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 124
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 124
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Transaction ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Transaction ID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 124
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Loan Amount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Loan Amount"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 124
        '
        'Admin_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1459, 619)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Panel"
        Me.Text = "Admin_Panel"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2ShadowPanel3.ResumeLayout(False)
        Me.Guna2ShadowPanel3.PerformLayout()
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel2.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.AdminPanelDatagridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminPanelDatagrid1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnToLoans As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents AdminPanelDatagridBindingSource As BindingSource
    Friend WithEvents AdminPanelDatagrid1BindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataTable1BindingSource2 As BindingSource
    Friend WithEvents DataTable1BindingSource1 As BindingSource
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CurrentMoney As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TotalEarnings As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ActiveLoans As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnToEdit As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnToVerified As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents btnToArchived As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents btnToPending As Guna.UI2.WinForms.Guna2GradientCircleButton
End Class

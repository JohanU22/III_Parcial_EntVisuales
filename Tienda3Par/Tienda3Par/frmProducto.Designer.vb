<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Me.PanelNuevoProducto = New System.Windows.Forms.Panel()
        Me.txtFechaVen = New System.Windows.Forms.MaskedTextBox()
        Me.cmbImpto = New System.Windows.Forms.ComboBox()
        Me.txtStockMinimo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TGUARDARCAMBIOS = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DATALISTADO_PRODUCTOS_OKA = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.Código = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.dtgBusquedaProductos = New System.Windows.Forms.DataGridView()
        Me.PanelBusqueda = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.txtbuscarCodigo = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PanelNuevoProducto.SuspendLayout()
        CType(Me.TGUARDARCAMBIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATALISTADO_PRODUCTOS_OKA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.dtgBusquedaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBusqueda.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNuevoProducto
        '
        Me.PanelNuevoProducto.AutoScroll = True
        Me.PanelNuevoProducto.BackColor = System.Drawing.Color.White
        Me.PanelNuevoProducto.Controls.Add(Me.txtFechaVen)
        Me.PanelNuevoProducto.Controls.Add(Me.cmbImpto)
        Me.PanelNuevoProducto.Controls.Add(Me.txtStockMinimo)
        Me.PanelNuevoProducto.Controls.Add(Me.Label9)
        Me.PanelNuevoProducto.Controls.Add(Me.Label8)
        Me.PanelNuevoProducto.Controls.Add(Me.Label7)
        Me.PanelNuevoProducto.Controls.Add(Me.TGUARDARCAMBIOS)
        Me.PanelNuevoProducto.Controls.Add(Me.Panel2)
        Me.PanelNuevoProducto.Controls.Add(Me.DATALISTADO_PRODUCTOS_OKA)
        Me.PanelNuevoProducto.Controls.Add(Me.txtStock)
        Me.PanelNuevoProducto.Controls.Add(Me.txtNombre)
        Me.PanelNuevoProducto.Controls.Add(Me.Label3)
        Me.PanelNuevoProducto.Controls.Add(Me.Label4)
        Me.PanelNuevoProducto.Controls.Add(Me.Label5)
        Me.PanelNuevoProducto.Controls.Add(Me.Label6)
        Me.PanelNuevoProducto.Controls.Add(Me.txtVenta)
        Me.PanelNuevoProducto.Controls.Add(Me.txtCompra)
        Me.PanelNuevoProducto.Controls.Add(Me.Código)
        Me.PanelNuevoProducto.Controls.Add(Me.txtCodigo)
        Me.PanelNuevoProducto.Controls.Add(Me.MenuStrip2)
        Me.PanelNuevoProducto.Controls.Add(Me.Panel30)
        Me.PanelNuevoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PanelNuevoProducto.Location = New System.Drawing.Point(0, 99)
        Me.PanelNuevoProducto.Name = "PanelNuevoProducto"
        Me.PanelNuevoProducto.Size = New System.Drawing.Size(691, 336)
        Me.PanelNuevoProducto.TabIndex = 532
        '
        'txtFechaVen
        '
        Me.txtFechaVen.Location = New System.Drawing.Point(176, 193)
        Me.txtFechaVen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaVen.Mask = "00/00/0000"
        Me.txtFechaVen.Name = "txtFechaVen"
        Me.txtFechaVen.Size = New System.Drawing.Size(116, 26)
        Me.txtFechaVen.TabIndex = 635
        Me.txtFechaVen.ValidatingType = GetType(Date)
        '
        'cmbImpto
        '
        Me.cmbImpto.FormattingEnabled = True
        Me.cmbImpto.Items.AddRange(New Object() {"0.13", "0.15", "0.18"})
        Me.cmbImpto.Location = New System.Drawing.Point(177, 250)
        Me.cmbImpto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbImpto.Name = "cmbImpto"
        Me.cmbImpto.Size = New System.Drawing.Size(92, 28)
        Me.cmbImpto.TabIndex = 634
        '
        'txtStockMinimo
        '
        Me.txtStockMinimo.BackColor = System.Drawing.Color.White
        Me.txtStockMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockMinimo.ForeColor = System.Drawing.Color.Black
        Me.txtStockMinimo.Location = New System.Drawing.Point(177, 221)
        Me.txtStockMinimo.Name = "txtStockMinimo"
        Me.txtStockMinimo.Size = New System.Drawing.Size(114, 26)
        Me.txtStockMinimo.TabIndex = 633
        Me.txtStockMinimo.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 632
        Me.Label9.Text = "Impuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 631
        Me.Label8.Text = "Stock minimo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 20)
        Me.Label7.TabIndex = 630
        Me.Label7.Text = "Fecha vencimiento"
        '
        'TGUARDARCAMBIOS
        '
        Me.TGUARDARCAMBIOS.Image = CType(resources.GetObject("TGUARDARCAMBIOS.Image"), System.Drawing.Image)
        Me.TGUARDARCAMBIOS.Location = New System.Drawing.Point(446, 59)
        Me.TGUARDARCAMBIOS.Name = "TGUARDARCAMBIOS"
        Me.TGUARDARCAMBIOS.Size = New System.Drawing.Size(242, 79)
        Me.TGUARDARCAMBIOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TGUARDARCAMBIOS.TabIndex = 629
        Me.TGUARDARCAMBIOS.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1264, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 13)
        Me.Panel2.TabIndex = 627
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(66, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 9
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(146, 248)
        Me.DataGridView1.TabIndex = 625
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn3})
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(52, 82)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 9
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowTemplate.Height = 40
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(137, 199)
        Me.DataGridView2.TabIndex = 626
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn3.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 340
        Me.Label1.Text = "Label1"
        '
        'DATALISTADO_PRODUCTOS_OKA
        '
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToAddRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToDeleteRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToResizeRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.BackgroundColor = System.Drawing.Color.White
        Me.DATALISTADO_PRODUCTOS_OKA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DATALISTADO_PRODUCTOS_OKA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DATALISTADO_PRODUCTOS_OKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATALISTADO_PRODUCTOS_OKA.ColumnHeadersVisible = False
        Me.DATALISTADO_PRODUCTOS_OKA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn8})
        Me.DATALISTADO_PRODUCTOS_OKA.EnableHeadersVisualStyles = False
        Me.DATALISTADO_PRODUCTOS_OKA.Location = New System.Drawing.Point(694, 43)
        Me.DATALISTADO_PRODUCTOS_OKA.Name = "DATALISTADO_PRODUCTOS_OKA"
        Me.DATALISTADO_PRODUCTOS_OKA.ReadOnly = True
        Me.DATALISTADO_PRODUCTOS_OKA.RowHeadersVisible = False
        Me.DATALISTADO_PRODUCTOS_OKA.RowHeadersWidth = 9
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.Height = 40
        Me.DATALISTADO_PRODUCTOS_OKA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATALISTADO_PRODUCTOS_OKA.Size = New System.Drawing.Size(75, 148)
        Me.DATALISTADO_PRODUCTOS_OKA.TabIndex = 494
        Me.DATALISTADO_PRODUCTOS_OKA.Visible = False
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn8.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.ReadOnly = True
        Me.DataGridViewCheckBoxColumn8.Visible = False
        Me.DataGridViewCheckBoxColumn8.Width = 125
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(177, 101)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(149, 26)
        Me.txtStock.TabIndex = 6
        Me.txtStock.Text = "0"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(177, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 26)
        Me.txtNombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Precio Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Precio Compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre"
        '
        'txtVenta
        '
        Me.txtVenta.BackColor = System.Drawing.Color.White
        Me.txtVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVenta.ForeColor = System.Drawing.Color.Black
        Me.txtVenta.Location = New System.Drawing.Point(177, 164)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(114, 26)
        Me.txtVenta.TabIndex = 8
        Me.txtVenta.Text = "0"
        '
        'txtCompra
        '
        Me.txtCompra.BackColor = System.Drawing.Color.White
        Me.txtCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompra.ForeColor = System.Drawing.Color.Black
        Me.txtCompra.Location = New System.Drawing.Point(177, 133)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(114, 26)
        Me.txtCompra.TabIndex = 7
        Me.txtCompra.Text = "0"
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Código.ForeColor = System.Drawing.Color.Black
        Me.Código.Location = New System.Drawing.Point(22, 32)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(65, 20)
        Me.Código.TabIndex = 338
        Me.Código.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(176, 31)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCodigo.Size = New System.Drawing.Size(151, 26)
        Me.txtCodigo.TabIndex = 2
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip2.Location = New System.Drawing.Point(724, 2)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip2.ShowItemToolTips = True
        Me.MenuStrip2.Size = New System.Drawing.Size(67, 45)
        Me.MenuStrip2.TabIndex = 539
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(126, 41)
        Me.ToolStripMenuItem3.Text = "ToolStripMenuItem3"
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel30.Location = New System.Drawing.Point(177, 283)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(154, 8)
        Me.Panel30.TabIndex = 537
        '
        'dtgBusquedaProductos
        '
        Me.dtgBusquedaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBusquedaProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgBusquedaProductos.Location = New System.Drawing.Point(0, 0)
        Me.dtgBusquedaProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.dtgBusquedaProductos.Name = "dtgBusquedaProductos"
        Me.dtgBusquedaProductos.RowHeadersWidth = 51
        Me.dtgBusquedaProductos.RowTemplate.Height = 24
        Me.dtgBusquedaProductos.Size = New System.Drawing.Size(341, 339)
        Me.dtgBusquedaProductos.TabIndex = 533
        '
        'PanelBusqueda
        '
        Me.PanelBusqueda.BackColor = System.Drawing.Color.White
        Me.PanelBusqueda.Controls.Add(Me.dtgBusquedaProductos)
        Me.PanelBusqueda.Location = New System.Drawing.Point(696, 97)
        Me.PanelBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBusqueda.Name = "PanelBusqueda"
        Me.PanelBusqueda.Size = New System.Drawing.Size(341, 339)
        Me.PanelBusqueda.TabIndex = 629
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel29)
        Me.Panel3.Controls.Add(Me.btnNuevo)
        Me.Panel3.Controls.Add(Me.txtbuscarCodigo)
        Me.Panel3.Controls.Add(Me.MenuStrip1)
        Me.Panel3.Controls.Add(Me.Panel13)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1037, 93)
        Me.Panel3.TabIndex = 630
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel29.Location = New System.Drawing.Point(11, 85)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(273, 2)
        Me.Panel29.TabIndex = 533
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(862, 50)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(111, 42)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNuevo.TabIndex = 359
        Me.btnNuevo.TabStop = False
        '
        'txtbuscarCodigo
        '
        Me.txtbuscarCodigo.BackColor = System.Drawing.Color.White
        Me.txtbuscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscarCodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbuscarCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtbuscarCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtbuscarCodigo.Location = New System.Drawing.Point(11, 60)
        Me.txtbuscarCodigo.Name = "txtbuscarCodigo"
        Me.txtbuscarCodigo.Size = New System.Drawing.Size(272, 22)
        Me.txtbuscarCodigo.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripMenuItem4})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(285, 51)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(67, 45)
        Me.MenuStrip1.TabIndex = 495
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSize = False
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 30)
        Me.btnBuscar.Text = "+"
        Me.btnBuscar.ToolTipText = "Buscar"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(126, 41)
        Me.ToolStripMenuItem4.Text = "ToolStripMenuItem3"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label44)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1037, 48)
        Me.Panel13.TabIndex = 530
        '
        'Label44
        '
        Me.Label44.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(0, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(189, 48)
        Me.Label44.TabIndex = 334
        Me.Label44.Text = "Productos"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(65, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(165, 20)
        Me.Label20.TabIndex = 216
        Me.Label20.Text = "Buscar seleccione en la lupa>>"
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 440)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelBusqueda)
        Me.Controls.Add(Me.PanelNuevoProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProducto"
        Me.Text = "frmProducto"
        Me.PanelNuevoProducto.ResumeLayout(False)
        Me.PanelNuevoProducto.PerformLayout()
        CType(Me.TGUARDARCAMBIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATALISTADO_PRODUCTOS_OKA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.dtgBusquedaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBusqueda.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelNuevoProducto As Panel
    Friend WithEvents txtFechaVen As MaskedTextBox
    Friend WithEvents cmbImpto As ComboBox
    Friend WithEvents txtStockMinimo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TGUARDARCAMBIOS As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents DATALISTADO_PRODUCTOS_OKA As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn8 As DataGridViewCheckBoxColumn
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents Código As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Panel30 As Panel
    Friend WithEvents dtgBusquedaProductos As DataGridView
    Friend WithEvents PanelBusqueda As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents txtbuscarCodigo As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnBuscar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents Label20 As Label
End Class

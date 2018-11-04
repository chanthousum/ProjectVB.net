<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_FRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_FRM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_categoryid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_clear = New System.Windows.Forms.LinkLabel()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.pic_image = New System.Windows.Forms.PictureBox()
        Me.cbo_categoryname = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_sellprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_unitprice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg_product = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Photo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddQtyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_categoryid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_clear)
        Me.GroupBox1.Controls.Add(Me.btn_browse)
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.btn_new)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.pic_image)
        Me.GroupBox1.Controls.Add(Me.cbo_categoryname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_sellprice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_unitprice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_barcode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_productname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'txt_categoryid
        '
        Me.txt_categoryid.Enabled = False
        Me.txt_categoryid.Location = New System.Drawing.Point(154, 183)
        Me.txt_categoryid.Name = "txt_categoryid"
        Me.txt_categoryid.Size = New System.Drawing.Size(233, 26)
        Me.txt_categoryid.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Category ID"
        '
        'lbl_clear
        '
        Me.lbl_clear.AutoSize = True
        Me.lbl_clear.Location = New System.Drawing.Point(475, 189)
        Me.lbl_clear.Name = "lbl_clear"
        Me.lbl_clear.Size = New System.Drawing.Size(46, 20)
        Me.lbl_clear.TabIndex = 17
        Me.lbl_clear.TabStop = True
        Me.lbl_clear.Text = "Clear"
        '
        'btn_browse
        '
        Me.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_browse.Location = New System.Drawing.Point(394, 186)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 27)
        Me.btn_browse.TabIndex = 16
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_close.Location = New System.Drawing.Point(541, 151)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(99, 27)
        Me.btn_close.TabIndex = 15
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.BackgroundImage = CType(resources.GetObject("btn_new.BackgroundImage"), System.Drawing.Image)
        Me.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_new.Location = New System.Drawing.Point(541, 119)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(99, 27)
        Me.btn_new.TabIndex = 14
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_delete.Location = New System.Drawing.Point(541, 87)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(99, 27)
        Me.btn_delete.TabIndex = 13
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.BackgroundImage = CType(resources.GetObject("btn_update.BackgroundImage"), System.Drawing.Image)
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_update.Location = New System.Drawing.Point(541, 58)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(99, 27)
        Me.btn_update.TabIndex = 12
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.BackgroundImage = CType(resources.GetObject("btn_save.BackgroundImage"), System.Drawing.Image)
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_save.Location = New System.Drawing.Point(541, 25)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(99, 27)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'pic_image
        '
        Me.pic_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_image.Location = New System.Drawing.Point(394, 25)
        Me.pic_image.Name = "pic_image"
        Me.pic_image.Size = New System.Drawing.Size(133, 155)
        Me.pic_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_image.TabIndex = 10
        Me.pic_image.TabStop = False
        '
        'cbo_categoryname
        '
        Me.cbo_categoryname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_categoryname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_categoryname.FormattingEnabled = True
        Me.cbo_categoryname.Location = New System.Drawing.Point(154, 152)
        Me.cbo_categoryname.Name = "cbo_categoryname"
        Me.cbo_categoryname.Size = New System.Drawing.Size(233, 28)
        Me.cbo_categoryname.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Category Name"
        '
        'txt_sellprice
        '
        Me.txt_sellprice.Location = New System.Drawing.Point(154, 121)
        Me.txt_sellprice.Name = "txt_sellprice"
        Me.txt_sellprice.Size = New System.Drawing.Size(233, 26)
        Me.txt_sellprice.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sell Price"
        '
        'txt_unitprice
        '
        Me.txt_unitprice.Location = New System.Drawing.Point(154, 89)
        Me.txt_unitprice.Name = "txt_unitprice"
        Me.txt_unitprice.Size = New System.Drawing.Size(233, 26)
        Me.txt_unitprice.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Unit Price"
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(154, 57)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(233, 26)
        Me.txt_barcode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Barcode"
        '
        'txt_productname
        '
        Me.txt_productname.Location = New System.Drawing.Point(154, 25)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.Size = New System.Drawing.Size(233, 26)
        Me.txt_productname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_product)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 310)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dg_product
        '
        Me.dg_product.AllowUserToAddRows = False
        Me.dg_product.AllowUserToDeleteRows = False
        Me.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Photo, Me.Column8})
        Me.dg_product.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dg_product.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_product.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dg_product.Location = New System.Drawing.Point(3, 22)
        Me.dg_product.Name = "dg_product"
        Me.dg_product.ReadOnly = True
        Me.dg_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_product.Size = New System.Drawing.Size(657, 285)
        Me.dg_product.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Barcode"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sell Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Category ID"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.HeaderText = "Category Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Photo
        '
        Me.Photo.HeaderText = "Photo"
        Me.Photo.Name = "Photo"
        Me.Photo.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "QtyInstock"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.AddQtyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 48)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'AddQtyToolStripMenuItem
        '
        Me.AddQtyToolStripMenuItem.Name = "AddQtyToolStripMenuItem"
        Me.AddQtyToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AddQtyToolStripMenuItem.Text = "Add Qty"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(156, 249)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(233, 26)
        Me.txt_search.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Search By :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Location = New System.Drawing.Point(541, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 27)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Print Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Product_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 589)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Product_FRM"
        Me.Text = "Product_FRM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_productname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_sellprice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_unitprice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_barcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_categoryname As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pic_image As System.Windows.Forms.PictureBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents lbl_clear As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dg_product As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_categoryid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddQtyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Photo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

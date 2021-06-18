<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSport = New System.Windows.Forms.DataGridView()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblBrandcolour = New System.Windows.Forms.Label()
        Me.lblBrnadprice = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "D.A.N SPORTS SHOP"
        '
        'dgvSport
        '
        Me.dgvSport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.brand, Me.colour, Me.price, Me.quantity})
        Me.dgvSport.Location = New System.Drawing.Point(12, 72)
        Me.dgvSport.Name = "dgvSport"
        Me.dgvSport.Size = New System.Drawing.Size(462, 166)
        Me.dgvSport.TabIndex = 1
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(489, 102)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(67, 20)
        Me.lblBrand.TabIndex = 2
        Me.lblBrand.Text = "Brand :"
        '
        'lblBrandcolour
        '
        Me.lblBrandcolour.AutoSize = True
        Me.lblBrandcolour.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandcolour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandcolour.Location = New System.Drawing.Point(489, 135)
        Me.lblBrandcolour.Name = "lblBrandcolour"
        Me.lblBrandcolour.Size = New System.Drawing.Size(124, 20)
        Me.lblBrandcolour.TabIndex = 3
        Me.lblBrandcolour.Text = "Brand Colour :"
        '
        'lblBrnadprice
        '
        Me.lblBrnadprice.AutoSize = True
        Me.lblBrnadprice.BackColor = System.Drawing.Color.Transparent
        Me.lblBrnadprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrnadprice.Location = New System.Drawing.Point(489, 171)
        Me.lblBrnadprice.Name = "lblBrnadprice"
        Me.lblBrnadprice.Size = New System.Drawing.Size(151, 20)
        Me.lblBrnadprice.TabIndex = 5
        Me.lblBrnadprice.Text = "Brand Price (RM):"
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(333, 272)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(141, 33)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Location = New System.Drawing.Point(12, 272)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(315, 34)
        Me.BtnAddNew.TabIndex = 8
        Me.BtnAddNew.Text = "ADD NEW BRAND"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(493, 206)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(129, 18)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "Brand Quantity :"
        '
        'brand
        '
        Me.brand.HeaderText = "Brand"
        Me.brand.Name = "brand"
        '
        'colour
        '
        Me.colour.HeaderText = "Brand Colour"
        Me.colour.Name = "colour"
        '
        'price
        '
        Me.price.HeaderText = "Brand Price (RM)"
        Me.price.Name = "price"
        '
        'quantity
        '
        Me.quantity.HeaderText = "Brand Quantity"
        Me.quantity.Name = "quantity"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 331)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.lblBrnadprice)
        Me.Controls.Add(Me.lblBrandcolour)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.dgvSport)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sportshop"
        CType(Me.dgvSport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSport As DataGridView
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandcolour As Label
    Friend WithEvents lblBrnadprice As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents colour As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
End Class

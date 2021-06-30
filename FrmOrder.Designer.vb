<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrder))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOrderBrand = New System.Windows.Forms.TextBox()
        Me.txtBoxOrderColour = New System.Windows.Forms.TextBox()
        Me.TxtBoxOrderPrice = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.NudOrderQuantity = New System.Windows.Forms.NumericUpDown()
        Me.BtnDelete = New System.Windows.Forms.Button()
        CType(Me.NudOrderQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(87, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Brand Price : (RM)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Brand Colour :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Brand Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Brand Quantity : "
        '
        'txtOrderBrand
        '
        Me.txtOrderBrand.Location = New System.Drawing.Point(161, 122)
        Me.txtOrderBrand.Name = "txtOrderBrand"
        Me.txtOrderBrand.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderBrand.TabIndex = 11
        '
        'txtBoxOrderColour
        '
        Me.txtBoxOrderColour.Location = New System.Drawing.Point(161, 177)
        Me.txtBoxOrderColour.Name = "txtBoxOrderColour"
        Me.txtBoxOrderColour.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxOrderColour.TabIndex = 12
        '
        'TxtBoxOrderPrice
        '
        Me.TxtBoxOrderPrice.Location = New System.Drawing.Point(161, 227)
        Me.TxtBoxOrderPrice.Name = "TxtBoxOrderPrice"
        Me.TxtBoxOrderPrice.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxOrderPrice.TabIndex = 13
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(305, 188)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(98, 41)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAdd.Location = New System.Drawing.Point(305, 123)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(98, 44)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "UPDATE ORDER"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'NudOrderQuantity
        '
        Me.NudOrderQuantity.Location = New System.Drawing.Point(161, 282)
        Me.NudOrderQuantity.Name = "NudOrderQuantity"
        Me.NudOrderQuantity.Size = New System.Drawing.Size(100, 20)
        Me.NudOrderQuantity.TabIndex = 18
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnDelete.Location = New System.Drawing.Point(305, 254)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(98, 44)
        Me.BtnDelete.TabIndex = 19
        Me.BtnDelete.Text = "DELETE ORDER"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(437, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.NudOrderQuantity)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtBoxOrderPrice)
        Me.Controls.Add(Me.txtBoxOrderColour)
        Me.Controls.Add(Me.txtOrderBrand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmOrder"
        Me.Text = "FrmOrder"
        CType(Me.NudOrderQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOrderBrand As TextBox
    Friend WithEvents txtBoxOrderColour As TextBox
    Friend WithEvents TxtBoxOrderPrice As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents NudOrderQuantity As NumericUpDown
    Friend WithEvents BtnDelete As Button
End Class

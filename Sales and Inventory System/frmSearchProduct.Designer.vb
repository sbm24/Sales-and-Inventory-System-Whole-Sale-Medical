<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchProduct))
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbWeight = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtC2 = New System.Windows.Forms.TextBox()
        Me.txtP2 = New System.Windows.Forms.TextBox()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1227, 594)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "By Availability"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(8, 101)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1196, 494)
        Me.DataGridView3.TabIndex = 34
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(321, 87)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(11, 26)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 40)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "&Get Data"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(211, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Export Excel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(111, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 40)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "&Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1227, 594)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "By Product Name"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 100)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1208, 494)
        Me.DataGridView1.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 87)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(24, 45)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(291, 24)
        Me.txtProductName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Product Name"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cmbProductName)
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Location = New System.Drawing.Point(348, 7)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(304, 87)
        Me.GroupBox9.TabIndex = 27
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Exact Search"
        '
        'cmbProductName
        '
        Me.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(24, 45)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(261, 25)
        Me.cmbProductName.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 21)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Product Name"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button7)
        Me.GroupBox8.Controls.Add(Me.Button9)
        Me.GroupBox8.Location = New System.Drawing.Point(667, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(227, 87)
        Me.GroupBox8.TabIndex = 28
        Me.GroupBox8.TabStop = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(115, 26)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(94, 40)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "&Export Excel"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(15, 26)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(94, 40)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "&Reset"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1235, 624)
        Me.TabControl1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 9
        '
        'cmbWeight
        '
        Me.cmbWeight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbWeight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbWeight.FormattingEnabled = True
        Me.cmbWeight.Location = New System.Drawing.Point(24, 45)
        Me.cmbWeight.Name = "cmbWeight"
        Me.cmbWeight.Size = New System.Drawing.Size(150, 21)
        Me.cmbWeight.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(115, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Export Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 92
        '
        'txtC2
        '
        Me.txtC2.Location = New System.Drawing.Point(115, 35)
        Me.txtC2.Name = "txtC2"
        Me.txtC2.Size = New System.Drawing.Size(129, 20)
        Me.txtC2.TabIndex = 93
        '
        'txtP2
        '
        Me.txtP2.Location = New System.Drawing.Point(115, 81)
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(129, 20)
        Me.txtP2.TabIndex = 92
        '
        'frmSearchProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1233, 622)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmSearchProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Products"
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbWeight As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtP2 As System.Windows.Forms.TextBox
End Class

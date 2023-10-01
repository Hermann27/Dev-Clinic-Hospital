<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulaireChambre
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnSup = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnFer = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnEnr = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.ComboCap = New System.Windows.Forms.ComboBox()
        Me.Comblocalcham = New System.Windows.Forms.ComboBox()
        Me.Combcategcham = New System.Windows.Forms.ComboBox()
        Me.txtprixcham = New System.Windows.Forms.TextBox()
        Me.txtdesig = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnSup)
        Me.KryptonPanel.Controls.Add(Me.btnFer)
        Me.KryptonPanel.Controls.Add(Me.btnEnr)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(717, 399)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnSup
        '
        Me.btnSup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSup.Location = New System.Drawing.Point(355, 100)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnSup.Size = New System.Drawing.Size(90, 25)
        Me.btnSup.TabIndex = 27
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnFer
        '
        Me.btnFer.AccessibleDescription = ""
        Me.btnFer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFer.Location = New System.Drawing.Point(240, 100)
        Me.btnFer.Name = "btnFer"
        Me.btnFer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnFer.Size = New System.Drawing.Size(90, 25)
        Me.btnFer.TabIndex = 26
        Me.btnFer.Values.Text = "Fermer"
        '
        'btnEnr
        '
        Me.btnEnr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnr.Location = New System.Drawing.Point(133, 100)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnEnr.Size = New System.Drawing.Size(90, 25)
        Me.btnEnr.TabIndex = 25
        Me.btnEnr.Values.Text = "Enregistre"
        '
        'btnMod
        '
        Me.btnMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMod.Location = New System.Drawing.Point(27, 100)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 24
        Me.btnMod.Values.Text = "Modifier"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.ComboCap)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.Comblocalcham)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.Combcategcham)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtprixcham)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtdesig)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtcode)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Panel.Cursor = System.Windows.Forms.Cursors.No
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(711, 94)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Gestion des Chambres"
        Me.KryptonGroupBox1.Values.Heading = "Gestion des Chambres"
        '
        'ComboCap
        '
        Me.ComboCap.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCap.FormattingEnabled = True
        Me.ComboCap.Items.AddRange(New Object() {"2LITS", "3LITS", "4LITS", "5LITS", "6LITS"})
        Me.ComboCap.Location = New System.Drawing.Point(254, 36)
        Me.ComboCap.Name = "ComboCap"
        Me.ComboCap.Size = New System.Drawing.Size(93, 21)
        Me.ComboCap.TabIndex = 26
        '
        'Comblocalcham
        '
        Me.Comblocalcham.Cursor = System.Windows.Forms.Cursors.Default
        Me.Comblocalcham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Comblocalcham.FormattingEnabled = True
        Me.Comblocalcham.Items.AddRange(New Object() {"PEDIATRE", "CHIRUGIE", "REBECA", "YVAN", "ROSALINE", "FALONNE", "BLANCHE", "STEPHANIE"})
        Me.Comblocalcham.Location = New System.Drawing.Point(541, 35)
        Me.Comblocalcham.Name = "Comblocalcham"
        Me.Comblocalcham.Size = New System.Drawing.Size(159, 21)
        Me.Comblocalcham.TabIndex = 25
        '
        'Combcategcham
        '
        Me.Combcategcham.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combcategcham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combcategcham.FormattingEnabled = True
        Me.Combcategcham.Items.AddRange(New Object() {"PRIVE", "PUBLIQUE"})
        Me.Combcategcham.Location = New System.Drawing.Point(541, 10)
        Me.Combcategcham.Name = "Combcategcham"
        Me.Combcategcham.Size = New System.Drawing.Size(159, 21)
        Me.Combcategcham.TabIndex = 24
        '
        'txtprixcham
        '
        Me.txtprixcham.Location = New System.Drawing.Point(71, 37)
        Me.txtprixcham.Name = "txtprixcham"
        Me.txtprixcham.Size = New System.Drawing.Size(100, 20)
        Me.txtprixcham.TabIndex = 23
        '
        'txtdesig
        '
        Me.txtdesig.Location = New System.Drawing.Point(254, 10)
        Me.txtdesig.Multiline = True
        Me.txtdesig.Name = "txtdesig"
        Me.txtdesig.Size = New System.Drawing.Size(164, 20)
        Me.txtdesig.TabIndex = 21
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(71, 11)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 20
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(431, 35)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(74, 20)
        Me.KryptonLabel6.TabIndex = 19
        Me.KryptonLabel6.Values.Text = "Localisation"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(180, 9)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(76, 20)
        Me.KryptonLabel5.TabIndex = 18
        Me.KryptonLabel5.Values.Text = "Designation"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 10)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel4.TabIndex = 17
        Me.KryptonLabel4.Values.Text = "Code"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 37)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(30, 20)
        Me.KryptonLabel3.TabIndex = 16
        Me.KryptonLabel3.Values.Text = "Prix"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(180, 37)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel2.TabIndex = 15
        Me.KryptonLabel2.Values.Text = "Capacite"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(431, 10)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(116, 20)
        Me.KryptonLabel1.TabIndex = 14
        Me.KryptonLabel1.Values.Text = "Categorie Chambre"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.Location = New System.Drawing.Point(8, 131)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DGV.Size = New System.Drawing.Size(704, 265)
        Me.DGV.TabIndex = 19
        '
        'FormulaireChambre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 399)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FormulaireChambre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire  Chambre"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Comblocalcham As System.Windows.Forms.ComboBox
    Friend WithEvents Combcategcham As System.Windows.Forms.ComboBox
    Friend WithEvents txtprixcham As System.Windows.Forms.TextBox
    Friend WithEvents txtdesig As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ComboCap As System.Windows.Forms.ComboBox
    Friend WithEvents btnSup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnFer As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEnr As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulaire_Traitement
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
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.dateFinTraitement = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dateDebutTraitement = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.txtobser = New System.Windows.Forms.TextBox()
        Me.CombDoc = New System.Windows.Forms.ComboBox()
        Me.CombCodeMal = New System.Windows.Forms.ComboBox()
        Me.txtEtatPat = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnSup = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnFer = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnEnr = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
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
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel.Controls.Add(Me.btnSup)
        Me.KryptonPanel.Controls.Add(Me.btnFer)
        Me.KryptonPanel.Controls.Add(Me.btnEnr)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(591, 331)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.dateFinTraitement)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.dateDebutTraitement)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtobser)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.CombDoc)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.CombCodeMal)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtEtatPat)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtcode)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(579, 130)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Enregistrement Traitement"
        Me.KryptonGroupBox1.Values.Heading = "Enregistrement Traitement"
        '
        'dateFinTraitement
        '
        Me.dateFinTraitement.Location = New System.Drawing.Point(79, 79)
        Me.dateFinTraitement.Name = "dateFinTraitement"
        Me.dateFinTraitement.Size = New System.Drawing.Size(163, 21)
        Me.dateFinTraitement.TabIndex = 31
        '
        'dateDebutTraitement
        '
        Me.dateDebutTraitement.Location = New System.Drawing.Point(79, 54)
        Me.dateDebutTraitement.Name = "dateDebutTraitement"
        Me.dateDebutTraitement.Size = New System.Drawing.Size(163, 21)
        Me.dateDebutTraitement.TabIndex = 30
        '
        'txtobser
        '
        Me.txtobser.Location = New System.Drawing.Point(344, 53)
        Me.txtobser.Multiline = True
        Me.txtobser.Name = "txtobser"
        Me.txtobser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobser.Size = New System.Drawing.Size(223, 50)
        Me.txtobser.TabIndex = 29
        '
        'CombDoc
        '
        Me.CombDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombDoc.FormattingEnabled = True
        Me.CombDoc.Location = New System.Drawing.Point(344, 28)
        Me.CombDoc.Name = "CombDoc"
        Me.CombDoc.Size = New System.Drawing.Size(137, 21)
        Me.CombDoc.TabIndex = 28
        '
        'CombCodeMal
        '
        Me.CombCodeMal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombCodeMal.FormattingEnabled = True
        Me.CombCodeMal.Location = New System.Drawing.Point(344, 4)
        Me.CombCodeMal.Name = "CombCodeMal"
        Me.CombCodeMal.Size = New System.Drawing.Size(137, 21)
        Me.CombCodeMal.TabIndex = 27
        '
        'txtEtatPat
        '
        Me.txtEtatPat.Location = New System.Drawing.Point(79, 28)
        Me.txtEtatPat.Name = "txtEtatPat"
        Me.txtEtatPat.Size = New System.Drawing.Size(163, 20)
        Me.txtEtatPat.TabIndex = 24
        '
        'txtcode
        '
        Me.txtcode.Enabled = False
        Me.txtcode.Location = New System.Drawing.Point(79, 5)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(91, 20)
        Me.txtcode.TabIndex = 23
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(262, 51)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel9.TabIndex = 22
        Me.KryptonLabel9.Values.Text = "Observation"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(261, 29)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel8.TabIndex = 21
        Me.KryptonLabel8.Values.Text = "Réf Dossiers"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(261, 4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(86, 20)
        Me.KryptonLabel7.TabIndex = 20
        Me.KryptonLabel7.Values.Text = "Code Maladie"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(6, 78)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel6.TabIndex = 19
        Me.KryptonLabel6.Values.Text = "Date Fin"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(6, 53)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel4.TabIndex = 18
        Me.KryptonLabel4.Values.Text = "Date Debut"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(7, 31)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel3.TabIndex = 17
        Me.KryptonLabel3.Values.Text = "Etat Patient"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 5)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel1.TabIndex = 16
        Me.KryptonLabel1.Values.Text = "Code"
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(420, 291)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnSup.Size = New System.Drawing.Size(90, 25)
        Me.btnSup.TabIndex = 25
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnFer
        '
        Me.btnFer.Location = New System.Drawing.Point(301, 291)
        Me.btnFer.Name = "btnFer"
        Me.btnFer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnFer.Size = New System.Drawing.Size(90, 25)
        Me.btnFer.TabIndex = 24
        Me.btnFer.Values.Text = "Fermer"
        '
        'btnEnr
        '
        Me.btnEnr.Location = New System.Drawing.Point(182, 291)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnEnr.Size = New System.Drawing.Size(90, 25)
        Me.btnEnr.TabIndex = 23
        Me.btnEnr.Values.Text = "Enregistre"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(63, 291)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 22
        Me.btnMod.Values.Text = "Modifier"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.Location = New System.Drawing.Point(2, 139)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(580, 134)
        Me.DGV.TabIndex = 21
        '
        'Formulaire_Traitement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 331)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "Formulaire_Traitement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire Traitement"
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
    Friend WithEvents btnSup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnFer As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEnr As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dateFinTraitement As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dateDebutTraitement As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents txtobser As System.Windows.Forms.TextBox
    Friend WithEvents CombDoc As System.Windows.Forms.ComboBox
    Friend WithEvents CombCodeMal As System.Windows.Forms.ComboBox
    Friend WithEvents txtEtatPat As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

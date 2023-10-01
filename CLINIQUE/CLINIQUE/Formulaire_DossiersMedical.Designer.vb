<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulaire_DossiersMedical
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
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnFer = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnEnr = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CombAP = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtobser = New System.Windows.Forms.TextBox()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Combmedecin = New System.Windows.Forms.ComboBox()
        Me.Combdocmed = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.datevisite = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGV1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.datemedicamprescr = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.txtqtite = New System.Windows.Forms.TextBox()
        Me.Combpat = New System.Windows.Forms.ComboBox()
        Me.Combmedicament = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DGV2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CombordM = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtobservO = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.dateord = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DGV3 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.CombCodOrd = New System.Windows.Forms.ComboBox()
        Me.Combmed = New System.Windows.Forms.ComboBox()
        Me.Combpatient = New System.Windows.Forms.ComboBox()
        Me.datedossier = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnSup)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Controls.Add(Me.btnFer)
        Me.KryptonPanel.Controls.Add(Me.btnEnr)
        Me.KryptonPanel.Controls.Add(Me.TabControl1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(551, 279)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(470, 193)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnSup.Size = New System.Drawing.Size(76, 32)
        Me.btnSup.TabIndex = 20
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(470, 29)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnMod.Size = New System.Drawing.Size(76, 32)
        Me.btnMod.TabIndex = 19
        Me.btnMod.Values.Text = "Modifier"
        '
        'btnFer
        '
        Me.btnFer.Location = New System.Drawing.Point(470, 138)
        Me.btnFer.Name = "btnFer"
        Me.btnFer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnFer.Size = New System.Drawing.Size(76, 32)
        Me.btnFer.TabIndex = 18
        Me.btnFer.Values.Text = "Fermer"
        '
        'btnEnr
        '
        Me.btnEnr.Location = New System.Drawing.Point(470, 83)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnEnr.Size = New System.Drawing.Size(76, 32)
        Me.btnEnr.TabIndex = 17
        Me.btnEnr.Values.Text = "Enregistre"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(5, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(459, 261)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.CombAP)
        Me.TabPage1.Controls.Add(Me.KryptonLabel1)
        Me.TabPage1.Controls.Add(Me.txtobser)
        Me.TabPage1.Controls.Add(Me.DGV)
        Me.TabPage1.Controls.Add(Me.Combmedecin)
        Me.TabPage1.Controls.Add(Me.Combdocmed)
        Me.TabPage1.Controls.Add(Me.KryptonLabel10)
        Me.TabPage1.Controls.Add(Me.datevisite)
        Me.TabPage1.Controls.Add(Me.KryptonLabel11)
        Me.TabPage1.Controls.Add(Me.KryptonLabel13)
        Me.TabPage1.Controls.Add(Me.KryptonLabel12)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(451, 235)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Visite du Medecin"
        '
        'CombAP
        '
        Me.CombAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombAP.FormattingEnabled = True
        Me.CombAP.Location = New System.Drawing.Point(316, 51)
        Me.CombAP.Name = "CombAP"
        Me.CombAP.Size = New System.Drawing.Size(131, 21)
        Me.CombAP.TabIndex = 10
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(212, 53)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(93, 20)
        Me.KryptonLabel1.TabIndex = 9
        Me.KryptonLabel1.Values.Text = "Acte Prestation"
        '
        'txtobser
        '
        Me.txtobser.Location = New System.Drawing.Point(4, 51)
        Me.txtobser.Multiline = True
        Me.txtobser.Name = "txtobser"
        Me.txtobser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobser.Size = New System.Drawing.Size(207, 48)
        Me.txtobser.TabIndex = 7
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(5, 102)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(438, 130)
        Me.DGV.TabIndex = 8
        '
        'Combmedecin
        '
        Me.Combmedecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combmedecin.FormattingEnabled = True
        Me.Combmedecin.Location = New System.Drawing.Point(317, 5)
        Me.Combmedecin.Name = "Combmedecin"
        Me.Combmedecin.Size = New System.Drawing.Size(129, 21)
        Me.Combmedecin.TabIndex = 6
        '
        'Combdocmed
        '
        Me.Combdocmed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combdocmed.FormattingEnabled = True
        Me.Combdocmed.Location = New System.Drawing.Point(317, 27)
        Me.Combdocmed.Name = "Combdocmed"
        Me.Combdocmed.Size = New System.Drawing.Size(131, 21)
        Me.Combdocmed.TabIndex = 5
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(-4, 6)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(69, 20)
        Me.KryptonLabel10.TabIndex = 0
        Me.KryptonLabel10.Values.Text = "Date Visite"
        '
        'datevisite
        '
        Me.datevisite.CalendarTodayDate = New Date(2013, 10, 14, 0, 0, 0, 0)
        Me.datevisite.Location = New System.Drawing.Point(60, 4)
        Me.datevisite.Name = "datevisite"
        Me.datevisite.Size = New System.Drawing.Size(154, 21)
        Me.datevisite.TabIndex = 4
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(-3, 34)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(144, 20)
        Me.KryptonLabel11.TabIndex = 1
        Me.KryptonLabel11.Values.Text = "Observation du medecin"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(215, 6)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(88, 20)
        Me.KryptonLabel13.TabIndex = 3
        Me.KryptonLabel13.Values.Text = "Nom Medecin"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(212, 31)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(111, 20)
        Me.KryptonLabel12.TabIndex = 2
        Me.KryptonLabel12.Values.Text = "N°Dossier Medical"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DGV1)
        Me.TabPage2.Controls.Add(Me.datemedicamprescr)
        Me.TabPage2.Controls.Add(Me.txtqtite)
        Me.TabPage2.Controls.Add(Me.Combpat)
        Me.TabPage2.Controls.Add(Me.Combmedicament)
        Me.TabPage2.Controls.Add(Me.KryptonLabel19)
        Me.TabPage2.Controls.Add(Me.KryptonLabel20)
        Me.TabPage2.Controls.Add(Me.KryptonLabel21)
        Me.TabPage2.Controls.Add(Me.KryptonLabel22)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(451, 235)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Medicament Prescris"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(7, 57)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(440, 170)
        Me.DGV1.TabIndex = 18
        '
        'datemedicamprescr
        '
        Me.datemedicamprescr.CalendarTodayDate = New Date(2013, 10, 14, 0, 0, 0, 0)
        Me.datemedicamprescr.Location = New System.Drawing.Point(55, 7)
        Me.datemedicamprescr.Name = "datemedicamprescr"
        Me.datemedicamprescr.Size = New System.Drawing.Size(160, 21)
        Me.datemedicamprescr.TabIndex = 17
        '
        'txtqtite
        '
        Me.txtqtite.Location = New System.Drawing.Point(55, 34)
        Me.txtqtite.Name = "txtqtite"
        Me.txtqtite.Size = New System.Drawing.Size(73, 20)
        Me.txtqtite.TabIndex = 16
        '
        'Combpat
        '
        Me.Combpat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combpat.FormattingEnabled = True
        Me.Combpat.Location = New System.Drawing.Point(294, 7)
        Me.Combpat.Name = "Combpat"
        Me.Combpat.Size = New System.Drawing.Size(153, 21)
        Me.Combpat.TabIndex = 15
        '
        'Combmedicament
        '
        Me.Combmedicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combmedicament.FormattingEnabled = True
        Me.Combmedicament.Location = New System.Drawing.Point(294, 30)
        Me.Combmedicament.Name = "Combmedicament"
        Me.Combmedicament.Size = New System.Drawing.Size(153, 21)
        Me.Combmedicament.TabIndex = 14
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(220, 7)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel19.TabIndex = 13
        Me.KryptonLabel19.Values.Text = "Nom Patient"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(220, 31)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel20.TabIndex = 12
        Me.KryptonLabel20.Values.Text = "Medicament"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(-1, 34)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel21.TabIndex = 11
        Me.KryptonLabel21.Values.Text = "Quantité"
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(0, 10)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel22.TabIndex = 10
        Me.KryptonLabel22.Values.Text = "Date"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.DGV2)
        Me.TabPage3.Controls.Add(Me.CombordM)
        Me.TabPage3.Controls.Add(Me.KryptonLabel23)
        Me.TabPage3.Controls.Add(Me.txtobservO)
        Me.TabPage3.Controls.Add(Me.txtcode)
        Me.TabPage3.Controls.Add(Me.dateord)
        Me.TabPage3.Controls.Add(Me.KryptonLabel25)
        Me.TabPage3.Controls.Add(Me.KryptonLabel26)
        Me.TabPage3.Controls.Add(Me.KryptonLabel27)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(451, 235)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ordonance"
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(3, 81)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(451, 150)
        Me.DGV2.TabIndex = 22
        '
        'CombordM
        '
        Me.CombordM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombordM.FormattingEnabled = True
        Me.CombordM.Location = New System.Drawing.Point(283, 5)
        Me.CombordM.Name = "CombordM"
        Me.CombordM.Size = New System.Drawing.Size(166, 21)
        Me.CombordM.TabIndex = 21
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(214, 5)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(61, 20)
        Me.KryptonLabel23.TabIndex = 20
        Me.KryptonLabel23.Values.Text = " Medecin"
        '
        'txtobservO
        '
        Me.txtobservO.Location = New System.Drawing.Point(284, 31)
        Me.txtobservO.Multiline = True
        Me.txtobservO.Name = "txtobservO"
        Me.txtobservO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservO.Size = New System.Drawing.Size(166, 47)
        Me.txtobservO.TabIndex = 18
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(45, 5)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(91, 20)
        Me.txtcode.TabIndex = 17
        '
        'dateord
        '
        Me.dateord.CalendarTodayDate = New Date(2013, 10, 14, 0, 0, 0, 0)
        Me.dateord.Location = New System.Drawing.Point(45, 30)
        Me.dateord.Name = "dateord"
        Me.dateord.Size = New System.Drawing.Size(163, 21)
        Me.dateord.TabIndex = 16
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(215, 31)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel25.TabIndex = 14
        Me.KryptonLabel25.Values.Text = "Observation"
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(3, 29)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel26.TabIndex = 13
        Me.KryptonLabel26.Values.Text = "Date"
        '
        'KryptonLabel27
        '
        Me.KryptonLabel27.Location = New System.Drawing.Point(3, 4)
        Me.KryptonLabel27.Name = "KryptonLabel27"
        Me.KryptonLabel27.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel27.TabIndex = 12
        Me.KryptonLabel27.Values.Text = "Code"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.DGV3)
        Me.TabPage4.Controls.Add(Me.txtref)
        Me.TabPage4.Controls.Add(Me.CombCodOrd)
        Me.TabPage4.Controls.Add(Me.Combmed)
        Me.TabPage4.Controls.Add(Me.Combpatient)
        Me.TabPage4.Controls.Add(Me.datedossier)
        Me.TabPage4.Controls.Add(Me.KryptonLabel28)
        Me.TabPage4.Controls.Add(Me.KryptonLabel29)
        Me.TabPage4.Controls.Add(Me.KryptonLabel30)
        Me.TabPage4.Controls.Add(Me.KryptonLabel31)
        Me.TabPage4.Controls.Add(Me.KryptonLabel32)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(451, 235)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Dossiers Medical"
        '
        'DGV3
        '
        Me.DGV3.AllowUserToAddRows = False
        Me.DGV3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV3.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.DGV3.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGV3.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV3.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV3.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV3.Location = New System.Drawing.Point(9, 79)
        Me.DGV3.Name = "DGV3"
        Me.DGV3.ReadOnly = True
        Me.DGV3.Size = New System.Drawing.Size(439, 150)
        Me.DGV3.TabIndex = 21
        '
        'txtref
        '
        Me.txtref.Location = New System.Drawing.Point(76, 32)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(157, 20)
        Me.txtref.TabIndex = 20
        '
        'CombCodOrd
        '
        Me.CombCodOrd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombCodOrd.FormattingEnabled = True
        Me.CombCodOrd.Location = New System.Drawing.Point(334, 51)
        Me.CombCodOrd.Name = "CombCodOrd"
        Me.CombCodOrd.Size = New System.Drawing.Size(114, 21)
        Me.CombCodOrd.TabIndex = 19
        '
        'Combmed
        '
        Me.Combmed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combmed.FormattingEnabled = True
        Me.Combmed.Location = New System.Drawing.Point(334, 28)
        Me.Combmed.Name = "Combmed"
        Me.Combmed.Size = New System.Drawing.Size(114, 21)
        Me.Combmed.TabIndex = 18
        '
        'Combpatient
        '
        Me.Combpatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combpatient.FormattingEnabled = True
        Me.Combpatient.Location = New System.Drawing.Point(334, 5)
        Me.Combpatient.Name = "Combpatient"
        Me.Combpatient.Size = New System.Drawing.Size(114, 21)
        Me.Combpatient.TabIndex = 17
        '
        'datedossier
        '
        Me.datedossier.CalendarTodayDate = New Date(2013, 10, 14, 0, 0, 0, 0)
        Me.datedossier.Location = New System.Drawing.Point(76, 8)
        Me.datedossier.Name = "datedossier"
        Me.datedossier.Size = New System.Drawing.Size(157, 21)
        Me.datedossier.TabIndex = 16
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(234, 53)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(103, 20)
        Me.KryptonLabel28.TabIndex = 15
        Me.KryptonLabel28.Values.Text = "Code Ordonance"
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(235, 33)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(106, 20)
        Me.KryptonLabel29.TabIndex = 14
        Me.KryptonLabel29.Values.Text = "Nom du Medecin"
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(236, 11)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(97, 20)
        Me.KryptonLabel30.TabIndex = 13
        Me.KryptonLabel30.Values.Text = "Nom du Patient"
        '
        'KryptonLabel31
        '
        Me.KryptonLabel31.Location = New System.Drawing.Point(4, 34)
        Me.KryptonLabel31.Name = "KryptonLabel31"
        Me.KryptonLabel31.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel31.TabIndex = 12
        Me.KryptonLabel31.Values.Text = "NumeroRéf"
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(4, 11)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Size = New System.Drawing.Size(78, 20)
        Me.KryptonLabel32.TabIndex = 11
        Me.KryptonLabel32.Values.Text = "Date dossier"
        '
        'Formulaire_DossiersMedical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 279)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "Formulaire_DossiersMedical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire Complementaire du patient"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnFer As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEnr As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtobser As System.Windows.Forms.TextBox
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Combmedecin As System.Windows.Forms.ComboBox
    Friend WithEvents Combdocmed As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents datevisite As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DGV1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents datemedicamprescr As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents txtqtite As System.Windows.Forms.TextBox
    Friend WithEvents Combpat As System.Windows.Forms.ComboBox
    Friend WithEvents Combmedicament As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DGV2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CombordM As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtobservO As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents dateord As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DGV3 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents CombCodOrd As System.Windows.Forms.ComboBox
    Friend WithEvents Combmed As System.Windows.Forms.ComboBox
    Friend WithEvents Combpatient As System.Windows.Forms.ComboBox
    Friend WithEvents datedossier As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents CombAP As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

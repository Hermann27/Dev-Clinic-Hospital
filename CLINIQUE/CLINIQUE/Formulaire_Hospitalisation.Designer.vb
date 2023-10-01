<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulaire_Hospitalisation
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
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.btnSup = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnFer = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnEnr = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.dateSortieHosp = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dateArriveeHosp = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.txtobser = New System.Windows.Forms.TextBox()
        Me.CombcodCham = New System.Windows.Forms.ComboBox()
        Me.CombdossPat = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Controls.Add(Me.btnSup)
        Me.KryptonPanel.Controls.Add(Me.btnFer)
        Me.KryptonPanel.Controls.Add(Me.btnEnr)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(684, 368)
        Me.KryptonPanel.TabIndex = 0
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
        Me.DGV.Location = New System.Drawing.Point(3, 132)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(669, 164)
        Me.DGV.TabIndex = 34
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(481, 320)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnSup.Size = New System.Drawing.Size(90, 25)
        Me.btnSup.TabIndex = 33
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnFer
        '
        Me.btnFer.Location = New System.Drawing.Point(354, 320)
        Me.btnFer.Name = "btnFer"
        Me.btnFer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnFer.Size = New System.Drawing.Size(90, 25)
        Me.btnFer.TabIndex = 32
        Me.btnFer.Values.Text = "Fermer"
        '
        'btnEnr
        '
        Me.btnEnr.Location = New System.Drawing.Point(225, 320)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnEnr.Size = New System.Drawing.Size(90, 25)
        Me.btnEnr.TabIndex = 31
        Me.btnEnr.Values.Text = "Enregistre"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(97, 320)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 30
        Me.btnMod.Values.Text = "Modifier"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.dateSortieHosp)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.dateArriveeHosp)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtcode)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtobser)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.CombcodCham)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.CombdossPat)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(678, 126)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Lime
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Hosipitalisation"
        Me.KryptonGroupBox1.Values.Heading = "Hosipitalisation"
        '
        'dateSortieHosp
        '
        Me.dateSortieHosp.Location = New System.Drawing.Point(129, 57)
        Me.dateSortieHosp.Name = "dateSortieHosp"
        Me.dateSortieHosp.Size = New System.Drawing.Size(165, 21)
        Me.dateSortieHosp.TabIndex = 42
        '
        'dateArriveeHosp
        '
        Me.dateArriveeHosp.Location = New System.Drawing.Point(129, 30)
        Me.dateArriveeHosp.Name = "dateArriveeHosp"
        Me.dateArriveeHosp.Size = New System.Drawing.Size(165, 21)
        Me.dateArriveeHosp.TabIndex = 41
        '
        'txtcode
        '
        Me.txtcode.Enabled = False
        Me.txtcode.Location = New System.Drawing.Point(129, 5)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 40
        '
        'txtobser
        '
        Me.txtobser.Location = New System.Drawing.Point(480, 61)
        Me.txtobser.Multiline = True
        Me.txtobser.Name = "txtobser"
        Me.txtobser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobser.Size = New System.Drawing.Size(186, 35)
        Me.txtobser.TabIndex = 39
        '
        'CombcodCham
        '
        Me.CombcodCham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombcodCham.FormattingEnabled = True
        Me.CombcodCham.Location = New System.Drawing.Point(480, 34)
        Me.CombcodCham.Name = "CombcodCham"
        Me.CombcodCham.Size = New System.Drawing.Size(186, 21)
        Me.CombcodCham.TabIndex = 38
        '
        'CombdossPat
        '
        Me.CombdossPat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombdossPat.FormattingEnabled = True
        Me.CombdossPat.Location = New System.Drawing.Point(480, 4)
        Me.CombdossPat.Name = "CombdossPat"
        Me.CombdossPat.Size = New System.Drawing.Size(186, 21)
        Me.CombdossPat.TabIndex = 37
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(361, 57)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel1.TabIndex = 29
        Me.KryptonLabel1.Values.Text = "Observation"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(359, 31)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel2.TabIndex = 30
        Me.KryptonLabel2.Values.Text = "Code Chambre"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(359, 5)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(115, 20)
        Me.KryptonLabel3.TabIndex = 31
        Me.KryptonLabel3.Values.Text = "N° Dossiers Patient"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(9, 5)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(123, 20)
        Me.KryptonLabel4.TabIndex = 32
        Me.KryptonLabel4.Values.Text = "Code Hospitalisation"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(9, 31)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(76, 20)
        Me.KryptonLabel5.TabIndex = 33
        Me.KryptonLabel5.Values.Text = "Date arrivée"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(10, 57)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel6.TabIndex = 34
        Me.KryptonLabel6.Values.Text = "Date Sortie"
        '
        'Formulaire_Hospitalisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 368)
        Me.Controls.Add(Me.KryptonGroupBox1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "Formulaire_Hospitalisation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire_Hospitalisation"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
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
    Friend WithEvents btnSup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnFer As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEnr As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtobser As System.Windows.Forms.TextBox
    Friend WithEvents CombcodCham As System.Windows.Forms.ComboBox
    Friend WithEvents CombdossPat As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dateSortieHosp As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dateArriveeHosp As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
End Class

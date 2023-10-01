<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulair_Laboratoire
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
        Me.btnFe = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnEn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.datelab = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.txtdesig = New System.Windows.Forms.TextBox()
        Me.CombExam = New System.Windows.Forms.ComboBox()
        Me.CombDP = New System.Windows.Forms.ComboBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnSu = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
        Me.KryptonPanel.Controls.Add(Me.btnFe)
        Me.KryptonPanel.Controls.Add(Me.btnEn)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel.Controls.Add(Me.btnSu)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(752, 366)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnFe
        '
        Me.btnFe.Location = New System.Drawing.Point(250, 102)
        Me.btnFe.Name = "btnFe"
        Me.btnFe.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnFe.Size = New System.Drawing.Size(90, 25)
        Me.btnFe.TabIndex = 26
        Me.btnFe.Values.Text = "Fermer"
        '
        'btnEn
        '
        Me.btnEn.Location = New System.Drawing.Point(127, 102)
        Me.btnEn.Name = "btnEn"
        Me.btnEn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnEn.Size = New System.Drawing.Size(90, 25)
        Me.btnEn.TabIndex = 25
        Me.btnEn.Values.Text = "Enregistre"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(4, 102)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 24
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
        Me.DGV.Location = New System.Drawing.Point(6, 141)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(743, 222)
        Me.DGV.TabIndex = 23
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.datelab)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtdesig)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.CombExam)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.CombDP)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtcode)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(749, 93)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Lime
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Gestion du laboratoire"
        Me.KryptonGroupBox1.Values.Heading = "Gestion du laboratoire"
        '
        'datelab
        '
        Me.datelab.CalendarTodayDate = New Date(2013, 9, 29, 0, 0, 0, 0)
        Me.datelab.Location = New System.Drawing.Point(58, 35)
        Me.datelab.Name = "datelab"
        Me.datelab.Size = New System.Drawing.Size(181, 21)
        Me.datelab.TabIndex = 25
        '
        'txtdesig
        '
        Me.txtdesig.Location = New System.Drawing.Point(580, 8)
        Me.txtdesig.Multiline = True
        Me.txtdesig.Name = "txtdesig"
        Me.txtdesig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdesig.Size = New System.Drawing.Size(162, 48)
        Me.txtdesig.TabIndex = 24
        '
        'CombExam
        '
        Me.CombExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombExam.FormattingEnabled = True
        Me.CombExam.Location = New System.Drawing.Point(386, 33)
        Me.CombExam.Name = "CombExam"
        Me.CombExam.Size = New System.Drawing.Size(119, 21)
        Me.CombExam.TabIndex = 22
        '
        'CombDP
        '
        Me.CombDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombDP.FormattingEnabled = True
        Me.CombDP.Location = New System.Drawing.Point(385, 7)
        Me.CombDP.Name = "CombDP"
        Me.CombDP.Size = New System.Drawing.Size(120, 21)
        Me.CombDP.TabIndex = 21
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(58, 9)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 18
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(508, 8)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel5.TabIndex = 17
        Me.KryptonLabel5.Values.Text = "Observation"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(7, 34)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel4.TabIndex = 16
        Me.KryptonLabel4.Values.Text = "Date"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(270, 8)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(109, 20)
        Me.KryptonLabel3.TabIndex = 15
        Me.KryptonLabel3.Values.Text = "N° Dossier Patient"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(270, 35)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel2.TabIndex = 14
        Me.KryptonLabel2.Values.Text = "Examens"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel1.TabIndex = 13
        Me.KryptonLabel1.Values.Text = "Code"
        '
        'btnSu
        '
        Me.btnSu.Location = New System.Drawing.Point(373, 102)
        Me.btnSu.Name = "btnSu"
        Me.btnSu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnSu.Size = New System.Drawing.Size(90, 25)
        Me.btnSu.TabIndex = 27
        Me.btnSu.Values.Text = "Supprimer"
        '
        'Formulair_Laboratoire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 366)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "Formulair_Laboratoire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulair Laboratoire"
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
    Friend WithEvents btnSu As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnFe As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEn As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents datelab As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents txtdesig As System.Windows.Forms.TextBox
    Friend WithEvents CombExam As System.Windows.Forms.ComboBox
    Friend WithEvents CombDP As System.Windows.Forms.ComboBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

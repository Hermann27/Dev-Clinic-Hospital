<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulaireConsultation
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSu = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnFe = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnEn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.gr = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.ch = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.Combmedecin = New System.Windows.Forms.ComboBox()
        Me.Combtypecon = New System.Windows.Forms.ComboBox()
        Me.txtobsermed = New System.Windows.Forms.TextBox()
        Me.txtprixcon = New System.Windows.Forms.TextBox()
        Me.datecon = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Combpatient = New System.Windows.Forms.ComboBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gr.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gr.Panel.SuspendLayout()
        Me.gr.SuspendLayout()
        CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox2.Panel.SuspendLayout()
        Me.KryptonGroupBox2.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(728, 472)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.Label2)
        Me.KryptonPanel1.Controls.Add(Me.Label1)
        Me.KryptonPanel1.Controls.Add(Me.Label3)
        Me.KryptonPanel1.Controls.Add(Me.btnSu)
        Me.KryptonPanel1.Controls.Add(Me.btnMo)
        Me.KryptonPanel1.Controls.Add(Me.btnFe)
        Me.KryptonPanel1.Controls.Add(Me.btnEn)
        Me.KryptonPanel1.Controls.Add(Me.DGV)
        Me.KryptonPanel1.Controls.Add(Me.gr)
        Me.KryptonPanel1.Controls.Add(Me.KryptonGroupBox2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(728, 472)
        Me.KryptonPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(106, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(502, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = " LISTE DES CONSULTATIONS DES PATIENTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(118, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "GESTION DES CONSULTATIONS DES PATIENTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(108, 447)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(516, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "* pour choisir une consultation, selectionnez la ligne dans la liste des consulta" & _
            "tions du patient."
        '
        'btnSu
        '
        Me.btnSu.Location = New System.Drawing.Point(640, 214)
        Me.btnSu.Name = "btnSu"
        Me.btnSu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnSu.Size = New System.Drawing.Size(76, 32)
        Me.btnSu.TabIndex = 15
        Me.btnSu.Values.Text = "Supprimer"
        '
        'btnMo
        '
        Me.btnMo.Location = New System.Drawing.Point(640, 100)
        Me.btnMo.Name = "btnMo"
        Me.btnMo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnMo.Size = New System.Drawing.Size(76, 32)
        Me.btnMo.TabIndex = 14
        Me.btnMo.Values.Text = "Modifier"
        '
        'btnFe
        '
        Me.btnFe.Location = New System.Drawing.Point(640, 176)
        Me.btnFe.Name = "btnFe"
        Me.btnFe.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnFe.Size = New System.Drawing.Size(76, 32)
        Me.btnFe.TabIndex = 13
        Me.btnFe.Values.Text = "Fermer"
        '
        'btnEn
        '
        Me.btnEn.Location = New System.Drawing.Point(640, 138)
        Me.btnEn.Name = "btnEn"
        Me.btnEn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnEn.Size = New System.Drawing.Size(76, 32)
        Me.btnEn.TabIndex = 12
        Me.btnEn.Values.Text = "Enregistre"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.Location = New System.Drawing.Point(2, 287)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(722, 150)
        Me.DGV.TabIndex = 1
        '
        'gr
        '
        Me.gr.Location = New System.Drawing.Point(465, 44)
        Me.gr.Name = "gr"
        '
        'gr.Panel
        '
        Me.gr.Panel.Controls.Add(Me.KryptonLabel8)
        Me.gr.Panel.Controls.Add(Me.txtsearch)
        Me.gr.Size = New System.Drawing.Size(251, 50)
        Me.gr.TabIndex = 3
        Me.gr.Text = "Recherche Patient Consulté"
        Me.gr.Values.Heading = "Recherche Patient Consulté"
        Me.gr.Visible = False
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(5, 1)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(49, 20)
        Me.KryptonLabel8.TabIndex = 1
        Me.KryptonLabel8.Values.Text = "Patient"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(52, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(190, 20)
        Me.txtsearch.TabIndex = 0
        '
        'KryptonGroupBox2
        '
        Me.KryptonGroupBox2.Location = New System.Drawing.Point(12, 40)
        Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
        '
        'KryptonGroupBox2.Panel
        '
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.ch)
        Me.KryptonGroupBox2.Size = New System.Drawing.Size(212, 50)
        Me.KryptonGroupBox2.TabIndex = 2
        Me.KryptonGroupBox2.Text = "Recherche Patient Consulté"
        Me.KryptonGroupBox2.Values.Heading = "Recherche Patient Consulté"
        '
        'ch
        '
        Me.ch.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.ch.Location = New System.Drawing.Point(3, 4)
        Me.ch.Name = "ch"
        Me.ch.Size = New System.Drawing.Size(203, 20)
        Me.ch.TabIndex = 3
        Me.ch.Text = "Mode de recherche est dèsactivé"
        Me.ch.Values.Text = "Mode de recherche est dèsactivé"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.Combmedecin)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.Combtypecon)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtobsermed)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtprixcon)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.datecon)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.Combpatient)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(614, 150)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Consultation"
        Me.KryptonGroupBox1.Values.Heading = "Consultation"
        '
        'Combmedecin
        '
        Me.Combmedecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combmedecin.FormattingEnabled = True
        Me.Combmedecin.Location = New System.Drawing.Point(465, 59)
        Me.Combmedecin.Name = "Combmedecin"
        Me.Combmedecin.Size = New System.Drawing.Size(142, 21)
        Me.Combmedecin.TabIndex = 14
        '
        'Combtypecon
        '
        Me.Combtypecon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combtypecon.FormattingEnabled = True
        Me.Combtypecon.Items.AddRange(New Object() {"SPECIALISTE", "GENERALISTE", "KINESITHERAPIE", "URGENCE"})
        Me.Combtypecon.Location = New System.Drawing.Point(465, 32)
        Me.Combtypecon.Name = "Combtypecon"
        Me.Combtypecon.Size = New System.Drawing.Size(140, 21)
        Me.Combtypecon.TabIndex = 13
        '
        'txtobsermed
        '
        Me.txtobsermed.Location = New System.Drawing.Point(6, 74)
        Me.txtobsermed.Multiline = True
        Me.txtobsermed.Name = "txtobsermed"
        Me.txtobsermed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobsermed.Size = New System.Drawing.Size(306, 48)
        Me.txtobsermed.TabIndex = 12
        '
        'txtprixcon
        '
        Me.txtprixcon.Location = New System.Drawing.Point(128, 32)
        Me.txtprixcon.Name = "txtprixcon"
        Me.txtprixcon.Size = New System.Drawing.Size(100, 20)
        Me.txtprixcon.TabIndex = 11
        '
        'datecon
        '
        Me.datecon.Location = New System.Drawing.Point(128, 5)
        Me.datecon.Name = "datecon"
        Me.datecon.Size = New System.Drawing.Size(184, 21)
        Me.datecon.TabIndex = 10
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(343, 60)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(109, 20)
        Me.KryptonLabel7.TabIndex = 9
        Me.KryptonLabel7.Values.Text = "Nom du  Medecin "
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(343, 9)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(97, 20)
        Me.KryptonLabel6.TabIndex = 8
        Me.KryptonLabel6.Values.Text = "Nom du Patient"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(6, 32)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(103, 20)
        Me.KryptonLabel4.TabIndex = 6
        Me.KryptonLabel4.Values.Text = "Prix Consultation"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(341, 35)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(109, 20)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Values.Text = "Type Consultation"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(6, 58)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(127, 20)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Values.Text = "Observation Medecin"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 2)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(109, 20)
        Me.KryptonLabel1.TabIndex = 3
        Me.KryptonLabel1.Values.Text = "Date Consultation"
        '
        'Combpatient
        '
        Me.Combpatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combpatient.FormattingEnabled = True
        Me.Combpatient.Location = New System.Drawing.Point(465, 5)
        Me.Combpatient.Name = "Combpatient"
        Me.Combpatient.Size = New System.Drawing.Size(140, 21)
        Me.Combpatient.TabIndex = 1
        '
        'FormulaireConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 472)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FormulaireConsultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormulaireConsultation"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gr.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gr.Panel.ResumeLayout(False)
        Me.gr.Panel.PerformLayout()
        CType(Me.gr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gr.ResumeLayout(False)
        CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox2.Panel.ResumeLayout(False)
        Me.KryptonGroupBox2.Panel.PerformLayout()
        CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox2.ResumeLayout(False)
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSu As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnFe As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEn As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents gr As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents ch As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents Combmedecin As System.Windows.Forms.ComboBox
    Friend WithEvents Combtypecon As System.Windows.Forms.ComboBox
    Friend WithEvents txtobsermed As System.Windows.Forms.TextBox
    Friend WithEvents txtprixcon As System.Windows.Forms.TextBox
    Friend WithEvents datecon As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Combpatient As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulaireService
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
        Me.btnDel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnaj = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnUP = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.txtdesig = New System.Windows.Forms.TextBox()
        Me.txtintitule = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Controls.Add(Me.btnDel)
        Me.KryptonPanel.Controls.Add(Me.btnClose)
        Me.KryptonPanel.Controls.Add(Me.btnaj)
        Me.KryptonPanel.Controls.Add(Me.btnUP)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(470, 298)
        Me.KryptonPanel.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 90)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(464, 144)
        Me.DGV.TabIndex = 46
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(369, 249)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnDel.Size = New System.Drawing.Size(90, 25)
        Me.btnDel.TabIndex = 45
        Me.btnDel.Values.Text = "Supprimer"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(250, 249)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnClose.Size = New System.Drawing.Size(90, 25)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Values.Text = "Fermer"
        '
        'btnaj
        '
        Me.btnaj.Location = New System.Drawing.Point(131, 249)
        Me.btnaj.Name = "btnaj"
        Me.btnaj.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnaj.Size = New System.Drawing.Size(90, 25)
        Me.btnaj.TabIndex = 43
        Me.btnaj.Values.Text = "Enregistre"
        '
        'btnUP
        '
        Me.btnUP.Location = New System.Drawing.Point(12, 249)
        Me.btnUP.Name = "btnUP"
        Me.btnUP.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnUP.Size = New System.Drawing.Size(90, 25)
        Me.btnUP.TabIndex = 42
        Me.btnUP.Values.Text = "Modifier"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtdesig)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtintitule)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtcode)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(467, 82)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Enregistrement des Services"
        Me.KryptonGroupBox1.Values.Heading = "Enregistrement des Services"
        '
        'txtdesig
        '
        Me.txtdesig.Location = New System.Drawing.Point(279, 6)
        Me.txtdesig.Multiline = True
        Me.txtdesig.Name = "txtdesig"
        Me.txtdesig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdesig.Size = New System.Drawing.Size(176, 46)
        Me.txtdesig.TabIndex = 48
        '
        'txtintitule
        '
        Me.txtintitule.Location = New System.Drawing.Point(91, 32)
        Me.txtintitule.Name = "txtintitule"
        Me.txtintitule.Size = New System.Drawing.Size(100, 20)
        Me.txtintitule.TabIndex = 47
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(91, 6)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 46
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(206, 6)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(76, 20)
        Me.KryptonLabel3.TabIndex = 45
        Me.KryptonLabel3.Values.Text = "Designation"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(9, 32)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(49, 20)
        Me.KryptonLabel2.TabIndex = 44
        Me.KryptonLabel2.Values.Text = "Intitule"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 10)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel1.TabIndex = 43
        Me.KryptonLabel1.Values.Text = "Code"
        '
        'FormulaireService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 298)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FormulaireService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire des Services"
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
    Friend WithEvents btnDel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnaj As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnUP As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtdesig As System.Windows.Forms.TextBox
    Friend WithEvents txtintitule As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

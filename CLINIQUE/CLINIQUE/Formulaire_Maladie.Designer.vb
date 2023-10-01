<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulaire_Maladie
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
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtprix = New System.Windows.Forms.TextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtcodmaladie = New System.Windows.Forms.TextBox()
        Me.txtdesig = New System.Windows.Forms.TextBox()
        Me.txtfamilleMaladie = New System.Windows.Forms.TextBox()
        Me.txtsousfamille = New System.Windows.Forms.TextBox()
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
        Me.KryptonPanel.Size = New System.Drawing.Size(505, 410)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtprix)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtcodmaladie)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtdesig)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtfamilleMaladie)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtsousfamille)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(493, 135)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Gestion Maladie"
        Me.KryptonGroupBox1.Values.Heading = "Gestion Maladie"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(301, 8)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(30, 20)
        Me.KryptonLabel5.TabIndex = 23
        Me.KryptonLabel5.Values.Text = "Prix "
        '
        'txtprix
        '
        Me.txtprix.Location = New System.Drawing.Point(337, 8)
        Me.txtprix.Name = "txtprix"
        Me.txtprix.Size = New System.Drawing.Size(140, 20)
        Me.txtprix.TabIndex = 22
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(8, 86)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(76, 20)
        Me.KryptonLabel4.TabIndex = 21
        Me.KryptonLabel4.Values.Text = "Sous famille"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(8, 60)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(95, 20)
        Me.KryptonLabel3.TabIndex = 20
        Me.KryptonLabel3.Values.Text = "Famille maladie"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(8, 34)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(76, 20)
        Me.KryptonLabel2.TabIndex = 19
        Me.KryptonLabel2.Values.Text = "Designation"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(8, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(85, 20)
        Me.KryptonLabel1.TabIndex = 18
        Me.KryptonLabel1.Values.Text = "Code maladie"
        '
        'txtcodmaladie
        '
        Me.txtcodmaladie.Location = New System.Drawing.Point(106, 8)
        Me.txtcodmaladie.Name = "txtcodmaladie"
        Me.txtcodmaladie.Size = New System.Drawing.Size(100, 20)
        Me.txtcodmaladie.TabIndex = 14
        '
        'txtdesig
        '
        Me.txtdesig.Location = New System.Drawing.Point(106, 34)
        Me.txtdesig.Name = "txtdesig"
        Me.txtdesig.Size = New System.Drawing.Size(371, 20)
        Me.txtdesig.TabIndex = 15
        '
        'txtfamilleMaladie
        '
        Me.txtfamilleMaladie.Location = New System.Drawing.Point(106, 60)
        Me.txtfamilleMaladie.Name = "txtfamilleMaladie"
        Me.txtfamilleMaladie.Size = New System.Drawing.Size(371, 20)
        Me.txtfamilleMaladie.TabIndex = 16
        '
        'txtsousfamille
        '
        Me.txtsousfamille.Location = New System.Drawing.Point(106, 86)
        Me.txtsousfamille.Name = "txtsousfamille"
        Me.txtsousfamille.Size = New System.Drawing.Size(371, 20)
        Me.txtsousfamille.TabIndex = 17
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(371, 351)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnSup.Size = New System.Drawing.Size(90, 25)
        Me.btnSup.TabIndex = 23
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnFer
        '
        Me.btnFer.Location = New System.Drawing.Point(253, 351)
        Me.btnFer.Name = "btnFer"
        Me.btnFer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnFer.Size = New System.Drawing.Size(90, 25)
        Me.btnFer.TabIndex = 22
        Me.btnFer.Values.Text = "Fermer"
        '
        'btnEnr
        '
        Me.btnEnr.Location = New System.Drawing.Point(136, 351)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnEnr.Size = New System.Drawing.Size(90, 25)
        Me.btnEnr.TabIndex = 21
        Me.btnEnr.Values.Text = "Enregistre"
        '
        'btnMod
        '
        Me.btnMod.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3
        Me.btnMod.Location = New System.Drawing.Point(24, 351)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 20
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
        Me.DGV.Location = New System.Drawing.Point(3, 150)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(493, 195)
        Me.DGV.TabIndex = 19
        '
        'Formulaire_Maladie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 410)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "Formulaire_Maladie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire_Maladie"
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
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtcodmaladie As System.Windows.Forms.TextBox
    Friend WithEvents txtdesig As System.Windows.Forms.TextBox
    Friend WithEvents txtfamilleMaladie As System.Windows.Forms.TextBox
    Friend WithEvents txtsousfamille As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtprix As System.Windows.Forms.TextBox
End Class

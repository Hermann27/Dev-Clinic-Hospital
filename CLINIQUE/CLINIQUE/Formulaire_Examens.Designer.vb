<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulaire_Examens
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
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.CombtypeExam = New System.Windows.Forms.ComboBox()
        Me.txtprixExam = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Controls.Add(Me.btnSup)
        Me.KryptonPanel.Controls.Add(Me.btnFer)
        Me.KryptonPanel.Controls.Add(Me.btnEnr)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(473, 439)
        Me.KryptonPanel.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.Location = New System.Drawing.Point(6, 137)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(467, 302)
        Me.DGV.TabIndex = 35
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(319, 95)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnSup.Size = New System.Drawing.Size(88, 25)
        Me.btnSup.TabIndex = 34
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnFer
        '
        Me.btnFer.Location = New System.Drawing.Point(216, 95)
        Me.btnFer.Name = "btnFer"
        Me.btnFer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnFer.Size = New System.Drawing.Size(88, 25)
        Me.btnFer.TabIndex = 33
        Me.btnFer.Values.Text = "Fermer"
        '
        'btnEnr
        '
        Me.btnEnr.Location = New System.Drawing.Point(113, 95)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnEnr.Size = New System.Drawing.Size(88, 25)
        Me.btnEnr.TabIndex = 32
        Me.btnEnr.Values.Text = "Enregistre"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(10, 95)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnMod.Size = New System.Drawing.Size(88, 25)
        Me.btnMod.TabIndex = 31
        Me.btnMod.Values.Text = "Modifier"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.CombtypeExam)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtprixExam)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtcode)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(470, 86)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Lime
        Me.KryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Maroon
        Me.KryptonGroupBox1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Gestion des Examens "
        Me.KryptonGroupBox1.Values.Heading = "Gestion des Examens "
        '
        'CombtypeExam
        '
        Me.CombtypeExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombtypeExam.FormattingEnabled = True
        Me.CombtypeExam.Items.AddRange(New Object() {"PALUDISME", "FIBOSCROPIE", "VIH", "EPATITE", "CELL"})
        Me.CombtypeExam.Location = New System.Drawing.Point(299, 10)
        Me.CombtypeExam.Name = "CombtypeExam"
        Me.CombtypeExam.Size = New System.Drawing.Size(159, 21)
        Me.CombtypeExam.TabIndex = 35
        '
        'txtprixExam
        '
        Me.txtprixExam.Location = New System.Drawing.Point(93, 33)
        Me.txtprixExam.Name = "txtprixExam"
        Me.txtprixExam.Size = New System.Drawing.Size(100, 20)
        Me.txtprixExam.TabIndex = 34
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(93, 7)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 33
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(10, 33)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel3.TabIndex = 32
        Me.KryptonLabel3.Values.Text = "Prix Examens"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(211, 10)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(88, 20)
        Me.KryptonLabel2.TabIndex = 31
        Me.KryptonLabel2.Values.Text = "Type Examens"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(9, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel1.TabIndex = 30
        Me.KryptonLabel1.Values.Text = "Code"
        '
        'Formulaire_Examens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 439)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "Formulaire_Examens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire_Examens"
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
    Friend WithEvents CombtypeExam As System.Windows.Forms.ComboBox
    Friend WithEvents txtprixExam As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

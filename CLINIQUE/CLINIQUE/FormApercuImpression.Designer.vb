<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormApercuImpression
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.btn_rechercher = New System.Windows.Forms.Button()
        Me.lst_table = New System.Windows.Forms.ComboBox()
        Me.btn_couleur = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_ouvrir = New System.Windows.Forms.Button()
        Me.btn_imprimer = New System.Windows.Forms.Button()
        Me.btn_couper = New System.Windows.Forms.Button()
        Me.zone_texte = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IimprimenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiseEnPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApperçuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Panel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1153, 503)
        Me.KryptonPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1108, 484)
        Me.Panel1.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.txt_Search)
        Me.Panel6.Controls.Add(Me.btn_rechercher)
        Me.Panel6.Controls.Add(Me.lst_table)
        Me.Panel6.Controls.Add(Me.btn_couleur)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(198, 34)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(900, 40)
        Me.Panel6.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(441, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Search"
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(531, 10)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(170, 20)
        Me.txt_Search.TabIndex = 3
        '
        'btn_rechercher
        '
        Me.btn_rechercher.AllowDrop = True
        Me.btn_rechercher.AutoEllipsis = True
        Me.btn_rechercher.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rechercher.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_rechercher.Image = Global.CLINIQUE.My.Resources.Resources._45Search_New1
        Me.btn_rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rechercher.Location = New System.Drawing.Point(707, 5)
        Me.btn_rechercher.Name = "btn_rechercher"
        Me.btn_rechercher.Size = New System.Drawing.Size(44, 29)
        Me.btn_rechercher.TabIndex = 6
        Me.btn_rechercher.Tag = "Rechercher"
        Me.btn_rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_rechercher.UseVisualStyleBackColor = False
        '
        'lst_table
        '
        Me.lst_table.FormattingEnabled = True
        Me.lst_table.Items.AddRange(New Object() {"PATIENTS", "MEDECIN", "DOSSIERS MEDICALE", "RENDEZ-VOUS", "MEDICAMENTS", "STOCK MEDICAMENT"})
        Me.lst_table.Location = New System.Drawing.Point(86, 10)
        Me.lst_table.Name = "lst_table"
        Me.lst_table.Size = New System.Drawing.Size(160, 21)
        Me.lst_table.TabIndex = 14
        '
        'btn_couleur
        '
        Me.btn_couleur.AllowDrop = True
        Me.btn_couleur.AutoEllipsis = True
        Me.btn_couleur.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_couleur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_couleur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_couleur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_couleur.Image = Global.CLINIQUE.My.Resources.Resources.GrooveIcon
        Me.btn_couleur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_couleur.Location = New System.Drawing.Point(832, 5)
        Me.btn_couleur.Name = "btn_couleur"
        Me.btn_couleur.Size = New System.Drawing.Size(44, 29)
        Me.btn_couleur.TabIndex = 13
        Me.btn_couleur.Tag = "Couleur"
        Me.btn_couleur.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_couleur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "TABLE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CLINIQUE.My.Resources.Resources.Copy_of_system_search
        Me.PictureBox1.Location = New System.Drawing.Point(7, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(120, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(988, 4)
        Me.Panel3.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.zone_texte)
        Me.Panel2.Location = New System.Drawing.Point(3, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1105, 390)
        Me.Panel2.TabIndex = 1
        '
        'DGV
        '
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGV.Location = New System.Drawing.Point(114, 13)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(981, 223)
        Me.DGV.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_ouvrir)
        Me.Panel5.Controls.Add(Me.btn_imprimer)
        Me.Panel5.Controls.Add(Me.btn_couper)
        Me.Panel5.Location = New System.Drawing.Point(1, 13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(103, 170)
        Me.Panel5.TabIndex = 2
        '
        'btn_ouvrir
        '
        Me.btn_ouvrir.AllowDrop = True
        Me.btn_ouvrir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ouvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ouvrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ouvrir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ouvrir.Image = Global.CLINIQUE.My.Resources.Resources._19Help
        Me.btn_ouvrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ouvrir.Location = New System.Drawing.Point(29, 113)
        Me.btn_ouvrir.Name = "btn_ouvrir"
        Me.btn_ouvrir.Size = New System.Drawing.Size(52, 46)
        Me.btn_ouvrir.TabIndex = 2
        Me.btn_ouvrir.Tag = "Ouvrir"
        Me.btn_ouvrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ouvrir.UseVisualStyleBackColor = False
        '
        'btn_imprimer
        '
        Me.btn_imprimer.AllowDrop = True
        Me.btn_imprimer.AutoEllipsis = True
        Me.btn_imprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_imprimer.Image = Global.CLINIQUE.My.Resources.Resources._36Printer
        Me.btn_imprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimer.Location = New System.Drawing.Point(29, 61)
        Me.btn_imprimer.Name = "btn_imprimer"
        Me.btn_imprimer.Size = New System.Drawing.Size(52, 46)
        Me.btn_imprimer.TabIndex = 3
        Me.btn_imprimer.Tag = "Imprimer"
        Me.btn_imprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimer.UseVisualStyleBackColor = False
        '
        'btn_couper
        '
        Me.btn_couper.AllowDrop = True
        Me.btn_couper.AutoEllipsis = True
        Me.btn_couper.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_couper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_couper.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_couper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_couper.Image = Global.CLINIQUE.My.Resources.Resources.directx
        Me.btn_couper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_couper.Location = New System.Drawing.Point(29, 3)
        Me.btn_couper.Name = "btn_couper"
        Me.btn_couper.Size = New System.Drawing.Size(52, 46)
        Me.btn_couper.TabIndex = 3
        Me.btn_couper.Tag = "Couper"
        Me.btn_couper.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_couper.UseVisualStyleBackColor = False
        '
        'zone_texte
        '
        Me.zone_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zone_texte.Location = New System.Drawing.Point(112, 13)
        Me.zone_texte.Name = "zone_texte"
        Me.zone_texte.Size = New System.Drawing.Size(983, 468)
        Me.zone_texte.TabIndex = 0
        Me.zone_texte.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(116, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rapport"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpressionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1108, 29)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImpressionToolStripMenuItem
        '
        Me.ImpressionToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ImpressionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IimprimenteToolStripMenuItem, Me.MiseEnPageToolStripMenuItem, Me.ApperçuToolStripMenuItem, Me.ImprimerToolStripMenuItem})
        Me.ImpressionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpressionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ImpressionToolStripMenuItem.Name = "ImpressionToolStripMenuItem"
        Me.ImpressionToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.ImpressionToolStripMenuItem.Text = "Impréssion"
        '
        'IimprimenteToolStripMenuItem
        '
        Me.IimprimenteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IimprimenteToolStripMenuItem.Name = "IimprimenteToolStripMenuItem"
        Me.IimprimenteToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.IimprimenteToolStripMenuItem.Text = "Imprimante"
        '
        'MiseEnPageToolStripMenuItem
        '
        Me.MiseEnPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MiseEnPageToolStripMenuItem.Name = "MiseEnPageToolStripMenuItem"
        Me.MiseEnPageToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.MiseEnPageToolStripMenuItem.Text = "Mise en page"
        '
        'ApperçuToolStripMenuItem
        '
        Me.ApperçuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ApperçuToolStripMenuItem.Name = "ApperçuToolStripMenuItem"
        Me.ApperçuToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.ApperçuToolStripMenuItem.Text = "Apperçu"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.ImprimerToolStripMenuItem.Text = "Imprimer"
        '
        'FormApercuImpression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 503)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FormApercuImpression"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire d'Impression"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents btn_rechercher As System.Windows.Forms.Button
    Friend WithEvents lst_table As System.Windows.Forms.ComboBox
    Friend WithEvents btn_couleur As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents zone_texte As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImpressionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IimprimenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiseEnPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApperçuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btn_imprimer As System.Windows.Forms.Button
    Friend WithEvents btn_couper As System.Windows.Forms.Button
    Friend WithEvents btn_ouvrir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class

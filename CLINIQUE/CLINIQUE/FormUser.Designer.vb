<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.gruser = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.ch = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.groupbx = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.txtconf = New System.Windows.Forms.TextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Combopri = New System.Windows.Forms.ComboBox()
        Me.ComboPersonnel = New System.Windows.Forms.ComboBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btndel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnup = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btncl = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnaj = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruser.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruser.Panel.SuspendLayout()
        Me.gruser.SuspendLayout()
        CType(Me.groupbx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupbx.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbx.Panel.SuspendLayout()
        Me.groupbx.SuspendLayout()
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
        Me.KryptonPanel.Size = New System.Drawing.Size(700, 392)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.DGV)
        Me.KryptonPanel1.Controls.Add(Me.gruser)
        Me.KryptonPanel1.Controls.Add(Me.groupbx)
        Me.KryptonPanel1.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel1.Controls.Add(Me.btndel)
        Me.KryptonPanel1.Controls.Add(Me.btnup)
        Me.KryptonPanel1.Controls.Add(Me.btncl)
        Me.KryptonPanel1.Controls.Add(Me.btnaj)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(700, 392)
        Me.KryptonPanel1.TabIndex = 1
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 215)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(690, 158)
        Me.DGV.TabIndex = 24
        '
        'gruser
        '
        Me.gruser.Location = New System.Drawing.Point(12, 10)
        Me.gruser.Name = "gruser"
        '
        'gruser.Panel
        '
        Me.gruser.Panel.Controls.Add(Me.ch)
        Me.gruser.Size = New System.Drawing.Size(212, 62)
        Me.gruser.TabIndex = 22
        Me.gruser.Text = "Recherche utilisateur"
        Me.gruser.Values.Heading = "Recherche utilisateur"
        '
        'ch
        '
        Me.ch.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.ch.Location = New System.Drawing.Point(3, 8)
        Me.ch.Name = "ch"
        Me.ch.Size = New System.Drawing.Size(203, 20)
        Me.ch.TabIndex = 3
        Me.ch.Text = "Mode de recherche est dèsactivé"
        Me.ch.Values.Text = "Mode de recherche est dèsactivé"
        '
        'groupbx
        '
        Me.groupbx.Location = New System.Drawing.Point(361, 14)
        Me.groupbx.Name = "groupbx"
        '
        'groupbx.Panel
        '
        Me.groupbx.Panel.Controls.Add(Me.txtsearch)
        Me.groupbx.Panel.Controls.Add(Me.KryptonLabel6)
        Me.groupbx.Size = New System.Drawing.Size(246, 58)
        Me.groupbx.TabIndex = 21
        Me.groupbx.Text = "Recherche"
        Me.groupbx.Values.Heading = "Recherche"
        Me.groupbx.Visible = False
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(64, 7)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(175, 20)
        Me.txtsearch.TabIndex = 3
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(3, 7)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel6.TabIndex = 2
        Me.KryptonLabel6.Values.Text = "Utilisateur :"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 91)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtconf)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.Combopri)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.ComboPersonnel)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtpass)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtlogin)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(604, 118)
        Me.KryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KryptonGroupBox1.TabIndex = 20
        Me.KryptonGroupBox1.Text = "Ajouter Utilisateur"
        Me.KryptonGroupBox1.Values.Heading = "Ajouter Utilisateur"
        '
        'txtconf
        '
        Me.txtconf.Location = New System.Drawing.Point(115, 61)
        Me.txtconf.Name = "txtconf"
        Me.txtconf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtconf.Size = New System.Drawing.Size(125, 20)
        Me.txtconf.TabIndex = 20
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(4, 61)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(115, 20)
        Me.KryptonLabel5.TabIndex = 19
        Me.KryptonLabel5.Values.Text = "Confirme Password"
        '
        'Combopri
        '
        Me.Combopri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combopri.FormattingEnabled = True
        Me.Combopri.Items.AddRange(New Object() {"ADMIN", "User"})
        Me.Combopri.Location = New System.Drawing.Point(437, 9)
        Me.Combopri.Name = "Combopri"
        Me.Combopri.Size = New System.Drawing.Size(147, 21)
        Me.Combopri.TabIndex = 18
        '
        'ComboPersonnel
        '
        Me.ComboPersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPersonnel.FormattingEnabled = True
        Me.ComboPersonnel.Location = New System.Drawing.Point(437, 36)
        Me.ComboPersonnel.Name = "ComboPersonnel"
        Me.ComboPersonnel.Size = New System.Drawing.Size(147, 21)
        Me.ComboPersonnel.TabIndex = 17
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(115, 35)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtpass.Size = New System.Drawing.Size(125, 20)
        Me.txtpass.TabIndex = 16
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(115, 7)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(125, 20)
        Me.txtlogin.TabIndex = 15
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(345, 37)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel4.TabIndex = 14
        Me.KryptonLabel4.Values.Text = "Personnel "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(345, 11)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel3.TabIndex = 13
        Me.KryptonLabel3.Values.Text = "Privilége"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 34)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(62, 20)
        Me.KryptonLabel2.TabIndex = 12
        Me.KryptonLabel2.Values.Text = "Password"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 7)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel1.TabIndex = 11
        Me.KryptonLabel1.Values.Text = "Login"
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(617, 175)
        Me.btndel.Name = "btndel"
        Me.btndel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btndel.Size = New System.Drawing.Size(76, 32)
        Me.btndel.TabIndex = 19
        Me.btndel.Values.Text = "Supprimer"
        '
        'btnup
        '
        Me.btnup.Location = New System.Drawing.Point(617, 13)
        Me.btnup.Name = "btnup"
        Me.btnup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnup.Size = New System.Drawing.Size(76, 32)
        Me.btnup.TabIndex = 18
        Me.btnup.Values.Text = "Modifier"
        '
        'btncl
        '
        Me.btncl.Location = New System.Drawing.Point(617, 121)
        Me.btncl.Name = "btncl"
        Me.btncl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btncl.Size = New System.Drawing.Size(76, 32)
        Me.btncl.TabIndex = 17
        Me.btncl.Values.Text = "Fermer"
        '
        'btnaj
        '
        Me.btnaj.Location = New System.Drawing.Point(617, 67)
        Me.btnaj.Name = "btnaj"
        Me.btnaj.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange
        Me.btnaj.Size = New System.Drawing.Size(76, 32)
        Me.btnaj.TabIndex = 16
        Me.btnaj.Values.Text = "Enregistre"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 392)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUser"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruser.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruser.Panel.ResumeLayout(False)
        Me.gruser.Panel.PerformLayout()
        CType(Me.gruser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruser.ResumeLayout(False)
        CType(Me.groupbx.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbx.Panel.ResumeLayout(False)
        Me.groupbx.Panel.PerformLayout()
        CType(Me.groupbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbx.ResumeLayout(False)
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
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents gruser As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents ch As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents groupbx As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents txtconf As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Combopri As System.Windows.Forms.ComboBox
    Friend WithEvents ComboPersonnel As System.Windows.Forms.ComboBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btndel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btncl As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnaj As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class

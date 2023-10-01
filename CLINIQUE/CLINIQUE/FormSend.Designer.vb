<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSend
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
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.txtexp = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtobjet = New System.Windows.Forms.TextBox()
        Me.btnSend = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnAnnuler = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnOpen = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtsms = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtpiecesjointes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtdes)
        Me.KryptonPanel.Controls.Add(Me.txtexp)
        Me.KryptonPanel.Controls.Add(Me.txtpass)
        Me.KryptonPanel.Controls.Add(Me.txtobjet)
        Me.KryptonPanel.Controls.Add(Me.btnSend)
        Me.KryptonPanel.Controls.Add(Me.btnAnnuler)
        Me.KryptonPanel.Controls.Add(Me.btnOpen)
        Me.KryptonPanel.Controls.Add(Me.txtsms)
        Me.KryptonPanel.Controls.Add(Me.txtpiecesjointes)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(622, 266)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtdes
        '
        Me.txtdes.BackColor = System.Drawing.Color.Pink
        Me.txtdes.Location = New System.Drawing.Point(71, 48)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(264, 20)
        Me.txtdes.TabIndex = 33
        '
        'txtexp
        '
        Me.txtexp.BackColor = System.Drawing.Color.Pink
        Me.txtexp.Location = New System.Drawing.Point(71, 22)
        Me.txtexp.Name = "txtexp"
        Me.txtexp.Size = New System.Drawing.Size(264, 20)
        Me.txtexp.TabIndex = 32
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Pink
        Me.txtpass.Location = New System.Drawing.Point(419, 21)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtpass.Size = New System.Drawing.Size(190, 20)
        Me.txtpass.TabIndex = 31
        '
        'txtobjet
        '
        Me.txtobjet.BackColor = System.Drawing.Color.Pink
        Me.txtobjet.Location = New System.Drawing.Point(70, 78)
        Me.txtobjet.Name = "txtobjet"
        Me.txtobjet.Size = New System.Drawing.Size(264, 20)
        Me.txtobjet.TabIndex = 30
        '
        'btnSend
        '
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Location = New System.Drawing.Point(382, 220)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnSend.Size = New System.Drawing.Size(90, 25)
        Me.btnSend.TabIndex = 29
        Me.btnSend.Values.Text = "Envoyer"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnuler.Location = New System.Drawing.Point(172, 220)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btnAnnuler.Size = New System.Drawing.Size(90, 25)
        Me.btnAnnuler.TabIndex = 28
        Me.btnAnnuler.Values.Text = "Annuler"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(587, 47)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(20, 21)
        Me.btnOpen.TabIndex = 27
        Me.btnOpen.Values.Text = "...."
        '
        'txtsms
        '
        Me.txtsms.Location = New System.Drawing.Point(9, 123)
        Me.txtsms.Multiline = True
        Me.txtsms.Name = "txtsms"
        Me.txtsms.Size = New System.Drawing.Size(606, 85)
        Me.txtsms.TabIndex = 26
        '
        'txtpiecesjointes
        '
        Me.txtpiecesjointes.Location = New System.Drawing.Point(419, 48)
        Me.txtpiecesjointes.Name = "txtpiecesjointes"
        Me.txtpiecesjointes.Size = New System.Drawing.Size(167, 20)
        Me.txtpiecesjointes.TabIndex = 25
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(7, 101)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(59, 20)
        Me.KryptonLabel6.TabIndex = 24
        Me.KryptonLabel6.Values.Text = "Message"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(340, 48)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(85, 20)
        Me.KryptonLabel5.TabIndex = 23
        Me.KryptonLabel5.Values.Text = "Pièces Jointes"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(10, 78)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel4.TabIndex = 22
        Me.KryptonLabel4.Values.Text = "Objet"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(9, 52)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(63, 20)
        Me.KryptonLabel3.TabIndex = 21
        Me.KryptonLabel3.Values.Text = "Email Des"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(340, 22)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(85, 20)
        Me.KryptonLabel2.TabIndex = 20
        Me.KryptonLabel2.Values.Text = "Password Exp"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 22)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(62, 20)
        Me.KryptonLabel1.TabIndex = 19
        Me.KryptonLabel1.Values.Text = "Email Exp"
        '
        'FormSend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 266)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FormSend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSend"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents txtexp As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtobjet As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAnnuler As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOpen As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtsms As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtpiecesjointes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

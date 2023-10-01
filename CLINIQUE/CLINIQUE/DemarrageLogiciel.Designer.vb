<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemarrageLogiciel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemarrageLogiciel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.image = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lbldecte = New System.Windows.Forms.Label()
        Me.lblchagre = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblef = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(6, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 90)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Version {1.0.1}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date  :20/09/2013" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact : 99-76-99-82" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Developpeur :Djoumdjeu" & _
            " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Etudiant a IUC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Filiere TI-PA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'image
        '
        Me.image.BackColor = System.Drawing.Color.Transparent
        Me.image.Location = New System.Drawing.Point(212, 1)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(170, 110)
        Me.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image.TabIndex = 1
        Me.image.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 90)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(209, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3500
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 25
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'lbldecte
        '
        Me.lbldecte.AutoSize = True
        Me.lbldecte.BackColor = System.Drawing.Color.Transparent
        Me.lbldecte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldecte.ForeColor = System.Drawing.Color.Yellow
        Me.lbldecte.Location = New System.Drawing.Point(12, 121)
        Me.lbldecte.Name = "lbldecte"
        Me.lbldecte.Size = New System.Drawing.Size(0, 13)
        Me.lbldecte.TabIndex = 6
        '
        'lblchagre
        '
        Me.lblchagre.AutoSize = True
        Me.lblchagre.BackColor = System.Drawing.Color.Transparent
        Me.lblchagre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchagre.ForeColor = System.Drawing.Color.DarkOrchid
        Me.lblchagre.Location = New System.Drawing.Point(12, 153)
        Me.lblchagre.Name = "lblchagre"
        Me.lblchagre.Size = New System.Drawing.Size(0, 13)
        Me.lblchagre.TabIndex = 7
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Black
        Me.lbl.Location = New System.Drawing.Point(158, 137)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 13)
        Me.lbl.TabIndex = 5
        '
        'lblef
        '
        Me.lblef.AutoSize = True
        Me.lblef.BackColor = System.Drawing.Color.Transparent
        Me.lblef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblef.ForeColor = System.Drawing.Color.DarkOrchid
        Me.lblef.Location = New System.Drawing.Point(12, 138)
        Me.lblef.Name = "lblef"
        Me.lblef.Size = New System.Drawing.Size(0, 13)
        Me.lblef.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(171, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "LOGICIEL DE GESTION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " DE LA CLINIQUE DE GAULLE"
        '
        'DemarrageLogiciel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(381, 279)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblef)
        Me.Controls.Add(Me.lblchagre)
        Me.Controls.Add(Me.lbldecte)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DemarrageLogiciel"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents image As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lbldecte As System.Windows.Forms.Label
    Friend WithEvents lblchagre As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents lblef As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

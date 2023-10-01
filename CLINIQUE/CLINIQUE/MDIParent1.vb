Imports System.Windows.Forms

Public Class MDIParent1

    'Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim SaveFileDialog As New SaveFileDialog
    '    SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

    '    If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = SaveFileDialog.FileName
    '        ' TODO: Add code here to save the current contents of the form to a file.
    '    End If
    'End Sub

    Dim CrystalReport2 As Object


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


   

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        With Authentification
            .MdiParent = Me
            .Show()
        End With
        With cboListePolices
            .Items.Add("arial")
            .Items.Add("Verdana")
            .Items.Add("algerion")
            .Items.Add("Courrier new")
        End With
        With lblmessage
            .Font = New Font(cboListePolices.Text, 36)
        End With
        With lblmessage
            .Font = New Font("Courrier new", lblmessage.Font.Size, FontStyle.Italic)
        End With
        chkDefilement_CheckedChanged(sender, e)
        trkvitesse.Enabled = False
    End Sub
    Private Sub chkDefilement_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefilement.CheckedChanged
        Timer2.Enabled = chkDefilement.Checked
        Timer2.Interval = 50 - trkvitesse.Value
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decon.Click
        user.Text = ""
        decon.Visible = False
        btndecon.Visible = False
        btdossim.Enabled = False
        bthosp.Enabled = False
        btncons.Enabled = False
        btnimp.Enabled = False
        btnm.Enabled = False
        btnr.Enabled = False
        btpa.Enabled = False
        tpat.Enabled = False
        med.Enabled = False
        dossier.Enabled = False
        cons.Enabled = False
        hosp.Enabled = False
        imp.Enabled = False
        rech.Enabled = False
        FileMenu.Enabled = False
        EditMenu.Enabled = False
        GesMenu.Enabled = False
        RapMenu.Enabled = False
        With Authentification
            .MdiParent = Me
            .Show()
        End With

        ' Me.Close()
    End Sub

    Private Sub tpat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpat.Click
        With FormulairePatient
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ToolStripLabel1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cons.Click
        With FormulaireConsultation
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub nmutre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmutre.Click
        With Formulaire_DossiersMedical
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        With FormulairePatient
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GestionDesRendezVousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesRendezVousToolStripMenuItem.Click
        With FormulaireRDV
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GestionDepotMedicamentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDepotMedicamentToolStripMenuItem.Click
        With Formulaire_priseCharge
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GestionDesChambresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesChambresToolStripMenuItem.Click
        With FormulaireChambre
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GestionDesMaladieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesMaladieToolStripMenuItem.Click
        With Formulaire_Maladie
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GestionDesTraitementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesTraitementsToolStripMenuItem.Click
        With Formulaire_Traitement
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GestionDesExamensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesExamensToolStripMenuItem.Click
        With Formulaire_Examens
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GestionDesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesToolStripMenuItem.Click
        With Formulair_Laboratoire
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub nmConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GestionPersonnelSoignantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionPersonnelSoignantToolStripMenuItem.Click
        With FormulaireUtilisateur
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblheure.Text = Now.ToLongTimeString
    End Sub

    Private Sub DossierDuPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DossierDuPatientToolStripMenuItem.Click
        With Formulaire_DossiersMedical
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GestionDepotMedicamentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDepotMedicamentToolStripMenuItem1.Click
        With Formulaire_Clinique
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceToolStripMenuItem.Click
        With FormulaireService
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub UtilisateursToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilisateursToolStripMenuItem.Click
        With FormUser
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub rech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rech.Click
        With FormSend
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub hosp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hosp.Click
        With Formulaire_Hospitalisation
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If lblmessage.Left < panSupport.Width Then
            lblmessage.Left += 5
        Else
            lblmessage.Left = -lblmessage.Width
        End If
    End Sub

    Private Sub ToolStripStatusLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel.Click
        'Me.FlowLayoutPanel1.Visible = Me.ToolBarToolStripMenuItem.Checked
        If Me.FlowLayoutPanel1.Visible = True Then
            Me.FlowLayoutPanel1.Visible = False
        Else
            Me.FlowLayoutPanel1.Visible = True
        End If
    End Sub

    Private Sub imp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp.Click
        With FormApercuImpression
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("WELCOME TO SOFT TECH")
    End Sub

    Private Sub med_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles med.Click
        With FormulaireMedicament
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub dossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dossier.Click
        With Formulaire_DossiersMedical
            .MdiParent = Me
            .Show()
        End With
    End Sub
End Class

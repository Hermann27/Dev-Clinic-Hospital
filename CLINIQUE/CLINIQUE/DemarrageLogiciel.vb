Public Class DemarrageLogiciel

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'lbldecte.ForeColor = Color.White
        'lbl.ForeColor = Color.White
        'lbl.ForeColor = Color.Yellow
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
        If ProgressBar1.Value > 10 And ProgressBar1.Value < 20 Then
            lbldecte.Text = "Detection des Parametres De Connexion"
            lblef.Text = "Chargement en cours "
            image.ImageLocation = "photo\1.gif"
        End If
        If ProgressBar1.Value > 20 And ProgressBar1.Value < 50 Then
            lbldecte.Text = ""
            image.ImageLocation = "photo\1.gif"
        End If
        If ProgressBar1.Value > 40 And ProgressBar1.Value < 70 Then

            lbldecte.Text = "Mise a Jour des Fichiers"
            image.ImageLocation = "photo\1.gif"
        End If
        If ProgressBar1.Value > 70 And ProgressBar1.Value < 90 Then
            lbldecte.Text = "Connexion à la Base Access"
            image.ImageLocation = "photo\3.gif"
            image.Visible = False
        End If
        If ProgressBar1.Value > 90 And ProgressBar1.Value <= 100 Then
            image.Visible = True
            lblchagre.Text = "Chargement des fichiers de Connexion ..."
            image.ImageLocation = "photo\3.jpg"

        End If
        If ProgressBar1.Value = 100 Then
            Timer2.Enabled = False
            Timer3.Enabled = False
        End If
        lbl.Text = ProgressBar1.Value & " %"
        If ProgressBar1.Value = 100 Then
            lblef.Text = "Chargement des parametre effectue avec success "
            lbl.Text = ""
            lblchagre.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim RepAccess As Object
        If ProgressBar1.Value = 100 Then
            ' je dois verifier la connexion ici
            If 1 = 1 Then
                With MDIParent1
                    .btndecon.Visible = False
                    .decon.Visible = False
                    .btdossim.Enabled = False
                    .bthosp.Enabled = False
                    .btncons.Enabled = False
                    .btnimp.Enabled = False
                    .btnm.Enabled = False
                    .btnr.Enabled = False
                    .btpa.Enabled = False
                    .tpat.Enabled = False
                    .med.Enabled = False
                    .dossier.Enabled = False
                    .cons.Enabled = False
                    .hosp.Enabled = False
                    .imp.Enabled = False
                    .rech.Enabled = False
                    .FileMenu.Enabled = False
                    .EditMenu.Enabled = False
                    .GesMenu.Enabled = False
                    .RapMenu.Enabled = False
                    .Show()
                End With
                Me.Close()
            Else
                Timer2.Enabled = False
                Timer3.Enabled = False
                Timer1.Enabled = False
                RepAccess = MsgBox("Erreur d'ouverture de la base Microsoft Access  " & Chr(13) & "" & Chr(13) & "Modifiez Le Fichier de Configuration", MsgBoxStyle.YesNo, "Connexion à la base Microsoft Access")
                If MsgBoxResult.Yes = RepAccess Then
                    ' LoginForm.Show()
                    ' Me.Close()
                Else
                    End
                End If
            End If
        End If
       
    End Sub

    
End Class

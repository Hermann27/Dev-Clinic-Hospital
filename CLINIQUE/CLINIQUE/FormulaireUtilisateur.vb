Public Class FormulaireUtilisateur
    Dim DC As New DCDataContext
    Private Sub Ch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch.CheckedChanged
        If Ch.Checked = True Then
            groupbx.Visible = True
        Else
            groupbx.Visible = False
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim result As New DialogResult
        result = OpenFileDialog1.ShowDialog
        If result = Windows.Forms.DialogResult.Cancel Then
            MsgBox("veillez selectionner une image svp:)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL")
        Else
            txt_url_portrait.Text = "Photo\" & IO.Path.GetFileName(OpenFileDialog1.FileName)
            FileCopy(OpenFileDialog1.FileName, My.Application.Info.DirectoryPath & "\Photo\" & IO.Path.GetFileName(OpenFileDialog1.FileName))
            img_portrait.ImageLocation = txt_url_portrait.Text
        End If
    End Sub

    Private Sub FormulaireUtilisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Query = From elt In DC.SERVICEs _
                   Select elt.INTITULE
        cmbser.DataSource = Query.ToList
        Affiche()
    End Sub

    Public Sub Affiche()
        Dim query2 = From elt In DC.PERSONNEL_SOIGNANTs Select New With {.CODE = elt.CODE_PERS.Trim, _
                                                                         .SERVICE = elt.SERVICE.INTITULE.Trim, _
                                                                         .NOM = elt.NOM_PERS.Trim, _
                                                                         .PRENOM = elt.PRENOM_PERS.Trim, _
                                                                         .EMAIL = elt.EMAIL.Trim, _
                                                                         .CIN = elt.CIN.Trim, _
                                                                         .GRADE = elt.GRADE_PERS.Trim, _
                                                                         .FONCTION = elt.FONCT.Trim, _
                                                                         .ADRESSE = elt.ADRESSE.Trim, _
                                                                         .DATE = elt.DATE_RECRUCT, _
                                                                         .SEXE = elt.SEXE.Trim, _
                                                                         .TELEPHONE = elt.TELEPHONE, _
                                                                         .PHOTO = elt.PHOTO _
                                                                        }
        DGV.DataSource = query2.ToList
    End Sub
    Dim valeurCodeP As String = ""
    Private Sub cmbser_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbser.SelectedValueChanged
        Dim Query2 = From elt2 In DC.SERVICEs _
                        Where elt2.INTITULE = cmbser.SelectedItem.ToString _
                        Select elt2
        valeurCodeP = Query2.First.CODE_SERV
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtmatricule.Text = "" And txtnom.Text = "" And txtphone.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL")
        Else
            Try

                Dim personnel As New PERSONNEL_SOIGNANT() With {.CODE_PERS = txtmatricule.Text, _
                                                                .CODE_SERV = valeurCodeP, _
                                                                .NOM_PERS = txtnom.Text, _
                                                                .PRENOM_PERS = txtprenom.Text, _
                                                                .EMAIL = txtemail.Text, _
                                                                .CIN = txtcin.Text, _
                                                                .PHOTO = txt_url_portrait.Text, _
                                                                .GRADE_PERS = txtgrade.Text, _
                                                                .FONCT = txtfonc.Text, _
                                                                .ADRESSE = txtadress.Text, _
                                                                .DATE_RECRUCT = datpic.Value, _
                                                                .SEXE = IIf(chM.Checked = True, chM.Text.ToString, chF.Text.ToString), _
                                                                .TELEPHONE = txtphone.Text}
                DC.PERSONNEL_SOIGNANTs.InsertOnSubmit(personnel)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL")
                Affiche()

            Catch ex As Exception

                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL")
            End Try

        End If
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        If txtmatricule.Text = "" And txtnom.Text = "" And txtphone.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL ")
        Else
            Try
                Dim P = (From Pers In DC.PERSONNEL_SOIGNANTs Select Pers Where Pers.CODE_PERS = txtmatricule.Text).Single()
                P.CODE_SERV = valeurCodeP
                P.NOM_PERS = txtnom.Text
                P.PRENOM_PERS = txtprenom.Text
                P.EMAIL = txtemail.Text
                P.CIN = txtcin.Text
                P.PHOTO = txt_url_portrait.Text
                P.GRADE_PERS = txtgrade.Text
                P.FONCT = txtfonc.Text
                P.ADRESSE = txtadress.Text
                P.DATE_RECRUCT = datpic.Value
                P.SEXE = IIf(chM.Checked = True, chM.Text.ToString, chF.Text.ToString)
                P.TELEPHONE = txtphone.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL")
                Affiche()

            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "IINFOS SUR LE PERSONNEL")
            End Try

        End If
    End Sub


    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtmatricule.Enabled = False
            btnSave.Enabled = False
            txtmatricule.Text = DGV.SelectedRows(0).Cells(0).Value
            cmbser.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            txtnom.Text = DGV.SelectedRows(0).Cells(2).Value
            txtprenom.Text = DGV.SelectedRows(0).Cells(3).Value
            txtemail.Text = DGV.SelectedRows(0).Cells(4).Value
            txtcin.Text = DGV.SelectedRows(0).Cells(5).Value
            txtgrade.Text = DGV.SelectedRows(0).Cells(6).Value
            txtfonc.Text = DGV.SelectedRows(0).Cells(7).Value
            txtadress.Text = DGV.SelectedRows(0).Cells(8).Value
            datpic.Value = DGV.SelectedRows(0).Cells(9).Value
            If DGV.SelectedRows(0).Cells(10).Value = "Masculin" Then
                chM.Checked = True
            Else
                chF.Checked = True
            End If
            txtphone.Text = DGV.SelectedRows(0).Cells(11).Value
            img_portrait.ImageLocation = DGV.SelectedRows(0).Cells(12).Value
            txt_url_portrait.Text = DGV.SelectedRows(0).Cells(12).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        txtmatricule.Enabled = True
        btnSave.Enabled = True
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtmatricule.Text = "" And txtnom.Text = "" And txtphone.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL")
        Else
            Try
                Dim ser = (From serv In DC.PERSONNEL_SOIGNANTs Select serv Where serv.CODE_PERS = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.PERSONNEL_SOIGNANTs.DeleteOnSubmit(ser)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL")
                Affiche()

            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS SUR LE PERSONNEL")
            End Try

        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim r = From ee In DC.PERSONNEL_SOIGNANTs Where ee.CODE_PERS.Contains(txtsearch.Text) Or ee.NOM_PERS.Contains(txtsearch.Text) Or ee.GRADE_PERS.Contains(txtsearch.Text) Select New With {.CODE = ee.CODE_PERS.Trim, _
                                                                                                                                                                                                 .SERVICE = ee.SERVICE.INTITULE.Trim, _
                                                                                                                                                                                                 .NOM = ee.NOM_PERS.Trim, _
                                                                                                                                                                                                 .PRENOM = ee.PRENOM_PERS.Trim, _
                                                                                                                                                                                                 .EMAIL = ee.EMAIL.Trim, _
                                                                                                                                                                                                 .CIN = ee.CIN.Trim, _
                                                                                                                                                                                                 .GRADE = ee.GRADE_PERS.Trim, _
                                                                                                                                                                                                 .FONCTION = ee.FONCT.Trim, _
                                                                                                                                                                                                 .ADRESSE = ee.ADRESSE.Trim, _
                                                                                                                                                                                                 .DATE = ee.DATE_RECRUCT, _
                                                                                                                                                                                                 .SEXE = ee.SEXE.Trim, _
                                                                                                                                                                                                 .TELEPHONE = ee.TELEPHONE, _
                                                                                                                                                                                                 .PHOTO = ee.PHOTO _
                                                                                                                                                                                                }
        DGV.DataSource = r.ToList
    End Sub

    Private Sub btnActualise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualise.Click
        txtmatricule.Text = ""
        cmbser.SelectedItem = ""
        txtnom.Text = ""
        txtprenom.Text = ""
        txtemail.Text = ""
        txtcin.Text = ""
        txtgrade.Text = ""
        txtfonc.Text = ""
        txtadress.Text = ""
        chM.Checked = False
        chF.Checked = False
        txtphone.Text = ""
        img_portrait.ImageLocation = ""
        txt_url_portrait.Text = ""
    End Sub

End Class

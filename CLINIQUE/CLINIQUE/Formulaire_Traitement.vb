Public Class Formulaire_Traitement
    Dim DC As New DCDataContext
    Dim ValeurCodeDM As Integer
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtcode.Text = "" And txtEtatPat.Text = "" And txtobser.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
        Else
            Try
                Dim serv = (From ser In DC.TRAITEMENTs Select ser Where ser.ID = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                serv.NUMERO_DOSSIER = ValeurCodeDM
                serv.CODE_MAL = CombCodeMal.SelectedItem.ToString
                serv.OBSERVATION = txtobser.Text
                serv.DATE_DEBUT = dateDebutTraitement.Value
                serv.DATE_FIN = dateFinTraitement.Value
                serv.ETAT_FIN = txtEtatPat.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi  :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
                Affiche()
            Catch ex As Exception
                MsgBox("Modification Erroner :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
            End Try
        End If
    End Sub

    Public Sub Affiche()
        Dim r = From ee In DC.TRAITEMENTs Select New With {.IDENTIFIANT = ee.ID, _
                                                           .REFERENCE_DOSSIER_MEDICAL = ee.DOSSIER_MEDICALE.NUMEROREF.Trim, _
                                                           .CODE_MALADIE = ee.CODE_MAL, _
                                                           .DATE_DEBUT = ee.DATE_DEBUT, _
                                                           .DATE_FIN = ee.DATE_FIN, _
                                                           .ETAT_FIN = ee.ETAT_FIN, _
                                                           .OBSERVATION = ee.OBSERVATION _
                                                         }
        DGV.DataSource = r.ToList
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            txtcode.Enabled = False
            txtcode.Text = DGV.SelectedRows(0).Cells(2).Value
            CombCodeMal.SelectedItem = DGV.SelectedRows(0).Cells(2).Value
            CombDoc.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            txtEtatPat.Text = DGV.SelectedRows(0).Cells(5).Value
            txtobser.Text = DGV.SelectedRows(0).Cells(6).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnEnr.Enabled = True
        txtcode.Enabled = True
    End Sub
    Private Sub Formulaire_Traitement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VISITE CHARGEMENT COMBOBOX ---------------------
        Dim QueryDM = From elt In DC.DOSSIER_MEDICALEs _
                   Select elt.NUMEROREF
        CombDoc.DataSource = QueryDM.ToList

        Dim QueryE = From elt In DC.MALADIEs _
                  Select elt.CODE_MAL Distinct
        CombCodeMal.DataSource = QueryE.ToList
        Affiche()
    End Sub

    Private Sub CombDoc_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombDoc.SelectedValueChanged
        Dim Query2 = From elt In DC.DOSSIER_MEDICALEs _
                      Where elt.NUMEROREF = CombDoc.SelectedItem.ToString _
                      Select elt
        ValeurCodeDM = Query2.First.NUMERO_DOSSIER
    End Sub

    Private Sub btnFer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFer.Click
        Me.Close()
    End Sub

    Private Sub btnEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnr.Click
        If txtcode.Text = "" And txtEtatPat.Text = "" And txtobser.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
        Else
            Try

                Dim Soc As New TRAITEMENT() With {.CODE_MAL = CombCodeMal.SelectedItem.ToString, _
                                                  .NUMERO_DOSSIER = ValeurCodeDM, _
                                                  .DATE_DEBUT = dateDebutTraitement.Value, _
                                                  .DATE_FIN = dateFinTraitement.Value, _
                                                  .ETAT_FIN = txtEtatPat.Text, _
                                                  .OBSERVATION = txtobser.Text _
                                                 }
                DC.TRAITEMENTs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi  :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
                Affiche()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
            End Try
        End If
    End Sub
    
    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If txtcode.Text = "" And txtEtatPat.Text = "" And txtobser.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
        Else
            Try
                Dim soc = (From serv In DC.TRAITEMENTs Select serv Where serv.ID = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                DC.TRAITEMENTs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi  :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
                Affiche()
            Catch ex As Exception
                MsgBox("Suppression Erroner :)", MsgBoxStyle.Information, "INFOS TRAITEMENT")
            End Try

        End If
    End Sub
End Class

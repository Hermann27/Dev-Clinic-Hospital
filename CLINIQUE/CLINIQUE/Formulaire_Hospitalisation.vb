Public Class Formulaire_Hospitalisation
    Dim DC As New DCDataContext
    Dim ValeurCodeDM As Integer
    Dim ValeurCodeE As String
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtcode.Text = "" And CombcodCham.SelectedItem = "" And CombdossPat.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
        Else
            Try
                Dim serv = (From ser In DC.HOSPITALISERs Select ser Where ser.NUMERO_DOSSIER = ValeurCodeDM).Single()
                serv.DATE_ARRIVE = dateArriveeHosp.Value
                serv.DATE_SORTIE = dateSortieHosp.Value
                serv.CODE_CH = CombcodCham.SelectedItem.ToString
                serv.OBSERVATION = txtobser.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
                Affiche()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
            End Try
        End If
    End Sub
    Public Sub Affiche()
        Dim r = From ee In DC.HOSPITALISERs Select New With {.CODE_CHAMBRE = ee.CODE_CH.Trim, _
                                                             .REF_DOSSIERS_PATIENT = ee.DOSSIER_MEDICALE.NUMEROREF.Trim, _
                                                             .DATE_ENTRE = ee.DATE_ARRIVE, _
                                                             .DATE_SORTIE = ee.DATE_SORTIE, _
                                                             .OBSERVATION = ee.OBSERVATION _
                                                            }
        DGV.DataSource = r.ToList
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            txtcode.Enabled = False
            txtcode.Text = "CLGH00" & ValeurCodeDM
            CombcodCham.SelectedItem = DGV.SelectedRows(0).Cells(0).Value
            CombdossPat.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            txtobser.Text = DGV.SelectedRows(0).Cells(4).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnEnr.Enabled = True
        ' txtcode.Enabled = True
    End Sub
    Private Sub Formulaire_Hospitalisation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------DOSSIER MEDICAL ET CHAMBRE CHARGEMENT COMBOBOX ---------------------
        Dim QueryDM = From elt In DC.DOSSIER_MEDICALEs _
                   Select elt.NUMEROREF
        CombdossPat.DataSource = QueryDM.ToList

        Dim QueryE = From elt In DC.CHAMBREs _
                  Select elt.CODE_CH Distinct
        CombcodCham.DataSource = QueryE.ToList
        Affiche()
    End Sub

    Private Sub CombdossPat_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombdossPat.SelectedValueChanged
        Dim Query2 = From elt In DC.DOSSIER_MEDICALEs _
                  Where elt.NUMEROREF = CombdossPat.SelectedItem.ToString _
                  Select elt
        ValeurCodeDM = Query2.First.NUMERO_DOSSIER
    End Sub

    Private Sub btnEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnr.Click
        If txtcode.Text = "" And CombcodCham.SelectedItem = "" And CombdossPat.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
        Else
            Try

                Dim Soc As New HOSPITALISER() With {.CODE_CH = CombcodCham.SelectedItem.ToString, _
                                                    .NUMERO_DOSSIER = ValeurCodeDM, _
                                                    .DATE_ARRIVE = dateArriveeHosp.Value, _
                                                    .DATE_SORTIE = dateSortieHosp.Value, _
                                                    .OBSERVATION = txtobser.Text _
                                                  }
                DC.HOSPITALISERs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
                Affiche()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
            End Try

        End If
    End Sub

    Private Sub btnFer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFer.Click
        Me.Close()
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If txtcode.Text = "" And CombcodCham.SelectedItem = "" And CombdossPat.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
        Else
            Try
                Dim soc = (From serv In DC.HOSPITALISERs Select serv Where serv.CODE_CH = DGV.SelectedRows(0).Cells(0).Value).Single()
                DC.HOSPITALISERs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
                Affiche()
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS HOSPITALISATION")
            End Try

        End If
    End Sub
End Class

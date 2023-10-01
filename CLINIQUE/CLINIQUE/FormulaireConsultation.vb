Public Class FormulaireConsultation

    Dim DC As New DCDataContext

    Private Sub ch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch.CheckedChanged
        If ch.Checked = True Then
            gr.Visible = True
        Else
            gr.Visible = False
        End If
    End Sub

    Private Sub btnEn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEn.Click
        If txtprixcon.Text = "" And Combpatient.SelectedItem = "" And Combmedecin.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
        Else
            Try

                Dim Soc As New CONSULTATION() With {.CODE_PAT = ValeurCodeP, _
                                           .CODE_PERS = ValeurCodePers, _
                                           .DATE_CONSULT = datecon.Value, _
                                           .TYPE_CONSULT = Combtypecon.SelectedItem.ToString, _
                                           .OBSERVATION = txtobsermed.Text, _
                                           .FRAIX_CONSULT = txtprixcon.Text _
                                         }
                DC.CONSULTATIONs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
                Affiche()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
            End Try

        End If
    End Sub
    Dim ValeurCodeP As String
    Dim ValeurCodePers As String
    Private Sub FormulaireConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VISITE CHARGEMENT COMBOBOX ---------------------
        Dim QueryP = From elt In DC.PERSONNEL_SOIGNANTs _
                   Select elt.NOM_PERS
        Combmedecin.DataSource = QueryP.ToList

        Dim QueryPat = From elt In DC.PATIENTs _
                  Select elt.NOM Distinct
        Combpatient.DataSource = QueryPat.ToList
        Affiche()
    End Sub
    Public Sub Affiche()
        Dim r = From ee In DC.CONSULTATIONs Select New With {.IDENTIFIANT = ee.ID, _
                                                             .PATIENT = ee.PATIENT.NOM.Trim, _
                                                             .MEDECIN = ee.PERSONNEL_SOIGNANT.NOM_PERS.Trim, _
                                                             .DATE_CONSULTATION = ee.DATE_CONSULT, _
                                                             .TYPE_CONSULTATION = ee.TYPE_CONSULT.Trim, _
                                                             .OBSERVATION = ee.OBSERVATION.Trim, _
                                                             .FRAIS_CONSULTATION = ee.FRAIX_CONSULT _
                                                           }
        DGV.DataSource = r.ToList
    End Sub

    Private Sub Combmedecin_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combmedecin.SelectedValueChanged
        Dim Query2 = From elt In DC.PERSONNEL_SOIGNANTs _
                    Where elt.NOM_PERS = Combmedecin.SelectedItem.ToString _
                    Select elt
        ValeurCodePers = Query2.First.CODE_PERS
    End Sub

    Private Sub Combpatient_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combpatient.SelectedValueChanged
        Dim Query22 = From elt2 In DC.PATIENTs _
                   Where elt2.NOM = Combpatient.SelectedItem.ToString _
                   Select elt2
        ValeurCodeP = Query22.First.CODE_PAT
    End Sub

    Private Sub btnFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFe.Click
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim r = From ee In DC.CONSULTATIONs Where ee.PERSONNEL_SOIGNANT.NOM_PERS.Contains(txtsearch.Text) Or ee.PATIENT.NOM.Contains(txtsearch.Text) Select New With {.IDENTIFIANT = ee.ID, _
                                                                                                                                                                      .PATIENT = ee.PATIENT.NOM.Trim, _
                                                                                                                                                                      .MEDECIN = ee.PERSONNEL_SOIGNANT.NOM_PERS.Trim, _
                                                                                                                                                                      .DATE_CONSULTATION = ee.DATE_CONSULT, _
                                                                                                                                                                      .TYPE_CONSULTATION = ee.TYPE_CONSULT.Trim, _
                                                                                                                                                                      .OBSERVATION = ee.OBSERVATION.Trim, _
                                                                                                                                                                      .FRAIS_CONSULTATION = ee.FRAIX_CONSULT _
                                                                                                                                                                    }
        DGV.DataSource = r.ToList
    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnEn.Enabled = False
            Combpatient.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            Combmedecin.SelectedItem = DGV.SelectedRows(0).Cells(2).Value
            Combtypecon.SelectedItem = DGV.SelectedRows(0).Cells(4).Value
            txtobsermed.Text = DGV.SelectedRows(0).Cells(5).Value
            txtprixcon.Text = DGV.SelectedRows(0).Cells(6).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnEn.Enabled = True
    End Sub

    Private Sub btnSu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSu.Click
        If txtprixcon.Text = "" And Combpatient.SelectedItem = "" And Combmedecin.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
        Else
            Try
                Dim soc = (From serv In DC.CONSULTATIONs Select serv Where serv.ID = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                DC.CONSULTATIONs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
                Affiche()
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
            End Try

        End If
    End Sub

    Private Sub btnMo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMo.Click
        If txtprixcon.Text = "" And Combpatient.SelectedItem = "" And Combmedecin.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
        Else
            Try
                Dim serv = (From ser In DC.CONSULTATIONs Select ser Where ser.ID = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                serv.CODE_PAT = ValeurCodeP
                serv.CODE_PERS = ValeurCodePers
                serv.DATE_CONSULT = datecon.Value
                serv.TYPE_CONSULT = Combtypecon.SelectedItem.ToString
                serv.OBSERVATION = txtobsermed.Text
                serv.FRAIX_CONSULT = txtprixcon.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
                Affiche()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS CONSULTATION")
            End Try
        End If
    End Sub
End Class

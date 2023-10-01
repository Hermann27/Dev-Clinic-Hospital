Public Class FormulaireRDV
    Dim DC As New DCDataContext
    Dim ValeurCodeP As String
    Dim ValeurCodePers As String
    Private Sub FormulaireRDV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VISITE CHARGEMENT COMBOBOX ---------------------
        Dim QueryP = From elt In DC.PERSONNEL_SOIGNANTs _
                   Select elt.NOM_PERS
        CombPS.DataSource = QueryP.ToList

        Dim QueryPat = From elt In DC.PATIENTs _
                  Select elt.NOM Distinct
        CombP.DataSource = QueryPat.ToList
        Affiche()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim r = From ee In DC.RDVs Where ee.PERSONNEL_SOIGNANT.NOM_PERS.Contains(txtsearch.Text) Or ee.PATIENT.NOM.Contains(txtsearch.Text) Select New With {.IDENTIFIANT = ee.ID_AUTO, _
                                                                                                                                                             .PATIENT = ee.PATIENT.NOM.Trim, _
                                                                                                                                                             .MEDECIN = ee.PERSONNEL_SOIGNANT.NOM_PERS.Trim, _
                                                                                                                                                             .DATE_RDV = ee.DATE_RDV, _
                                                                                                                                                             .HEURE_RDV = ee.HEURE_RDV.Trim, _
                                                                                                                                                             .MODIF_RDV = ee.MODIF_RDV.Trim, _
                                                                                                                                                             .OBSERVATION = ee.OBSERVATION_RDV.Trim _
                                                                                                                                                            }
        DGV.DataSource = r.ToList
    End Sub

    Private Sub CombPS_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombPS.SelectedValueChanged
        Dim Query2 = From elt In DC.PERSONNEL_SOIGNANTs _
                    Where elt.NOM_PERS = CombPS.SelectedItem.ToString _
                    Select elt
        ValeurCodePers = Query2.First.CODE_PERS
    End Sub

    Private Sub CombP_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombP.SelectedValueChanged
        Dim Query22 = From elt2 In DC.PATIENTs _
                   Where elt2.NOM = CombP.SelectedItem.ToString _
                   Select elt2
        ValeurCodeP = Query22.First.CODE_PAT
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtobser.Text = "" And CombP.SelectedItem = "" And CombPS.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS RDV")
        Else
            Try

                Dim Soc As New RDV() With {.CODE_PAT = ValeurCodeP, _
                                           .CODE_PERS = ValeurCodePers, _
                                           .DATE_RDV = datpic.Value, _
                                           .HEURE_RDV = txtheure.Text, _
                                           .MODIF_RDV = txtmodif.Text, _
                                           .OBSERVATION_RDV = txtobser.Text _
                                         }
                DC.RDVs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS RDV")
                Affiche()
            Catch ex As Exception
                MsgBox("Enregistrement Erroner  :)", MsgBoxStyle.Information, "INFOS RDV")
            End Try

        End If
    End Sub
    Public Sub Affiche()
        Dim r = From ee In DC.RDVs Select New With {.IDENTIFIANT = ee.ID_AUTO, _
                                                    .PATIENT = ee.PATIENT.NOM.Trim, _
                                                    .MEDECIN = ee.PERSONNEL_SOIGNANT.NOM_PERS.Trim, _
                                                    .DATE_RDV = ee.DATE_RDV, _
                                                    .HEURE_RDV = ee.HEURE_RDV.Trim, _
                                                    .MODIF_RDV = ee.MODIF_RDV.Trim, _
                                                    .OBSERVATION = ee.OBSERVATION_RDV.Trim _
                                                   }
        DGV.DataSource = r.ToList
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btbnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbnUp.Click
        If txtobser.Text = "" And CombP.SelectedItem = "" And CombPS.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS RDV")
        Else
            Try
                Dim serv = (From ser In DC.RDVs Select ser Where ser.ID_AUTO = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                serv.CODE_PAT = ValeurCodeP
                serv.CODE_PERS = ValeurCodePers
                serv.DATE_RDV = datpic.Value
                serv.HEURE_RDV = txtheure.Text
                serv.MODIF_RDV = txtmodif.Text
                serv.OBSERVATION_RDV = txtobser.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS RDV")
                Affiche()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS RDV")
            End Try
        End If
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If txtobser.Text = "" And CombP.SelectedItem = "" And CombPS.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS RDV")
        Else
            Try
                Dim soc = (From serv In DC.RDVs Select serv Where serv.ID_AUTO = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                DC.RDVs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS RDV")
                Affiche()
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS RDV")
            End Try

        End If
    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnSave.Enabled = False
            CombP.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            CombPS.SelectedItem = DGV.SelectedRows(0).Cells(2).Value
            txtheure.Text = DGV.SelectedRows(0).Cells(4).Value
            txtobser.Text = DGV.SelectedRows(0).Cells(5).Value
            txtobser.Text = DGV.SelectedRows(0).Cells(6).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnSave.Enabled = True
    End Sub
End Class

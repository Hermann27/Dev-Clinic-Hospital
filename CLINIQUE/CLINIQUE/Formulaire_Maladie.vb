Public Class Formulaire_Maladie
    Dim DC As New DCDataContext
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtcodmaladie.Text = "" And txtdesig.Text = "" And txtfamilleMaladie.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS MALADIE")
        Else
            Try
                Dim serv = (From ser In DC.MALADIEs Select ser Where ser.CODE_MAL = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                serv.DESIGNATION = txtdesig.Text
                serv.FAMILLE_MAL = txtfamilleMaladie.Text
                serv.PRIX_TRAIT = txtprix.Text
                serv.SOUS_FAMILLE_MAL = txtsousfamille.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS MALADIE")
                Affiche()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS MALADIE")
            End Try
        End If
    End Sub
    Public Sub Affiche()
        Dim r = From ee In DC.MALADIEs Select New With {.CODE = ee.CODE_MAL.Trim, _
                                                          .FAMILLE = ee.FAMILLE_MAL.Trim, _
                                                          .SOUS_FAMILLE = ee.SOUS_FAMILLE_MAL.Trim, _
                                                          .PRIX = ee.PRIX_TRAIT, _
                                                          .OBSERVATION = ee.DESIGNATION.Trim _
                                                        }
        DGV.DataSource = r.ToList
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            txtcodmaladie.Enabled = False
            txtcodmaladie.Text = DGV.SelectedRows(0).Cells(0).Value
            txtfamilleMaladie.Text = DGV.SelectedRows(0).Cells(1).Value
            txtsousfamille.Text = DGV.SelectedRows(0).Cells(2).Value
            txtprix.Text = DGV.SelectedRows(0).Cells(3).Value
            txtdesig.Text = DGV.SelectedRows(0).Cells(4).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnEnr.Enabled = True
        txtcodmaladie.Enabled = True
    End Sub
    Private Sub btnEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnr.Click
        If txtcodmaladie.Text = "" And txtdesig.Text = "" And txtfamilleMaladie.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS MALADIE")
        Else
            Try

                Dim Soc As New MALADIE() With {.CODE_MAL = txtcodmaladie.Text, _
                                                   .DESIGNATION = txtdesig.Text, _
                                                   .FAMILLE_MAL = txtfamilleMaladie.Text, _
                                                   .SOUS_FAMILLE_MAL = txtfamilleMaladie.Text, _
                                                   .PRIX_TRAIT = txtprix.Text _
                                                  }
                DC.MALADIEs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS MALADIE")
                Affiche()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS MALADIE")
            End Try

        End If
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If txtcodmaladie.Text = "" And txtdesig.Text = "" And txtfamilleMaladie.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS MALADIE")
        Else
            Try
                Dim soc = (From serv In DC.MALADIEs Select serv Where serv.CODE_MAL = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.MALADIEs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS MALADIE")
                Affiche()
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS MALADIE")
            End Try

        End If
    End Sub

    Private Sub btnFer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFer.Click
        Me.Close()
    End Sub

    Private Sub Formulaire_Maladie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Affiche()
    End Sub
End Class

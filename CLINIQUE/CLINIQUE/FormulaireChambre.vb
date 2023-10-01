Public Class FormulaireChambre

    Dim DC As New DCDataContext

    Private Sub btnEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnr.Click
        If txtcode.Text = "" And Combcategcham.SelectedItem = "" And Comblocalcham.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
        Else
            Try

                Dim Soc As New CHAMBRE() With {.CODE_CH = txtcode.Text, _
                                                   .LOCALISATION = Comblocalcham.SelectedItem.ToString, _
                                                   .CATEGORIE_CH = Combcategcham.SelectedItem.ToString, _
                                                   .TYPE_LIT = ComboCap.SelectedItem.ToString, _
                                                   .PRIX_CH = txtprixcham.Text, _
                                                   .DESIGNATION = txtdesig.Text _
                                                  }
                DC.CHAMBREs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
                Affiche()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
            End Try

        End If
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtcode.Text = "" And Combcategcham.SelectedItem = "" And Comblocalcham.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
        Else
            Try
                Dim serv = (From ser In DC.CHAMBREs Select ser Where ser.CODE_CH = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                serv.LOCALISATION = Comblocalcham.SelectedItem.ToString
                serv.CATEGORIE_CH = Combcategcham.SelectedItem.ToString
                serv.PRIX_CH = txtprixcham.Text
                serv.TYPE_LIT = ComboCap.SelectedItem.ToString
                serv.DESIGNATION = txtdesig.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
                Affiche()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
            End Try
        End If
    End Sub
    Public Sub Affiche()
        Dim r = From ee In DC.CHAMBREs Select New With {.CODE = ee.CODE_CH.Trim, _
                                                           .CATEGORIE = ee.CATEGORIE_CH.Trim, _
                                                           .LOCALISATION = ee.LOCALISATION, _
                                                           .CAPACITE = ee.TYPE_LIT, _
                                                           .PRIX = ee.PRIX_CH, _
                                                           .DESIGNATION = ee.DESIGNATION _
                                                         }
        DGV.DataSource = r.ToList
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            txtcode.Enabled = False
            txtcode.Text = DGV.SelectedRows(0).Cells(0).Value
            Combcategcham.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            Comblocalcham.SelectedItem = DGV.SelectedRows(0).Cells(2).Value
            ComboCap.SelectedItem = DGV.SelectedRows(0).Cells(3).Value
            txtprixcham.Text = DGV.SelectedRows(0).Cells(4).Value
            txtdesig.Text = DGV.SelectedRows(0).Cells(5).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnEnr.Enabled = True
        txtcode.Enabled = True
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If txtcode.Text = "" And Combcategcham.SelectedItem = "" And Comblocalcham.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
        Else
            Try
                Dim soc = (From serv In DC.CHAMBREs Select serv Where serv.CODE_CH = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.CHAMBREs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
                Affiche()
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS CHAMBRE")
            End Try

        End If
    End Sub

    Private Sub btnFer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFer.Click
        Me.Close()
    End Sub

    Private Sub FormulaireChambre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Affiche()
    End Sub
End Class

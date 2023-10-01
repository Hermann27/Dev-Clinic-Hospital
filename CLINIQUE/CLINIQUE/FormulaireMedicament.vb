Public Class FormulaireMedicament
    Dim DC As New DCDataContext
    Private Sub ch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch.CheckedChanged
        If ch.Checked = True Then
            groupbx.Visible = True
        Else
            groupbx.Visible = False
        End If
    End Sub

    Private Sub KryptonButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If txtmode.Text = "" And txtnom.Text = "" And txtprix.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")
        Else
            Try
                Dim ser = (From serv In DC.PHARMACIEs Select serv Where serv.CODE_MEC = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.PHARMACIEs.DeleteOnSubmit(ser)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")
                Affiche()
                ser = Nothing
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")
            End Try

        End If
    End Sub

    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAJ.Click
        If txtmode.Text = "" And txtnom.Text = "" And txtprix.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")
        Else
            Try

                Dim mec As New PHARMACIE() With {.CODE_MEC = txtcode.Text, _
                                                                .NOM_MEC = txtnom.Text, _
                                                                .PRIX_MEC = txtprix.Text, _
                                                                .FAMILLE_M = cmbF.SelectedItem.ToString, _
                                                                .FORME_M = cmbForme.SelectedItem.ToString, _
                                                                .POSOLOGU_M = txtmode.Text, _
                                                                .OBSERVATION = txtobser.Text _
                                                }
                DC.PHARMACIEs.InsertOnSubmit(mec)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")
                Affiche()
            Catch ex As Exception

                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")
            End Try

        End If
    End Sub

    Private Sub KryptonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUP.Click
        If txtmode.Text = "" And txtnom.Text = "" And txtprix.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")
        Else
            Try
                Dim P = (From Pers In DC.PHARMACIEs Select Pers Where Pers.CODE_MEC = txtcode.Text).Single()
                P.CODE_MEC = txtcode.Text
                P.NOM_MEC = txtnom.Text
                P.PRIX_MEC = txtprix.Text
                P.FAMILLE_M = cmbF.SelectedItem.ToString
                P.FORME_M = cmbForme.SelectedItem.ToString
                P.POSOLOGU_M = txtmode.Text
                P.OBSERVATION = txtobser.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")
                Affiche()
                P = Nothing
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS SUR LE MEDICAMENT")

            End Try

        End If
    End Sub
    Public Sub Affiche()
        Dim query2 = From elt In DC.PHARMACIEs Select New With {.CODE = elt.CODE_MEC, _
                                                                             .NOM = elt.NOM_MEC.Trim, _
                                                                             .PRIX = elt.PRIX_MEC, _
                                                                             .FAMILLE = elt.FAMILLE_M.Trim, _
                                                                             .FORME = elt.FORME_M.Trim, _
                                                                             .POSOLOGIE_USUELE = elt.POSOLOGU_M.Trim, _
                                                                             .OBSERVATION = elt.OBSERVATION.Trim _
                                                             }

        DGV.DataSource = query2.ToList
    End Sub
    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClo.Click
        Me.Close()
    End Sub

    Private Sub rbN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbN.CheckedChanged

        Dim Query2 = From elt2 In DC.PHARMACIEs _
                                                Select elt2.NOM_MEC Distinct
        cmbM.DataSource = Query2.ToList
    End Sub

    Private Sub rbF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbF.CheckedChanged
        Dim Query2 = From elt2 In DC.PHARMACIEs _
                                                Select elt2.FAMILLE_M Distinct
        cmbM.DataSource = Query2.ToList

    End Sub

    Private Sub rbFO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFO.CheckedChanged
        Dim Query2 = From elt2 In DC.PHARMACIEs _
                                               Order By elt2.FORME_M Select elt2.FORME_M Distinct
        cmbM.DataSource = Query2.ToList

    End Sub

    Private Sub FormulaireMedicament_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Affiche()
    End Sub

    Private Sub cmbM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbM.SelectedIndexChanged
        Dim r = From ee In DC.PHARMACIEs Where ee.NOM_MEC.Contains(cmbM.SelectedItem.ToString) Or ee.FORME_M.Contains(cmbM.SelectedItem.ToString) Or ee.FAMILLE_M.Contains(cmbM.SelectedItem.ToString) Select New With {.CODE = ee.CODE_MEC, _
                                                                                                                                                                                                                                     .NOM = ee.NOM_MEC.Trim, _
                                                                                                                                                                                                                                     .PRIX = ee.PRIX_MEC, _
                                                                                                                                                                                                                                     .FAMILLE = ee.FAMILLE_M.Trim, _
                                                                                                                                                                                                                                     .FORME = ee.FORME_M.Trim, _
                                                                                                                                                                                                                                     .POSOLOGIE_USUELE = ee.POSOLOGU_M.Trim, _
                                                                                                                                                                                                                                     .OBSERVATION = ee.OBSERVATION.Trim _
                                                                                                                                                                                                                     }






        DGV.DataSource = r.ToList
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtcode.Enabled = False
            btnAJ.Enabled = False
            txtcode.Text = DGV.SelectedRows(0).Cells(0).Value
            txtnom.Text = DGV.SelectedRows(0).Cells(1).Value
            txtprix.Text = DGV.SelectedRows(0).Cells(2).Value
            cmbF.SelectedItem = DGV.SelectedRows(0).Cells(3).Value
            cmbForme.SelectedItem = DGV.SelectedRows(0).Cells(4).Value
            txtmode.Text = DGV.SelectedRows(0).Cells(5).Value
            txtobser.Text = DGV.SelectedRows(0).Cells(6).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        txtcode.Enabled = True
        btnAJ.Enabled = True

    End Sub
    Public Sub initialisez()
        txtcode.Text = ""
        txtnom.Text = ""
        txtprix.Text = ""
        txtmode.Text = ""
        txtobser.Text = ""
    End Sub

    Private Sub KryptonLinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonLinkLabel1.LinkClicked
        initialisez()
    End Sub
End Class

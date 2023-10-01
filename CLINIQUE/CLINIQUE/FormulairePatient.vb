Public Class FormulairePatient
    Dim DC As New DCDataContext
    Private Sub KryptonCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch.CheckedChanged
        If Ch.Checked = True Then
            groupbx.Visible = True
        Else
            groupbx.Visible = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtcode.Text = "" And txtnom.Text = "" And txtcin.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
        Else

            Try

                Dim patient As New PATIENT() With {.CODE_PAT = txtcode.Text, _
                                                                .CODE = valeurCodeP, _
                                                                .NOM = txtnom.Text, _
                                                                .PRENOM = txtprenom.Text, _
                                                                .EMAIL = txtemail.Text, _
                                                                .CIN = txtcin.Text, _
                                                                .PROFESSION = txtprof.Text, _
                                                                .QUARTIE = txtktier.Text, _
                                                                .LIEU_NAISS = txtlieu.Text, _
                                                                .DATE_NAISS = datnaiss.Value, _
                                                                .GROUPE_SANGUN = txtgr.Text, _
                                                                .PERSONNE_A_CONTACTER = txtPC.Text, _
                                                                .SEXE = IIf(rbM.Checked = True, rbM.Text.ToString, rbF.Text.ToString), _
                                                                .TELEPHONE = txttephone.Text}
                DC.PATIENTs.InsertOnSubmit(patient)
                DC.SubmitChanges()
                'DC.Refresh(
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
                Affiche()
            Catch ex As Exception
                MsgBox(ex.Message)
                ' MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
            End Try

        End If
    End Sub
    Public Sub Affiche()
        Dim query2 = From elt In DC.PATIENTs Select New With {.CODE = elt.CODE_PAT.Trim, _
                                                              .SOCIETE = elt.SOCIETE.NOM_SOC.Trim, _
                                                              .NOM = elt.NOM.Trim, _
                                                              .PRENOM = elt.PRENOM.Trim, _
                                                              .EMAIL = elt.EMAIL.Trim, _
                                                              .CIN = elt.CIN, _
                                                              .GROUPE_SANGUN = elt.GROUPE_SANGUN.Trim, _
                                                              .PROFESSION = elt.PROFESSION.Trim, _
                                                              .LIEU = elt.LIEU_NAISS.Trim, _
                                                              .DATE = elt.DATE_NAISS, _
                                                              .SEXE = elt.SEXE.Trim, _
                                                              .TELEPHONE = elt.TELEPHONE, _
                                                              .QUARTIER = elt.QUARTIE, _
                                                              .PERSONNEL_CONTACTER = elt.PERSONNE_A_CONTACTER _
                                                             }
        DGV.DataSource = query2.ToList
    End Sub

    Private Sub FormulairePatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Query = From elt In DC.SOCIETEs _
                   Select elt.NOM_SOC
        cmbSoc.DataSource = Query.ToList
        Affiche()
    End Sub
    Dim valeurCodeP As String
    Private Sub cmbSoc_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSoc.SelectedValueChanged
        Dim Query2 = From elt2 In DC.SOCIETEs _
                        Where elt2.NOM_SOC = cmbSoc.SelectedItem.ToString _
                        Select elt2
        valeurCodeP = Query2.First.CODE
    End Sub

    Private Sub btnUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUP.Click
        If txtcode.Text = "" And txtnom.Text = "" And txtcin.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
        Else
            Try
                Dim P = (From Pers In DC.PATIENTs Select Pers Where Pers.CODE_PAT = txtcode.Text).Single()
                P.CODE = valeurCodeP
                P.NOM = txtnom.Text
                P.PRENOM = txtprenom.Text
                P.EMAIL = txtemail.Text
                P.CIN = txtcin.Text
                P.PERSONNE_A_CONTACTER = txtPC.Text
                P.GROUPE_SANGUN = txtgr.Text
                P.PROFESSION = txtprof.Text
                P.QUARTIE = txtktier.Text
                P.DATE_NAISS = datnaiss.Value
                P.LIEU_NAISS = txtlieu.Text
                P.SEXE = IIf(rbM.Checked = True, rbM.Text.ToString, rbF.Text.ToString)
                P.TELEPHONE = txttephone.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
                Affiche()
                P = Nothing
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
            
            End Try

        End If
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If txtcode.Text = "" And txtnom.Text = "" And txtcin.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
        Else
            Try
                Dim ser = (From serv In DC.PATIENTs Select serv Where serv.CODE_PAT = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.PATIENTs.DeleteOnSubmit(ser)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
                Affiche()
            Catch ex As Exception
                MsgBox(ex.Message)
                ' MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS SUR LE PATIENT")
            End Try

        End If
    End Sub


    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim r = From ee In DC.PATIENTs Where ee.CODE_PAT.Contains(txtsearch.Text) Or ee.NOM.Contains(txtsearch.Text) Or ee.GROUPE_SANGUN.Contains(txtsearch.Text) Select New With {.CODE = ee.CODE_PAT.Trim, _
                                                                                                                                                                                   .SOCIETE = ee.SOCIETE.NOM_SOC.Trim, _
                                                                                                                                                                                   .NOM = ee.NOM.Trim, _
                                                                                                                                                                                   .PRENOM = ee.PRENOM.Trim,
                                                                                                                                                                                   .EMAIL = ee.EMAIL.Trim, _
                                                                                                                                                                                   .CIN = ee.CIN, _
                                                                                                                                                                                   .GROUPE_SANGUN = ee.GROUPE_SANGUN.Trim, _
                                                                                                                                                                                   .PROFESSION = ee.PROFESSION.Trim, _
                                                                                                                                                                                   .LIEU = ee.LIEU_NAISS.Trim, _
                                                                                                                                                                                   .DATE = ee.DATE_NAISS, _
                                                                                                                                                                                   .SEXE = ee.SEXE.Trim, _
                                                                                                                                                                                   .TELEPHONE = ee.TELEPHONE, _
                                                                                                                                                                                   .QUARTIER = ee.QUARTIE, _
                                                                                                                                                                                   .PERSONNEL_CONTACTER = ee.PERSONNE_A_CONTACTER _
                                                                                                                                                                                  }
        DGV.DataSource = r.ToList
    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtcode.Enabled = False
            btnSave.Enabled = False
            txtcode.Text = DGV.SelectedRows(0).Cells(0).Value
            cmbSoc.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            txtnom.Text = DGV.SelectedRows(0).Cells(2).Value
            txtprenom.Text = DGV.SelectedRows(0).Cells(3).Value
            txtemail.Text = DGV.SelectedRows(0).Cells(4).Value
            txtcin.Text = DGV.SelectedRows(0).Cells(5).Value
            txtgr.Text = DGV.SelectedRows(0).Cells(6).Value
            txtprof.Text = DGV.SelectedRows(0).Cells(7).Value
            txtlieu.Text = DGV.SelectedRows(0).Cells(8).Value
            datnaiss.Value = DGV.SelectedRows(0).Cells(9).Value
            If DGV.SelectedRows(0).Cells(10).Value = "Masculin" Then
                rbM.Checked = True
            Else
                rbF.Checked = True
            End If
            txttephone.Text = DGV.SelectedRows(0).Cells(11).Value
            txtktier.Text = DGV.SelectedRows(0).Cells(12).Value
            txtPC.Text = DGV.SelectedRows(0).Cells(13).Value
        End If
    End Sub

    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        txtcode.Enabled = True
        btnSave.Enabled = True
    End Sub

    Public Sub initialize()
        txtcode.Text = ""
        cmbSoc.SelectedItem = ""
        txtnom.Text = ""
        txtprenom.Text = ""
        txtemail.Text = ""
        txtcin.Text = ""
        txtktier.Text = ""
        txtprof.Text = ""
        txtPC.Text = ""
        rbM.Checked = False
        rbF.Checked = False
        txttephone.Text = ""
    End Sub

    Private Sub KryptonLinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonLinkLabel1.LinkClicked
        initialize()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
Public Class Formulaire_priseCharge
    Dim DC As New DCDataContext
    Private Sub KryptonButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnengass.Click
        If txtcode.Text = "" And txtfax.Text = "" And txtnom.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
        Else
            Try

                Dim assurence As New ASSURANCE() With {.CODE_ASS = txtcode.Text, .NOM_ASS = txtnom.Text, .BP_ASS = txtbp.Text, .TELEPHONE_ASS = txtphone.Text, .TELEX_ASS = txtref.Text, .FAX_ASS = txtfax.Text}
                DC.ASSURANCEs.InsertOnSubmit(assurence)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
                Affiche()

            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
            End Try

        End If

    End Sub

    Private Sub Formulaire_depot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Query = From elt In DC.ACTE_PRESTATIONs _
                   Select elt.INTUTLE_PRES
        CmbAP.DataSource = Query.ToList

        Dim QueryC = From elt In DC.CATEGORIE_SOCIETEs _
                  Select elt.INTITULE Distinct
        CmbCs.DataSource = QueryC.ToList

        Dim QueryCS = From elt In DC.SOCIETEs _
                  Select elt.NOM_SOC
        CombSoc.DataSource = QueryCS.ToList

        Dim QueryCG = From elt In DC.ACTE_PRESTATIONs _
                  Select elt.INTUTLE_PRES
        CombPG.DataSource = QueryCG.ToList
        Affiche()
        AfficheS()
        AfficheSD()
        AfficheCS()
        AfficheAP()
        AfficheG()
    End Sub

    Private Sub btndelass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelass.Click
        If txtcode.Text = "" And txtfax.Text = "" And txtnom.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
        Else
            Try
                Dim assurance = (From serv In DC.ASSURANCEs Select serv Where serv.CODE_ASS = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.ASSURANCEs.DeleteOnSubmit(assurance)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
                Affiche()

            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
            End Try

        End If
    End Sub

    Dim VaureID As Integer
    Dim VaureCode As String
    Private Sub btnUPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPass.Click
        If txtcode.Text = "" And txtfax.Text = "" And txtnom.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
        Else
            Try
                Dim serv = (From ser In DC.ASSURANCEs Select ser Where ser.CODE_ASS = txtcode.Text).Single()
                serv.BP_ASS = txtbp.Text
                serv.NOM_ASS = txtnom.Text
                serv.TELEPHONE_ASS = txtphone.Text
                serv.TELEX_ASS = txtref.Text
                serv.FAX_ASS = txtfax.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
                Affiche()

            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS ASSURANCE")
            End Try

        End If
    End Sub
    Public Sub Affiche()
        Dim query2 = From elt In DC.ASSURANCEs Select New With {.CODE = elt.CODE_ASS.Trim, .NOM = elt.NOM_ASS, .BP = elt.BP_ASS, .TELEPHONE = elt.TELEPHONE_ASS, .REFERENCE = elt.TELEX_ASS, .FAX = elt.FAX_ASS}
        DGV.DataSource = query2.ToList
    End Sub
    Public Sub AfficheS()
        Dim query2 = From elt In DC.SOCIETEs Select New With {.CODE = elt.CODE.Trim, .NOM = elt.NOM_SOC, .ADRESSE = elt.ADRESSE_SOC}
        DGV1.DataSource = query2.ToList
    End Sub
    Private Sub btnFers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFers.Click
        Me.Close()
    End Sub

    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        txtcode.Enabled = True
        btnengass.Enabled = True
    End Sub
    Private Sub DGV1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV1.LostFocus
        txtcodeS.Enabled = True
        btnsave.Enabled = True
    End Sub
    Private Sub DGV2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV2.LostFocus
        btnsavedetail.Enabled = True
    End Sub

    Private Sub DGV4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV4.LostFocus
        btnSaveC.Enabled = True
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtcode.Enabled = False
            btnengass.Enabled = False
            txtcode.Text = DGV.SelectedRows(0).Cells(0).Value
            txtnom.Text = DGV.SelectedRows(0).Cells(1).Value
            txtbp.Text = DGV.SelectedRows(0).Cells(2).Value
            txtphone.Text = DGV.SelectedRows(0).Cells(3).Value
            txtref.Text = DGV.SelectedRows(0).Cells(4).Value
            txtfax.Text = DGV.SelectedRows(0).Cells(5).Value
        End If
    End Sub

    Private Sub btnfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfer.Click
        Me.Close()
    End Sub

    Private Sub btnUpSoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpSoc.Click
        If txtcodeS.Text = "" And txtadressS.Text = "" And txtnomS.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SOCIETE")
        Else
            Try
                Dim serv = (From ser In DC.SOCIETEs Select ser Where ser.CODE = txtcodeS.Text).Single()
                serv.NOM_SOC = txtnom.Text
                serv.ADRESSE_SOC = txtadressS.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS SOCIETE")
                AfficheS()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS SOCIETE")
            End Try

        End If
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If txtcodeS.Text = "" And txtadressS.Text = "" And txtnomS.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SOCIETE")
        Else
            Try
                Dim soc = (From serv In DC.SOCIETEs Select serv Where serv.CODE = DGV1.SelectedRows(0).Cells(0).Value.ToString.Trim).Single()
                DC.SOCIETEs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS SOCIETE")
                AfficheS()
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS SOCIETE")
            End Try

        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtcodeS.Text = "" And txtadressS.Text = "" And txtnomS.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SOCIETE")
        Else
            Try

                Dim Soc As New SOCIETE() With {.CODE = txtcodeS.Text, .NOM_SOC = txtnomS.Text, .ADRESSE_SOC = txtadressS.Text}
                DC.SOCIETEs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS SOCIETE")
                AfficheS()

            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS SOCIETE")
            End Try

        End If

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim r = From ee In DC.SOCIETEs Where ee.NOM_SOC.Contains(txtsearch.Text) Or ee.CODE.Contains(txtsearch.Text) Or ee.ADRESSE_SOC.Contains(txtsearch.Text) Select New With {.CODE = ee.CODE.Trim, .NOM = ee.NOM_SOC, .ADRESSE = ee.ADRESSE_SOC}
        DGV.DataSource = r.ToList
    End Sub

    Private Sub DGV1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV1.SelectionChanged
        If DGV1.SelectedRows.Count > 0 Then
            txtcodeS.Enabled = False
            btnsave.Enabled = False
            txtcodeS.Text = DGV1.SelectedRows(0).Cells(0).Value
            txtnomS.Text = DGV1.SelectedRows(0).Cells(1).Value
            txtadressS.Text = DGV1.SelectedRows(0).Cells(2).Value
        End If
    End Sub
    Private Sub DGV2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV2.SelectionChanged
        If DGV2.SelectedRows.Count > 0 Then
            btnsavedetail.Enabled = False
            CmbAP.SelectedItem = DGV2.SelectedRows(0).Cells(1).Value
            CmbCs.SelectedItem = DGV2.SelectedRows(0).Cells(2).Value
            txtprix.Text = DGV2.SelectedRows(0).Cells(3).Value
        End If
    End Sub
    Private Sub DGV4_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV4.SelectionChanged
        If DGV4.SelectedRows.Count > 0 Then
            btnSaveC.Enabled = False
            CombSoc.SelectedItem = DGV4.SelectedRows(0).Cells(1).Value
            txtintituleC.Text = DGV4.SelectedRows(0).Cells(2).Value
            txtdesigC.Text = DGV4.SelectedRows(0).Cells(3).Value
        End If
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdetail.Click
        If txtprix.Text = "" And CmbAP.SelectedItem = "" And CmbCs.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DETAIL ASSURANCE SOCIETE")
        Else
            MsgBox(DGV2.SelectedRows(0).Cells(0).Value & " " & txtprix.Text.Trim & " " & VaureCode.Trim & " " & VaureID)
            Try
                Dim servL = (From ser In DC.DETAIL_ASSURANCE_SOCs Select ser Where ser.ID_AUTO = CInt(DGV2.SelectedRows(0).Cells(0).Value)).Single()
                servL.CODE_PRES = VaureCode.Trim
                servL.ID = VaureID
                servL.PRIX_PRATIQUER = txtprix.Text.Trim
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS DETAIL ASSURANCE SOCIETE")
                AfficheSD()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS DETAIL ASSURANCE SOCIETE")
            End Try

        End If
    End Sub

    Private Sub btnsupdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsupdetail.Click
        If txtprix.Text = "" And CmbAP.SelectedItem = "" And CmbCs.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DETAIL ASSURANCE SOCIETE")
        Else
            Try

                Dim soc = (From serv In DC.DETAIL_ASSURANCE_SOCs Select serv Where serv.ID_AUTO = DGV2.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.DETAIL_ASSURANCE_SOCs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS  DETAIL ASSURANCE SOCIETE")
                AfficheSD()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS  DETAIL ASSURANCE SOCIETE")
            End Try

        End If
    End Sub

    Private Sub btnsavedetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavedetail.Click
        If txtprix.Text = "" And CmbAP.SelectedItem = "" And CmbCs.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DETAIL ASSURANCE SOCIETE")
        Else
            Try

                Dim Soc As New DETAIL_ASSURANCE_SOC() With {.CODE_PRES = VaureCode, .PRIX_PRATIQUER = txtprix.Text, .ID = VaureID}
                DC.DETAIL_ASSURANCE_SOCs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS DETAIL ASSURANCE SOCIETE")
                AfficheSD()

            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS DETAIL ASSURANCE SOCIETE")
            End Try

        End If
    End Sub
    Public Sub AfficheSD()
        Dim query2 = From elt In DC.DETAIL_ASSURANCE_SOCs Select New With {.IDENTIFIANT = elt.ID_AUTO, .CODE_PRESTATION = elt.ACTE_PRESTATION.INTUTLE_PRES, .CATEGORIE_SOCIETE = elt.CATEGORIE_SOCIETE.INTITULE, .PRIX_PRATIQUE = elt.PRIX_PRATIQUER}
        DGV2.DataSource = query2.ToList
    End Sub

    Private Sub CmbAP_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAP.SelectedValueChanged
        Dim Query2 = From elt2 In DC.ACTE_PRESTATIONs _
                        Where elt2.INTUTLE_PRES = CmbAP.SelectedItem.ToString _
                        Select elt2
        VaureCode = Query2.First.CODE_PRES
    End Sub

    Private Sub CmbCs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCs.SelectedIndexChanged
        Dim Query2 = From elt2 In DC.CATEGORIE_SOCIETEs _
                        Where elt2.INTITULE = CmbCs.SelectedItem.ToString _
                        Select elt2
        VaureID = Query2.First.ID
    End Sub
    Dim VaureCodeS As String
    Private Sub KryptonButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpC.Click
        If txtintituleC.Text = "" And CombSoc.SelectedItem = "" And txtdesigC.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CATEGORIE SOCIETE")
        Else
            Try
                Dim servL = (From ser In DC.CATEGORIE_SOCIETEs Select ser Where ser.ID = CInt(DGV4.SelectedRows(0).Cells(0).Value)).Single()
                servL.CODE = VaureCodeS.Trim
                servL.INTITULE = txtintituleC.Text
                servL.DESIG_CAT = txtdesigC.Text.Trim
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS CATEGORIE SOCIETE")
                AfficheCS()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS CATEGORIE SOCIETE")
            End Try

        End If
    End Sub

    Public Sub AfficheCS()
        Dim query2 = From elt In DC.CATEGORIE_SOCIETEs Select New With {.IDENTIFIANT = elt.ID, .NOM_SOCIETE = elt.SOCIETE.NOM_SOC, .INTITULE = elt.INTITULE, .DESIGNATION = elt.DESIG_CAT}
        DGV4.DataSource = query2.ToList
    End Sub

    Private Sub CombSoc_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombSoc.SelectedValueChanged
        Dim Query2 = From elt2 In DC.SOCIETEs _
                        Where elt2.NOM_SOC = CombSoc.SelectedItem.ToString _
                        Select elt2
        VaureCodeS = Query2.First.CODE
    End Sub

    Private Sub btnSaveC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveC.Click
        If txtintituleC.Text = "" And CombSoc.SelectedItem = "" And txtdesigC.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CATEGORIE SOCIETE")
        Else
            Try

                Dim Soc As New CATEGORIE_SOCIETE() With {.CODE = VaureCodeS, .INTITULE = txtintituleC.Text, .DESIG_CAT = txtdesigC.Text}
                DC.CATEGORIE_SOCIETEs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS CATEGORIE SOCIETE")
                AfficheCS()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS CATEGORIE SOCIETE")
            End Try

        End If
    End Sub

    Private Sub btnDelC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelC.Click
        If txtintituleC.Text = "" And CombSoc.SelectedItem = "" And txtdesigC.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS CATEGORIE SOCIETE")
        Else
            Try

                Dim soc = (From serv In DC.CATEGORIE_SOCIETEs Select serv Where serv.ID = DGV4.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.CATEGORIE_SOCIETEs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS  CATEGORIE SOCIETE")
                AfficheCS()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS  CATEGORIE SOCIETE")
            End Try

        End If
    End Sub

    Private Sub btncloseC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncloseC.Click
        Me.Close()
    End Sub
#Region "Code acte de prestation"
    Private Sub btnUpP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpP.Click
        If txtintituleP.Text = "" And txtprixP.Text = "" And txtcleP.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ACTE DE PRESTATION")
        Else
            Try
                Dim AP = (From ser In DC.ACTE_PRESTATIONs Select ser Where ser.CODE_PRES = DGV5.SelectedRows(0).Cells(0).Value.ToString).Single()
                AP.INTUTLE_PRES = txtintituleP.Text
                AP.LETTRE_CLE = txtcleP.Text
                AP.PRIX_PRATITIQUER = txtprixP.Text.Trim
                AP.DESIGNATION = txtdesigP.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS ACTE DE PRESTATION")
                AfficheAP()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS ACTE DE PRESTATION")
            End Try
        End If
    End Sub



    Private Sub btnSaveP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveP.Click
        If txtintituleP.Text = "" And txtprixP.Text = "" And txtcleP.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ACTE DE PRESTATION")
        Else
            Try

                Dim Soc As New ACTE_PRESTATION() With {.CODE_PRES = txtCodeP.Text, .INTUTLE_PRES = txtintituleP.Text, .LETTRE_CLE = txtcleP.Text, .PRIX_PRATITIQUER = txtprixP.Text, .DESIGNATION = txtdesigP.Text}
                DC.ACTE_PRESTATIONs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS ACTE DE PRESTATION")
                AfficheAP()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS ACTE DE PRESTATION")
            End Try

        End If
    End Sub

    Private Sub btndelP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelP.Click
        If txtintituleP.Text = "" And txtprixP.Text = "" And txtcleP.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ACTE DE PRESTATION")
        Else
            Try

                Dim soc = (From serv In DC.ACTE_PRESTATIONs Select serv Where serv.CODE_PRES = DGV5.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.ACTE_PRESTATIONs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS  ACTE DE PRESTATION")
                AfficheAP()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS  ACTE DE PRESTATION")
            End Try

        End If
    End Sub


    Private Sub btnCloseP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseP.Click
        Me.Close()
    End Sub
    Private Sub DGV5_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV5.SelectionChanged
        If DGV5.SelectedRows.Count > 0 Then
            btnSaveP.Enabled = False
            txtCodeP.Text = DGV5.SelectedRows(0).Cells(0).Value
            txtintituleP.Text = DGV5.SelectedRows(0).Cells(1).Value
            txtcleP.Text = DGV5.SelectedRows(0).Cells(2).Value
            txtprixP.Text = DGV5.SelectedRows(0).Cells(3).Value
            txtdesigP.Text = DGV5.SelectedRows(0).Cells(4).Value
        End If
    End Sub
    Private Sub DGV5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV5.LostFocus
        btnSaveP.Enabled = True
    End Sub
    Public Sub AfficheAP()
        Dim query2 = From elt In DC.ACTE_PRESTATIONs Select New With {.CODE_ACTE = elt.CODE_PRES.Trim, .INTITULE = elt.INTUTLE_PRES, .LETTRE_CLE = elt.LETTRE_CLE, .PRIX_PRATIQUE = elt.PRIX_PRATITIQUER, .DESIGNATION = elt.DESIGNATION}
        DGV5.DataSource = query2.ToList
    End Sub
#End Region

#Region "GROUPE ACTE DE PRESTATION"

    Private Sub btnUpG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpG.Click
        If txtcodeG.Text = "" And txtintituleG.Text = "" And txtdesigG.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS GROUPE PRESTATION")
        Else
            Try
                Dim AP = (From ser In DC.GROUPEs Select ser Where ser.CODE_GR = DGV6.SelectedRows(0).Cells(0).Value.ToString).Single()
                AP.CODE_PRES = valeurCodeG
                AP.INTITULE = txtintituleG.Text
                AP.DESIGNATION = txtdesigG.Text.Trim
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS GROUPE PRESTATION")
                AfficheG()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS GROUPE PRESTATION")
            End Try
        End If
    End Sub


    Dim valeurCodeG As String
    Private Sub CombPG_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombPG.SelectedValueChanged
        Dim Query22 = From elt2 In DC.ACTE_PRESTATIONs _
                      Where elt2.INTUTLE_PRES = CombPG.SelectedItem.ToString _
                      Select elt2
        valeurCodeG = Query22.First.CODE_PRES
    End Sub
    Private Sub btnSaveG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveG.Click
        If txtcodeG.Text = "" And txtintituleG.Text = "" And txtdesigG.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS GROUPE PRESTATION")
        Else
            Try

                Dim Soc As New GROUPE() With {.CODE_GR = txtcodeG.Text, .CODE_PRES = valeurCodeG, .INTITULE = txtintituleG.Text, .DESIGNATION = txtdesigG.Text}
                DC.GROUPEs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS GROUPE PRESTATION")
                AfficheG()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS GROUPE PRESTATION")
            End Try

        End If
    End Sub

    Private Sub btndelG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelG.Click
        If txtcodeG.Text = "" And txtintituleG.Text = "" And txtdesigG.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS GROUPE PRESTATION")
        Else
            Try

                Dim soc = (From serv In DC.GROUPEs Select serv Where serv.CODE_GR = DGV6.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.GROUPEs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS  GROUPE PRESTATION")
                AfficheG()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS  GROUPE PRESTATION")
            End Try

        End If
    End Sub

    Private Sub KryptonButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton23.Click
        Me.Close()
    End Sub


    Private Sub DGV6_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV6.SelectionChanged
        If DGV6.SelectedRows.Count > 0 Then
            btnSaveG.Enabled = False
            txtcodeG.Text = DGV6.SelectedRows(0).Cells(0).Value
            CombPG.SelectedItem = DGV6.SelectedRows(0).Cells(1).Value
            txtintituleG.Text = DGV6.SelectedRows(0).Cells(2).Value
            txtdesigG.Text = DGV6.SelectedRows(0).Cells(3).Value
        End If
    End Sub
    Private Sub DGV6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV6.LostFocus
        btnSaveG.Enabled = True
    End Sub
    Public Sub AfficheG()
        Dim query2 = From elt In DC.GROUPEs Select New With {.CODE = elt.CODE_GR.Trim, .ACTE_PRESTATION = elt.ACTE_PRESTATION.INTUTLE_PRES, .INTITULE = elt.INTITULE, .DESIGNATION = elt.DESIGNATION}
        DGV6.DataSource = query2.ToList
    End Sub
#End Region


    Private Sub btnMod_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Select Case TabC1.SelectedIndex
            Case Is = 0

            Case Is = 1

            Case Is = 2

            Case Is = 3

            Case Is = 4

            Case Is = 5

            Case Is = 6

        End Select
    End Sub

    Private Sub btnEnr_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnr.Click
        Select Case TabC1.SelectedIndex
            Case Is = 0

            Case Is = 1

            Case Is = 2

            Case Is = 3

            Case Is = 4

            Case Is = 5

            Case Is = 6

        End Select
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        Select Case TabC1.SelectedIndex
            Case Is = 0

            Case Is = 1

            Case Is = 2

            Case Is = 3

            Case Is = 4

            Case Is = 5

            Case Is = 6

        End Select
    End Sub
End Class

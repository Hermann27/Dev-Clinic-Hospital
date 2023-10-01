Public Class Formulaire_DossiersMedical
    Dim DC As New DCDataContext
    '------------dossiers medical variable-------------------
    Dim ValeurCodeOrd As String
    Dim ValeurCodePers As String
    Dim ValeurCodePatient As String
    '-------------variable visite medical---------------
    Dim ValeurCodeDM As Integer
    Dim ValeurCodeMEDECIN As String
    Dim ValeurCodeAP As String
    '--------------------variable medicament prescris------------
    Dim ValeurCodePat As String
    Dim ValeurCodeMEDICAMENT As String
    '---------------------variable ordonance-------
    Dim ValeurCodeMEDECINOdr As String
    '--------------------variable medicament prescris------------
    Dim ValeurCodePatients As String
    Dim ValeurCodeMED5 As String
    '-------------------------------------------------------------
    Private Sub btnEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnr.Click
        Select Case TabControl1.SelectedIndex
            Case Is = 0
                If txtobser.Text = "" And CombAP.SelectedItem = "" And Combmedecin.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS VISITE")
                Else
                    Try

                        Dim Soc As New VISITE() With {.NUMERO_DOSSIER = ValeurCodeDM, _
                                                      .CODE_PERS = ValeurCodeMEDECIN, _
                                                      .CODE_PRES = ValeurCodeAP, _
                                                      .DATE_VISITE = datevisite.Value, _
                                                      .OBSERVATION = txtobservO.Text _
                                                     }
                        DC.VISITEs.InsertOnSubmit(Soc)
                        DC.SubmitChanges()
                        MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS VISITE")
                        Affiche()
                    Catch ex As Exception
                        MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS VISITE")
                    End Try

                End If
            Case Is = 1
                If txtqtite.Text = "" And Combpat.SelectedItem = "" And Combmedicament.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                Else
                    Try

                        Dim Soc As New CONSOMMER() With {.CODE_PAT = ValeurCodePat, _
                                                         .CODE_MEC = ValeurCodeMEDICAMENT, _
                                                         .DATE_CONSO = datemedicamprescr.Value, _
                                                         .QTE_CONSO = txtqtite.Text _
                                                        }
                        DC.CONSOMMERs.InsertOnSubmit(Soc)
                        DC.SubmitChanges()
                        MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                        AfficheMP()
                    Catch ex As Exception
                        MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                    End Try

                End If
            Case Is = 2
                If txtcode.Text = "" And txtobservO.Text = "" And CombordM.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                Else
                    Try

                        Dim Soc As New ORDONANCE() With {.CODE_ORD = txtcode.Text, _
                                                         .CODE_PERS = ValeurCodeMEDECINOdr, _
                                                         .DATE_ORD = dateord.Value, _
                                                         .DETAIL_ORD = txtobservO.Text _
                                                        }
                        DC.ORDONANCEs.InsertOnSubmit(Soc)
                        DC.SubmitChanges()
                        MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                        AfficheO()

                    Catch ex As Exception
                        MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                    End Try

                End If
            Case Is = 3
                If txtref.Text = "" And Combpatient.SelectedItem = "" And Combmed.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                Else
                    Try

                        Dim Soc As New DOSSIER_MEDICALE() With {.CODE_ORD = CombCodOrd.SelectedItem.ToString, _
                                                                .CODE_PERS = ValeurCodeMED5, _
                                                                .CODE_PAT = ValeurCodePatients, _
                                                                .ANNEE = datedossier.Value, _
                                                                .NUMEROREF = txtref.Text _
                                                               }
                        DC.DOSSIER_MEDICALEs.InsertOnSubmit(Soc)
                        DC.SubmitChanges()
                        MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS  DOSSIERS MEDICAL")
                        AfficheDM()

                    Catch ex As Exception
                        MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS  DOSSIERS MEDICAL")
                    End Try

                End If
        End Select
    End Sub
   
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Select Case TabControl1.SelectedIndex
            Case Is = 0
                If txtobser.Text = "" And CombAP.SelectedItem = "" And Combmedecin.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS VISITE")
                Else
                    Try
                        Dim serv = (From ser In DC.VISITEs Select ser Where ser.NUMERO_AUTO = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                        serv.NUMERO_DOSSIER = ValeurCodeDM
                        serv.CODE_PERS = ValeurCodeMEDECIN
                        serv.CODE_PRES = ValeurCodeAP
                        serv.DATE_VISITE = datevisite.Value
                        serv.OBSERVATION = txtobser.Text
                        DC.SubmitChanges()
                        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS VISITE")
                        Affiche()

                    Catch ex As Exception
                        MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS VISITE")
                    End Try
                End If
            Case Is = 1
                If txtqtite.Text = "" And Combpat.SelectedItem = "" And Combmedicament.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                Else
                    Try
                        Dim serv = (From ser In DC.CONSOMMERs Select ser Where ser.CODE_PAT = ValeurCodePat).Single()
                        serv.CODE_MEC = ValeurCodeMEDICAMENT
                        serv.DATE_CONSO = datemedicamprescr.Value
                        serv.QTE_CONSO = txtqtite.Text
                        DC.SubmitChanges()
                        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                        AfficheMP()
                    Catch ex As Exception
                        MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                    End Try
                End If
            Case Is = 2
                If txtcode.Text = "" And txtobservO.Text = "" And CombordM.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                Else
                    Try
                        Dim serv = (From ser In DC.ORDONANCEs Select ser Where ser.CODE_ORD = txtcode.Text).Single()
                        serv.CODE_PERS = ValeurCodeMEDECINOdr
                        serv.DATE_ORD = dateord.Value
                        serv.DETAIL_ORD = txtobservO.Text
                        DC.SubmitChanges()
                        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                        AfficheO()

                    Catch ex As Exception
                        MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                    End Try

                End If
            Case Is = 3
                If txtref.Text = "" And Combpatient.SelectedItem = "" And Combmed.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                Else
                    Try
                        Dim serv = (From ser In DC.DOSSIER_MEDICALEs Select ser Where ser.NUMERO_DOSSIER = CInt(DGV3.SelectedRows(0).Cells(0).Value)).Single()
                        serv.CODE_ORD = CombCodOrd.SelectedItem.ToString
                        serv.CODE_PERS = ValeurCodeMED5
                        serv.CODE_PAT = ValeurCodePatients
                        serv.ANNEE = datedossier.Value
                        serv.NUMEROREF = txtref.Text
                        DC.SubmitChanges()
                        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS  DOSSIERS MEDICAL")
                        AfficheDM()
                    Catch ex As Exception
                        MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS  DOSSIERS MEDICAL")
                    End Try

                End If
        End Select
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        Select Case TabControl1.SelectedIndex
            Case Is = 0
                If txtobser.Text = "" And CombAP.SelectedItem = "" And Combmedecin.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS VISITE")
                Else
                    Try
                        Dim soc = (From serv In DC.VISITEs Select serv Where serv.NUMERO_AUTO = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                        DC.VISITEs.DeleteOnSubmit(soc)
                        DC.SubmitChanges()
                        MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS VISITE")
                        Affiche()
                    Catch ex As Exception
                        MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS VISITE")
                    End Try

                End If

            Case Is = 1
                If txtqtite.Text = "" And Combpat.SelectedItem = "" And Combmedicament.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICAL")
                Else
                    Try
                        Dim soc = (From serv In DC.CONSOMMERs Select serv Where serv.CODE_PAT = ValeurCodePat).Single()
                        DC.CONSOMMERs.DeleteOnSubmit(soc)
                        DC.SubmitChanges()
                        MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICAL")
                        AfficheMP()
                    Catch ex As Exception
                        MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICAL")
                    End Try

                End If

            Case Is = 2
                If txtcode.Text = "" And txtobservO.Text = "" And CombordM.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                Else
                    Try
                        Dim soc = (From serv In DC.ORDONANCEs Select serv Where serv.CODE_ORD = txtcode.Text).Single()
                        DC.ORDONANCEs.DeleteOnSubmit(soc)
                        DC.SubmitChanges()
                        MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                        AfficheO()
                    Catch ex As Exception
                        MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                    End Try

                End If

            Case Is = 3
                If txtref.Text = "" And Combpatient.SelectedItem = "" And Combmed.SelectedItem = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                Else
                    Try
                        MsgBox(DGV3.SelectedRows(0).Cells(0).Value)
                        Dim soc = (From serv In DC.DOSSIER_MEDICALEs Select serv Where serv.NUMERO_DOSSIER = CInt(DGV3.SelectedRows(0).Cells(0).Value)).Single()
                        DC.DOSSIER_MEDICALEs.DeleteOnSubmit(soc)
                        DC.SubmitChanges()
                        MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                        AfficheDM()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        ' MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                    End Try

                End If

        End Select
    End Sub
    Public Sub Affiche()
        Dim query2 = From elt In DC.VISITEs Select New With {.IDENTIFICATION = elt.NUMERO_AUTO, _
                                                             .REFERENCE_DOSSIERS = elt.DOSSIER_MEDICALE.NUMEROREF, _
                                                             .MEDECIN = elt.PERSONNEL_SOIGNANT.NOM_PERS, _
                                                             .ACTE_PRESTATION = elt.ACTE_PRESTATION.INTUTLE_PRES, _
                                                             .DATE_VISITE = elt.DATE_VISITE, _
                                                             .OBSERVATION_MEDECIN = elt.OBSERVATION _
                                                            }
        DGV.DataSource = query2.ToList
    End Sub
    Public Sub AfficheMP()
         Dim query2 = From elt In DC.CONSOMMERs Select New With {.PATIENT = elt.PATIENT.NOM, _
                                                               .NOM_MEDICAMENT = elt.PHARMACIE.NOM_MEC, _
                                                               .DATE_CONSOMMATION = elt.DATE_CONSO, _
                                                               .QUANTITE = elt.QTE_CONSO _
                                                              }
        DGV1.DataSource = query2.ToList
    End Sub
    Public Sub AfficheO()
        Dim query2 = From elt In DC.ORDONANCEs Select New With {.CODE = elt.CODE_ORD, _
                                                                .MEDECIN = elt.PERSONNEL_SOIGNANT.NOM_PERS, _
                                                                .DATE_DELIVRANCE = elt.DATE_ORD, _
                                                                .DETAILLE_ORDONANCE = elt.DETAIL_ORD _
                                                               }
        DGV2.DataSource = query2.ToList
    End Sub
    Public Sub AfficheDM()
        Dim query2 = From elt In DC.DOSSIER_MEDICALEs Select New With {.IDENTIFICATION = elt.NUMERO_DOSSIER, _
                                                             .ORDONANCE = elt.CODE_ORD.Trim, _
                                                             .MEDECIN = elt.PERSONNEL_SOIGNANT.NOM_PERS, _
                                                             .PATIENT = elt.PATIENT.NOM, _
                                                             .DATE_OUVERTURE_DOSSIERS = elt.ANNEE, _
                                                             .REFERENCE = elt.NUMEROREF _
                                                            }
        DGV3.DataSource = query2.ToList
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            'txtcodeG.Text = DGV6.SelectedRows(0).Cells(0).Value
            'CombPG.SelectedItem = DGV6.SelectedRows(0).Cells(1).Value
            'txtintituleG.Text = DGV6.SelectedRows(0).Cells(2).Value
            'txtdesigG.Text = DGV6.SelectedRows(0).Cells(3).Value
        End If
    End Sub

    Private Sub DGV1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV1.SelectionChanged
        If DGV1.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            'txtcodeG.Text = DGV6.SelectedRows(0).Cells(0).Value
            'CombPG.SelectedItem = DGV6.SelectedRows(0).Cells(1).Value
            'txtintituleG.Text = DGV6.SelectedRows(0).Cells(2).Value
            'txtdesigG.Text = DGV6.SelectedRows(0).Cells(3).Value
        End If
    End Sub
    Private Sub DGV2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV2.SelectionChanged
        If DGV2.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            'txtcodeG.Text = DGV6.SelectedRows(0).Cells(0).Value
            'CombPG.SelectedItem = DGV6.SelectedRows(0).Cells(1).Value
            'txtintituleG.Text = DGV6.SelectedRows(0).Cells(2).Value
            'txtdesigG.Text = DGV6.SelectedRows(0).Cells(3).Value
        End If
    End Sub
    Private Sub DGV3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV3.SelectionChanged
        If DGV3.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            'txtcodeG.Text = DGV6.SelectedRows(0).Cells(0).Value
            'CombPG.SelectedItem = DGV6.SelectedRows(0).Cells(1).Value
            'txtintituleG.Text = DGV6.SelectedRows(0).Cells(2).Value
            'txtdesigG.Text = DGV6.SelectedRows(0).Cells(3).Value
        End If
    End Sub


    Private Sub DGV3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV3.LostFocus
        btnEnr.Enabled = True
    End Sub

    Private Sub DGV2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV2.LostFocus
        btnEnr.Enabled = True
    End Sub

    Private Sub DGV1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV1.LostFocus
        btnEnr.Enabled = True
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnEnr.Enabled = True
    End Sub
   
    Private Sub Formulaire_DossiersMedical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VISITE CHARGEMENT COMBOBOX ---------------------
        Dim QueryP = From elt In DC.PERSONNEL_SOIGNANTs _
                   Select elt.NOM_PERS
        Combmedecin.DataSource = QueryP.ToList

        Dim QueryDM = From elt In DC.DOSSIER_MEDICALEs _
                  Select elt.NUMEROREF Distinct
        Combdocmed.DataSource = QueryDM.ToList

        Dim QueryAP = From elt In DC.ACTE_PRESTATIONs _
                  Select elt.INTUTLE_PRES
        CombAP.DataSource = QueryAP.ToList
        '-----------------------MEDICAMENT PRESCRIS---------
        Dim QueryPat = From elt In DC.PATIENTs _
                  Select elt.NOM Distinct
        Combpat.DataSource = QueryPat.ToList

        Dim QueryM = From elt In DC.PHARMACIEs _
                 Select elt.NOM_MEC Distinct
        Combmedicament.DataSource = QueryM.ToList
        '------------------------ORDONANCE---------
        Dim QueryPERS = From elt In DC.PERSONNEL_SOIGNANTs _
                  Select elt.NOM_PERS
        CombordM.DataSource = QueryPERS.ToList

        '-----------------DOSSIERS MEDICAL CHARGEMENT COMBOBOX ---------------------
        Dim QueryPatient = From elt In DC.PATIENTs _
                   Select elt.NOM
        Combpatient.DataSource = QueryPatient.ToList

        Dim QueryMedecin = From elt In DC.PERSONNEL_SOIGNANTs _
                  Select elt.NOM_PERS Distinct
        Combmed.DataSource = QueryMedecin.ToList

        Dim QueryOrd = From elt In DC.ORDONANCEs _
                  Select elt.CODE_ORD
        CombCodOrd.DataSource = QueryOrd.ToList
        Affiche()
        AfficheDM()
        AfficheMP()
        AfficheO()

    End Sub

    Private Sub CombAP_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombAP.SelectedValueChanged
        Dim Query22 = From elt2 In DC.ACTE_PRESTATIONs _
                     Where elt2.INTUTLE_PRES = CombAP.SelectedItem.ToString _
                     Select elt2
        ValeurCodeAP = Query22.First.CODE_PRES
    End Sub
    
    Private Sub Combdocmed_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combdocmed.SelectedValueChanged
        Dim Query22 = From elt2 In DC.DOSSIER_MEDICALEs _
                     Where elt2.NUMEROREF = Combdocmed.SelectedItem.ToString _
                     Select elt2
        ValeurCodeDM = Query22.First.NUMERO_DOSSIER
    End Sub

    Private Sub Combmedecin_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combmedecin.SelectedValueChanged
        Dim Query22 = From elt2 In DC.PERSONNEL_SOIGNANTs _
                    Where elt2.NOM_PERS = Combmedecin.SelectedItem.ToString _
                    Select elt2
        ValeurCodeMEDECIN = Query22.First.CODE_PERS
    End Sub
    
    Private Sub Combpat_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combpat.SelectedValueChanged
        Dim Query22 = From elt2 In DC.PATIENTs _
                    Where elt2.NOM = Combpat.SelectedItem.ToString _
                    Select elt2
        ValeurCodePat = Query22.First.CODE_PAT
    End Sub

    Private Sub Combmedicament_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combmedicament.SelectedValueChanged
        Dim Query22 = From elt2 In DC.PHARMACIEs _
                            Where elt2.NOM_MEC = Combmedicament.SelectedItem.ToString _
                            Select elt2
        ValeurCodeMEDICAMENT = Query22.First.CODE_MEC
    End Sub

    Private Sub CombordM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombordM.SelectedValueChanged
        Dim Query22 = From elt2 In DC.PERSONNEL_SOIGNANTs _
                    Where elt2.NOM_PERS = CombordM.SelectedItem.ToString _
                    Select elt2
        ValeurCodeMEDECINOdr = Query22.First.CODE_PERS
    End Sub

    Private Sub Combpatient_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combpatient.SelectedValueChanged
        Dim Query22 = From elt2 In DC.PATIENTs _
                    Where elt2.NOM = Combpat.SelectedItem.ToString _
                    Select elt2
        ValeurCodePatients = Query22.First.CODE_PAT
    End Sub

    Private Sub Combmed_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combmed.SelectedValueChanged
        Dim Query22 = From elt2 In DC.PERSONNEL_SOIGNANTs _
                    Where elt2.NOM_PERS = CombordM.SelectedItem.ToString _
                    Select elt2
        ValeurCodeMED5 = Query22.First.CODE_PERS
    End Sub

    Private Sub btnFer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFer.Click
        Me.Close()
    End Sub

End Class

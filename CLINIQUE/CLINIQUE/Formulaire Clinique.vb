Imports System.Text.RegularExpressions.Regex
Public Class Formulaire_Clinique
    Dim DC As New DCDataContext
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Select Case TabControl1.SelectedIndex
            Case Is = 0
                If txtintitule.Text = "" And txtdesig.Text = "" And txtadresse.Text = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                Else
                    Try
                        Dim serv = (From ser In DC.DEPOT_MEDICAMENTs Select ser Where ser.ID_AUTO = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                        serv.INTITULE = txtintitule.Text
                        serv.ADRESSE = txtadresse.Text
                        serv.REGIONS = txtregion.Text
                        serv.PAYS = txtpays.Text
                        serv.REPONSABLE = txtresp.Text
                        serv.TELEPHONE = txtphone.Text
                        serv.EMAIL = txtemail.Text
                        serv.DESIGNATION = txtdesig.Text
                        DC.SubmitChanges()
                        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                        Affiche()
                    Catch ex As Exception
                        MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                    End Try
                End If
            Case Is = 1
                'If txtqtite.Text = "" And Combpat.SelectedItem = "" And Combmedicament.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                'Else
                '    Try
                '        Dim serv = (From ser In DC.CONSOMMERs Select ser Where ser.CODE_PAT = ValeurCodePat).Single()
                '        serv.CODE_MEC = ValeurCodeMEDICAMENT
                '        serv.DATE_CONSO = datemedicamprescr.Value
                '        serv.QTE_CONSO = txtqtite.Text
                '        DC.SubmitChanges()
                '        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                '        AfficheMP()
                '    Catch ex As Exception
                '        MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                '    End Try
                'End If
            Case Is = 2
                'If txtcode.Text = "" And txtobservO.Text = "" And CombordM.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                'Else
                '    Try
                '        Dim serv = (From ser In DC.ORDONANCEs Select ser Where ser.CODE_ORD = txtcode.Text).Single()
                '        serv.CODE_PERS = ValeurCodeMEDECINOdr
                '        serv.DATE_ORD = dateord.Value
                '        serv.DETAIL_ORD = txtobservO.Text
                '        DC.SubmitChanges()
                '        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                '        AfficheO()

                '    Catch ex As Exception
                '        MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                '    End Try

                'End If
            Case Is = 3
                'If txtref.Text = "" And Combpatient.SelectedItem = "" And Combmed.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                'Else
                '    Try
                '        Dim serv = (From ser In DC.DOSSIER_MEDICALEs Select ser Where ser.NUMERO_DOSSIER = CInt(DGV3.SelectedRows(0).Cells(0).Value)).Single()
                '        serv.CODE_ORD = CombCodOrd.SelectedItem.ToString
                '        serv.CODE_PERS = ValeurCodeMED5
                '        serv.CODE_PAT = ValeurCodePatients
                '        serv.ANNEE = datedossier.Value
                '        serv.NUMEROREF = txtref.Text
                '        DC.SubmitChanges()
                '        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS  DOSSIERS MEDICAL")
                '        AfficheDM()
                '    Catch ex As Exception
                '        MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS  DOSSIERS MEDICAL")
                '    End Try

                'End If
        End Select
    End Sub

    Private Sub btnEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnr.Click
        Select Case TabControl1.SelectedIndex
            Case Is = 0
                If txtintitule.Text = "" And txtdesig.Text = "" And txtadresse.Text = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                Else

                    Try
                        If System.Text.RegularExpressions.Regex.IsMatch(txtemail.Text, "^(\w{1,12})@([a-z]{1,5})\.([a-z]{1,3})$") = True And System.Text.RegularExpressions.Regex.IsMatch(txtphone.Text, "^([-_/ ]?[0-9]{2}){4}$") = True Then


                            Dim depot As New DEPOT_MEDICAMENT() With {.INTITULE = txtintitule.Text, _
                                                                      .ADRESSE = txtadresse.Text, _
                                                                      .REGIONS = txtregion.Text, _
                                                                      .PAYS = txtpays.Text, _
                                                                      .REPONSABLE = txtresp.Text, _
                                                                      .TELEPHONE = txtphone.Text, _
                                                                      .EMAIL = txtemail.Text, _
                                                                      .DESIGNATION = txtdesig.Text _
                                                         }
                            DC.DEPOT_MEDICAMENTs.InsertOnSubmit(depot)
                            DC.SubmitChanges()
                            MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                            Affiche()
                        Else
                            MsgBox("Email ou Format Telephone invalide --> " & txtemail.Text, MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                        End If
                    Catch ex As Exception
                        MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                    End Try

                End If
            Case Is = 1
                'If txtqtite.Text = "" And Combpat.SelectedItem = "" And Combmedicament.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                'Else
                '    Try

                '        Dim Soc As New CONSOMMER() With {.CODE_PAT = ValeurCodePat, _
                '                                         .CODE_MEC = ValeurCodeMEDICAMENT, _
                '                                         .DATE_CONSO = datemedicamprescr.Value, _
                '                                         .QTE_CONSO = txtqtite.Text _
                '                                        }
                '        DC.CONSOMMERs.InsertOnSubmit(Soc)
                '        DC.SubmitChanges()
                '        MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                '        AfficheMP()
                '    Catch ex As Exception
                '        MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICALE")
                '    End Try

                'End If
            Case Is = 2
                'If txtcode.Text = "" And txtobservO.Text = "" And CombordM.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                'Else
                '    Try

                '        Dim Soc As New ORDONANCE() With {.CODE_ORD = txtcode.Text, _
                '                                         .CODE_PERS = ValeurCodeMEDECINOdr, _
                '                                         .DATE_ORD = dateord.Value, _
                '                                         .DETAIL_ORD = txtobservO.Text _
                '                                        }
                '        DC.ORDONANCEs.InsertOnSubmit(Soc)
                '        DC.SubmitChanges()
                '        MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                '        AfficheO()

                '    Catch ex As Exception
                '        MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                '    End Try

                'End If
            Case Is = 3
                'If txtref.Text = "" And Combpatient.SelectedItem = "" And Combmed.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                'Else
                '    Try

                '        Dim Soc As New DOSSIER_MEDICALE() With {.CODE_ORD = CombCodOrd.SelectedItem.ToString, _
                '                                                .CODE_PERS = ValeurCodeMED5, _
                '                                                .CODE_PAT = ValeurCodePatients, _
                '                                                .ANNEE = datedossier.Value, _
                '                                                .NUMEROREF = txtref.Text _
                '                                               }
                '        DC.DOSSIER_MEDICALEs.InsertOnSubmit(Soc)
                '        DC.SubmitChanges()
                '        MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS  DOSSIERS MEDICAL")
                '        AfficheDM()

                '    Catch ex As Exception
                '        MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS  DOSSIERS MEDICAL")
                '    End Try

                'End If
        End Select
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        Select Case TabControl1.SelectedIndex
            Case Is = 0
                If txtintitule.Text = "" And txtdesig.Text = "" And txtadresse.Text = "" Then
                    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                Else
                    Try
                        Dim depot = (From serv In DC.DEPOT_MEDICAMENTs Select serv Where serv.ID_AUTO = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                        DC.DEPOT_MEDICAMENTs.DeleteOnSubmit(depot)
                        DC.SubmitChanges()
                        MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                        Affiche()
                    Catch ex As Exception
                        MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS DEPOT MEDICAMENTS")
                    End Try

                End If

            Case Is = 1
                'If txtqtite.Text = "" And Combpat.SelectedItem = "" And Combmedicament.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICAL")
                'Else
                '    Try
                '        Dim soc = (From serv In DC.CONSOMMERs Select serv Where serv.CODE_PAT = ValeurCodePat).Single()
                '        DC.CONSOMMERs.DeleteOnSubmit(soc)
                '        DC.SubmitChanges()
                '        MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICAL")
                '        AfficheMP()
                '    Catch ex As Exception
                '        MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS PRESCRIPTION MEDICAL")
                '    End Try

                'End If

            Case Is = 2
                'If txtcode.Text = "" And txtobservO.Text = "" And CombordM.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                'Else
                '    Try
                '        Dim soc = (From serv In DC.ORDONANCEs Select serv Where serv.CODE_ORD = txtcode.Text).Single()
                '        DC.ORDONANCEs.DeleteOnSubmit(soc)
                '        DC.SubmitChanges()
                '        MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                '        AfficheO()
                '    Catch ex As Exception
                '        MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS ORDONANCE")
                '    End Try

                'End If

            Case Is = 3
                'If txtref.Text = "" And Combpatient.SelectedItem = "" And Combmed.SelectedItem = "" Then
                '    MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                'Else
                '    Try
                '        MsgBox(DGV3.SelectedRows(0).Cells(0).Value)
                '        Dim soc = (From serv In DC.DOSSIER_MEDICALEs Select serv Where serv.NUMERO_DOSSIER = CInt(DGV3.SelectedRows(0).Cells(0).Value)).Single()
                '        DC.DOSSIER_MEDICALEs.DeleteOnSubmit(soc)
                '        DC.SubmitChanges()
                '        MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                '        AfficheDM()
                '    Catch ex As Exception
                '        MsgBox(ex.Message)
                '        ' MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS DOSSIERS MEDICAL")
                '    End Try

                'End If

        End Select
    End Sub

    Private Sub btnFer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFer.Click
        Me.Close()
    End Sub
    Public Sub Affiche()

        Dim query2 = From elt In DC.DEPOT_MEDICAMENTs Select New With {.IDENTIFICATION = elt.ID_AUTO, _
                                                             .INTITULE = elt.INTITULE, _
                                                             .ADRESSE = elt.ADRESSE, _
                                                             .REGIONS = elt.REGIONS, _
                                                             .PAYS = elt.PAYS, _
                                                                       .REPONSABLE = elt.REPONSABLE, _
                                                                       .TELEPHONE = elt.TELEPHONE, _
                                                                       .EMAIL = elt.EMAIL, _
                                                                       .DESIGNATION = elt.DESIGNATION _
                                                            }
        DGV.DataSource = query2.ToList
    End Sub

    Private Sub Formulaire_Clinique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Affiche()
    End Sub
End Class

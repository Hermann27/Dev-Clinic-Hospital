Imports System.Security.Cryptography
Imports System.Data.SqlClient
Public Class Authentification
    Dim Compte As String
    Dim pseudo As String
    Dim DC As New DCDataContext
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Using md5Hash As MD5 = MD5.Create
            Dim hash As String = Cryptage.GetMd5Hash(md5Hash, txtpass.Text)
            Dim QueryC = From elt In DC.UTILISATEURs _
                         Where elt.LOGIN = txtlogin.Text.ToString And elt.PASSWORD = hash.ToString _
                         Select elt

            If QueryC.Count = 0 Then
                MsgBox("Utilisateur n'existe pas :)", MsgBoxStyle.Information, "Infos Authentification")
            Else
                Try
                    Compte = QueryC.FirstOrDefault.PRIVILEGE.ToString
                    pseudo = QueryC.FirstOrDefault.PERSONNEL_SOIGNANT.NOM_PERS.ToString
                    If Compte.Trim  = "ADMIN" Then
                        With MDIParent1
                            Select Case Now.Hour
                                Case Is <= 12
                                    .user.Text = "Bonjour  " & pseudo
                                Case Is <= 14
                                    .user.Text = "Bon Après Midi  " & pseudo
                                Case Is <= 24
                                    .user.Text = "Bonsoir  " & pseudo
                            End Select
                            .btdossim.Enabled = True
                            .bthosp.Enabled = True
                            .btncons.Enabled = True
                            .btnimp.Enabled = True
                            .btnm.Enabled = True
                            .btnr.Enabled = True
                            .btpa.Enabled = True
                            .tpat.Enabled = True
                            .med.Enabled = True
                            .dossier.Enabled = True
                            .cons.Enabled = True
                            .hosp.Enabled = True
                            .imp.Enabled = True
                            .rech.Enabled = True
                            .FileMenu.Enabled = True
                            .EditMenu.Enabled = True
                            .GesMenu.Enabled = True
                            .RapMenu.Enabled = True
                            If .decon.Visible = False Then
                                .decon.Text = "Déconnexion"
                                .decon.Visible = True
                                .btndecon.Visible = True
                            End If
                            .Show()
                        End With
                        Me.Close()
                    ElseIf Compte.Trim = "User" Then
                        With MDIParent1
                            Select Case Now.Hour
                                Case Is <= 12
                                    .user.Text = "Bonjour  " & pseudo
                                Case Is <= 14
                                    .user.Text = "Bon Après Midi  " & pseudo
                                Case Is <= 24
                                    .user.Text = "Bonsoir  " & pseudo
                            End Select
                            .btdossim.Enabled = True
                            .bthosp.Enabled = True
                            .btncons.Enabled = True
                            .btnimp.Enabled = True
                            .btnm.Enabled = True
                            .btnr.Enabled = True
                            .btpa.Enabled = True
                            .tpat.Enabled = True
                            .med.Enabled = True
                            .dossier.Enabled = True
                            .cons.Enabled = True
                            .hosp.Enabled = True
                            .imp.Enabled = True
                            .rech.Enabled = True
                            .FileMenu.Enabled = True
                            .EditMenu.Enabled = True
                            .GesMenu.Enabled = True
                            .RapMenu.Enabled = True
                            If .decon.Visible = False Then
                                .decon.Text = "Déconnexion"
                                .decon.Visible = True
                                .btndecon.Visible = True
                            End If
                            .Show()
                        End With
                        Me.Close()
                    Else
                        MsgBox("Login  or Mot de passe Incorrect :)", MsgBoxStyle.Information, "Infos Authentification")
                    End If

                Catch ex As Exception
                    MsgBox("valeur incorrect pleace try again :)", MsgBoxStyle.Information, "Infos Authentification")
                End Try
            End If
           
        End Using
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        With MDIParent1
            If .decon.Visible = False Then
                .decon.Text = "Connexion"
                .decon.Visible = True
                .btndecon.Visible = True
            End If
            .Show()
        End With
        Me.Close()

    End Sub
End Class

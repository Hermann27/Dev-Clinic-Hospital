Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient
Public Class FormUser
    Dim DC As New DCDataContext
    Private Sub ch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch.CheckedChanged
        If ch.Checked = True Then
            groupbx.Visible = True
        Else
            groupbx.Visible = False
        End If
    End Sub

    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Query = From elt In DC.PERSONNEL_SOIGNANTs _
                    Select elt.NOM_PERS
        ComboPersonnel.DataSource = Query.ToList
        Affiche()
    End Sub
    Dim valeurCodeP As String
    Private Sub ComboPersonnel_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboPersonnel.SelectedValueChanged
        Dim Query2 = From elt2 In DC.PERSONNEL_SOIGNANTs _
                        Where elt2.NOM_PERS = ComboPersonnel.SelectedItem.ToString _
                        Select elt2
        valeurCodeP = Query2.First.CODE_PERS
    End Sub

    Private Sub btnaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaj.Click

        If txtlogin.Text = "" And txtpass.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "Infos Connexion")
        Else
            If txtpass.Text.Equals(txtconf.Text) Then
                Try

                    Using md5Hash As MD5 = MD5.Create()

                        Dim hash As String = Cryptage.GetMd5Hash(md5Hash, txtpass.Text)

                        Dim user As New UTILISATEUR() With {.LOGIN = txtlogin.Text, .PASSWORD = hash, .CODE_PERS = valeurCodeP, .PRIVILEGE = Combopri.SelectedItem.ToString}
                        DC.UTILISATEURs.InsertOnSubmit(user)
                        DC.SubmitChanges()
                        MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
                        Affiche()
                    End Using
                Catch ex As Exception
                    MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
                End Try
            Else
                MsgBox("VOTRE MOT DE PASSE NE SON PAS IDENTIQUE:)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
            End If
        End If
    End Sub

    Private Sub btncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncl.Click
        Me.Close()
    End Sub

    Private Sub btnup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnup.Click
        If txtlogin.Text = "" And txtpass.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "Infos Connexion")
        Else
            If txtpass.Text.Equals(txtconf.Text) Then
                Try

                    Using md5Hash As MD5 = MD5.Create()
                        Dim hash2 As String = Cryptage.GetMd5Hash(md5Hash, txtpass.Text)
                        Dim UserUP = (From use In DC.UTILISATEURs Select use Where use.LOGIN = txtlogin.Text).Single()
                        'UserUP.LOGIN = txtlogin.Text
                        UserUP.PASSWORD = hash2
                        UserUP.PRIVILEGE = Combopri.SelectedItem.ToString
                        UserUP.CODE_PERS = valeurCodeP
                        DC.SubmitChanges()
                        MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
                        Affiche()
                    End Using
                Catch ex As Exception
                    MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
                End Try
            Else
                MsgBox("VOTRE MOT DE PASSE NE SON PAS IDENTIQUE:)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
            End If
        End If
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If txtlogin.Text = "" And txtpass.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "Infos Connexion")
        Else
            If txtpass.Text.Equals(txtconf.Text) Then
                Try
                    Dim UserUP = (From use In DC.UTILISATEURs Select use Where use.LOGIN = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                    DC.UTILISATEURs.DeleteOnSubmit(UserUP)
                    DC.SubmitChanges()
                    MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
                    Affiche()
                Catch ex As Exception
                    MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
                End Try
            Else
                MsgBox("VOTRE MOT DE PASSE NE SON PAS IDENTIQUE:)", MsgBoxStyle.Information, "INFOS AUTHENTICATION")
            End If
        End If
    End Sub

    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        txtlogin.Enabled = True
        btnaj.Enabled = True
    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtlogin.Enabled = False
            btnaj.Enabled = False
            txtlogin.Text = DGV.SelectedRows(0).Cells(0).Value
            ComboPersonnel.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            Combopri.SelectedValue = DGV.SelectedRows(0).Cells(2).Value
        End If
    End Sub

    Public Sub Affiche()
        Dim query2 = From elt In DC.UTILISATEURs Select New With {.Login = elt.LOGIN, .Personnel = elt.PERSONNEL_SOIGNANT.NOM_PERS, .PRIVILEGE = elt.PRIVILEGE}
        DGV.DataSource = query2.ToList
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim r = From ee In DC.UTILISATEURs Where ee.LOGIN.Contains(txtsearch.Text) Or ee.PRIVILEGE.Contains(txtsearch.Text) Or ee.PERSONNEL_SOIGNANT.NOM_PERS.Contains(txtsearch.Text) Select ee.LOGIN, ee.PERSONNEL_SOIGNANT.NOM_PERS, ee.PRIVILEGE
        DGV.DataSource = r.ToList
    End Sub

End Class

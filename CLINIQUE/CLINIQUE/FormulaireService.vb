Public Class FormulaireService
    Dim DC As New DCDataContext
    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaj.Click
        If txtcode.Text = "" And txtdesig.Text = "" And txtintitule.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SERVICE")
        Else
            Try

                Dim service As New SERVICE() With {.CODE_SERV = txtcode.Text, .INTITULE = txtintitule.Text, .OBSERVATION = txtdesig.Text}
                DC.SERVICEs.InsertOnSubmit(service)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS SERVICE")
                Affiche()

            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS SERVICE")
            End Try

        End If
    End Sub

    Private Sub FormulaireService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Affiche()
    End Sub
    Public Sub Affiche()
        Dim query2 = From elt In DC.SERVICEs Select New With {.CODE = elt.CODE_SERV.Trim, .INTITULE = elt.INTITULE, .OBSERVATION = elt.OBSERVATION}
        DGV.DataSource = query2.ToList
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUP.Click

        If txtcode.Text = "" And txtdesig.Text = "" And txtintitule.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SERINFOS SERVICE ")
        Else
            Try
                Dim serv = (From ser In DC.SERVICEs Select ser Where ser.CODE_SERV = txtcode.Text).Single()
                serv.INTITULE = txtintitule.Text
                serv.OBSERVATION = txtdesig.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS SERVICE")
                Affiche()

            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS SERVICE")
            End Try

        End If
    End Sub

    Private Sub KryptonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub KryptonButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If txtcode.Text = "" And txtdesig.Text = "" And txtintitule.Text = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS SERVICE")
        Else
            Try
                Dim ser = (From serv In DC.SERVICEs Select serv Where serv.CODE_SERV = DGV.SelectedRows(0).Cells(0).Value.ToString).Single()
                DC.SERVICEs.DeleteOnSubmit(ser)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS SERVICE")
                Affiche()

            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS SERVICE")
            End Try

        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        txtcode.Enabled = True
        btnaj.Enabled = True
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtcode.Enabled = False
            btnaj.Enabled = False
            txtcode.Text = DGV.SelectedRows(0).Cells(0).Value
            txtintitule.Text = DGV.SelectedRows(0).Cells(1).Value
            txtdesig.Text = DGV.SelectedRows(0).Cells(2).Value
        End If
    End Sub
End Class

Public Class Formulaire_Examens
    Dim DC As New DCDataContext
    Private Sub btnFer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFer.Click
        Me.Close()
    End Sub

    Private Sub btnEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnr.Click
        If txtcode.Text = "" And txtprixExam.Text = "" And CombtypeExam.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS EXAMENS")
        Else
            
            Try

                Dim Soc As New EXAMEN() With {.CODE_EXAM = txtcode.Text, _
                                             .TYPE_EXAM = CombtypeExam.SelectedItem.ToString, _
                                             .PRIX_EXAM = txtprixExam.Text _
                                            }
                DC.EXAMENs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS EXAMENS")
                Affiche()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS EXAMENS")
                'MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Public Sub Affiche()
        Dim r = From ee In DC.EXAMENs Select New With {.CODE = ee.CODE_EXAM.Trim, _
                                                            .TYPE_EXAMENS = ee.TYPE_EXAM.Trim, _
                                                            .FRAIS_EXAMENS = ee.PRIX_EXAM _
                                                          }
        DGV.DataSource = r.ToList
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtcode.Text = "" And txtprixExam.Text = "" And CombtypeExam.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS EXAMENS")
        Else
            Try
                Dim serv = (From ser In DC.EXAMENs Select ser Where ser.CODE_EXAM = txtcode.Text).Single()
                serv.TYPE_EXAM = CombtypeExam.SelectedItem.ToString
                serv.PRIX_EXAM = txtprixExam.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS EXAMENS")
                Affiche()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS EXAMENS")
            End Try
        End If
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If txtcode.Text = "" And txtprixExam.Text = "" And CombtypeExam.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS EXAMENS")
        Else
            Try
                Dim soc = (From serv In DC.EXAMENs Select serv Where serv.CODE_EXAM = txtcode.Text).Single()
                DC.EXAMENs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS EXAMENS")
                Affiche()
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS EXAMENS")
            End Try

        End If
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnEnr.Enabled = False
            txtcode.Enabled = False
            txtcode.Text = DGV.SelectedRows(0).Cells(0).Value
            CombtypeExam.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            txtprixExam.Text = DGV.SelectedRows(0).Cells(2).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnEnr.Enabled = True
        txtcode.Enabled = True
    End Sub

    Private Sub Formulaire_Examens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Affiche()
    End Sub
End Class

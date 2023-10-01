Public Class Formulair_Laboratoire
    Dim DC As New DCDataContext
    Dim ValeurCodeDM As Integer
    Dim ValeurCodeE As String
    Private Sub Formulair_Laboratoire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VISITE CHARGEMENT COMBOBOX ---------------------
        Dim QueryDM = From elt In DC.DOSSIER_MEDICALEs _
                   Select elt.NUMEROREF
        CombDP.DataSource = QueryDM.ToList

        Dim QueryE = From elt In DC.EXAMENs _
                  Select elt.TYPE_EXAM Distinct
        CombExam.DataSource = QueryE.ToList
        Affiche()
    End Sub

    Private Sub CombDP_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombDP.SelectedValueChanged
        Dim Query2 = From elt In DC.DOSSIER_MEDICALEs _
                   Where elt.NUMEROREF = CombDP.SelectedItem.ToString _
                   Select elt
        ValeurCodeDM = Query2.First.NUMERO_DOSSIER
    End Sub

    Private Sub CombExam_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombExam.SelectedValueChanged
        Dim Query2 = From elt In DC.EXAMENs _
                           Where elt.TYPE_EXAM = CombExam.SelectedItem.ToString _
                           Select elt
        ValeurCodeE = Query2.First.CODE_EXAM
    End Sub

    Private Sub btnEn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEn.Click
        If txtcode.Text = "" And CombDP.SelectedItem = "" And CombExam.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
        Else
            Try

                Dim Soc As New LABORATOIRE() With {.CODE_EXAM = ValeurCodeE, _
                                                   .NUMERO_DOSSIER = ValeurCodeDM, _
                                                   .DATE_LB = datelab.Value, _
                                                   .OBSERVATION = txtdesig.Text _
                                                  }
                DC.LABORATOIREs.InsertOnSubmit(Soc)
                DC.SubmitChanges()
                MsgBox("Enregistrement Reussi :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
                Affiche()
            Catch ex As Exception
                MsgBox("Erreur de manipulation :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
            End Try

        End If
    End Sub
    Public Sub Affiche()
        Dim r = From ee In DC.LABORATOIREs Select New With {.IDENTIFIANT = ee.ID, _
                                                           .TYPE_EXAMENS = ee.EXAMEN.TYPE_EXAM.Trim, _
                                                           .DATE_EXAMENS_LABORATOIRE = ee.DATE_LB, _
                                                           .REFERENCE_DOSSIER_MEDICAL = ee.DOSSIER_MEDICALE.NUMEROREF, _
                                                           .OBSERVATION = ee.OBSERVATION _
                                                         }
        DGV.DataSource = r.ToList
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtcode.Text = "" And CombDP.SelectedItem = "" And CombExam.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
        Else
            Try
                Dim serv = (From ser In DC.LABORATOIREs Select ser Where ser.ID = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                serv.CODE_EXAM = ValeurCodeE
                serv.NUMERO_DOSSIER = ValeurCodeDM
                serv.DATE_LB = datelab.Value
                serv.OBSERVATION = txtdesig.Text
                DC.SubmitChanges()
                MsgBox("Modification Reussi :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
                Affiche()
            Catch ex As Exception
                MsgBox("Modification Erroner  :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
            End Try
        End If
    End Sub

    Private Sub btnSu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSu.Click
        If txtcode.Text = "" And CombDP.SelectedItem = "" And CombExam.SelectedItem = "" Then
            MsgBox("Verifier les Champs de Votre Formulaire :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
        Else
            Try
                Dim soc = (From serv In DC.LABORATOIREs Select serv Where serv.ID = CInt(DGV.SelectedRows(0).Cells(0).Value)).Single()
                DC.LABORATOIREs.DeleteOnSubmit(soc)
                DC.SubmitChanges()
                MsgBox("Suppression Reussi :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
                Affiche()
            Catch ex As Exception
                MsgBox("Suppression Erroner  :)", MsgBoxStyle.Information, "INFOS LABORATOIRE")
            End Try

        End If
    End Sub
    Private Sub DGV_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            btnEn.Enabled = False
            txtcode.Enabled = False
            ' txtcode.Text = DGV.SelectedRows(0).Cells(0).Value
            CombExam.SelectedItem = DGV.SelectedRows(0).Cells(1).Value
            CombDP.SelectedItem = DGV.SelectedRows(0).Cells(3).Value
            txtdesig.Text = DGV.SelectedRows(0).Cells(4).Value
        End If
    End Sub
    Private Sub DGV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.LostFocus
        btnEn.Enabled = True
        ' txtcode.Enabled = True
    End Sub

    Private Sub btnFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFe.Click
        Me.Close()
    End Sub

   
End Class

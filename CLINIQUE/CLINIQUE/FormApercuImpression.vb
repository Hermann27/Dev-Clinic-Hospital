Public Class FormApercuImpression
    Dim DC As New DCDataContext
    Private Sub btn_couper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_couper.Click
        Me.Close()
    End Sub

    Private Sub lst_table_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_table.SelectedValueChanged
        Select Case lst_table.SelectedItem
            Case "PATIENTS"
                AfficheP()
            Case "RENDEZ-VOUS"
                Affiche()
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""

        End Select
    End Sub
    Public Sub Affiche()
        Dim r = From ee In DC.RDVs Select New With {.IDENTIFIANT = ee.ID_AUTO, _
                                                    .PATIENT = ee.PATIENT.NOM.Trim, _
                                                    .MEDECIN = ee.PERSONNEL_SOIGNANT.NOM_PERS.Trim, _
                                                    .DATE_RDV = ee.DATE_RDV, _
                                                    .HEURE_RDV = ee.HEURE_RDV.Trim, _
                                                    .MODIF_RDV = ee.MODIF_RDV.Trim, _
                                                    .OBSERVATION = ee.OBSERVATION_RDV.Trim _
                                                   }
        DGV.DataSource = r.ToList
    End Sub
    Public Sub AfficheP()
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

    Private Sub btn_imprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimer.Click
        Select Case lst_table.SelectedItem
            Case "PATIENTS"

            Case "RENDEZ-VOUS"
                imprimerRDV()
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""
            Case ""

        End Select

    End Sub
    Public Sub imprimerRDV()
        Dim dt As New DataTable
        With dt
            .Columns.Add("IDENTIFIANT")
            .Columns.Add("PATIENT")
            .Columns.Add("MEDECIN")
            .Columns.Add("DATE_RDV")
            .Columns.Add("HEURE_RDV")
            .Columns.Add("MODIF_RDV")
            .Columns.Add("OBSERVATION")
        End With
        For Each dr As DataGridViewRow In Me.DGV.Rows
            dt.Rows.Add(dr.Cells("IDENTIFIANT").Value, dr.Cells("PATIENT").Value, dr.Cells("MEDECIN").Value, dr.Cells("DATE_RDV").Value, dr.Cells("HEURE_RDV").Value, dr.Cells("MODIF_RDV").Value, dr.Cells("OBSERVATION").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport3
        rptDoc.SetDataSource(dt)
        IMPRESSION.CrystalReportViewer1.ReportSource = rptDoc
        With IMPRESSION
            .IsMdiContainer = True
            .ShowDialog()
        End With
        'IMPRESSION.ShowDialog()
        IMPRESSION.Dispose()
    End Sub

    Private Sub txt_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Search.TextChanged
        Dim r = From ee In DC.RDVs Where ee.PERSONNEL_SOIGNANT.NOM_PERS.Contains(txt_Search.Text) Or ee.PATIENT.NOM.Contains(txt_Search.Text) Select New With {.IDENTIFIANT = ee.ID_AUTO, _
                                                                                                                                                             .PATIENT = ee.PATIENT.NOM.Trim, _
                                                                                                                                                             .MEDECIN = ee.PERSONNEL_SOIGNANT.NOM_PERS.Trim, _
                                                                                                                                                             .DATE_RDV = ee.DATE_RDV, _
                                                                                                                                                             .HEURE_RDV = ee.HEURE_RDV.Trim, _
                                                                                                                                                             .MODIF_RDV = ee.MODIF_RDV.Trim, _
                                                                                                                                                             .OBSERVATION = ee.OBSERVATION_RDV.Trim _
                                                                                                                                                            }
        DGV.DataSource = r.ToList
    End Sub
End Class

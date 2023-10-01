Public Class FormImpression
    Dim DC As New DCDataContext
    Private Sub FormImpression_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Affiche()
    End Sub
    Public Sub Affiche()
        Dim rr = From et In DC.PATIENTs, ey In DC.SOCIETEs, ei In DC.ASSURANCEs, dp In DC.DOSSIER_MEDICALEs _
                Where et.CODE = ey.CODE And et.CODE_PAT = dp.CODE_PAT _
                Select New With {
                                .SOCIETE = ey.NOM_SOC, _
                                .DateNaiss = et.DATE_NAISS, _
                                .RefDM = dp.NUMEROREF.Trim, _
                                .ASSURANCE = ei.NOM_ASS _
                                }
        DGV.DataSource = rr.ToList
    End Sub

    Private Sub btnapercu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnapercu.Click
        Dim dt As New DataTable
        With dt
            .Columns.Add("SOCIETE")
            .Columns.Add("DateNaiss")
            .Columns.Add("RefDM")
            .Columns.Add("ASSURANCE")
        End With
        For Each dr As DataGridViewRow In Me.DGV.Rows
            dt.Rows.Add(dr.Cells("SOCIETE").Value, dr.Cells("DateNaiss").Value, dr.Cells("RefDM").Value, dr.Cells("ASSURANCE").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport4
        rptDoc.SetDataSource(dt)
        IMPRESSION.CrystalReportViewer1.ReportSource = rptDoc
        IMPRESSION.ShowDialog()
        IMPRESSION.Dispose()

    End Sub
End Class

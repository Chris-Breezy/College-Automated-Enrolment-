Public Class SectionFrm

    Private Sub TblSectionBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblSectionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSectionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub SectionFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblSemester' table. You can move, or remove it, as needed.
        Me.TblSemesterTableAdapter.Fill(Me.MstDataSet.tblSemester)
        'TODO: This line of code loads data into the 'MstDataSet.tblSchoolYear' table. You can move, or remove it, as needed.
        Me.TblSchoolYearTableAdapter.Fill(Me.MstDataSet.tblSchoolYear)
        'TODO: This line of code loads data into the 'MstDataSet.tblCourse' table. You can move, or remove it, as needed.
        Me.TblCourseTableAdapter.Fill(Me.MstDataSet.tblCourse)
        'TODO: This line of code loads data into the 'MstDataSet.tblSection' table. You can move, or remove it, as needed.
        Me.TblSectionTableAdapter.Fill(Me.MstDataSet.tblSection)

        Call totSec()
    End Sub
    Private Sub totSec()
        Dim i As Integer = 0
        For i = 0 To TblSectionDataGridView.Rows.Count - 1 Step +1
        Next
        lTots.Text = "Total Sections:" & i
    End Sub
End Class
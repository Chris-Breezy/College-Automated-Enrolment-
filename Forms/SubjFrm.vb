Public Class SubjFrm

    Private Sub TblSubjectBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblSubjectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSubjectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub SubjFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblCourse' table. You can move, or remove it, as needed.
        Me.TblCourseTableAdapter.Fill(Me.MstDataSet.tblCourse)
        'TODO: This line of code loads data into the 'MstDataSet.tblSubject' table. You can move, or remove it, as needed.
        Me.TblSubjectTableAdapter.Fill(Me.MstDataSet.tblSubject)

        Call totSub()
    End Sub

    Private Sub TblSubjectBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblSubjectBindingNavigator.RefreshItems

    End Sub
    Private Sub totSub()
        Dim i As Integer = 0
        For i = 0 To TblSubjectDataGridView.Rows.Count - 1 Step +1
        Next
        lTots.Text = "Total Subjects:" & i
    End Sub
End Class
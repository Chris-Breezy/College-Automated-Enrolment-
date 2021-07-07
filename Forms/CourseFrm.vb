Public Class CourseFrm

    Private Sub TblCourseBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblCourseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCourseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub CourseFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblDepartment' table. You can move, or remove it, as needed.
        Me.TblDepartmentTableAdapter.Fill(Me.MstDataSet.tblDepartment)
        'TODO: This line of code loads data into the 'SkolDBFDataSet.tblDepartment' table. You can move, or remove it, as needed.
        'Me.TblDepartmentTableAdapter.Fill(Me.SkolDBFDataSet.tblDepartment)
        'TODO: This line of code loads data into the 'MstDataSet.tblCourse' table. You can move, or remove it, as needed.
        Me.TblCourseTableAdapter.Fill(Me.MstDataSet.tblCourse)


    End Sub

    Private Sub TblCourseDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblCourseDataGridView.CellContentClick

    End Sub
End Class
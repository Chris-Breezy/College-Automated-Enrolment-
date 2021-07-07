Public Class TeacherFrm

    Private Sub TblTeacherBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblTeacherBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTeacherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub TeacherFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblDepartment' table. You can move, or remove it, as needed.
        Me.TblDepartmentTableAdapter.Fill(Me.MstDataSet.tblDepartment)
        'TODO: This line of code loads data into the 'MstDataSet.tblTeacher' table. You can move, or remove it, as needed.
        Me.TblTeacherTableAdapter.Fill(Me.MstDataSet.tblTeacher)

    End Sub
End Class
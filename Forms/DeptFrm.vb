Public Class DeptFrm

    Private Sub TblDepartmentBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblDepartmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblDepartmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub DeptFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblDepartment' table. You can move, or remove it, as needed.
        Me.TblDepartmentTableAdapter.Fill(Me.MstDataSet.tblDepartment)

    End Sub
End Class
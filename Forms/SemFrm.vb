Public Class SemFrm

    Private Sub TblSemesterBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblSemesterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSemesterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub SemFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblSemester' table. You can move, or remove it, as needed.
        Me.TblSemesterTableAdapter.Fill(Me.MstDataSet.tblSemester)

    End Sub
End Class
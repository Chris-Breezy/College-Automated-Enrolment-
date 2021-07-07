Public Class SchoolYear

    Private Sub TblSchoolYearBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblSchoolYearBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSchoolYearBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub SchoolYear_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblSchoolYear' table. You can move, or remove it, as needed.
        Me.TblSchoolYearTableAdapter.Fill(Me.MstDataSet.tblSchoolYear)

    End Sub
End Class
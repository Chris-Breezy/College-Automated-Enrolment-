Public Class ProspectusFrm

    Private Sub TblProspectusBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblProspectusBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblProspectusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub ProspectusFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblSemester' table. You can move, or remove it, as needed.
        Me.TblSemesterTableAdapter.Fill(Me.MstDataSet.tblSemester)
        'TODO: This line of code loads data into the 'MstDataSet.tblCourse' table. You can move, or remove it, as needed.
        Me.TblCourseTableAdapter.Fill(Me.MstDataSet.tblCourse)
        'TODO: This line of code loads data into the 'MstDataSet.tblSubject' table. You can move, or remove it, as needed.
        Me.TblSubjectTableAdapter.Fill(Me.MstDataSet.tblSubject)
        'TODO: This line of code loads data into the 'MstDataSet.tblProspectus' table. You can move, or remove it, as needed.
        Me.TblProspectusTableAdapter.Fill(Me.MstDataSet.tblProspectus)

    End Sub

    Private Sub TblProspectusDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblProspectusDataGridView.CellContentClick

    End Sub
End Class
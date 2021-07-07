Public Class Student_Information

    Private Sub TblStudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblStudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblStudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)

    End Sub

    Private Sub Student_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.MstDataSet.tblStudent)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
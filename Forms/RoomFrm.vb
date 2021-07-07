Public Class RoomFrm

    Private Sub TblRoomBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblRoomBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRoomBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

    End Sub

    Private Sub RoomFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblRoom' table. You can move, or remove it, as needed.
        Me.TblRoomTableAdapter.Fill(Me.MstDataSet.tblRoom)

    End Sub
End Class
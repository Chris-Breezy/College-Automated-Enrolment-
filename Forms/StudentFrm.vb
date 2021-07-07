Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration.ConfigurationSettings

Public Class StudentFrm

    Dim con As New OleDbConnection
    Dim conStr As String = EnrollSys.My.Settings.SkolDBFConnectionString.ToString
    Dim lodfrm As Boolean

    Private Sub TblStudentBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblStudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblStudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)

    End Sub

    Private Sub StudentFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet1.tblCourse' table. You can move, or remove it, as needed.
        'Me.TblCourseTableAdapter.Fill(Me.MstDataSet1.tblCourse)
        'TODO: This line of code loads data into the 'MstDataSet1.tblStudent' table. You can move, or remove it, as needed.
        'Me.TblStudentTableAdapter.Fill(Me.MstDataSet1.tblStudent)
        'TODO: This line of code loads data into the 'MstDataSet.tblCourse' table. You can move, or remove it, as needed.
        Me.TblCourseTableAdapter.Fill(Me.MstDataSet.tblCourse)
        'TODO: This line of code loads data into the 'MstDataSet.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.MstDataSet.tblStudent)

        'Call List_Course()

    End Sub
    Private Sub List_Course()

        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = "Select CourseID,Course  From tblCourse ORDER BY Course "

        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Cors")
            con.Close()
            CourseIDComboBox.DataSource = ds.Tables(0)
            CourseIDComboBox.DisplayMember = "Course"
            CourseIDComboBox.ValueMember = "CourseID"
            CourseIDComboBox.SelectedValue = "CourseID"
            'If ds.Tables(0).Rows.Count > 0 Then
            '    CourseIDComboBox.SelectedValue = ds.Tables(0).Rows(0).Item("CourseID")
            'End If

        Catch ex As Exception
            MsgBox("error..Course..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub bFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFind.Click
        On Error GoTo SearchErr

        If tFind.Text = "" Then
            'Call notFound()
            Exit Sub

        Else

            Dim cantFind As String = tFind.Text
            'Me.dgvFill()

            TblStudentBindingSource.Filter = "(Convert(StudentID, 'System.String') LIKE '%" & tFind.Text & "%')" & _
            "OR (Convert(FirstName, 'System.String') LIKE '%" & tFind.Text & "%') OR (MiddleName LIKE '%" & tFind.Text & "%')" & _
            "OR (LastName LIKE '%" & tFind.Text & "%')"
            If TblStudentBindingSource.Count <> 0 Then
                With TblStudentDataGridView
                    .DataSource = TblStudentBindingSource
                End With

            Else

                'Me.notFound()

                MsgBox("--> " & cantFind & vbNewLine & _
                       "The search item was not found.", _
                       MsgBoxStyle.Information, "Hoy JOBERT!")

                TblStudentBindingSource.Filter = Nothing

                With TblStudentDataGridView
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = TblStudentBindingSource
                End With

            End If

        End If
ErrExit:
        Exit Sub
SearchErr:
        MsgBox("Error Number " & Err.Number & vbNewLine & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error?")
        Resume ErrExit
    End Sub

    Private Sub bClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        On Error GoTo ErrRe
        tFind.Select()
        TblStudentBindingSource.Filter = Nothing

        With TblStudentDataGridView
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = TblStudentBindingSource
        End With

        Me.reset()

ErrEx:
        Exit Sub
ErrRe:
        MsgBox("Error Number " & Err.Number & vbNewLine & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrEx
    End Sub
    Private Sub reset()
        Dim txtS As TextBox = tFind
        With txtS
            .Text = ""
            .Select()
        End With

        If TblStudentDataGridView.DataSource Is Nothing Then
            Exit Sub

        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TblStudentBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblStudentBindingNavigator.RefreshItems

    End Sub
End Class
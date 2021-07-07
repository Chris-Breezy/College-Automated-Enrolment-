Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration.ConfigurationSettings

Public Class ScheduleFrm
    Dim con As New OleDbConnection
    Dim conStr As String = EnrollSys.My.Settings.SkolDBFConnectionString.ToString
    Dim lodfrm As Boolean
    Dim s_Error As String = ""

    Private Sub TblSchoolYearBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TblSchoolYearBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)

    End Sub

    Private Sub ScheduleFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblTeacher' table. You can move, or remove it, as needed.
        Me.TblTeacherTableAdapter.Fill(Me.MstDataSet.tblTeacher)
        'TODO: This line of code loads data into the 'MstDataSet.tblRoom' table. You can move, or remove it, as needed.
        Me.TblRoomTableAdapter.Fill(Me.MstDataSet.tblRoom)
        'TODO: This line of code loads data into the 'MstDataSet1.tblSubject' table. You can move, or remove it, as needed.
        Me.TblSubjectTableAdapter.Fill(Me.MstDataSet1.tblSubject)
        'TODO: This line of code loads data into the 'MstDataSet.tblSection' table. You can move, or remove it, as needed.
        Me.TblSectionTableAdapter.Fill(Me.MstDataSet.tblSection)
        'TODO: This line of code loads data into the 'MstDataSet.tblSubjectOffering' table. You can move, or remove it, as needed.
        Me.TblSubjectOfferingTableAdapter.Fill(Me.MstDataSet.tblSubjectOffering)
        'TODO: This line of code loads data into the 'MstDataSet.tblSemester' table. You can move, or remove it, as needed.
        Me.TblSemesterTableAdapter.Fill(Me.MstDataSet.tblSemester)
        'TODO: This line of code loads data into the 'MstDataSet.tblCourse' table. You can move, or remove it, as needed.
        Me.TblCourseTableAdapter.Fill(Me.MstDataSet.tblCourse)
        'TODO: This line of code loads data into the 'MstDataSet.tblSchoolYear' table. You can move, or remove it, as needed.
        Me.TblSchoolYearTableAdapter.Fill(Me.MstDataSet.tblSchoolYear)

        lodfrm = True
        cbLvl.SelectedIndex = 0
        Call GetSem()
        Call GetTerm()
        Call GetCourse()
        Call GetSection()
        Call GetSubj()
        'Call GetTeach()
        Call getAllOffer()
        lodfrm = False
    End Sub

    Private Sub GetSection()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr


        Dim sql As String = "Select * From tblSection Where trim(CourseID)='" & Trim(cbCourse.SelectedValue) & "' AND " &
                            " trim(SchoolYear)='" & Trim(SchoolYearComboBox.SelectedValue) & "' AND SemesterID='" & Trim(cbSem.SelectedValue) & "' " &
                            " AND LevelYear=" & Val(cbLvl.Text)
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Secs")
            con.Close()
            cbSec.DataSource = ds.Tables(0)
            cbSec.DisplayMember = "SectionTitle"
            cbSec.ValueMember = "SectionID"
        Catch ex As Exception
            MsgBox("error..Section..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub

    Function CkDupSubjOferID() As Boolean
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr


        Dim sql As String = "Select * From tblSubjectOffering Where trim(SubjectOfferingID)='" & Trim(tCode.Text) &
                            "' AND trim(SubjectOfferingID)<>'" & Trim(tCode.Tag) & "' "
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Ck")
            con.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("Duplicate Subject Offer ID...")
                tCode.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("error..Ck_SubjOffer..." & ex.Message)
            con.Close()
            Return False
        Finally
            con.Close()
        End Try

    End Function

    Function ckTimeConflict() As Boolean
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim LessTimeIn As String = DateAdd(DateInterval.Minute, -1, dpTimeIn.Value)
        Dim AddTimeOut As String = DateAdd(DateInterval.Minute, 1, dpTimeOut.Value)

        Dim sql As String = "Select * From tblSubjectOffering " &
                            " Where TimeIn Between " & LessTimeIn & " AND " & AddTimeOut & "  " &
                            " AND trim(SubjectOfferingID)<>'" & Trim(tCode.Tag) & "' AND Trim(Terms)=' " & Trim(cbTerm.Text) & "'"
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "CkTime")
            con.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                'MsgBox("Duplicate Subject Offer ID...")
                'tCode.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("error..Ck_Time..." & ex.Message)
            con.Close()
            Return False
        Finally
            con.Close()
        End Try

    End Function


    Private Sub GetSubj()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = "Select SubjectID,SubjectTitle,CourseID,LevelYear From tblSubject " &
                            " Where trim(CourseID)='" & Trim(cbCourse.SelectedValue) & "' AND LevelYear=" & Val(cbLvl.Text)
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Subj")
            con.Close()
            cbSubj.DataSource = ds.Tables(0)
            cbSubj.DisplayMember = "SubjectTitle"
            cbSubj.ValueMember = "SubjectID"

        Catch ex As Exception
            MsgBox("error..Subj..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub GetSem()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = "Select Semester,SemesterID From tblSemester ORDER BY Semester "

        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Sems")
            con.Close()
            cbSem.DataSource = ds.Tables(0)
            cbSem.DisplayMember = "Semester"
            cbSem.ValueMember = "SemesterID"

        Catch ex As Exception
            MsgBox("error..Semester..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub GetTerm()
        cbTerm.Items.Clear()
        If cbSem.SelectedValue = "Sem-3" Then
            cbTerm.Items.Add("Summer")
        Else
            cbTerm.Items.Add("1st")
            cbTerm.Items.Add("2nd")
        End If
        cbTerm.SelectedIndex = 0

    End Sub


    Private Sub GetCourse()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = "Select Course,CourseID From tblCourse ORDER BY Course "

        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Sems")
            con.Close()
            cbCourse.DataSource = ds.Tables(0)
            cbCourse.DisplayMember = "Course"
            cbCourse.ValueMember = "CourseID"

        Catch ex As Exception
            MsgBox("error..Semester..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub

    'Private Sub GetTeach()
    '    Dim ds As New DataSet
    '    Dim da As OleDb.OleDbDataAdapter
    '    con.ConnectionString = conStr

    '    Dim sql As String = "Select TeacherID, Lastname + ', ' + FirstName As Teachers From tblTeacher " &
    '                        " ORDER BY Lastname ASC "
    '    Try
    '        con.Open()
    '        da = New OleDb.OleDbDataAdapter(sql, con)
    '        ds.Clear()
    '        da.Fill(ds, "Teach")
    '        con.Close()
    '        cbTeach.DataSource = ds.Tables(0)
    '        cbTeach.DisplayMember = "Teachers"
    '        cbTeach.ValueMember = "TeacherID"

    '    Catch ex As Exception
    '        MsgBox("error..Teach..." & ex.Message)
    '        con.Close()
    '    Finally
    '        con.Close()
    '    End Try

    'End Sub


    Private Sub getAllOffer()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr


        'Dim sql As String = " SELECT SO.SubjectOfferingID, SO.SubjectID, SO.TimeIn, SO.TimeOut, SO.Days, SO.SectionID, SO.roomID, SO.MaxSlot, " &
        '                    " SO.TEacherID,[FirstName]+', '+[LastName] As Teachers " &
        '                    " From tblSubjectOffering SO " &
        '                    " LEFT JOIN tblTeacher t ON SO.TeacherID = t.TeacherID  " &
        '                    " Where Trim(SO.SectionID)='" & Trim(cbSec.SelectedValue) & "' "

        Dim sql As String = " SELECT SubjectOfferingID, SubjectID, TimeIn, TimeOut, Days, SectionID, roomID, MaxSlot,Terms " &
                            " From tblSubjectOffering " &
                            " Where Trim(SectionID)='" & Trim(cbSec.SelectedValue) & "' "

        ds.Clear()
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "SubjOffer")
            con.Close()
            gvDisp.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("error..alloffer..." & ex.Message)
            con.Close()
            Exit Sub
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub TotalSum()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = " SELECT tblSubjectOffering.SubjectOfferingID, tblSubject.SubjectTitle, Sum(tblSubject.Units) AS SumOfUnits " &
                            " FROM tblSubject INNER JOIN tblSubjectOffering ON tblSubject.SubjectID = tblSubjectOffering.SubjectID  " &
                            " WHERE Trim(SubjectOfferingID.SectionID)='" & Trim(cbSec.SelectedValue) & "'  " &
                            " GROUP BY tblSubjectOffering.SubjectOfferingID, tblSubject.SubjectTitle "

        'Dim sql As String = " SELECT s.SubjectOfferingID, s.SubjectID,SUM(t.UNITS) AS UNITS" &
        '                    " From tblSubjectOffering s " &
        '                    " LEFT JOIN tblSubject t ON s.SubjectID=t.s.SubjectID " &
        '                    " Where Trim(s.SectionID)='" & Trim(cbSec.SelectedValue) & "' GROUP BY s.SectionID "

        ds.Clear()
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "SubjTots")
            con.Close()
            lUnits.Text = ds.Tables(0).Rows(0).Item("SumOfUnits").value
        Catch ex As Exception
            MsgBox("error..TotUnit..." & ex.Message)
            con.Close()
            lUnits.Text = 0
            Exit Sub
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TotalSum()
        Exit Sub
        If ckTimeConflict() = False Then
            MsgBox("Conflict")
        Else
            MsgBox("OK")
        End If

        Exit Sub

        Dim LessTimeIn As String = DateAdd(DateInterval.Minute, -1, dpTimeIn.Value)
        Dim AddTimeOut As String = DateAdd(DateInterval.Minute, 1, dpTimeOut.Value)
        MsgBox(LessTimeIn & " - " & AddTimeOut)
        Exit Sub

        If dpTimeIn.Value.ToShortTimeString > dpTimeOut.Value.ToShortTimeString Then
            MsgBox("Dako")
        ElseIf dpTimeIn.Value.ToShortTimeString = dpTimeOut.Value.ToShortTimeString Then
            MsgBox("Pareho")
        Else
            MsgBox("Tama lang")
        End If
        MsgBox(dpTimeIn.Value.ToShortTimeString & " - " & dpTimeOut.Value.ToShortTimeString)
        'Call getAllOffer()
        'Call GetSubj()
        'MsgBox(dpTimeIn.Value.ToShortTimeString())

    End Sub

    Private Sub CourseComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCourse.SelectedIndexChanged
        If lodfrm = True Then
            Exit Sub
        End If
        Call GetSection()
        Call getAllOffer()
        Call GetSubj()
    End Sub

    Private Sub bAddSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAddSec.Click
        Dim oldSem, oldyr, oldcourse, oldlvl As String
        oldSem = cbSem.Text
        oldyr = SchoolYearComboBox.Text
        oldcourse = cbCourse.Text
        oldlvl = cbLvl.Text

        Dim frmSec As New SectionFrm
        frmSec.ShowDialog()
        Me.TblSectionTableAdapter.Fill(Me.MstDataSet.tblSection)
        Me.TblSubjectOfferingTableAdapter.Fill(Me.MstDataSet.tblSubjectOffering)
        Me.TblSemesterTableAdapter.Fill(Me.MstDataSet.tblSemester)
        Me.TblCourseTableAdapter.Fill(Me.MstDataSet.tblCourse)
        Me.TblSchoolYearTableAdapter.Fill(Me.MstDataSet.tblSchoolYear)
        lodfrm = True
        cbLvl.SelectedIndex = 0
        Call GetSection()
        Call GetSubj()
        'Call GetTeach()
        Call getAllOffer()

        cbSem.Text = oldSem
        SchoolYearComboBox.Text = oldyr
        cbCourse.Text = oldcourse
        cbLvl.Text = oldlvl


        lodfrm = False




        Call GetSection()
    End Sub

    Private Sub cbSec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSec.SelectedIndexChanged
        If lodfrm = True Then
            Exit Sub
        End If
        Call getAllOffer()
    End Sub

    Private Sub bNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNew.Click
        If bNew.Text = "New" Then
            bNew.Tag = 0
            tCode.Text = ""
            tCode.Tag = ""
            bNew.Text = "Save"
            bEdit.Text = "Cancel"
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            Panel2.Enabled = Not Panel2.Enabled
            tCode.Focus()

        ElseIf bNew.Text = "Save" Then
            If tCode.Text = Nothing Or cbSubj.Text = Nothing Or cbSec.Text = Nothing Then
                MsgBox("Incomplete Data Please Complete the Following : " + Chr(13) + "- Section " + Chr(13) + "- Subject Offering ID " + Chr(13) + "- Subject " + Chr(13) + "- Days")
                tCode.Focus()
                Exit Sub
            End If

            'Call GetDays()

            If GetTime() = True Then
                MsgBox(s_Error)
                tCode.Focus()
                Exit Sub
            End If

            'If GetDays() = True Then
            '    MsgBox(s_Error)
            '    tCode.Focus()
            '    Exit Sub
            'End If

            If dpTimeIn.Value.ToString("HH:mm:00") > dpTimeOut.Value.ToString("HH:mm:00") Then
                MsgBox("Invalid Time Start and Start End " + Chr(13) + "Time Start Must be Earlier than Start End ")
                Exit Sub
            End If
            If CkDupSubjOferID() = False Then
                Exit Sub
            End If

            If bNew.Tag = 0 Then
                Call SaveNew()
            Else
                Call SaveUpdate()
            End If

            bNew.Tag = 0
        End If
    End Sub

    Private Sub SaveNew()
        Dim ds As New DataSet
        'Dim da As OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand

        con.ConnectionString = conStr
        cmd.Connection = con

        cmd.CommandText = "INSERT INTO tblSubjectOffering(SubjectOfferingID,SubjectID,TimeIn,TimeOut,Days,SectionID,RoomID,MaxsLot,SchoolYear,SemesterID,LevelYear,Terms)  " &
                            " VALUES('" & tCode.Text.Trim & "','" & Trim(cbSubj.SelectedValue) & "','" &
                            dpTimeIn.Value.ToShortTimeString & "','" & dpTimeOut.Value.ToShortTimeString & "','" & UCase(tDays.Text).Trim & "','" &
                            Trim(cbSec.SelectedValue) & "','" & Trim(cbRoom.SelectedValue) & "'," & tSlot.Value & ",'" & Trim(SchoolYearComboBox.SelectedValue) & "','" &
                            Trim(cbSem.SelectedValue) & "'," & Val(cbLvl.Text) & ",'" &
                            Trim(cbTerm.Text) & "')"

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Successfully Save....")
            Call getAllOffer()

        Catch ex As Exception
            MsgBox("error...Insert..." & ex.Message)
            con.Close()
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            Panel2.Enabled = Not Panel2.Enabled
            Exit Sub
        Finally
            con.Close()
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            Panel2.Enabled = Not Panel2.Enabled
            bNew.Text = "New"
            bEdit.Text = "Edit"

        End Try

    End Sub

    Private Sub SaveUpdate()
        Dim ds As New DataSet
        Dim cmd As New OleDb.OleDbCommand

        con.ConnectionString = conStr
        cmd.Connection = con

        cmd.CommandText = "UPDATE tblSubjectOffering SET " &
                            " SubjectOfferingID='" & tCode.Text.Trim & "'," &
                            " SubjectID='" & Trim(cbSubj.SelectedValue) & "'," &
                            " TimeIn='" & dpTimeIn.Value.ToShortTimeString & "'," &
                            " TimeOut='" & dpTimeOut.Value.ToShortTimeString & "'," &
                            " Days='" & UCase(tDays.Text).Trim & "'," &
                            " SectionID='" & Trim(cbSec.SelectedValue) & "'," &
                            " RoomID='" & Trim(cbRoom.SelectedValue) & "'," &
                            " MaxsLot=" & tSlot.Value & "," &
                            " SchoolYear='" & Trim(SchoolYearComboBox.SelectedValue) & "'," &
                            " SemesterID='" & Trim(cbSem.SelectedValue) & "'," &
                            " LevelYear=" & Val(cbLvl.Text) & "," &
                            " Terms='" & Trim(cbTerm.Text) & "' " &
                            " WHERE SubjectOfferingID='" & tCode.Tag.Trim & "' "
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Call getAllOffer()

            MsgBox("Successfully Updated....")

        Catch ex As Exception
            MsgBox("error...Update..." & ex.Message)
            con.Close()
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            Panel2.Enabled = Not Panel2.Enabled
            Exit Sub
        Finally
            con.Close()
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            Panel2.Enabled = Not Panel2.Enabled
            bNew.Text = "New"
            bNew.Tag = 0
            bEdit.Text = "Edit"
        End Try

    End Sub

    Private Sub bEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEdit.Click
        If bNew.Text = "New" Then
            If gvDisp.Rows.Count = 0 Or tCode.Tag = Nothing Then
                MsgBox("Please Select Record or No to be Edited...")
                gvDisp.Focus()
                Exit Sub
            End If
            bNew.Tag = 1
            bNew.Text = "Save"
            bEdit.Text = "Cancel"
            Panel1.Visible = Not Panel1.Visible
            Panel2.Enabled = Not Panel2.Enabled
            bDel.Enabled = Not bDel.Enabled
        Else
            bNew.Tag = 0
            bNew.Text = "New"
            bEdit.Text = "Edit"
            Panel1.Visible = Not Panel1.Visible
            Panel2.Enabled = Not Panel2.Enabled
            bDel.Enabled = Not bDel.Enabled
        End If
    End Sub

    Private Sub cbLvl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLvl.SelectedIndexChanged

        If lodfrm = True Then
            Exit Sub
        End If
        Call GetSection()
        Call getAllOffer()
        Call GetSubj()

    End Sub

    Private Sub gvDisp_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvDisp.CellEnter
        gvDisp.Tag = e.RowIndex
        tCode.Text = gvDisp.Rows(e.RowIndex).Cells("SubjOffID").Value
        tCode.Tag = gvDisp.Rows(e.RowIndex).Cells("SubjOffID").Value
        cbSubj.SelectedValue = gvDisp.Rows(e.RowIndex).Cells("SubjectID").Value
        tSlot.Text = gvDisp.Rows(e.RowIndex).Cells("Maxslot").Value
        tDays.Text = gvDisp.Rows(e.RowIndex).Cells("Days").Value
        cbTerm.Text = If(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("Terms").Value), "", gvDisp.Rows(e.RowIndex).Cells("Terms").Value)
        cbRoom.SelectedValue = gvDisp.Rows(e.RowIndex).Cells("RoomID").Value
        dpTimeIn.CustomFormat = "hh:mm tt"
        dpTimeOut.CustomFormat = "hh:mm tt"
        dpTimeIn.Text = gvDisp.Rows(e.RowIndex).Cells("TimeIn").Value.ToString
        dpTimeOut.Text = gvDisp.Rows(e.RowIndex).Cells("TimeOut").Value.ToString
        'If IsDBNull(gvDisp.Rows(e.RowIndex).Cells("TeacherID").Value) Or gvDisp.Rows(e.RowIndex).Cells("TeacherID").Value = Nothing Then
        '    cbTeach.SelectedIndex = -1
        'Else
        '    cbTeach.SelectedValue = gvDisp.Rows(e.RowIndex).Cells("TeacherID").Value
        'End If66

    End Sub

    'Private Sub cbTeach_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
    '    If Keys.Delete Then
    '        cbTeach.SelectedIndex = -1
    '    End If
    'End Sub

    Private Sub bDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDel.Click
        If gvDisp.Rows.Count = 0 Or tCode.Tag = Nothing Then
            MsgBox("No Record Selected to be Deleted...")
            gvDisp.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Delete This Subject Offered?" + Chr(13) + tCode.Text + " - " + cbSubj.Text, "Delete...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim ds As New DataSet
            Dim cmd As New OleDb.OleDbCommand

            con.ConnectionString = conStr
            cmd.Connection = con

            cmd.CommandText = "DELETE FROM tblSubjectOffering " &
                                " WHERE SubjectOfferingID='" & tCode.Tag.Trim & "' "
            Try
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Successfully Updated....")
                Call getAllOffer()

            Catch ex As Exception
                MsgBox("error...Update..." & ex.Message)
                con.Close()
                'Panel1.Visible = Not Panel1.Visible
                'bDel.Enabled = Not bDel.Enabled
                'Panel2.Enabled = Not Panel2.Enabled
                Exit Sub
            Finally
                con.Close()
                'Panel1.Visible = Not Panel1.Visible
                'bDel.Enabled = Not bDel.Enabled
                'Panel2.Enabled = Not Panel2.Enabled
                bNew.Text = "New"
                bNew.Tag = 0
                bEdit.Text = "Edit"
            End Try
        End If

    End Sub

    Private Sub cbRoom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbRoom.KeyPress
        If Keys.Delete Then
            cbRoom.SelectedItem = -1
        End If
    End Sub

    Private Sub SchoolYearComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolYearComboBox.SelectedIndexChanged
        If lodfrm = True Then
            Exit Sub
        End If
        Call GetSection()
        Call getAllOffer()
        Call GetSubj()

    End Sub

    Private Sub SemesterComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSem.SelectedIndexChanged
        If lodfrm = True Then
            Exit Sub
        End If
        Call GetTerm()
        Call GetSection()
        Call getAllOffer()
        Call GetSubj()

    End Sub
    Function GetDays() As Boolean
        s_Error = ""
        Dim sIn As Date = dpTimeIn.Text
        Dim sOut As Date = dpTimeOut.Text
        Dim sCode As String = Trim(tCode.Text)
        Dim sTerms As String = Trim(UCase(cbTerm.Text))

        Dim gv_sIn As Date
        Dim gv_sOut As Date
        Dim s_Code As String
        Dim gv_Term As String
        Dim gvAdlaw As String

        Dim naa As Boolean = False
        Dim adlaw(6) As String
        Dim NaaTo As Boolean = False
        Dim nDays As Integer = 0

        Dim TheDays(6) As Boolean
        TheDays(0) = False
        TheDays(1) = False
        TheDays(2) = False
        TheDays(3) = False
        TheDays(4) = False
        TheDays(5) = False
        TheDays(6) = False

        '***Get Adlaw***
        Dim mgaADlaw As String = ""

        For d = 0 To Len(tDays.Text) - 1
            If Trim(UCase(tDays.Text)) = "M-F" Then
                TheDays(0) = True
                TheDays(1) = True
                TheDays(2) = True
                TheDays(3) = True
                TheDays(4) = True
                d = Len(tDays.Text) - 1
            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "M" Then
                TheDays(0) = True

            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "T" Then
                If UCase(Mid(tDays.Text, d + 1, 2)) = "TH" Then
                    TheDays(3) = True
                    d = d + 1
                Else
                    TheDays(1) = True
                End If

            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "W" Then
                TheDays(2) = True

            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "F" Then
                TheDays(4) = True

            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "S" Then
                If UCase(Mid(tDays.Text, d + 1, 3)) = "SAT" Then
                    TheDays(5) = True
                Else
                    TheDays(6) = True
                End If
                d = d + 2

            End If

        Next

        '***Get Data from GridView****

        For i = 0 To gvDisp.Rows.Count - 1
            Dim naaAdlaw As Boolean = False

            gv_sIn = gvDisp.Rows(i).Cells("TimeIn").Value
            gv_sOut = gvDisp.Rows(i).Cells("TimeOut").Value
            s_Code = gvDisp.Rows(i).Cells("SubjOffID").Value
            gvAdlaw = gvDisp.Rows(i).Cells("Days").Value
            gv_Term = Trim(UCase(gvDisp.Rows(i).Cells("Days").Value))

            Dim gvTheDays(6) As Boolean
            gvTheDays(0) = False
            gvTheDays(1) = False
            gvTheDays(2) = False
            gvTheDays(3) = False
            gvTheDays(4) = False
            gvTheDays(5) = False
            gvTheDays(6) = False

            naaAdlaw = False

            For d2 = 0 To Len(gvAdlaw) - 1

                If Trim(UCase(gvAdlaw)) = "M-F" Then
                    gvTheDays(0) = True
                    gvTheDays(1) = True
                    gvTheDays(2) = True
                    gvTheDays(3) = True
                    gvTheDays(4) = True
                    d2 = Len(gvAdlaw) - 1

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "M" Then
                    gvTheDays(0) = True

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "T" Then
                    If UCase(Mid(gvAdlaw, d2 + 1, 2)) = "TH" Then
                        gvTheDays(3) = True
                        d2 = d2 + 1
                    Else
                        gvTheDays(1) = True
                    End If

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "W" Then
                    gvTheDays(2) = True

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "F" Then
                    gvTheDays(4) = True

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "S" Then
                    If UCase(Mid(gvAdlaw, d2 + 1, 3)) = "SAT" Then
                        gvTheDays(5) = True
                    Else
                        gvTheDays(6) = True
                    End If
                    d2 = d2 + 2

                End If

            Next

            If TheDays(0) = True And gvTheDays(0) = True Then
                naaAdlaw = True

            ElseIf TheDays(1) = True And gvTheDays(1) = True Then
                naaAdlaw = True

            ElseIf TheDays(2) = True And gvTheDays(2) = True Then
                naaAdlaw = True

            ElseIf TheDays(3) = True And gvTheDays(3) = True Then
                naaAdlaw = True

            ElseIf TheDays(4) = True And gvTheDays(4) = True Then
                naaAdlaw = True

            ElseIf TheDays(5) = True And gvTheDays(5) = True Then
                naaAdlaw = True

            ElseIf TheDays(6) = True And gvTheDays(6) = True Then
                naaAdlaw = True
            End If

            '***Comparison

            If s_Code <> sCode And (gv_sIn.ToShortTimeString > sIn.ToShortTimeString And gv_sIn.ToShortTimeString < sOut.ToShortTimeString) _
                And naaAdlaw = True And sTerms = gv_Term Then

                naa = True
                s_Error = "Conflict with " & s_Code
            End If

            If s_Code <> sCode And (gv_sOut.ToShortTimeString > sIn.ToShortTimeString And gv_sOut.ToShortTimeString < sOut.ToShortTimeString) _
                And naaAdlaw = True And sTerms = gv_Term Then

                naa = True
                s_Error = "Conflict with " & s_Code
            End If

            If s_Code <> sCode And (sIn.ToShortTimeString > gv_sIn.ToShortTimeString And sIn.ToShortTimeString < gv_sOut.ToShortTimeString Or _
                                    sOut.ToShortTimeString > gv_sIn.ToShortTimeString And sOut.ToShortTimeString < gv_sOut.ToShortTimeString) _
                And naaAdlaw = True And sTerms = gv_Term Then

                naa = True
                s_Error = "Conflict with " & s_Code
            End If

            If s_Code <> sCode And _
                (gv_sIn.ToShortTimeString = sIn.ToShortTimeString Or _
                 gv_sIn.ToShortTimeString = sOut.ToShortTimeString Or _
                 gv_sOut.ToShortTimeString = sIn.ToShortTimeString And gv_sOut.ToShortTimeString = sOut.ToShortTimeString) And _
             naaAdlaw = True And sTerms = gv_Term Then

                naa = True
                s_Error = "Conflict with " & s_Code
            End If

            'MsgBox("GV - " & gv_sIn & " - " & gv_sOut & " Txt - " & sIn & " - " & sOut & " Code " & sCode & " - " & s_Code & " Unsa man " & naa _
            '       & " naadalwa=" & naaAdlaw)

            '            MsgBox(" MON=" & TheDays(0) & " TUE=" & TheDays(1) & " WED=" & TheDays(2) & " THU=" & TheDays(3) & " FRI=" & TheDays(4) & _
            '" SAT=" & TheDays(5) & " SUN=" & TheDays(6) & _
            '" MON=" & gvTheDays(0) & " TUE=" & gvTheDays(1) & " WED=" & gvTheDays(2) & " THU=" & gvTheDays(3) & " FRI=" & gvTheDays(4) & _
            '" SAT=" & gvTheDays(5) & " SUN=" & gvTheDays(6))
            '***************
        Next
        Return naa


    End Function

    Function GetTime() As Boolean
        s_Error = ""
        'Dim ds As New DataSet
        'Dim da As OleDb.OleDbDataAdapter
        'con.ConnectionString = conStr

        Dim sIn As Date = dpTimeIn.Text
        Dim sOut As Date = dpTimeOut.Text
        Dim sCode As String = Trim(tCode.Text)
        Dim sTerms As String = Trim(UCase(cbTerm.Text))

        'sIn = DateAdd(DateInterval.Minute, 1, sIn)
        'sOut = DateAdd(DateInterval.Minute, -1, sOut)


        Dim gv_sIn As Date
        Dim gv_sOut As Date
        Dim s_Code As String
        Dim gv_Term As String
        Dim gvAdlaw As String


        Dim naa As Boolean = False
        Dim adlaw(6) As String
        Dim NaaTo As Boolean = False
        Dim nDays As Integer = 0


        Dim TheDays(6) As Boolean
        TheDays(0) = False
        TheDays(1) = False
        TheDays(2) = False
        TheDays(3) = False
        TheDays(4) = False
        TheDays(5) = False
        TheDays(6) = False


        '***Get Adlaw***
        Dim mgaADlaw As String = ""


        For d = 0 To Len(tDays.Text) - 1
            If Trim(UCase(tDays.Text)) = "M-F" Then
                TheDays(0) = True
                TheDays(1) = True
                TheDays(2) = True
                TheDays(3) = True
                TheDays(4) = True
                d = Len(tDays.Text) - 1
            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "M" Then
                TheDays(0) = True

            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "T" Then
                If UCase(Mid(tDays.Text, d + 1, 2)) = "TH" Then
                    TheDays(3) = True
                    d = d + 1
                Else
                    TheDays(1) = True
                End If

            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "W" Then
                TheDays(2) = True

            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "F" Then
                TheDays(4) = True

            ElseIf UCase(Mid(tDays.Text, d + 1, 1)) = "S" Then
                If UCase(Mid(tDays.Text, d + 1, 3)) = "SAT" Then
                    TheDays(5) = True
                Else
                    TheDays(6) = True
                End If
                d = d + 2

            End If

        Next


        '***Get Data from GridView****

        For i = 0 To gvDisp.Rows.Count - 1
            Dim naaAdlaw As Boolean = False
            gv_sIn = gvDisp.Rows(i).Cells("TimeIn").Value
            gv_sOut = gvDisp.Rows(i).Cells("TimeOut").Value
            s_Code = gvDisp.Rows(i).Cells("SubjOffID").Value
            gvAdlaw = gvDisp.Rows(i).Cells("Days").Value
            gv_Term = Trim(UCase(gvDisp.Rows(i).Cells("Terms").Value))


            Dim gvTheDays(6) As Boolean
            gvTheDays(0) = False
            gvTheDays(1) = False
            gvTheDays(2) = False
            gvTheDays(3) = False
            gvTheDays(4) = False
            gvTheDays(5) = False
            gvTheDays(6) = False

            naaAdlaw = False

            For d2 = 0 To Len(gvAdlaw) - 1

                If Trim(UCase(gvAdlaw)) = "M-F" Then
                    gvTheDays(0) = True
                    gvTheDays(1) = True
                    gvTheDays(2) = True
                    gvTheDays(3) = True
                    gvTheDays(4) = True
                    d2 = Len(gvAdlaw) - 1

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "M" Then
                    gvTheDays(0) = True

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "T" Then
                    If UCase(Mid(gvAdlaw, d2 + 1, 2)) = "TH" Then
                        gvTheDays(3) = True
                        d2 = d2 + 1
                    Else
                        gvTheDays(1) = True
                    End If

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "W" Then
                    gvTheDays(2) = True

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "F" Then
                    gvTheDays(4) = True

                ElseIf UCase(Mid(gvAdlaw, d2 + 1, 1)) = "S" Then
                    If UCase(Mid(gvAdlaw, d2 + 1, 3)) = "SAT" Then
                        gvTheDays(5) = True
                    Else
                        gvTheDays(6) = True
                    End If
                    d2 = d2 + 2

                End If

            Next

            If TheDays(0) = True And gvTheDays(0) = True Then
                naaAdlaw = True

            ElseIf TheDays(1) = True And gvTheDays(1) = True Then
                naaAdlaw = True

            ElseIf TheDays(2) = True And gvTheDays(2) = True Then
                naaAdlaw = True

            ElseIf TheDays(3) = True And gvTheDays(3) = True Then
                naaAdlaw = True

            ElseIf TheDays(4) = True And gvTheDays(4) = True Then
                naaAdlaw = True

            ElseIf TheDays(5) = True And gvTheDays(5) = True Then
                naaAdlaw = True

            ElseIf TheDays(6) = True And gvTheDays(6) = True Then
                naaAdlaw = True
            End If


            '***Comparison
            If s_Code <> sCode And (gv_sIn.ToShortTimeString > sIn.ToShortTimeString And gv_sIn.ToShortTimeString < sOut.ToShortTimeString) _
               And naaAdlaw = True And sTerms = gv_Term Then

                naa = True
                s_Error = "Conflict with " & s_Code
            End If

            If s_Code <> sCode And (gv_sOut.ToShortTimeString > sIn.ToShortTimeString And gv_sOut.ToShortTimeString < sOut.ToShortTimeString) _
                And naaAdlaw = True And sTerms = gv_Term Then

                naa = True
                s_Error = "Conflict with " & s_Code
            End If

            If s_Code <> sCode And (sIn.ToShortTimeString > gv_sIn.ToShortTimeString And sIn.ToShortTimeString < gv_sOut.ToShortTimeString Or _
                                    sOut.ToShortTimeString > gv_sIn.ToShortTimeString And sOut.ToShortTimeString < gv_sOut.ToShortTimeString) _
                And naaAdlaw = True And sTerms = gv_Term Then

                naa = True
                s_Error = "Conflict with " & s_Code
            End If

            If s_Code <> sCode And _
                (gv_sIn.ToShortTimeString = sIn.ToShortTimeString Or _
                 gv_sIn.ToShortTimeString = sOut.ToShortTimeString Or _
                 gv_sOut.ToShortTimeString = sIn.ToShortTimeString And gv_sOut.ToShortTimeString = sOut.ToShortTimeString) And _
             naaAdlaw = True And sTerms = gv_Term Then

                naa = True
                s_Error = "Conflict with " & s_Code
            End If







            'If s_Code <> sCode And (gv_sIn.ToShortTimeString > sIn.ToShortTimeString And gv_sIn.ToShortTimeString < sOut.ToShortTimeString) Then
            '    naa = True
            'End If
            'If s_Code <> sCode And (gv_sOut.ToShortTimeString > sIn.ToShortTimeString And gv_sOut.ToShortTimeString < sOut.ToShortTimeString) Then
            '    naa = True
            'End If

            'If s_Code <> sCode And _
            '    (gv_sIn.ToShortTimeString = sIn.ToShortTimeString Or _
            '     gv_sIn.ToShortTimeString = sOut.ToShortTimeString Or _
            '     gv_sOut.ToShortTimeString = sIn.ToShortTimeString And gv_sOut.ToShortTimeString = sOut.ToShortTimeString) Then
            '    naa = True
            'End If

            'MsgBox("GV - " & gv_sIn & " - " & gv_sOut & " Txt - " & sIn & " - " & sOut & " Code " & sCode & " - " & s_Code & " Unsa man " & naa)

        Next
        Return naa

    End Function

    Private Sub gvDisp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvDisp.CellContentClick

    End Sub
End Class
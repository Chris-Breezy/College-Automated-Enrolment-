Imports System.IO
Imports System
Imports System.Net.Dns
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration.ConfigurationSettings

Imports Excel = Microsoft.Office.Interop.Excel

Public Class EnrollFrm
    Dim con As New OleDbConnection
    Dim conStr As String = EnrollSys.My.Settings.SkolDBFConnectionString.ToString
    Dim lodfrm As Boolean
    Dim s_Error As String = ""

    Private Sub TblSchoolYearBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TblSchoolYearBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MstDataSet)

    End Sub

    Private Sub EnrollFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.MstDataSet.tblStudent)
        'TODO: This line of code loads data into the 'MstDataSet.tblCourse' table. You can move, or remove it, as needed.
        Me.TblCourseTableAdapter.Fill(Me.MstDataSet.tblCourse)
        'TODO: This line of code loads data into the 'MstDataSet.tblSemester' table. You can move, or remove it, as needed.
        Me.TblSemesterTableAdapter.Fill(Me.MstDataSet.tblSemester)
        'TODO: This line of code loads data into the 'MstDataSet.tblSchoolYear' table. You can move, or remove it, as needed.
        Me.TblSchoolYearTableAdapter.Fill(Me.MstDataSet.tblSchoolYear)

        lodfrm = True
        If cbSem.SelectedValue = "Sem-3" Then
            cbTerm.Items.Add("All")
        Else
            cbTerm.Items.Add("All")
            cbTerm.Items.Add("1st")
            cbTerm.Items.Add("2nd")
        End If
        cbTerm.SelectedIndex = 0

        Call GetStudName()
        Call getAllOffer()
        Call GetSubjOffer()
        Call TotUnits()
        cbLvl.SelectedIndex = 0
        lodfrm = False

    End Sub

    Private Sub GetStudName()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = "Select StudentID,LastName +', ' +FirstName +' '+ MiddleName as Nym From tblStudent "
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Studs")
            con.Close()
            cbNym.DataSource = ds.Tables(0)
            cbNym.DisplayMember = "Nym"
            cbNym.ValueMember = "StudentID"

        Catch ex As Exception
            MsgBox("error..SName..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub DispStudName()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = "Select StudentID,LastName +', ' +FirstName +' '+ MiddleName as Nym From tblStudent " &
                            " WHERE trim(StudentID)='" & Trim(cbId.Text) & "'"
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Studs")
            con.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                cbNym.SelectedValue = ds.Tables(0).Rows(0).Item("StudentId")
            End If

        Catch ex As Exception
            MsgBox("error..SID..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub DispStudID()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = "Select StudentID,LastName +', ' +FirstName +' '+ MiddleName as Nym From tblStudent " &
                            " WHERE trim(StudentID)='" & Trim(cbNym.SelectedValue) & "'"

        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Studs")
            con.Close()
            cbId.SelectedValue = ds.Tables(0).Rows(0).Item("StudentId")

        Catch ex As Exception
            MsgBox("error..sName..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbId.SelectedIndexChanged
        If lodfrm = True Then
            Exit Sub
        End If
        Call DispStudName()
        Call getAllOffer()
    End Sub

    Private Sub cbNym_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbNym.SelectedIndexChanged
        If lodfrm = True Then
            Exit Sub
        End If
        Call DispStudID()
        Call getAllOffer()
    End Sub

    Private Sub bNew_Click(sender As System.Object, e As System.EventArgs) Handles bNew.Click
        If bNew.Text = "New" Then
            bNew.Tag = 0
            cbSubOferID.Text = ""
            cbSubOferID.Tag = 0
            bNew.Text = "Save"
            bEdit.Text = "Cancel"
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            Panel2.Enabled = Not cbSem.Enabled
            gvDisp.Enabled = Not gvDisp.Enabled
            cbTerm.SelectedIndex = 0
            Call Disp_AllSub()
            'Call getSubjDetails()
            cbSubOferID.Focus()

        ElseIf bNew.Text = "Save" Then
            If cbSubOferID.Text = Nothing Or cbSubOferID.SelectedIndex = -1 Then
                MsgBox("Please Select Subject Offer ID ")
                cbSubOferID.Focus()
                Exit Sub
            End If


            If GetDays() = True Then
                MsgBox(s_Error)
                cbSubOferID.Focus()
                Exit Sub
            End If

            'If GetTime() = True Then
            '    MsgBox("Conflict Time in Other Subject...")
            '    cbSubOferID.Focus()
            '    Exit Sub
            'End If

            If GetExistBubj() = True Then
                MsgBox("Subject Already Exist...")
                cbSubOferID.Focus()
                Exit Sub

            End If


            If bNew.Tag = 0 Then
                Call SaveNew()
            Else
                Call SaveUpdate()
            End If

            bNew.Tag = 0
            Panel2.Enabled = Not cbSem.Enabled
            gvDisp.Enabled = Not gvDisp.Enabled
        End If

    End Sub


    Private Sub SaveNew()
        Dim ds As New DataSet
        'Dim da As OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand

        con.ConnectionString = conStr
        cmd.Connection = con

        cmd.CommandText = "INSERT INTO tblEnrolment(StudentID,SubjectOfferingID,SchoolYear,SemesterID,CourseID,DateEnroled,Terms)  " &
                            " VALUES('" & cbId.Text.Trim & "','" & cbSubOferID.Text.Trim & "','" & Trim(cbYear.Text) & "','" &
                            Trim(cbSem.SelectedValue) & "','" & Trim(cbCourse.SelectedValue) & "','" &
                            dpDyt.Value.ToShortDateString & "','" & tTerm.Text & "')"

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Call getAllOffer()
            Call TotUnits()
            MsgBox("Successfully Save....")
        Catch ex As Exception
            MsgBox("error...Insert..." & ex.Message)
            con.Close()
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            Exit Sub
        Finally
            con.Close()
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            bNew.Text = "New"
            bEdit.Text = "Edit"

        End Try

    End Sub

    Private Sub SaveUpdate()
        Dim ds As New DataSet
        Dim cmd As New OleDb.OleDbCommand

        con.ConnectionString = conStr
        cmd.Connection = con

        cmd.CommandText = "UPDATE tblEnrolment SET " &
                            " SubjectOfferingID='" & cbSubOferID.Text.Trim & "'," &
                            " SchoolYear='" & Trim(cbYear.Text) & "'," &
                            " SemesterID='" & Trim(cbSem.SelectedValue) & "'," &
                            " CourseID='" & Trim(cbCourse.SelectedValue) & "', " &
                            " Terms='" & Trim(tTerm.Text) & "' " &
                            " WHERE EnrollNo=" & Val(cbSubOferID.Tag)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Successfully Updated....")
            Call getAllOffer()
            Call TotUnits()
        Catch ex As Exception
            MsgBox("error...Update..." & ex.Message)
            con.Close()
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            Exit Sub
        Finally
            con.Close()
            Panel1.Visible = Not Panel1.Visible
            bDel.Enabled = Not bDel.Enabled
            bNew.Text = "New"
            bNew.Tag = 0
            bEdit.Text = "Edit"
        End Try

    End Sub


    Private Sub bEdit_Click(sender As System.Object, e As System.EventArgs) Handles bEdit.Click
        If bNew.Text = "New" Then
            If gvDisp.Rows.Count = 0 Or cbSubOferID.Tag = 0 Then
                MsgBox("Please Select Record or No to be Edited...")
                gvDisp.Focus()
                Exit Sub
            End If
            If tTerm.Text = Nothing Then
                cbTerm.SelectedIndex = 0
            Else
                cbTerm.Text = tTerm.Text
            End If
            bNew.Tag = 1
            bNew.Text = "Save"
            bEdit.Text = "Cancel"
            Panel1.Visible = Not Panel1.Visible
            Panel2.Enabled = Not cbSem.Enabled
            gvDisp.Enabled = Not gvDisp.Enabled
            bDel.Enabled = Not bDel.Enabled
        Else
            bNew.Tag = 0
            bNew.Text = "New"
            bEdit.Text = "Edit"
            Panel1.Visible = Not Panel1.Visible
            Panel2.Enabled = Not cbSem.Enabled
            gvDisp.Enabled = Not gvDisp.Enabled
            bDel.Enabled = Not bDel.Enabled
        End If

    End Sub

    Private Sub getAllOffer()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr


        Dim sql As String = " SELECT e.SubjectOfferingID, s.TimeIn, s.TimeOut, s.Days, sj.Units, r.Room, e.enrollno, sj.SubjectTitle, sj.Description, s.Terms " &
                            " FROM (tblSubject AS sj " &
                            " RIGHT JOIN (tblEnrolment AS e LEFT JOIN tblSubjectOffering AS s ON e.SubjectOfferingID = s.SubjectOfferingID) ON sj.SubjectID = s.SubjectID) " &
                            " LEFT JOIN tblRoom AS r ON s.RoomID = r.RoomID " &
                            " WHERE ((" &
                            "       (e.StudentID)='" & Trim(cbId.SelectedValue) & "') " &
                            "   AND ((e.CourseID)='" & Trim(cbCourse.SelectedValue) & "') " &
                            "   AND ((e.SchoolYear)='" & Trim(cbYear.Text) & "') " &
                            "   AND ((e.SemesterID)='" & cbSem.SelectedValue & "')) "
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

    Private Sub Disp_AllSub()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim addTerm As String = ""

        If cbTerm.Text = "1st" Then
            addTerm = " AND e.Terms='1st'"
        ElseIf cbTerm.Text = "2nd" Then
            addTerm = " AND e.Terms='2nd'"
        End If

        Dim sql As String = " SELECT e.SubjectOfferingID " &
                            " FROM tblSubjectOffering e " &
                            " WHERE e.SchoolYear='" & Trim(cbYear.Text) & "' " &
                            "   AND e.SemesterID='" & cbSem.SelectedValue & "' " & addTerm
        ds.Clear()
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "AllSubjOffer")
            con.Close()
            cbSubOferID.DataSource = ds.Tables(0)
            cbSubOferID.DisplayMember = "SubjectOfferingID"
            cbSubOferID.ValueMember = "SubjectOfferingID"

        Catch ex As Exception
            MsgBox("error..allsubjoffer..." & ex.Message)
            con.Close()
            Exit Sub
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub GetSubjOffer()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr


        Dim sql As String = "Select SubjectOfferingID,SchoolYear,SemesterID From tblSubjectOffering " &
                            " WHERE SchoolYear='" & Trim(cbYear.Text) & "' AND " &
                            " SemesterID='" & cbSem.SelectedValue & "' " &
                            " ORDER BY SubjectOfferingID ASC "
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Secs")
            con.Close()
            cbSubOferID.DataSource = ds.Tables(0)
            cbSubOferID.DisplayMember = "SubjectOfferingID"
            cbSubOferID.ValueMember = "SubjectOfferingID"
        Catch ex As Exception
            MsgBox("error..Section..." & ex.Message)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub getSubjDetails()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = " SELECT o.SubjectOfferingID,FORMAT(o.TimeIn,'Medium Time') as timeIn, FORMAT(o.TimeOut,'Medium Time') AS TIMEOUT, o.Days, o.Terms, s.SubjectTitle, s.Description, s.Units,r.Room " &
            " FROM tblRoom AS r RIGHT JOIN (tblSubject AS s RIGHT JOIN tblSubjectOffering AS o ON s.SubjectID = o.SubjectID) " &
            " ON r.RoomID = o.RoomID WHERE (((o.SubjectOfferingID)='" & Trim(cbSubOferID.Text) & "'))"

        ds.Clear()
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "SubjOffer")
            con.Close()
            tSubTitle.Text = If(IsDBNull(ds.Tables(0).Rows(0).Item("SubjectTitle")), "", ds.Tables(0).Rows(0).Item("SubjectTitle"))
            tSubjDesc.Text = If(IsDBNull(ds.Tables(0).Rows(0).Item("Description")), "", ds.Tables(0).Rows(0).Item("Description"))
            tTymIn.Text = If(IsDBNull(ds.Tables(0).Rows(0).Item("TimeIn").ToString), "", ds.Tables(0).Rows(0).Item("TimeIn").ToString)
            tTymOut.Text = If(IsDBNull(ds.Tables(0).Rows(0).Item("TimeOut").ToString), "", ds.Tables(0).Rows(0).Item("TimeOut").ToString)
            tDays.Text = If(IsDBNull(ds.Tables(0).Rows(0).Item("days")), "", ds.Tables(0).Rows(0).Item("days"))
            tUnits.Text = If(IsDBNull(ds.Tables(0).Rows(0).Item("Units").ToString), "", ds.Tables(0).Rows(0).Item("Units").ToString)
            tRoom.Text = If(IsDBNull(ds.Tables(0).Rows(0).Item("Room")), "", ds.Tables(0).Rows(0).Item("Room"))
            tTerm.Text = If(IsDBNull(ds.Tables(0).Rows(0).Item("Terms")), "", ds.Tables(0).Rows(0).Item("Terms"))
            'gvDisp.DataSource = ds.Tables(0)
            Call TotUnits()
        Catch ex As Exception
            MsgBox("error..SubjDets..." & ex.Message)
            con.Close()
            Exit Sub
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub cbSubOferID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbSubOferID.SelectedIndexChanged
        If lodfrm = True Then
            Exit Sub
        End If
        If cbSubOferID.SelectedIndex = -1 Then
            Exit Sub
        End If
        Call getSubjDetails()
    End Sub

    Private Sub gvDisp_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvDisp.CellEnter
        gvDisp.Tag = e.RowIndex
        cbSubOferID.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("SubjOffID").Value), "", gvDisp.Rows(e.RowIndex).Cells("SubjOffID").Value)
        cbSubOferID.Tag = gvDisp.Rows(e.RowIndex).Cells("enrollNo").Value

        tSubTitle.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("SubjectTitle").Value), "", gvDisp.Rows(e.RowIndex).Cells("SubjectTitle").Value)
        tSubjDesc.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("Description").Value), "", gvDisp.Rows(e.RowIndex).Cells("Description").Value)
        tTymIn.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("TimeIn").Value), "", gvDisp.Rows(e.RowIndex).Cells("TimeIn").Value)
        tTymOut.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("TimeOut").Value), "", gvDisp.Rows(e.RowIndex).Cells("TimeOut").Value)
        tDays.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("days").Value), "", gvDisp.Rows(e.RowIndex).Cells("days").Value)
        tUnits.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("Units").Value), "", gvDisp.Rows(e.RowIndex).Cells("Units").Value)
        tRoom.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("Room").Value), "", gvDisp.Rows(e.RowIndex).Cells("Room").Value)
        tTerm.Text = IIf(IsDBNull(gvDisp.Rows(e.RowIndex).Cells("Terms").Value), "", gvDisp.Rows(e.RowIndex).Cells("Terms").Value)


    End Sub

    Private Sub bPrint_Click(sender As System.Object, e As System.EventArgs) Handles bPrint.Click
        'Print Excel
        'Imports Excel = Microsoft.Office.Interop.Excel
        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim raXL As Excel.Range

        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        'appXL.Visible = True

        ' Add a new workbook.
        wbXl = appXL.Workbooks.Add
        shXL = wbXl.ActiveSheet

        shXL.Range("A1").ColumnWidth = 20 'code
        shXL.Range("B1").ColumnWidth = 10 'SubjTitle
        shXL.Range("C1").ColumnWidth = 28 'Description
        shXL.Range("D1").ColumnWidth = 10 'In
        shXL.Range("E1").ColumnWidth = 10 'Out
        shXL.Range("F1").ColumnWidth = 9 ' Days
        shXL.Range("G1").ColumnWidth = 10 'room
        shXL.Range("H1").ColumnWidth = 8 'units


        Dim r As Integer = 1
        shXL.Cells(r, 1).Value = "Enrollment Form"
        r = r + 1
        shXL.Cells(r, 1).Value = "ID Number : " & cbId.SelectedText & " Student Name : " & cbNym.SelectedText
        shXL.Cells(r, 2).Value = "Course : " & cbCourse.SelectedText &
            " Year/Level : " & cbLvl.SelectedText &
            " School Year : " & cbYear.SelectedText &
            " Semester : " & cbSem.SelectedText
        r = r + 2

        shXL.Cells(r, 1).Value = "Code "
        shXL.Cells(r, 2).Value = "Subject Title"
        shXL.Cells(r, 3).Value = "Description"
        shXL.Cells(r, 4).Value = "Time Start"
        shXL.Cells(r, 5).Value = "Time End"
        shXL.Cells(r, 6).Value = "Days"
        shXL.Cells(r, 7).Value = "Room"
        shXL.Cells(r, 8).Value = "Units"

        Dim gr, Tots As Integer
        Tots = 0
        For gr = 0 To gvDisp.Rows.Count = 1 Step +1
            r = r + 1
            shXL.Cells(r, 1).Value = gvDisp.Rows(gr).Cells("SubjOffID").Value
            shXL.Cells(r, 2).Value = gvDisp.Rows(gr).Cells("SubjectTitle").Value
            shXL.Cells(r, 3).Value = gvDisp.Rows(gr).Cells("Description").Value
            shXL.Cells(r, 4).Value = gvDisp.Rows(gr).Cells("TimeIn").Value
            shXL.Cells(r, 5).Value = gvDisp.Rows(gr).Cells("TimeOut").Value
            shXL.Cells(r, 6).Value = gvDisp.Rows(gr).Cells("Days").Value
            shXL.Cells(r, 7).Value = gvDisp.Rows(gr).Cells("Room").Value
            shXL.Cells(r, 8).Value = gvDisp.Rows(gr).Cells("Units").Value
            Tots = Tots + gvDisp.Rows(gr).Cells("Units").Value
        Next
        r = r + 1
        shXL.Cells(r, 7).Value = "Total Units : "
        shXL.Cells(r, 8).Value = Tots.ToString
        appXL.Visible = True
        appXL.UserControl = True

        ' Release object references.
        raXL = Nothing
        shXL = Nothing
        wbXl = Nothing
        'appXL.Quit()
        'appXL = Nothing
        Exit Sub
Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)


        ' Add table headers going cell by cell.
        'shXL.Cells(1, 1).Value = "First Name"

        'r = r + 1
        'shXL.Cells(r, 1).Value = "DTR Date"
        'shXL.Cells(r, 2).Value = "ID Number"
        'shXL.Cells(r, 3).Value = "Full Name"
        'shXL.Cells(r, 4).Value = "TIME-IN"
        'shXL.Cells(r, 5).Value = "TIME-OUT"
        'shXL.Cells(r, 6).Value = "Log Type"
        'shXL.Cells(r, 7).Value = "Total Time"
        'shXL.Cells(r, 8).Value = "Break"
        'shXL.Cells(r, 9).Value = "Break(Paid)"
        'shXL.Cells(r, 10).Value = "Late"
        'shXL.Cells(r, 11).Value = "Over Time"
        'shXL.Cells(r, 12).Value = "Under Time"
        'shXL.Cells(r, 13).Value = "Lunch Break"
        'shXL.Cells(r, 14).Value = "Coffee Break"
        'shXL.Cells(r, 15).Value = "Meeting/Coaching Break"
        'shXL.Cells(r, 16).Value = "Personal/Bio Break"
        'shXL.Cells(r, 17).Value = "Training"

        'shXL.Cells(r, 18).Value = "Total Time"
        'shXL.Cells(r, 19).Value = "Total Break"
        'shXL.Cells(r, 20).Value = "Total Break(Paid)"
        'shXL.Cells(r, 21).Value = "Total Late"
        'shXL.Cells(r, 22).Value = "Total Over Time"
        'shXL.Cells(r, 23).Value = "Total Under Time"
        'shXL.Cells(r, 24).Value = "Total Lunch Break"
        'shXL.Cells(r, 25).Value = "Total Coffee Break"
        'shXL.Cells(r, 26).Value = "Total Meeting/Coaching Break"
        'shXL.Cells(r, 27).Value = "Total Personal/Bio Break"
        'shXL.Cells(r, 28).Value = "Total Training"

        'shXL.Cells(r, 29).Value = "Rooster"
        'shXL.Cells(r, 30).Value = "Account/Bill Ref."
        'shXL.Cells(r, 31).Value = "Location"
        'shXL.Cells(r, 32).Value = "Site"
        'shXL.Cells(r, 33).Value = "Division"
        'shXL.Cells(r, 34).Value = "Allowed Late"
        'shXL.Cells(r, 35).Value = "Remarks"
        'shXL.Cells(r, 36).Value = "Day Type"

        '' Format A1:D1 as bold, vertical alignment = center.
        'With shXL.Range("A" + r.ToString, "AI" + r.ToString)
        '    .Font.Bold = True
        '    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        'End With

        '' value from 
        'If ds.Tables(0).Rows.Count > 0 Then
        '    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
        '        r = r + 1
        '        With shXL
        '            .Cells(r, 1).Value = ds.Tables(0).Rows(i).Item("DTR Date").ToString
        '            .Cells(r, 2).Value = ds.Tables(0).Rows(i).Item("Id Number").ToString
        '            .Cells(r, 3).Value = ds.Tables(0).Rows(i).Item("Full Name").ToString

        '            '.Range(r, 3).NumberFormat = "H:m:ss p m/dd/yyyy"
        '            .Cells(r, 4).Value = ds.Tables(0).Rows(i).Item("Time-In").ToString
        '            .Cells(r, 5).Value = ds.Tables(0).Rows(i).Item("Time-Out").ToString


        '            .Cells(r, 6).Value = ds.Tables(0).Rows(i).Item("Log Type").ToString


        '            .Cells(r, 7).Value = ds.Tables(0).Rows(i).Item("Total Time").ToString
        '            .Cells(r, 8).Value = ds.Tables(0).Rows(i).Item("Break").ToString
        '            .Cells(r, 9).Value = ds.Tables(0).Rows(i).Item("Break(Paid)").ToString
        '            .Cells(r, 10).Value = ds.Tables(0).Rows(i).Item("Late").ToString
        '            .Cells(r, 11).Value = ds.Tables(0).Rows(i).Item("OT").ToString
        '            .Cells(r, 12).Value = ds.Tables(0).Rows(i).Item("UnderTime").ToString
        '            .Cells(r, 13).Value = ds.Tables(0).Rows(i).Item("Lunch").ToString
        '            .Cells(r, 14).Value = ds.Tables(0).Rows(i).Item("Coffee").ToString
        '            .Cells(r, 15).Value = ds.Tables(0).Rows(i).Item("Meeting/Coaching").ToString
        '            .Cells(r, 16).Value = ds.Tables(0).Rows(i).Item("Personal/Bio").ToString
        '            .Cells(r, 17).Value = ds.Tables(0).Rows(i).Item("Training").ToString

        '            .Cells(r, 18).Value = ds.Tables(0).Rows(i).Item("Total Time").ToString
        '            .Cells(r, 19).Value = ds.Tables(0).Rows(i).Item("Total Break").ToString
        '            .Cells(r, 20).Value = ds.Tables(0).Rows(i).Item("Total Break(Paid)").ToString
        '            .Cells(r, 21).Value = ds.Tables(0).Rows(i).Item("Total Late").ToString
        '            .Cells(r, 22).Value = ds.Tables(0).Rows(i).Item("Total OT").ToString
        '            .Cells(r, 23).Value = ds.Tables(0).Rows(i).Item("Total Under").ToString
        '            .Cells(r, 24).Value = ds.Tables(0).Rows(i).Item("Total Lunch").ToString
        '            .Cells(r, 25).Value = ds.Tables(0).Rows(i).Item("Total Coffee").ToString
        '            .Cells(r, 26).Value = ds.Tables(0).Rows(i).Item("Total Meeting/Coaching").ToString
        '            .Cells(r, 27).Value = ds.Tables(0).Rows(i).Item("Total Personal/Bio").ToString
        '            .Cells(r, 28).Value = ds.Tables(0).Rows(i).Item("Total Training").ToString



        '            .Cells(r, 29).Value = ds.Tables(0).Rows(i).Item("Rooster").ToString
        '            .Cells(r, 30).Value = ds.Tables(0).Rows(i).Item("Account").ToString
        '            .Cells(r, 31).Value = ds.Tables(0).Rows(i).Item("Location").ToString
        '            .Cells(r, 32).Value = ds.Tables(0).Rows(i).Item("Site").ToString
        '            .Cells(r, 33).Value = ds.Tables(0).Rows(i).Item("Division").ToString
        '            .Cells(r, 34).Value = ds.Tables(0).Rows(i).Item("Allowed Late").ToString
        '            .Cells(r, 35).Value = ds.Tables(0).Rows(i).Item("Remarks").ToString
        '            .Cells(r, 36).Value = ds.Tables(0).Rows(i).Item("Day Type").ToString

        '        End With

        '    Next
        'End If



        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        'PrintDialog1.ShowDialog()
        'PrintPreviewDialog1.ShowDialog()

        'Dim prntDial As New PrintDialog
        'prntDial.Document = PrintDocument1
        'prntDial.UseEXDialog = True
        'If DialogResult.OK = Windows.Forms.DialogResult.OK Then
        '    PrintDocument1.DocumentName = "TEsting Lang"
        '    PrintDocument1.Print()
        'End If
        'PrintDocument1.Print()
        'PrintDocument1.DefaultPageSettings.Landscape = True
        'PrintPreviewDialog1.Document = PrintDocument1 'PrintPreviewDialog associate with PrintDocument.
        'PrintPreviewDialog1.ShowDialog() 'open the print preview

        'Call GetTime()
        'MsgBox("Sorry Still on Processss...")
    End Sub

    Private Sub cbYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbYear.SelectedIndexChanged
        Call getAllOffer()
        Call GetSubjOffer()
    End Sub

    Private Sub cbSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSem.SelectedIndexChanged
        cbTerm.Items.Clear()
        If cbSem.SelectedValue = "Sem-3" Then
            cbTerm.Items.Add("All")
        Else
            cbTerm.Items.Add("All")
            cbTerm.Items.Add("1st")
            cbTerm.Items.Add("2nd")
        End If
        Call getAllOffer()
        Call GetSubjOffer()
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbCourse.SelectedIndexChanged
        Call getAllOffer()
    End Sub

    Private Sub bAddStud_Click(sender As System.Object, e As System.EventArgs) Handles bAddStud.Click
        Dim StudentFrm As New StudInfo
        StudentFrm.ShowDialog()
        Me.TblStudentTableAdapter.Fill(Me.MstDataSet.tblStudent)
        'Call DispStudID()
        'Call DispStudName()

    End Sub

    Function GetTime() As Boolean
        'Dim ds As New DataSet
        'Dim da As OleDb.OleDbDataAdapter
        'con.ConnectionString = conStr

        Dim sIn As Date = tTymIn.Text
        Dim sOut As Date = tTymOut.Text
        Dim sCode As String = Trim(cbSubOferID.Text)
        'sIn = DateAdd(DateInterval.Minute, 1, sIn)
        'sOut = DateAdd(DateInterval.Minute, -1, sOut)


        Dim gv_sIn As Date
        Dim gv_sOut As Date
        Dim s_Code As String

        Dim naa As Boolean = False

        For i = 0 To gvDisp.Rows.Count - 1
            gv_sIn = gvDisp.Rows(i).Cells("TimeIn").Value
            gv_sOut = gvDisp.Rows(i).Cells("TimeOut").Value
            s_Code = gvDisp.Rows(i).Cells("SubjOffID").Value


            If s_Code <> sCode And (gv_sIn.ToShortTimeString > sIn.ToShortTimeString And gv_sIn.ToShortTimeString < sOut.ToShortTimeString) Then
                naa = True
            End If
            If s_Code <> sCode And (gv_sOut.ToShortTimeString > sIn.ToShortTimeString And gv_sOut.ToShortTimeString < sOut.ToShortTimeString) Then
                naa = True
            End If

            If s_Code <> sCode And _
                (gv_sIn.ToShortTimeString = sIn.ToShortTimeString Or _
                 gv_sIn.ToShortTimeString = sOut.ToShortTimeString Or _
                 gv_sOut.ToShortTimeString = sIn.ToShortTimeString And gv_sOut.ToShortTimeString = sOut.ToShortTimeString) Then
                naa = True
            End If

            'MsgBox("GV - " & gv_sIn & " - " & gv_sOut & " Txt - " & sIn & " - " & sOut & " Code " & sCode & " - " & s_Code & " Unsa man " & naa)

        Next
        Return naa


        'Dim sql As String = "SELECT tblEnrolment.EnrollNo, " &
        '    " FORMAT(tblSubjectOffering.TimeIn,'Medium Time') as TimeIn, " &
        '    " FORMAT(tblSubjectOffering.TimeOut,'Medium Time') as TimeoUT, " &
        '    " tblEnrolment.StudentID, tblEnrolment.SchoolYear, tblEnrolment.SemesterID, tblEnrolment.Terms " &
        '    " FROM tblEnrolment INNER JOIN tblSubjectOffering ON tblEnrolment.SubjectOfferingID = tblSubjectOffering.SubjectOfferingID " &
        '    " WHERE tblEnrolment.StudentID='" & Trim(cbId.Text) & "' AND tblEnrolment.SchoolYear='" & Trim(cbYear.Text) & "' " &
        '    " AND tblEnrolment.SemesterID='" & Trim(cbSem.SelectedValue) & "' " &
        '    " AND tblEnrolment.SubjectOfferingID<>'" & Trim(cbSubOferID.SelectedValue) & "' " &
        '    " AND Trim(tblEnrolment.Terms)='" & Trim(tTerm.Text) & "' " &
        '    " AND ((tblSubjectOffering.TimeIn BETWEEN #" & sIn.ToShortTimeString & "# AND #" & sOut.ToShortTimeString & "#) " &
        '    " OR (tblSubjectOffering.TimeOut BETWEEN #" & sIn.ToShortTimeString & "# AND #" & sOut.ToShortTimeString & "#)) ;"
        ''tblEnrolment.EnrollNo<>" & Val(cbSubOferID.Tag) AND 

        ''MsgBox(sql)
        ''Return False
        ''Exit Function
        'ds.Clear()
        'Try
        '    con.Open()
        '    da = New OleDb.OleDbDataAdapter(sql, con)
        '    da.Fill(ds, "TimeCon")
        '    con.Close()
        '    'DataGridView1.DataSource = ds.Tables(0)
        '    If ds.Tables(0).Rows.Count > 0 Then
        '        Return True
        '    Else
        '        Return False
        '        'MsgBox("Wala...")
        '    End If
        '    'gvDisp.DataSource = ds.Tables(0)
        'Catch ex As Exception
        '    MsgBox("error..in Gettting Time..." & ex.Message)
        '    con.Close()
        '    Return False
        '    Exit Function
        'Finally
        '    con.Close()
        'End Try


    End Function


    Function GetDays() As Boolean
        s_Error = ""
        Dim sIn As Date = tTymIn.Text
        Dim sOut As Date = tTymOut.Text
        Dim sCode As String = Trim(cbSubOferID.Text)
        Dim sTerms As String = Trim(UCase(tTerm.Text))

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


    Function GetExistBubj() As Boolean
        Dim naa As Boolean = False
        For i = 0 To gvDisp.Rows.Count - 1
            'MsgBox(gvDisp.Rows(i).Cells("EnrollNo").Value & " =" & cbSubOferID.Tag)
            If UCase(tSubTitle.Text).Trim = Trim(UCase(gvDisp.Rows(i).Cells("SubjectTitle").Value)) And _
                Val(gvDisp.Rows(i).Cells("EnrollNo").Value) <> Val(cbSubOferID.Tag) Then
                naa = True
            End If
        Next
        Return naa
    End Function

    Private Sub TotUnits()
        Dim tots As Integer = 0
        For x = 0 To gvDisp.Rows.Count - 1 Step +1
            'Dim XX As Integer = gvDisp.Rows(x).Cells("Units")
            tots = tots + IIf(IsDBNull(gvDisp.Rows(x).Cells("Units").Value), 0, gvDisp.Rows(x).Cells("Units").Value)
        Next
        lTots.Text = "Total Units : " & tots.ToString
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim bm As New Bitmap(Me.gvDisp.Width, Me.gvDisp.Height)
        'gvDisp.DrawToBitmap(bm, New Rectangle(0, 0, Me.gvDisp.Width, Me.gvDisp.Height))
        'e.Graphics.DrawImage(bm, 0, 0)

        Dim bm As New Bitmap(Me.pict_logo.Width, Me.pict_logo.Height)
        pict_logo.DrawToBitmap(bm, New Rectangle(0, 0, Me.pict_logo.Width, Me.pict_logo.Height))
        e.Graphics.DrawImage(bm, 50, 25)


        '**other
        Static pageNum As Integer
        Dim y_row As Integer = 40
        Dim x_row As Integer = 30


        'font settings
        Dim prFont_Heads As New Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont_Hd As New Font("Verana", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont As New Font("Times New Roman", 10, GraphicsUnit.Point)


        e.Graphics.DrawString("SAMSON POLYTHECNIC COLLEGE OF DAVAO", prFont_Heads, Brushes.Black, 230, 50)

        e.Graphics.DrawString("Formerly SAMSON TECHNICAL INSTITUTE", prFont_Hd, Brushes.Black, 270, 70)

        e.Graphics.DrawString("R. Magsaysay Avenue, Corner Chavez St., Davao City", prFont_Hd, Brushes.Black, 240, 85)

        e.Graphics.DrawString("Tel. No. (082)-300-1493/227-2392 Email: samson_technical@yahoo.com", prFont_Hd, Brushes.Black, 200, 105)


        'e.Graphics.DrawString("PAGE " & pageNum + 1, prFont, Brushes.Black, 700, 1050)
        'e.Graphics.DrawRectangle(Pens.Blue, 0, 0, 300, 100)

        e.Graphics.DrawString("Enrollment Form", prFont_Hd, Brushes.Black, x_row, 140)
        e.Graphics.DrawString("", prFont, Brushes.Black, x_row, 14)
        e.Graphics.DrawString("Student ID  : " & cbId.Text, prFont, Brushes.Black, x_row, 160)
        e.Graphics.DrawString("Course      : " & cbCourse.Text, prFont, Brushes.Black, x_row, 180)
        e.Graphics.DrawString("School Year : " & cbYear.Text, prFont, Brushes.Black, x_row, 200)

        e.Graphics.DrawString("Name        : " & cbNym.Text, prFont, Brushes.Black, 400, 160)
        e.Graphics.DrawString("Year Level  : " & cbLvl.Text, prFont, Brushes.Black, 400, 180)
        e.Graphics.DrawString("Semester    : " & cbSem.Text, prFont, Brushes.Black, 400, 200)


        e.Graphics.DrawString("", prFont, Brushes.Black, x_row, 90)

        Dim r As Integer = 250

        e.Graphics.DrawString("Subject Title", prFont_Hd, Brushes.Black, 30, r)
        e.Graphics.DrawString("Description", prFont_Hd, Brushes.Black, 140, r)
        e.Graphics.DrawString("TimeIn", prFont_Hd, Brushes.Black, 400, r)
        e.Graphics.DrawString("TimeOut", prFont_Hd, Brushes.Black, 500, r)
        e.Graphics.DrawString("Days", prFont_Hd, Brushes.Black, 600, r)
        e.Graphics.DrawString("Room", prFont_Hd, Brushes.Black, 650, r)
        e.Graphics.DrawString("Units", prFont_Hd, Brushes.Black, 750, r)

        r = r + 20

        Dim totU As Integer = 0
        For rw = 0 To gvDisp.Rows.Count - 1 Step +1
            e.Graphics.DrawString(gvDisp.Rows(rw).Cells("SubjectTitle").Value, prFont, Brushes.Black, 30, r)
            e.Graphics.DrawString(gvDisp.Rows(rw).Cells("Description").Value, prFont, Brushes.Black, 100, r)
            e.Graphics.DrawString(gvDisp.Rows(rw).Cells("TimeIn").Value, prFont, Brushes.Black, 400, r)
            e.Graphics.DrawString(gvDisp.Rows(rw).Cells("TimeOut").Value, prFont, Brushes.Black, 500, r)
            e.Graphics.DrawString(gvDisp.Rows(rw).Cells("days").Value, prFont, Brushes.Black, 600, r)
            e.Graphics.DrawString(gvDisp.Rows(rw).Cells("Room").Value, prFont, Brushes.Black, 650, r)
            e.Graphics.DrawString(gvDisp.Rows(rw).Cells("Units").Value, prFont, Brushes.Black, 750, r)
            r = r + 15
            totU = totU + gvDisp.Rows(rw).Cells("Units").Value
        Next

        e.Graphics.DrawString("Total Units : " & totU.ToString, prFont, Brushes.Black, 680, r + 30)

        '**String

        ' Add more printing statements here
        ' Following is the logic that determines whether we’re done printing
        pageNum = pageNum + 1
        If pageNum <= 3 Then
            e.HasMorePages = True
        Else


            e.HasMorePages = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub bDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDel.Click
        If gvDisp.Rows.Count = 0 Or cbSubOferID.Tag = Nothing Then
            MsgBox("No Record Selected to be Drop...")
            gvDisp.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Drop This Subject Offered?" + Chr(13) + cbSubOferID.Text + " - " + tSubTitle.Text, "Delete...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim ds As New DataSet
            Dim cmd As New OleDb.OleDbCommand

            con.ConnectionString = conStr
            cmd.Connection = con

            cmd.CommandText = "DELETE FROM tblEnrolment " &
                                " WHERE SubjectOfferingID='" & cbSubOferID.Text.ToString & "' "
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

    '    If gvDisp.Rows.Count = 0 Or cbSubOferID.Tag = Nothing Then
    '        MsgBox("No Record Selected to be Drop...")
    '        gvDisp.Focus()
    '        Exit Sub
    '    End If

    '    If MessageBox.Show("Delete This Subject Offered?" + Chr(13) + cbSubOferID.Text + " - " + cbSubOferID.Text, "Delete...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        Dim ds As New DataSet
    '        Dim cmd As New OleDb.OleDbCommand

    '        con.ConnectionString = conStr
    '        cmd.Connection = con

    '        cmd.CommandText = "DELETE FROM tblEnrolment" &
    '                            " WHERE tblEnrolment='" & cbSubOferID.Tag.Trim & "' "
    '        Try
    '            con.Open()
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '            MsgBox("Successfully Updated....")
    '            Call getAllOffer()

    '        Catch ex As Exception
    '            MsgBox("error...Update..." & ex.Message)
    '            con.Close()
    '            Panel1.Visible = Not Panel1.Visible
    '            bDel.Enabled = Not bDel.Enabled
    '            'Panel2.Enabled = Not Panel2.Enabled
    '            Exit Sub
    '        Finally
    '            con.Close()
    '            Panel1.Visible = Not Panel1.Visible
    '            bDel.Enabled = Not bDel.Enabled
    '            'Panel2.Enabled = Not Panel2.Enabled
    '            bNew.Text = "New"
    '            bNew.Tag = 0
    '            bEdit.Text = "Edit"
    '        End Try
    '    End If
    End Sub

    Private Sub cbTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call getAllOffer()
    End Sub

    Private Sub tSubTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSubTitle.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If GetDays() = True Then
            MsgBox("Conflict...")
        Else
            MsgBox("Ok lang...")
        End If
        'Dim xx As Date = tTymIn.Text
        'MsgBox(xx)

    End Sub

    Private Sub gvDisp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvDisp.CellContentClick

    End Sub

    Private Sub cbTerm_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTerm.SelectedIndexChanged
        Call Disp_AllSub()
    End Sub

    Private Sub lTots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lTots.Click

    End Sub
End Class
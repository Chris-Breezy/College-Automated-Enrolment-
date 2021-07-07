Imports System
Imports System.Data.OleDb
Public Class StudInfo
    Dim con As New OleDbConnection
    Dim conStr As String = EnrollSys.My.Settings.SkolDBFConnectionString.ToString
    Dim lodfrm As Boolean

    Private Sub TblStudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblStudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblStudentBindingSource.EndEdit()
3:      Me.TableAdapterManager.UpdateAll(Me.MstDataSet)
        MessageBox.Show("Successfully Save")

        'If LastNameTextBox.Text = Nothing Or FirstNameTextBox.Text = Nothing Or MiddleNameTextBox.Text = Nothing Then
        '    MsgBox("Incomplete Data Please Complete the Following : " + Chr(13) + "- Last Name" + Chr(13) + "- First Name" + Chr(13) + "- Middle Name")
        '    StudentIDTextBox.Focus()
        '    Exit Sub
        'End If

    End Sub

    Private Sub StudInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MstDataSet.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.MstDataSet.tblStudent)

    End Sub
    Function ckDups() As Boolean
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = conStr

        Dim sql As String = "Select StudentID,LastName +', ' +FirstName +' '+ MiddleName as Nym From tblStudent " &
                            " WHERE StudentID<>'" & StudentIDTextBox.Text & "' AND " &
                            " LastName='" & LastNameTextBox.Text & "' AND " &
                            " FirstName='" & FirstNameTextBox.Text & "' AND " &
                            " MiddleName='" & MiddleNameTextBox.Text & "'"
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "cKStuds")
            con.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("This Student Name is already Exist")
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox("error..Check Dups..." & ex.Message)
            con.Close()
            Return False
        Finally
            con.Close()
        End Try
    End Function


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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim y_row As Integer = 40
        Dim x_row As Integer = 44
        Dim bm As New Bitmap(Me.pict_logo.Width, Me.pict_logo.Height)
        Dim scalefac As Integer = 100
        Dim img As Image = pict_logo.Image

        'While (scalefac * pict_logo.Width / pict_logo.horizontalresoulution > e.PageBounds.Width Or scalefac * pict_logo.Height) And scalefac > 2
        'scalefac -= 1
        'End While
        'Dim sz As New SizeF(100 *pict_logo.Width / pict_log]

        pict_logo.DrawToBitmap(bm, New Rectangle(0, 0, Me.pict_logo.Width, Me.pict_logo.Height))
        e.Graphics.DrawImage(bm, 50, 25)

        Dim prFont_Heads As New Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont_Hd As New Font("Verana", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont As New Font("Times New Roman", 10, GraphicsUnit.Point)
        Dim WEW As New Font("Times New Roman", 13, FontStyle.Bold, GraphicsUnit.Point)


        e.Graphics.DrawString("SAMSON POLYTHECNIC COLLEGE OF DAVAO", prFont_Heads, Brushes.Black, 180, 50)

        e.Graphics.DrawString("Formerly SAMSON TECHNICAL INSTITUTE", prFont_Hd, Brushes.Black, 270, 75)

        e.Graphics.DrawString("R. Magsaysay Avenue, Corner Chavez St., Davao City", prFont, Brushes.Black, 262, 93)

        e.Graphics.DrawString("Tel. No. (082)-300-1493/227-2392 Email: samson_technical@yahoo.com", prFont, Brushes.Black, 200, 111)

        e.Graphics.DrawString("STUDENT'S INFORMATION SHEET", prFont_Heads, Brushes.Black, 230, 160)
        e.Graphics.DrawString("Admission Date: " & Date_FileDateTimePicker.Text, prFont, Brushes.Black, 630, 15)
        e.Graphics.DrawString("PERSONAL DATA", prFont_Hd, Brushes.Black, x_row, 210)

        e.Graphics.DrawString("Course:", prFont, Brushes.Black, x_row, 240)

        e.Graphics.DrawString("STATUS", prFont_Hd, Brushes.Black, x_row, 270)
        e.Graphics.DrawString("(Please Check)", prFont, Brushes.Black, 110, 270)



        e.Graphics.DrawString("( )" & Old_StudRadioButton.Text, prFont, Brushes.Black, 220, 270)
        e.Graphics.DrawString("( )" & New_StudRadioButton.Text, prFont, Brushes.Black, 300, 270)
        e.Graphics.DrawString("( )" & TransfereeRadioButton.Text, prFont, Brushes.Black, 370, 270)
        e.Graphics.DrawString("( )" & ReturneeRadioButton.Text, prFont, Brushes.Black, 470, 270)
        e.Graphics.DrawString("( )" & CrossEnroleeRadioButton.Text, prFont, Brushes.Black, 560, 270)


        e.Graphics.DrawString("StudentID: " & StudentIDTextBox.Text, prFont, Brushes.Black, x_row, 300)
        e.Graphics.DrawString("Last Name: " & LastNameTextBox.Text, prFont, Brushes.Black, 220, 300)


        'e.Graphics.DrawString("_______________", prFont, Brushes.Black, 286, 302)

        e.Graphics.DrawString("First Name: " & FirstNameTextBox.Text, prFont, Brushes.Black, 400, 300)
        e.Graphics.DrawString("Middle Name: " & MiddleNameTextBox.Text, prFont, Brushes.Black, 600, 300)

        e.Graphics.DrawString("Contact No: " & ContactNoTextBox.Text, prFont, Brushes.Black, x_row, 330)
        e.Graphics.DrawString("Date of Birth: " & BirthDateDateTimePicker.Text, prFont, Brushes.Black, 220, 330)
        e.Graphics.DrawString("Place of Birth: " & PlaceOfBirthTextBox.Text, prFont, Brushes.Black, 400, 330)

        e.Graphics.DrawString("Age: " & AgeNumericUpDown.Text, prFont, Brushes.Black, x_row, 360)
        e.Graphics.DrawString("Civil Status: " & StatusComboBox.Text, prFont, Brushes.Black, 220, 360)
        e.Graphics.DrawString("Religion: " & ReligionTextBox.Text, prFont, Brushes.Black, 400, 360)
        e.Graphics.DrawString("Gender: " & GenderTextBox.Text, prFont, Brushes.Black, 600, 360)

        e.Graphics.DrawString("Citizenship: " & CitizenshipTextBox.Text, prFont, Brushes.Black, x_row, 390)
        e.Graphics.DrawString("Weight: ", prFont, Brushes.Black, 220, 390)
        e.Graphics.DrawString("Height: ", prFont, Brushes.Black, 400, 390)
        e.Graphics.DrawString("Blood Type: " & BloodTypeTextBox.Text, prFont, Brushes.Black, 600, 390)

        e.Graphics.DrawString("City Address: " & AddressTextBox.Text, prFont, Brushes.Black, x_row, 420)
        e.Graphics.DrawString("Provincial Address: " & ProvAddTextBox.Text, prFont, Brushes.Black, x_row, 450)

        e.Graphics.DrawString("No. of siblings: " & NoOfSiblingsNumericUpDown.Text, prFont, Brushes.Black, x_row, 480)
        e.Graphics.DrawString("Sibling Position: " & SiblingPositionNumericUpDown.Text, prFont, Brushes.Black, 220, 480)
        e.Graphics.DrawString("Mother Tongue: " & Lang_DialectComboBox.Text, prFont, Brushes.Black, 400, 480)

        e.Graphics.DrawString("Father's Name: " & FatherNameTextBox.Text, prFont, Brushes.Black, x_row, 510)
        e.Graphics.DrawString("Occupation: " & FatherWorkTextBox.Text, prFont, Brushes.Black, 400, 510)

        e.Graphics.DrawString("Date of birth: " & Father_BDayDateTimePicker.Text, prFont, Brushes.Black, x_row, 540)
        e.Graphics.DrawString("Place of birth: " & FatherBplaceTextBox.Text, prFont, Brushes.Black, 220, 540)
        e.Graphics.DrawString("Religion: " & Father_RelTextBox.Text, prFont, Brushes.Black, 600, 540)

        e.Graphics.DrawString("Mother's Name: " & MotherNameTextBox.Text, prFont, Brushes.Black, x_row, 570)
        e.Graphics.DrawString("Occupation: " & MotherWorkTextBox.Text, prFont, Brushes.Black, 400, 570)

        e.Graphics.DrawString("Date of birth: " & Mother_BdayDateTimePicker.Text, prFont, Brushes.Black, x_row, 600)
        e.Graphics.DrawString("Place of birth: " & MotherBplaceTextBox.Text, prFont, Brushes.Black, 220, 600)
        e.Graphics.DrawString("Religion: " & Mother_RelTextBox.Text, prFont, Brushes.Black, 600, 600)

        e.Graphics.DrawString("With whom do you presently live? (Complete Name Address)", prFont_Hd, Brushes.Black, x_row, 630)

        e.Graphics.DrawString("Name: " & Live_NameTextBox.Text, prFont, Brushes.Black, x_row, 650)
        e.Graphics.DrawString("Relationship: " & Live_RelationTextBox.Text, prFont, Brushes.Black, 400, 650)
        e.Graphics.DrawString("Contact No: " & Live_ContactTextBox.Text, prFont, Brushes.Black, 600, 650)

        e.Graphics.DrawString("Address: " & Live_AddTextBox.Text, prFont, Brushes.Black, x_row, 670)

        e.Graphics.DrawString("In Case of Emergency, please notify:", prFont_Hd, Brushes.Black, x_row, 700)

        e.Graphics.DrawString("Name: " & Emergency_NameTextBox.Text, prFont, Brushes.Black, x_row, 720)
        e.Graphics.DrawString("Relationship: " & Emergency_RelationTextBox.Text, prFont, Brushes.Black, 400, 720)
        e.Graphics.DrawString("Contact No: " & Emergency_ContactTextBox.Text, prFont, Brushes.Black, 600, 720)

        e.Graphics.DrawString("EDUCATIONAL BACKGROUND", prFont_Hd, Brushes.Black, x_row, 750)
        e.Graphics.DrawString("Elem. School Attended: " & ElementaryTextBox.Text, prFont, Brushes.Black, x_row, 770)
        e.Graphics.DrawString("School Year: " & Elem_YearTextBox.Text, prFont, Brushes.Black, 600, 770)

        e.Graphics.DrawString("High School Attended: " & HighSchoolTextBox.Text, prFont, Brushes.Black, x_row, 790)
        e.Graphics.DrawString("School Year: " & HighSchool_YearTextBox.Text, prFont, Brushes.Black, 600, 790)

        e.Graphics.DrawString("Last School Attended: " & LastSchoolAddTextBox.Text, prFont, Brushes.Black, x_row, 810)
        e.Graphics.DrawString("School Year: " & LastSchool_YRTextBox.Text, prFont, Brushes.Black, 600, 810)

        e.Graphics.DrawString("Please Check:", prFont_Hd, Brushes.Black, x_row, 830)
        e.Graphics.DrawString("( ) Private School: " & Private_PublicComboBox.Text, prFont, Brushes.Black, 400, 830)
        e.Graphics.DrawString("( ) Public School" & Private_PublicComboBox.Text, prFont, Brushes.Black, 270, 830)

        e.Graphics.DrawString("Address:", prFont, Brushes.Black, x_row, 850)

        e.Graphics.DrawString("SCHOOL RECORDS SUBMITTED UPON ENROLLMENT:", prFont_Hd, Brushes.Black, x_row, 880)

        e.Graphics.DrawString("____Form 137 (to be requested by the school)", prFont, Brushes.Black, x_row, 900)
        e.Graphics.DrawString("____Form 138 or Report Card", prFont, Brushes.Black, x_row, 920)
        e.Graphics.DrawString("____NSO/PSA certificate( photo copy only)", prFont, Brushes.Black, x_row, 940)
        e.Graphics.DrawString("____Good Moral Character Certificate", prFont, Brushes.Black, x_row, 960)
        e.Graphics.DrawString("____Employer's Consent ", prFont, Brushes.Black, 400, 940)

        e.Graphics.DrawString("____Qualified Voucher Recipient Cert. (QVR)" & Private_PublicComboBox.Text, prFont, Brushes.Black, 400, 900)
        e.Graphics.DrawString("____Transcript of Records(TOR)" & Private_PublicComboBox.Text, prFont, Brushes.Black, 400, 920)
        e.Graphics.DrawString("____Honorable Dismissal (for transferee)" & Private_PublicComboBox.Text, prFont, Brushes.Black, 400, 960)


        e.Graphics.DrawString("We HEREBY CERTIFY", prFont_Hd, Brushes.Black, x_row, 1000)
        e.Graphics.DrawString("that the above information are true and correct to the best of our knowledge.", prFont, Brushes.Black, 205, 1000)

        e.Graphics.DrawString("________________________________________", prFont, Brushes.Black, 50, 1050)
        e.Graphics.DrawString("Student's Signature Over Printed Name", prFont, Brushes.Black, 85, 1067)

        e.Graphics.DrawString("________________________________________", prFont, Brushes.Black, 480, 1050)
        e.Graphics.DrawString("Parent's Signature Over Printed Name", prFont, Brushes.Black, 520, 1067)

        e.Graphics.DrawString("_____________", prFont, Brushes.Black, 140, 1100)
        e.Graphics.DrawString("Date Signed", prFont, Brushes.Black, 150, 1117)

        e.Graphics.DrawString("_____________", prFont, Brushes.Black, 570, 1100)
        e.Graphics.DrawString("Date Signed", prFont, Brushes.Black, 585, 1117)

    End Sub

    Private Sub TabPage5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BirthDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthDateDateTimePicker.ValueChanged
        With BirthDateDateTimePicker.Value
            Dim celebrate As DateTime = New DateTime(Now.Year, .Month, .Day)
            Dim age As Integer = Now.Year - .Year
            If celebrate > Now Then age -= 1
            AgeNumericUpDown.Text = CStr(age)
        End With
    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        TblStudentBindingSource.AddNew()

    End Sub

    Private Sub bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsave.Click
        Try
            TblStudentBindingSource.EndEdit()
            TblStudentTableAdapter.Update(MstDataSet.tblStudent)
            MessageBox.Show("Successfully Save")

        Catch ex As Exception
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class
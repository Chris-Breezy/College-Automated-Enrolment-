<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SchoolYearLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim SubjectIDLabel As System.Windows.Forms.Label
        Dim SubjectOfferingIDLabel As System.Windows.Forms.Label
        Dim StudentIDLabel1 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnrollFrm))
        Me.MstDataSet = New EnrollSys.MstDataSet()
        Me.TblSchoolYearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSchoolYearTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSchoolYearTableAdapter()
        Me.TableAdapterManager = New EnrollSys.MstDataSetTableAdapters.TableAdapterManager()
        Me.TblCourseTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter()
        Me.TblSemesterTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSemesterTableAdapter()
        Me.TblStudentTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblStudentTableAdapter()
        Me.TblSemesterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbTerm = New System.Windows.Forms.ComboBox()
        Me.tTerm = New System.Windows.Forms.TextBox()
        Me.tUnits = New System.Windows.Forms.TextBox()
        Me.tRoom = New System.Windows.Forms.TextBox()
        Me.tDays = New System.Windows.Forms.TextBox()
        Me.tTymOut = New System.Windows.Forms.TextBox()
        Me.tTymIn = New System.Windows.Forms.TextBox()
        Me.tSubjDesc = New System.Windows.Forms.TextBox()
        Me.tSubTitle = New System.Windows.Forms.TextBox()
        Me.cbSubOferID = New System.Windows.Forms.ComboBox()
        Me.gvDisp = New System.Windows.Forms.DataGridView()
        Me.SubjOffID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Terms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Units = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enrolNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbId = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.cbSem = New System.Windows.Forms.ComboBox()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.cbLvl = New System.Windows.Forms.ComboBox()
        Me.cbNym = New System.Windows.Forms.ComboBox()
        Me.dpDyt = New System.Windows.Forms.DateTimePicker()
        Me.bDel = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bNew = New System.Windows.Forms.Button()
        Me.bPrint = New System.Windows.Forms.Button()
        Me.bAddStud = New System.Windows.Forms.Button()
        Me.lTots = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        SchoolYearLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        SubjectIDLabel = New System.Windows.Forms.Label()
        SubjectOfferingIDLabel = New System.Windows.Forms.Label()
        StudentIDLabel1 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchoolYearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSemesterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gvDisp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SchoolYearLabel
        '
        SchoolYearLabel.AutoSize = True
        SchoolYearLabel.Location = New System.Drawing.Point(36, 47)
        SchoolYearLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SchoolYearLabel.Name = "SchoolYearLabel"
        SchoolYearLabel.Size = New System.Drawing.Size(68, 13)
        SchoolYearLabel.TabIndex = 1
        SchoolYearLabel.Text = "School Year:"
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Location = New System.Drawing.Point(220, 47)
        SemesterLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(54, 13)
        SemesterLabel.TabIndex = 2
        SemesterLabel.Text = "Semester:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(58, 78)
        CourseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(43, 13)
        CourseLabel.TabIndex = 4
        CourseLabel.Text = "Course:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(890, 3)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 11
        Label5.Text = "Room:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(728, 3)
        Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(34, 13)
        Label4.TabIndex = 10
        Label4.Text = "Days:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(642, 3)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 13)
        Label3.TabIndex = 9
        Label3.Text = "Time End:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(556, 3)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 13)
        Label2.TabIndex = 8
        Label2.Text = "Time Start:"
        '
        'SubjectIDLabel
        '
        SubjectIDLabel.AutoSize = True
        SubjectIDLabel.Location = New System.Drawing.Point(290, 3)
        SubjectIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SubjectIDLabel.Name = "SubjectIDLabel"
        SubjectIDLabel.Size = New System.Drawing.Size(46, 13)
        SubjectIDLabel.TabIndex = 2
        SubjectIDLabel.Text = "Subject:"
        '
        'SubjectOfferingIDLabel
        '
        SubjectOfferingIDLabel.AutoSize = True
        SubjectOfferingIDLabel.Location = New System.Drawing.Point(147, 3)
        SubjectOfferingIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SubjectOfferingIDLabel.Name = "SubjectOfferingIDLabel"
        SubjectOfferingIDLabel.Size = New System.Drawing.Size(100, 13)
        SubjectOfferingIDLabel.TabIndex = 0
        SubjectOfferingIDLabel.Text = "Subject Offering ID:"
        '
        'StudentIDLabel1
        '
        StudentIDLabel1.AutoSize = True
        StudentIDLabel1.Location = New System.Drawing.Point(18, 13)
        StudentIDLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StudentIDLabel1.Name = "StudentIDLabel1"
        StudentIDLabel1.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel1.TabIndex = 13
        StudentIDLabel1.Text = "Student ID:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(374, 81)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(63, 13)
        Label7.TabIndex = 19
        Label7.Text = "Year/Level:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(242, 13)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 13)
        Label1.TabIndex = 23
        Label1.Text = "Student Name:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(410, 3)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(63, 13)
        Label6.TabIndex = 14
        Label6.Text = "Description:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(394, 47)
        Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(92, 13)
        Label8.TabIndex = 25
        Label8.Text = "Date Registration:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(959, 3)
        Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(34, 13)
        Label9.TabIndex = 22
        Label9.Text = "Units:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(816, 3)
        Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(34, 13)
        Label11.TabIndex = 24
        Label11.Text = "Term:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(50, 3)
        Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(31, 13)
        Label10.TabIndex = 27
        Label10.Text = "Term"
        '
        'MstDataSet
        '
        Me.MstDataSet.DataSetName = "MstDataSet"
        Me.MstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSchoolYearBindingSource
        '
        Me.TblSchoolYearBindingSource.DataMember = "tblSchoolYear"
        Me.TblSchoolYearBindingSource.DataSource = Me.MstDataSet
        '
        'TblSchoolYearTableAdapter
        '
        Me.TblSchoolYearTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAccessTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCollegeTableAdapter = Nothing
        Me.TableAdapterManager.tblCourseTableAdapter = Me.TblCourseTableAdapter
        Me.TableAdapterManager.tblCredentialTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblDiscountTableAdapter = Nothing
        Me.TableAdapterManager.tblDroppedTableAdapter = Nothing
        Me.TableAdapterManager.tblEnrolmentTableAdapter = Nothing
        Me.TableAdapterManager.tblExpirationTableAdapter = Nothing
        Me.TableAdapterManager.tblFeeTableAdapter = Nothing
        Me.TableAdapterManager.tblGraduateTableAdapter = Nothing
        Me.TableAdapterManager.tblPrerequisiteTableAdapter = Nothing
        Me.TableAdapterManager.tblProspectusTableAdapter = Nothing
        Me.TableAdapterManager.tblRoomDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblRoomTableAdapter = Nothing
        Me.TableAdapterManager.tblSchoolTableAdapter = Nothing
        Me.TableAdapterManager.tblSchoolYearTableAdapter = Me.TblSchoolYearTableAdapter
        Me.TableAdapterManager.tblSectionTableAdapter = Nothing
        Me.TableAdapterManager.tblSemesterTableAdapter = Me.TblSemesterTableAdapter
        Me.TableAdapterManager.tblStudentTableAdapter = Me.TblStudentTableAdapter
        Me.TableAdapterManager.tblSubjectOfferingTableAdapter = Nothing
        Me.TableAdapterManager.tblSubjectTableAdapter = Nothing
        Me.TableAdapterManager.tblTeacherTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccessTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblYearLevelTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnrollSys.MstDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCourseTableAdapter
        '
        Me.TblCourseTableAdapter.ClearBeforeFill = True
        '
        'TblSemesterTableAdapter
        '
        Me.TblSemesterTableAdapter.ClearBeforeFill = True
        '
        'TblStudentTableAdapter
        '
        Me.TblStudentTableAdapter.ClearBeforeFill = True
        '
        'TblSemesterBindingSource
        '
        Me.TblSemesterBindingSource.DataMember = "tblSemester"
        Me.TblSemesterBindingSource.DataSource = Me.MstDataSet
        '
        'TblCourseBindingSource
        '
        Me.TblCourseBindingSource.DataMember = "tblCourse"
        Me.TblCourseBindingSource.DataSource = Me.MstDataSet
        '
        'TblStudentBindingSource
        '
        Me.TblStudentBindingSource.DataMember = "tblStudent"
        Me.TblStudentBindingSource.DataSource = Me.MstDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.cbTerm)
        Me.Panel1.Controls.Add(Me.tTerm)
        Me.Panel1.Controls.Add(Label11)
        Me.Panel1.Controls.Add(Me.tUnits)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Me.tRoom)
        Me.Panel1.Controls.Add(Me.tDays)
        Me.Panel1.Controls.Add(Me.tTymOut)
        Me.Panel1.Controls.Add(Me.tTymIn)
        Me.Panel1.Controls.Add(Me.tSubjDesc)
        Me.Panel1.Controls.Add(Me.tSubTitle)
        Me.Panel1.Controls.Add(Me.cbSubOferID)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(SubjectIDLabel)
        Me.Panel1.Controls.Add(SubjectOfferingIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 119)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 44)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'cbTerm
        '
        Me.cbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTerm.FormattingEnabled = True
        Me.cbTerm.Location = New System.Drawing.Point(13, 18)
        Me.cbTerm.Name = "cbTerm"
        Me.cbTerm.Size = New System.Drawing.Size(98, 21)
        Me.cbTerm.TabIndex = 26
        '
        'tTerm
        '
        Me.tTerm.Location = New System.Drawing.Point(790, 18)
        Me.tTerm.Margin = New System.Windows.Forms.Padding(2)
        Me.tTerm.Name = "tTerm"
        Me.tTerm.ReadOnly = True
        Me.tTerm.Size = New System.Drawing.Size(76, 20)
        Me.tTerm.TabIndex = 25
        '
        'tUnits
        '
        Me.tUnits.Location = New System.Drawing.Point(952, 18)
        Me.tUnits.Margin = New System.Windows.Forms.Padding(2)
        Me.tUnits.Name = "tUnits"
        Me.tUnits.ReadOnly = True
        Me.tUnits.Size = New System.Drawing.Size(65, 20)
        Me.tUnits.TabIndex = 23
        '
        'tRoom
        '
        Me.tRoom.Location = New System.Drawing.Point(873, 18)
        Me.tRoom.Margin = New System.Windows.Forms.Padding(2)
        Me.tRoom.Name = "tRoom"
        Me.tRoom.ReadOnly = True
        Me.tRoom.Size = New System.Drawing.Size(76, 20)
        Me.tRoom.TabIndex = 21
        '
        'tDays
        '
        Me.tDays.Location = New System.Drawing.Point(710, 18)
        Me.tDays.Margin = New System.Windows.Forms.Padding(2)
        Me.tDays.Name = "tDays"
        Me.tDays.ReadOnly = True
        Me.tDays.Size = New System.Drawing.Size(76, 20)
        Me.tDays.TabIndex = 20
        '
        'tTymOut
        '
        Me.tTymOut.Location = New System.Drawing.Point(631, 18)
        Me.tTymOut.Margin = New System.Windows.Forms.Padding(2)
        Me.tTymOut.Name = "tTymOut"
        Me.tTymOut.ReadOnly = True
        Me.tTymOut.Size = New System.Drawing.Size(76, 20)
        Me.tTymOut.TabIndex = 19
        '
        'tTymIn
        '
        Me.tTymIn.Location = New System.Drawing.Point(552, 18)
        Me.tTymIn.Margin = New System.Windows.Forms.Padding(2)
        Me.tTymIn.Name = "tTymIn"
        Me.tTymIn.ReadOnly = True
        Me.tTymIn.Size = New System.Drawing.Size(76, 20)
        Me.tTymIn.TabIndex = 18
        '
        'tSubjDesc
        '
        Me.tSubjDesc.Location = New System.Drawing.Point(358, 18)
        Me.tSubjDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.tSubjDesc.Name = "tSubjDesc"
        Me.tSubjDesc.ReadOnly = True
        Me.tSubjDesc.Size = New System.Drawing.Size(190, 20)
        Me.tSubjDesc.TabIndex = 17
        '
        'tSubTitle
        '
        Me.tSubTitle.Location = New System.Drawing.Point(278, 18)
        Me.tSubTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.tSubTitle.Name = "tSubTitle"
        Me.tSubTitle.ReadOnly = True
        Me.tSubTitle.Size = New System.Drawing.Size(76, 20)
        Me.tSubTitle.TabIndex = 16
        '
        'cbSubOferID
        '
        Me.cbSubOferID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubOferID.FormattingEnabled = True
        Me.cbSubOferID.Location = New System.Drawing.Point(128, 18)
        Me.cbSubOferID.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSubOferID.Name = "cbSubOferID"
        Me.cbSubOferID.Size = New System.Drawing.Size(146, 21)
        Me.cbSubOferID.TabIndex = 15
        Me.cbSubOferID.Tag = "0"
        '
        'gvDisp
        '
        Me.gvDisp.AllowUserToAddRows = False
        Me.gvDisp.AllowUserToDeleteRows = False
        Me.gvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDisp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjOffID, Me.SubjectTitle, Me.Description, Me.TimeIn, Me.TimeOut, Me.Days, Me.Terms, Me.Room, Me.Units, Me.enrolNo})
        Me.gvDisp.Location = New System.Drawing.Point(2, 168)
        Me.gvDisp.Margin = New System.Windows.Forms.Padding(2)
        Me.gvDisp.MultiSelect = False
        Me.gvDisp.Name = "gvDisp"
        Me.gvDisp.ReadOnly = True
        Me.gvDisp.RowHeadersVisible = False
        Me.gvDisp.RowTemplate.Height = 24
        Me.gvDisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvDisp.Size = New System.Drawing.Size(1019, 267)
        Me.gvDisp.TabIndex = 12
        '
        'SubjOffID
        '
        Me.SubjOffID.DataPropertyName = "SubjectOfferingID"
        Me.SubjOffID.HeaderText = "Code"
        Me.SubjOffID.Name = "SubjOffID"
        Me.SubjOffID.ReadOnly = True
        Me.SubjOffID.Width = 200
        '
        'SubjectTitle
        '
        Me.SubjectTitle.DataPropertyName = "SubjectTitle"
        Me.SubjectTitle.HeaderText = "Subj Title"
        Me.SubjectTitle.Name = "SubjectTitle"
        Me.SubjectTitle.ReadOnly = True
        Me.SubjectTitle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'TimeIn
        '
        Me.TimeIn.DataPropertyName = "TimeIn"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TimeIn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TimeIn.HeaderText = "Time Start"
        Me.TimeIn.Name = "TimeIn"
        Me.TimeIn.ReadOnly = True
        '
        'TimeOut
        '
        Me.TimeOut.DataPropertyName = "TimeOut"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TimeOut.DefaultCellStyle = DataGridViewCellStyle2
        Me.TimeOut.HeaderText = "Time End"
        Me.TimeOut.Name = "TimeOut"
        Me.TimeOut.ReadOnly = True
        '
        'Days
        '
        Me.Days.DataPropertyName = "Days"
        Me.Days.HeaderText = "Days"
        Me.Days.Name = "Days"
        Me.Days.ReadOnly = True
        '
        'Terms
        '
        Me.Terms.DataPropertyName = "Terms"
        Me.Terms.HeaderText = "Terms"
        Me.Terms.Name = "Terms"
        Me.Terms.ReadOnly = True
        '
        'Room
        '
        Me.Room.DataPropertyName = "Room"
        Me.Room.HeaderText = "Room"
        Me.Room.Name = "Room"
        Me.Room.ReadOnly = True
        Me.Room.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Room.Width = 200
        '
        'Units
        '
        Me.Units.DataPropertyName = "Units"
        Me.Units.HeaderText = "Units"
        Me.Units.Name = "Units"
        Me.Units.ReadOnly = True
        '
        'enrolNo
        '
        Me.enrolNo.DataPropertyName = "enrolNo"
        Me.enrolNo.HeaderText = "EnrollNo"
        Me.enrolNo.Name = "enrolNo"
        Me.enrolNo.ReadOnly = True
        Me.enrolNo.Visible = False
        '
        'cbId
        '
        Me.cbId.DataSource = Me.TblStudentBindingSource
        Me.cbId.DisplayMember = "StudentID"
        Me.cbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbId.FormattingEnabled = True
        Me.cbId.Location = New System.Drawing.Point(82, 9)
        Me.cbId.Margin = New System.Windows.Forms.Padding(2)
        Me.cbId.Name = "cbId"
        Me.cbId.Size = New System.Drawing.Size(148, 21)
        Me.cbId.TabIndex = 14
        Me.cbId.ValueMember = "StudentID"
        '
        'cbYear
        '
        Me.cbYear.DataSource = Me.TblSchoolYearBindingSource
        Me.cbYear.DisplayMember = "SchoolYear"
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(108, 43)
        Me.cbYear.Margin = New System.Windows.Forms.Padding(2)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(92, 21)
        Me.cbYear.TabIndex = 15
        '
        'cbSem
        '
        Me.cbSem.DataSource = Me.TblSemesterBindingSource
        Me.cbSem.DisplayMember = "Semester"
        Me.cbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSem.FormattingEnabled = True
        Me.cbSem.Location = New System.Drawing.Point(279, 43)
        Me.cbSem.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSem.Name = "cbSem"
        Me.cbSem.Size = New System.Drawing.Size(92, 21)
        Me.cbSem.TabIndex = 16
        Me.cbSem.ValueMember = "SemesterID"
        '
        'cbCourse
        '
        Me.cbCourse.DataSource = Me.TblCourseBindingSource
        Me.cbCourse.DisplayMember = "Course"
        Me.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Location = New System.Drawing.Point(106, 78)
        Me.cbCourse.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(263, 21)
        Me.cbCourse.TabIndex = 17
        Me.cbCourse.ValueMember = "CourseID"
        '
        'cbLvl
        '
        Me.cbLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLvl.FormattingEnabled = True
        Me.cbLvl.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbLvl.Location = New System.Drawing.Point(436, 78)
        Me.cbLvl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbLvl.Name = "cbLvl"
        Me.cbLvl.Size = New System.Drawing.Size(72, 21)
        Me.cbLvl.TabIndex = 18
        '
        'cbNym
        '
        Me.cbNym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNym.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNym.FormattingEnabled = True
        Me.cbNym.Location = New System.Drawing.Point(322, 9)
        Me.cbNym.Margin = New System.Windows.Forms.Padding(2)
        Me.cbNym.Name = "cbNym"
        Me.cbNym.Size = New System.Drawing.Size(310, 21)
        Me.cbNym.TabIndex = 20
        '
        'dpDyt
        '
        Me.dpDyt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDyt.Location = New System.Drawing.Point(488, 43)
        Me.dpDyt.Margin = New System.Windows.Forms.Padding(2)
        Me.dpDyt.Name = "dpDyt"
        Me.dpDyt.Size = New System.Drawing.Size(86, 20)
        Me.dpDyt.TabIndex = 24
        '
        'bDel
        '
        Me.bDel.Location = New System.Drawing.Point(430, 457)
        Me.bDel.Margin = New System.Windows.Forms.Padding(2)
        Me.bDel.Name = "bDel"
        Me.bDel.Size = New System.Drawing.Size(62, 27)
        Me.bDel.TabIndex = 28
        Me.bDel.Text = "Dropped"
        Me.bDel.UseVisualStyleBackColor = True
        '
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(360, 457)
        Me.bEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(62, 27)
        Me.bEdit.TabIndex = 27
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bNew
        '
        Me.bNew.Location = New System.Drawing.Point(289, 457)
        Me.bNew.Margin = New System.Windows.Forms.Padding(2)
        Me.bNew.Name = "bNew"
        Me.bNew.Size = New System.Drawing.Size(62, 27)
        Me.bNew.TabIndex = 26
        Me.bNew.Tag = "0"
        Me.bNew.Text = "New"
        Me.bNew.UseVisualStyleBackColor = True
        '
        'bPrint
        '
        Me.bPrint.Location = New System.Drawing.Point(586, 457)
        Me.bPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(94, 27)
        Me.bPrint.TabIndex = 29
        Me.bPrint.Text = "Export to Excel"
        Me.bPrint.UseVisualStyleBackColor = True
        '
        'bAddStud
        '
        Me.bAddStud.Location = New System.Drawing.Point(648, 5)
        Me.bAddStud.Margin = New System.Windows.Forms.Padding(2)
        Me.bAddStud.Name = "bAddStud"
        Me.bAddStud.Size = New System.Drawing.Size(99, 28)
        Me.bAddStud.TabIndex = 30
        Me.bAddStud.Text = "Add Student"
        Me.bAddStud.UseVisualStyleBackColor = True
        '
        'lTots
        '
        Me.lTots.AutoSize = True
        Me.lTots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTots.Location = New System.Drawing.Point(706, 445)
        Me.lTots.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTots.Name = "lTots"
        Me.lTots.Size = New System.Drawing.Size(88, 13)
        Me.lTots.TabIndex = 31
        Me.lTots.Text = "Total Units : 0"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(497, 457)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 27)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Print Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pict_logo
        '
        Me.pict_logo.Image = Global.EnrollSys.My.Resources.Resources._18x18_logo_samson
        Me.pict_logo.Location = New System.Drawing.Point(836, 11)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(121, 97)
        Me.pict_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pict_logo.TabIndex = 33
        Me.pict_logo.TabStop = False
        Me.pict_logo.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbId)
        Me.Panel2.Controls.Add(SchoolYearLabel)
        Me.Panel2.Controls.Add(SemesterLabel)
        Me.Panel2.Controls.Add(CourseLabel)
        Me.Panel2.Controls.Add(Me.bAddStud)
        Me.Panel2.Controls.Add(StudentIDLabel1)
        Me.Panel2.Controls.Add(Me.cbYear)
        Me.Panel2.Controls.Add(Me.cbSem)
        Me.Panel2.Controls.Add(Me.cbCourse)
        Me.Panel2.Controls.Add(Me.cbLvl)
        Me.Panel2.Controls.Add(Label8)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Controls.Add(Me.dpDyt)
        Me.Panel2.Controls.Add(Me.cbNym)
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Location = New System.Drawing.Point(32, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 109)
        Me.Panel2.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(709, 460)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'EnrollFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 494)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pict_logo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lTots)
        Me.Controls.Add(Me.bPrint)
        Me.Controls.Add(Me.bDel)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.bNew)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gvDisp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnrollFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchoolYearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSemesterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gvDisp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MstDataSet As EnrollSys.MstDataSet
    Friend WithEvents TblSchoolYearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSchoolYearTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSchoolYearTableAdapter
    Friend WithEvents TableAdapterManager As EnrollSys.MstDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSemesterTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSemesterTableAdapter
    Friend WithEvents TblSemesterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCourseTableAdapter As EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter
    Friend WithEvents TblCourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStudentTableAdapter As EnrollSys.MstDataSetTableAdapters.tblStudentTableAdapter
    Friend WithEvents TblStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gvDisp As System.Windows.Forms.DataGridView
    Friend WithEvents cbId As System.Windows.Forms.ComboBox
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbSem As System.Windows.Forms.ComboBox
    Friend WithEvents cbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cbLvl As System.Windows.Forms.ComboBox
    Friend WithEvents cbNym As System.Windows.Forms.ComboBox
    Friend WithEvents cbSubOferID As System.Windows.Forms.ComboBox
    Friend WithEvents dpDyt As System.Windows.Forms.DateTimePicker
    Friend WithEvents tUnits As System.Windows.Forms.TextBox
    Friend WithEvents tRoom As System.Windows.Forms.TextBox
    Friend WithEvents tDays As System.Windows.Forms.TextBox
    Friend WithEvents tTymOut As System.Windows.Forms.TextBox
    Friend WithEvents tTymIn As System.Windows.Forms.TextBox
    Friend WithEvents tSubjDesc As System.Windows.Forms.TextBox
    Friend WithEvents tSubTitle As System.Windows.Forms.TextBox
    Friend WithEvents bDel As System.Windows.Forms.Button
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents bNew As System.Windows.Forms.Button
    Friend WithEvents bPrint As System.Windows.Forms.Button
    Friend WithEvents bAddStud As System.Windows.Forms.Button
    Friend WithEvents lTots As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pict_logo As System.Windows.Forms.PictureBox
    Friend WithEvents tTerm As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbTerm As System.Windows.Forms.ComboBox
    Friend WithEvents SubjOffID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Days As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Terms As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Units As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents enrolNo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

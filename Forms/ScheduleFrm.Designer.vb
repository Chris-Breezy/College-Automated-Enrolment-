<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleFrm
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
        Dim CourseLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim SubjectOfferingIDLabel As System.Windows.Forms.Label
        Dim SubjectIDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleFrm))
        Me.MstDataSet = New EnrollSys.MstDataSet()
        Me.TblSchoolYearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSchoolYearTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSchoolYearTableAdapter()
        Me.TableAdapterManager = New EnrollSys.MstDataSetTableAdapters.TableAdapterManager()
        Me.TblCourseTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter()
        Me.TblSemesterTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSemesterTableAdapter()
        Me.SchoolYearComboBox = New System.Windows.Forms.ComboBox()
        Me.TblSchoolYearBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.TblSemesterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbSem = New System.Windows.Forms.ComboBox()
        Me.TblSubjectOfferingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSubjectOfferingTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSubjectOfferingTableAdapter()
        Me.TblSectionTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSectionTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbSec = New System.Windows.Forms.ComboBox()
        Me.bAddSec = New System.Windows.Forms.Button()
        Me.gvDisp = New System.Windows.Forms.DataGridView()
        Me.TblSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstDataSet1 = New EnrollSys.MstDataSet()
        Me.TblRoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbTerm = New System.Windows.Forms.ComboBox()
        Me.tSlot = New System.Windows.Forms.NumericUpDown()
        Me.cbRoom = New System.Windows.Forms.ComboBox()
        Me.tDays = New System.Windows.Forms.TextBox()
        Me.dpTimeOut = New System.Windows.Forms.DateTimePicker()
        Me.dpTimeIn = New System.Windows.Forms.DateTimePicker()
        Me.cbSubj = New System.Windows.Forms.ComboBox()
        Me.tCode = New System.Windows.Forms.TextBox()
        Me.TblSubjectTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSubjectTableAdapter()
        Me.bNew = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bDel = New System.Windows.Forms.Button()
        Me.TblRoomTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblRoomTableAdapter()
        Me.cbLvl = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MstDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTeacherTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblTeacherTableAdapter()
        Me.lUnits = New System.Windows.Forms.Label()
        Me.TblRoomtblSubjectOfferingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjOffID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Terms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MaxSlot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        SchoolYearLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        SubjectOfferingIDLabel = New System.Windows.Forms.Label()
        SubjectIDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchoolYearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchoolYearBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSemesterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSubjectOfferingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDisp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.tSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.MstDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRoomtblSubjectOfferingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchoolYearLabel
        '
        SchoolYearLabel.AutoSize = True
        SchoolYearLabel.Location = New System.Drawing.Point(6, 6)
        SchoolYearLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SchoolYearLabel.Name = "SchoolYearLabel"
        SchoolYearLabel.Size = New System.Drawing.Size(68, 13)
        SchoolYearLabel.TabIndex = 1
        SchoolYearLabel.Text = "School Year:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(30, 42)
        CourseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(43, 13)
        CourseLabel.TabIndex = 3
        CourseLabel.Text = "Course:"
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Location = New System.Drawing.Point(190, 6)
        SemesterLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(54, 13)
        SemesterLabel.TabIndex = 5
        SemesterLabel.Text = "Semester:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(-4, 74)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(88, 13)
        Label1.TabIndex = 8
        Label1.Text = "Section/Session:"
        '
        'SubjectOfferingIDLabel
        '
        SubjectOfferingIDLabel.AutoSize = True
        SubjectOfferingIDLabel.Location = New System.Drawing.Point(2, 5)
        SubjectOfferingIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SubjectOfferingIDLabel.Name = "SubjectOfferingIDLabel"
        SubjectOfferingIDLabel.Size = New System.Drawing.Size(100, 13)
        SubjectOfferingIDLabel.TabIndex = 0
        SubjectOfferingIDLabel.Text = "Subject Offering ID:"
        '
        'SubjectIDLabel
        '
        SubjectIDLabel.AutoSize = True
        SubjectIDLabel.Location = New System.Drawing.Point(133, 5)
        SubjectIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SubjectIDLabel.Name = "SubjectIDLabel"
        SubjectIDLabel.Size = New System.Drawing.Size(46, 13)
        SubjectIDLabel.TabIndex = 2
        SubjectIDLabel.Text = "Subject:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(223, 5)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 13)
        Label2.TabIndex = 8
        Label2.Text = "Time Start:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(323, 5)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 13)
        Label3.TabIndex = 9
        Label3.Text = "Time End:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(431, 6)
        Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(34, 13)
        Label4.TabIndex = 10
        Label4.Text = "Days:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(633, 3)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 11
        Label5.Text = "Room:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(709, 5)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(28, 13)
        Label6.TabIndex = 14
        Label6.Text = "Slot:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(457, 25)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(63, 13)
        Label7.TabIndex = 16
        Label7.Text = "Year/Level:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(534, 6)
        Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(34, 13)
        Label10.TabIndex = 39
        Label10.Text = "Term:"
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
        Me.TableAdapterManager.tblStudentTableAdapter = Nothing
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
        'SchoolYearComboBox
        '
        Me.SchoolYearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSchoolYearBindingSource, "SchoolYear", True))
        Me.SchoolYearComboBox.DataSource = Me.TblSchoolYearBindingSource1
        Me.SchoolYearComboBox.DisplayMember = "SchoolYear"
        Me.SchoolYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SchoolYearComboBox.FormattingEnabled = True
        Me.SchoolYearComboBox.Location = New System.Drawing.Point(77, 4)
        Me.SchoolYearComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SchoolYearComboBox.Name = "SchoolYearComboBox"
        Me.SchoolYearComboBox.Size = New System.Drawing.Size(109, 21)
        Me.SchoolYearComboBox.TabIndex = 0
        Me.SchoolYearComboBox.ValueMember = "SchoolYear"
        '
        'TblSchoolYearBindingSource1
        '
        Me.TblSchoolYearBindingSource1.DataMember = "tblSchoolYear"
        Me.TblSchoolYearBindingSource1.DataSource = Me.MstDataSet
        '
        'TblCourseBindingSource
        '
        Me.TblCourseBindingSource.DataMember = "tblCourse"
        Me.TblCourseBindingSource.DataSource = Me.MstDataSet
        '
        'cbCourse
        '
        Me.cbCourse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCourseBindingSource, "Course", True))
        Me.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Location = New System.Drawing.Point(77, 40)
        Me.cbCourse.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(296, 21)
        Me.cbCourse.TabIndex = 3
        '
        'TblSemesterBindingSource
        '
        Me.TblSemesterBindingSource.DataMember = "tblSemester"
        Me.TblSemesterBindingSource.DataSource = Me.MstDataSet
        '
        'cbSem
        '
        Me.cbSem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSemesterBindingSource, "Semester", True))
        Me.cbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSem.FormattingEnabled = True
        Me.cbSem.Location = New System.Drawing.Point(248, 4)
        Me.cbSem.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSem.Name = "cbSem"
        Me.cbSem.Size = New System.Drawing.Size(112, 21)
        Me.cbSem.TabIndex = 1
        '
        'TblSubjectOfferingBindingSource
        '
        Me.TblSubjectOfferingBindingSource.DataMember = "tblSubjectOffering"
        Me.TblSubjectOfferingBindingSource.DataSource = Me.MstDataSet
        '
        'TblSubjectOfferingTableAdapter
        '
        Me.TblSubjectOfferingTableAdapter.ClearBeforeFill = True
        '
        'TblSectionTableAdapter
        '
        Me.TblSectionTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 421)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'cbSec
        '
        Me.cbSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSec.FormattingEnabled = True
        Me.cbSec.Location = New System.Drawing.Point(77, 71)
        Me.cbSec.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSec.Name = "cbSec"
        Me.cbSec.Size = New System.Drawing.Size(109, 21)
        Me.cbSec.TabIndex = 7
        '
        'bAddSec
        '
        Me.bAddSec.Location = New System.Drawing.Point(192, 71)
        Me.bAddSec.Margin = New System.Windows.Forms.Padding(2)
        Me.bAddSec.Name = "bAddSec"
        Me.bAddSec.Size = New System.Drawing.Size(82, 20)
        Me.bAddSec.TabIndex = 9
        Me.bAddSec.Text = "Add Section"
        Me.bAddSec.UseVisualStyleBackColor = True
        '
        'gvDisp
        '
        Me.gvDisp.AllowUserToAddRows = False
        Me.gvDisp.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvDisp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDisp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjOffID, Me.SubjectID, Me.TimeIn, Me.TimeOut, Me.Days, Me.Terms, Me.RoomID, Me.MaxSlot, Me.SectionID})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvDisp.DefaultCellStyle = DataGridViewCellStyle4
        Me.gvDisp.Location = New System.Drawing.Point(15, 165)
        Me.gvDisp.Margin = New System.Windows.Forms.Padding(2)
        Me.gvDisp.MultiSelect = False
        Me.gvDisp.Name = "gvDisp"
        Me.gvDisp.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvDisp.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gvDisp.RowHeadersVisible = False
        Me.gvDisp.RowTemplate.Height = 24
        Me.gvDisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvDisp.Size = New System.Drawing.Size(863, 251)
        Me.gvDisp.TabIndex = 10
        '
        'TblSubjectBindingSource
        '
        Me.TblSubjectBindingSource.DataMember = "tblSubject"
        Me.TblSubjectBindingSource.DataSource = Me.MstDataSet1
        '
        'MstDataSet1
        '
        Me.MstDataSet1.DataSetName = "MstDataSet"
        Me.MstDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRoomBindingSource
        '
        Me.TblRoomBindingSource.DataMember = "tblRoom"
        Me.TblRoomBindingSource.DataSource = Me.MstDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.cbTerm)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Me.tSlot)
        Me.Panel1.Controls.Add(Me.cbRoom)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.tDays)
        Me.Panel1.Controls.Add(Me.dpTimeOut)
        Me.Panel1.Controls.Add(Me.dpTimeIn)
        Me.Panel1.Controls.Add(Me.cbSubj)
        Me.Panel1.Controls.Add(Me.tCode)
        Me.Panel1.Controls.Add(SubjectIDLabel)
        Me.Panel1.Controls.Add(SubjectOfferingIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(21, 110)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 50)
        Me.Panel1.TabIndex = 11
        Me.Panel1.Visible = False
        '
        'cbTerm
        '
        Me.cbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTerm.FormattingEnabled = True
        Me.cbTerm.Items.AddRange(New Object() {"1st", "2nd", "Summer"})
        Me.cbTerm.Location = New System.Drawing.Point(507, 21)
        Me.cbTerm.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTerm.Name = "cbTerm"
        Me.cbTerm.Size = New System.Drawing.Size(92, 21)
        Me.cbTerm.TabIndex = 38
        '
        'tSlot
        '
        Me.tSlot.Location = New System.Drawing.Point(702, 21)
        Me.tSlot.Margin = New System.Windows.Forms.Padding(2)
        Me.tSlot.Name = "tSlot"
        Me.tSlot.Size = New System.Drawing.Size(43, 20)
        Me.tSlot.TabIndex = 13
        Me.tSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbRoom
        '
        Me.cbRoom.DataSource = Me.TblRoomBindingSource
        Me.cbRoom.DisplayMember = "Room"
        Me.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRoom.FormattingEnabled = True
        Me.cbRoom.Location = New System.Drawing.Point(603, 20)
        Me.cbRoom.Margin = New System.Windows.Forms.Padding(2)
        Me.cbRoom.Name = "cbRoom"
        Me.cbRoom.Size = New System.Drawing.Size(92, 21)
        Me.cbRoom.TabIndex = 12
        Me.cbRoom.ValueMember = "RoomID"
        '
        'tDays
        '
        Me.tDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tDays.Location = New System.Drawing.Point(406, 22)
        Me.tDays.Margin = New System.Windows.Forms.Padding(2)
        Me.tDays.Name = "tDays"
        Me.tDays.Size = New System.Drawing.Size(97, 20)
        Me.tDays.TabIndex = 7
        '
        'dpTimeOut
        '
        Me.dpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dpTimeOut.Location = New System.Drawing.Point(306, 20)
        Me.dpTimeOut.Margin = New System.Windows.Forms.Padding(2)
        Me.dpTimeOut.Name = "dpTimeOut"
        Me.dpTimeOut.ShowUpDown = True
        Me.dpTimeOut.Size = New System.Drawing.Size(96, 20)
        Me.dpTimeOut.TabIndex = 6
        '
        'dpTimeIn
        '
        Me.dpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dpTimeIn.Location = New System.Drawing.Point(206, 20)
        Me.dpTimeIn.Margin = New System.Windows.Forms.Padding(2)
        Me.dpTimeIn.Name = "dpTimeIn"
        Me.dpTimeIn.ShowUpDown = True
        Me.dpTimeIn.Size = New System.Drawing.Size(96, 20)
        Me.dpTimeIn.TabIndex = 5
        '
        'cbSubj
        '
        Me.cbSubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSubj.FormattingEnabled = True
        Me.cbSubj.Location = New System.Drawing.Point(110, 20)
        Me.cbSubj.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSubj.Name = "cbSubj"
        Me.cbSubj.Size = New System.Drawing.Size(92, 21)
        Me.cbSubj.TabIndex = 4
        '
        'tCode
        '
        Me.tCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tCode.Location = New System.Drawing.Point(4, 21)
        Me.tCode.Margin = New System.Windows.Forms.Padding(2)
        Me.tCode.Name = "tCode"
        Me.tCode.Size = New System.Drawing.Size(97, 20)
        Me.tCode.TabIndex = 3
        '
        'TblSubjectTableAdapter
        '
        Me.TblSubjectTableAdapter.ClearBeforeFill = True
        '
        'bNew
        '
        Me.bNew.Location = New System.Drawing.Point(332, 426)
        Me.bNew.Margin = New System.Windows.Forms.Padding(2)
        Me.bNew.Name = "bNew"
        Me.bNew.Size = New System.Drawing.Size(62, 27)
        Me.bNew.TabIndex = 12
        Me.bNew.Tag = "0"
        Me.bNew.Text = "New"
        Me.bNew.UseVisualStyleBackColor = True
        '
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(403, 426)
        Me.bEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(62, 27)
        Me.bEdit.TabIndex = 13
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bDel
        '
        Me.bDel.Location = New System.Drawing.Point(473, 426)
        Me.bDel.Margin = New System.Windows.Forms.Padding(2)
        Me.bDel.Name = "bDel"
        Me.bDel.Size = New System.Drawing.Size(62, 27)
        Me.bDel.TabIndex = 14
        Me.bDel.Text = "Delete"
        Me.bDel.UseVisualStyleBackColor = True
        '
        'TblRoomTableAdapter
        '
        Me.TblRoomTableAdapter.ClearBeforeFill = True
        '
        'cbLvl
        '
        Me.cbLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLvl.FormattingEnabled = True
        Me.cbLvl.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbLvl.Location = New System.Drawing.Point(452, 40)
        Me.cbLvl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbLvl.Name = "cbLvl"
        Me.cbLvl.Size = New System.Drawing.Size(109, 21)
        Me.cbLvl.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbCourse)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Controls.Add(Me.SchoolYearComboBox)
        Me.Panel2.Controls.Add(Me.cbLvl)
        Me.Panel2.Controls.Add(SchoolYearLabel)
        Me.Panel2.Controls.Add(CourseLabel)
        Me.Panel2.Controls.Add(Me.cbSem)
        Me.Panel2.Controls.Add(SemesterLabel)
        Me.Panel2.Controls.Add(Me.cbSec)
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.bAddSec)
        Me.Panel2.Location = New System.Drawing.Point(15, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(699, 96)
        Me.Panel2.TabIndex = 17
        '
        'MstDataSetBindingSource
        '
        Me.MstDataSetBindingSource.DataSource = Me.MstDataSet
        Me.MstDataSetBindingSource.Position = 0
        '
        'TblTeacherBindingSource
        '
        Me.TblTeacherBindingSource.DataMember = "tblTeacher"
        Me.TblTeacherBindingSource.DataSource = Me.MstDataSet
        '
        'TblTeacherTableAdapter
        '
        Me.TblTeacherTableAdapter.ClearBeforeFill = True
        '
        'lUnits
        '
        Me.lUnits.AutoSize = True
        Me.lUnits.Location = New System.Drawing.Point(703, 433)
        Me.lUnits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lUnits.Name = "lUnits"
        Me.lUnits.Size = New System.Drawing.Size(13, 13)
        Me.lUnits.TabIndex = 18
        Me.lUnits.Text = "0"
        Me.lUnits.Visible = False
        '
        'TblRoomtblSubjectOfferingBindingSource
        '
        Me.TblRoomtblSubjectOfferingBindingSource.DataMember = "tblRoomtblSubjectOffering"
        Me.TblRoomtblSubjectOfferingBindingSource.DataSource = Me.TblRoomBindingSource
        '
        'SubjOffID
        '
        Me.SubjOffID.DataPropertyName = "SubjectOfferingID"
        Me.SubjOffID.HeaderText = "Code"
        Me.SubjOffID.Name = "SubjOffID"
        Me.SubjOffID.ReadOnly = True
        Me.SubjOffID.Width = 200
        '
        'SubjectID
        '
        Me.SubjectID.DataPropertyName = "SubjectID"
        Me.SubjectID.DataSource = Me.TblSubjectBindingSource
        Me.SubjectID.DisplayMember = "SubjectTitle"
        Me.SubjectID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.SubjectID.HeaderText = "Subj Title"
        Me.SubjectID.Name = "SubjectID"
        Me.SubjectID.ReadOnly = True
        Me.SubjectID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SubjectID.ValueMember = "SubjectID"
        '
        'TimeIn
        '
        Me.TimeIn.DataPropertyName = "TimeIn"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TimeIn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TimeIn.HeaderText = "Time Start"
        Me.TimeIn.Name = "TimeIn"
        Me.TimeIn.ReadOnly = True
        '
        'TimeOut
        '
        Me.TimeOut.DataPropertyName = "TimeOut"
        DataGridViewCellStyle3.Format = "t"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TimeOut.DefaultCellStyle = DataGridViewCellStyle3
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
        Me.Terms.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'RoomID
        '
        Me.RoomID.DataPropertyName = "RoomID"
        Me.RoomID.DataSource = Me.TblRoomtblSubjectOfferingBindingSource
        Me.RoomID.DisplayMember = "Room"
        Me.RoomID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.RoomID.HeaderText = "Room"
        Me.RoomID.Name = "RoomID"
        Me.RoomID.ReadOnly = True
        Me.RoomID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RoomID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RoomID.ValueMember = "RoomID"
        Me.RoomID.Width = 200
        '
        'MaxSlot
        '
        Me.MaxSlot.DataPropertyName = "MaxSlot"
        Me.MaxSlot.HeaderText = "Slot"
        Me.MaxSlot.Name = "MaxSlot"
        Me.MaxSlot.ReadOnly = True
        '
        'SectionID
        '
        Me.SectionID.DataPropertyName = "SectionID"
        Me.SectionID.HeaderText = "SectionID"
        Me.SectionID.Name = "SectionID"
        Me.SectionID.ReadOnly = True
        Me.SectionID.Visible = False
        '
        'ScheduleFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 464)
        Me.Controls.Add(Me.lUnits)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.bDel)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.bNew)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gvDisp)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScheduleFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Scheduling"
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchoolYearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchoolYearBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSemesterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSubjectOfferingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDisp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tSlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MstDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRoomtblSubjectOfferingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MstDataSet As EnrollSys.MstDataSet
    Friend WithEvents TblSchoolYearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSchoolYearTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSchoolYearTableAdapter
    Friend WithEvents TableAdapterManager As EnrollSys.MstDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCourseTableAdapter As EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter
    Friend WithEvents SchoolYearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblCourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSemesterTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSemesterTableAdapter
    Friend WithEvents cbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents TblSemesterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cbSem As System.Windows.Forms.ComboBox
    Friend WithEvents TblSchoolYearBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblSubjectOfferingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSubjectOfferingTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSubjectOfferingTableAdapter
    Friend WithEvents TblSectionTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSectionTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbSec As System.Windows.Forms.ComboBox
    Friend WithEvents bAddSec As System.Windows.Forms.Button
    Friend WithEvents gvDisp As System.Windows.Forms.DataGridView
    Friend WithEvents MstDataSet1 As EnrollSys.MstDataSet
    Friend WithEvents TblSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSubjectTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSubjectTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbSubj As System.Windows.Forms.ComboBox
    Friend WithEvents tCode As System.Windows.Forms.TextBox
    Friend WithEvents tDays As System.Windows.Forms.TextBox
    Friend WithEvents dpTimeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpTimeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents bNew As System.Windows.Forms.Button
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents bDel As System.Windows.Forms.Button
    Friend WithEvents cbRoom As System.Windows.Forms.ComboBox
    Friend WithEvents TblRoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRoomTableAdapter As EnrollSys.MstDataSetTableAdapters.tblRoomTableAdapter
    Friend WithEvents tSlot As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbLvl As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MstDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTeacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTeacherTableAdapter As EnrollSys.MstDataSetTableAdapters.tblTeacherTableAdapter
    Friend WithEvents lUnits As System.Windows.Forms.Label
    Friend WithEvents cbTerm As System.Windows.Forms.ComboBox
    Friend WithEvents SubjOffID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Days As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Terms As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblRoomtblSubjectOfferingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaxSlot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

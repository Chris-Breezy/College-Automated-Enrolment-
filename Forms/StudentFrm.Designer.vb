<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentFrm
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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim BloodTypeLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PlaceOfBirthLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim CitizenshipLabel As System.Windows.Forms.Label
        Dim Date_FileLabel As System.Windows.Forms.Label
        Dim CourseIDLabel As System.Windows.Forms.Label
        Dim SessionLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim ProvAddLabel As System.Windows.Forms.Label
        Dim NoOfSiblingsLabel As System.Windows.Forms.Label
        Dim SiblingPositionLabel As System.Windows.Forms.Label
        Dim LastSchoolNameLabel As System.Windows.Forms.Label
        Dim Lang_DialectLabel As System.Windows.Forms.Label
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim FatherWorkLabel As System.Windows.Forms.Label
        Dim FatherContactLabel As System.Windows.Forms.Label
        Dim MotherNameLabel As System.Windows.Forms.Label
        Dim MotherWorkLabel As System.Windows.Forms.Label
        Dim MotherContactLabel As System.Windows.Forms.Label
        Dim Emergency_NameLabel As System.Windows.Forms.Label
        Dim Emergency_RelationLabel As System.Windows.Forms.Label
        Dim Emergency_ContactLabel As System.Windows.Forms.Label
        Dim Emergency_AddLabel As System.Windows.Forms.Label
        Dim Live_NameLabel As System.Windows.Forms.Label
        Dim Live_RelationLabel As System.Windows.Forms.Label
        Dim Live_ContactLabel As System.Windows.Forms.Label
        Dim Live_AddLabel As System.Windows.Forms.Label
        Dim Educ_CourseLabel As System.Windows.Forms.Label
        Dim Educ_DeptLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Last_CourseLabel As System.Windows.Forms.Label
        Dim ElementaryLabel As System.Windows.Forms.Label
        Dim Elem_AwardLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim HighSchoolLabel As System.Windows.Forms.Label
        Dim Highest_EducLabel As System.Windows.Forms.Label
        Dim Highest_YearLabel As System.Windows.Forms.Label
        Dim Highest_SectionLabel As System.Windows.Forms.Label
        Dim Highest_AddLabel As System.Windows.Forms.Label
        Dim Old_StudLabel As System.Windows.Forms.Label
        Dim New_StudLabel As System.Windows.Forms.Label
        Dim ReturneeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentFrm))
        Me.TblStudentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstDataSet = New EnrollSys.MstDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblStudentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TblStudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CourseIDComboBox = New System.Windows.Forms.ComboBox()
        Me.MotherContactTextBox = New System.Windows.Forms.TextBox()
        Me.MotherWorkTextBox = New System.Windows.Forms.TextBox()
        Me.MotherNameTextBox = New System.Windows.Forms.TextBox()
        Me.FatherContactTextBox = New System.Windows.Forms.TextBox()
        Me.FatherWorkTextBox = New System.Windows.Forms.TextBox()
        Me.FatherNameTextBox = New System.Windows.Forms.TextBox()
        Me.Lang_DialectTextBox = New System.Windows.Forms.TextBox()
        Me.SiblingPositionNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NoOfSiblingsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProvAddTextBox = New System.Windows.Forms.TextBox()
        Me.WeightNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HeightNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SessionTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.ReligionTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.BloodTypeTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.PlaceOfBirthTextBox = New System.Windows.Forms.TextBox()
        Me.CitizenshipTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Live_AddTextBox = New System.Windows.Forms.TextBox()
        Me.Live_ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Live_RelationTextBox = New System.Windows.Forms.TextBox()
        Me.Live_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Emergency_AddTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_RelationTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReturneeRadioButton = New System.Windows.Forms.RadioButton()
        Me.New_StudRadioButton = New System.Windows.Forms.RadioButton()
        Me.Old_StudRadioButton = New System.Windows.Forms.RadioButton()
        Me.Highest_AddTextBox = New System.Windows.Forms.TextBox()
        Me.Highest_SectionTextBox = New System.Windows.Forms.TextBox()
        Me.Highest_YearTextBox = New System.Windows.Forms.TextBox()
        Me.Highest_EducTextBox = New System.Windows.Forms.TextBox()
        Me.HighSchool_AwardTextBox = New System.Windows.Forms.TextBox()
        Me.HighSchool_YearTextBox = New System.Windows.Forms.TextBox()
        Me.HighSchoolTextBox = New System.Windows.Forms.TextBox()
        Me.Elem_AwardTextBox = New System.Windows.Forms.TextBox()
        Me.Elem_YearTextBox = New System.Windows.Forms.TextBox()
        Me.ElementaryTextBox = New System.Windows.Forms.TextBox()
        Me.Last_CourseTextBox = New System.Windows.Forms.TextBox()
        Me.Educ_DeptTextBox = New System.Windows.Forms.TextBox()
        Me.Educ_CourseTextBox = New System.Windows.Forms.TextBox()
        Me.LastSchoolNameTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Survey_Other_SpecifyTextBox = New System.Windows.Forms.TextBox()
        Me.Survey_OtherCheckBox = New System.Windows.Forms.CheckBox()
        Me.Survey_TVCheckBox = New System.Windows.Forms.CheckBox()
        Me.Survey_RadioCheckBox = New System.Windows.Forms.CheckBox()
        Me.Survey_NewsCheckBox = New System.Windows.Forms.CheckBox()
        Me.Survey_BoucherCheckBox = New System.Windows.Forms.CheckBox()
        Me.Survey_CareerCheckBox = New System.Windows.Forms.CheckBox()
        Me.Survey_Friend_RelCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TblCourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Date_FileDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TblStudentTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblStudentTableAdapter()
        Me.TableAdapterManager = New EnrollSys.MstDataSetTableAdapters.TableAdapterManager()
        Me.TblCourseTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter()
        Me.tFind = New System.Windows.Forms.TextBox()
        Me.bFind = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        StudentIDLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        BloodTypeLabel = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        PlaceOfBirthLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        BirthDateLabel = New System.Windows.Forms.Label()
        CitizenshipLabel = New System.Windows.Forms.Label()
        Date_FileLabel = New System.Windows.Forms.Label()
        CourseIDLabel = New System.Windows.Forms.Label()
        SessionLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        ProvAddLabel = New System.Windows.Forms.Label()
        NoOfSiblingsLabel = New System.Windows.Forms.Label()
        SiblingPositionLabel = New System.Windows.Forms.Label()
        LastSchoolNameLabel = New System.Windows.Forms.Label()
        Lang_DialectLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        FatherWorkLabel = New System.Windows.Forms.Label()
        FatherContactLabel = New System.Windows.Forms.Label()
        MotherNameLabel = New System.Windows.Forms.Label()
        MotherWorkLabel = New System.Windows.Forms.Label()
        MotherContactLabel = New System.Windows.Forms.Label()
        Emergency_NameLabel = New System.Windows.Forms.Label()
        Emergency_RelationLabel = New System.Windows.Forms.Label()
        Emergency_ContactLabel = New System.Windows.Forms.Label()
        Emergency_AddLabel = New System.Windows.Forms.Label()
        Live_NameLabel = New System.Windows.Forms.Label()
        Live_RelationLabel = New System.Windows.Forms.Label()
        Live_ContactLabel = New System.Windows.Forms.Label()
        Live_AddLabel = New System.Windows.Forms.Label()
        Educ_CourseLabel = New System.Windows.Forms.Label()
        Educ_DeptLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Last_CourseLabel = New System.Windows.Forms.Label()
        ElementaryLabel = New System.Windows.Forms.Label()
        Elem_AwardLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        HighSchoolLabel = New System.Windows.Forms.Label()
        Highest_EducLabel = New System.Windows.Forms.Label()
        Highest_YearLabel = New System.Windows.Forms.Label()
        Highest_SectionLabel = New System.Windows.Forms.Label()
        Highest_AddLabel = New System.Windows.Forms.Label()
        Old_StudLabel = New System.Windows.Forms.Label()
        New_StudLabel = New System.Windows.Forms.Label()
        ReturneeLabel = New System.Windows.Forms.Label()
        CType(Me.TblStudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblStudentBindingNavigator.SuspendLayout()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SiblingPositionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoOfSiblingsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(34, 16)
        StudentIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 30
        StudentIDLabel.Text = "Student ID:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(32, 85)
        LastNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 32
        LastNameLabel.Text = "Last Name:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Location = New System.Drawing.Point(48, 224)
        ReligionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(48, 13)
        ReligionLabel.TabIndex = 52
        ReligionLabel.Text = "Religion:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(32, 108)
        FirstNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 34
        FirstNameLabel.Text = "First Name:"
        '
        'BloodTypeLabel
        '
        BloodTypeLabel.AutoSize = True
        BloodTypeLabel.Location = New System.Drawing.Point(302, 295)
        BloodTypeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BloodTypeLabel.Name = "BloodTypeLabel"
        BloodTypeLabel.Size = New System.Drawing.Size(64, 13)
        BloodTypeLabel.TabIndex = 50
        BloodTypeLabel.Text = "Blood Type:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(22, 131)
        MiddleNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(72, 13)
        MiddleNameLabel.TabIndex = 36
        MiddleNameLabel.Text = "Middle Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(27, 318)
        AddressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(68, 13)
        AddressLabel.TabIndex = 48
        AddressLabel.Text = "City Address:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(68, 248)
        GenderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(28, 13)
        GenderLabel.TabIndex = 38
        GenderLabel.Text = "Sex:"
        '
        'PlaceOfBirthLabel
        '
        PlaceOfBirthLabel.AutoSize = True
        PlaceOfBirthLabel.Location = New System.Drawing.Point(18, 154)
        PlaceOfBirthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PlaceOfBirthLabel.Name = "PlaceOfBirthLabel"
        PlaceOfBirthLabel.Size = New System.Drawing.Size(75, 13)
        PlaceOfBirthLabel.TabIndex = 46
        PlaceOfBirthLabel.Text = "Place Of Birth:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(32, 200)
        StatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(62, 13)
        StatusLabel.TabIndex = 40
        StatusLabel.Text = "Civil Status:"
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Location = New System.Drawing.Point(36, 178)
        BirthDateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(57, 13)
        BirthDateLabel.TabIndex = 44
        BirthDateLabel.Text = "Birth Date:"
        '
        'CitizenshipLabel
        '
        CitizenshipLabel.AutoSize = True
        CitizenshipLabel.Location = New System.Drawing.Point(32, 271)
        CitizenshipLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CitizenshipLabel.Name = "CitizenshipLabel"
        CitizenshipLabel.Size = New System.Drawing.Size(60, 13)
        CitizenshipLabel.TabIndex = 42
        CitizenshipLabel.Text = "Citizenship:"
        '
        'Date_FileLabel
        '
        Date_FileLabel.AutoSize = True
        Date_FileLabel.Location = New System.Drawing.Point(467, 26)
        Date_FileLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Date_FileLabel.Name = "Date_FileLabel"
        Date_FileLabel.Size = New System.Drawing.Size(33, 13)
        Date_FileLabel.TabIndex = 30
        Date_FileLabel.Text = "Date:"
        '
        'CourseIDLabel
        '
        CourseIDLabel.AutoSize = True
        CourseIDLabel.Location = New System.Drawing.Point(50, 39)
        CourseIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CourseIDLabel.Name = "CourseIDLabel"
        CourseIDLabel.Size = New System.Drawing.Size(43, 13)
        CourseIDLabel.TabIndex = 57
        CourseIDLabel.Text = "Course:"
        '
        'SessionLabel
        '
        SessionLabel.AutoSize = True
        SessionLabel.Location = New System.Drawing.Point(46, 63)
        SessionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SessionLabel.Name = "SessionLabel"
        SessionLabel.Size = New System.Drawing.Size(47, 13)
        SessionLabel.TabIndex = 58
        SessionLabel.Text = "Session:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(206, 175)
        AgeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 59
        AgeLabel.Text = "Age:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Location = New System.Drawing.Point(184, 295)
        HeightLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(41, 13)
        HeightLabel.TabIndex = 14
        HeightLabel.Text = "Height:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(271, 295)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(27, 13)
        Label1.TabIndex = 15
        Label1.Text = "(cm)"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(52, 295)
        WeightLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 62
        WeightLabel.Text = "Weight:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(148, 295)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(25, 13)
        Label2.TabIndex = 64
        Label2.Text = "(kg)"
        '
        'ProvAddLabel
        '
        ProvAddLabel.AutoSize = True
        ProvAddLabel.Location = New System.Drawing.Point(2, 342)
        ProvAddLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ProvAddLabel.Name = "ProvAddLabel"
        ProvAddLabel.Size = New System.Drawing.Size(97, 13)
        ProvAddLabel.TabIndex = 64
        ProvAddLabel.Text = "Provincial Address:"
        '
        'NoOfSiblingsLabel
        '
        NoOfSiblingsLabel.AutoSize = True
        NoOfSiblingsLabel.Location = New System.Drawing.Point(19, 366)
        NoOfSiblingsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NoOfSiblingsLabel.Name = "NoOfSiblingsLabel"
        NoOfSiblingsLabel.Size = New System.Drawing.Size(77, 13)
        NoOfSiblingsLabel.TabIndex = 65
        NoOfSiblingsLabel.Text = "No Of Siblings:"
        '
        'SiblingPositionLabel
        '
        SiblingPositionLabel.AutoSize = True
        SiblingPositionLabel.Location = New System.Drawing.Point(142, 366)
        SiblingPositionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SiblingPositionLabel.Name = "SiblingPositionLabel"
        SiblingPositionLabel.Size = New System.Drawing.Size(81, 13)
        SiblingPositionLabel.TabIndex = 66
        SiblingPositionLabel.Text = "Sibling Position:"
        '
        'LastSchoolNameLabel
        '
        LastSchoolNameLabel.AutoSize = True
        LastSchoolNameLabel.Location = New System.Drawing.Point(2, 152)
        LastSchoolNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LastSchoolNameLabel.Name = "LastSchoolNameLabel"
        LastSchoolNameLabel.Size = New System.Drawing.Size(112, 13)
        LastSchoolNameLabel.TabIndex = 58
        LastSchoolNameLabel.Text = "Last School Attended:"
        '
        'Lang_DialectLabel
        '
        Lang_DialectLabel.AutoSize = True
        Lang_DialectLabel.Location = New System.Drawing.Point(27, 389)
        Lang_DialectLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Lang_DialectLabel.Name = "Lang_DialectLabel"
        Lang_DialectLabel.Size = New System.Drawing.Size(106, 13)
        Lang_DialectLabel.TabIndex = 67
        Lang_DialectLabel.Text = "Language or Dialect:"
        '
        'FatherNameLabel
        '
        FatherNameLabel.AutoSize = True
        FatherNameLabel.Location = New System.Drawing.Point(41, 414)
        FatherNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(78, 13)
        FatherNameLabel.TabIndex = 68
        FatherNameLabel.Text = "Father's Name:"
        '
        'FatherWorkLabel
        '
        FatherWorkLabel.AutoSize = True
        FatherWorkLabel.Location = New System.Drawing.Point(15, 435)
        FatherWorkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FatherWorkLabel.Name = "FatherWorkLabel"
        FatherWorkLabel.Size = New System.Drawing.Size(105, 13)
        FatherWorkLabel.TabIndex = 69
        FatherWorkLabel.Text = "Father's Occupation:"
        '
        'FatherContactLabel
        '
        FatherContactLabel.AutoSize = True
        FatherContactLabel.Location = New System.Drawing.Point(297, 437)
        FatherContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FatherContactLabel.Name = "FatherContactLabel"
        FatherContactLabel.Size = New System.Drawing.Size(64, 13)
        FatherContactLabel.TabIndex = 70
        FatherContactLabel.Text = "Contact No:"
        '
        'MotherNameLabel
        '
        MotherNameLabel.AutoSize = True
        MotherNameLabel.Location = New System.Drawing.Point(39, 461)
        MotherNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MotherNameLabel.Name = "MotherNameLabel"
        MotherNameLabel.Size = New System.Drawing.Size(81, 13)
        MotherNameLabel.TabIndex = 71
        MotherNameLabel.Text = "Mother's Name:"
        '
        'MotherWorkLabel
        '
        MotherWorkLabel.AutoSize = True
        MotherWorkLabel.Location = New System.Drawing.Point(13, 485)
        MotherWorkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MotherWorkLabel.Name = "MotherWorkLabel"
        MotherWorkLabel.Size = New System.Drawing.Size(108, 13)
        MotherWorkLabel.TabIndex = 72
        MotherWorkLabel.Text = "Mother's Occupation:"
        '
        'MotherContactLabel
        '
        MotherContactLabel.AutoSize = True
        MotherContactLabel.Location = New System.Drawing.Point(293, 485)
        MotherContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MotherContactLabel.Name = "MotherContactLabel"
        MotherContactLabel.Size = New System.Drawing.Size(64, 13)
        MotherContactLabel.TabIndex = 73
        MotherContactLabel.Text = "Contact No:"
        '
        'Emergency_NameLabel
        '
        Emergency_NameLabel.AutoSize = True
        Emergency_NameLabel.Location = New System.Drawing.Point(84, 233)
        Emergency_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Emergency_NameLabel.Name = "Emergency_NameLabel"
        Emergency_NameLabel.Size = New System.Drawing.Size(38, 13)
        Emergency_NameLabel.TabIndex = 1
        Emergency_NameLabel.Text = "Name:"
        '
        'Emergency_RelationLabel
        '
        Emergency_RelationLabel.AutoSize = True
        Emergency_RelationLabel.Location = New System.Drawing.Point(53, 258)
        Emergency_RelationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Emergency_RelationLabel.Name = "Emergency_RelationLabel"
        Emergency_RelationLabel.Size = New System.Drawing.Size(68, 13)
        Emergency_RelationLabel.TabIndex = 3
        Emergency_RelationLabel.Text = "Relationship:"
        '
        'Emergency_ContactLabel
        '
        Emergency_ContactLabel.AutoSize = True
        Emergency_ContactLabel.Location = New System.Drawing.Point(59, 284)
        Emergency_ContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Emergency_ContactLabel.Name = "Emergency_ContactLabel"
        Emergency_ContactLabel.Size = New System.Drawing.Size(64, 13)
        Emergency_ContactLabel.TabIndex = 5
        Emergency_ContactLabel.Text = "Contact No:"
        '
        'Emergency_AddLabel
        '
        Emergency_AddLabel.AutoSize = True
        Emergency_AddLabel.Location = New System.Drawing.Point(26, 309)
        Emergency_AddLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Emergency_AddLabel.Name = "Emergency_AddLabel"
        Emergency_AddLabel.Size = New System.Drawing.Size(95, 13)
        Emergency_AddLabel.TabIndex = 7
        Emergency_AddLabel.Text = "Complete Address:"
        '
        'Live_NameLabel
        '
        Live_NameLabel.AutoSize = True
        Live_NameLabel.Location = New System.Drawing.Point(84, 54)
        Live_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Live_NameLabel.Name = "Live_NameLabel"
        Live_NameLabel.Size = New System.Drawing.Size(38, 13)
        Live_NameLabel.TabIndex = 10
        Live_NameLabel.Text = "Name:"
        '
        'Live_RelationLabel
        '
        Live_RelationLabel.AutoSize = True
        Live_RelationLabel.Location = New System.Drawing.Point(53, 80)
        Live_RelationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Live_RelationLabel.Name = "Live_RelationLabel"
        Live_RelationLabel.Size = New System.Drawing.Size(68, 13)
        Live_RelationLabel.TabIndex = 12
        Live_RelationLabel.Text = "Relationship:"
        '
        'Live_ContactLabel
        '
        Live_ContactLabel.AutoSize = True
        Live_ContactLabel.Location = New System.Drawing.Point(59, 103)
        Live_ContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Live_ContactLabel.Name = "Live_ContactLabel"
        Live_ContactLabel.Size = New System.Drawing.Size(64, 13)
        Live_ContactLabel.TabIndex = 14
        Live_ContactLabel.Text = "Contact No:"
        '
        'Live_AddLabel
        '
        Live_AddLabel.AutoSize = True
        Live_AddLabel.Location = New System.Drawing.Point(26, 128)
        Live_AddLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Live_AddLabel.Name = "Live_AddLabel"
        Live_AddLabel.Size = New System.Drawing.Size(95, 13)
        Live_AddLabel.TabIndex = 16
        Live_AddLabel.Text = "Complete Address:"
        '
        'Educ_CourseLabel
        '
        Educ_CourseLabel.AutoSize = True
        Educ_CourseLabel.Location = New System.Drawing.Point(30, 47)
        Educ_CourseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Educ_CourseLabel.Name = "Educ_CourseLabel"
        Educ_CourseLabel.Size = New System.Drawing.Size(71, 13)
        Educ_CourseLabel.TabIndex = 61
        Educ_CourseLabel.Text = "Educ Course:"
        '
        'Educ_DeptLabel
        '
        Educ_DeptLabel.AutoSize = True
        Educ_DeptLabel.Location = New System.Drawing.Point(38, 70)
        Educ_DeptLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Educ_DeptLabel.Name = "Educ_DeptLabel"
        Educ_DeptLabel.Size = New System.Drawing.Size(61, 13)
        Educ_DeptLabel.TabIndex = 62
        Educ_DeptLabel.Text = "Educ Dept:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(34, 132)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(78, 13)
        Label5.TabIndex = 68
        Label5.Text = "(If TRansferee)"
        '
        'Last_CourseLabel
        '
        Last_CourseLabel.AutoSize = True
        Last_CourseLabel.Location = New System.Drawing.Point(69, 173)
        Last_CourseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Last_CourseLabel.Name = "Last_CourseLabel"
        Last_CourseLabel.Size = New System.Drawing.Size(43, 13)
        Last_CourseLabel.TabIndex = 68
        Last_CourseLabel.Text = "Course:"
        '
        'ElementaryLabel
        '
        ElementaryLabel.AutoSize = True
        ElementaryLabel.Location = New System.Drawing.Point(20, 235)
        ElementaryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ElementaryLabel.Name = "ElementaryLabel"
        ElementaryLabel.Size = New System.Drawing.Size(62, 13)
        ElementaryLabel.TabIndex = 69
        ElementaryLabel.Text = "Elementary:"
        '
        'Elem_AwardLabel
        '
        Elem_AwardLabel.AutoSize = True
        Elem_AwardLabel.Location = New System.Drawing.Point(385, 214)
        Elem_AwardLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Elem_AwardLabel.Name = "Elem_AwardLabel"
        Elem_AwardLabel.Size = New System.Drawing.Size(89, 13)
        Elem_AwardLabel.TabIndex = 71
        Elem_AwardLabel.Text = "Award Recieved:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(139, 214)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(74, 13)
        Label6.TabIndex = 73
        Label6.Text = "School Name:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(296, 214)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(68, 13)
        Label7.TabIndex = 74
        Label7.Text = "School Year:"
        '
        'HighSchoolLabel
        '
        HighSchoolLabel.AutoSize = True
        HighSchoolLabel.Location = New System.Drawing.Point(16, 258)
        HighSchoolLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        HighSchoolLabel.Name = "HighSchoolLabel"
        HighSchoolLabel.Size = New System.Drawing.Size(68, 13)
        HighSchoolLabel.TabIndex = 74
        HighSchoolLabel.Text = "High School:"
        '
        'Highest_EducLabel
        '
        Highest_EducLabel.AutoSize = True
        Highest_EducLabel.Location = New System.Drawing.Point(14, 298)
        Highest_EducLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Highest_EducLabel.Name = "Highest_EducLabel"
        Highest_EducLabel.Size = New System.Drawing.Size(153, 13)
        Highest_EducLabel.TabIndex = 77
        Highest_EducLabel.Text = "Highest Educ:ation Completed:"
        '
        'Highest_YearLabel
        '
        Highest_YearLabel.AutoSize = True
        Highest_YearLabel.Location = New System.Drawing.Point(98, 323)
        Highest_YearLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Highest_YearLabel.Name = "Highest_YearLabel"
        Highest_YearLabel.Size = New System.Drawing.Size(68, 13)
        Highest_YearLabel.TabIndex = 78
        Highest_YearLabel.Text = "School Year:"
        '
        'Highest_SectionLabel
        '
        Highest_SectionLabel.AutoSize = True
        Highest_SectionLabel.Location = New System.Drawing.Point(121, 350)
        Highest_SectionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Highest_SectionLabel.Name = "Highest_SectionLabel"
        Highest_SectionLabel.Size = New System.Drawing.Size(46, 13)
        Highest_SectionLabel.TabIndex = 79
        Highest_SectionLabel.Text = "Section:"
        '
        'Highest_AddLabel
        '
        Highest_AddLabel.AutoSize = True
        Highest_AddLabel.Location = New System.Drawing.Point(14, 352)
        Highest_AddLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Highest_AddLabel.Name = "Highest_AddLabel"
        Highest_AddLabel.Size = New System.Drawing.Size(48, 13)
        Highest_AddLabel.TabIndex = 80
        Highest_AddLabel.Text = "Address:"
        '
        'Old_StudLabel
        '
        Old_StudLabel.AutoSize = True
        Old_StudLabel.Location = New System.Drawing.Point(23, 115)
        Old_StudLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Old_StudLabel.Name = "Old_StudLabel"
        Old_StudLabel.Size = New System.Drawing.Size(51, 13)
        Old_StudLabel.TabIndex = 80
        Old_StudLabel.Text = "Old Stud:"
        '
        'New_StudLabel
        '
        New_StudLabel.AutoSize = True
        New_StudLabel.Location = New System.Drawing.Point(180, 112)
        New_StudLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        New_StudLabel.Name = "New_StudLabel"
        New_StudLabel.Size = New System.Drawing.Size(57, 13)
        New_StudLabel.TabIndex = 81
        New_StudLabel.Text = "New Stud:"
        '
        'ReturneeLabel
        '
        ReturneeLabel.AutoSize = True
        ReturneeLabel.Location = New System.Drawing.Point(334, 112)
        ReturneeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReturneeLabel.Name = "ReturneeLabel"
        ReturneeLabel.Size = New System.Drawing.Size(54, 13)
        ReturneeLabel.TabIndex = 82
        ReturneeLabel.Text = "Returnee:"
        '
        'TblStudentBindingNavigator
        '
        Me.TblStudentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblStudentBindingNavigator.BindingSource = Me.TblStudentBindingSource
        Me.TblStudentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblStudentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblStudentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblStudentBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator2, Me.HelpToolStripButton, Me.ToolStripButton1})
        Me.TblStudentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblStudentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblStudentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblStudentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblStudentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblStudentBindingNavigator.Name = "TblStudentBindingNavigator"
        Me.TblStudentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblStudentBindingNavigator.Size = New System.Drawing.Size(970, 25)
        Me.TblStudentBindingNavigator.TabIndex = 0
        Me.TblStudentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TblStudentBindingSource
        '
        Me.TblStudentBindingSource.DataMember = "tblStudent"
        Me.TblStudentBindingSource.DataSource = Me.MstDataSet
        '
        'MstDataSet
        '
        Me.MstDataSet.DataSetName = "MstDataSet"
        Me.MstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        Me.BindingNavigatorCountItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator.Visible = False
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        Me.BindingNavigatorPositionItem.Visible = False
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator1.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'TblStudentBindingNavigatorSaveItem
        '
        Me.TblStudentBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblStudentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblStudentBindingNavigatorSaveItem.Name = "TblStudentBindingNavigatorSaveItem"
        Me.TblStudentBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.TblStudentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        Me.NewToolStripButton.Visible = False
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        Me.OpenToolStripButton.Visible = False
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        Me.SaveToolStripButton.Visible = False
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        Me.PrintToolStripButton.Visible = False
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        Me.toolStripSeparator.Visible = False
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        Me.CutToolStripButton.Visible = False
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        Me.CopyToolStripButton.Visible = False
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        Me.PasteToolStripButton.Visible = False
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.toolStripSeparator2.Visible = False
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        Me.HelpToolStripButton.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton1.Text = "Update"
        '
        'TblStudentDataGridView
        '
        Me.TblStudentDataGridView.AllowUserToAddRows = False
        Me.TblStudentDataGridView.AllowUserToDeleteRows = False
        Me.TblStudentDataGridView.AutoGenerateColumns = False
        Me.TblStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblStudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2})
        Me.TblStudentDataGridView.DataSource = Me.TblStudentBindingSource
        Me.TblStudentDataGridView.Location = New System.Drawing.Point(9, 32)
        Me.TblStudentDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.TblStudentDataGridView.Name = "TblStudentDataGridView"
        Me.TblStudentDataGridView.ReadOnly = True
        Me.TblStudentDataGridView.RowHeadersVisible = False
        Me.TblStudentDataGridView.RowTemplate.Height = 24
        Me.TblStudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblStudentDataGridView.Size = New System.Drawing.Size(442, 484)
        Me.TblStudentDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MiddleName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MiddleName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(470, 42)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(500, 547)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.CourseIDComboBox)
        Me.TabPage1.Controls.Add(MotherContactLabel)
        Me.TabPage1.Controls.Add(Me.MotherContactTextBox)
        Me.TabPage1.Controls.Add(MotherWorkLabel)
        Me.TabPage1.Controls.Add(Me.MotherWorkTextBox)
        Me.TabPage1.Controls.Add(MotherNameLabel)
        Me.TabPage1.Controls.Add(Me.MotherNameTextBox)
        Me.TabPage1.Controls.Add(FatherContactLabel)
        Me.TabPage1.Controls.Add(Me.FatherContactTextBox)
        Me.TabPage1.Controls.Add(FatherWorkLabel)
        Me.TabPage1.Controls.Add(Me.FatherWorkTextBox)
        Me.TabPage1.Controls.Add(FatherNameLabel)
        Me.TabPage1.Controls.Add(Me.FatherNameTextBox)
        Me.TabPage1.Controls.Add(Lang_DialectLabel)
        Me.TabPage1.Controls.Add(Me.Lang_DialectTextBox)
        Me.TabPage1.Controls.Add(SiblingPositionLabel)
        Me.TabPage1.Controls.Add(Me.SiblingPositionNumericUpDown)
        Me.TabPage1.Controls.Add(NoOfSiblingsLabel)
        Me.TabPage1.Controls.Add(Me.NoOfSiblingsNumericUpDown)
        Me.TabPage1.Controls.Add(ProvAddLabel)
        Me.TabPage1.Controls.Add(Me.ProvAddTextBox)
        Me.TabPage1.Controls.Add(Label2)
        Me.TabPage1.Controls.Add(WeightLabel)
        Me.TabPage1.Controls.Add(Me.WeightNumericUpDown)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(HeightLabel)
        Me.TabPage1.Controls.Add(Me.HeightNumericUpDown)
        Me.TabPage1.Controls.Add(AgeLabel)
        Me.TabPage1.Controls.Add(Me.AgeNumericUpDown)
        Me.TabPage1.Controls.Add(SessionLabel)
        Me.TabPage1.Controls.Add(Me.SessionTextBox)
        Me.TabPage1.Controls.Add(CourseIDLabel)
        Me.TabPage1.Controls.Add(Me.LastNameTextBox)
        Me.TabPage1.Controls.Add(Me.StudentIDTextBox)
        Me.TabPage1.Controls.Add(StudentIDLabel)
        Me.TabPage1.Controls.Add(LastNameLabel)
        Me.TabPage1.Controls.Add(Me.FirstNameTextBox)
        Me.TabPage1.Controls.Add(ReligionLabel)
        Me.TabPage1.Controls.Add(FirstNameLabel)
        Me.TabPage1.Controls.Add(Me.ReligionTextBox)
        Me.TabPage1.Controls.Add(Me.MiddleNameTextBox)
        Me.TabPage1.Controls.Add(BloodTypeLabel)
        Me.TabPage1.Controls.Add(MiddleNameLabel)
        Me.TabPage1.Controls.Add(Me.BloodTypeTextBox)
        Me.TabPage1.Controls.Add(Me.GenderComboBox)
        Me.TabPage1.Controls.Add(AddressLabel)
        Me.TabPage1.Controls.Add(GenderLabel)
        Me.TabPage1.Controls.Add(Me.AddressTextBox)
        Me.TabPage1.Controls.Add(Me.StatusComboBox)
        Me.TabPage1.Controls.Add(PlaceOfBirthLabel)
        Me.TabPage1.Controls.Add(StatusLabel)
        Me.TabPage1.Controls.Add(Me.PlaceOfBirthTextBox)
        Me.TabPage1.Controls.Add(Me.CitizenshipTextBox)
        Me.TabPage1.Controls.Add(BirthDateLabel)
        Me.TabPage1.Controls.Add(CitizenshipLabel)
        Me.TabPage1.Controls.Add(Me.BirthDateDateTimePicker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(492, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CourseIDComboBox
        '
        Me.CourseIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "CourseID", True))
        Me.CourseIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseIDComboBox.FormattingEnabled = True
        Me.CourseIDComboBox.Location = New System.Drawing.Point(97, 37)
        Me.CourseIDComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CourseIDComboBox.Name = "CourseIDComboBox"
        Me.CourseIDComboBox.Size = New System.Drawing.Size(323, 21)
        Me.CourseIDComboBox.TabIndex = 75
        '
        'MotherContactTextBox
        '
        Me.MotherContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MotherContact", True))
        Me.MotherContactTextBox.Location = New System.Drawing.Point(359, 483)
        Me.MotherContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MotherContactTextBox.Name = "MotherContactTextBox"
        Me.MotherContactTextBox.Size = New System.Drawing.Size(130, 20)
        Me.MotherContactTextBox.TabIndex = 27
        '
        'MotherWorkTextBox
        '
        Me.MotherWorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MotherWork", True))
        Me.MotherWorkTextBox.Location = New System.Drawing.Point(126, 483)
        Me.MotherWorkTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MotherWorkTextBox.Name = "MotherWorkTextBox"
        Me.MotherWorkTextBox.Size = New System.Drawing.Size(161, 20)
        Me.MotherWorkTextBox.TabIndex = 26
        '
        'MotherNameTextBox
        '
        Me.MotherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MotherName", True))
        Me.MotherNameTextBox.Location = New System.Drawing.Point(126, 458)
        Me.MotherNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MotherNameTextBox.Name = "MotherNameTextBox"
        Me.MotherNameTextBox.Size = New System.Drawing.Size(213, 20)
        Me.MotherNameTextBox.TabIndex = 25
        '
        'FatherContactTextBox
        '
        Me.FatherContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FatherContact", True))
        Me.FatherContactTextBox.Location = New System.Drawing.Point(359, 436)
        Me.FatherContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FatherContactTextBox.Name = "FatherContactTextBox"
        Me.FatherContactTextBox.Size = New System.Drawing.Size(130, 20)
        Me.FatherContactTextBox.TabIndex = 24
        '
        'FatherWorkTextBox
        '
        Me.FatherWorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FatherWork", True))
        Me.FatherWorkTextBox.Location = New System.Drawing.Point(126, 436)
        Me.FatherWorkTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FatherWorkTextBox.Name = "FatherWorkTextBox"
        Me.FatherWorkTextBox.Size = New System.Drawing.Size(161, 20)
        Me.FatherWorkTextBox.TabIndex = 23
        '
        'FatherNameTextBox
        '
        Me.FatherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FatherName", True))
        Me.FatherNameTextBox.Location = New System.Drawing.Point(126, 413)
        Me.FatherNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FatherNameTextBox.Name = "FatherNameTextBox"
        Me.FatherNameTextBox.Size = New System.Drawing.Size(213, 20)
        Me.FatherNameTextBox.TabIndex = 22
        '
        'Lang_DialectTextBox
        '
        Me.Lang_DialectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Lang_Dialect", True))
        Me.Lang_DialectTextBox.Location = New System.Drawing.Point(134, 388)
        Me.Lang_DialectTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Lang_DialectTextBox.Name = "Lang_DialectTextBox"
        Me.Lang_DialectTextBox.Size = New System.Drawing.Size(286, 20)
        Me.Lang_DialectTextBox.TabIndex = 21
        '
        'SiblingPositionNumericUpDown
        '
        Me.SiblingPositionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "SiblingPosition", True))
        Me.SiblingPositionNumericUpDown.Location = New System.Drawing.Point(228, 364)
        Me.SiblingPositionNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.SiblingPositionNumericUpDown.Name = "SiblingPositionNumericUpDown"
        Me.SiblingPositionNumericUpDown.Size = New System.Drawing.Size(29, 20)
        Me.SiblingPositionNumericUpDown.TabIndex = 20
        '
        'NoOfSiblingsNumericUpDown
        '
        Me.NoOfSiblingsNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "NoOfSiblings", True))
        Me.NoOfSiblingsNumericUpDown.Location = New System.Drawing.Point(100, 364)
        Me.NoOfSiblingsNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.NoOfSiblingsNumericUpDown.Name = "NoOfSiblingsNumericUpDown"
        Me.NoOfSiblingsNumericUpDown.Size = New System.Drawing.Size(32, 20)
        Me.NoOfSiblingsNumericUpDown.TabIndex = 19
        '
        'ProvAddTextBox
        '
        Me.ProvAddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "ProvAdd", True))
        Me.ProvAddTextBox.Location = New System.Drawing.Point(100, 340)
        Me.ProvAddTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProvAddTextBox.Name = "ProvAddTextBox"
        Me.ProvAddTextBox.Size = New System.Drawing.Size(320, 20)
        Me.ProvAddTextBox.TabIndex = 18
        '
        'WeightNumericUpDown
        '
        Me.WeightNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Weight", True))
        Me.WeightNumericUpDown.Location = New System.Drawing.Point(98, 292)
        Me.WeightNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.WeightNumericUpDown.Name = "WeightNumericUpDown"
        Me.WeightNumericUpDown.Size = New System.Drawing.Size(45, 20)
        Me.WeightNumericUpDown.TabIndex = 13
        '
        'HeightNumericUpDown
        '
        Me.HeightNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Height", True))
        Me.HeightNumericUpDown.Location = New System.Drawing.Point(224, 292)
        Me.HeightNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.HeightNumericUpDown.Name = "HeightNumericUpDown"
        Me.HeightNumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.HeightNumericUpDown.TabIndex = 14
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Age", True))
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(238, 175)
        Me.AgeNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.AgeNumericUpDown.TabIndex = 8
        '
        'SessionTextBox
        '
        Me.SessionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Session", True))
        Me.SessionTextBox.Location = New System.Drawing.Point(97, 61)
        Me.SessionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SessionTextBox.Name = "SessionTextBox"
        Me.SessionTextBox.Size = New System.Drawing.Size(173, 20)
        Me.SessionTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(97, 83)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(97, 14)
        Me.StudentIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(76, 20)
        Me.StudentIDTextBox.TabIndex = 0
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(97, 106)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'ReligionTextBox
        '
        Me.ReligionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Religion", True))
        Me.ReligionTextBox.Location = New System.Drawing.Point(97, 222)
        Me.ReligionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ReligionTextBox.Name = "ReligionTextBox"
        Me.ReligionTextBox.Size = New System.Drawing.Size(201, 20)
        Me.ReligionTextBox.TabIndex = 10
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(97, 128)
        Me.MiddleNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.MiddleNameTextBox.TabIndex = 5
        '
        'BloodTypeTextBox
        '
        Me.BloodTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "BloodType", True))
        Me.BloodTypeTextBox.Location = New System.Drawing.Point(370, 292)
        Me.BloodTypeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BloodTypeTextBox.Name = "BloodTypeTextBox"
        Me.BloodTypeTextBox.Size = New System.Drawing.Size(50, 20)
        Me.BloodTypeTextBox.TabIndex = 15
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(97, 245)
        Me.GenderComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(92, 21)
        Me.GenderComboBox.TabIndex = 11
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(100, 318)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(320, 20)
        Me.AddressTextBox.TabIndex = 17
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Widow", "Separated", "Divorce/Annuled"})
        Me.StatusComboBox.Location = New System.Drawing.Point(97, 197)
        Me.StatusComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(92, 21)
        Me.StatusComboBox.TabIndex = 9
        '
        'PlaceOfBirthTextBox
        '
        Me.PlaceOfBirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "PlaceOfBirth", True))
        Me.PlaceOfBirthTextBox.Location = New System.Drawing.Point(97, 151)
        Me.PlaceOfBirthTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PlaceOfBirthTextBox.Name = "PlaceOfBirthTextBox"
        Me.PlaceOfBirthTextBox.Size = New System.Drawing.Size(239, 20)
        Me.PlaceOfBirthTextBox.TabIndex = 6
        '
        'CitizenshipTextBox
        '
        Me.CitizenshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Citizenship", True))
        Me.CitizenshipTextBox.Location = New System.Drawing.Point(97, 269)
        Me.CitizenshipTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CitizenshipTextBox.Name = "CitizenshipTextBox"
        Me.CitizenshipTextBox.Size = New System.Drawing.Size(201, 20)
        Me.CitizenshipTextBox.TabIndex = 12
        '
        'BirthDateDateTimePicker
        '
        Me.BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthDateDateTimePicker.Location = New System.Drawing.Point(97, 175)
        Me.BirthDateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker"
        Me.BirthDateDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.BirthDateDateTimePicker.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Live_AddLabel)
        Me.TabPage2.Controls.Add(Me.Live_AddTextBox)
        Me.TabPage2.Controls.Add(Live_ContactLabel)
        Me.TabPage2.Controls.Add(Me.Live_ContactTextBox)
        Me.TabPage2.Controls.Add(Live_RelationLabel)
        Me.TabPage2.Controls.Add(Me.Live_RelationTextBox)
        Me.TabPage2.Controls.Add(Live_NameLabel)
        Me.TabPage2.Controls.Add(Me.Live_NameTextBox)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Emergency_AddLabel)
        Me.TabPage2.Controls.Add(Me.Emergency_AddTextBox)
        Me.TabPage2.Controls.Add(Emergency_ContactLabel)
        Me.TabPage2.Controls.Add(Me.Emergency_ContactTextBox)
        Me.TabPage2.Controls.Add(Emergency_RelationLabel)
        Me.TabPage2.Controls.Add(Me.Emergency_RelationTextBox)
        Me.TabPage2.Controls.Add(Emergency_NameLabel)
        Me.TabPage2.Controls.Add(Me.Emergency_NameTextBox)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(492, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Presently Live and In Case of Emergency"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Live_AddTextBox
        '
        Me.Live_AddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Live_Add", True))
        Me.Live_AddTextBox.Location = New System.Drawing.Point(125, 128)
        Me.Live_AddTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Live_AddTextBox.Name = "Live_AddTextBox"
        Me.Live_AddTextBox.Size = New System.Drawing.Size(358, 20)
        Me.Live_AddTextBox.TabIndex = 3
        '
        'Live_ContactTextBox
        '
        Me.Live_ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Live_Contact", True))
        Me.Live_ContactTextBox.Location = New System.Drawing.Point(125, 105)
        Me.Live_ContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Live_ContactTextBox.Name = "Live_ContactTextBox"
        Me.Live_ContactTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Live_ContactTextBox.TabIndex = 2
        '
        'Live_RelationTextBox
        '
        Me.Live_RelationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Live_Relation", True))
        Me.Live_RelationTextBox.Location = New System.Drawing.Point(125, 78)
        Me.Live_RelationTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Live_RelationTextBox.Name = "Live_RelationTextBox"
        Me.Live_RelationTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Live_RelationTextBox.TabIndex = 1
        '
        'Live_NameTextBox
        '
        Me.Live_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Live_Name", True))
        Me.Live_NameTextBox.Location = New System.Drawing.Point(125, 53)
        Me.Live_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Live_NameTextBox.Name = "Live_NameTextBox"
        Me.Live_NameTextBox.Size = New System.Drawing.Size(262, 20)
        Me.Live_NameTextBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(411, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "With whom doyou presently live?(Complete Name and Address)"
        '
        'Emergency_AddTextBox
        '
        Me.Emergency_AddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Emergency_Add", True))
        Me.Emergency_AddTextBox.Location = New System.Drawing.Point(125, 309)
        Me.Emergency_AddTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Emergency_AddTextBox.Name = "Emergency_AddTextBox"
        Me.Emergency_AddTextBox.Size = New System.Drawing.Size(358, 20)
        Me.Emergency_AddTextBox.TabIndex = 7
        '
        'Emergency_ContactTextBox
        '
        Me.Emergency_ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Emergency_Contact", True))
        Me.Emergency_ContactTextBox.Location = New System.Drawing.Point(125, 280)
        Me.Emergency_ContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Emergency_ContactTextBox.Name = "Emergency_ContactTextBox"
        Me.Emergency_ContactTextBox.Size = New System.Drawing.Size(177, 20)
        Me.Emergency_ContactTextBox.TabIndex = 6
        '
        'Emergency_RelationTextBox
        '
        Me.Emergency_RelationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Emergency_Relation", True))
        Me.Emergency_RelationTextBox.Location = New System.Drawing.Point(125, 257)
        Me.Emergency_RelationTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Emergency_RelationTextBox.Name = "Emergency_RelationTextBox"
        Me.Emergency_RelationTextBox.Size = New System.Drawing.Size(154, 20)
        Me.Emergency_RelationTextBox.TabIndex = 5
        '
        'Emergency_NameTextBox
        '
        Me.Emergency_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Emergency_Name", True))
        Me.Emergency_NameTextBox.Location = New System.Drawing.Point(125, 233)
        Me.Emergency_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Emergency_NameTextBox.Name = "Emergency_NameTextBox"
        Me.Emergency_NameTextBox.Size = New System.Drawing.Size(239, 20)
        Me.Emergency_NameTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 205)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "In Case of Emergency, Please Notify:"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(ReturneeLabel)
        Me.TabPage3.Controls.Add(Me.ReturneeRadioButton)
        Me.TabPage3.Controls.Add(New_StudLabel)
        Me.TabPage3.Controls.Add(Me.New_StudRadioButton)
        Me.TabPage3.Controls.Add(Old_StudLabel)
        Me.TabPage3.Controls.Add(Me.Old_StudRadioButton)
        Me.TabPage3.Controls.Add(Highest_AddLabel)
        Me.TabPage3.Controls.Add(Me.Highest_AddTextBox)
        Me.TabPage3.Controls.Add(Highest_SectionLabel)
        Me.TabPage3.Controls.Add(Me.Highest_SectionTextBox)
        Me.TabPage3.Controls.Add(Highest_YearLabel)
        Me.TabPage3.Controls.Add(Me.Highest_YearTextBox)
        Me.TabPage3.Controls.Add(Highest_EducLabel)
        Me.TabPage3.Controls.Add(Me.Highest_EducTextBox)
        Me.TabPage3.Controls.Add(Me.HighSchool_AwardTextBox)
        Me.TabPage3.Controls.Add(Me.HighSchool_YearTextBox)
        Me.TabPage3.Controls.Add(HighSchoolLabel)
        Me.TabPage3.Controls.Add(Me.HighSchoolTextBox)
        Me.TabPage3.Controls.Add(Label7)
        Me.TabPage3.Controls.Add(Label6)
        Me.TabPage3.Controls.Add(Elem_AwardLabel)
        Me.TabPage3.Controls.Add(Me.Elem_AwardTextBox)
        Me.TabPage3.Controls.Add(Me.Elem_YearTextBox)
        Me.TabPage3.Controls.Add(ElementaryLabel)
        Me.TabPage3.Controls.Add(Me.ElementaryTextBox)
        Me.TabPage3.Controls.Add(Last_CourseLabel)
        Me.TabPage3.Controls.Add(Me.Last_CourseTextBox)
        Me.TabPage3.Controls.Add(Label5)
        Me.TabPage3.Controls.Add(Educ_DeptLabel)
        Me.TabPage3.Controls.Add(Me.Educ_DeptTextBox)
        Me.TabPage3.Controls.Add(Educ_CourseLabel)
        Me.TabPage3.Controls.Add(Me.Educ_CourseTextBox)
        Me.TabPage3.Controls.Add(LastSchoolNameLabel)
        Me.TabPage3.Controls.Add(Me.LastSchoolNameTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(492, 521)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Educational Background"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReturneeRadioButton
        '
        Me.ReturneeRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblStudentBindingSource, "Returnee", True))
        Me.ReturneeRadioButton.Location = New System.Drawing.Point(393, 110)
        Me.ReturneeRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ReturneeRadioButton.Name = "ReturneeRadioButton"
        Me.ReturneeRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.ReturneeRadioButton.TabIndex = 83
        Me.ReturneeRadioButton.TabStop = True
        Me.ReturneeRadioButton.Text = "RadioButton1"
        Me.ReturneeRadioButton.UseVisualStyleBackColor = True
        '
        'New_StudRadioButton
        '
        Me.New_StudRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblStudentBindingSource, "New_Stud", True))
        Me.New_StudRadioButton.Location = New System.Drawing.Point(249, 109)
        Me.New_StudRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.New_StudRadioButton.Name = "New_StudRadioButton"
        Me.New_StudRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.New_StudRadioButton.TabIndex = 82
        Me.New_StudRadioButton.TabStop = True
        Me.New_StudRadioButton.Text = "RadioButton1"
        Me.New_StudRadioButton.UseVisualStyleBackColor = True
        '
        'Old_StudRadioButton
        '
        Me.Old_StudRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblStudentBindingSource, "Old_Stud", True))
        Me.Old_StudRadioButton.Location = New System.Drawing.Point(78, 110)
        Me.Old_StudRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.Old_StudRadioButton.Name = "Old_StudRadioButton"
        Me.Old_StudRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.Old_StudRadioButton.TabIndex = 81
        Me.Old_StudRadioButton.TabStop = True
        Me.Old_StudRadioButton.Text = "RadioButton1"
        Me.Old_StudRadioButton.UseVisualStyleBackColor = True
        '
        'Highest_AddTextBox
        '
        Me.Highest_AddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Highest_Add", True))
        Me.Highest_AddTextBox.Location = New System.Drawing.Point(64, 367)
        Me.Highest_AddTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Highest_AddTextBox.Name = "Highest_AddTextBox"
        Me.Highest_AddTextBox.Size = New System.Drawing.Size(407, 20)
        Me.Highest_AddTextBox.TabIndex = 17
        '
        'Highest_SectionTextBox
        '
        Me.Highest_SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Highest_Section", True))
        Me.Highest_SectionTextBox.Location = New System.Drawing.Point(170, 346)
        Me.Highest_SectionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Highest_SectionTextBox.Name = "Highest_SectionTextBox"
        Me.Highest_SectionTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Highest_SectionTextBox.TabIndex = 16
        '
        'Highest_YearTextBox
        '
        Me.Highest_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Highest_Year", True))
        Me.Highest_YearTextBox.Location = New System.Drawing.Point(170, 321)
        Me.Highest_YearTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Highest_YearTextBox.Name = "Highest_YearTextBox"
        Me.Highest_YearTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Highest_YearTextBox.TabIndex = 15
        '
        'Highest_EducTextBox
        '
        Me.Highest_EducTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Highest_Educ", True))
        Me.Highest_EducTextBox.Location = New System.Drawing.Point(170, 298)
        Me.Highest_EducTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Highest_EducTextBox.Name = "Highest_EducTextBox"
        Me.Highest_EducTextBox.Size = New System.Drawing.Size(199, 20)
        Me.Highest_EducTextBox.TabIndex = 14
        '
        'HighSchool_AwardTextBox
        '
        Me.HighSchool_AwardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "HighSchool_Award", True))
        Me.HighSchool_AwardTextBox.Location = New System.Drawing.Point(365, 256)
        Me.HighSchool_AwardTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.HighSchool_AwardTextBox.Name = "HighSchool_AwardTextBox"
        Me.HighSchool_AwardTextBox.Size = New System.Drawing.Size(125, 20)
        Me.HighSchool_AwardTextBox.TabIndex = 13
        '
        'HighSchool_YearTextBox
        '
        Me.HighSchool_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "HighSchool_Year", True))
        Me.HighSchool_YearTextBox.Location = New System.Drawing.Point(286, 256)
        Me.HighSchool_YearTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.HighSchool_YearTextBox.Name = "HighSchool_YearTextBox"
        Me.HighSchool_YearTextBox.Size = New System.Drawing.Size(76, 20)
        Me.HighSchool_YearTextBox.TabIndex = 12
        '
        'HighSchoolTextBox
        '
        Me.HighSchoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "HighSchool", True))
        Me.HighSchoolTextBox.Location = New System.Drawing.Point(86, 255)
        Me.HighSchoolTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.HighSchoolTextBox.Name = "HighSchoolTextBox"
        Me.HighSchoolTextBox.Size = New System.Drawing.Size(196, 20)
        Me.HighSchoolTextBox.TabIndex = 11
        '
        'Elem_AwardTextBox
        '
        Me.Elem_AwardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Elem_Award", True))
        Me.Elem_AwardTextBox.Location = New System.Drawing.Point(365, 232)
        Me.Elem_AwardTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Elem_AwardTextBox.Name = "Elem_AwardTextBox"
        Me.Elem_AwardTextBox.Size = New System.Drawing.Size(126, 20)
        Me.Elem_AwardTextBox.TabIndex = 10
        '
        'Elem_YearTextBox
        '
        Me.Elem_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Elem_Year", True))
        Me.Elem_YearTextBox.Location = New System.Drawing.Point(286, 232)
        Me.Elem_YearTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Elem_YearTextBox.Name = "Elem_YearTextBox"
        Me.Elem_YearTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Elem_YearTextBox.TabIndex = 9
        '
        'ElementaryTextBox
        '
        Me.ElementaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Elementary", True))
        Me.ElementaryTextBox.Location = New System.Drawing.Point(86, 232)
        Me.ElementaryTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ElementaryTextBox.Name = "ElementaryTextBox"
        Me.ElementaryTextBox.Size = New System.Drawing.Size(196, 20)
        Me.ElementaryTextBox.TabIndex = 8
        '
        'Last_CourseTextBox
        '
        Me.Last_CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Last_Course", True))
        Me.Last_CourseTextBox.Location = New System.Drawing.Point(116, 173)
        Me.Last_CourseTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Last_CourseTextBox.Name = "Last_CourseTextBox"
        Me.Last_CourseTextBox.Size = New System.Drawing.Size(194, 20)
        Me.Last_CourseTextBox.TabIndex = 7
        '
        'Educ_DeptTextBox
        '
        Me.Educ_DeptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Educ_Dept", True))
        Me.Educ_DeptTextBox.Location = New System.Drawing.Point(106, 67)
        Me.Educ_DeptTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Educ_DeptTextBox.Name = "Educ_DeptTextBox"
        Me.Educ_DeptTextBox.Size = New System.Drawing.Size(222, 20)
        Me.Educ_DeptTextBox.TabIndex = 1
        '
        'Educ_CourseTextBox
        '
        Me.Educ_CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Educ_Course", True))
        Me.Educ_CourseTextBox.Location = New System.Drawing.Point(104, 45)
        Me.Educ_CourseTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Educ_CourseTextBox.Name = "Educ_CourseTextBox"
        Me.Educ_CourseTextBox.Size = New System.Drawing.Size(223, 20)
        Me.Educ_CourseTextBox.TabIndex = 0
        '
        'LastSchoolNameTextBox
        '
        Me.LastSchoolNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "LastSchoolName", True))
        Me.LastSchoolNameTextBox.Location = New System.Drawing.Point(116, 150)
        Me.LastSchoolNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastSchoolNameTextBox.Name = "LastSchoolNameTextBox"
        Me.LastSchoolNameTextBox.Size = New System.Drawing.Size(344, 20)
        Me.LastSchoolNameTextBox.TabIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.Survey_Other_SpecifyTextBox)
        Me.TabPage4.Controls.Add(Me.Survey_OtherCheckBox)
        Me.TabPage4.Controls.Add(Me.Survey_TVCheckBox)
        Me.TabPage4.Controls.Add(Me.Survey_RadioCheckBox)
        Me.TabPage4.Controls.Add(Me.Survey_NewsCheckBox)
        Me.TabPage4.Controls.Add(Me.Survey_BoucherCheckBox)
        Me.TabPage4.Controls.Add(Me.Survey_CareerCheckBox)
        Me.TabPage4.Controls.Add(Me.Survey_Friend_RelCheckBox)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(492, 521)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Survey"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Survey_Other_SpecifyTextBox
        '
        Me.Survey_Other_SpecifyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Survey_Other_Specify", True))
        Me.Survey_Other_SpecifyTextBox.Location = New System.Drawing.Point(103, 235)
        Me.Survey_Other_SpecifyTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Survey_Other_SpecifyTextBox.Name = "Survey_Other_SpecifyTextBox"
        Me.Survey_Other_SpecifyTextBox.Size = New System.Drawing.Size(328, 20)
        Me.Survey_Other_SpecifyTextBox.TabIndex = 18
        '
        'Survey_OtherCheckBox
        '
        Me.Survey_OtherCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "Survey_Other", True))
        Me.Survey_OtherCheckBox.Location = New System.Drawing.Point(75, 210)
        Me.Survey_OtherCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Survey_OtherCheckBox.Name = "Survey_OtherCheckBox"
        Me.Survey_OtherCheckBox.Size = New System.Drawing.Size(176, 20)
        Me.Survey_OtherCheckBox.TabIndex = 17
        Me.Survey_OtherCheckBox.Text = "g. Others (Please Specify :"
        Me.Survey_OtherCheckBox.UseVisualStyleBackColor = True
        '
        'Survey_TVCheckBox
        '
        Me.Survey_TVCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "Survey_TV", True))
        Me.Survey_TVCheckBox.Location = New System.Drawing.Point(75, 186)
        Me.Survey_TVCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Survey_TVCheckBox.Name = "Survey_TVCheckBox"
        Me.Survey_TVCheckBox.Size = New System.Drawing.Size(134, 20)
        Me.Survey_TVCheckBox.TabIndex = 16
        Me.Survey_TVCheckBox.Text = "f. Television"
        Me.Survey_TVCheckBox.UseVisualStyleBackColor = True
        '
        'Survey_RadioCheckBox
        '
        Me.Survey_RadioCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "Survey_Radio", True))
        Me.Survey_RadioCheckBox.Location = New System.Drawing.Point(75, 162)
        Me.Survey_RadioCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Survey_RadioCheckBox.Name = "Survey_RadioCheckBox"
        Me.Survey_RadioCheckBox.Size = New System.Drawing.Size(78, 20)
        Me.Survey_RadioCheckBox.TabIndex = 15
        Me.Survey_RadioCheckBox.Text = "e. Radio"
        Me.Survey_RadioCheckBox.UseVisualStyleBackColor = True
        '
        'Survey_NewsCheckBox
        '
        Me.Survey_NewsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "Survey_News", True))
        Me.Survey_NewsCheckBox.Location = New System.Drawing.Point(75, 137)
        Me.Survey_NewsCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Survey_NewsCheckBox.Name = "Survey_NewsCheckBox"
        Me.Survey_NewsCheckBox.Size = New System.Drawing.Size(160, 20)
        Me.Survey_NewsCheckBox.TabIndex = 14
        Me.Survey_NewsCheckBox.Text = "d. News Paper"
        Me.Survey_NewsCheckBox.UseVisualStyleBackColor = True
        '
        'Survey_BoucherCheckBox
        '
        Me.Survey_BoucherCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "Survey_Boucher", True))
        Me.Survey_BoucherCheckBox.Location = New System.Drawing.Point(75, 113)
        Me.Survey_BoucherCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Survey_BoucherCheckBox.Name = "Survey_BoucherCheckBox"
        Me.Survey_BoucherCheckBox.Size = New System.Drawing.Size(200, 20)
        Me.Survey_BoucherCheckBox.TabIndex = 13
        Me.Survey_BoucherCheckBox.Text = "c. Brochures / Posters"
        Me.Survey_BoucherCheckBox.UseVisualStyleBackColor = True
        '
        'Survey_CareerCheckBox
        '
        Me.Survey_CareerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "Survey_Career", True))
        Me.Survey_CareerCheckBox.Location = New System.Drawing.Point(75, 89)
        Me.Survey_CareerCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Survey_CareerCheckBox.Name = "Survey_CareerCheckBox"
        Me.Survey_CareerCheckBox.Size = New System.Drawing.Size(161, 20)
        Me.Survey_CareerCheckBox.TabIndex = 12
        Me.Survey_CareerCheckBox.Text = "b. Career Guidance Program"
        Me.Survey_CareerCheckBox.UseVisualStyleBackColor = True
        '
        'Survey_Friend_RelCheckBox
        '
        Me.Survey_Friend_RelCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "Survey_Friend_Rel", True))
        Me.Survey_Friend_RelCheckBox.Location = New System.Drawing.Point(75, 64)
        Me.Survey_Friend_RelCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Survey_Friend_RelCheckBox.Name = "Survey_Friend_RelCheckBox"
        Me.Survey_Friend_RelCheckBox.Size = New System.Drawing.Size(184, 20)
        Me.Survey_Friend_RelCheckBox.TabIndex = 11
        Me.Survey_Friend_RelCheckBox.Text = "a. Friends and Relatives"
        Me.Survey_Friend_RelCheckBox.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(544, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "How did you learn about Samson Polythecnic College of Davao Inc.? (Please Check)"
        '
        'TblCourseBindingSource
        '
        Me.TblCourseBindingSource.DataMember = "tblCourse"
        Me.TblCourseBindingSource.DataSource = Me.MstDataSet
        '
        'Date_FileDateTimePicker
        '
        Me.Date_FileDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Date_File", True))
        Me.Date_FileDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_FileDateTimePicker.Location = New System.Drawing.Point(502, 24)
        Me.Date_FileDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.Date_FileDateTimePicker.Name = "Date_FileDateTimePicker"
        Me.Date_FileDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.Date_FileDateTimePicker.TabIndex = 1
        '
        'TblStudentTableAdapter
        '
        Me.TblStudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAccessTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCollegeTableAdapter = Nothing
        Me.TableAdapterManager.tblCourseTableAdapter = Nothing
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
        Me.TableAdapterManager.tblSchoolYearTableAdapter = Nothing
        Me.TableAdapterManager.tblSectionTableAdapter = Nothing
        Me.TableAdapterManager.tblSemesterTableAdapter = Nothing
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
        'tFind
        '
        Me.tFind.Location = New System.Drawing.Point(9, 534)
        Me.tFind.Margin = New System.Windows.Forms.Padding(2)
        Me.tFind.Name = "tFind"
        Me.tFind.Size = New System.Drawing.Size(182, 20)
        Me.tFind.TabIndex = 34
        '
        'bFind
        '
        Me.bFind.Location = New System.Drawing.Point(204, 531)
        Me.bFind.Margin = New System.Windows.Forms.Padding(2)
        Me.bFind.Name = "bFind"
        Me.bFind.Size = New System.Drawing.Size(86, 24)
        Me.bFind.TabIndex = 33
        Me.bFind.Text = "Find"
        Me.bFind.UseVisualStyleBackColor = True
        '
        'bClear
        '
        Me.bClear.Location = New System.Drawing.Point(294, 531)
        Me.bClear.Margin = New System.Windows.Forms.Padding(2)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(86, 24)
        Me.bClear.TabIndex = 35
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'StudentFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 589)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.tFind)
        Me.Controls.Add(Me.bFind)
        Me.Controls.Add(Date_FileLabel)
        Me.Controls.Add(Me.Date_FileDateTimePicker)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TblStudentDataGridView)
        Me.Controls.Add(Me.TblStudentBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information"
        CType(Me.TblStudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblStudentBindingNavigator.ResumeLayout(False)
        Me.TblStudentBindingNavigator.PerformLayout()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.SiblingPositionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoOfSiblingsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MstDataSet As EnrollSys.MstDataSet
    Friend WithEvents TblStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStudentTableAdapter As EnrollSys.MstDataSetTableAdapters.tblStudentTableAdapter
    Friend WithEvents TableAdapterManager As EnrollSys.MstDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblStudentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblStudentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblStudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReligionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlaceOfBirthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitizenshipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_FileDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TblCourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCourseTableAdapter As EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter
    Friend WithEvents SessionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents HeightNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents WeightNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ProvAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoOfSiblingsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SiblingPositionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LastSchoolNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lang_DialectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatherWorkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotherWorkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Emergency_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_AddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_RelationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Live_AddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Live_ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Live_RelationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Live_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Educ_CourseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Educ_DeptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_CourseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HighSchool_AwardTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HighSchool_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HighSchoolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Elem_AwardTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Elem_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ElementaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Highest_SectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Highest_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Highest_EducTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Highest_AddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Survey_Other_SpecifyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Survey_OtherCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Survey_TVCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Survey_RadioCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Survey_NewsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Survey_BoucherCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Survey_CareerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Survey_Friend_RelCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CourseIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReturneeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents New_StudRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Old_StudRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tFind As System.Windows.Forms.TextBox
    Friend WithEvents bFind As System.Windows.Forms.Button
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class

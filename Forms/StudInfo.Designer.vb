<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudInfo
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
        Dim Date_FileLabel As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim SessionLabel As System.Windows.Forms.Label
        Dim LRNNoLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim PlaceOfBirthLabel As System.Windows.Forms.Label
        Dim CitizenshipLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim BloodTypeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ProvAddLabel As System.Windows.Forms.Label
        Dim NoOfSiblingsLabel As System.Windows.Forms.Label
        Dim SiblingPositionLabel As System.Windows.Forms.Label
        Dim Lang_DialectLabel As System.Windows.Forms.Label
        Dim FatherContactLabel As System.Windows.Forms.Label
        Dim Father_RelLabel As System.Windows.Forms.Label
        Dim FatherBplaceLabel As System.Windows.Forms.Label
        Dim Father_BDayLabel As System.Windows.Forms.Label
        Dim FatherWorkLabel As System.Windows.Forms.Label
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim MotherNameLabel As System.Windows.Forms.Label
        Dim MotherWorkLabel As System.Windows.Forms.Label
        Dim MotherContactLabel As System.Windows.Forms.Label
        Dim Mother_BdayLabel As System.Windows.Forms.Label
        Dim MotherBplaceLabel As System.Windows.Forms.Label
        Dim Mother_RelLabel As System.Windows.Forms.Label
        Dim GuardianContactLabel As System.Windows.Forms.Label
        Dim Live_NameLabel As System.Windows.Forms.Label
        Dim Live_RelationLabel As System.Windows.Forms.Label
        Dim Live_ContactLabel As System.Windows.Forms.Label
        Dim Emergency_NameLabel As System.Windows.Forms.Label
        Dim Emergency_RelationLabel As System.Windows.Forms.Label
        Dim Emergency_ContactLabel As System.Windows.Forms.Label
        Dim Live_AddLabel As System.Windows.Forms.Label
        Dim ElementaryLabel As System.Windows.Forms.Label
        Dim Elem_YearLabel As System.Windows.Forms.Label
        Dim HighSchoolLabel As System.Windows.Forms.Label
        Dim HighSchool_YearLabel As System.Windows.Forms.Label
        Dim LastSchoolNameLabel As System.Windows.Forms.Label
        Dim LastSchool_YRLabel As System.Windows.Forms.Label
        Dim Private_PublicLabel As System.Windows.Forms.Label
        Dim LastSchoolAddLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim WeightLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudInfo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblStudentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.TblStudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.StudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_FileDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightNumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.ReligionTextBox = New System.Windows.Forms.TextBox()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.AgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Lang_DialectComboBox = New System.Windows.Forms.ComboBox()
        Me.SiblingPositionNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NoOfSiblingsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProvAddTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BloodTypeTextBox = New System.Windows.Forms.TextBox()
        Me.CitizenshipTextBox = New System.Windows.Forms.TextBox()
        Me.PlaceOfBirthTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LRNNoTextBox = New System.Windows.Forms.TextBox()
        Me.SessionTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.CrossEnroleeRadioButton = New System.Windows.Forms.RadioButton()
        Me.ReturneeRadioButton = New System.Windows.Forms.RadioButton()
        Me.TransfereeRadioButton = New System.Windows.Forms.RadioButton()
        Me.New_StudRadioButton = New System.Windows.Forms.RadioButton()
        Me.Old_StudRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GuardianContactTextBox = New System.Windows.Forms.TextBox()
        Me.Mother_RelTextBox = New System.Windows.Forms.TextBox()
        Me.MotherBplaceTextBox = New System.Windows.Forms.TextBox()
        Me.Mother_BdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MotherContactTextBox = New System.Windows.Forms.TextBox()
        Me.MotherWorkTextBox = New System.Windows.Forms.TextBox()
        Me.MotherNameTextBox = New System.Windows.Forms.TextBox()
        Me.FatherContactTextBox = New System.Windows.Forms.TextBox()
        Me.Father_RelTextBox = New System.Windows.Forms.TextBox()
        Me.FatherBplaceTextBox = New System.Windows.Forms.TextBox()
        Me.Father_BDayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FatherWorkTextBox = New System.Windows.Forms.TextBox()
        Me.FatherNameTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Live_AddTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_RelationTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Live_ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Live_RelationTextBox = New System.Windows.Forms.TextBox()
        Me.Live_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LastSchoolAddTextBox = New System.Windows.Forms.TextBox()
        Me.Private_PublicComboBox = New System.Windows.Forms.ComboBox()
        Me.LastSchool_YRTextBox = New System.Windows.Forms.TextBox()
        Me.LastSchoolNameTextBox = New System.Windows.Forms.TextBox()
        Me.HighSchool_YearTextBox = New System.Windows.Forms.TextBox()
        Me.HighSchoolTextBox = New System.Windows.Forms.TextBox()
        Me.Elem_YearTextBox = New System.Windows.Forms.TextBox()
        Me.ElementaryTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Honor_DismisCheckBox = New System.Windows.Forms.CheckBox()
        Me.TORCheckBox = New System.Windows.Forms.CheckBox()
        Me.QVRCheckBox = New System.Windows.Forms.CheckBox()
        Me.EMP_ConsCheckBox = New System.Windows.Forms.CheckBox()
        Me.GMCCheckBox = New System.Windows.Forms.CheckBox()
        Me.NSO_PSACheckBox = New System.Windows.Forms.CheckBox()
        Me.Form138CheckBox = New System.Windows.Forms.CheckBox()
        Me.Form137CheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bClear = New System.Windows.Forms.Button()
        Me.tFind = New System.Windows.Forms.TextBox()
        Me.bFind = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Badd = New System.Windows.Forms.Button()
        Me.bsave = New System.Windows.Forms.Button()
        Me.TblStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstDataSet = New EnrollSys.MstDataSet()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblStudentTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblStudentTableAdapter()
        Me.TableAdapterManager = New EnrollSys.MstDataSetTableAdapters.TableAdapterManager()
        Date_FileLabel = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        SessionLabel = New System.Windows.Forms.Label()
        LRNNoLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        BirthDateLabel = New System.Windows.Forms.Label()
        PlaceOfBirthLabel = New System.Windows.Forms.Label()
        CitizenshipLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        BloodTypeLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ProvAddLabel = New System.Windows.Forms.Label()
        NoOfSiblingsLabel = New System.Windows.Forms.Label()
        SiblingPositionLabel = New System.Windows.Forms.Label()
        Lang_DialectLabel = New System.Windows.Forms.Label()
        FatherContactLabel = New System.Windows.Forms.Label()
        Father_RelLabel = New System.Windows.Forms.Label()
        FatherBplaceLabel = New System.Windows.Forms.Label()
        Father_BDayLabel = New System.Windows.Forms.Label()
        FatherWorkLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        MotherNameLabel = New System.Windows.Forms.Label()
        MotherWorkLabel = New System.Windows.Forms.Label()
        MotherContactLabel = New System.Windows.Forms.Label()
        Mother_BdayLabel = New System.Windows.Forms.Label()
        MotherBplaceLabel = New System.Windows.Forms.Label()
        Mother_RelLabel = New System.Windows.Forms.Label()
        GuardianContactLabel = New System.Windows.Forms.Label()
        Live_NameLabel = New System.Windows.Forms.Label()
        Live_RelationLabel = New System.Windows.Forms.Label()
        Live_ContactLabel = New System.Windows.Forms.Label()
        Emergency_NameLabel = New System.Windows.Forms.Label()
        Emergency_RelationLabel = New System.Windows.Forms.Label()
        Emergency_ContactLabel = New System.Windows.Forms.Label()
        Live_AddLabel = New System.Windows.Forms.Label()
        ElementaryLabel = New System.Windows.Forms.Label()
        Elem_YearLabel = New System.Windows.Forms.Label()
        HighSchoolLabel = New System.Windows.Forms.Label()
        HighSchool_YearLabel = New System.Windows.Forms.Label()
        LastSchoolNameLabel = New System.Windows.Forms.Label()
        LastSchool_YRLabel = New System.Windows.Forms.Label()
        Private_PublicLabel = New System.Windows.Forms.Label()
        LastSchoolAddLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        WeightLabel1 = New System.Windows.Forms.Label()
        CType(Me.TblStudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblStudentBindingNavigator.SuspendLayout()
        CType(Me.TblStudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.WeightNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiblingPositionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoOfSiblingsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Date_FileLabel
        '
        Date_FileLabel.AutoSize = True
        Date_FileLabel.Location = New System.Drawing.Point(419, 28)
        Date_FileLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Date_FileLabel.Name = "Date_FileLabel"
        Date_FileLabel.Size = New System.Drawing.Size(83, 13)
        Date_FileLabel.TabIndex = 2
        Date_FileLabel.Text = "Admission Date:"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(48, 66)
        StudentIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 10
        StudentIDLabel.Text = "Student ID:"
        '
        'SessionLabel
        '
        SessionLabel.AutoSize = True
        SessionLabel.Location = New System.Drawing.Point(267, 86)
        SessionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SessionLabel.Name = "SessionLabel"
        SessionLabel.Size = New System.Drawing.Size(47, 13)
        SessionLabel.TabIndex = 11
        SessionLabel.Text = "Session:"
        SessionLabel.Visible = False
        '
        'LRNNoLabel
        '
        LRNNoLabel.AutoSize = True
        LRNNoLabel.Location = New System.Drawing.Point(270, 113)
        LRNNoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LRNNoLabel.Name = "LRNNoLabel"
        LRNNoLabel.Size = New System.Drawing.Size(46, 13)
        LRNNoLabel.TabIndex = 12
        LRNNoLabel.Text = "LRNNo:"
        LRNNoLabel.Visible = False
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(47, 89)
        LastNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 13
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(47, 113)
        FirstNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 14
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(36, 137)
        MiddleNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(72, 13)
        MiddleNameLabel.TabIndex = 16
        MiddleNameLabel.Text = "Middle Name:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(45, 183)
        ContactNoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(64, 13)
        ContactNoLabel.TabIndex = 18
        ContactNoLabel.Text = "Contact No:"
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Location = New System.Drawing.Point(213, 258)
        BirthDateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(57, 13)
        BirthDateLabel.TabIndex = 20
        BirthDateLabel.Text = "Birth Date:"
        '
        'PlaceOfBirthLabel
        '
        PlaceOfBirthLabel.AutoSize = True
        PlaceOfBirthLabel.Location = New System.Drawing.Point(32, 162)
        PlaceOfBirthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PlaceOfBirthLabel.Name = "PlaceOfBirthLabel"
        PlaceOfBirthLabel.Size = New System.Drawing.Size(75, 13)
        PlaceOfBirthLabel.TabIndex = 22
        PlaceOfBirthLabel.Text = "Place Of Birth:"
        '
        'CitizenshipLabel
        '
        CitizenshipLabel.AutoSize = True
        CitizenshipLabel.Location = New System.Drawing.Point(47, 210)
        CitizenshipLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CitizenshipLabel.Name = "CitizenshipLabel"
        CitizenshipLabel.Size = New System.Drawing.Size(60, 13)
        CitizenshipLabel.TabIndex = 24
        CitizenshipLabel.Text = "Citizenship:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Location = New System.Drawing.Point(195, 234)
        HeightLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(41, 13)
        HeightLabel.TabIndex = 28
        HeightLabel.Text = "Height:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(166, 234)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(25, 13)
        Label2.TabIndex = 30
        Label2.Text = "(kg)"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(315, 232)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(27, 13)
        Label3.TabIndex = 31
        Label3.Text = "(cm)"
        '
        'BloodTypeLabel
        '
        BloodTypeLabel.AutoSize = True
        BloodTypeLabel.Location = New System.Drawing.Point(346, 232)
        BloodTypeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BloodTypeLabel.Name = "BloodTypeLabel"
        BloodTypeLabel.Size = New System.Drawing.Size(64, 13)
        BloodTypeLabel.TabIndex = 16
        BloodTypeLabel.Text = "Blood Type:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(59, 282)
        AddressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 34
        AddressLabel.Text = "Address:"
        '
        'ProvAddLabel
        '
        ProvAddLabel.AutoSize = True
        ProvAddLabel.Location = New System.Drawing.Point(10, 304)
        ProvAddLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ProvAddLabel.Name = "ProvAddLabel"
        ProvAddLabel.Size = New System.Drawing.Size(97, 13)
        ProvAddLabel.TabIndex = 36
        ProvAddLabel.Text = "Provincial Address:"
        '
        'NoOfSiblingsLabel
        '
        NoOfSiblingsLabel.AutoSize = True
        NoOfSiblingsLabel.Location = New System.Drawing.Point(30, 332)
        NoOfSiblingsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NoOfSiblingsLabel.Name = "NoOfSiblingsLabel"
        NoOfSiblingsLabel.Size = New System.Drawing.Size(77, 13)
        NoOfSiblingsLabel.TabIndex = 38
        NoOfSiblingsLabel.Text = "No Of Siblings:"
        '
        'SiblingPositionLabel
        '
        SiblingPositionLabel.AutoSize = True
        SiblingPositionLabel.Location = New System.Drawing.Point(26, 356)
        SiblingPositionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SiblingPositionLabel.Name = "SiblingPositionLabel"
        SiblingPositionLabel.Size = New System.Drawing.Size(81, 13)
        SiblingPositionLabel.TabIndex = 40
        SiblingPositionLabel.Text = "Sibling Position:"
        '
        'Lang_DialectLabel
        '
        Lang_DialectLabel.AutoSize = True
        Lang_DialectLabel.Location = New System.Drawing.Point(27, 381)
        Lang_DialectLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Lang_DialectLabel.Name = "Lang_DialectLabel"
        Lang_DialectLabel.Size = New System.Drawing.Size(80, 13)
        Lang_DialectLabel.TabIndex = 42
        Lang_DialectLabel.Text = "Mother Tounge"
        '
        'FatherContactLabel
        '
        FatherContactLabel.AutoSize = True
        FatherContactLabel.Location = New System.Drawing.Point(20, 136)
        FatherContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FatherContactLabel.Name = "FatherContactLabel"
        FatherContactLabel.Size = New System.Drawing.Size(80, 13)
        FatherContactLabel.TabIndex = 66
        FatherContactLabel.Text = "Father Contact:"
        '
        'Father_RelLabel
        '
        Father_RelLabel.AutoSize = True
        Father_RelLabel.Location = New System.Drawing.Point(20, 161)
        Father_RelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Father_RelLabel.Name = "Father_RelLabel"
        Father_RelLabel.Size = New System.Drawing.Size(78, 13)
        Father_RelLabel.TabIndex = 64
        Father_RelLabel.Text = "Father Religion"
        '
        'FatherBplaceLabel
        '
        FatherBplaceLabel.AutoSize = True
        FatherBplaceLabel.Location = New System.Drawing.Point(26, 184)
        FatherBplaceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FatherBplaceLabel.Name = "FatherBplaceLabel"
        FatherBplaceLabel.Size = New System.Drawing.Size(70, 13)
        FatherBplaceLabel.TabIndex = 62
        FatherBplaceLabel.Text = "Place of Birth"
        '
        'Father_BDayLabel
        '
        Father_BDayLabel.AutoSize = True
        Father_BDayLabel.Location = New System.Drawing.Point(31, 114)
        Father_BDayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Father_BDayLabel.Name = "Father_BDayLabel"
        Father_BDayLabel.Size = New System.Drawing.Size(66, 13)
        Father_BDayLabel.TabIndex = 60
        Father_BDayLabel.Text = "Date of Birth"
        '
        'FatherWorkLabel
        '
        FatherWorkLabel.AutoSize = True
        FatherWorkLabel.Location = New System.Drawing.Point(35, 90)
        FatherWorkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FatherWorkLabel.Name = "FatherWorkLabel"
        FatherWorkLabel.Size = New System.Drawing.Size(62, 13)
        FatherWorkLabel.TabIndex = 58
        FatherWorkLabel.Text = "Occupation"
        '
        'FatherNameLabel
        '
        FatherNameLabel.AutoSize = True
        FatherNameLabel.Location = New System.Drawing.Point(29, 66)
        FatherNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(71, 13)
        FatherNameLabel.TabIndex = 56
        FatherNameLabel.Text = "Father Name:"
        '
        'MotherNameLabel
        '
        MotherNameLabel.AutoSize = True
        MotherNameLabel.Location = New System.Drawing.Point(329, 65)
        MotherNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MotherNameLabel.Name = "MotherNameLabel"
        MotherNameLabel.Size = New System.Drawing.Size(74, 13)
        MotherNameLabel.TabIndex = 67
        MotherNameLabel.Text = "Mother Name:"
        '
        'MotherWorkLabel
        '
        MotherWorkLabel.AutoSize = True
        MotherWorkLabel.Location = New System.Drawing.Point(342, 91)
        MotherWorkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MotherWorkLabel.Name = "MotherWorkLabel"
        MotherWorkLabel.Size = New System.Drawing.Size(62, 13)
        MotherWorkLabel.TabIndex = 68
        MotherWorkLabel.Text = "Occupation"
        '
        'MotherContactLabel
        '
        MotherContactLabel.AutoSize = True
        MotherContactLabel.Location = New System.Drawing.Point(321, 139)
        MotherContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MotherContactLabel.Name = "MotherContactLabel"
        MotherContactLabel.Size = New System.Drawing.Size(83, 13)
        MotherContactLabel.TabIndex = 69
        MotherContactLabel.Text = "Mother Contact:"
        '
        'Mother_BdayLabel
        '
        Mother_BdayLabel.AutoSize = True
        Mother_BdayLabel.Location = New System.Drawing.Point(332, 115)
        Mother_BdayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Mother_BdayLabel.Name = "Mother_BdayLabel"
        Mother_BdayLabel.Size = New System.Drawing.Size(66, 13)
        Mother_BdayLabel.TabIndex = 70
        Mother_BdayLabel.Text = "Date of Birth"
        '
        'MotherBplaceLabel
        '
        MotherBplaceLabel.AutoSize = True
        MotherBplaceLabel.Location = New System.Drawing.Point(332, 188)
        MotherBplaceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MotherBplaceLabel.Name = "MotherBplaceLabel"
        MotherBplaceLabel.Size = New System.Drawing.Size(70, 13)
        MotherBplaceLabel.TabIndex = 71
        MotherBplaceLabel.Text = "Place of Birth"
        '
        'Mother_RelLabel
        '
        Mother_RelLabel.AutoSize = True
        Mother_RelLabel.Location = New System.Drawing.Point(321, 163)
        Mother_RelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Mother_RelLabel.Name = "Mother_RelLabel"
        Mother_RelLabel.Size = New System.Drawing.Size(81, 13)
        Mother_RelLabel.TabIndex = 72
        Mother_RelLabel.Text = "Mother Religion"
        '
        'GuardianContactLabel
        '
        GuardianContactLabel.AutoSize = True
        GuardianContactLabel.Location = New System.Drawing.Point(28, 248)
        GuardianContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        GuardianContactLabel.Name = "GuardianContactLabel"
        GuardianContactLabel.Size = New System.Drawing.Size(183, 13)
        GuardianContactLabel.TabIndex = 73
        GuardianContactLabel.Text = "Contact Number of Parents/Guardian"
        GuardianContactLabel.Visible = False
        '
        'Live_NameLabel
        '
        Live_NameLabel.AutoSize = True
        Live_NameLabel.Location = New System.Drawing.Point(68, 53)
        Live_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Live_NameLabel.Name = "Live_NameLabel"
        Live_NameLabel.Size = New System.Drawing.Size(38, 13)
        Live_NameLabel.TabIndex = 2
        Live_NameLabel.Text = "Name:"
        '
        'Live_RelationLabel
        '
        Live_RelationLabel.AutoSize = True
        Live_RelationLabel.Location = New System.Drawing.Point(37, 76)
        Live_RelationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Live_RelationLabel.Name = "Live_RelationLabel"
        Live_RelationLabel.Size = New System.Drawing.Size(68, 13)
        Live_RelationLabel.TabIndex = 3
        Live_RelationLabel.Text = "Relationship:"
        '
        'Live_ContactLabel
        '
        Live_ContactLabel.AutoSize = True
        Live_ContactLabel.Location = New System.Drawing.Point(43, 98)
        Live_ContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Live_ContactLabel.Name = "Live_ContactLabel"
        Live_ContactLabel.Size = New System.Drawing.Size(64, 13)
        Live_ContactLabel.TabIndex = 5
        Live_ContactLabel.Text = "Contact No:"
        '
        'Emergency_NameLabel
        '
        Emergency_NameLabel.AutoSize = True
        Emergency_NameLabel.Location = New System.Drawing.Point(73, 191)
        Emergency_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Emergency_NameLabel.Name = "Emergency_NameLabel"
        Emergency_NameLabel.Size = New System.Drawing.Size(38, 13)
        Emergency_NameLabel.TabIndex = 8
        Emergency_NameLabel.Text = "Name:"
        '
        'Emergency_RelationLabel
        '
        Emergency_RelationLabel.AutoSize = True
        Emergency_RelationLabel.Location = New System.Drawing.Point(42, 214)
        Emergency_RelationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Emergency_RelationLabel.Name = "Emergency_RelationLabel"
        Emergency_RelationLabel.Size = New System.Drawing.Size(68, 13)
        Emergency_RelationLabel.TabIndex = 10
        Emergency_RelationLabel.Text = "Relationship:"
        '
        'Emergency_ContactLabel
        '
        Emergency_ContactLabel.AutoSize = True
        Emergency_ContactLabel.Location = New System.Drawing.Point(48, 236)
        Emergency_ContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Emergency_ContactLabel.Name = "Emergency_ContactLabel"
        Emergency_ContactLabel.Size = New System.Drawing.Size(64, 13)
        Emergency_ContactLabel.TabIndex = 12
        Emergency_ContactLabel.Text = "Contact No:"
        '
        'Live_AddLabel
        '
        Live_AddLabel.AutoSize = True
        Live_AddLabel.Location = New System.Drawing.Point(56, 121)
        Live_AddLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Live_AddLabel.Name = "Live_AddLabel"
        Live_AddLabel.Size = New System.Drawing.Size(48, 13)
        Live_AddLabel.TabIndex = 16
        Live_AddLabel.Text = "Address:"
        '
        'ElementaryLabel
        '
        ElementaryLabel.AutoSize = True
        ElementaryLabel.Location = New System.Drawing.Point(66, 59)
        ElementaryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ElementaryLabel.Name = "ElementaryLabel"
        ElementaryLabel.Size = New System.Drawing.Size(62, 13)
        ElementaryLabel.TabIndex = 0
        ElementaryLabel.Text = "Elementary:"
        '
        'Elem_YearLabel
        '
        Elem_YearLabel.AutoSize = True
        Elem_YearLabel.Location = New System.Drawing.Point(420, 60)
        Elem_YearLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Elem_YearLabel.Name = "Elem_YearLabel"
        Elem_YearLabel.Size = New System.Drawing.Size(32, 13)
        Elem_YearLabel.TabIndex = 2
        Elem_YearLabel.Text = "Year:"
        '
        'HighSchoolLabel
        '
        HighSchoolLabel.AutoSize = True
        HighSchoolLabel.Location = New System.Drawing.Point(60, 84)
        HighSchoolLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        HighSchoolLabel.Name = "HighSchoolLabel"
        HighSchoolLabel.Size = New System.Drawing.Size(68, 13)
        HighSchoolLabel.TabIndex = 4
        HighSchoolLabel.Text = "High School:"
        '
        'HighSchool_YearLabel
        '
        HighSchool_YearLabel.AutoSize = True
        HighSchool_YearLabel.Location = New System.Drawing.Point(420, 84)
        HighSchool_YearLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        HighSchool_YearLabel.Name = "HighSchool_YearLabel"
        HighSchool_YearLabel.Size = New System.Drawing.Size(32, 13)
        HighSchool_YearLabel.TabIndex = 6
        HighSchool_YearLabel.Text = "Year:"
        '
        'LastSchoolNameLabel
        '
        LastSchoolNameLabel.AutoSize = True
        LastSchoolNameLabel.Location = New System.Drawing.Point(31, 108)
        LastSchoolNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LastSchoolNameLabel.Name = "LastSchoolNameLabel"
        LastSchoolNameLabel.Size = New System.Drawing.Size(97, 13)
        LastSchoolNameLabel.TabIndex = 8
        LastSchoolNameLabel.Text = "Last School Name:"
        '
        'LastSchool_YRLabel
        '
        LastSchool_YRLabel.AutoSize = True
        LastSchool_YRLabel.Location = New System.Drawing.Point(420, 108)
        LastSchool_YRLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LastSchool_YRLabel.Name = "LastSchool_YRLabel"
        LastSchool_YRLabel.Size = New System.Drawing.Size(32, 13)
        LastSchool_YRLabel.TabIndex = 10
        LastSchool_YRLabel.Text = "Year:"
        '
        'Private_PublicLabel
        '
        Private_PublicLabel.AutoSize = True
        Private_PublicLabel.Location = New System.Drawing.Point(55, 131)
        Private_PublicLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Private_PublicLabel.Name = "Private_PublicLabel"
        Private_PublicLabel.Size = New System.Drawing.Size(70, 13)
        Private_PublicLabel.TabIndex = 12
        Private_PublicLabel.Text = "School Type:"
        '
        'LastSchoolAddLabel
        '
        LastSchoolAddLabel.AutoSize = True
        LastSchoolAddLabel.Location = New System.Drawing.Point(22, 154)
        LastSchoolAddLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LastSchoolAddLabel.Name = "LastSchoolAddLabel"
        LastSchoolAddLabel.Size = New System.Drawing.Size(107, 13)
        LastSchoolAddLabel.TabIndex = 46
        LastSchoolAddLabel.Text = "Last School Address:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(369, 258)
        AgeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 61
        AgeLabel.Text = "Age:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(46, 258)
        StatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(62, 13)
        StatusLabel.TabIndex = 63
        StatusLabel.Text = "Civil Status:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Location = New System.Drawing.Point(212, 332)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(48, 13)
        ReligionLabel.TabIndex = 63
        ReligionLabel.Text = "Religion:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(215, 356)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 64
        GenderLabel.Text = "Gender:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(61, 234)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 65
        WeightLabel.Text = "Weight:"
        '
        'WeightLabel1
        '
        WeightLabel1.AutoSize = True
        WeightLabel1.Location = New System.Drawing.Point(386, 374)
        WeightLabel1.Name = "WeightLabel1"
        WeightLabel1.Size = New System.Drawing.Size(44, 13)
        WeightLabel1.TabIndex = 39
        WeightLabel1.Text = "Weight:"
        WeightLabel1.Visible = False
        '
        'TblStudentBindingNavigator
        '
        Me.TblStudentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblStudentBindingNavigator.BindingSource = Me.TblStudentBindingSource
        Me.TblStudentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblStudentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblStudentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblStudentBindingNavigatorSaveItem})
        Me.TblStudentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblStudentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblStudentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblStudentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblStudentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblStudentBindingNavigator.Name = "TblStudentBindingNavigator"
        Me.TblStudentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblStudentBindingNavigator.Size = New System.Drawing.Size(1059, 25)
        Me.TblStudentBindingNavigator.TabIndex = 0
        Me.TblStudentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        '
        'TblStudentBindingNavigatorSaveItem
        '
        Me.TblStudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TblStudentBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblStudentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblStudentBindingNavigatorSaveItem.Name = "TblStudentBindingNavigatorSaveItem"
        Me.TblStudentBindingNavigatorSaveItem.Size = New System.Drawing.Size(87, 22)
        Me.TblStudentBindingNavigatorSaveItem.Text = "Save Data/Edit"
        '
        'TblStudentDataGridView
        '
        Me.TblStudentDataGridView.AllowUserToAddRows = False
        Me.TblStudentDataGridView.AllowUserToDeleteRows = False
        Me.TblStudentDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblStudentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TblStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblStudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentID, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.TblStudentDataGridView.DataSource = Me.TblStudentBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblStudentDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.TblStudentDataGridView.Location = New System.Drawing.Point(0, 26)
        Me.TblStudentDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.TblStudentDataGridView.Name = "TblStudentDataGridView"
        Me.TblStudentDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblStudentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TblStudentDataGridView.RowHeadersVisible = False
        Me.TblStudentDataGridView.RowTemplate.Height = 24
        Me.TblStudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblStudentDataGridView.Size = New System.Drawing.Size(397, 479)
        Me.TblStudentDataGridView.TabIndex = 1
        '
        'StudentID
        '
        Me.StudentID.DataPropertyName = "StudentID"
        Me.StudentID.HeaderText = "Student ID"
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
        '
        'Date_FileDateTimePicker
        '
        Me.Date_FileDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Date_File", True))
        Me.Date_FileDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_FileDateTimePicker.Location = New System.Drawing.Point(506, 24)
        Me.Date_FileDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.Date_FileDateTimePicker.Name = "Date_FileDateTimePicker"
        Me.Date_FileDateTimePicker.Size = New System.Drawing.Size(85, 20)
        Me.Date_FileDateTimePicker.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(401, 47)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(638, 458)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.HeightTextBox)
        Me.TabPage1.Controls.Add(Me.WeightTextBox)
        Me.TabPage1.Controls.Add(WeightLabel1)
        Me.TabPage1.Controls.Add(WeightLabel)
        Me.TabPage1.Controls.Add(Me.WeightNumericUpDown1)
        Me.TabPage1.Controls.Add(GenderLabel)
        Me.TabPage1.Controls.Add(Me.GenderTextBox)
        Me.TabPage1.Controls.Add(ReligionLabel)
        Me.TabPage1.Controls.Add(Me.ReligionTextBox)
        Me.TabPage1.Controls.Add(Me.pict_logo)
        Me.TabPage1.Controls.Add(Me.StatusComboBox)
        Me.TabPage1.Controls.Add(StatusLabel)
        Me.TabPage1.Controls.Add(AgeLabel)
        Me.TabPage1.Controls.Add(Me.AgeNumericUpDown)
        Me.TabPage1.Controls.Add(Lang_DialectLabel)
        Me.TabPage1.Controls.Add(Me.Lang_DialectComboBox)
        Me.TabPage1.Controls.Add(SiblingPositionLabel)
        Me.TabPage1.Controls.Add(Me.SiblingPositionNumericUpDown)
        Me.TabPage1.Controls.Add(NoOfSiblingsLabel)
        Me.TabPage1.Controls.Add(Me.NoOfSiblingsNumericUpDown)
        Me.TabPage1.Controls.Add(ProvAddLabel)
        Me.TabPage1.Controls.Add(Me.ProvAddTextBox)
        Me.TabPage1.Controls.Add(AddressLabel)
        Me.TabPage1.Controls.Add(Me.AddressTextBox)
        Me.TabPage1.Controls.Add(BloodTypeLabel)
        Me.TabPage1.Controls.Add(Me.BloodTypeTextBox)
        Me.TabPage1.Controls.Add(Label3)
        Me.TabPage1.Controls.Add(Label2)
        Me.TabPage1.Controls.Add(HeightLabel)
        Me.TabPage1.Controls.Add(CitizenshipLabel)
        Me.TabPage1.Controls.Add(Me.CitizenshipTextBox)
        Me.TabPage1.Controls.Add(PlaceOfBirthLabel)
        Me.TabPage1.Controls.Add(Me.PlaceOfBirthTextBox)
        Me.TabPage1.Controls.Add(BirthDateLabel)
        Me.TabPage1.Controls.Add(Me.BirthDateDateTimePicker)
        Me.TabPage1.Controls.Add(ContactNoLabel)
        Me.TabPage1.Controls.Add(Me.ContactNoTextBox)
        Me.TabPage1.Controls.Add(MiddleNameLabel)
        Me.TabPage1.Controls.Add(Me.MiddleNameTextBox)
        Me.TabPage1.Controls.Add(FirstNameLabel)
        Me.TabPage1.Controls.Add(Me.FirstNameTextBox)
        Me.TabPage1.Controls.Add(LastNameLabel)
        Me.TabPage1.Controls.Add(Me.LastNameTextBox)
        Me.TabPage1.Controls.Add(LRNNoLabel)
        Me.TabPage1.Controls.Add(Me.LRNNoTextBox)
        Me.TabPage1.Controls.Add(SessionLabel)
        Me.TabPage1.Controls.Add(Me.SessionTextBox)
        Me.TabPage1.Controls.Add(StudentIDLabel)
        Me.TabPage1.Controls.Add(Me.StudentIDTextBox)
        Me.TabPage1.Controls.Add(Me.CrossEnroleeRadioButton)
        Me.TabPage1.Controls.Add(Me.ReturneeRadioButton)
        Me.TabPage1.Controls.Add(Me.TransfereeRadioButton)
        Me.TabPage1.Controls.Add(Me.New_StudRadioButton)
        Me.TabPage1.Controls.Add(Me.Old_StudRadioButton)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(630, 429)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'HeightTextBox
        '
        Me.HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Height", True))
        Me.HeightTextBox.Location = New System.Drawing.Point(248, 229)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(66, 20)
        Me.HeightTextBox.TabIndex = 68
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(111, 232)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(50, 20)
        Me.WeightTextBox.TabIndex = 67
        '
        'WeightNumericUpDown1
        '
        Me.WeightNumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Weight", True))
        Me.WeightNumericUpDown1.Location = New System.Drawing.Point(436, 374)
        Me.WeightNumericUpDown1.Name = "WeightNumericUpDown1"
        Me.WeightNumericUpDown1.Size = New System.Drawing.Size(77, 20)
        Me.WeightNumericUpDown1.TabIndex = 40
        Me.WeightNumericUpDown1.Visible = False
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(266, 353)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 65
        '
        'ReligionTextBox
        '
        Me.ReligionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Religion", True))
        Me.ReligionTextBox.Location = New System.Drawing.Point(266, 329)
        Me.ReligionTextBox.Name = "ReligionTextBox"
        Me.ReligionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReligionTextBox.TabIndex = 64
        '
        'pict_logo
        '
        Me.pict_logo.Image = Global.EnrollSys.My.Resources.Resources._18x18_logo_samson
        Me.pict_logo.Location = New System.Drawing.Point(499, 6)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(110, 125)
        Me.pict_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pict_logo.TabIndex = 40
        Me.pict_logo.TabStop = False
        Me.pict_logo.Visible = False
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Widow", "Separated", "Divorce/Annuled"})
        Me.StatusComboBox.Location = New System.Drawing.Point(111, 255)
        Me.StatusComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(92, 21)
        Me.StatusComboBox.TabIndex = 8
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Age", True))
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(402, 255)
        Me.AgeNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.AgeNumericUpDown.TabIndex = 60
        '
        'Lang_DialectComboBox
        '
        Me.Lang_DialectComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Lang_Dialect", True))
        Me.Lang_DialectComboBox.FormattingEnabled = True
        Me.Lang_DialectComboBox.Items.AddRange(New Object() {"Tagalog", "English", "Cebuano"})
        Me.Lang_DialectComboBox.Location = New System.Drawing.Point(111, 377)
        Me.Lang_DialectComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Lang_DialectComboBox.Name = "Lang_DialectComboBox"
        Me.Lang_DialectComboBox.Size = New System.Drawing.Size(92, 21)
        Me.Lang_DialectComboBox.TabIndex = 13
        '
        'SiblingPositionNumericUpDown
        '
        Me.SiblingPositionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "SiblingPosition", True))
        Me.SiblingPositionNumericUpDown.Location = New System.Drawing.Point(111, 353)
        Me.SiblingPositionNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.SiblingPositionNumericUpDown.Name = "SiblingPositionNumericUpDown"
        Me.SiblingPositionNumericUpDown.Size = New System.Drawing.Size(90, 20)
        Me.SiblingPositionNumericUpDown.TabIndex = 12
        '
        'NoOfSiblingsNumericUpDown
        '
        Me.NoOfSiblingsNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "NoOfSiblings", True))
        Me.NoOfSiblingsNumericUpDown.Location = New System.Drawing.Point(111, 329)
        Me.NoOfSiblingsNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.NoOfSiblingsNumericUpDown.Name = "NoOfSiblingsNumericUpDown"
        Me.NoOfSiblingsNumericUpDown.Size = New System.Drawing.Size(90, 20)
        Me.NoOfSiblingsNumericUpDown.TabIndex = 11
        '
        'ProvAddTextBox
        '
        Me.ProvAddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "ProvAdd", True))
        Me.ProvAddTextBox.Location = New System.Drawing.Point(111, 304)
        Me.ProvAddTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProvAddTextBox.Name = "ProvAddTextBox"
        Me.ProvAddTextBox.Size = New System.Drawing.Size(339, 20)
        Me.ProvAddTextBox.TabIndex = 10
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(111, 280)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(339, 20)
        Me.AddressTextBox.TabIndex = 9
        '
        'BloodTypeTextBox
        '
        Me.BloodTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "BloodType", True))
        Me.BloodTypeTextBox.Location = New System.Drawing.Point(414, 227)
        Me.BloodTypeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BloodTypeTextBox.Name = "BloodTypeTextBox"
        Me.BloodTypeTextBox.Size = New System.Drawing.Size(108, 20)
        Me.BloodTypeTextBox.TabIndex = 33
        '
        'CitizenshipTextBox
        '
        Me.CitizenshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Citizenship", True))
        Me.CitizenshipTextBox.Location = New System.Drawing.Point(111, 207)
        Me.CitizenshipTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CitizenshipTextBox.Name = "CitizenshipTextBox"
        Me.CitizenshipTextBox.Size = New System.Drawing.Size(113, 20)
        Me.CitizenshipTextBox.TabIndex = 6
        '
        'PlaceOfBirthTextBox
        '
        Me.PlaceOfBirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "PlaceOfBirth", True))
        Me.PlaceOfBirthTextBox.Location = New System.Drawing.Point(111, 159)
        Me.PlaceOfBirthTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PlaceOfBirthTextBox.Name = "PlaceOfBirthTextBox"
        Me.PlaceOfBirthTextBox.Size = New System.Drawing.Size(231, 20)
        Me.PlaceOfBirthTextBox.TabIndex = 4
        '
        'BirthDateDateTimePicker
        '
        Me.BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthDateDateTimePicker.Location = New System.Drawing.Point(274, 255)
        Me.BirthDateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker"
        Me.BirthDateDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.BirthDateDateTimePicker.TabIndex = 21
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Location = New System.Drawing.Point(111, 183)
        Me.ContactNoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(113, 20)
        Me.ContactNoTextBox.TabIndex = 5
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(111, 135)
        Me.MiddleNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(127, 20)
        Me.MiddleNameTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(111, 111)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(141, 20)
        Me.FirstNameTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(111, 87)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(130, 20)
        Me.LastNameTextBox.TabIndex = 1
        '
        'LRNNoTextBox
        '
        Me.LRNNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "LRNNo", True))
        Me.LRNNoTextBox.Location = New System.Drawing.Point(318, 110)
        Me.LRNNoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LRNNoTextBox.Name = "LRNNoTextBox"
        Me.LRNNoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.LRNNoTextBox.TabIndex = 15
        Me.LRNNoTextBox.Visible = False
        '
        'SessionTextBox
        '
        Me.SessionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Session", True))
        Me.SessionTextBox.Location = New System.Drawing.Point(318, 84)
        Me.SessionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SessionTextBox.Name = "SessionTextBox"
        Me.SessionTextBox.Size = New System.Drawing.Size(76, 20)
        Me.SessionTextBox.TabIndex = 14
        Me.SessionTextBox.Visible = False
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(111, 63)
        Me.StudentIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(76, 20)
        Me.StudentIDTextBox.TabIndex = 0
        '
        'CrossEnroleeRadioButton
        '
        Me.CrossEnroleeRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblStudentBindingSource, "CrossEnrolee", True))
        Me.CrossEnroleeRadioButton.Location = New System.Drawing.Point(359, 24)
        Me.CrossEnroleeRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CrossEnroleeRadioButton.Name = "CrossEnroleeRadioButton"
        Me.CrossEnroleeRadioButton.Size = New System.Drawing.Size(91, 20)
        Me.CrossEnroleeRadioButton.TabIndex = 10
        Me.CrossEnroleeRadioButton.Text = "Cross Enrolee"
        Me.CrossEnroleeRadioButton.UseVisualStyleBackColor = True
        '
        'ReturneeRadioButton
        '
        Me.ReturneeRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblStudentBindingSource, "Returnee", True))
        Me.ReturneeRadioButton.Location = New System.Drawing.Point(288, 24)
        Me.ReturneeRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ReturneeRadioButton.Name = "ReturneeRadioButton"
        Me.ReturneeRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.ReturneeRadioButton.TabIndex = 8
        Me.ReturneeRadioButton.Text = "Returnee"
        Me.ReturneeRadioButton.UseVisualStyleBackColor = True
        '
        'TransfereeRadioButton
        '
        Me.TransfereeRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblStudentBindingSource, "Transferee", True))
        Me.TransfereeRadioButton.Location = New System.Drawing.Point(206, 24)
        Me.TransfereeRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.TransfereeRadioButton.Name = "TransfereeRadioButton"
        Me.TransfereeRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.TransfereeRadioButton.TabIndex = 6
        Me.TransfereeRadioButton.Text = "Transferee"
        Me.TransfereeRadioButton.UseVisualStyleBackColor = True
        '
        'New_StudRadioButton
        '
        Me.New_StudRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblStudentBindingSource, "New_Stud", True))
        Me.New_StudRadioButton.Location = New System.Drawing.Point(157, 24)
        Me.New_StudRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.New_StudRadioButton.Name = "New_StudRadioButton"
        Me.New_StudRadioButton.Size = New System.Drawing.Size(53, 20)
        Me.New_StudRadioButton.TabIndex = 4
        Me.New_StudRadioButton.Text = "New"
        Me.New_StudRadioButton.UseVisualStyleBackColor = True
        '
        'Old_StudRadioButton
        '
        Me.Old_StudRadioButton.Checked = True
        Me.Old_StudRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblStudentBindingSource, "Old_Stud", True))
        Me.Old_StudRadioButton.Location = New System.Drawing.Point(105, 24)
        Me.Old_StudRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.Old_StudRadioButton.Name = "Old_StudRadioButton"
        Me.Old_StudRadioButton.Size = New System.Drawing.Size(47, 19)
        Me.Old_StudRadioButton.TabIndex = 2
        Me.Old_StudRadioButton.TabStop = True
        Me.Old_StudRadioButton.Text = "Old"
        Me.Old_StudRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status:"
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(GuardianContactLabel)
        Me.TabPage5.Controls.Add(Me.GuardianContactTextBox)
        Me.TabPage5.Controls.Add(Mother_RelLabel)
        Me.TabPage5.Controls.Add(Me.Mother_RelTextBox)
        Me.TabPage5.Controls.Add(MotherBplaceLabel)
        Me.TabPage5.Controls.Add(Me.MotherBplaceTextBox)
        Me.TabPage5.Controls.Add(Mother_BdayLabel)
        Me.TabPage5.Controls.Add(Me.Mother_BdayDateTimePicker)
        Me.TabPage5.Controls.Add(MotherContactLabel)
        Me.TabPage5.Controls.Add(Me.MotherContactTextBox)
        Me.TabPage5.Controls.Add(MotherWorkLabel)
        Me.TabPage5.Controls.Add(Me.MotherWorkTextBox)
        Me.TabPage5.Controls.Add(MotherNameLabel)
        Me.TabPage5.Controls.Add(Me.MotherNameTextBox)
        Me.TabPage5.Controls.Add(FatherContactLabel)
        Me.TabPage5.Controls.Add(Me.FatherContactTextBox)
        Me.TabPage5.Controls.Add(Father_RelLabel)
        Me.TabPage5.Controls.Add(Me.Father_RelTextBox)
        Me.TabPage5.Controls.Add(FatherBplaceLabel)
        Me.TabPage5.Controls.Add(Me.FatherBplaceTextBox)
        Me.TabPage5.Controls.Add(Father_BDayLabel)
        Me.TabPage5.Controls.Add(Me.Father_BDayDateTimePicker)
        Me.TabPage5.Controls.Add(FatherWorkLabel)
        Me.TabPage5.Controls.Add(Me.FatherWorkTextBox)
        Me.TabPage5.Controls.Add(FatherNameLabel)
        Me.TabPage5.Controls.Add(Me.FatherNameTextBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Size = New System.Drawing.Size(630, 429)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Parents"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GuardianContactTextBox
        '
        Me.GuardianContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "GuardianContact", True))
        Me.GuardianContactTextBox.Location = New System.Drawing.Point(216, 244)
        Me.GuardianContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GuardianContactTextBox.Name = "GuardianContactTextBox"
        Me.GuardianContactTextBox.Size = New System.Drawing.Size(232, 20)
        Me.GuardianContactTextBox.TabIndex = 74
        Me.GuardianContactTextBox.Visible = False
        '
        'Mother_RelTextBox
        '
        Me.Mother_RelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Mother_Rel", True))
        Me.Mother_RelTextBox.Location = New System.Drawing.Point(406, 160)
        Me.Mother_RelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Mother_RelTextBox.Name = "Mother_RelTextBox"
        Me.Mother_RelTextBox.Size = New System.Drawing.Size(176, 20)
        Me.Mother_RelTextBox.TabIndex = 73
        '
        'MotherBplaceTextBox
        '
        Me.MotherBplaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MotherBplace", True))
        Me.MotherBplaceTextBox.Location = New System.Drawing.Point(406, 184)
        Me.MotherBplaceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MotherBplaceTextBox.Name = "MotherBplaceTextBox"
        Me.MotherBplaceTextBox.Size = New System.Drawing.Size(176, 20)
        Me.MotherBplaceTextBox.TabIndex = 72
        '
        'Mother_BdayDateTimePicker
        '
        Me.Mother_BdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Mother_Bday", True))
        Me.Mother_BdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Mother_BdayDateTimePicker.Location = New System.Drawing.Point(406, 112)
        Me.Mother_BdayDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.Mother_BdayDateTimePicker.Name = "Mother_BdayDateTimePicker"
        Me.Mother_BdayDateTimePicker.Size = New System.Drawing.Size(85, 20)
        Me.Mother_BdayDateTimePicker.TabIndex = 71
        '
        'MotherContactTextBox
        '
        Me.MotherContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MotherContact", True))
        Me.MotherContactTextBox.Location = New System.Drawing.Point(406, 136)
        Me.MotherContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MotherContactTextBox.Name = "MotherContactTextBox"
        Me.MotherContactTextBox.Size = New System.Drawing.Size(126, 20)
        Me.MotherContactTextBox.TabIndex = 70
        '
        'MotherWorkTextBox
        '
        Me.MotherWorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MotherWork", True))
        Me.MotherWorkTextBox.Location = New System.Drawing.Point(406, 87)
        Me.MotherWorkTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MotherWorkTextBox.Name = "MotherWorkTextBox"
        Me.MotherWorkTextBox.Size = New System.Drawing.Size(123, 20)
        Me.MotherWorkTextBox.TabIndex = 69
        '
        'MotherNameTextBox
        '
        Me.MotherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "MotherName", True))
        Me.MotherNameTextBox.Location = New System.Drawing.Point(406, 63)
        Me.MotherNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MotherNameTextBox.Name = "MotherNameTextBox"
        Me.MotherNameTextBox.Size = New System.Drawing.Size(176, 20)
        Me.MotherNameTextBox.TabIndex = 68
        '
        'FatherContactTextBox
        '
        Me.FatherContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FatherContact", True))
        Me.FatherContactTextBox.Location = New System.Drawing.Point(103, 134)
        Me.FatherContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FatherContactTextBox.Name = "FatherContactTextBox"
        Me.FatherContactTextBox.Size = New System.Drawing.Size(126, 20)
        Me.FatherContactTextBox.TabIndex = 67
        '
        'Father_RelTextBox
        '
        Me.Father_RelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Father_Rel", True))
        Me.Father_RelTextBox.Location = New System.Drawing.Point(103, 158)
        Me.Father_RelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Father_RelTextBox.Name = "Father_RelTextBox"
        Me.Father_RelTextBox.Size = New System.Drawing.Size(168, 20)
        Me.Father_RelTextBox.TabIndex = 65
        '
        'FatherBplaceTextBox
        '
        Me.FatherBplaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FatherBplace", True))
        Me.FatherBplaceTextBox.Location = New System.Drawing.Point(103, 182)
        Me.FatherBplaceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FatherBplaceTextBox.Name = "FatherBplaceTextBox"
        Me.FatherBplaceTextBox.Size = New System.Drawing.Size(168, 20)
        Me.FatherBplaceTextBox.TabIndex = 63
        '
        'Father_BDayDateTimePicker
        '
        Me.Father_BDayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStudentBindingSource, "Father_BDay", True))
        Me.Father_BDayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Father_BDayDateTimePicker.Location = New System.Drawing.Point(103, 111)
        Me.Father_BDayDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.Father_BDayDateTimePicker.Name = "Father_BDayDateTimePicker"
        Me.Father_BDayDateTimePicker.Size = New System.Drawing.Size(85, 20)
        Me.Father_BDayDateTimePicker.TabIndex = 61
        '
        'FatherWorkTextBox
        '
        Me.FatherWorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FatherWork", True))
        Me.FatherWorkTextBox.Location = New System.Drawing.Point(103, 87)
        Me.FatherWorkTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FatherWorkTextBox.Name = "FatherWorkTextBox"
        Me.FatherWorkTextBox.Size = New System.Drawing.Size(130, 20)
        Me.FatherWorkTextBox.TabIndex = 59
        '
        'FatherNameTextBox
        '
        Me.FatherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "FatherName", True))
        Me.FatherNameTextBox.Location = New System.Drawing.Point(103, 63)
        Me.FatherNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FatherNameTextBox.Name = "FatherNameTextBox"
        Me.FatherNameTextBox.Size = New System.Drawing.Size(168, 20)
        Me.FatherNameTextBox.TabIndex = 57
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Live_AddLabel)
        Me.TabPage2.Controls.Add(Me.Live_AddTextBox)
        Me.TabPage2.Controls.Add(Emergency_ContactLabel)
        Me.TabPage2.Controls.Add(Me.Emergency_ContactTextBox)
        Me.TabPage2.Controls.Add(Emergency_RelationLabel)
        Me.TabPage2.Controls.Add(Me.Emergency_RelationTextBox)
        Me.TabPage2.Controls.Add(Emergency_NameLabel)
        Me.TabPage2.Controls.Add(Me.Emergency_NameTextBox)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Live_ContactLabel)
        Me.TabPage2.Controls.Add(Me.Live_ContactTextBox)
        Me.TabPage2.Controls.Add(Live_RelationLabel)
        Me.TabPage2.Controls.Add(Me.Live_RelationTextBox)
        Me.TabPage2.Controls.Add(Live_NameLabel)
        Me.TabPage2.Controls.Add(Me.Live_NameTextBox)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(630, 429)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Presently Live & Emergency"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Live_AddTextBox
        '
        Me.Live_AddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Live_Add", True))
        Me.Live_AddTextBox.Location = New System.Drawing.Point(111, 119)
        Me.Live_AddTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Live_AddTextBox.Name = "Live_AddTextBox"
        Me.Live_AddTextBox.Size = New System.Drawing.Size(371, 20)
        Me.Live_AddTextBox.TabIndex = 17
        '
        'Emergency_ContactTextBox
        '
        Me.Emergency_ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Emergency_Contact", True))
        Me.Emergency_ContactTextBox.Location = New System.Drawing.Point(122, 232)
        Me.Emergency_ContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Emergency_ContactTextBox.Name = "Emergency_ContactTextBox"
        Me.Emergency_ContactTextBox.Size = New System.Drawing.Size(187, 20)
        Me.Emergency_ContactTextBox.TabIndex = 13
        '
        'Emergency_RelationTextBox
        '
        Me.Emergency_RelationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Emergency_Relation", True))
        Me.Emergency_RelationTextBox.Location = New System.Drawing.Point(122, 210)
        Me.Emergency_RelationTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Emergency_RelationTextBox.Name = "Emergency_RelationTextBox"
        Me.Emergency_RelationTextBox.Size = New System.Drawing.Size(107, 20)
        Me.Emergency_RelationTextBox.TabIndex = 11
        '
        'Emergency_NameTextBox
        '
        Me.Emergency_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Emergency_Name", True))
        Me.Emergency_NameTextBox.Location = New System.Drawing.Point(122, 187)
        Me.Emergency_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Emergency_NameTextBox.Name = "Emergency_NameTextBox"
        Me.Emergency_NameTextBox.Size = New System.Drawing.Size(284, 20)
        Me.Emergency_NameTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "In Case of Emergency, please notify"
        '
        'Live_ContactTextBox
        '
        Me.Live_ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Live_Contact", True))
        Me.Live_ContactTextBox.Location = New System.Drawing.Point(111, 96)
        Me.Live_ContactTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Live_ContactTextBox.Name = "Live_ContactTextBox"
        Me.Live_ContactTextBox.Size = New System.Drawing.Size(198, 20)
        Me.Live_ContactTextBox.TabIndex = 6
        '
        'Live_RelationTextBox
        '
        Me.Live_RelationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Live_Relation", True))
        Me.Live_RelationTextBox.Location = New System.Drawing.Point(111, 73)
        Me.Live_RelationTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Live_RelationTextBox.Name = "Live_RelationTextBox"
        Me.Live_RelationTextBox.Size = New System.Drawing.Size(118, 20)
        Me.Live_RelationTextBox.TabIndex = 4
        '
        'Live_NameTextBox
        '
        Me.Live_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Live_Name", True))
        Me.Live_NameTextBox.Location = New System.Drawing.Point(111, 50)
        Me.Live_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Live_NameTextBox.Name = "Live_NameTextBox"
        Me.Live_NameTextBox.Size = New System.Drawing.Size(295, 20)
        Me.Live_NameTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "With Whom do you Presently Live?"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(LastSchoolAddLabel)
        Me.TabPage3.Controls.Add(Me.LastSchoolAddTextBox)
        Me.TabPage3.Controls.Add(Private_PublicLabel)
        Me.TabPage3.Controls.Add(Me.Private_PublicComboBox)
        Me.TabPage3.Controls.Add(LastSchool_YRLabel)
        Me.TabPage3.Controls.Add(Me.LastSchool_YRTextBox)
        Me.TabPage3.Controls.Add(LastSchoolNameLabel)
        Me.TabPage3.Controls.Add(Me.LastSchoolNameTextBox)
        Me.TabPage3.Controls.Add(HighSchool_YearLabel)
        Me.TabPage3.Controls.Add(Me.HighSchool_YearTextBox)
        Me.TabPage3.Controls.Add(HighSchoolLabel)
        Me.TabPage3.Controls.Add(Me.HighSchoolTextBox)
        Me.TabPage3.Controls.Add(Elem_YearLabel)
        Me.TabPage3.Controls.Add(Me.Elem_YearTextBox)
        Me.TabPage3.Controls.Add(ElementaryLabel)
        Me.TabPage3.Controls.Add(Me.ElementaryTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(630, 429)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Educational Background"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LastSchoolAddTextBox
        '
        Me.LastSchoolAddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "LastSchoolAdd", True))
        Me.LastSchoolAddTextBox.Location = New System.Drawing.Point(133, 154)
        Me.LastSchoolAddTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastSchoolAddTextBox.Name = "LastSchoolAddTextBox"
        Me.LastSchoolAddTextBox.Size = New System.Drawing.Size(253, 20)
        Me.LastSchoolAddTextBox.TabIndex = 47
        '
        'Private_PublicComboBox
        '
        Me.Private_PublicComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Private_Public", True))
        Me.Private_PublicComboBox.FormattingEnabled = True
        Me.Private_PublicComboBox.Items.AddRange(New Object() {"Private", "Public"})
        Me.Private_PublicComboBox.Location = New System.Drawing.Point(133, 129)
        Me.Private_PublicComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Private_PublicComboBox.Name = "Private_PublicComboBox"
        Me.Private_PublicComboBox.Size = New System.Drawing.Size(124, 21)
        Me.Private_PublicComboBox.TabIndex = 13
        '
        'LastSchool_YRTextBox
        '
        Me.LastSchool_YRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "LastSchool_YR", True))
        Me.LastSchool_YRTextBox.Location = New System.Drawing.Point(456, 105)
        Me.LastSchool_YRTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastSchool_YRTextBox.Name = "LastSchool_YRTextBox"
        Me.LastSchool_YRTextBox.Size = New System.Drawing.Size(92, 20)
        Me.LastSchool_YRTextBox.TabIndex = 11
        '
        'LastSchoolNameTextBox
        '
        Me.LastSchoolNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "LastSchoolName", True))
        Me.LastSchoolNameTextBox.Location = New System.Drawing.Point(133, 105)
        Me.LastSchoolNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastSchoolNameTextBox.Name = "LastSchoolNameTextBox"
        Me.LastSchoolNameTextBox.Size = New System.Drawing.Size(276, 20)
        Me.LastSchoolNameTextBox.TabIndex = 9
        '
        'HighSchool_YearTextBox
        '
        Me.HighSchool_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "HighSchool_Year", True))
        Me.HighSchool_YearTextBox.Location = New System.Drawing.Point(456, 81)
        Me.HighSchool_YearTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.HighSchool_YearTextBox.Name = "HighSchool_YearTextBox"
        Me.HighSchool_YearTextBox.Size = New System.Drawing.Size(92, 20)
        Me.HighSchool_YearTextBox.TabIndex = 7
        '
        'HighSchoolTextBox
        '
        Me.HighSchoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "HighSchool", True))
        Me.HighSchoolTextBox.Location = New System.Drawing.Point(133, 81)
        Me.HighSchoolTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.HighSchoolTextBox.Name = "HighSchoolTextBox"
        Me.HighSchoolTextBox.Size = New System.Drawing.Size(276, 20)
        Me.HighSchoolTextBox.TabIndex = 5
        '
        'Elem_YearTextBox
        '
        Me.Elem_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Elem_Year", True))
        Me.Elem_YearTextBox.Location = New System.Drawing.Point(456, 56)
        Me.Elem_YearTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Elem_YearTextBox.Name = "Elem_YearTextBox"
        Me.Elem_YearTextBox.Size = New System.Drawing.Size(92, 20)
        Me.Elem_YearTextBox.TabIndex = 3
        '
        'ElementaryTextBox
        '
        Me.ElementaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentBindingSource, "Elementary", True))
        Me.ElementaryTextBox.Location = New System.Drawing.Point(133, 56)
        Me.ElementaryTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ElementaryTextBox.Name = "ElementaryTextBox"
        Me.ElementaryTextBox.Size = New System.Drawing.Size(276, 20)
        Me.ElementaryTextBox.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Honor_DismisCheckBox)
        Me.TabPage4.Controls.Add(Me.TORCheckBox)
        Me.TabPage4.Controls.Add(Me.QVRCheckBox)
        Me.TabPage4.Controls.Add(Me.EMP_ConsCheckBox)
        Me.TabPage4.Controls.Add(Me.GMCCheckBox)
        Me.TabPage4.Controls.Add(Me.NSO_PSACheckBox)
        Me.TabPage4.Controls.Add(Me.Form138CheckBox)
        Me.TabPage4.Controls.Add(Me.Form137CheckBox)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(630, 429)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Record Submitted"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Honor_DismisCheckBox
        '
        Me.Honor_DismisCheckBox.AutoSize = True
        Me.Honor_DismisCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "Honor_Dismis", True))
        Me.Honor_DismisCheckBox.Location = New System.Drawing.Point(30, 298)
        Me.Honor_DismisCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Honor_DismisCheckBox.Name = "Honor_DismisCheckBox"
        Me.Honor_DismisCheckBox.Size = New System.Drawing.Size(121, 17)
        Me.Honor_DismisCheckBox.TabIndex = 16
        Me.Honor_DismisCheckBox.Text = "Honorable Dismissal"
        Me.Honor_DismisCheckBox.UseVisualStyleBackColor = True
        '
        'TORCheckBox
        '
        Me.TORCheckBox.AutoSize = True
        Me.TORCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "TOR", True))
        Me.TORCheckBox.Location = New System.Drawing.Point(30, 264)
        Me.TORCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TORCheckBox.Name = "TORCheckBox"
        Me.TORCheckBox.Size = New System.Drawing.Size(160, 17)
        Me.TORCheckBox.TabIndex = 14
        Me.TORCheckBox.Text = "Transcript of Records (TOR)"
        Me.TORCheckBox.UseVisualStyleBackColor = True
        '
        'QVRCheckBox
        '
        Me.QVRCheckBox.AutoSize = True
        Me.QVRCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "QVR", True))
        Me.QVRCheckBox.Location = New System.Drawing.Point(30, 232)
        Me.QVRCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QVRCheckBox.Name = "QVRCheckBox"
        Me.QVRCheckBox.Size = New System.Drawing.Size(215, 17)
        Me.QVRCheckBox.TabIndex = 12
        Me.QVRCheckBox.Text = "Qualified Voucher Recipient Cert. (QVR)"
        Me.QVRCheckBox.UseVisualStyleBackColor = True
        '
        'EMP_ConsCheckBox
        '
        Me.EMP_ConsCheckBox.AutoSize = True
        Me.EMP_ConsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "EMP_Cons", True))
        Me.EMP_ConsCheckBox.Location = New System.Drawing.Point(30, 195)
        Me.EMP_ConsCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EMP_ConsCheckBox.Name = "EMP_ConsCheckBox"
        Me.EMP_ConsCheckBox.Size = New System.Drawing.Size(118, 17)
        Me.EMP_ConsCheckBox.TabIndex = 10
        Me.EMP_ConsCheckBox.Text = "Employer's Consent"
        Me.EMP_ConsCheckBox.UseVisualStyleBackColor = True
        '
        'GMCCheckBox
        '
        Me.GMCCheckBox.AutoSize = True
        Me.GMCCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "GMC", True))
        Me.GMCCheckBox.Location = New System.Drawing.Point(30, 158)
        Me.GMCCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GMCCheckBox.Name = "GMCCheckBox"
        Me.GMCCheckBox.Size = New System.Drawing.Size(130, 17)
        Me.GMCCheckBox.TabIndex = 8
        Me.GMCCheckBox.Text = "Good Moral Character"
        Me.GMCCheckBox.UseVisualStyleBackColor = True
        '
        'NSO_PSACheckBox
        '
        Me.NSO_PSACheckBox.AutoSize = True
        Me.NSO_PSACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "NSO_PSA", True))
        Me.NSO_PSACheckBox.Location = New System.Drawing.Point(30, 123)
        Me.NSO_PSACheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NSO_PSACheckBox.Name = "NSO_PSACheckBox"
        Me.NSO_PSACheckBox.Size = New System.Drawing.Size(125, 17)
        Me.NSO_PSACheckBox.TabIndex = 6
        Me.NSO_PSACheckBox.Text = "NSO/PSA Certificate"
        Me.NSO_PSACheckBox.UseVisualStyleBackColor = True
        '
        'Form138CheckBox
        '
        Me.Form138CheckBox.AutoSize = True
        Me.Form138CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "form138", True))
        Me.Form138CheckBox.Location = New System.Drawing.Point(30, 87)
        Me.Form138CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Form138CheckBox.Name = "Form138CheckBox"
        Me.Form138CheckBox.Size = New System.Drawing.Size(70, 17)
        Me.Form138CheckBox.TabIndex = 4
        Me.Form138CheckBox.Text = "Form 138"
        Me.Form138CheckBox.UseVisualStyleBackColor = True
        '
        'Form137CheckBox
        '
        Me.Form137CheckBox.AutoSize = True
        Me.Form137CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblStudentBindingSource, "form137", True))
        Me.Form137CheckBox.Location = New System.Drawing.Point(30, 55)
        Me.Form137CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Form137CheckBox.Name = "Form137CheckBox"
        Me.Form137CheckBox.Size = New System.Drawing.Size(70, 17)
        Me.Form137CheckBox.TabIndex = 3
        Me.Form137CheckBox.Text = "Form 137"
        Me.Form137CheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(329, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "School Records Submitted Upon Enrollment:"
        '
        'bClear
        '
        Me.bClear.Location = New System.Drawing.Point(297, 519)
        Me.bClear.Margin = New System.Windows.Forms.Padding(2)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(86, 24)
        Me.bClear.TabIndex = 38
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'tFind
        '
        Me.tFind.Location = New System.Drawing.Point(12, 522)
        Me.tFind.Margin = New System.Windows.Forms.Padding(2)
        Me.tFind.Name = "tFind"
        Me.tFind.Size = New System.Drawing.Size(182, 20)
        Me.tFind.TabIndex = 37
        '
        'bFind
        '
        Me.bFind.Location = New System.Drawing.Point(207, 519)
        Me.bFind.Margin = New System.Windows.Forms.Padding(2)
        Me.bFind.Name = "bFind"
        Me.bFind.Size = New System.Drawing.Size(86, 24)
        Me.bFind.TabIndex = 36
        Me.bFind.Text = "Find"
        Me.bFind.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 515)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 27)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Print Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Badd
        '
        Me.Badd.Location = New System.Drawing.Point(574, 515)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(83, 28)
        Me.Badd.TabIndex = 40
        Me.Badd.Text = "Add"
        Me.Badd.UseVisualStyleBackColor = True
        Me.Badd.Visible = False
        '
        'bsave
        '
        Me.bsave.Location = New System.Drawing.Point(671, 514)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(83, 28)
        Me.bsave.TabIndex = 41
        Me.bsave.Text = "Save"
        Me.bsave.UseVisualStyleBackColor = True
        Me.bsave.Visible = False
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
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn22.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "MiddleName"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Middle Name"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
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
        'StudInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 565)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.Badd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.tFind)
        Me.Controls.Add(Me.bFind)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Date_FileLabel)
        Me.Controls.Add(Me.Date_FileDateTimePicker)
        Me.Controls.Add(Me.TblStudentDataGridView)
        Me.Controls.Add(Me.TblStudentBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudInfo"
        CType(Me.TblStudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblStudentBindingNavigator.ResumeLayout(False)
        Me.TblStudentBindingNavigator.PerformLayout()
        CType(Me.TblStudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.WeightNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiblingPositionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoOfSiblingsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Date_FileDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CrossEnroleeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ReturneeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TransfereeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents New_StudRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Old_StudRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents MiddleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LRNNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SessionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitizenshipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlaceOfBirthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lang_DialectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SiblingPositionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NoOfSiblingsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GuardianContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mother_RelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotherBplaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mother_BdayDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MotherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotherWorkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Father_RelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatherBplaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Father_BDayDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FatherWorkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Live_AddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_RelationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Live_ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Live_RelationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Live_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Elem_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ElementaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Private_PublicComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LastSchool_YRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastSchoolNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HighSchool_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HighSchoolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastSchoolAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Honor_DismisCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TORCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QVRCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EMP_ConsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GMCCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NSO_PSACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Form138CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Form137CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents tFind As System.Windows.Forms.TextBox
    Friend WithEvents bFind As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents AgeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents pict_logo As System.Windows.Forms.PictureBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReligionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeightNumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Badd As System.Windows.Forms.Button
    Friend WithEvents bsave As System.Windows.Forms.Button
    Friend WithEvents HeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeightTextBox As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SectionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SectionFrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblSectionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TblSectionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSectionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblCourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblSchoolYearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SemesterID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblSemesterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LevelYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSemesterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSectionTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSectionTableAdapter()
        Me.TableAdapterManager = New EnrollSys.MstDataSetTableAdapters.TableAdapterManager()
        Me.TblCourseTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter()
        Me.TblSchoolYearTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSchoolYearTableAdapter()
        Me.TblSemesterTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSemesterTableAdapter()
        Me.lTots = New System.Windows.Forms.Label()
        CType(Me.TblSectionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSectionBindingNavigator.SuspendLayout()
        CType(Me.TblSectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSectionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchoolYearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSemesterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSemesterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblSectionBindingNavigator
        '
        Me.TblSectionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblSectionBindingNavigator.BindingSource = Me.TblSectionBindingSource
        Me.TblSectionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSectionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblSectionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblSectionBindingNavigatorSaveItem})
        Me.TblSectionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSectionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSectionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSectionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSectionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSectionBindingNavigator.Name = "TblSectionBindingNavigator"
        Me.TblSectionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSectionBindingNavigator.Size = New System.Drawing.Size(878, 25)
        Me.TblSectionBindingNavigator.TabIndex = 0
        Me.TblSectionBindingNavigator.Text = "BindingNavigator1"
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
        'TblSectionBindingSource
        '
        Me.TblSectionBindingSource.DataMember = "tblSection"
        Me.TblSectionBindingSource.DataSource = Me.MstDataSet
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
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
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
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblSectionBindingNavigatorSaveItem
        '
        Me.TblSectionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblSectionBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblSectionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblSectionBindingNavigatorSaveItem.Name = "TblSectionBindingNavigatorSaveItem"
        Me.TblSectionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblSectionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblSectionDataGridView
        '
        Me.TblSectionDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblSectionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TblSectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSectionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn3, Me.SemesterID, Me.LevelYear, Me.DataGridViewTextBoxColumn5})
        Me.TblSectionDataGridView.DataSource = Me.TblSectionBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblSectionDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.TblSectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblSectionDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.TblSectionDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.TblSectionDataGridView.Name = "TblSectionDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblSectionDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TblSectionDataGridView.RowHeadersVisible = False
        Me.TblSectionDataGridView.RowTemplate.Height = 24
        Me.TblSectionDataGridView.Size = New System.Drawing.Size(878, 385)
        Me.TblSectionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SectionID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SectionID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SectionTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SectionTitle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CourseID"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.TblCourseBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "Course"
        Me.DataGridViewTextBoxColumn10.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "CourseID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.ValueMember = "CourseID"
        Me.DataGridViewTextBoxColumn10.Width = 200
        '
        'TblCourseBindingSource
        '
        Me.TblCourseBindingSource.DataMember = "tblCourse"
        Me.TblCourseBindingSource.DataSource = Me.MstDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SchoolYear"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.TblSchoolYearBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "SchoolYear"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SchoolYear"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "SchoolYear"
        '
        'TblSchoolYearBindingSource
        '
        Me.TblSchoolYearBindingSource.DataMember = "tblSchoolYear"
        Me.TblSchoolYearBindingSource.DataSource = Me.MstDataSet
        '
        'SemesterID
        '
        Me.SemesterID.DataPropertyName = "SemesterID"
        Me.SemesterID.DataSource = Me.TblSemesterBindingSource
        Me.SemesterID.DisplayMember = "Semester"
        Me.SemesterID.FillWeight = 150.0!
        Me.SemesterID.HeaderText = "SemesterID"
        Me.SemesterID.Name = "SemesterID"
        Me.SemesterID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SemesterID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SemesterID.ValueMember = "SemesterID"
        Me.SemesterID.Width = 150
        '
        'TblSemesterBindingSource
        '
        Me.TblSemesterBindingSource.DataMember = "tblSemester"
        Me.TblSemesterBindingSource.DataSource = Me.MstDataSetBindingSource
        '
        'MstDataSetBindingSource
        '
        Me.MstDataSetBindingSource.DataSource = Me.MstDataSet
        Me.MstDataSetBindingSource.Position = 0
        '
        'LevelYear
        '
        Me.LevelYear.DataPropertyName = "LevelYear"
        Me.LevelYear.HeaderText = "Year/Level"
        Me.LevelYear.Name = "LevelYear"
        Me.LevelYear.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Slots"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Slots"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TblSemesterBindingSource1
        '
        Me.TblSemesterBindingSource1.DataMember = "tblSemester"
        Me.TblSemesterBindingSource1.DataSource = Me.MstDataSet
        '
        'TblSectionTableAdapter
        '
        Me.TblSectionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblSectionTableAdapter = Me.TblSectionTableAdapter
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
        'TblSchoolYearTableAdapter
        '
        Me.TblSchoolYearTableAdapter.ClearBeforeFill = True
        '
        'TblSemesterTableAdapter
        '
        Me.TblSemesterTableAdapter.ClearBeforeFill = True
        '
        'lTots
        '
        Me.lTots.AutoSize = True
        Me.lTots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTots.Location = New System.Drawing.Point(333, 6)
        Me.lTots.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTots.Name = "lTots"
        Me.lTots.Size = New System.Drawing.Size(108, 13)
        Me.lTots.TabIndex = 32
        Me.lTots.Text = "Total Sections : 0"
        '
        'SectionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 410)
        Me.Controls.Add(Me.lTots)
        Me.Controls.Add(Me.TblSectionDataGridView)
        Me.Controls.Add(Me.TblSectionBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SectionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Sections"
        CType(Me.TblSectionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSectionBindingNavigator.ResumeLayout(False)
        Me.TblSectionBindingNavigator.PerformLayout()
        CType(Me.TblSectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSectionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchoolYearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSemesterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSemesterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MstDataSet As EnrollSys.MstDataSet
    Friend WithEvents TblSectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSectionTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSectionTableAdapter
    Friend WithEvents TableAdapterManager As EnrollSys.MstDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSectionBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblSectionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblCourseTableAdapter As EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter
    Friend WithEvents TblSectionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblCourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSchoolYearTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSchoolYearTableAdapter
    Friend WithEvents TblSchoolYearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSemesterTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSemesterTableAdapter
    Friend WithEvents MstDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSemesterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblSemesterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SemesterID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents LevelYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lTots As System.Windows.Forms.Label
End Class

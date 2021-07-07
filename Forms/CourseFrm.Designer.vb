<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseFrm))
        Me.TblCourseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblCourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TblCourseBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblCourseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Init = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblDepartmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCourseTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter()
        Me.TableAdapterManager = New EnrollSys.MstDataSetTableAdapters.TableAdapterManager()
        Me.TblDepartmentTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblDepartmentTableAdapter()
        CType(Me.TblCourseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblCourseBindingNavigator.SuspendLayout()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCourseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblCourseBindingNavigator
        '
        Me.TblCourseBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblCourseBindingNavigator.BindingSource = Me.TblCourseBindingSource
        Me.TblCourseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblCourseBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblCourseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblCourseBindingNavigatorSaveItem})
        Me.TblCourseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblCourseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblCourseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblCourseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblCourseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblCourseBindingNavigator.Name = "TblCourseBindingNavigator"
        Me.TblCourseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblCourseBindingNavigator.Size = New System.Drawing.Size(882, 25)
        Me.TblCourseBindingNavigator.TabIndex = 0
        Me.TblCourseBindingNavigator.Text = "BindingNavigator1"
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
        'TblCourseBindingSource
        '
        Me.TblCourseBindingSource.DataMember = "tblCourse"
        Me.TblCourseBindingSource.DataSource = Me.MstDataSet
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
        'TblCourseBindingNavigatorSaveItem
        '
        Me.TblCourseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TblCourseBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblCourseBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblCourseBindingNavigatorSaveItem.Name = "TblCourseBindingNavigatorSaveItem"
        Me.TblCourseBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.TblCourseBindingNavigatorSaveItem.Text = "Update/Save"
        '
        'TblCourseDataGridView
        '
        Me.TblCourseDataGridView.AllowUserToDeleteRows = False
        Me.TblCourseDataGridView.AutoGenerateColumns = False
        Me.TblCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCourseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Init, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblCourseDataGridView.DataSource = Me.TblCourseBindingSource
        Me.TblCourseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblCourseDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.TblCourseDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.TblCourseDataGridView.Name = "TblCourseDataGridView"
        Me.TblCourseDataGridView.RowHeadersVisible = False
        Me.TblCourseDataGridView.RowTemplate.Height = 24
        Me.TblCourseDataGridView.Size = New System.Drawing.Size(882, 296)
        Me.TblCourseDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CourseID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CourseID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Course"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'Init
        '
        Me.Init.DataPropertyName = "Init"
        Me.Init.HeaderText = "Initial"
        Me.Init.Name = "Init"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Major"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Major"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Curriculum"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Curriculum"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DepartmentID"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.TblDepartmentBindingSource1
        Me.DataGridViewTextBoxColumn5.DisplayMember = "DepartmentTitle"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn5.HeaderText = "DepartmentID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "DepartmentID"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'TblDepartmentBindingSource1
        '
        Me.TblDepartmentBindingSource1.DataMember = "tblDepartment"
        Me.TblDepartmentBindingSource1.DataSource = Me.MstDataSet
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "YearLevel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "YearLevel"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CurrentOffered"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CurrentOffered"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Diploma"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Diploma"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataMember = "tblDepartment"
        '
        'TblCourseTableAdapter
        '
        Me.TblCourseTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblSchoolYearTableAdapter = Nothing
        Me.TableAdapterManager.tblSectionTableAdapter = Nothing
        Me.TableAdapterManager.tblSemesterTableAdapter = Nothing
        Me.TableAdapterManager.tblStudentTableAdapter = Nothing
        Me.TableAdapterManager.tblSubjectOfferingTableAdapter = Nothing
        Me.TableAdapterManager.tblSubjectTableAdapter = Nothing
        Me.TableAdapterManager.tblTeacherTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccessTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblYearLevelTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnrollSys.MstDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblDepartmentTableAdapter
        '
        Me.TblDepartmentTableAdapter.ClearBeforeFill = True
        '
        'CourseFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 321)
        Me.Controls.Add(Me.TblCourseDataGridView)
        Me.Controls.Add(Me.TblCourseBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CourseFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Course"
        CType(Me.TblCourseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblCourseBindingNavigator.ResumeLayout(False)
        Me.TblCourseBindingNavigator.PerformLayout()
        CType(Me.TblCourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCourseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MstDataSet As EnrollSys.MstDataSet
    Friend WithEvents TblCourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCourseTableAdapter As EnrollSys.MstDataSetTableAdapters.tblCourseTableAdapter
    Friend WithEvents TableAdapterManager As EnrollSys.MstDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCourseBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblCourseBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblCourseDataGridView As System.Windows.Forms.DataGridView
    'Friend WithEvents SkolDBFDataSet As EnrollSys.SkolDBFDataSet
    Friend WithEvents TblDepartmentBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents TblDepartmentTableAdapter As EnrollSys.SkolDBFDataSetTableAdapters.tblDepartmentTableAdapter
    Friend WithEvents TblDepartmentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblDepartmentTableAdapter As EnrollSys.MstDataSetTableAdapters.tblDepartmentTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Init As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class

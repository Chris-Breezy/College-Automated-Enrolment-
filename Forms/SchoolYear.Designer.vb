<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchoolYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchoolYear))
        Me.MstDataSet = New EnrollSys.MstDataSet()
        Me.TblSchoolYearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSchoolYearTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSchoolYearTableAdapter()
        Me.TableAdapterManager = New EnrollSys.MstDataSetTableAdapters.TableAdapterManager()
        Me.TblSchoolYearBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblSchoolYearBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSchoolYearDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchoolYearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchoolYearBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSchoolYearBindingNavigator.SuspendLayout()
        CType(Me.TblSchoolYearDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.tblSchoolYearTableAdapter = Me.TblSchoolYearTableAdapter
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
        'TblSchoolYearBindingNavigator
        '
        Me.TblSchoolYearBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblSchoolYearBindingNavigator.BindingSource = Me.TblSchoolYearBindingSource
        Me.TblSchoolYearBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSchoolYearBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblSchoolYearBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblSchoolYearBindingNavigatorSaveItem})
        Me.TblSchoolYearBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSchoolYearBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSchoolYearBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSchoolYearBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSchoolYearBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSchoolYearBindingNavigator.Name = "TblSchoolYearBindingNavigator"
        Me.TblSchoolYearBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSchoolYearBindingNavigator.Size = New System.Drawing.Size(230, 25)
        Me.TblSchoolYearBindingNavigator.TabIndex = 0
        Me.TblSchoolYearBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
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
        'TblSchoolYearBindingNavigatorSaveItem
        '
        Me.TblSchoolYearBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblSchoolYearBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblSchoolYearBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblSchoolYearBindingNavigatorSaveItem.Name = "TblSchoolYearBindingNavigatorSaveItem"
        Me.TblSchoolYearBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.TblSchoolYearBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblSchoolYearDataGridView
        '
        Me.TblSchoolYearDataGridView.AutoGenerateColumns = False
        Me.TblSchoolYearDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSchoolYearDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1})
        Me.TblSchoolYearDataGridView.DataSource = Me.TblSchoolYearBindingSource
        Me.TblSchoolYearDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblSchoolYearDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.TblSchoolYearDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TblSchoolYearDataGridView.Name = "TblSchoolYearDataGridView"
        Me.TblSchoolYearDataGridView.RowHeadersVisible = False
        Me.TblSchoolYearDataGridView.RowTemplate.Height = 24
        Me.TblSchoolYearDataGridView.Size = New System.Drawing.Size(230, 207)
        Me.TblSchoolYearDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SchoolYear"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SchoolYear"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Locked"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Locked"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'SchoolYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 232)
        Me.Controls.Add(Me.TblSchoolYearDataGridView)
        Me.Controls.Add(Me.TblSchoolYearBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SchoolYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Year"
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchoolYearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchoolYearBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSchoolYearBindingNavigator.ResumeLayout(False)
        Me.TblSchoolYearBindingNavigator.PerformLayout()
        CType(Me.TblSchoolYearDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MstDataSet As EnrollSys.MstDataSet
    Friend WithEvents TblSchoolYearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSchoolYearTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSchoolYearTableAdapter
    Friend WithEvents TableAdapterManager As EnrollSys.MstDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSchoolYearBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblSchoolYearBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblSchoolYearDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class

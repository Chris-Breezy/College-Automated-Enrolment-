<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SemFrm))
        Me.MstDataSet = New EnrollSys.MstDataSet()
        Me.TblSemesterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSemesterTableAdapter = New EnrollSys.MstDataSetTableAdapters.tblSemesterTableAdapter()
        Me.TableAdapterManager = New EnrollSys.MstDataSetTableAdapters.TableAdapterManager()
        Me.TblSemesterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblSemesterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSemesterDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSemesterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSemesterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSemesterBindingNavigator.SuspendLayout()
        CType(Me.TblSemesterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MstDataSet
        '
        Me.MstDataSet.DataSetName = "MstDataSet"
        Me.MstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSemesterBindingSource
        '
        Me.TblSemesterBindingSource.DataMember = "tblSemester"
        Me.TblSemesterBindingSource.DataSource = Me.MstDataSet
        '
        'TblSemesterTableAdapter
        '
        Me.TblSemesterTableAdapter.ClearBeforeFill = True
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
        'TblSemesterBindingNavigator
        '
        Me.TblSemesterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblSemesterBindingNavigator.BindingSource = Me.TblSemesterBindingSource
        Me.TblSemesterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSemesterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblSemesterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblSemesterBindingNavigatorSaveItem})
        Me.TblSemesterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSemesterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSemesterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSemesterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSemesterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSemesterBindingNavigator.Name = "TblSemesterBindingNavigator"
        Me.TblSemesterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSemesterBindingNavigator.Size = New System.Drawing.Size(298, 25)
        Me.TblSemesterBindingNavigator.TabIndex = 0
        Me.TblSemesterBindingNavigator.Text = "BindingNavigator1"
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
        'TblSemesterBindingNavigatorSaveItem
        '
        Me.TblSemesterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblSemesterBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblSemesterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblSemesterBindingNavigatorSaveItem.Name = "TblSemesterBindingNavigatorSaveItem"
        Me.TblSemesterBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblSemesterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblSemesterDataGridView
        '
        Me.TblSemesterDataGridView.AutoGenerateColumns = False
        Me.TblSemesterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSemesterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TblSemesterDataGridView.DataSource = Me.TblSemesterBindingSource
        Me.TblSemesterDataGridView.Location = New System.Drawing.Point(9, 37)
        Me.TblSemesterDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TblSemesterDataGridView.Name = "TblSemesterDataGridView"
        Me.TblSemesterDataGridView.RowHeadersVisible = False
        Me.TblSemesterDataGridView.RowTemplate.Height = 24
        Me.TblSemesterDataGridView.Size = New System.Drawing.Size(280, 179)
        Me.TblSemesterDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SemesterID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SemesterID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Semester"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Semester"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'SemFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 241)
        Me.Controls.Add(Me.TblSemesterDataGridView)
        Me.Controls.Add(Me.TblSemesterBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SemFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Semester"
        CType(Me.MstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSemesterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSemesterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSemesterBindingNavigator.ResumeLayout(False)
        Me.TblSemesterBindingNavigator.PerformLayout()
        CType(Me.TblSemesterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MstDataSet As EnrollSys.MstDataSet
    Friend WithEvents TblSemesterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSemesterTableAdapter As EnrollSys.MstDataSetTableAdapters.tblSemesterTableAdapter
    Friend WithEvents TableAdapterManager As EnrollSys.MstDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSemesterBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblSemesterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblSemesterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

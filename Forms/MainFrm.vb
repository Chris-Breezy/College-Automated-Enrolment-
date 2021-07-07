Imports System.Windows.Forms

Public Class MainFrm

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub EnrollmentFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnrollmentFormToolStripMenuItem.Click
        Dim frmEnroll As New EnrollFrm
        frmEnroll.ShowDialog()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        Dim frmCourse As New CourseFrm
        frmCourse.ShowDialog()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        Dim frmdept As New DeptFrm
        frmdept.ShowDialog()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        Dim frmRoom As New RoomFrm
        frmRoom.ShowDialog()

    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScheduleToolStripMenuItem.Click
        Dim frmSched As New ScheduleFrm
        frmSched.ShowDialog()
    End Sub

    Private Sub SchoolYearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SchoolYearToolStripMenuItem.Click
        Dim frmSchooYr As New SchoolYear
        frmSchooYr.ShowDialog()
    End Sub

    Private Sub SectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SectionToolStripMenuItem.Click
        Dim frmsec As New SectionFrm
        frmsec.ShowDialog()
    End Sub

    Private Sub SemesterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SemesterToolStripMenuItem.Click
        Dim frmsem As New SemFrm
        frmsem.ShowDialog()
    End Sub

    Private Sub StudentInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentInfoToolStripMenuItem.Click
        Dim Studfrm As New StudInfo
        Studfrm.ShowDialog()
    End Sub

    Private Sub SubjectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        Dim frmsubj As New SubjFrm
        frmsubj.ShowDialog()
    End Sub

    Private Sub TeacherToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TeacherToolStripMenuItem.Click
        Dim frmTeach As New TeacherFrm
        frmTeach.ShowDialog()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        If MessageBox.Show("Want to Quit the System?", "Close the System...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        tym.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
        'Ltime.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        Dim frmuser As New UserFrm
        frmuser.ShowDialog()
    End Sub

    Private Sub tym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tym.Click

    End Sub
End Class

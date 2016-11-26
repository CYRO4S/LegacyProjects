Public Class Form1

    


    Private Function SourceDirectoryExists() As Boolean
        If Not (System.IO.Directory.Exists(txtSource.Text)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function SourceFileExists() As Boolean
        If Not (System.IO.File.Exists(txtSource.Text)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Form2.ShowDialog()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim Title, Destination, Source, Content As String
        Dim time As Integer = txtTime.Text
        Me.Visible = False
        Me.ShowInTaskbar = False
        Source = txtSource.Text
        Destination = txtDestination.Text
        Content = txtContent.Text
        Title = txtTitle.Text
        If RBDirectory.Checked = True Then
            Do
                SourceDirectoryExists()
                System.Threading.Thread.Sleep(100 * time)
            Loop Until SourceDirectoryExists() = True
            If ckbHide.Checked = True Then
                Shell("xcopy.exe " & Source & " " & Destination & " /H /E", AppWinStyle.Hide, False)
                If ckbMsgbox.Checked = True Then
                    If RBIOK.Checked = True Then
                        MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf RBQYN.Checked = True Then
                        If (MessageBox.Show(Content, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
                        Else
                        End If
                    ElseIf RBWOK.Checked = True Then
                        MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf RBEOK.Checked = True Then
                        MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    End
                Else
                    End
                End If
            Else
                Shell("xcopy.exe " & Source & " " & Destination & " /E", AppWinStyle.Hide, False)
                If ckbMsgbox.Checked = True Then
                    If RBIOK.Checked = True Then
                        MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf RBQYN.Checked = True Then
                        If (MessageBox.Show(Content, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
                        Else
                        End If
                    ElseIf RBWOK.Checked = True Then
                        MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf RBEOK.Checked = True Then
                        MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    End
                Else
                    End
                End If
            End If
        ElseIf RBFile.Checked = True Then
            Do
                SourceFileExists()
                System.Threading.Thread.Sleep(100 * time)
            Loop Until SourceFileExists() = True
            Shell("xcopy.exe " & Source & " " & Destination, AppWinStyle.Hide, False)
            If ckbMsgbox.Checked = True Then
                If RBIOK.Checked = True Then
                    MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf RBQYN.Checked = True Then
                    If (MessageBox.Show(Content, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
                    Else
                    End If
                ElseIf RBWOK.Checked = True Then
                    MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf RBEOK.Checked = True Then
                    MessageBox.Show(Content, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                End
            Else
                End
            End If
        End If
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        TitlePreview.Visible = True
        ContentPreview.Visible = True
        TitlePreview.Text = txtTitle.Text
        ContentPreview.Text = txtContent.Text
        If RBIOK.Checked = True Then
            picEOK.Visible = False
            picIOK.Visible = False
            picWOK.Visible = False
            picQYN.Visible = False
            picIOK.Visible = True
        ElseIf RBQYN.Checked = True Then
            picEOK.Visible = False
            picIOK.Visible = False
            picWOK.Visible = False
            picQYN.Visible = False
            picQYN.Visible = True
        ElseIf RBWOK.Checked = True Then
            picEOK.Visible = False
            picIOK.Visible = False
            picWOK.Visible = False
            picQYN.Visible = False
            picWOK.Visible = True
        ElseIf RBEOK.Checked = True Then
            picEOK.Visible = False
            picIOK.Visible = False
            picWOK.Visible = False
            picQYN.Visible = False
            picEOK.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picEOK.Visible = False
        picIOK.Visible = False
        picWOK.Visible = False
        picQYN.Visible = False
        TitlePreview.Visible = False
        ContentPreview.Visible = False
        ckbHide.Checked = True
        ckbMsgbox.Checked = True
        RBDirectory.Checked = True
        RBQYN.Checked = True
        txtTitle.Enabled = True
        txtContent.Enabled = True
        RBEOK.Enabled = True
        RBIOK.Enabled = True
        RBWOK.Enabled = True
        RBQYN.Enabled = True
        btnPreview.Enabled = True
    End Sub

    Private Sub RBFile_CheckedChanged(sender As Object, e As EventArgs) Handles RBFile.CheckedChanged
        ckbHide.Enabled = Not (ckbHide.Enabled)
    End Sub

    Private Sub RBDirectory_CheckedChanged(sender As Object, e As EventArgs) Handles RBDirectory.CheckedChanged
        ckbHide.Enabled = True
    End Sub

    Private Sub ckbMsgbox_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMsgbox.CheckedChanged
        txtTitle.Enabled = Not (txtTitle.Enabled)
        txtContent.Enabled = Not (txtContent.Enabled)
        RBEOK.Enabled = Not (RBEOK.Enabled)
        RBIOK.Enabled = Not (RBIOK.Enabled)
        RBWOK.Enabled = Not (RBWOK.Enabled)
        RBQYN.Enabled = Not (RBQYN.Enabled)
        btnPreview.Enabled = Not (btnPreview.Enabled)
    End Sub
End Class

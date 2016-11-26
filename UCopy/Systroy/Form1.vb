Public Class frmUCopy

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Function SourceFileExists() As Boolean
        If Not (System.IO.Directory.Exists(txtSource.Text)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Visible = False
        Do
            SourceFileExists()
            System.Threading.Thread.Sleep(500)
        Loop Until SourceFileExists() = True
        Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(txtSource.Text, txtDestination.Text)
        If (MessageBox.Show(txtContent.Text, txtTitle.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class

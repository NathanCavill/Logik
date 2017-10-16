Public Class Form1
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click

        Dim result As Boolean


        If RadioButtonAND.Checked Then
            If CheckBoxA.Checked And CheckBoxB.Checked Then
                result = True
            End If
        End If

        If RadioButtonOR.Checked Then
            If CheckBoxA.Checked Or CheckBoxB.Checked Then
                result = True
            End If
        End If

        If RadioButtonNOT.Checked Then
            If CheckBoxA.Checked Then
                result = False
            Else
                result = True
            End If
        End If

        If RadioButtonXOR.Checked Then
            If CheckBoxA.Checked Then
                result = True
            End If
            If CheckBoxB.Checked Then
                    result = True
                End If

            ElseIf CheckBoxA.Checked And CheckBoxB.Checked Then
                    result = False
                End If




        MessageBox.Show(result)
    End Sub

    Private Sub RadioButtonNOT_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNOT.CheckedChanged
        If RadioButtonNOT.Checked Then
            CheckBoxB.Enabled = False
        Else
            CheckBoxB.Enabled = True
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox1.Show()
    End Sub
End Class

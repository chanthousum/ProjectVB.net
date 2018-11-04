Public Class Sale_FRM
    Dim objfunction As New clsFunction
    Dim objorder As New clsOrder
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        AxShockwaveFlash1.Movie = Application.StartupPath & "\banner.swf"
        txt_barcode.Select()

    End Sub
    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If objfunction.EmptyTextBox(txt_barcode) = True Then Exit Sub
            With objorder
                .AddData()
                .SubTotal()
                .AfterDiscount()
            End With

        End If
    End Sub

    Private Sub txt_cashreciev_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cashreciev.KeyDown
        If e.KeyCode = Keys.Enter Then
            If objfunction.EmptyTextBox(txt_cashreciev) = True Then Exit Sub
            Dim cashrecieve = Convert.ToDouble(txt_cashreciev.Text)
            Dim atferdiscount = Convert.ToDouble(lbl_afterdiscount.Text)
            If cashrecieve > atferdiscount Or cashrecieve = atferdiscount Then
                Dim cashreturn As Double = Convert.ToDouble(txt_cashreciev.Text) - Convert.ToDouble(lbl_afterdiscount.Text)
                lbl_cashreturn.Text = Format(Math.Round(cashreturn, 2), "#0.00")

                ''after save data when order
                If MessageBox.Show("Are you print", "Print", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    With objorder
                        .SaveData()
                    End With
                End If
            End If

        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_discount.KeyDown

        If e.KeyCode = Keys.Enter Then
            If objfunction.EmptyTextBox(txt_discount) = True Then Exit Sub
            objorder.AfterDiscount()

            'Save data into database
        ElseIf e.KeyCode = Keys.F12 Then
            If dg_order.Rows.Count = 0 Then
                Exit Sub
            End If
            If MessageBox.Show("Are you Print", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objorder.SaveData()

            End If
        End If


    End Sub

    Private Sub txt_discount_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class

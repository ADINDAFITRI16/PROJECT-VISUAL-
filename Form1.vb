Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rtbhasil.Text = "Nim" + vbTab + vbTab + ": " + tbnim.Text + vbCrLf &
                        "Nama" + vbTab + vbTab + ": " + tbnama.Text + vbCrLf &
                        "HP" + vbTab + vbTab + ": " + tbhp.Text + vbCrLf &
                        "alamat" + vbTab + vbTab + ": " + tbalamat.Text

        'Gender
        If rblaki.Checked = True Then
            rtbhasil.Text += vbCrLf + "Jenis Kelamin" + vbTab + vbTab + ": " + rblaki.Text
        ElseIf rbc.Checked = True Then
            rtbhasil.Text += vbCrLf + "Jenis Kelamin" + vbTab + vbTab + ": " + rbpr.Text
        End If

        'tempat tanggal lahir
        Dim umur As Integer = Date.Now.Year - dtplahir.Value.Year
        If Date.Now.Month > dtplahir.Value.Month Then
            umur -= 1
        End If

        If Date.Now.Date <> dtplahir.Value.Date And umur >= 1 Then
            rtbhasil.Text += vbCrLf + "tempat tanggal lahir" + vbTab + ": " + tbtmplahir.Text + ", " + dtplahir.Value.ToString("dd MMMM yyyy", New Globalization.CultureInfo("id-ID"))
            rtbhasil.Text += vbCrLf + "umur" + vbTab + vbTab + ": " + umur.ToString + " tahun"
        ElseIf Date.Now.Date <> dtplahir.Value.Date And umur < 1 Then
            rtbhasil.Text += vbCrLf + "tempat tanggal lahir" + vbTab + ": " + tbtmplahir.Text + ", " + dtplahir.Value.ToString("dd MMMM yyyy", New Globalization.CultureInfo("id-ID"))
            rtbhasil.Text += vbCrLf + "umur" + vbTab + vbTab + ": <1 tahun"
        ElseIf Date.Now.Date = dtplahir.Value.Date Then
            MessageBox.Show("tanggal lahir sama dengan tanggal sekarang!", "error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If

        'email
        rtbhasil.Text += vbCrLf + "Email" + vbTab + vbTab + ": " + tbemail.Text

        'pekerjaan
        If cbkerja.SelectedItem IsNot Nothing Then
            Select Case cbkerja.SelectedItem
                Case "lainnya..."
                    rtbhasil.Text += vbCrLf + "Pekerjaan" + vbTab + vbTab + ": " + tbkerja.Text
                Case Else
                    rtbhasil.Text += vbCrLf + "Pekerjaan" + vbTab + vbTab + ": " + cbkerja.SelectedItem.ToString()
            End Select
        End If

        'jurusan
        If cbjurusan.SelectedItem IsNot Nothing Then
            rtbhasil.Text += vbCrLf + "Jurusan" + vbTab + vbTab + ": " + cbjurusan.SelectedItem.ToString
        End If

        'prodi
        If cbprodi.SelectedItem IsNot Nothing Then
            rtbhasil.Text += vbCrLf + "Program Studi" + vbTab + ": " + cbprodi.SelectedItem.ToString
        End If

        'semester
        If cbsmt.SelectedItem IsNot Nothing Then
            rtbhasil.Text += vbCrLf + "semester" + vbTab + vbTab + ": " + cbsmt.SelectedItem.ToString + " - "
            If rba.Checked = True Then
                rtbhasil.Text += rba.Text
            ElseIf rbb.Checked = True Then
                rtbhasil.Text += rbb.Text
            ElseIf rbc.Checked = True Then
                rtbhasil.Text += rbc.Text
            End If
        End If

        'matkul
        If clbMatkul.CheckedItems.Count > 0 Then
            rtbhasil.Text += vbCrLf + "Mata Kuliah" + vbTab + ": "
            For Each chckbox As Object In clbmatkul.CheckedItems
                rtbhasil.Text += chckbox.ToString + ", "
            Next
            rtbhasil.Text = rtbhasil.Text.Trim().Remove(rtbhasil.TextLength - 2)
        End If

        'tahun masuk
        rtbhasil.Text += vbCrLf + "tahun masuk" + vbTab + ": " + dtpmasuk.Value.Date.Year.ToString

        'asal sekolah
        If cbasal.SelectedItem IsNot Nothing Then
            Select Case cbasal.SelectedItem
                Case "lainnya..."
                    rtbhasil.Text += vbCrLf + "riwayat" + vbTab + vbTab + ": " + tbasal.Text
                Case Else
                    rtbhasil.Text += vbCrLf + "Riwayat" + vbTab + vbTab + ": " + cbasal.SelectedItem.ToString()
            End Select
        End If
        'status mahasiswa
        If cbstatus.SelectedItem IsNot Nothing Then
            rtbhasil.Text += vbCrLf + "Status Mahasiswa" + vbTab + ": " + cbstatus.SelectedItem.ToString
        End If

        'alamat kampus
        rtbhasil.Text += vbCrLf + "Alamat kampus" + vbTab + ": " + tbalamatkmps.Text


    End Sub
    Private Sub cbasal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbasal.SelectedIndexChanged, cbkerja.SelectedIndexChanged
        Select Case cbasal.SelectedItem
            Case "Lainnya"
                tbasal.Enabled = True
            Case Else
                tbasal.Enabled = False
        End Select
    End Sub

    'picture box
    Private Sub btopen_Click(sender As Object, e As EventArgs) Handles btopen.Click
        OpenFileDialog1.Filter = "gambar | *.jpg;*jpeg;*.png;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = OpenFileDialog1.FileName
            pbfoto.Image = Image.FromFile(imagePath)
        End If
    End Sub
    Private Sub pbfoto_Click(sender As Object, e As EventArgs) Handles pbfoto.Click
        OpenFileDialog1.Filter = "gambar | *.jpg;*jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = OpenFileDialog1.FileName
            pbfoto.Image = Image.FromFile(imagePath)
        End If
    End Sub
End Class

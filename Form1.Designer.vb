<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Alamat = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbnim = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.rtbhasil = New System.Windows.Forms.TextBox()
        Me.rbc = New System.Windows.Forms.RadioButton()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.HP = New System.Windows.Forms.Label()
        Me.clbmatkul = New System.Windows.Forms.CheckedListBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dtpmasuk = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.pbfoto = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rbpr = New System.Windows.Forms.RadioButton()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.tbalamat = New System.Windows.Forms.TextBox()
        Me.cbsmt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rba = New System.Windows.Forms.RadioButton()
        Me.rbb = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbprodi = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbalamatkmps = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbtmplahir = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbhp = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.btopen = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbasal = New System.Windows.Forms.ComboBox()
        Me.tbasal = New System.Windows.Forms.TextBox()
        Me.cbkerja = New System.Windows.Forms.ComboBox()
        Me.tbkerja = New System.Windows.Forms.TextBox()
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(25, 69)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(27, 13)
        Me.Nama.TabIndex = 0
        Me.Nama.Text = "NIM"
        '
        'Alamat
        '
        Me.Alamat.AutoSize = True
        Me.Alamat.Location = New System.Drawing.Point(25, 94)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(35, 13)
        Me.Alamat.TabIndex = 0
        Me.Alamat.Text = "Nama"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(859, 7)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(151, 52)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Foto Profil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gunakan Pas Foto Resmi 4x6 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Klik Foto/Openfile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Untuk Upload Foto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    ""
        '
        'tbnim
        '
        Me.tbnim.Location = New System.Drawing.Point(92, 66)
        Me.tbnim.Multiline = True
        Me.tbnim.Name = "tbnim"
        Me.tbnim.Size = New System.Drawing.Size(222, 20)
        Me.tbnim.TabIndex = 1
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(91, 92)
        Me.tbnama.Multiline = True
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(224, 21)
        Me.tbnama.TabIndex = 1
        Me.tbnama.Text = " "
        '
        'rtbhasil
        '
        Me.rtbhasil.Location = New System.Drawing.Point(733, 158)
        Me.rtbhasil.Multiline = True
        Me.rtbhasil.Name = "rtbhasil"
        Me.rtbhasil.Size = New System.Drawing.Size(309, 286)
        Me.rtbhasil.TabIndex = 1
        Me.rtbhasil.Text = " "
        '
        'rbc
        '
        Me.rbc.AutoSize = True
        Me.rbc.Location = New System.Drawing.Point(592, 112)
        Me.rbc.Name = "rbc"
        Me.rbc.Size = New System.Drawing.Size(32, 17)
        Me.rbc.TabIndex = 3
        Me.rbc.TabStop = True
        Me.rbc.Text = "C"
        Me.rbc.UseVisualStyleBackColor = True
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(91, 227)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(68, 17)
        Me.rblaki.TabIndex = 3
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki Laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'HP
        '
        Me.HP.AutoSize = True
        Me.HP.Location = New System.Drawing.Point(394, 65)
        Me.HP.Name = "HP"
        Me.HP.Size = New System.Drawing.Size(44, 13)
        Me.HP.TabIndex = 0
        Me.HP.Text = "Jurusan"
        '
        'clbmatkul
        '
        Me.clbmatkul.FormattingEnabled = True
        Me.clbmatkul.Items.AddRange(New Object() {"Algoritma Dasar", "Dasar Pemograman", "Matematika", "Pemograman Android", "Pemograman Game", "Pemograman Web", "Pemograman Database Berbasis Dekstop"})
        Me.clbmatkul.Location = New System.Drawing.Point(466, 135)
        Me.clbmatkul.Name = "clbmatkul"
        Me.clbmatkul.Size = New System.Drawing.Size(223, 109)
        Me.clbmatkul.TabIndex = 5
        '
        'cbjurusan
        '
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Items.AddRange(New Object() {"Fakultas Teknik Informatika", "Fakultas Ekonomi dan Bisnis"})
        Me.cbjurusan.Location = New System.Drawing.Point(465, 58)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(223, 21)
        Me.cbjurusan.TabIndex = 7
        '
        'tbemail
        '
        Me.tbemail.Location = New System.Drawing.Point(90, 320)
        Me.tbemail.Multiline = True
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(226, 22)
        Me.tbemail.TabIndex = 1
        Me.tbemail.Text = " "
        '
        'dtpmasuk
        '
        Me.dtpmasuk.Location = New System.Drawing.Point(465, 259)
        Me.dtpmasuk.Name = "dtpmasuk"
        Me.dtpmasuk.Size = New System.Drawing.Size(226, 20)
        Me.dtpmasuk.TabIndex = 8
        '
        'pbfoto
        '
        Me.pbfoto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pbfoto.Location = New System.Drawing.Point(733, 7)
        Me.pbfoto.Name = "pbfoto"
        Me.pbfoto.Size = New System.Drawing.Size(104, 145)
        Me.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbfoto.TabIndex = 9
        Me.pbfoto.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(945, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 27)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cetak Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(394, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Prodi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(394, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tahun Masuk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(394, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Semester"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 39)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Mata Kuliah" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "yang sudah " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "diambil"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 39)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tempat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tanggal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Lahir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 26)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Alamat " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rumah"
        '
        'rbpr
        '
        Me.rbpr.AutoSize = True
        Me.rbpr.Location = New System.Drawing.Point(165, 227)
        Me.rbpr.Name = "rbpr"
        Me.rbpr.Size = New System.Drawing.Size(79, 17)
        Me.rbpr.TabIndex = 3
        Me.rbpr.TabStop = True
        Me.rbpr.Text = "Perempuan"
        Me.rbpr.UseVisualStyleBackColor = True
        '
        'cbstatus
        '
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cbstatus.Location = New System.Drawing.Point(468, 343)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(223, 21)
        Me.cbstatus.TabIndex = 7
        '
        'dtplahir
        '
        Me.dtplahir.Location = New System.Drawing.Point(91, 287)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(226, 20)
        Me.dtplahir.TabIndex = 8
        '
        'tbalamat
        '
        Me.tbalamat.Location = New System.Drawing.Point(90, 145)
        Me.tbalamat.Multiline = True
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(224, 72)
        Me.tbalamat.TabIndex = 1
        Me.tbalamat.Text = " "
        '
        'cbsmt
        '
        Me.cbsmt.FormattingEnabled = True
        Me.cbsmt.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbsmt.Location = New System.Drawing.Point(465, 108)
        Me.cbsmt.Name = "cbsmt"
        Me.cbsmt.Size = New System.Drawing.Size(41, 21)
        Me.cbsmt.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pribadi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Data Mahasiswa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jenis " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kelamin"
        '
        'rba
        '
        Me.rba.AutoSize = True
        Me.rba.Location = New System.Drawing.Point(521, 112)
        Me.rba.Name = "rba"
        Me.rba.Size = New System.Drawing.Size(32, 17)
        Me.rba.TabIndex = 3
        Me.rba.TabStop = True
        Me.rba.Text = "A"
        Me.rba.UseVisualStyleBackColor = True
        '
        'rbb
        '
        Me.rbb.AutoSize = True
        Me.rbb.Location = New System.Drawing.Point(555, 112)
        Me.rbb.Name = "rbb"
        Me.rbb.Size = New System.Drawing.Size(32, 17)
        Me.rbb.TabIndex = 3
        Me.rbb.TabStop = True
        Me.rbb.Text = "B"
        Me.rbb.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(397, 338)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 26)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mahasiswa"
        '
        'cbprodi
        '
        Me.cbprodi.FormattingEnabled = True
        Me.cbprodi.Items.AddRange(New Object() {"Sistem Teknologi Informasi (STI)", "Sistem Informasi (SI)", "Management", "Hukum Bisnis", "Akuntansi"})
        Me.cbprodi.Location = New System.Drawing.Point(465, 83)
        Me.cbprodi.Name = "cbprodi"
        Me.cbprodi.Size = New System.Drawing.Size(223, 21)
        Me.cbprodi.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(397, 376)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 26)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Alamat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kampus"
        '
        'tbalamatkmps
        '
        Me.tbalamatkmps.Location = New System.Drawing.Point(466, 380)
        Me.tbalamatkmps.Multiline = True
        Me.tbalamatkmps.Name = "tbalamatkmps"
        Me.tbalamatkmps.Size = New System.Drawing.Size(226, 64)
        Me.tbalamatkmps.TabIndex = 1
        Me.tbalamatkmps.Text = " "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 329)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Email"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 357)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Pekerjaan"
        '
        'tbtmplahir
        '
        Me.tbtmplahir.Location = New System.Drawing.Point(90, 259)
        Me.tbtmplahir.Multiline = True
        Me.tbtmplahir.Name = "tbtmplahir"
        Me.tbtmplahir.Size = New System.Drawing.Size(226, 22)
        Me.tbtmplahir.TabIndex = 1
        Me.tbtmplahir.Text = " "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "HP"
        '
        'tbhp
        '
        Me.tbhp.Location = New System.Drawing.Point(90, 117)
        Me.tbhp.Multiline = True
        Me.tbhp.Name = "tbhp"
        Me.tbhp.Size = New System.Drawing.Size(224, 21)
        Me.tbhp.TabIndex = 1
        Me.tbhp.Text = " "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'btopen
        '
        Me.btopen.Location = New System.Drawing.Point(862, 69)
        Me.btopen.Name = "btopen"
        Me.btopen.Size = New System.Drawing.Size(68, 27)
        Me.btopen.TabIndex = 10
        Me.btopen.Text = "Open File"
        Me.btopen.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(394, 289)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Asal Sekolah"
        '
        'cbasal
        '
        Me.cbasal.FormattingEnabled = True
        Me.cbasal.Items.AddRange(New Object() {"Sekolah Menengah akhir (SMA)", "Sekolah Menengah Kejuruan (SMK)", "Madrasah Aliyah Negri (MAN)", "Madrasah Aliyah (MA)", "Lainnya"})
        Me.cbasal.Location = New System.Drawing.Point(469, 289)
        Me.cbasal.Name = "cbasal"
        Me.cbasal.Size = New System.Drawing.Size(223, 21)
        Me.cbasal.TabIndex = 7
        '
        'tbasal
        '
        Me.tbasal.Location = New System.Drawing.Point(469, 312)
        Me.tbasal.Multiline = True
        Me.tbasal.Name = "tbasal"
        Me.tbasal.Size = New System.Drawing.Size(223, 22)
        Me.tbasal.TabIndex = 1
        Me.tbasal.Text = " "
        '
        'cbkerja
        '
        Me.cbkerja.FormattingEnabled = True
        Me.cbkerja.Items.AddRange(New Object() {"Swasta", "Wirausaha", "Belum Bekerja", "Lainnya"})
        Me.cbkerja.Location = New System.Drawing.Point(91, 354)
        Me.cbkerja.Name = "cbkerja"
        Me.cbkerja.Size = New System.Drawing.Size(223, 21)
        Me.cbkerja.TabIndex = 7
        '
        'tbkerja
        '
        Me.tbkerja.Location = New System.Drawing.Point(91, 381)
        Me.tbkerja.Multiline = True
        Me.tbkerja.Name = "tbkerja"
        Me.tbkerja.Size = New System.Drawing.Size(223, 22)
        Me.tbkerja.TabIndex = 1
        Me.tbkerja.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 450)
        Me.Controls.Add(Me.btopen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbfoto)
        Me.Controls.Add(Me.dtplahir)
        Me.Controls.Add(Me.dtpmasuk)
        Me.Controls.Add(Me.cbsmt)
        Me.Controls.Add(Me.cbkerja)
        Me.Controls.Add(Me.cbasal)
        Me.Controls.Add(Me.cbstatus)
        Me.Controls.Add(Me.cbprodi)
        Me.Controls.Add(Me.cbjurusan)
        Me.Controls.Add(Me.clbmatkul)
        Me.Controls.Add(Me.rblaki)
        Me.Controls.Add(Me.rbpr)
        Me.Controls.Add(Me.rbb)
        Me.Controls.Add(Me.rba)
        Me.Controls.Add(Me.rbc)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.rtbhasil)
        Me.Controls.Add(Me.tbalamatkmps)
        Me.Controls.Add(Me.tbkerja)
        Me.Controls.Add(Me.tbasal)
        Me.Controls.Add(Me.tbtmplahir)
        Me.Controls.Add(Me.tbemail)
        Me.Controls.Add(Me.tbhp)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.tbnim)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HP)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nama)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nama As Label
    Friend WithEvents Alamat As Label
    Friend WithEvents label3 As Label
    Friend WithEvents tbnim As TextBox
    Friend WithEvents tbnama As TextBox
    Friend WithEvents rtbhasil As TextBox
    Friend WithEvents rbc As RadioButton
    Friend WithEvents rblaki As RadioButton
    Friend WithEvents HP As Label
    Friend WithEvents clbmatkul As CheckedListBox
    Friend WithEvents cbjurusan As ComboBox
    Friend WithEvents tbemail As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtpmasuk As DateTimePicker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbfoto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents rbpr As RadioButton
    Friend WithEvents cbstatus As ComboBox
    Friend WithEvents dtplahir As DateTimePicker
    Friend WithEvents tbalamat As TextBox
    Friend WithEvents cbsmt As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rba As RadioButton
    Friend WithEvents rbb As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents cbprodi As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbalamatkmps As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbtmplahir As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbhp As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents btopen As Button
    Friend WithEvents tblinkpth As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbasal As ComboBox
    Friend WithEvents tbasal As TextBox
    Friend WithEvents cbkerja As ComboBox
    Friend WithEvents tbkerja As TextBox
End Class

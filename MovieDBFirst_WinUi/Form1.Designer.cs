namespace MovieDBFirst_WinUi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgGenre = new System.Windows.Forms.DataGridView();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.AddGenre = new System.Windows.Forms.Button();
            this.txtAddGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgSaloon = new System.Windows.Forms.DataGridView();
            this.btnDeleteSaloon = new System.Windows.Forms.Button();
            this.btnSaloonDelete = new System.Windows.Forms.Button();
            this.AddSaloon = new System.Windows.Forms.Button();
            this.txtSaloonCap = new System.Windows.Forms.TextBox();
            this.txtSaloonName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgSessions = new System.Windows.Forms.DataGridView();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnSessionDelete = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.txtSessionAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgDirectors = new System.Windows.Forms.DataGridView();
            this.btnDeleteDirector = new System.Windows.Forms.Button();
            this.btnAddDirector = new System.Windows.Forms.Button();
            this.txtDirectorSurname = new System.Windows.Forms.TextBox();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.cmbSaloon = new System.Windows.Forms.ComboBox();
            this.cmbDirectors = new System.Windows.Forms.ComboBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTheaters = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenre)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaloon)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSessions)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirectors)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheaters)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(647, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgGenre);
            this.tabPage1.Controls.Add(this.btnDeleteGenre);
            this.tabPage1.Controls.Add(this.AddGenre);
            this.tabPage1.Controls.Add(this.txtAddGenre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Genre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgGenre
            // 
            this.dgGenre.AllowUserToOrderColumns = true;
            this.dgGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgGenre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGenre.Location = new System.Drawing.Point(26, 85);
            this.dgGenre.Name = "dgGenre";
            this.dgGenre.Size = new System.Drawing.Size(268, 255);
            this.dgGenre.TabIndex = 2;
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(26, 346);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(268, 21);
            this.btnDeleteGenre.TabIndex = 4;
            this.btnDeleteGenre.Text = "Delete Genre";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // AddGenre
            // 
            this.AddGenre.Location = new System.Drawing.Point(93, 55);
            this.AddGenre.Name = "AddGenre";
            this.AddGenre.Size = new System.Drawing.Size(201, 21);
            this.AddGenre.TabIndex = 4;
            this.AddGenre.Text = "Add Genre";
            this.AddGenre.UseVisualStyleBackColor = true;
            this.AddGenre.Click += new System.EventHandler(this.AddGenre_Click);
            // 
            // txtAddGenre
            // 
            this.txtAddGenre.Location = new System.Drawing.Point(93, 28);
            this.txtAddGenre.Name = "txtAddGenre";
            this.txtAddGenre.Size = new System.Drawing.Size(201, 21);
            this.txtAddGenre.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add Genre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgSaloon);
            this.tabPage2.Controls.Add(this.btnDeleteSaloon);
            this.tabPage2.Controls.Add(this.btnSaloonDelete);
            this.tabPage2.Controls.Add(this.AddSaloon);
            this.tabPage2.Controls.Add(this.txtSaloonCap);
            this.tabPage2.Controls.Add(this.txtSaloonName);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Saloon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgSaloon
            // 
            this.dgSaloon.AllowUserToOrderColumns = true;
            this.dgSaloon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgSaloon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgSaloon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSaloon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaloon.Location = new System.Drawing.Point(25, 113);
            this.dgSaloon.Name = "dgSaloon";
            this.dgSaloon.Size = new System.Drawing.Size(268, 228);
            this.dgSaloon.TabIndex = 8;
            // 
            // btnDeleteSaloon
            // 
            this.btnDeleteSaloon.Location = new System.Drawing.Point(25, 384);
            this.btnDeleteSaloon.Name = "btnDeleteSaloon";
            this.btnDeleteSaloon.Size = new System.Drawing.Size(268, 21);
            this.btnDeleteSaloon.TabIndex = 7;
            this.btnDeleteSaloon.Text = "Delete Saloon";
            this.btnDeleteSaloon.UseVisualStyleBackColor = true;
            // 
            // btnSaloonDelete
            // 
            this.btnSaloonDelete.Location = new System.Drawing.Point(25, 347);
            this.btnSaloonDelete.Name = "btnSaloonDelete";
            this.btnSaloonDelete.Size = new System.Drawing.Size(268, 21);
            this.btnSaloonDelete.TabIndex = 7;
            this.btnSaloonDelete.Text = "Delete Saloon";
            this.btnSaloonDelete.UseVisualStyleBackColor = true;
            this.btnSaloonDelete.Click += new System.EventHandler(this.btnSaloonDelete_Click);
            // 
            // AddSaloon
            // 
            this.AddSaloon.Location = new System.Drawing.Point(94, 84);
            this.AddSaloon.Name = "AddSaloon";
            this.AddSaloon.Size = new System.Drawing.Size(199, 21);
            this.AddSaloon.TabIndex = 7;
            this.AddSaloon.Text = "Add Saloon";
            this.AddSaloon.UseVisualStyleBackColor = true;
            this.AddSaloon.Click += new System.EventHandler(this.AddSaloon_Click);
            // 
            // txtSaloonCap
            // 
            this.txtSaloonCap.Location = new System.Drawing.Point(94, 57);
            this.txtSaloonCap.Name = "txtSaloonCap";
            this.txtSaloonCap.Size = new System.Drawing.Size(199, 21);
            this.txtSaloonCap.TabIndex = 6;
            // 
            // txtSaloonName
            // 
            this.txtSaloonName.Location = new System.Drawing.Point(94, 30);
            this.txtSaloonName.Name = "txtSaloonName";
            this.txtSaloonName.Size = new System.Drawing.Size(199, 21);
            this.txtSaloonName.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Capacity";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saloon Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgSessions);
            this.tabPage3.Controls.Add(this.btnDeleteSession);
            this.tabPage3.Controls.Add(this.btnSessionDelete);
            this.tabPage3.Controls.Add(this.btnAddSession);
            this.tabPage3.Controls.Add(this.txtSessionAdd);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(313, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Sessions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgSessions
            // 
            this.dgSessions.AllowUserToOrderColumns = true;
            this.dgSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgSessions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSessions.Location = new System.Drawing.Point(26, 77);
            this.dgSessions.Name = "dgSessions";
            this.dgSessions.Size = new System.Drawing.Size(268, 267);
            this.dgSessions.TabIndex = 11;
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Location = new System.Drawing.Point(26, 384);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(268, 21);
            this.btnDeleteSession.TabIndex = 10;
            this.btnDeleteSession.Text = "Delete Session";
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            // 
            // btnSessionDelete
            // 
            this.btnSessionDelete.Location = new System.Drawing.Point(26, 350);
            this.btnSessionDelete.Name = "btnSessionDelete";
            this.btnSessionDelete.Size = new System.Drawing.Size(268, 21);
            this.btnSessionDelete.TabIndex = 10;
            this.btnSessionDelete.Text = "Delete Session";
            this.btnSessionDelete.UseVisualStyleBackColor = true;
            this.btnSessionDelete.Click += new System.EventHandler(this.btnSessionDelete_Click);
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(94, 50);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(200, 21);
            this.btnAddSession.TabIndex = 10;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // txtSessionAdd
            // 
            this.txtSessionAdd.Location = new System.Drawing.Point(94, 23);
            this.txtSessionAdd.Name = "txtSessionAdd";
            this.txtSessionAdd.Size = new System.Drawing.Size(200, 21);
            this.txtSessionAdd.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Add Session";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgDirectors);
            this.tabPage4.Controls.Add(this.btnDeleteDirector);
            this.tabPage4.Controls.Add(this.btnAddDirector);
            this.tabPage4.Controls.Add(this.txtDirectorSurname);
            this.tabPage4.Controls.Add(this.txtDirectorName);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(313, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Director";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgDirectors
            // 
            this.dgDirectors.AllowUserToOrderColumns = true;
            this.dgDirectors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgDirectors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgDirectors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDirectors.Location = new System.Drawing.Point(22, 119);
            this.dgDirectors.Name = "dgDirectors";
            this.dgDirectors.Size = new System.Drawing.Size(268, 221);
            this.dgDirectors.TabIndex = 6;
            // 
            // btnDeleteDirector
            // 
            this.btnDeleteDirector.Location = new System.Drawing.Point(22, 346);
            this.btnDeleteDirector.Name = "btnDeleteDirector";
            this.btnDeleteDirector.Size = new System.Drawing.Size(268, 21);
            this.btnDeleteDirector.TabIndex = 8;
            this.btnDeleteDirector.Text = "Delete Director";
            this.btnDeleteDirector.UseVisualStyleBackColor = true;
            this.btnDeleteDirector.Click += new System.EventHandler(this.btnDeleteDirector_Click);
            // 
            // btnAddDirector
            // 
            this.btnAddDirector.Location = new System.Drawing.Point(22, 89);
            this.btnAddDirector.Name = "btnAddDirector";
            this.btnAddDirector.Size = new System.Drawing.Size(268, 24);
            this.btnAddDirector.TabIndex = 9;
            this.btnAddDirector.Text = "Add Director";
            this.btnAddDirector.UseVisualStyleBackColor = true;
            this.btnAddDirector.Click += new System.EventHandler(this.btnAddDirector_Click);
            // 
            // txtDirectorSurname
            // 
            this.txtDirectorSurname.Location = new System.Drawing.Point(89, 56);
            this.txtDirectorSurname.Name = "txtDirectorSurname";
            this.txtDirectorSurname.Size = new System.Drawing.Size(201, 21);
            this.txtDirectorSurname.TabIndex = 7;
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Location = new System.Drawing.Point(89, 29);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(201, 21);
            this.txtDirectorName.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(-4, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Surname";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(-4, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Director Name";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddMovie);
            this.groupBox1.Controls.Add(this.txtDuration);
            this.groupBox1.Controls.Add(this.txtMovieName);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.cmbSession);
            this.groupBox1.Controls.Add(this.cmbSaloon);
            this.groupBox1.Controls.Add(this.cmbDirectors);
            this.groupBox1.Controls.Add(this.cmbGenre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Movies";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(414, 336);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(129, 26);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(103, 135);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(206, 20);
            this.txtDuration.TabIndex = 3;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(103, 26);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(440, 20);
            this.txtMovieName.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(103, 58);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(1);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(440, 63);
            this.txtDescription.TabIndex = 2;
            // 
            // cmbSession
            // 
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(103, 280);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(206, 21);
            this.cmbSession.TabIndex = 1;
            // 
            // cmbSaloon
            // 
            this.cmbSaloon.FormattingEnabled = true;
            this.cmbSaloon.Location = new System.Drawing.Point(103, 246);
            this.cmbSaloon.Name = "cmbSaloon";
            this.cmbSaloon.Size = new System.Drawing.Size(206, 21);
            this.cmbSaloon.TabIndex = 1;
            // 
            // cmbDirectors
            // 
            this.cmbDirectors.FormattingEnabled = true;
            this.cmbDirectors.Location = new System.Drawing.Point(103, 175);
            this.cmbDirectors.Name = "cmbDirectors";
            this.cmbDirectors.Size = new System.Drawing.Size(206, 21);
            this.cmbDirectors.TabIndex = 1;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(103, 211);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(206, 21);
            this.cmbGenre.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Select Session";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Select Saloon";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Select Director";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Duration";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Genre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgTheaters
            // 
            this.dgTheaters.AllowUserToOrderColumns = true;
            this.dgTheaters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgTheaters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgTheaters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTheaters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTheaters.Location = new System.Drawing.Point(51, 493);
            this.dgTheaters.Name = "dgTheaters";
            this.dgTheaters.Size = new System.Drawing.Size(913, 189);
            this.dgTheaters.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(866, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 711);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgTheaters);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenre)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaloon)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSessions)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirectors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheaters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgGenre;
        private System.Windows.Forms.Button AddGenre;
        private System.Windows.Forms.TextBox txtAddGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddSaloon;
        private System.Windows.Forms.TextBox txtSaloonName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.TextBox txtSessionAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaloonCap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.ComboBox cmbSaloon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgSaloon;
        private System.Windows.Forms.DataGridView dgSessions;
        private System.Windows.Forms.DataGridView dgTheaters;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgDirectors;
        private System.Windows.Forms.Button btnDeleteDirector;
        private System.Windows.Forms.Button btnAddDirector;
        private System.Windows.Forms.TextBox txtDirectorSurname;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDirectors;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeleteSaloon;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Button btnSaloonDelete;
        private System.Windows.Forms.Button btnSessionDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExit;
    }
}


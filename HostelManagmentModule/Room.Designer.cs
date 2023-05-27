namespace HostelManagmentModule
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomList = new System.Windows.Forms.DataGridView();
            this.RoomNumBtn = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomStatusBtn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomYesRadBtn = new System.Windows.Forms.RadioButton();
            this.RoomNoRadBtn = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 53);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(984, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Jpan", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(286, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROOM INFORMATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 23);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Jpan", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(625, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "ROOM LIST";
            // 
            // RoomList
            // 
            this.RoomList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomList.Location = new System.Drawing.Point(534, 126);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(366, 405);
            this.RoomList.TabIndex = 4;
            this.RoomList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RoomNumBtn
            // 
            this.RoomNumBtn.AcceptsReturn = false;
            this.RoomNumBtn.AcceptsTab = false;
            this.RoomNumBtn.AnimationSpeed = 200;
            this.RoomNumBtn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RoomNumBtn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RoomNumBtn.BackColor = System.Drawing.Color.Transparent;
            this.RoomNumBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RoomNumBtn.BackgroundImage")));
            this.RoomNumBtn.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.RoomNumBtn.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RoomNumBtn.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RoomNumBtn.BorderColorIdle = System.Drawing.Color.Navy;
            this.RoomNumBtn.BorderRadius = 1;
            this.RoomNumBtn.BorderThickness = 3;
            this.RoomNumBtn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RoomNumBtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNumBtn.DefaultFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumBtn.DefaultText = "";
            this.RoomNumBtn.FillColor = System.Drawing.Color.White;
            this.RoomNumBtn.HideSelection = true;
            this.RoomNumBtn.IconLeft = null;
            this.RoomNumBtn.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNumBtn.IconPadding = 10;
            this.RoomNumBtn.IconRight = null;
            this.RoomNumBtn.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNumBtn.Lines = new string[0];
            this.RoomNumBtn.Location = new System.Drawing.Point(85, 159);
            this.RoomNumBtn.MaxLength = 32767;
            this.RoomNumBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.RoomNumBtn.Modified = false;
            this.RoomNumBtn.Multiline = false;
            this.RoomNumBtn.Name = "RoomNumBtn";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RoomNumBtn.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.RoomNumBtn.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RoomNumBtn.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Navy;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RoomNumBtn.OnIdleState = stateProperties12;
            this.RoomNumBtn.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.RoomNumBtn.PasswordChar = '\0';
            this.RoomNumBtn.PlaceholderForeColor = System.Drawing.Color.Navy;
            this.RoomNumBtn.PlaceholderText = "RoomNumber";
            this.RoomNumBtn.ReadOnly = false;
            this.RoomNumBtn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RoomNumBtn.SelectedText = "";
            this.RoomNumBtn.SelectionLength = 0;
            this.RoomNumBtn.SelectionStart = 0;
            this.RoomNumBtn.ShortcutsEnabled = true;
            this.RoomNumBtn.Size = new System.Drawing.Size(196, 39);
            this.RoomNumBtn.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.RoomNumBtn.TabIndex = 5;
            this.RoomNumBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RoomNumBtn.TextMarginBottom = 0;
            this.RoomNumBtn.TextMarginLeft = 3;
            this.RoomNumBtn.TextMarginTop = 0;
            this.RoomNumBtn.TextPlaceholder = "RoomNumber";
            this.RoomNumBtn.UseSystemPasswordChar = false;
            this.RoomNumBtn.WordWrap = true;
            this.RoomNumBtn.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(82, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ROOM STATUS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RoomStatusBtn
            // 
            this.RoomStatusBtn.FormattingEnabled = true;
            this.RoomStatusBtn.Items.AddRange(new object[] {
            "Active",
            "NotActive"});
            this.RoomStatusBtn.Location = new System.Drawing.Point(175, 218);
            this.RoomStatusBtn.Name = "RoomStatusBtn";
            this.RoomStatusBtn.Size = new System.Drawing.Size(105, 21);
            this.RoomStatusBtn.TabIndex = 7;
            this.RoomStatusBtn.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(82, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "BOOKED";
            // 
            // RoomYesRadBtn
            // 
            this.RoomYesRadBtn.AutoSize = true;
            this.RoomYesRadBtn.Checked = true;
            this.RoomYesRadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomYesRadBtn.ForeColor = System.Drawing.Color.Navy;
            this.RoomYesRadBtn.Location = new System.Drawing.Point(175, 257);
            this.RoomYesRadBtn.Name = "RoomYesRadBtn";
            this.RoomYesRadBtn.Size = new System.Drawing.Size(46, 17);
            this.RoomYesRadBtn.TabIndex = 10;
            this.RoomYesRadBtn.TabStop = true;
            this.RoomYesRadBtn.Text = "Yes";
            this.RoomYesRadBtn.UseVisualStyleBackColor = true;
            // 
            // RoomNoRadBtn
            // 
            this.RoomNoRadBtn.AutoSize = true;
            this.RoomNoRadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoRadBtn.ForeColor = System.Drawing.Color.Navy;
            this.RoomNoRadBtn.Location = new System.Drawing.Point(235, 257);
            this.RoomNoRadBtn.Name = "RoomNoRadBtn";
            this.RoomNoRadBtn.Size = new System.Drawing.Size(41, 17);
            this.RoomNoRadBtn.TabIndex = 11;
            this.RoomNoRadBtn.Text = "No";
            this.RoomNoRadBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 544);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 31);
            this.panel3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified Jpan", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(299, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(464, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "BY 19K-1484 19K-1446 19K-0247";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(85, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(192, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(306, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(28, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(867, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 575);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.RoomNoRadBtn);
            this.Controls.Add(this.RoomYesRadBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoomStatusBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoomNumBtn);
            this.Controls.Add(this.RoomList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RoomList;
        private Bunifu.UI.WinForms.BunifuTextBox RoomNumBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RoomStatusBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RoomYesRadBtn;
        private System.Windows.Forms.RadioButton RoomNoRadBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
    }
}
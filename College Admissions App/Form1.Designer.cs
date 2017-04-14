namespace College_Admissions_App
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.programComboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.GEDradioButton = new System.Windows.Forms.RadioButton();
            this.HSradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PhDradioButton = new System.Windows.Forms.RadioButton();
            this.MASradioButton = new System.Windows.Forms.RadioButton();
            this.BAradioButton = new System.Windows.Forms.RadioButton();
            this.CollegeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LRradioButton = new System.Windows.Forms.RadioButton();
            this.FBradioButton = new System.Windows.Forms.RadioButton();
            this.WEradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ACTtextBox = new System.Windows.Forms.TextBox();
            this.SATtextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ACTcheckBox = new System.Windows.Forms.CheckBox();
            this.SATcheckBox = new System.Windows.Forms.CheckBox();
            this.processButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(33, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome to the National University program admissions requirements form.  Please " +
    "select your desired program of study.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(33, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 19);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Choose a Program:";
            // 
            // programComboBox
            // 
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Items.AddRange(new object[] {
            "Computer Science",
            "Business Administration",
            "Liberal Arts",
            "Counseling Psychology"});
            this.programComboBox.Location = new System.Drawing.Point(244, 83);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(224, 28);
            this.programComboBox.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(33, 129);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(530, 63);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Please indicate your qualifications below.  Once finished, please click \"Process\"" +
    " and a recommendation will be made based on the criteria selected.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoneRadioButton);
            this.groupBox1.Controls.Add(this.GEDradioButton);
            this.groupBox1.Controls.Add(this.HSradioButton);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-College Education (Required)";
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoneRadioButton.Location = new System.Drawing.Point(20, 95);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(70, 22);
            this.NoneRadioButton.TabIndex = 12;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "None";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // GEDradioButton
            // 
            this.GEDradioButton.AutoSize = true;
            this.GEDradioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEDradioButton.Location = new System.Drawing.Point(20, 66);
            this.GEDradioButton.Name = "GEDradioButton";
            this.GEDradioButton.Size = new System.Drawing.Size(68, 22);
            this.GEDradioButton.TabIndex = 11;
            this.GEDradioButton.TabStop = true;
            this.GEDradioButton.Text = "GED";
            this.GEDradioButton.UseVisualStyleBackColor = true;
            // 
            // HSradioButton
            // 
            this.HSradioButton.AutoSize = true;
            this.HSradioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSradioButton.Location = new System.Drawing.Point(20, 34);
            this.HSradioButton.Name = "HSradioButton";
            this.HSradioButton.Size = new System.Drawing.Size(180, 22);
            this.HSradioButton.TabIndex = 10;
            this.HSradioButton.TabStop = true;
            this.HSradioButton.Text = "High School Diploma";
            this.HSradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PhDradioButton);
            this.groupBox2.Controls.Add(this.MASradioButton);
            this.groupBox2.Controls.Add(this.BAradioButton);
            this.groupBox2.Controls.Add(this.CollegeRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "College Education (Highest Completed)";
            // 
            // PhDradioButton
            // 
            this.PhDradioButton.AutoSize = true;
            this.PhDradioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhDradioButton.Location = new System.Drawing.Point(20, 121);
            this.PhDradioButton.Name = "PhDradioButton";
            this.PhDradioButton.Size = new System.Drawing.Size(102, 22);
            this.PhDradioButton.TabIndex = 16;
            this.PhDradioButton.TabStop = true;
            this.PhDradioButton.Text = "Doctorate";
            this.PhDradioButton.UseVisualStyleBackColor = true;
            // 
            // MASradioButton
            // 
            this.MASradioButton.AutoSize = true;
            this.MASradioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MASradioButton.Location = new System.Drawing.Point(20, 93);
            this.MASradioButton.Name = "MASradioButton";
            this.MASradioButton.Size = new System.Drawing.Size(92, 22);
            this.MASradioButton.TabIndex = 15;
            this.MASradioButton.TabStop = true;
            this.MASradioButton.Text = "Master\'s";
            this.MASradioButton.UseVisualStyleBackColor = true;
            // 
            // BAradioButton
            // 
            this.BAradioButton.AutoSize = true;
            this.BAradioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAradioButton.Location = new System.Drawing.Point(20, 65);
            this.BAradioButton.Name = "BAradioButton";
            this.BAradioButton.Size = new System.Drawing.Size(106, 22);
            this.BAradioButton.TabIndex = 14;
            this.BAradioButton.TabStop = true;
            this.BAradioButton.Text = "Bachelor\'s";
            this.BAradioButton.UseVisualStyleBackColor = true;
            // 
            // CollegeRadioButton
            // 
            this.CollegeRadioButton.AutoSize = true;
            this.CollegeRadioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollegeRadioButton.Location = new System.Drawing.Point(20, 37);
            this.CollegeRadioButton.Name = "CollegeRadioButton";
            this.CollegeRadioButton.Size = new System.Drawing.Size(292, 22);
            this.CollegeRadioButton.TabIndex = 13;
            this.CollegeRadioButton.TabStop = true;
            this.CollegeRadioButton.Text = "Attended College (degree unfinished)";
            this.CollegeRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LRradioButton);
            this.groupBox3.Controls.Add(this.FBradioButton);
            this.groupBox3.Controls.Add(this.WEradioButton);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(33, 544);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 131);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Experience";
            // 
            // LRradioButton
            // 
            this.LRradioButton.AutoSize = true;
            this.LRradioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRradioButton.Location = new System.Drawing.Point(20, 87);
            this.LRradioButton.Name = "LRradioButton";
            this.LRradioButton.Size = new System.Drawing.Size(179, 22);
            this.LRradioButton.TabIndex = 15;
            this.LRradioButton.TabStop = true;
            this.LRradioButton.Text = "Laboratory Research";
            this.LRradioButton.UseVisualStyleBackColor = true;
            // 
            // FBradioButton
            // 
            this.FBradioButton.AutoSize = true;
            this.FBradioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBradioButton.Location = new System.Drawing.Point(20, 59);
            this.FBradioButton.Name = "FBradioButton";
            this.FBradioButton.Size = new System.Drawing.Size(147, 22);
            this.FBradioButton.TabIndex = 14;
            this.FBradioButton.TabStop = true;
            this.FBradioButton.Text = "Family Business";
            this.FBradioButton.UseVisualStyleBackColor = true;
            // 
            // WEradioButton
            // 
            this.WEradioButton.AutoSize = true;
            this.WEradioButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WEradioButton.Location = new System.Drawing.Point(20, 31);
            this.WEradioButton.Name = "WEradioButton";
            this.WEradioButton.Size = new System.Drawing.Size(225, 22);
            this.WEradioButton.TabIndex = 13;
            this.WEradioButton.TabStop = true;
            this.WEradioButton.Text = "Work Experience in Industry";
            this.WEradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ACTtextBox);
            this.groupBox4.Controls.Add(this.SATtextBox);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.ACTcheckBox);
            this.groupBox4.Controls.Add(this.SATcheckBox);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(419, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 214);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tests";
            // 
            // ACTtextBox
            // 
            this.ACTtextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ACTtextBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACTtextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ACTtextBox.Location = new System.Drawing.Point(71, 160);
            this.ACTtextBox.Name = "ACTtextBox";
            this.ACTtextBox.Size = new System.Drawing.Size(73, 26);
            this.ACTtextBox.TabIndex = 15;
            this.ACTtextBox.TextChanged += new System.EventHandler(this.ACTtextBox_TextChanged);
            // 
            // SATtextBox
            // 
            this.SATtextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SATtextBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SATtextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SATtextBox.Location = new System.Drawing.Point(71, 65);
            this.SATtextBox.Name = "SATtextBox";
            this.SATtextBox.Size = new System.Drawing.Size(73, 26);
            this.SATtextBox.TabIndex = 10;
            this.SATtextBox.TextChanged += new System.EventHandler(this.SATtextBox_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(17, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 19);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Score:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(17, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 19);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Score:";
            // 
            // ACTcheckBox
            // 
            this.ACTcheckBox.AutoSize = true;
            this.ACTcheckBox.Location = new System.Drawing.Point(17, 126);
            this.ACTcheckBox.Name = "ACTcheckBox";
            this.ACTcheckBox.Size = new System.Drawing.Size(68, 23);
            this.ACTcheckBox.TabIndex = 12;
            this.ACTcheckBox.Text = "ACT";
            this.ACTcheckBox.UseVisualStyleBackColor = true;
            // 
            // SATcheckBox
            // 
            this.SATcheckBox.AutoSize = true;
            this.SATcheckBox.Location = new System.Drawing.Point(17, 34);
            this.SATcheckBox.Name = "SATcheckBox";
            this.SATcheckBox.Size = new System.Drawing.Size(66, 23);
            this.SATcheckBox.TabIndex = 10;
            this.SATcheckBox.Text = "SAT";
            this.SATcheckBox.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(441, 475);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(122, 39);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(441, 544);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 39);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(441, 613);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 39);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 691);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.programComboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Admission Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox programComboBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NoneRadioButton;
        private System.Windows.Forms.RadioButton GEDradioButton;
        private System.Windows.Forms.RadioButton HSradioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox ACTcheckBox;
        private System.Windows.Forms.CheckBox SATcheckBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton PhDradioButton;
        private System.Windows.Forms.RadioButton MASradioButton;
        private System.Windows.Forms.RadioButton BAradioButton;
        private System.Windows.Forms.RadioButton CollegeRadioButton;
        private System.Windows.Forms.RadioButton LRradioButton;
        private System.Windows.Forms.RadioButton FBradioButton;
        private System.Windows.Forms.RadioButton WEradioButton;
        private System.Windows.Forms.TextBox ACTtextBox;
        private System.Windows.Forms.TextBox SATtextBox;
    }
}


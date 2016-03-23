namespace RPG
{
    partial class ADGP125
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADGP125));
            this.button1 = new System.Windows.Forms.Button();
            this.BattleBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PartyBox = new System.Windows.Forms.PictureBox();
            this.EnemyBox = new System.Windows.Forms.PictureBox();
            this.EnemyHPBar = new System.Windows.Forms.ProgressBar();
            this.PartyHPBar = new System.Windows.Forms.ProgressBar();
            this.Run = new System.Windows.Forms.Button();
            this.EName = new System.Windows.Forms.Label();
            this.EStatus = new System.Windows.Forms.Label();
            this.EnemyHPNumb = new System.Windows.Forms.Label();
            this.HPNumb = new System.Windows.Forms.Label();
            this.StatusLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.EXPBar = new System.Windows.Forms.ProgressBar();
            this.LevelLable = new System.Windows.Forms.Label();
            this.ELevelLable = new System.Windows.Forms.Label();
            this.AttackLable = new System.Windows.Forms.Label();
            this.DefenceLable = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Button();
            this.AttackO1 = new System.Windows.Forms.Button();
            this.AttackO3 = new System.Windows.Forms.Button();
            this.AttackO2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Battle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BattleBox
            // 
            this.BattleBox.Location = new System.Drawing.Point(352, 12);
            this.BattleBox.Name = "BattleBox";
            this.BattleBox.Size = new System.Drawing.Size(244, 251);
            this.BattleBox.TabIndex = 1;
            this.BattleBox.Text = "";
            this.BattleBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(918, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PartyBox
            // 
            this.PartyBox.Location = new System.Drawing.Point(13, 13);
            this.PartyBox.Name = "PartyBox";
            this.PartyBox.Size = new System.Drawing.Size(304, 250);
            this.PartyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PartyBox.TabIndex = 4;
            this.PartyBox.TabStop = false;
            this.PartyBox.Click += new System.EventHandler(this.PartyBox_Click);
            // 
            // EnemyBox
            // 
            this.EnemyBox.Location = new System.Drawing.Point(629, 12);
            this.EnemyBox.Name = "EnemyBox";
            this.EnemyBox.Size = new System.Drawing.Size(273, 251);
            this.EnemyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EnemyBox.TabIndex = 5;
            this.EnemyBox.TabStop = false;
            this.EnemyBox.Click += new System.EventHandler(this.EnemyBox_Click);
            // 
            // EnemyHPBar
            // 
            this.EnemyHPBar.Location = new System.Drawing.Point(629, 270);
            this.EnemyHPBar.Name = "EnemyHPBar";
            this.EnemyHPBar.Size = new System.Drawing.Size(273, 23);
            this.EnemyHPBar.TabIndex = 6;
            this.EnemyHPBar.Click += new System.EventHandler(this.EnemyHPBar_Click);
            // 
            // PartyHPBar
            // 
            this.PartyHPBar.Location = new System.Drawing.Point(13, 270);
            this.PartyHPBar.Name = "PartyHPBar";
            this.PartyHPBar.Size = new System.Drawing.Size(304, 23);
            this.PartyHPBar.TabIndex = 7;
            this.PartyHPBar.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(918, 245);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(110, 48);
            this.Run.TabIndex = 8;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.Location = new System.Drawing.Point(629, 300);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(42, 13);
            this.EName.TabIndex = 9;
            this.EName.Text = "EName";
            this.EName.Click += new System.EventHandler(this.EName_Click);
            // 
            // EStatus
            // 
            this.EStatus.AutoSize = true;
            this.EStatus.Location = new System.Drawing.Point(858, 300);
            this.EStatus.Name = "EStatus";
            this.EStatus.Size = new System.Drawing.Size(44, 13);
            this.EStatus.TabIndex = 10;
            this.EStatus.Text = "EStatus";
            this.EStatus.Click += new System.EventHandler(this.EStatus_Click);
            // 
            // EnemyHPNumb
            // 
            this.EnemyHPNumb.AutoSize = true;
            this.EnemyHPNumb.Location = new System.Drawing.Point(725, 300);
            this.EnemyHPNumb.Name = "EnemyHPNumb";
            this.EnemyHPNumb.Size = new System.Drawing.Size(82, 13);
            this.EnemyHPNumb.TabIndex = 11;
            this.EnemyHPNumb.Text = "EnemyHPNumb";
            this.EnemyHPNumb.Click += new System.EventHandler(this.EnemyHPNumb_Click);
            // 
            // HPNumb
            // 
            this.HPNumb.AutoSize = true;
            this.HPNumb.Location = new System.Drawing.Point(119, 326);
            this.HPNumb.Name = "HPNumb";
            this.HPNumb.Size = new System.Drawing.Size(50, 13);
            this.HPNumb.TabIndex = 14;
            this.HPNumb.Text = "HPNumb";
            this.HPNumb.Click += new System.EventHandler(this.HPNumb_Click);
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.Location = new System.Drawing.Point(244, 326);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(63, 13);
            this.StatusLable.TabIndex = 13;
            this.StatusLable.Text = "StatusLable";
            this.StatusLable.Click += new System.EventHandler(this.StatusLable_Click);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(15, 326);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(61, 13);
            this.NameLable.TabIndex = 12;
            this.NameLable.Text = "NameLable";
            this.NameLable.Click += new System.EventHandler(this.NameLable_Click);
            // 
            // EXPBar
            // 
            this.EXPBar.Location = new System.Drawing.Point(13, 300);
            this.EXPBar.Name = "EXPBar";
            this.EXPBar.Size = new System.Drawing.Size(304, 13);
            this.EXPBar.TabIndex = 15;
            this.EXPBar.Click += new System.EventHandler(this.EXPBar_Click);
            // 
            // LevelLable
            // 
            this.LevelLable.AutoSize = true;
            this.LevelLable.Location = new System.Drawing.Point(15, 348);
            this.LevelLable.Name = "LevelLable";
            this.LevelLable.Size = new System.Drawing.Size(59, 13);
            this.LevelLable.TabIndex = 16;
            this.LevelLable.Text = "LevelLable";
            this.LevelLable.Click += new System.EventHandler(this.LevelLable_Click);
            // 
            // ELevelLable
            // 
            this.ELevelLable.AutoSize = true;
            this.ELevelLable.Location = new System.Drawing.Point(629, 326);
            this.ELevelLable.Name = "ELevelLable";
            this.ELevelLable.Size = new System.Drawing.Size(66, 13);
            this.ELevelLable.TabIndex = 17;
            this.ELevelLable.Text = "ELevelLable";
            this.ELevelLable.Click += new System.EventHandler(this.ELevelLable_Click);
            // 
            // AttackLable
            // 
            this.AttackLable.AutoSize = true;
            this.AttackLable.Location = new System.Drawing.Point(243, 348);
            this.AttackLable.Name = "AttackLable";
            this.AttackLable.Size = new System.Drawing.Size(64, 13);
            this.AttackLable.TabIndex = 18;
            this.AttackLable.Text = "AttackLable";
            this.AttackLable.Click += new System.EventHandler(this.AttackLable_Click);
            // 
            // DefenceLable
            // 
            this.DefenceLable.AutoSize = true;
            this.DefenceLable.Location = new System.Drawing.Point(233, 370);
            this.DefenceLable.Name = "DefenceLable";
            this.DefenceLable.Size = new System.Drawing.Size(74, 13);
            this.DefenceLable.TabIndex = 19;
            this.DefenceLable.Text = "DefenceLable";
            this.DefenceLable.Click += new System.EventHandler(this.DefenceLable_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(919, 300);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(109, 83);
            this.Pause.TabIndex = 20;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // AttackO1
            // 
            this.AttackO1.Location = new System.Drawing.Point(106, 348);
            this.AttackO1.Name = "AttackO1";
            this.AttackO1.Size = new System.Drawing.Size(75, 23);
            this.AttackO1.TabIndex = 21;
            this.AttackO1.Text = "AttackO1";
            this.AttackO1.UseVisualStyleBackColor = true;
            this.AttackO1.Click += new System.EventHandler(this.AttackO1_Click);
            // 
            // AttackO3
            // 
            this.AttackO3.Location = new System.Drawing.Point(106, 406);
            this.AttackO3.Name = "AttackO3";
            this.AttackO3.Size = new System.Drawing.Size(75, 23);
            this.AttackO3.TabIndex = 22;
            this.AttackO3.Text = "AttackO3";
            this.AttackO3.UseVisualStyleBackColor = true;
            this.AttackO3.Click += new System.EventHandler(this.AttackO3_Click);
            // 
            // AttackO2
            // 
            this.AttackO2.Location = new System.Drawing.Point(106, 377);
            this.AttackO2.Name = "AttackO2";
            this.AttackO2.Size = new System.Drawing.Size(75, 23);
            this.AttackO2.TabIndex = 23;
            this.AttackO2.Text = "AttackO2";
            this.AttackO2.UseVisualStyleBackColor = true;
            this.AttackO2.Click += new System.EventHandler(this.AttackO2_Click);
            // 
            // ADGP125
            // 
            this.ClientSize = new System.Drawing.Size(1040, 545);
            this.Controls.Add(this.AttackO2);
            this.Controls.Add(this.AttackO3);
            this.Controls.Add(this.AttackO1);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.DefenceLable);
            this.Controls.Add(this.AttackLable);
            this.Controls.Add(this.ELevelLable);
            this.Controls.Add(this.LevelLable);
            this.Controls.Add(this.EXPBar);
            this.Controls.Add(this.HPNumb);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.EnemyHPNumb);
            this.Controls.Add(this.EStatus);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.PartyHPBar);
            this.Controls.Add(this.EnemyHPBar);
            this.Controls.Add(this.EnemyBox);
            this.Controls.Add(this.PartyBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BattleBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADGP125";
            this.Text = "ADGP125";
            ((System.ComponentModel.ISupportInitialize)(this.PartyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBattle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox BattleBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox PartyBox;
        private System.Windows.Forms.PictureBox EnemyBox;
        private System.Windows.Forms.ProgressBar EnemyHPBar;
        private System.Windows.Forms.ProgressBar PartyHPBar;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.Label EStatus;
        private System.Windows.Forms.Label EnemyHPNumb;
        private System.Windows.Forms.Label HPNumb;
        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.ProgressBar EXPBar;
        private System.Windows.Forms.Label LevelLable;
        private System.Windows.Forms.Label ELevelLable;
        private System.Windows.Forms.Label AttackLable;
        private System.Windows.Forms.Label DefenceLable;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button AttackO1;
        private System.Windows.Forms.Button AttackO3;
        private System.Windows.Forms.Button AttackO2;
    }
}


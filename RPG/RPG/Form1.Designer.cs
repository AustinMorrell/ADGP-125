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
            // ADGP125
            // 
            this.ClientSize = new System.Drawing.Size(1040, 545);
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
    }
}


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
            this.StartBattle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBattle
            // 
            this.StartBattle.Location = new System.Drawing.Point(877, 12);
            this.StartBattle.Name = "StartBattle";
            this.StartBattle.Size = new System.Drawing.Size(113, 98);
            this.StartBattle.TabIndex = 0;
            this.StartBattle.Text = "Start Battle";
            this.StartBattle.UseVisualStyleBackColor = true;
            this.StartBattle.Click += new System.EventHandler(this.StartBattle_Click);
            // 
            // ADGP125
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 548);
            this.Controls.Add(this.StartBattle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADGP125";
            this.Text = "ADGP125";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBattle;
    }
}


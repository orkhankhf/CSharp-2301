namespace WindowsFormsAppPart4.MineFieldGame
{
    partial class MineFieldGame
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
            this.minePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mineLbl = new System.Windows.Forms.Label();
            this.resetGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minePanel
            // 
            this.minePanel.Location = new System.Drawing.Point(12, 99);
            this.minePanel.Name = "minePanel";
            this.minePanel.Size = new System.Drawing.Size(450, 450);
            this.minePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xal:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(57, 9);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(0, 24);
            this.scoreLbl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mina:";
            // 
            // mineLbl
            // 
            this.mineLbl.AutoSize = true;
            this.mineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mineLbl.ForeColor = System.Drawing.Color.Green;
            this.mineLbl.Location = new System.Drawing.Point(70, 40);
            this.mineLbl.Name = "mineLbl";
            this.mineLbl.Size = new System.Drawing.Size(0, 24);
            this.mineLbl.TabIndex = 4;
            // 
            // resetGameBtn
            // 
            this.resetGameBtn.Location = new System.Drawing.Point(356, 12);
            this.resetGameBtn.Name = "resetGameBtn";
            this.resetGameBtn.Size = new System.Drawing.Size(106, 41);
            this.resetGameBtn.TabIndex = 5;
            this.resetGameBtn.Text = "Yenidən Başla";
            this.resetGameBtn.UseVisualStyleBackColor = true;
            this.resetGameBtn.Click += new System.EventHandler(this.resetGameBtn_Click);
            // 
            // MineFieldGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.resetGameBtn);
            this.Controls.Add(this.mineLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MineFieldGame";
            this.Text = "MineField Game";
            this.Load += new System.EventHandler(this.MineFieldGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel minePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mineLbl;
        private System.Windows.Forms.Button resetGameBtn;
    }
}
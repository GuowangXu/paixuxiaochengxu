namespace _1651789_许国望_计算机科学与技术_综合应用9
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNum = new System.Windows.Forms.Button();
            this.btnOnce = new System.Windows.Forms.Button();
            this.lblDice = new System.Windows.Forms.Label();
            this.ptbxGame = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDead = new System.Windows.Forms.Label();
            this.rtbxDead = new System.Windows.Forms.RichTextBox();
            this.gbxCtrl = new System.Windows.Forms.GroupBox();
            this.lblNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxGame)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbxCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNum
            // 
            this.btnNum.Enabled = false;
            this.btnNum.Location = new System.Drawing.Point(89, 70);
            this.btnNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(113, 29);
            this.btnNum.TabIndex = 0;
            this.btnNum.Text = "设置人数";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnOnce
            // 
            this.btnOnce.Enabled = false;
            this.btnOnce.Location = new System.Drawing.Point(272, 70);
            this.btnOnce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOnce.Name = "btnOnce";
            this.btnOnce.Size = new System.Drawing.Size(103, 29);
            this.btnOnce.TabIndex = 1;
            this.btnOnce.Text = "掷骰子";
            this.btnOnce.UseVisualStyleBackColor = true;
            this.btnOnce.Click += new System.EventHandler(this.btnOnce_Click);
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDice.Location = new System.Drawing.Point(308, 128);
            this.lblDice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(29, 30);
            this.lblDice.TabIndex = 2;
            this.lblDice.Text = "6";
            // 
            // ptbxGame
            // 
            this.ptbxGame.Image = ((System.Drawing.Image)(resources.GetObject("ptbxGame.Image")));
            this.ptbxGame.Location = new System.Drawing.Point(613, 62);
            this.ptbxGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbxGame.Name = "ptbxGame";
            this.ptbxGame.Size = new System.Drawing.Size(667, 625);
            this.ptbxGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxGame.TabIndex = 3;
            this.ptbxGame.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1383, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiGame
            // 
            this.tsmiGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart});
            this.tsmiGame.Name = "tsmiGame";
            this.tsmiGame.Size = new System.Drawing.Size(51, 24);
            this.tsmiGame.Text = "游戏";
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(129, 26);
            this.tsmiStart.Text = "新游戏";
            this.tsmiStart.Click += new System.EventHandler(this.tsmiStart_Click);
            // 
            // lblDead
            // 
            this.lblDead.AutoSize = true;
            this.lblDead.Location = new System.Drawing.Point(85, 199);
            this.lblDead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(109, 20);
            this.lblDead.TabIndex = 6;
            this.lblDead.Text = "已淘汰编号";
            // 
            // rtbxDead
            // 
            this.rtbxDead.Location = new System.Drawing.Point(88, 235);
            this.rtbxDead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbxDead.Name = "rtbxDead";
            this.rtbxDead.ReadOnly = true;
            this.rtbxDead.Size = new System.Drawing.Size(285, 333);
            this.rtbxDead.TabIndex = 7;
            this.rtbxDead.Text = "";
            // 
            // gbxCtrl
            // 
            this.gbxCtrl.Controls.Add(this.lblNum);
            this.gbxCtrl.Controls.Add(this.rtbxDead);
            this.gbxCtrl.Controls.Add(this.btnNum);
            this.gbxCtrl.Controls.Add(this.lblDead);
            this.gbxCtrl.Controls.Add(this.btnOnce);
            this.gbxCtrl.Controls.Add(this.lblDice);
            this.gbxCtrl.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbxCtrl.Location = new System.Drawing.Point(52, 62);
            this.gbxCtrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCtrl.Name = "gbxCtrl";
            this.gbxCtrl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCtrl.Size = new System.Drawing.Size(495, 624);
            this.gbxCtrl.TabIndex = 8;
            this.gbxCtrl.TabStop = false;
            this.gbxCtrl.Text = "游戏参数";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum.Location = new System.Drawing.Point(103, 128);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(93, 30);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "2~100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 730);
            this.Controls.Add(this.gbxCtrl);
            this.Controls.Add(this.ptbxGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "扔骰子小游戏";
            ((System.ComponentModel.ISupportInitialize)(this.ptbxGame)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxCtrl.ResumeLayout(false);
            this.gbxCtrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnOnce;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.PictureBox ptbxGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.RichTextBox rtbxDead;
        private System.Windows.Forms.GroupBox gbxCtrl;
        private System.Windows.Forms.Label lblNum;
    }
}


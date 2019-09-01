namespace _1651789_许国望_计算机科学与技术_算法实现9
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
            this.btnInsertSort = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBInsertSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnSelectSort = new System.Windows.Forms.Button();
            this.gbxSort = new System.Windows.Forms.GroupBox();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.rtbxData2 = new System.Windows.Forms.RichTextBox();
            this.rtbxData1 = new System.Windows.Forms.RichTextBox();
            this.labelData1 = new System.Windows.Forms.Label();
            this.labelData2 = new System.Windows.Forms.Label();
            this.gbxSort.SuspendLayout();
            this.gbxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertSort
            // 
            this.btnInsertSort.Location = new System.Drawing.Point(37, 38);
            this.btnInsertSort.Name = "btnInsertSort";
            this.btnInsertSort.Size = new System.Drawing.Size(121, 23);
            this.btnInsertSort.TabIndex = 0;
            this.btnInsertSort.Text = "直接插入排序";
            this.btnInsertSort.UseVisualStyleBackColor = true;
            this.btnInsertSort.Click += new System.EventHandler(this.btnInsertSort_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(152, 309);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(91, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "排序过程";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBInsertSort
            // 
            this.btnBInsertSort.Location = new System.Drawing.Point(37, 87);
            this.btnBInsertSort.Name = "btnBInsertSort";
            this.btnBInsertSort.Size = new System.Drawing.Size(121, 23);
            this.btnBInsertSort.TabIndex = 2;
            this.btnBInsertSort.Text = "折半插入排序";
            this.btnBInsertSort.UseVisualStyleBackColor = true;
            this.btnBInsertSort.Click += new System.EventHandler(this.btnBInsertSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Location = new System.Drawing.Point(37, 139);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(121, 23);
            this.btnShellSort.TabIndex = 3;
            this.btnShellSort.Text = "希尔排序";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(37, 192);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(121, 23);
            this.btnBubbleSort.TabIndex = 4;
            this.btnBubbleSort.Text = "冒泡排序";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(37, 243);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(121, 23);
            this.btnQuickSort.TabIndex = 5;
            this.btnQuickSort.Text = "快速排序";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnSelectSort
            // 
            this.btnSelectSort.Location = new System.Drawing.Point(37, 294);
            this.btnSelectSort.Name = "btnSelectSort";
            this.btnSelectSort.Size = new System.Drawing.Size(121, 23);
            this.btnSelectSort.TabIndex = 6;
            this.btnSelectSort.Text = "简单选择排序";
            this.btnSelectSort.UseVisualStyleBackColor = true;
            this.btnSelectSort.Click += new System.EventHandler(this.btnSelectSort_Click);
            // 
            // gbxSort
            // 
            this.gbxSort.Controls.Add(this.btnInsertSort);
            this.gbxSort.Controls.Add(this.btnSelectSort);
            this.gbxSort.Controls.Add(this.btnBInsertSort);
            this.gbxSort.Controls.Add(this.btnQuickSort);
            this.gbxSort.Controls.Add(this.btnShellSort);
            this.gbxSort.Controls.Add(this.btnBubbleSort);
            this.gbxSort.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbxSort.Location = new System.Drawing.Point(58, 37);
            this.gbxSort.Name = "gbxSort";
            this.gbxSort.Size = new System.Drawing.Size(183, 351);
            this.gbxSort.TabIndex = 7;
            this.gbxSort.TabStop = false;
            this.gbxSort.Text = "排序方式";
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.labelData2);
            this.gbxData.Controls.Add(this.labelData1);
            this.gbxData.Controls.Add(this.rtbxData1);
            this.gbxData.Controls.Add(this.rtbxData2);
            this.gbxData.Controls.Add(this.btnProcess);
            this.gbxData.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbxData.Location = new System.Drawing.Point(317, 37);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(397, 351);
            this.gbxData.TabIndex = 8;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "数据显示";
            // 
            // rtbxData2
            // 
            this.rtbxData2.Location = new System.Drawing.Point(30, 204);
            this.rtbxData2.Name = "rtbxData2";
            this.rtbxData2.ReadOnly = true;
            this.rtbxData2.Size = new System.Drawing.Size(344, 99);
            this.rtbxData2.TabIndex = 3;
            this.rtbxData2.Text = "";
            // 
            // rtbxData1
            // 
            this.rtbxData1.Location = new System.Drawing.Point(30, 63);
            this.rtbxData1.Name = "rtbxData1";
            this.rtbxData1.ReadOnly = true;
            this.rtbxData1.Size = new System.Drawing.Size(344, 99);
            this.rtbxData1.TabIndex = 4;
            this.rtbxData1.Text = "";
            // 
            // labelData1
            // 
            this.labelData1.AutoSize = true;
            this.labelData1.Location = new System.Drawing.Point(32, 38);
            this.labelData1.Name = "labelData1";
            this.labelData1.Size = new System.Drawing.Size(72, 16);
            this.labelData1.TabIndex = 5;
            this.labelData1.Text = "待排数据";
            // 
            // labelData2
            // 
            this.labelData2.AutoSize = true;
            this.labelData2.Location = new System.Drawing.Point(32, 174);
            this.labelData2.Name = "labelData2";
            this.labelData2.Size = new System.Drawing.Size(72, 16);
            this.labelData2.TabIndex = 6;
            this.labelData2.Text = "排序结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.gbxData);
            this.Controls.Add(this.gbxSort);
            this.Name = "Form1";
            this.Text = "排序小程序";
            this.gbxSort.ResumeLayout(false);
            this.gbxData.ResumeLayout(false);
            this.gbxData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertSort;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBInsertSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnSelectSort;
        private System.Windows.Forms.GroupBox gbxSort;
        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.Label labelData2;
        private System.Windows.Forms.Label labelData1;
        private System.Windows.Forms.RichTextBox rtbxData1;
        private System.Windows.Forms.RichTextBox rtbxData2;
    }
}


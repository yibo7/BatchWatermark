namespace BatchWatermark
{
    partial class Main
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
            this.txtSourePath = new System.Windows.Forms.TextBox();
            this.btnSelIn = new System.Windows.Forms.Button();
            this.btnSelOut = new System.Windows.Forms.Button();
            this.txtSyPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbFindingInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelOutPath = new System.Windows.Forms.Button();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.tbImgquality = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWatermarkPlace = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWatermarktransparency = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbImgquality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWatermarkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWatermarktransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSourePath
            // 
            this.txtSourePath.Location = new System.Drawing.Point(135, 23);
            this.txtSourePath.Name = "txtSourePath";
            this.txtSourePath.Size = new System.Drawing.Size(336, 21);
            this.txtSourePath.TabIndex = 0;
            // 
            // btnSelIn
            // 
            this.btnSelIn.Location = new System.Drawing.Point(475, 22);
            this.btnSelIn.Name = "btnSelIn";
            this.btnSelIn.Size = new System.Drawing.Size(75, 23);
            this.btnSelIn.TabIndex = 1;
            this.btnSelIn.Text = "选择目录";
            this.btnSelIn.UseVisualStyleBackColor = true;
            this.btnSelIn.Click += new System.EventHandler(this.btnSelIn_Click);
            // 
            // btnSelOut
            // 
            this.btnSelOut.Location = new System.Drawing.Point(475, 57);
            this.btnSelOut.Name = "btnSelOut";
            this.btnSelOut.Size = new System.Drawing.Size(75, 23);
            this.btnSelOut.TabIndex = 3;
            this.btnSelOut.Text = "选择文件";
            this.btnSelOut.UseVisualStyleBackColor = true;
            this.btnSelOut.Click += new System.EventHandler(this.btnSelOut_Click);
            // 
            // txtSyPath
            // 
            this.txtSyPath.Location = new System.Drawing.Point(135, 58);
            this.txtSyPath.Name = "txtSyPath";
            this.txtSyPath.Size = new System.Drawing.Size(336, 21);
            this.txtSyPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "图片源目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "水印图";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "开始生成";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbFindingInfo
            // 
            this.lbFindingInfo.AutoSize = true;
            this.lbFindingInfo.Location = new System.Drawing.Point(38, 315);
            this.lbFindingInfo.Name = "lbFindingInfo";
            this.lbFindingInfo.Size = new System.Drawing.Size(0, 12);
            this.lbFindingInfo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "输出图片目录";
            // 
            // btnSelOutPath
            // 
            this.btnSelOutPath.Location = new System.Drawing.Point(474, 92);
            this.btnSelOutPath.Name = "btnSelOutPath";
            this.btnSelOutPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelOutPath.TabIndex = 11;
            this.btnSelOutPath.Text = "选择目录";
            this.btnSelOutPath.UseVisualStyleBackColor = true;
            this.btnSelOutPath.Click += new System.EventHandler(this.btnSelOutPath_Click);
            // 
            // txtOutPath
            // 
            this.txtOutPath.Location = new System.Drawing.Point(134, 93);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.Size = new System.Drawing.Size(336, 21);
            this.txtOutPath.TabIndex = 10;
            // 
            // tbImgquality
            // 
            this.tbImgquality.Location = new System.Drawing.Point(125, 125);
            this.tbImgquality.Maximum = 100;
            this.tbImgquality.Name = "tbImgquality";
            this.tbImgquality.Size = new System.Drawing.Size(425, 45);
            this.tbImgquality.TabIndex = 13;
            this.tbImgquality.Value = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "水印图片质量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "位置";
            // 
            // tbWatermarkPlace
            // 
            this.tbWatermarkPlace.Location = new System.Drawing.Point(124, 218);
            this.tbWatermarkPlace.Maximum = 9;
            this.tbWatermarkPlace.Minimum = 1;
            this.tbWatermarkPlace.Name = "tbWatermarkPlace";
            this.tbWatermarkPlace.Size = new System.Drawing.Size(425, 45);
            this.tbWatermarkPlace.TabIndex = 15;
            this.tbWatermarkPlace.Value = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(122, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "左上    中上     右上    左中     中中     右中     左下   右中    右下";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "水印图片透明度";
            // 
            // tbWatermarktransparency
            // 
            this.tbWatermarktransparency.Location = new System.Drawing.Point(123, 167);
            this.tbWatermarktransparency.Minimum = 1;
            this.tbWatermarktransparency.Name = "tbWatermarktransparency";
            this.tbWatermarktransparency.Size = new System.Drawing.Size(425, 45);
            this.tbWatermarktransparency.TabIndex = 18;
            this.tbWatermarktransparency.Value = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 420);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbWatermarktransparency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbWatermarkPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbImgquality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelOutPath);
            this.Controls.Add(this.txtOutPath);
            this.Controls.Add(this.lbFindingInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelOut);
            this.Controls.Add(this.txtSyPath);
            this.Controls.Add(this.btnSelIn);
            this.Controls.Add(this.txtSourePath);
            this.Name = "Main";
            this.Text = "批量生成图片水印";
            ((System.ComponentModel.ISupportInitialize)(this.tbImgquality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWatermarkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWatermarktransparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourePath;
        private System.Windows.Forms.Button btnSelIn;
        private System.Windows.Forms.Button btnSelOut;
        private System.Windows.Forms.TextBox txtSyPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbFindingInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelOutPath;
        private System.Windows.Forms.TextBox txtOutPath;
        private System.Windows.Forms.TrackBar tbImgquality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbWatermarkPlace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbWatermarktransparency;
    }
}


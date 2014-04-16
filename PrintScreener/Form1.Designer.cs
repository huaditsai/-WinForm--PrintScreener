namespace PrintScreener
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPrSc = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnJPG = new System.Windows.Forms.RadioButton();
            this.rbtnPNG = new System.Windows.Forms.RadioButton();
            this.rbtnBMP = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnAct = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnModArea = new System.Windows.Forms.RadioButton();
            this.rbtnModFull = new System.Windows.Forms.RadioButton();
            this.btnRecord = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrSc
            // 
            this.btnPrSc.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrSc.Location = new System.Drawing.Point(21, 213);
            this.btnPrSc.Name = "btnPrSc";
            this.btnPrSc.Size = new System.Drawing.Size(112, 37);
            this.btnPrSc.TabIndex = 0;
            this.btnPrSc.Text = "ScreenShot";
            this.btnPrSc.UseVisualStyleBackColor = true;
            this.btnPrSc.Click += new System.EventHandler(this.btnPrSc_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPath.Location = new System.Drawing.Point(12, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(218, 27);
            this.txtPath.TabIndex = 1;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(236, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnJPG
            // 
            this.rbtnJPG.AutoSize = true;
            this.rbtnJPG.Checked = true;
            this.rbtnJPG.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnJPG.Location = new System.Drawing.Point(80, 80);
            this.rbtnJPG.Name = "rbtnJPG";
            this.rbtnJPG.Size = new System.Drawing.Size(53, 23);
            this.rbtnJPG.TabIndex = 4;
            this.rbtnJPG.TabStop = true;
            this.rbtnJPG.Text = "JPG";
            this.rbtnJPG.UseVisualStyleBackColor = true;
            this.rbtnJPG.CheckedChanged += new System.EventHandler(this.rbtnJPG_CheckedChanged);
            // 
            // rbtnPNG
            // 
            this.rbtnPNG.AutoSize = true;
            this.rbtnPNG.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnPNG.Location = new System.Drawing.Point(139, 80);
            this.rbtnPNG.Name = "rbtnPNG";
            this.rbtnPNG.Size = new System.Drawing.Size(59, 23);
            this.rbtnPNG.TabIndex = 5;
            this.rbtnPNG.Text = "PNG";
            this.rbtnPNG.UseVisualStyleBackColor = true;
            this.rbtnPNG.CheckedChanged += new System.EventHandler(this.rbtnPNG_CheckedChanged);
            // 
            // rbtnBMP
            // 
            this.rbtnBMP.AutoSize = true;
            this.rbtnBMP.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnBMP.Location = new System.Drawing.Point(204, 80);
            this.rbtnBMP.Name = "rbtnBMP";
            this.rbtnBMP.Size = new System.Drawing.Size(59, 23);
            this.rbtnBMP.TabIndex = 6;
            this.rbtnBMP.Text = "BMP";
            this.rbtnBMP.UseVisualStyleBackColor = true;
            this.rbtnBMP.CheckedChanged += new System.EventHandler(this.rbtnBMP_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Format";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.rbtnAct);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rbtnModArea);
            this.panel2.Controls.Add(this.rbtnModFull);
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 32);
            this.panel2.TabIndex = 12;
            // 
            // rbtnAct
            // 
            this.rbtnAct.AutoSize = true;
            this.rbtnAct.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnAct.Location = new System.Drawing.Point(114, 6);
            this.rbtnAct.Name = "rbtnAct";
            this.rbtnAct.Size = new System.Drawing.Size(69, 23);
            this.rbtnAct.TabIndex = 16;
            this.rbtnAct.Text = "Active";
            this.rbtnAct.UseVisualStyleBackColor = true;
            this.rbtnAct.CheckedChanged += new System.EventHandler(this.rbtnAct_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(0, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mode";
            // 
            // rbtnModArea
            // 
            this.rbtnModArea.AutoSize = true;
            this.rbtnModArea.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnModArea.Location = new System.Drawing.Point(184, 6);
            this.rbtnModArea.Name = "rbtnModArea";
            this.rbtnModArea.Size = new System.Drawing.Size(59, 23);
            this.rbtnModArea.TabIndex = 15;
            this.rbtnModArea.Text = "Area";
            this.rbtnModArea.UseVisualStyleBackColor = true;
            this.rbtnModArea.CheckedChanged += new System.EventHandler(this.rbtnModArea_CheckedChanged);
            // 
            // rbtnModFull
            // 
            this.rbtnModFull.AutoSize = true;
            this.rbtnModFull.Checked = true;
            this.rbtnModFull.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnModFull.Location = new System.Drawing.Point(56, 6);
            this.rbtnModFull.Name = "rbtnModFull";
            this.rbtnModFull.Size = new System.Drawing.Size(52, 23);
            this.rbtnModFull.TabIndex = 14;
            this.rbtnModFull.TabStop = true;
            this.rbtnModFull.Text = "Full";
            this.rbtnModFull.UseVisualStyleBackColor = true;
            this.rbtnModFull.CheckedChanged += new System.EventHandler(this.rbtnModFull_CheckedChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRecord.Location = new System.Drawing.Point(151, 213);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(112, 37);
            this.btnRecord.TabIndex = 15;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnBMP);
            this.Controls.Add(this.rbtnPNG);
            this.Controls.Add(this.rbtnJPG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnPrSc);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Screener";
            this.TopMost = true;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrSc;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnJPG;
        private System.Windows.Forms.RadioButton rbtnPNG;
        private System.Windows.Forms.RadioButton rbtnBMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnModFull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnModArea;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.RadioButton rbtnAct;
        private System.Windows.Forms.Button button2;
    }
}


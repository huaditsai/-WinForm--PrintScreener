namespace PrintScreener
{
    partial class Form2
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
            this.labLx = new System.Windows.Forms.Label();
            this.labRx = new System.Windows.Forms.Label();
            this.labTy = new System.Windows.Forms.Label();
            this.labDy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labLx
            // 
            this.labLx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labLx.AutoSize = true;
            this.labLx.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLx.Location = new System.Drawing.Point(12, 118);
            this.labLx.Name = "labLx";
            this.labLx.Size = new System.Drawing.Size(30, 19);
            this.labLx.TabIndex = 1;
            this.labLx.Text = "X : ";
            // 
            // labRx
            // 
            this.labRx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labRx.AutoSize = true;
            this.labRx.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRx.Location = new System.Drawing.Point(209, 119);
            this.labRx.Name = "labRx";
            this.labRx.Size = new System.Drawing.Size(26, 19);
            this.labRx.TabIndex = 2;
            this.labRx.Text = "X :";
            // 
            // labTy
            // 
            this.labTy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTy.AutoSize = true;
            this.labTy.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTy.Location = new System.Drawing.Point(106, 9);
            this.labTy.Name = "labTy";
            this.labTy.Size = new System.Drawing.Size(29, 19);
            this.labTy.TabIndex = 3;
            this.labTy.Text = "Y : ";
            // 
            // labDy
            // 
            this.labDy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labDy.AutoSize = true;
            this.labDy.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDy.Location = new System.Drawing.Point(106, 228);
            this.labDy.Name = "labDy";
            this.labDy.Size = new System.Drawing.Size(29, 19);
            this.labDy.TabIndex = 4;
            this.labDy.Text = "Y : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 251);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirm with Space";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(256, 256);
            this.Controls.Add(this.labDy);
            this.Controls.Add(this.labTy);
            this.Controls.Add(this.labRx);
            this.Controls.Add(this.labLx);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLx;
        private System.Windows.Forms.Label labRx;
        private System.Windows.Forms.Label labTy;
        private System.Windows.Forms.Label labDy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
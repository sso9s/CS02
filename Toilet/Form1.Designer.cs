namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pninout1 = new System.Windows.Forms.Panel();
            this.pbinout = new System.Windows.Forms.PictureBox();
            this.pncall1 = new System.Windows.Forms.Panel();
            this.pbcall = new System.Windows.Forms.PictureBox();
            this.pnts = new System.Windows.Forms.Panel();
            this.pbts = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pninout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinout)).BeginInit();
            this.pncall1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcall)).BeginInit();
            this.pnts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // pninout1
            // 
            this.pninout1.Controls.Add(this.pbinout);
            this.pninout1.Location = new System.Drawing.Point(12, 12);
            this.pninout1.Name = "pninout1";
            this.pninout1.Size = new System.Drawing.Size(252, 250);
            this.pninout1.TabIndex = 3;
            // 
            // pbinout
            // 
            this.pbinout.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.pbinout.Location = new System.Drawing.Point(52, 29);
            this.pbinout.Name = "pbinout";
            this.pbinout.Size = new System.Drawing.Size(158, 180);
            this.pbinout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbinout.TabIndex = 5;
            this.pbinout.TabStop = false;
            // 
            // pncall1
            // 
            this.pncall1.Controls.Add(this.pbcall);
            this.pncall1.Location = new System.Drawing.Point(284, 12);
            this.pncall1.Name = "pncall1";
            this.pncall1.Size = new System.Drawing.Size(252, 250);
            this.pncall1.TabIndex = 0;
            // 
            // pbcall
            // 
            this.pbcall.Image = global::WindowsFormsApp1.Properties.Resources.warn;
            this.pbcall.Location = new System.Drawing.Point(31, 29);
            this.pbcall.Name = "pbcall";
            this.pbcall.Size = new System.Drawing.Size(185, 166);
            this.pbcall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbcall.TabIndex = 6;
            this.pbcall.TabStop = false;
            // 
            // pnts
            // 
            this.pnts.Controls.Add(this.pbts);
            this.pnts.Location = new System.Drawing.Point(564, 12);
            this.pnts.Name = "pnts";
            this.pnts.Size = new System.Drawing.Size(272, 250);
            this.pnts.TabIndex = 4;
            // 
            // pbts
            // 
            this.pbts.Image = global::WindowsFormsApp1.Properties.Resources.pbts;
            this.pbts.Location = new System.Drawing.Point(48, 29);
            this.pbts.Name = "pbts";
            this.pbts.Size = new System.Drawing.Size(193, 180);
            this.pbts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbts.TabIndex = 7;
            this.pbts.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(715, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnts);
            this.Controls.Add(this.pncall1);
            this.Controls.Add(this.pninout1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pninout1.ResumeLayout(false);
            this.pninout1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinout)).EndInit();
            this.pncall1.ResumeLayout(false);
            this.pncall1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcall)).EndInit();
            this.pnts.ResumeLayout(false);
            this.pnts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pninout1;
        private System.Windows.Forms.PictureBox pbinout;
        private System.Windows.Forms.Panel pncall1;
        private System.Windows.Forms.PictureBox pbcall;
        private System.Windows.Forms.Panel pnts;
        private System.Windows.Forms.PictureBox pbts;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


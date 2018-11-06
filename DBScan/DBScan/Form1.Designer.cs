namespace DBScan
{
    partial class Form1
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
            this.txtLocate = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.Eps = new System.Windows.Forms.Label();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMinPts = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocate
            // 
            this.txtLocate.AutoSize = true;
            this.txtLocate.Location = new System.Drawing.Point(12, 715);
            this.txtLocate.Name = "txtLocate";
            this.txtLocate.Size = new System.Drawing.Size(0, 17);
            this.txtLocate.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1158, 495);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlContainer_MouseClick);
            this.pnlContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlContainer_MouseMove);
            // 
            // Eps
            // 
            this.Eps.AutoSize = true;
            this.Eps.Location = new System.Drawing.Point(12, 529);
            this.Eps.Name = "Eps";
            this.Eps.Size = new System.Drawing.Size(32, 17);
            this.Eps.TabIndex = 3;
            this.Eps.Text = "Eps";
            // 
            // txtEps
            // 
            this.txtEps.Location = new System.Drawing.Point(50, 526);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(121, 22);
            this.txtEps.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "MinPts";
            // 
            // cboMinPts
            // 
            this.cboMinPts.FormattingEnabled = true;
            this.cboMinPts.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboMinPts.Location = new System.Drawing.Point(232, 526);
            this.cboMinPts.Name = "cboMinPts";
            this.cboMinPts.Size = new System.Drawing.Size(121, 24);
            this.cboMinPts.TabIndex = 6;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(371, 526);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(92, 24);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Chạy";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(469, 526);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 24);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Clear";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cboMinPts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEps);
            this.Controls.Add(this.Eps);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.txtLocate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "DbScan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLocate;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label Eps;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMinPts;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnXoa;
    }
}


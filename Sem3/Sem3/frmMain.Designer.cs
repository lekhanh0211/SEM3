
namespace Sem3
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnTk = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnDM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Green;
            this.pnLeft.Controls.Add(this.btnTk);
            this.pnLeft.Controls.Add(this.btnNV);
            this.pnLeft.Controls.Add(this.btnHD);
            this.pnLeft.Controls.Add(this.btnSP);
            this.pnLeft.Controls.Add(this.btnDM);
            this.pnLeft.Controls.Add(this.pictureBox1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(200, 526);
            this.pnLeft.TabIndex = 0;
            // 
            // btnTk
            // 
            this.btnTk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTk.FlatAppearance.BorderSize = 0;
            this.btnTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTk.Location = new System.Drawing.Point(0, 447);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(200, 40);
            this.btnTk.TabIndex = 5;
            this.btnTk.Text = "Thống kê";
            this.btnTk.UseVisualStyleBackColor = false;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // btnNV
            // 
            this.btnNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNV.FlatAppearance.BorderSize = 0;
            this.btnNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNV.Location = new System.Drawing.Point(0, 377);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(200, 40);
            this.btnNV.TabIndex = 4;
            this.btnNV.Text = "Quản lý nhân viên";
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnHD
            // 
            this.btnHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHD.FlatAppearance.BorderSize = 0;
            this.btnHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHD.Location = new System.Drawing.Point(0, 307);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(200, 40);
            this.btnHD.TabIndex = 3;
            this.btnHD.Text = "Hóa đơn bán hàng";
            this.btnHD.UseVisualStyleBackColor = false;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnSP
            // 
            this.btnSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSP.FlatAppearance.BorderSize = 0;
            this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSP.Location = new System.Drawing.Point(0, 234);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(200, 40);
            this.btnSP.TabIndex = 2;
            this.btnSP.Text = "Quản lý sản phẩm";
            this.btnSP.UseVisualStyleBackColor = false;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnDM
            // 
            this.btnDM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDM.FlatAppearance.BorderSize = 0;
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDM.Location = new System.Drawing.Point(0, 159);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(200, 40);
            this.btnDM.TabIndex = 1;
            this.btnDM.Text = "Quản lý danh mục";
            this.btnDM.UseVisualStyleBackColor = false;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnTop.Controls.Add(this.btnLogOut);
            this.pnTop.Controls.Add(this.txtTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.ForeColor = System.Drawing.Color.Crimson;
            this.pnTop.Location = new System.Drawing.Point(200, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(800, 79);
            this.pnTop.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(666, 21);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(122, 36);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTitle.Location = new System.Drawing.Point(30, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(80, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Trang chủ";
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.LightYellow;
            this.pnBody.Controls.Add(this.pictureBox2);
            this.pnBody.Controls.Add(this.label1);
            this.pnBody.Controls.Add(this.statusStrip1);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(200, 79);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(800, 447);
            this.pnBody.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(402, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(264, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chương trình quản lý bán hàng";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel2.Text = "Version 1.0.0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 526);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnLogOut;
    }
}


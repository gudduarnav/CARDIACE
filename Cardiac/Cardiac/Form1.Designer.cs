namespace LittleManComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSrc = new System.Windows.Forms.DataGridView();
            this.dgvAsm = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.cbDelay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAC = new System.Windows.Forms.Label();
            this.lbPC = new System.Windows.Forms.Label();
            this.lkHome = new System.Windows.Forms.LinkLabel();
            this.lkLMC = new System.Windows.Forms.LinkLabel();
            this.lkAbout = new System.Windows.Forms.LinkLabel();
            this.lbFlag = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSrc);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Code:";
            // 
            // dgvSrc
            // 
            this.dgvSrc.AllowUserToAddRows = false;
            this.dgvSrc.AllowUserToDeleteRows = false;
            this.dgvSrc.AllowUserToResizeColumns = false;
            this.dgvSrc.AllowUserToResizeRows = false;
            this.dgvSrc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSrc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSrc.Location = new System.Drawing.Point(14, 31);
            this.dgvSrc.MultiSelect = false;
            this.dgvSrc.Name = "dgvSrc";
            this.dgvSrc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSrc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSrc.Size = new System.Drawing.Size(236, 288);
            this.dgvSrc.TabIndex = 0;
            this.dgvSrc.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvSrc_CellBeginEdit);
            this.dgvSrc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSrc_CellValueChanged);
            // 
            // dgvAsm
            // 
            this.dgvAsm.AllowUserToAddRows = false;
            this.dgvAsm.AllowUserToDeleteRows = false;
            this.dgvAsm.AllowUserToResizeColumns = false;
            this.dgvAsm.AllowUserToResizeRows = false;
            this.dgvAsm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAsm.Location = new System.Drawing.Point(20, 28);
            this.dgvAsm.MultiSelect = false;
            this.dgvAsm.Name = "dgvAsm";
            this.dgvAsm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAsm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAsm.Size = new System.Drawing.Size(209, 288);
            this.dgvAsm.TabIndex = 0;
            this.dgvAsm.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAsm_CellBeginEdit);
            this.dgvAsm.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsm_CellValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAsm);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machine Code:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(559, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(201, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(559, 60);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(201, 30);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(559, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(559, 265);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(201, 30);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delay:";
            // 
            // rtbReport
            // 
            this.rtbReport.BackColor = System.Drawing.SystemColors.Control;
            this.rtbReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbReport.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReport.Location = new System.Drawing.Point(12, 353);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.ReadOnly = true;
            this.rtbReport.Size = new System.Drawing.Size(653, 106);
            this.rtbReport.TabIndex = 10;
            this.rtbReport.Text = "";
            // 
            // cbDelay
            // 
            this.cbDelay.FormattingEnabled = true;
            this.cbDelay.Location = new System.Drawing.Point(596, 309);
            this.cbDelay.Name = "cbDelay";
            this.cbDelay.Size = new System.Drawing.Size(55, 21);
            this.cbDelay.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "AC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "PC:";
            // 
            // lbAC
            // 
            this.lbAC.AutoSize = true;
            this.lbAC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAC.Location = new System.Drawing.Point(593, 138);
            this.lbAC.Name = "lbAC";
            this.lbAC.Size = new System.Drawing.Size(18, 19);
            this.lbAC.TabIndex = 15;
            this.lbAC.Text = "0";
            // 
            // lbPC
            // 
            this.lbPC.AutoSize = true;
            this.lbPC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPC.Location = new System.Drawing.Point(593, 171);
            this.lbPC.Name = "lbPC";
            this.lbPC.Size = new System.Drawing.Size(18, 19);
            this.lbPC.TabIndex = 16;
            this.lbPC.Text = "0";
            // 
            // lkHome
            // 
            this.lkHome.AutoSize = true;
            this.lkHome.Location = new System.Drawing.Point(564, 202);
            this.lkHome.Name = "lkHome";
            this.lkHome.Size = new System.Drawing.Size(100, 13);
            this.lkHome.TabIndex = 17;
            this.lkHome.TabStop = true;
            this.lkHome.Text = "arnavguddu.6te.net";
            this.lkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkHome_LinkClicked);
            // 
            // lkLMC
            // 
            this.lkLMC.AutoSize = true;
            this.lkLMC.Location = new System.Drawing.Point(565, 224);
            this.lkLMC.Name = "lkLMC";
            this.lkLMC.Size = new System.Drawing.Size(206, 13);
            this.lkLMC.TabIndex = 18;
            this.lkLMC.TabStop = true;
            this.lkLMC.Text = "CARDboard Illustrative Aid to Computation";
            this.lkLMC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLMC_LinkClicked);
            // 
            // lkAbout
            // 
            this.lkAbout.AutoSize = true;
            this.lkAbout.Location = new System.Drawing.Point(565, 245);
            this.lkAbout.Name = "lkAbout";
            this.lkAbout.Size = new System.Drawing.Size(35, 13);
            this.lkAbout.TabIndex = 19;
            this.lkAbout.TabStop = true;
            this.lkAbout.Text = "About";
            this.lkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkAbout_LinkClicked);
            // 
            // lbFlag
            // 
            this.lbFlag.AutoSize = true;
            this.lbFlag.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlag.Location = new System.Drawing.Point(706, 144);
            this.lbFlag.Name = "lbFlag";
            this.lbFlag.Size = new System.Drawing.Size(45, 19);
            this.lbFlag.TabIndex = 21;
            this.lbFlag.Text = "Zero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Flag:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 471);
            this.Controls.Add(this.lbFlag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lkAbout);
            this.Controls.Add(this.lkLMC);
            this.Controls.Add(this.lkHome);
            this.Controls.Add(this.lbPC);
            this.Controls.Add(this.lbAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDelay);
            this.Controls.Add(this.rtbReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARDboard Illustrative Aid to Computation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSrc;
        private System.Windows.Forms.DataGridView dgvAsm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.ComboBox cbDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAC;
        private System.Windows.Forms.Label lbPC;
        private System.Windows.Forms.LinkLabel lkHome;
        private System.Windows.Forms.LinkLabel lkLMC;
        private System.Windows.Forms.LinkLabel lkAbout;
        private System.Windows.Forms.Label lbFlag;
        private System.Windows.Forms.Label label6;

    }
}


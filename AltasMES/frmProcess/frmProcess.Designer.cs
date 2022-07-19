namespace AltasMES
{
    partial class frmProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.BasePanel1.SuspendLayout();
            this.Basepanel2.SuspendLayout();
            this.Basepanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(795, 50);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExecl
            // 
            this.btnExecl.Location = new System.Drawing.Point(1081, 50);
            this.btnExecl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExecl.Click += new System.EventHandler(this.btnExecl_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(986, 50);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(88, 46);
            this.lblTitle.Text = "공정";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(890, 50);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Create.png");
            this.imageList1.Images.SetKeyName(1, "Modify.png");
            this.imageList1.Images.SetKeyName(2, "Delete.png");
            this.imageList1.Images.SetKeyName(3, "Serach.png");
            this.imageList1.Images.SetKeyName(4, "Execl.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Text = "검색조건";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 966);
            this.panel2.Size = new System.Drawing.Size(1182, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Size = new System.Drawing.Size(1182, 685);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProcess);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1182, 685);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "공정 목록";
            // 
            // dgvProcess
            // 
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcess.Location = new System.Drawing.Point(3, 25);
            this.dgvProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.RowHeadersWidth = 51;
            this.dgvProcess.RowTemplate.Height = 27;
            this.dgvProcess.Size = new System.Drawing.Size(1176, 658);
            this.dgvProcess.TabIndex = 0;
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Name = "frmProcess";
            this.Text = "공정";
            this.Load += new System.EventHandler(this.frmProcess_Load);
            this.BasePanel1.ResumeLayout(false);
            this.Basepanel2.ResumeLayout(false);
            this.Basepanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProcess;
    }
}
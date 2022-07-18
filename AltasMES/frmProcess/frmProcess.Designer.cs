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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(800, 90);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 26);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExecl
            // 
            this.btnExecl.Location = new System.Drawing.Point(699, 26);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(604, 26);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(88, 46);
            this.lblTitle.Text = "공정";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(509, 26);
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
            this.groupBox2.Size = new System.Drawing.Size(800, 78);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 282);
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmProcess";
            this.Text = "frmProcess";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
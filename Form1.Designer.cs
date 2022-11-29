namespace Responsi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.inputDepartemen = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.boxKaryawan = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputKaryawanId = new System.Windows.Forms.TextBox();
            this.boxKeterangan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dep. Karyawan";
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(105, 95);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(158, 20);
            this.inputNama.TabIndex = 3;
            // 
            // inputDepartemen
            // 
            this.inputDepartemen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputDepartemen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputDepartemen.Location = new System.Drawing.Point(105, 118);
            this.inputDepartemen.Name = "inputDepartemen";
            this.inputDepartemen.Size = new System.Drawing.Size(158, 20);
            this.inputDepartemen.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(14, 157);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(355, 157);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(485, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // boxKaryawan
            // 
            this.boxKaryawan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxKaryawan.Location = new System.Drawing.Point(14, 203);
            this.boxKaryawan.Name = "boxKaryawan";
            this.boxKaryawan.Size = new System.Drawing.Size(755, 292);
            this.boxKaryawan.TabIndex = 9;
            this.boxKaryawan.TabStop = false;
            this.boxKaryawan.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Karyawan (Khusus Edit dan Delete)";
            // 
            // inputKaryawanId
            // 
            this.inputKaryawanId.Location = new System.Drawing.Point(508, 117);
            this.inputKaryawanId.Name = "inputKaryawanId";
            this.inputKaryawanId.Size = new System.Drawing.Size(100, 20);
            this.inputKaryawanId.TabIndex = 11;
            // 
            // boxKeterangan
            // 
            this.boxKeterangan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boxKeterangan.Location = new System.Drawing.Point(635, 34);
            this.boxKeterangan.Name = "boxKeterangan";
            this.boxKeterangan.Size = new System.Drawing.Size(134, 100);
            this.boxKeterangan.TabIndex = 12;
            this.boxKeterangan.TabStop = false;
            this.boxKeterangan.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.boxKeterangan);
            this.Controls.Add(this.inputKaryawanId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxKaryawan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.inputDepartemen);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.TextBox inputDepartemen;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox boxKaryawan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputKaryawanId;
        private System.Windows.Forms.GroupBox boxKeterangan;
    }
}


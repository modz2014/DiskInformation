namespace DiskInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtxtDiskInformation = new System.Windows.Forms.RichTextBox();
            this.btnGetHardDiskNumber = new System.Windows.Forms.Button();
            this.BtnChangeSerialNumber = new System.Windows.Forms.Button();
            this.txtNewSerialNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtxtDiskInformation
            // 
            this.rtxtDiskInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDiskInformation.Location = new System.Drawing.Point(13, 13);
            this.rtxtDiskInformation.Name = "rtxtDiskInformation";
            this.rtxtDiskInformation.Size = new System.Drawing.Size(390, 175);
            this.rtxtDiskInformation.TabIndex = 0;
            this.rtxtDiskInformation.Text = "";
            // 
            // btnGetHardDiskNumber
            // 
            this.btnGetHardDiskNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetHardDiskNumber.Location = new System.Drawing.Point(13, 194);
            this.btnGetHardDiskNumber.Name = "btnGetHardDiskNumber";
            this.btnGetHardDiskNumber.Size = new System.Drawing.Size(152, 35);
            this.btnGetHardDiskNumber.TabIndex = 1;
            this.btnGetHardDiskNumber.Text = "Get Hard Disk Number";
            this.btnGetHardDiskNumber.UseVisualStyleBackColor = true;
            this.btnGetHardDiskNumber.Click += new System.EventHandler(this.BtnGetHardDiskNumber_Click);
            // 
            // BtnChangeSerialNumber
            // 
            this.BtnChangeSerialNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeSerialNumber.Location = new System.Drawing.Point(13, 251);
            this.BtnChangeSerialNumber.Name = "BtnChangeSerialNumber";
            this.BtnChangeSerialNumber.Size = new System.Drawing.Size(152, 35);
            this.BtnChangeSerialNumber.TabIndex = 4;
            this.BtnChangeSerialNumber.Text = "Change Serial:";
            this.BtnChangeSerialNumber.UseVisualStyleBackColor = true;
            this.BtnChangeSerialNumber.Click += new System.EventHandler(this.BtnChangeSerialNumber_Click);
            // 
            // txtNewSerialNumber
            // 
            this.txtNewSerialNumber.Location = new System.Drawing.Point(187, 266);
            this.txtNewSerialNumber.Name = "txtNewSerialNumber";
            this.txtNewSerialNumber.Size = new System.Drawing.Size(164, 20);
            this.txtNewSerialNumber.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 393);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNewSerialNumber);
            this.Controls.Add(this.BtnChangeSerialNumber);
            this.Controls.Add(this.btnGetHardDiskNumber);
            this.Controls.Add(this.rtxtDiskInformation);
            
            this.Name = "Form1";
            this.Text = "Disk Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDiskInformation;
        private System.Windows.Forms.Button btnGetHardDiskNumber;
        private System.Windows.Forms.Button BtnChangeSerialNumber;
        private System.Windows.Forms.TextBox txtNewSerialNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}


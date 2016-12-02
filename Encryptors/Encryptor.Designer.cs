namespace Encryptors
{
    partial class Encryptor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryptor));
            this.groupRequest = new System.Windows.Forms.GroupBox();
            this.txtTextToEncrypt = new System.Windows.Forms.TextBox();
            this.groupEncryptor = new System.Windows.Forms.GroupBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblEncryption = new System.Windows.Forms.Label();
            this.cmbEncryption = new System.Windows.Forms.ComboBox();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupRequest.SuspendLayout();
            this.groupEncryptor.SuspendLayout();
            this.groupResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRequest
            // 
            this.groupRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupRequest.Controls.Add(this.txtTextToEncrypt);
            this.groupRequest.Location = new System.Drawing.Point(12, 12);
            this.groupRequest.Name = "groupRequest";
            this.groupRequest.Size = new System.Drawing.Size(612, 279);
            this.groupRequest.TabIndex = 0;
            this.groupRequest.TabStop = false;
            this.groupRequest.Text = "Text to encrypt";
            // 
            // txtTextToEncrypt
            // 
            this.txtTextToEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToEncrypt.Location = new System.Drawing.Point(6, 21);
            this.txtTextToEncrypt.Multiline = true;
            this.txtTextToEncrypt.Name = "txtTextToEncrypt";
            this.txtTextToEncrypt.Size = new System.Drawing.Size(600, 252);
            this.txtTextToEncrypt.TabIndex = 0;
            // 
            // groupEncryptor
            // 
            this.groupEncryptor.Controls.Add(this.btnEncrypt);
            this.groupEncryptor.Controls.Add(this.lblEncryption);
            this.groupEncryptor.Controls.Add(this.cmbEncryption);
            this.groupEncryptor.Location = new System.Drawing.Point(12, 297);
            this.groupEncryptor.Name = "groupEncryptor";
            this.groupEncryptor.Size = new System.Drawing.Size(612, 64);
            this.groupEncryptor.TabIndex = 1;
            this.groupEncryptor.TabStop = false;
            this.groupEncryptor.Text = "Encryptor";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(475, 21);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(131, 24);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblEncryption
            // 
            this.lblEncryption.AutoSize = true;
            this.lblEncryption.Location = new System.Drawing.Point(6, 24);
            this.lblEncryption.Name = "lblEncryption";
            this.lblEncryption.Size = new System.Drawing.Size(79, 17);
            this.lblEncryption.TabIndex = 2;
            this.lblEncryption.Text = "Encryption:";
            // 
            // cmbEncryption
            // 
            this.cmbEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncryption.FormattingEnabled = true;
            this.cmbEncryption.Location = new System.Drawing.Point(118, 21);
            this.cmbEncryption.Name = "cmbEncryption";
            this.cmbEncryption.Size = new System.Drawing.Size(351, 24);
            this.cmbEncryption.TabIndex = 0;
            // 
            // groupResult
            // 
            this.groupResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupResult.Controls.Add(this.txtResult);
            this.groupResult.Location = new System.Drawing.Point(12, 367);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(612, 272);
            this.groupResult.TabIndex = 2;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(6, 21);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(600, 245);
            this.txtResult.TabIndex = 0;
            // 
            // Encryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 651);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.groupEncryptor);
            this.Controls.Add(this.groupRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(654, 698);
            this.MinimumSize = new System.Drawing.Size(654, 698);
            this.Name = "Encryptor";
            this.Text = "Encryptor";
            this.Load += new System.EventHandler(this.Encryptor_Load);
            this.groupRequest.ResumeLayout(false);
            this.groupRequest.PerformLayout();
            this.groupEncryptor.ResumeLayout(false);
            this.groupEncryptor.PerformLayout();
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupRequest;
        private System.Windows.Forms.TextBox txtTextToEncrypt;
        private System.Windows.Forms.GroupBox groupEncryptor;
        private System.Windows.Forms.Label lblEncryption;
        private System.Windows.Forms.ComboBox cmbEncryption;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnEncrypt;
    }
}


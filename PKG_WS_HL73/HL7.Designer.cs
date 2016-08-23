namespace PKG_WS_HL73
{
    partial class HL7
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
            this.btn_SUBMIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SUBMIT
            // 
            this.btn_SUBMIT.Location = new System.Drawing.Point(109, 57);
            this.btn_SUBMIT.Name = "btn_SUBMIT";
            this.btn_SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.btn_SUBMIT.TabIndex = 0;
            this.btn_SUBMIT.Text = "OK";
            this.btn_SUBMIT.UseVisualStyleBackColor = true;
            // 
            // HL7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btn_SUBMIT);
            this.Name = "HL7";
            this.Text = "HL7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SUBMIT;
    }
}


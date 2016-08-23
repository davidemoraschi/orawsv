namespace WS_HOLAMUNDO
{
    partial class frm_HolaMundo
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
            this.btn_Currito = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Currito
            // 
            this.btn_Currito.Location = new System.Drawing.Point(49, 80);
            this.btn_Currito.Name = "btn_Currito";
            this.btn_Currito.Size = new System.Drawing.Size(205, 50);
            this.btn_Currito.TabIndex = 0;
            this.btn_Currito.Text = "Currito...dale al botoncito";
            this.btn_Currito.UseVisualStyleBackColor = true;
            this.btn_Currito.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(49, 54);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(205, 20);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.Text = "Almagesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tu nombre:";
            // 
            // frm_HolaMundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.btn_Currito);
            this.Name = "frm_HolaMundo";
            this.Text = "WS_HolaMundo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Currito;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label1;
    }
}


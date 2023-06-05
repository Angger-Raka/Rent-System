namespace CarRentAdmin.Helper
{
    partial class ErrOption
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbErr = new System.Windows.Forms.Label();
            this.BtnYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kesalahan!";
            // 
            // TbErr
            // 
            this.TbErr.AutoSize = true;
            this.TbErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbErr.Location = new System.Drawing.Point(13, 53);
            this.TbErr.Name = "TbErr";
            this.TbErr.Size = new System.Drawing.Size(48, 20);
            this.TbErr.TabIndex = 7;
            this.TbErr.Text = "TbErr";
            // 
            // BtnYes
            // 
            this.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnYes.FlatAppearance.BorderSize = 2;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.Location = new System.Drawing.Point(204, 116);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(75, 28);
            this.BtnYes.TabIndex = 8;
            this.BtnYes.Text = "Ok";
            this.BtnYes.UseVisualStyleBackColor = true;
            // 
            // ErrOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 174);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.TbErr);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrOption";
            this.Text = "ErrOption";
            this.Load += new System.EventHandler(this.ErrOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TbErr;
        private System.Windows.Forms.Button BtnYes;
    }
}
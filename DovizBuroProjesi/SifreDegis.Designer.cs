namespace DovizBuroProjesi
{
    partial class SifreDegis
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
            this.btndegis = new System.Windows.Forms.Button();
            this.txtyenisifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkullanıcı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndegis
            // 
            this.btndegis.Location = new System.Drawing.Point(211, 65);
            this.btndegis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btndegis.Name = "btndegis";
            this.btndegis.Size = new System.Drawing.Size(135, 32);
            this.btndegis.TabIndex = 0;
            this.btndegis.Text = "Değiştir";
            this.btndegis.UseVisualStyleBackColor = true;
            this.btndegis.Click += new System.EventHandler(this.btndegis_Click);
            // 
            // txtyenisifre
            // 
            this.txtyenisifre.Location = new System.Drawing.Point(136, 27);
            this.txtyenisifre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtyenisifre.Name = "txtyenisifre";
            this.txtyenisifre.Size = new System.Drawing.Size(210, 30);
            this.txtyenisifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Şifreniz :";
            // 
            // lblkullanıcı
            // 
            this.lblkullanıcı.AutoSize = true;
            this.lblkullanıcı.Location = new System.Drawing.Point(132, 75);
            this.lblkullanıcı.Name = "lblkullanıcı";
            this.lblkullanıcı.Size = new System.Drawing.Size(60, 22);
            this.lblkullanıcı.TabIndex = 5;
            this.lblkullanıcı.Text = "label3";
            this.lblkullanıcı.Visible = false;
            // 
            // SifreDegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(391, 127);
            this.Controls.Add(this.lblkullanıcı);
            this.Controls.Add(this.txtyenisifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndegis);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SifreDegis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegis";
            this.Load += new System.EventHandler(this.SifreDegis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndegis;
        private System.Windows.Forms.TextBox txtyenisifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkullanıcı;
    }
}
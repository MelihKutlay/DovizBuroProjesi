namespace DovizBuroProjesi
{
    partial class HesapGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.txtkullaniciad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI AD :";
            // 
            // btngirisyap
            // 
            this.btngirisyap.Location = new System.Drawing.Point(273, 142);
            this.btngirisyap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(112, 33);
            this.btngirisyap.TabIndex = 1;
            this.btngirisyap.Text = "GİRİŞ YAP";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // txtkullaniciad
            // 
            this.txtkullaniciad.Location = new System.Drawing.Point(199, 66);
            this.txtkullaniciad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtkullaniciad.Name = "txtkullaniciad";
            this.txtkullaniciad.Size = new System.Drawing.Size(186, 30);
            this.txtkullaniciad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE :";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(199, 104);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(186, 30);
            this.txtsifre.TabIndex = 4;
            // 
            // HesapGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 231);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkullaniciad);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HesapGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HesapGiris";
            this.Load += new System.EventHandler(this.HesapGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.TextBox txtkullaniciad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsifre;
    }
}
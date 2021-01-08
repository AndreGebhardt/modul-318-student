
namespace MeineTransportApp_06._01._2021
{
    partial class GoogleMaps
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSuche = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlz = new System.Windows.Forms.TextBox();
            this.textBoxStaat = new System.Windows.Forms.TextBox();
            this.textBoxStadt = new System.Windows.Forms.TextBox();
            this.textBoxStrasse = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.buttonSuche);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPlz);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxStaat);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxStadt);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxStrasse);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonSuche
            // 
            this.buttonSuche.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSuche.Location = new System.Drawing.Point(65, 314);
            this.buttonSuche.Name = "buttonSuche";
            this.buttonSuche.Size = new System.Drawing.Size(180, 72);
            this.buttonSuche.TabIndex = 8;
            this.buttonSuche.Text = "Suche";
            this.buttonSuche.UseVisualStyleBackColor = false;
            this.buttonSuche.Click += new System.EventHandler(this.buttonSuche_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "PLZ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Land/Kanton:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stadt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Strasse:";
            // 
            // textBoxPlz
            // 
            this.textBoxPlz.Location = new System.Drawing.Point(155, 202);
            this.textBoxPlz.Name = "textBoxPlz";
            this.textBoxPlz.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlz.TabIndex = 3;
            // 
            // textBoxStaat
            // 
            this.textBoxStaat.Location = new System.Drawing.Point(155, 160);
            this.textBoxStaat.Multiline = true;
            this.textBoxStaat.Name = "textBoxStaat";
            this.textBoxStaat.Size = new System.Drawing.Size(100, 23);
            this.textBoxStaat.TabIndex = 2;
            // 
            // textBoxStadt
            // 
            this.textBoxStadt.Location = new System.Drawing.Point(155, 63);
            this.textBoxStadt.Name = "textBoxStadt";
            this.textBoxStadt.Size = new System.Drawing.Size(100, 22);
            this.textBoxStadt.TabIndex = 1;
            // 
            // textBoxStrasse
            // 
            this.textBoxStrasse.Location = new System.Drawing.Point(155, 25);
            this.textBoxStrasse.Name = "textBoxStrasse";
            this.textBoxStrasse.Size = new System.Drawing.Size(100, 22);
            this.textBoxStrasse.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(500, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // GoogleMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GoogleMaps";
            this.Text = "GoogleMaps";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlz;
        private System.Windows.Forms.TextBox textBoxStaat;
        private System.Windows.Forms.TextBox textBoxStadt;
        private System.Windows.Forms.TextBox textBoxStrasse;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonSuche;
    }
}
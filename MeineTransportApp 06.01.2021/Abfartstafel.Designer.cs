
namespace MeineTransportApp_06._01._2021
{
    partial class abfarhtsTafel
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
            this.verbindungSuchen1 = new System.Windows.Forms.Button();
            this.dataGridViewabfahrt = new System.Windows.Forms.DataGridView();
            this.abfahrt9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nach9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinweis9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewabfahrt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Station:";
            // 
            // verbindungSuchen1
            // 
            this.verbindungSuchen1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verbindungSuchen1.Location = new System.Drawing.Point(452, 91);
            this.verbindungSuchen1.Name = "verbindungSuchen1";
            this.verbindungSuchen1.Size = new System.Drawing.Size(212, 92);
            this.verbindungSuchen1.TabIndex = 2;
            this.verbindungSuchen1.Text = "Verbindung suchen";
            this.verbindungSuchen1.UseVisualStyleBackColor = true;
         
            this.verbindungSuchen1.Click += new System.EventHandler(this.verbindungSuchen1_Click);
            // 
            // dataGridViewabfahrt
            // 
            this.dataGridViewabfahrt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewabfahrt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abfahrt9,
            this.nach9,
            this.gleis9,
            this.hinweis9});
            this.dataGridViewabfahrt.Location = new System.Drawing.Point(52, 234);
            this.dataGridViewabfahrt.Name = "dataGridViewabfahrt";
            this.dataGridViewabfahrt.RowHeadersWidth = 51;
            this.dataGridViewabfahrt.RowTemplate.Height = 24;
            this.dataGridViewabfahrt.Size = new System.Drawing.Size(612, 201);
            this.dataGridViewabfahrt.TabIndex = 3;
            // 
            // abfahrt9
            // 
            this.abfahrt9.HeaderText = "Abfahrt";
            this.abfahrt9.MinimumWidth = 6;
            this.abfahrt9.Name = "abfahrt9";
            this.abfahrt9.Width = 125;
            // 
            // nach9
            // 
            this.nach9.HeaderText = "Nach";
            this.nach9.MinimumWidth = 6;
            this.nach9.Name = "nach9";
            this.nach9.Width = 125;
            // 
            // gleis9
            // 
            this.gleis9.HeaderText = "Gleis";
            this.gleis9.MinimumWidth = 6;
            this.gleis9.Name = "gleis9";
            this.gleis9.Width = 125;
            // 
            // hinweis9
            // 
            this.hinweis9.HeaderText = "Hinweis";
            this.hinweis9.MinimumWidth = 6;
            this.hinweis9.Name = "hinweis9";
            this.hinweis9.Width = 125;
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(137, 106);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(228, 24);
            this.comboBoxStation.TabIndex = 5;
            
            // 
            // abfarhtsTafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.comboBoxStation);
            this.Controls.Add(this.dataGridViewabfahrt);
            this.Controls.Add(this.verbindungSuchen1);
            this.Controls.Add(this.label1);
            this.Name = "abfarhtsTafel";
            this.Text = "Abfahrtstafel 1.0";
            this.Load += new System.EventHandler(this.abfarhtsTafel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewabfahrt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verbindungSuchen1;
        private System.Windows.Forms.DataGridView dataGridViewabfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrt9;
        private System.Windows.Forms.DataGridViewTextBoxColumn nach9;
        private System.Windows.Forms.DataGridViewTextBoxColumn gleis9;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinweis9;
        private System.Windows.Forms.ComboBox comboBoxStation;
    }
}
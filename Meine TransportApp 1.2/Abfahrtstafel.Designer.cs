
namespace Meine_TransportApp_1._2
{
    partial class abfahrt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tafel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.suchenButton = new System.Windows.Forms.Button();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.abfahrt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nach1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinweis2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tafel)).BeginInit();
            this.SuspendLayout();
            // 
            // tafel
            // 
            this.tafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abfahrt2,
            this.nach1,
            this.gleis2,
            this.hinweis2});
            this.tafel.Location = new System.Drawing.Point(12, 180);
            this.tafel.Name = "tafel";
            this.tafel.RowHeadersWidth = 51;
            this.tafel.RowTemplate.Height = 24;
            this.tafel.Size = new System.Drawing.Size(615, 255);
            this.tafel.TabIndex = 0;
            this.tafel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tafel_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Station:";
            // 
            // suchenButton
            // 
            this.suchenButton.Location = new System.Drawing.Point(491, 68);
            this.suchenButton.Name = "suchenButton";
            this.suchenButton.Size = new System.Drawing.Size(136, 78);
            this.suchenButton.TabIndex = 3;
            this.suchenButton.Text = "Suchen";
            this.suchenButton.UseVisualStyleBackColor = true;
            this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(163, 72);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(235, 24);
            this.comboBoxName.TabIndex = 4;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // abfahrt2
            // 
            this.abfahrt2.HeaderText = "Abfahrt";
            this.abfahrt2.MinimumWidth = 6;
            this.abfahrt2.Name = "abfahrt2";
            this.abfahrt2.Width = 125;
            // 
            // nach1
            // 
            this.nach1.HeaderText = "Nach";
            this.nach1.MinimumWidth = 6;
            this.nach1.Name = "nach1";
            this.nach1.Width = 125;
            // 
            // gleis2
            // 
            this.gleis2.HeaderText = "Gleis";
            this.gleis2.MinimumWidth = 6;
            this.gleis2.Name = "gleis2";
            this.gleis2.Width = 125;
            // 
            // hinweis2
            // 
            this.hinweis2.HeaderText = "Hinweis";
            this.hinweis2.MinimumWidth = 6;
            this.hinweis2.Name = "hinweis2";
            this.hinweis2.Width = 125;
            // 
            // abfahrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.suchenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tafel);
            this.Name = "abfahrt";
            this.Text = "Meine Transport-App / Abfartstafel";
            ((System.ComponentModel.ISupportInitialize)(this.tafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tafel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nach1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gleis2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinweis2;
    }
}


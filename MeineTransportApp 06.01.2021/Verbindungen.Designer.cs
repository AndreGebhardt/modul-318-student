
namespace MeineTransportApp_06._01._2021
{
    partial class Verbindungen
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
            this.verbindungSuchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewVerbindungen = new System.Windows.Forms.DataGridView();
            this.abfahrt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinweis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.abfahrtsButton = new System.Windows.Forms.Button();
            this.comboBoxNach = new System.Windows.Forms.ComboBox();
            this.comboBoxStart = new System.Windows.Forms.ComboBox();
            this.googlebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // verbindungSuchen
            // 
            this.verbindungSuchen.BackColor = System.Drawing.Color.SteelBlue;
            this.verbindungSuchen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verbindungSuchen.Location = new System.Drawing.Point(127, 236);
            this.verbindungSuchen.Name = "verbindungSuchen";
            this.verbindungSuchen.Size = new System.Drawing.Size(447, 57);
            this.verbindungSuchen.TabIndex = 0;
            this.verbindungSuchen.Text = "Verbindung suchen";
            this.verbindungSuchen.UseVisualStyleBackColor = false;
            this.verbindungSuchen.Click += new System.EventHandler(this.verbindungSuchen_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zeit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Von:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nach:";
            // 
            // dataGridViewVerbindungen
            // 
            this.dataGridViewVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abfahrt1,
            this.dauer,
            this.gleis,
            this.ankunft1,
            this.hinweis});
            this.dataGridViewVerbindungen.Location = new System.Drawing.Point(9, 332);
            this.dataGridViewVerbindungen.Name = "dataGridViewVerbindungen";
            this.dataGridViewVerbindungen.RowHeadersWidth = 51;
            this.dataGridViewVerbindungen.RowTemplate.Height = 24;
            this.dataGridViewVerbindungen.Size = new System.Drawing.Size(713, 189);
            this.dataGridViewVerbindungen.TabIndex = 9;
            // 
            // abfahrt1
            // 
            this.abfahrt1.HeaderText = "Abfahrt";
            this.abfahrt1.MinimumWidth = 6;
            this.abfahrt1.Name = "abfahrt1";
            this.abfahrt1.Width = 125;
            // 
            // dauer
            // 
            this.dauer.HeaderText = "Dauer";
            this.dauer.MinimumWidth = 6;
            this.dauer.Name = "dauer";
            this.dauer.Width = 125;
            // 
            // gleis
            // 
            this.gleis.HeaderText = "Gleis";
            this.gleis.MinimumWidth = 6;
            this.gleis.Name = "gleis";
            this.gleis.Width = 125;
            // 
            // ankunft1
            // 
            this.ankunft1.HeaderText = "Ankunft";
            this.ankunft1.MinimumWidth = 6;
            this.ankunft1.Name = "ankunft1";
            this.ankunft1.Width = 125;
            // 
            // hinweis
            // 
            this.hinweis.HeaderText = "Hinweis";
            this.hinweis.MinimumWidth = 6;
            this.hinweis.Name = "hinweis";
            this.hinweis.Width = 125;
            // 
            // datum
            // 
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum.Location = new System.Drawing.Point(129, 98);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(126, 22);
            this.datum.TabIndex = 10;
            this.datum.Value = new System.DateTime(2021, 1, 6, 14, 38, 32, 0);
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(440, 94);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(134, 22);
            this.time.TabIndex = 11;
            // 
            // abfahrtsButton
            // 
            this.abfahrtsButton.BackColor = System.Drawing.Color.Khaki;
            this.abfahrtsButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abfahrtsButton.Location = new System.Drawing.Point(129, 12);
            this.abfahrtsButton.Name = "abfahrtsButton";
            this.abfahrtsButton.Size = new System.Drawing.Size(216, 37);
            this.abfahrtsButton.TabIndex = 12;
            this.abfahrtsButton.Text = "Abfahrtstafel";
            this.abfahrtsButton.UseVisualStyleBackColor = false;
            this.abfahrtsButton.Click += new System.EventHandler(this.abfahrtsButton_Click);
            // 
            // comboBoxNach
            // 
            this.comboBoxNach.FormattingEnabled = true;
            this.comboBoxNach.Location = new System.Drawing.Point(440, 161);
            this.comboBoxNach.Name = "comboBoxNach";
            this.comboBoxNach.Size = new System.Drawing.Size(134, 24);
            this.comboBoxNach.TabIndex = 15;
            this.comboBoxNach.TextChanged += new System.EventHandler(this.comboBoxNach_TextChanged);
            // 
            // comboBoxStart
            // 
            this.comboBoxStart.FormattingEnabled = true;
            this.comboBoxStart.Location = new System.Drawing.Point(127, 161);
            this.comboBoxStart.Name = "comboBoxStart";
            this.comboBoxStart.Size = new System.Drawing.Size(128, 24);
            this.comboBoxStart.TabIndex = 16;
            this.comboBoxStart.TextChanged += new System.EventHandler(this.comboBoxStart_TextChanged);
            // 
            // googlebutton
            // 
            this.googlebutton.BackColor = System.Drawing.Color.Khaki;
            this.googlebutton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googlebutton.Location = new System.Drawing.Point(351, 12);
            this.googlebutton.Name = "googlebutton";
            this.googlebutton.Size = new System.Drawing.Size(223, 35);
            this.googlebutton.TabIndex = 17;
            this.googlebutton.Text = "Karte";
            this.googlebutton.UseVisualStyleBackColor = false;
            this.googlebutton.Click += new System.EventHandler(this.googlebutton_Click);
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(745, 540);
            this.Controls.Add(this.googlebutton);
            this.Controls.Add(this.comboBoxStart);
            this.Controls.Add(this.comboBoxNach);
            this.Controls.Add(this.abfahrtsButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.dataGridViewVerbindungen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verbindungSuchen);
            this.Name = "Verbindungen";
            this.Text = "Meine Transport-App / Verbindungen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verbindungSuchen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewVerbindungen;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunft1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinweis;
        private System.Windows.Forms.Button abfahrtsButton;
        private System.Windows.Forms.ComboBox comboBoxNach;
        private System.Windows.Forms.ComboBox comboBoxStart;
        private System.Windows.Forms.Button googlebutton;
    }
}


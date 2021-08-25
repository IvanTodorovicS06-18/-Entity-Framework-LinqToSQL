
namespace Domaci2
{
    partial class Form1
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
            this.cboServisZaDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteServis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKlijentZaDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gridServisList = new System.Windows.Forms.DataGridView();
            this.gridKlijentList = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbKlijentUpdate = new System.Windows.Forms.GroupBox();
            this.cboKlijentID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.txtUKomentar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUKontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURegBroj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbServisUpdate = new System.Windows.Forms.GroupBox();
            this.cboServisId = new System.Windows.Forms.ComboBox();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.dtUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUNazivKlijenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijentList)).BeginInit();
            this.gbKlijentUpdate.SuspendLayout();
            this.gbServisUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboServisZaDelete
            // 
            this.cboServisZaDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServisZaDelete.FormattingEnabled = true;
            this.cboServisZaDelete.Location = new System.Drawing.Point(1251, 330);
            this.cboServisZaDelete.Name = "cboServisZaDelete";
            this.cboServisZaDelete.Size = new System.Drawing.Size(121, 21);
            this.cboServisZaDelete.TabIndex = 25;
            // 
            // btnDeleteServis
            // 
            this.btnDeleteServis.Location = new System.Drawing.Point(1251, 357);
            this.btnDeleteServis.Name = "btnDeleteServis";
            this.btnDeleteServis.Size = new System.Drawing.Size(121, 30);
            this.btnDeleteServis.TabIndex = 24;
            this.btnDeleteServis.Text = "Izbrisi servis";
            this.btnDeleteServis.UseVisualStyleBackColor = true;
            this.btnDeleteServis.Click += new System.EventHandler(this.btnDeleteServis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1199, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "servisID:";
            // 
            // cboKlijentZaDelete
            // 
            this.cboKlijentZaDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKlijentZaDelete.FormattingEnabled = true;
            this.cboKlijentZaDelete.Location = new System.Drawing.Point(444, 312);
            this.cboKlijentZaDelete.Name = "cboKlijentZaDelete";
            this.cboKlijentZaDelete.Size = new System.Drawing.Size(121, 21);
            this.cboKlijentZaDelete.TabIndex = 22;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(444, 339);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(121, 29);
            this.btnDeleteClient.TabIndex = 21;
            this.btnDeleteClient.Text = "Izbrisi klijenta";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "KlijentID:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(155, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(131, 51);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gridServisList
            // 
            this.gridServisList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServisList.Location = new System.Drawing.Point(835, 92);
            this.gridServisList.Name = "gridServisList";
            this.gridServisList.Size = new System.Drawing.Size(537, 194);
            this.gridServisList.TabIndex = 18;
            // 
            // gridKlijentList
            // 
            this.gridKlijentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKlijentList.Location = new System.Drawing.Point(14, 92);
            this.gridKlijentList.Name = "gridKlijentList";
            this.gridKlijentList.Size = new System.Drawing.Size(576, 194);
            this.gridKlijentList.TabIndex = 17;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(121, 51);
            this.btnRead.TabIndex = 16;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // gbKlijentUpdate
            // 
            this.gbKlijentUpdate.Controls.Add(this.label10);
            this.gbKlijentUpdate.Controls.Add(this.txtUNazivKlijenta);
            this.gbKlijentUpdate.Controls.Add(this.cboKlijentID);
            this.gbKlijentUpdate.Controls.Add(this.label6);
            this.gbKlijentUpdate.Controls.Add(this.btnUpdateClient);
            this.gbKlijentUpdate.Controls.Add(this.txtUKomentar);
            this.gbKlijentUpdate.Controls.Add(this.label4);
            this.gbKlijentUpdate.Controls.Add(this.txtUKontakt);
            this.gbKlijentUpdate.Controls.Add(this.label3);
            this.gbKlijentUpdate.Controls.Add(this.txtURegBroj);
            this.gbKlijentUpdate.Controls.Add(this.label9);
            this.gbKlijentUpdate.Location = new System.Drawing.Point(31, 312);
            this.gbKlijentUpdate.Name = "gbKlijentUpdate";
            this.gbKlijentUpdate.Size = new System.Drawing.Size(355, 353);
            this.gbKlijentUpdate.TabIndex = 27;
            this.gbKlijentUpdate.TabStop = false;
            this.gbKlijentUpdate.Text = "Klijent update";
            // 
            // cboKlijentID
            // 
            this.cboKlijentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKlijentID.FormattingEnabled = true;
            this.cboKlijentID.Location = new System.Drawing.Point(106, 35);
            this.cboKlijentID.Name = "cboKlijentID";
            this.cboKlijentID.Size = new System.Drawing.Size(160, 21);
            this.cboKlijentID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Naziv klijenta:";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(124, 260);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(113, 40);
            this.btnUpdateClient.TabIndex = 8;
            this.btnUpdateClient.Text = "Update client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // txtUKomentar
            // 
            this.txtUKomentar.Location = new System.Drawing.Point(106, 162);
            this.txtUKomentar.MaxLength = 200;
            this.txtUKomentar.Multiline = true;
            this.txtUKomentar.Name = "txtUKomentar";
            this.txtUKomentar.Size = new System.Drawing.Size(222, 74);
            this.txtUKomentar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodatni komentar:";
            // 
            // txtUKontakt
            // 
            this.txtUKontakt.Location = new System.Drawing.Point(106, 119);
            this.txtUKontakt.MaxLength = 40;
            this.txtUKontakt.Name = "txtUKontakt";
            this.txtUKontakt.Size = new System.Drawing.Size(160, 20);
            this.txtUKontakt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kontakt:";
            // 
            // txtURegBroj
            // 
            this.txtURegBroj.Location = new System.Drawing.Point(106, 86);
            this.txtURegBroj.MaxLength = 20;
            this.txtURegBroj.Name = "txtURegBroj";
            this.txtURegBroj.Size = new System.Drawing.Size(160, 20);
            this.txtURegBroj.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Registarski broj:";
            // 
            // gbServisUpdate
            // 
            this.gbServisUpdate.Controls.Add(this.cboServisId);
            this.gbServisUpdate.Controls.Add(this.btnUpdateService);
            this.gbServisUpdate.Controls.Add(this.dtUpdateDate);
            this.gbServisUpdate.Controls.Add(this.txtUpdateOpis);
            this.gbServisUpdate.Controls.Add(this.label5);
            this.gbServisUpdate.Controls.Add(this.label7);
            this.gbServisUpdate.Controls.Add(this.label8);
            this.gbServisUpdate.Location = new System.Drawing.Point(824, 333);
            this.gbServisUpdate.Name = "gbServisUpdate";
            this.gbServisUpdate.Size = new System.Drawing.Size(378, 279);
            this.gbServisUpdate.TabIndex = 28;
            this.gbServisUpdate.TabStop = false;
            this.gbServisUpdate.Text = "Servis update";
            // 
            // cboServisId
            // 
            this.cboServisId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServisId.FormattingEnabled = true;
            this.cboServisId.Location = new System.Drawing.Point(106, 37);
            this.cboServisId.Name = "cboServisId";
            this.cboServisId.Size = new System.Drawing.Size(94, 21);
            this.cboServisId.TabIndex = 13;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(138, 200);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(113, 40);
            this.btnUpdateService.TabIndex = 11;
            this.btnUpdateService.Text = "Update service";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // dtUpdateDate
            // 
            this.dtUpdateDate.Location = new System.Drawing.Point(106, 66);
            this.dtUpdateDate.Name = "dtUpdateDate";
            this.dtUpdateDate.Size = new System.Drawing.Size(200, 20);
            this.dtUpdateDate.TabIndex = 10;
            // 
            // txtUpdateOpis
            // 
            this.txtUpdateOpis.Location = new System.Drawing.Point(106, 105);
            this.txtUpdateOpis.MaxLength = 400;
            this.txtUpdateOpis.Multiline = true;
            this.txtUpdateOpis.Name = "txtUpdateOpis";
            this.txtUpdateOpis.Size = new System.Drawing.Size(222, 74);
            this.txtUpdateOpis.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Opis usluga:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Datum servisa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "servisID:";
            // 
            // txtUNazivKlijenta
            // 
            this.txtUNazivKlijenta.Location = new System.Drawing.Point(106, 62);
            this.txtUNazivKlijenta.Name = "txtUNazivKlijenta";
            this.txtUNazivKlijenta.Size = new System.Drawing.Size(160, 20);
            this.txtUNazivKlijenta.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "KlijentID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 658);
            this.Controls.Add(this.gbServisUpdate);
            this.Controls.Add(this.gbKlijentUpdate);
            this.Controls.Add(this.cboServisZaDelete);
            this.Controls.Add(this.btnDeleteServis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboKlijentZaDelete);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gridServisList);
            this.Controls.Add(this.gridKlijentList);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridServisList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijentList)).EndInit();
            this.gbKlijentUpdate.ResumeLayout(false);
            this.gbKlijentUpdate.PerformLayout();
            this.gbServisUpdate.ResumeLayout(false);
            this.gbServisUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboServisZaDelete;
        private System.Windows.Forms.Button btnDeleteServis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKlijentZaDelete;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView gridServisList;
        private System.Windows.Forms.DataGridView gridKlijentList;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox gbKlijentUpdate;
        private System.Windows.Forms.ComboBox cboKlijentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.TextBox txtUKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUKontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURegBroj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbServisUpdate;
        private System.Windows.Forms.ComboBox cboServisId;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.DateTimePicker dtUpdateDate;
        private System.Windows.Forms.TextBox txtUpdateOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUNazivKlijenta;
    }
}


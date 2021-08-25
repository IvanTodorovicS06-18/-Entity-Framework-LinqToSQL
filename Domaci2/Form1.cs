using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domaci2
{
    public partial class Form1 : Form
    {
        DataEntity db = new DataEntity();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            gridKlijentList.DataSource = db.klijenti.ToList<Klijent>();
            gridServisList.DataSource = db.servisi.ToList<Servis>();

            foreach (Control ku in gbKlijentUpdate.Controls)
            {
                ku.DataBindings.Clear();
            }
              
            foreach (Control su in gbServisUpdate.Controls)
            {
              su.DataBindings.Clear();
            }
                
                

            cboKlijentZaDelete.DataSource = gridKlijentList.DataSource;
            cboKlijentZaDelete.DisplayMember = "klijentID";
            cboKlijentZaDelete.ValueMember = "klijentID";

            cboServisZaDelete.DataSource = gridServisList.DataSource;
            cboServisZaDelete.DisplayMember = "servisID";
            cboServisZaDelete.ValueMember = "servisID";

            Cursor = Cursors.Default;
            //Klijent
            cboKlijentID.DataSource = gridKlijentList.DataSource;
            cboKlijentID.DisplayMember = "klijentID";
            cboKlijentID.ValueMember = "klijentID";

            txtUNazivKlijenta.DataBindings.Add("Text", gridKlijentList.DataSource, "nazivKlijenta");
            txtURegBroj.DataBindings.Add("Text", gridKlijentList.DataSource, "registarskiBroj");
            txtUKontakt.DataBindings.Add("Text", gridKlijentList.DataSource, "Kontakt");
            txtUKomentar.DataBindings.Add("Text", gridKlijentList.DataSource, "dodatniKomentar");

            //Servis

            cboServisId.DataSource = gridServisList.DataSource;
            cboServisId.DisplayMember = "servisID";
            cboServisId.ValueMember = "servisID";

            dtUpdateDate.DataBindings.Add("Text", gridServisList.DataSource, "datumServisa");
            txtUpdateOpis.DataBindings.Add("Text", gridServisList.DataSource, "opisUsluge");


          
          

        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(cboKlijentZaDelete.SelectedValue);
                Klijent klijent = db.klijenti.SingleOrDefault(k => k.klijentID == id);
                Servis servis = db.servisi.SingleOrDefault(s => s.klijentID == klijent.klijentID);

                if (servis == null)
                {
                    db.klijenti.Remove(klijent);
                    db.SaveChanges();
                    db.Dispose();

                    db = new DataEntity();
                    btnRead_Click(null, null);

                    MessageBox.Show("Uspesno ste obrisali klijenta", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Klijent " + klijent.nazivKlijenta + " ne moze biti obrisan!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteServis_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboServisZaDelete.SelectedValue);
                Servis ser = db.servisi.SingleOrDefault(x => x.servisID == id);

                db.servisi.Remove(ser);
                db.SaveChanges();
                db.Dispose();
                db = new DataEntity();

                btnRead_Click(null, null);

                MessageBox.Show("Uspesno ste obrisali servis", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertForm insert = new InsertForm();
            insert.ShowDialog();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboKlijentID.SelectedValue);
                Klijent updateK = db.klijenti.SingleOrDefault(k => k.klijentID == id);

                updateK.klijentID = id;
                updateK.nazivKlijenta = txtUNazivKlijenta.Text;
                updateK.registarskiBroj = txtURegBroj.Text;
                updateK.Kontakt = txtUKontakt.Text;
                updateK.dodatniKomentar = txtUKomentar.Text;

                db.SaveChanges();
                btnRead_Click(null, null);

                MessageBox.Show("Klijent je azuriran", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.Dispose(); 
                db = new DataEntity();

            }
            catch (DbEntityValidationException efex)
            {
                foreach (DbEntityValidationResult s in efex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
                db.Dispose(); 
                db = new DataEntity();
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboServisId.SelectedValue);
                Servis updateS = db.servisi.SingleOrDefault(s => s.servisID == id);

                updateS.servisID = id;
                updateS.datumServisa = dtUpdateDate.Value;
                updateS.opisUsluge = txtUpdateOpis.Text;

                db.SaveChanges();
                btnRead_Click(null, null);

                MessageBox.Show("Servis je azuriran", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.Dispose(); 
                db = new DataEntity();
            }
            catch (DbEntityValidationException efex)
            {
                foreach (DbEntityValidationResult s in efex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }

                }
                db.Dispose(); 
                db = new DataEntity();
            }
        }
    }
}

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
    public partial class InsertForm : Form
    {
        DataEntity db = new DataEntity();
        public InsertForm()
        {
            InitializeComponent();
        }

        private void btnInsertKlijenti_Click(object sender, EventArgs e)
        {
            try
            {
                Klijent newKlijent = new Klijent { nazivKlijenta = txtNazivKlijenta.Text, registarskiBroj = txtRegBroj.Text, Kontakt = txtKontakt.Text, dodatniKomentar = txtKomentar.Text };
                db.klijenti.Add(newKlijent);
                db.SaveChanges();

                MessageBox.Show("Novi klijent je dodat", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbKlijentId.DataSource = db.klijenti.ToList<Klijent>();
                cmbKlijentId.DisplayMember = "klijentID";
                cmbKlijentId.ValueMember = "klijentID";

                db.Dispose(); // brisanje reference na objekat
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
                db.Dispose(); // brisanje reference na objekat
                db = new DataEntity();
            }
        }

        private void btnInsertServis_Click(object sender, EventArgs e)
        {
         
            try
            {
                Servis newServis = new Servis { klijentID = Convert.ToInt32(cmbKlijentId.Text), datumServisa = dtServis.Value, opisUsluge = txtOpis.Text };

                db.servisi.Add(newServis);
                db.SaveChanges();

                MessageBox.Show("Novi servis je dodat", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                db.Dispose(); // brisanje reference na objekat
                db = new DataEntity();
            }
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            cmbKlijentId.DataSource = db.klijenti.ToList<Klijent>();
            cmbKlijentId.DisplayMember = "klijentID";
            cmbKlijentId.ValueMember = "klijentID";
        }
    }
}

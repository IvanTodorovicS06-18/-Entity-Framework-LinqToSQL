using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domaci1
{
    public partial class Form1 : Form
    {
        DomaciLinqDataContext dataContext = new DomaciLinqDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                gridRead.DataSource = dataContext.PRead();

                foreach (Control con in gbUpdate.Controls)
                {
                 con.DataBindings.Clear();
                }
                  
                txtUpSuplierID.DataBindings.Add("Text", gridRead.DataSource, "supplierid");
                txtUpCompanyName.DataBindings.Add("Text", gridRead.DataSource, "companyname");
                txtUpContactName.DataBindings.Add("Text", gridRead.DataSource, "contactname");
                txtUpContactTitle.DataBindings.Add("Text", gridRead.DataSource, "contacttitle");
                txtUpAddress.DataBindings.Add("Text", gridRead.DataSource, "address");
                txtUpCity.DataBindings.Add("Text", gridRead.DataSource, "city");
                txtUpRegion.DataBindings.Add("Text", gridRead.DataSource, "region");
                txtUpPostalCode.DataBindings.Add("Text", gridRead.DataSource, "postalcode");
                txtUpCountry.DataBindings.Add("Text", gridRead.DataSource, "country");
                txtUpPhone.DataBindings.Add("Text", gridRead.DataSource, "phone");
                txtUpFax.DataBindings.Add("Text", gridRead.DataSource, "fax");

                cboDelete.DataSource = dataContext.PRead();
                cboDelete.DisplayMember = "supplierid";
                cboDelete.ValueMember = "supplierid";
            }

          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
              
                dataContext = new DomaciLinqDataContext();

                if (txtCompanyName.Text.Trim() == "" || txtContactName.Text.Trim() == "" ||
                    txtContactTitle.Text.Trim() == "" || txtAddress.Text.Trim() == "" ||
                    txtCity.Text.Trim() == "" || txtRegion.Text.Trim() == "" ||
                    txtPostalCode.Text.Trim() == "" || txtCountry.Text.Trim() == "" ||
                    txtPhone.Text.Trim() == "" || txtFax.Text.Trim() == "")
                {
                    MessageBox.Show("Polja ne smeju biti prazna.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                 dataContext.PInsert
                     (
                       txtCompanyName.Text, txtContactName.Text, txtContactTitle.Text,
                       txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostalCode.Text,
                       txtCountry.Text, txtPhone.Text, txtFax.Text
                     );
                    MessageBox.Show("Uspesan unos", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    btnRead_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilterForm_Click(object sender, EventArgs e)
        {
            FilterForm ff = new FilterForm();
            ff.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Ret = 0;
                int supplierid = Convert.ToInt32(cboDelete.SelectedValue);
                Ret = dataContext.PDelete(supplierid);
                if (Ret > 0)
                {
                    throw new Exception("Ne mozete izbrisati red iz tabele");

                }

                btnRead_Click(null, null);
                MessageBox.Show("Uspesno obrisano!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
           
                int supplierid = Convert.ToInt32(txtUpSuplierID.Text);
                 dataContext.PUpdate(supplierid, txtUpCompanyName.Text, txtUpContactName.Text, txtUpContactTitle.Text,
                    txtUpAddress.Text, txtUpCity.Text, txtUpRegion.Text, txtUpPostalCode.Text, txtUpCountry.Text, txtUpPhone.Text, txtUpFax.Text);
                MessageBox.Show("Uspesan update");
                btnRead_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}


             




               



           

             

          



            

             



          
          
           
         

                


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
    public partial class FilterForm : Form
    {
        DomaciLinqDataContext dataContext = new DomaciLinqDataContext();
        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            var suppliers = from s in dataContext.Suppliers
                            select s;
            gridCityList.DataSource = suppliers;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCityList.Text.Trim() != "")
                {
                    var city = from s in dataContext.Suppliers
                               where s.city == txtCityList.Text
                               orderby s.supplierid ascending
                               select new
                               {
                                   s.supplierid,s.companyname,s.contactname,
                                   s.contacttitle,s.address,s.city,s.region,
                                   s.postalcode,s.country,s.phone,s.fax
                               };
                    gridCityList.DataSource = city;
                }
                else
                {
                    var suppliers = from s in dataContext.Suppliers
                                    select s;
                    gridCityList.DataSource = suppliers;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            var suppliers = from s in dataContext.Suppliers
                            select s;
            gridCityList.DataSource = suppliers;
        }
    }
}

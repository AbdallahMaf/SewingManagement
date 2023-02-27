using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelierCoutureGEST
{
    public partial class Modeles : Form
    {
        Functions Con;
        public Modeles()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void ShowModels()
        {
            string Query = "select * from Modeles";
            dgvListModels.DataSource = Con.GetData(Query);
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try { 
                if(tbModels.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Models = tbModels.Text;
                    string Query = "insert into Modeles values('{0}')";
                    Query = string.Format(Query, Models);
                    Con.SetData(Query);
                    ShowModels();
                    tbModels.Text = "";                }
            }
            catch(Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
        }

       
    }
}

using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBar
{
    public partial class FrmOperaciones : Form
    {
        private Table table;
        public FrmOperaciones(Table tableIn)
        {
            InitializeComponent();
            this.table = tableIn;
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Bar.ListString(table.OrderList));
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FrmAddDrink frm = new FrmAddDrink(table.OrderList, 0);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Bar.ListString(table.OrderList) + "\n" + table.Money);
            Bar.Money = table.Money;
            table.Close();
            Close();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            table.AddCar();

        }


    }
}

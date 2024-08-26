using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace FormsBar
{
    public partial class FrmMesas : Form
    {
        public FrmMesas()
        {
            InitializeComponent();


        }
        private void FrmMesas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(0));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(1));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(2));
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(3));
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(4));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(5));
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(6));
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(7));
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(8));
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(9));
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(10));
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(11));
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(12));
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(13));
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(14));
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(15));
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(16));
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(17));
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(18));
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            OpenOperations(Bar.GetTable(19));
        }

        private void OpenOperations(Table table)
        {
            FrmOperaciones frm = new FrmOperaciones(table);
            frm.ShowDialog();
        }

        private void btnAddDrinkInventory_Click(object sender, EventArgs e)
        {
            FrmAddDrink frm = new FrmAddDrink(Bar.Inventory, 1);
            frm.ShowDialog();
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Bar.ListString(Bar.Inventory));
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            FrmData frm = new FrmData();
            frm.ShowDialog();
        }

        private void btnEndMonth_Click(object sender, EventArgs e)
        {
            //DateTime.Now.ToString("MMMM").Remove(0,1).Insert(0, DateTime.Now.ToString("MMMM").ElementAt(0).ToString().ToUpper())
            ADO.CreateMonth();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            Thread timeThread;
            Thread moneyThread;

            timeThread = new Thread(UpdateClock);
            timeThread.IsBackground = true; // Permite que el hilo se cierre cuando se cierre la aplicación
            timeThread.Start();

            moneyThread = new Thread(UpdateMoney);
            moneyThread.IsBackground = true; // Permite que el hilo se cierre cuando se cierre la aplicación
            moneyThread.Start();
        }

        private void UpdateClock()
        {
            while (true)
            {
                this.Invoke(new Action(() =>
                {
                    this.lblTiempo.Text = DateTime.Now.ToString("HH:mm:ss");
                }));

                Thread.Sleep(2000);
            }
        }

        private void UpdateMoney()
        {
            while (true)
            {
                this.Invoke(new Action(() =>
                {
                    this.txtBarMoney.Text = Bar.Money.ToString();
                }));

                Thread.Sleep(5000);
            }
        }
    }
}

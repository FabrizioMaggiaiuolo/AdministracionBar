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
    public partial class FrmAddDrink : Form
    {
        List<EDrinks> list;
        int flagInventario;
        public FrmAddDrink(List<EDrinks> listPass, int flag)
        {
            InitializeComponent();
            list = listPass;
            flagInventario = flag;
        }

        private void FrmAddDrink_Load(object sender, EventArgs e)
        {

        }

        private void ckbFernet_CheckedChanged(object sender, EventArgs e)
        {
            cmbFernet.Enabled = true;
        }

        private void ckbCubaLibre_CheckedChanged(object sender, EventArgs e)
        {
            cmbCubaLibre.Enabled = true;
        }

        private void ckbWhiskey_CheckedChanged(object sender, EventArgs e)
        {
            cmbWhisky.Enabled = true;
        }

        private void ckbWine_CheckedChanged(object sender, EventArgs e)
        {
            cmbWine.Enabled = true;
        }

        private void ckbWater_CheckedChanged(object sender, EventArgs e)
        {
            cmbWater.Enabled = true;
        }

        private void ckbCoke_CheckedChanged(object sender, EventArgs e)
        {
            cmbCoke.Enabled = true;
        }

        private void ckbSprite_CheckedChanged(object sender, EventArgs e)
        {
            cmbSprite.Enabled = true;
        }

        private void ckbLemonade_CheckedChanged(object sender, EventArgs e)
        {
            cmbLemonade.Enabled = true;
        }



        //-------------------------------------------------------------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ckbFernet.Checked)
            {
                if(cmbFernet.SelectedIndex != -1)
                {
                    for (int i = 0; i < (cmbFernet.SelectedIndex + 1); i++)
                    {
                        if(flagInventario == 0)
                        {
                            if (!Bar.RevisarInventario(EDrinks.fernet))
                            {
                                MessageBox.Show("No hay mas fernet en el inventario");
                                break;
                            }
                        }
                        list.Add(EDrinks.fernet);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione alguna cantidad para continuar");
                }
                
            }
            if (ckbCubaLibre.Checked)
            {
                if (cmbCubaLibre.SelectedIndex != -1)
                {
                    for (int i = 0; i < (cmbCubaLibre.SelectedIndex + 1); i++)
                    {
                        if (flagInventario == 0)
                        {
                            if (!Bar.RevisarInventario(EDrinks.cubaLibre))
                            {
                                MessageBox.Show("No hay mas cuba libre en el inventario");
                                break;
                            }
                        }
                        list.Add(EDrinks.cubaLibre);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione alguna cantidad para continuar");
                }
                
            }
            if (ckbWhiskey.Checked)
            {
                if (cmbWhisky.SelectedIndex != -1)
                {
                    for (int i = 0; i < (cmbWhisky.SelectedIndex + 1); i++)
                    {
                        if (flagInventario == 0)
                        {
                            if (!Bar.RevisarInventario(EDrinks.whisky))
                            {
                                MessageBox.Show("No hay mas whisky en el inventario");
                                break;
                            }
                        }
                        list.Add(EDrinks.whisky);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione alguna cantidad para continuar");
                }
                
            }
            if (ckbWine.Checked)
            {
                if (cmbWine.SelectedIndex != -1)
                {
                    for (int i = 0; i < (cmbWine.SelectedIndex + 1); i++)
                    {
                        if (flagInventario == 0)
                        {
                            if (!Bar.RevisarInventario(EDrinks.wine))
                            {
                                MessageBox.Show("No hay mas vino en el inventario");
                                break;
                            }
                        }
                        list.Add(EDrinks.wine);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione alguna cantidad para continuar");
                }
                
            }
            if (ckbWater.Checked)
            {
                if (cmbWater.SelectedIndex != -1)
                {
                    for (int i = 0; i < (cmbWater.SelectedIndex + 1); i++)
                    {
                        if (flagInventario == 0)
                        {
                            if (!Bar.RevisarInventario(EDrinks.water))
                            {
                                MessageBox.Show("No hay mas agua en el inventario");
                                break;
                            }
                        }
                        list.Add(EDrinks.water);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione alguna cantidad para continuar");
                }
                
            }
            if (ckbCoke.Checked)
            {
                if (cmbCoke.SelectedIndex != -1)
                {
                    for (int i = 0; i < (cmbCoke.SelectedIndex + 1); i++)
                    {
                        if (flagInventario == 0)
                        {
                            if (!Bar.RevisarInventario(EDrinks.coke))
                            {
                                MessageBox.Show("No hay mas coca cola en el inventario");
                                break;
                            }
                        }
                        list.Add(EDrinks.coke);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione alguna cantidad para continuar");
                }
                
            }
            if (ckbSprite.Checked)
            {
                if (cmbSprite.SelectedIndex != -1)
                {
                    for (int i = 0; i < (cmbSprite.SelectedIndex + 1); i++)
                    {
                        if (flagInventario == 0)
                        {
                            if (!Bar.RevisarInventario(EDrinks.sprite))
                            {
                                MessageBox.Show("No hay mas sprite en el inventario");
                                break;
                            }
                        }
                        list.Add(EDrinks.sprite);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione alguna cantidad para continuar");
                }
                
            }
            if (ckbLemonade.Checked)
            {
                if (cmbLemonade.SelectedIndex != -1)
                {
                    for (int i = 0; i < (cmbLemonade.SelectedIndex + 1); i++)
                    {
                        if (flagInventario == 0)
                        {
                            if (!Bar.RevisarInventario(EDrinks.lemonade))
                            {
                                MessageBox.Show("No hay mas limonada en el inventario");
                                break;
                            }
                        }
                        list.Add(EDrinks.lemonade);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione alguna cantidad para continuar");
                }
                
            }

            Close();
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaDatosUsuario
{
    public partial class Form1 : Form
    {
        Stack DatosUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lblValidate.Text = "";
            DatosUsuario = new Stack();
            tbCount.Text = 0.ToString();
            tbArray.Text = "";
            tbOutput.Text = "";
            lblValidate.Text = "Pila creada correctamente";
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbInput.Text))
            {
                if(DatosUsuario != null)
                {
                    var count = 0;
                    var data = "";
                    tbCount.Text = 0.ToString();
                    DatosUsuario.Push(tbInput.Text);
                    foreach (var item in DatosUsuario)
                    {
                        count += 1;
                        data += item.ToString() + " "; 
                    }
                    tbCount.Text = count.ToString();
                    tbArray.Text = data;
                    tbInput.Text = "";
                    lblValidate.Text = "Dato creado correctamente";
                }
                else
                {
                    lblValidate.Text = "Debes crear la pila primero";
                }
            }
            else
            {
                lblValidate.Text = "Debes rellenar el dato de entrada";
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (DatosUsuario != null)
            {
                var count = 0;
                var data = "";
                tbCount.Text = 0.ToString();
                tbOutput.Text = DatosUsuario.Peek().ToString();
                DatosUsuario.Pop();
                foreach (var item in DatosUsuario)
                {
                    count += 1;
                    data += item.ToString() + " ";
                }
                tbCount.Text = count.ToString();
                tbArray.Text = data;
                tbInput.Text = "";
                lblValidate.Text = "Primer dato eliminado correctamente";
            }
            else
            {
                lblValidate.Text = "Debes crear la pila primero";
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if(DatosUsuario != null)
            {
                var count = DatosUsuario.Count;
                tbCount.Text = count.ToString();
                lblValidate.Text = "Datos contados correctamente";
            }
            else
            {
                lblValidate.Text = "Debes crear la pila primero";
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            if(DatosUsuario != null)
            {
                var top = DatosUsuario.Peek();
                tbTop.Text = top.ToString();
                lblValidate.Text = "Dato extraido correctamente";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(DatosUsuario != null)
            {
                string data = "";
                var copy = DatosUsuario;
                foreach (var item in copy)
                {
                    data += item.ToString() + " ";
                }
                DatosUsuario.Clear();
                tbCount.Text = 0.ToString();
                tbArray.Text = "";
                tbOutput.Text = data;
                lblValidate.Text = "Pila vaciada correctamente correctamente";
            }
            else
            {
                lblValidate.Text = "Debes crear la pila primero";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (DatosUsuario != null)
            {
            }
            else
            {
                lblValidate.Text = "Debes crear la pila primero";
            }
        }

        private void btnNeatArray_Click(object sender, EventArgs e)
        {
            if (DatosUsuario != null)
            {
                if(DatosUsuario.Count > 0)
                {
                    var data = "";
                    for (int i = DatosUsuario.Count - 1; i >= 0 ; i--)
                    {
                        data += DatosUsuario.ToArray()[i].ToString() + " ";
                    }
                    tbNeatArray.Text = data;
                }
            }
            else
            {
                lblValidate.Text = "Debes crear la pila primero";
            }
        }
    }
}

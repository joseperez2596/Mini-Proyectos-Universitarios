using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtNaturaleza.Enabled = false;
    }
    protected void cmdCalcular_Click(object sender, EventArgs e)
    {
        double m = 0;
        if (!double.TryParse(txtNumero.Text, out m))
        {
            txtNaturaleza.Text = "Debe insertar un numero valido.";
            return;
        }
            m = Convert.ToDouble(txtNumero.Text);
        

            if (m < 0)
            {
                txtNaturaleza.Text = "Negativo";
            }
            else
            {
                if (m > 0)
                {
                    txtNaturaleza.Text = "Positivo";
                }
                else
                {
                    if (m == 0)
                    {
                        txtNaturaleza.Text = "Cero";
                    }
                }
            }
        
        

    }
    protected void cmdLimpiar_Click(object sender, EventArgs e)
    {
        txtNumero.Text = "";
        txtNaturaleza.Text = "";
    }
}
using System;
using System.Collections.Generic;
using Gateware.Negocio;

namespace Gateware
{
    public partial class Exercicio01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExecutar01_Click(object sender, EventArgs e)
        {
            lblSolucao01.Text = $"Solução 001 - {Negocio.Exercicio01.Solucao01()}";

            upnExercicio01.Update();
        }

        protected void btnExecutar02_Click(object sender, EventArgs e)
        {
            lblSolucao02.Text = $"Solução 002 - {Negocio.Exercicio01.Solucao02()}";

            upnExercicio01.Update();
        }
    }
}
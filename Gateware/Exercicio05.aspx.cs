using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gateware
{
    public partial class Exercicio05 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblSolucao.Text = $"Solução- {Negocio.Exercicio05.Executar()}";
            }
        }
    }
}
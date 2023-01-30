using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Pokedex_web
{
    // LISTO

    public partial class _default : System.Web.UI.Page
    {

        public List<Pokemon> ListaPokemon { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            ListaPokemon = negocio.listarConSP();


            // REPEATER
            if (!IsPostBack)
            {
            repRepetidor.DataSource = ListaPokemon;
            repRepetidor.DataBind();
            }
        }

        protected void btnEjemplo_Click(object sender, EventArgs e)
        {
            // Capturamos el dato (sender)

            string valor = ((Button)sender).CommandArgument;
        }
    }
}
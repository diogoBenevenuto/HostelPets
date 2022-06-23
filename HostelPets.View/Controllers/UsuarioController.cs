using Microsoft.AspNetCore.Mvc;
using HostelPets.View.Models;
using Microsoft.Data.SqlClient;

namespace HostelPets.View.Controllers
{
    public class UsuarioController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        //GET ACCOUNT
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=DESKTOP-0P8LOCH; database=HostelPets; integrated security = SSPI;";

        }
        [HttpPost]
        public IActionResult Verify(Usuarios acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from login where nome_cliente '" + acc.Name + "' and senha_cliente='" + acc.Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Sucess");
            }
            else
            {
                con.Close();
                return View("Error");
            }
        }
    }
}

            
 

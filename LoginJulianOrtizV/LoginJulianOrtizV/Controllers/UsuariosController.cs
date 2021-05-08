using LoginJulianOrtizV.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginJulianOrtizV.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Uusarios
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsuariosModel model)
        {
            String conectionString = "Data Source=localhost;" +
                                        "Initial catalog=LogginJulian;" +
                                        "User id=sa;" +
                                        "Password=M@ria0313";

            string query = "select * from tbl_login where username='" + model.UserName + "' and password='" + model.Password + "'";
            using (SqlConnection conexion = new SqlConnection(conectionString))
            {
                SqlCommand consulta = new SqlCommand(query, conexion);
                try
                {
                    conexion.Open();
                    SqlDataReader Veryfy = consulta.ExecuteReader();
                    if (Veryfy.Read())
                    {
                        UsuariosModel User = new UsuariosModel();
                        User.UserName = Veryfy[0].ToString();
                        
                        conexion.Close();
                        return View("Hellouser",User);
                    }

                    else
                    {
                        conexion.Close();
                        return View("error");
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
           
        }

        public ActionResult NewUser() 
        {


            return View();
        
        }

        [HttpPost]
        public ActionResult NewUser(UsuariosModel model)
        {
            String conectionString = "Data Source=localhost;" +
                                        "Initial catalog=LogginJulian;" +
                                        "User id=sa;" +
                                        "Password=M@ria0313";
            string query = "INSERT INTO [tbl_login] ([userName], [password], [email]) VALUES (" + "'" + model.UserName + "'" + "," + "'" + model.Password +"'"+","+ "'" + model.Email + "'" + ")";
            using (SqlConnection conexion = new SqlConnection(conectionString))
            {
                SqlCommand consulta = new SqlCommand(query, conexion);
                try
                {
                    conexion.Open();
                    consulta.ExecuteReader();
                    conexion.Dispose();
                    return Redirect("~/usuarios/");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public ActionResult Contacto()
        {
            return View();
        
        }


    }
}
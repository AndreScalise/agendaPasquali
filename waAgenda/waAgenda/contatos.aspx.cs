using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class contatos : System.Web.UI.Page
    {
        protected void ListView1_ItemInserted(object sender, ListViewInsertedEventArgs e)
        {

        }

        protected void SqlDataSourceContatos_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                Response.Write("<script> alert('Não foi possível incluir. Registro duplicado ou campo em branco.');</script>");
                e.ExceptionHandled = true;
            }
        }

        protected void SqlDataSourceContatos_Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                Response.Write("<script> alert('Não foi possível alterar. Erro: Campo em branco.');</script>");
                e.ExceptionHandled = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoWeb
{
    public partial class FormularioWeb : System.Web.UI.Page
    {
        private void cargarGridClienteReservaciones()
        {

            //-------------Código Linq---------------------

            BD_HOTELDataContext DataContext = new BD_HOTELDataContext();
            var consulta = from customer in DataContext.CLIENTES
                           join reservation in DataContext.RESERVACIONES
                           on customer.ID_CLIENTE equals reservation.ID_CLIENTE

                           select new
                           {
                               Nombre = customer.NOMBRE,
                               Teléfono = customer.TELEFONO,
                               Habitación = reservation.TIPOHABITACION,
                               Entrada= reservation.FECHAINGRESO,
                               Salida =reservation.FECHASALIDA
                           };

            grdClientes.DataSource = consulta;
            grdClientes.DataBind();

        }

        private void cargarCboNombres()
        {
            //-------------Código Linq---------------------

            BD_HOTELDataContext DataContext = new BD_HOTELDataContext();

            var consulta = from registroClientes in DataContext.CLIENTES
                           select new
                           {
                               registroClientes.ID_CLIENTE,
                               registroClientes.NOMBRE,
                               registroClientes.TELEFONO
                           };


            //--------------Fin Código LinQ----------------
            cboNombres.DataValueField = "NOMBRE";

            cboNombres.DataSource = consulta;
            cboNombres.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarCboNombres();
        }

        #region Método para cargar la tabla Clientes en el GridView

        private void cargarGridTodosLoaClientes()
        {
            //-------------Código Linq---------------------

            BD_HOTELDataContext DataContext = new BD_HOTELDataContext();
            var consulta = from customer in DataContext.CLIENTES
                           select new
                           {
                               ID = customer.ID_CLIENTE,
                               Name = customer.NOMBRE,
                               Phone = customer.TELEFONO,
                               Address = customer.DIRECCION
                           };

            //--------------Fin Código LinQ----------------

            //No es necesario crear un foreach porque solo se usa para mostrarlo, no usar especificamente algo
            grdClientes.DataSource = consulta;
            grdClientes.DataBind();
        }

        #endregion

        protected void btnEjemplo1_Click(object sender, EventArgs e)
        {
            cargarGridTodosLoaClientes();
        }

        protected void btnEjemplo2_Click(object sender, EventArgs e)
        {
            cargarGridClienteReservaciones();
        }
    }
}
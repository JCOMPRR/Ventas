using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto memoria = new Producto();
            memoria.Codigo = "001";
            memoria.Descripcion = "Memoria RAM";
            memoria.PrecioUnitario = 100.15m; //La "m" es para decir que es un decimal

            //Diferente manera (mas comoda)
            Producto discoDuro = new Producto()
            {
                Codigo = "002",
                Descripcion = "Disco duro 1T",
                PrecioUnitario = 520.40m
            };

            Producto laptop = new Producto()
            {
                Codigo = "003",
                Descripcion = "Laptop Huaweii",
                PrecioUnitario = 1260.10m
            };

            List<Producto> productos = new List<Producto>();
            productos.Add(memoria);
            productos.Add(discoDuro);
            productos.Add(laptop);

            dgvProductos.DataSource = productos;
        }
    }
}

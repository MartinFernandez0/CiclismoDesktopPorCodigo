using CiclismoDesktopPorCodigo.DatabaseModels.ModelosCiclismo;
using CiclismoDesktopPorCodigo.DatabaseModels.ModelosParticulares;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CiclismoDesktopPorCodigo.Views.LINQ
{
    public partial class PruebasLINQView : Form
    {
        #region Construimos un ArrayJSON

        JArray jsonArrayPeliculas = JArray.Parse("[\r\n  { \"title\": \"El laberinto del fauno\", \"director\": \"Guillermo del Toro\", \"year\": 2006, \"genre\": \"Fantasía\" },\r\n  { \"title\": \"Amores perros\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2000, \"genre\": \"Drama\" },\r\n  { \"title\": \"Mar adentro\", \"director\": \"Alejandro Amenábar\", \"year\": 2004, \"genre\": \"Drama\" },\r\n  { \"title\": \"Todo sobre mi madre\", \"director\": \"Pedro Almodóvar\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"El secreto de sus ojos\", \"director\": \"Juan José Campanella\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"Roma\", \"director\": \"Alfonso Cuarón\", \"year\": 2018, \"genre\": \"Drama\" },\r\n  { \"title\": \"Y tu mamá también\", \"director\": \"Alfonso Cuarón\", \"year\": 2001, \"genre\": \"Drama\" },\r\n  { \"title\": \"La lengua de las mariposas\", \"director\": \"José Luis Cuerda\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"Biutiful\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2010, \"genre\": \"Drama\" },\r\n  { \"title\": \"La vida secreta de las palabras\", \"director\": \"Isabel Coixet\", \"year\": 2005, \"genre\": \"Drama\" },\r\n  { \"title\": \"Relatos salvajes\", \"director\": \"Damián Szifron\", \"year\": 2014, \"genre\": \"Comedia negra\" },\r\n  { \"title\": \"Hable con ella\", \"director\": \"Pedro Almodóvar\", \"year\": 2002, \"genre\": \"Drama\" },\r\n  { \"title\": \"El orfanato\", \"director\": \"J.A. Bayona\", \"year\": 2007, \"genre\": \"Terror\" },\r\n  { \"title\": \"Volver\", \"director\": \"Pedro Almodóvar\", \"year\": 2006, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"Abre los ojos\", \"director\": \"Alejandro Amenábar\", \"year\": 1997, \"genre\": \"Ciencia ficción\" },\r\n  { \"title\": \"Celda 211\", \"director\": \"Daniel Monzón\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"El hijo de la novia\", \"director\": \"Juan José Campanella\", \"year\": 2001, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"El espinazo del diablo\", \"director\": \"Guillermo del Toro\", \"year\": 2001, \"genre\": \"Terror\" },\r\n  { \"title\": \"La piel que habito\", \"director\": \"Pedro Almodóvar\", \"year\": 2011, \"genre\": \"Thriller\" },\r\n  { \"title\": \"La historia oficial\", \"director\": \"Luis Puenzo\", \"year\": 1985, \"genre\": \"Drama\" }\r\n]\r\n");

        #endregion
        public PruebasLINQView()
        {
            InitializeComponent();
        }

        private void btnPruebaArray_Click(object sender, EventArgs e)
        {
            //Creamos un ARRAY de numeros
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            // Con LINQ filtramos los numeros pares y creamos un nuevo array
            var NumerosPares = (from num in numbers
                                where num % 2 == 0
                                select new { NumerosPares = num }).ToList();

            //Mostramos los numeros pares en el DataGridView
            dataGridResultados.DataSource = NumerosPares.ToList();

        }

        private void btnPruebaSQL_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoRenzo2Context())
            {
                var query = from Cliente in context.Clientes
                            select Cliente;

                dataGridResultados.DataSource = query.ToList();
            }

        }

        private void btnPruebasXML_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("D:\\MARTIN\\Programacion I\\C#\\CiclismoDesktopPorCodigo\\CiclismoDesktopPorCodigo\\Views\\XML\\Libros.xml");
            ;
            var libros = from book in doc.Descendants("book")
                         select new
                         {
                             title = book.Element("title")?.Value,
                             author = book.Element("author")?.Value,
                             year = book.Element("year")?.Value,
                             genre = book.Element("genre")?.Value,

                         };

            dataGridResultados.DataSource = libros.ToList();
        }

        private void bntJSON_Click(object sender, EventArgs e)
        {
            JArray jsonArrayPeliculas = JArray.Parse("[\r\n  { \"title\": \"El laberinto del fauno\", \"director\": \"Guillermo del Toro\", \"year\": 2006, \"genre\": \"Fantasía\" },\r\n  { \"title\": \"Amores perros\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2000, \"genre\": \"Drama\" },\r\n  { \"title\": \"Mar adentro\", \"director\": \"Alejandro Amenábar\", \"year\": 2004, \"genre\": \"Drama\" },\r\n  { \"title\": \"Todo sobre mi madre\", \"director\": \"Pedro Almodóvar\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"El secreto de sus ojos\", \"director\": \"Juan José Campanella\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"Roma\", \"director\": \"Alfonso Cuarón\", \"year\": 2018, \"genre\": \"Drama\" },\r\n  { \"title\": \"Y tu mamá también\", \"director\": \"Alfonso Cuarón\", \"year\": 2001, \"genre\": \"Drama\" },\r\n  { \"title\": \"La lengua de las mariposas\", \"director\": \"José Luis Cuerda\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"Biutiful\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2010, \"genre\": \"Drama\" },\r\n  { \"title\": \"La vida secreta de las palabras\", \"director\": \"Isabel Coixet\", \"year\": 2005, \"genre\": \"Drama\" },\r\n  { \"title\": \"Relatos salvajes\", \"director\": \"Damián Szifron\", \"year\": 2014, \"genre\": \"Comedia negra\" },\r\n  { \"title\": \"Hable con ella\", \"director\": \"Pedro Almodóvar\", \"year\": 2002, \"genre\": \"Drama\" },\r\n  { \"title\": \"El orfanato\", \"director\": \"J.A. Bayona\", \"year\": 2007, \"genre\": \"Terror\" },\r\n  { \"title\": \"Volver\", \"director\": \"Pedro Almodóvar\", \"year\": 2006, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"Abre los ojos\", \"director\": \"Alejandro Amenábar\", \"year\": 1997, \"genre\": \"Ciencia ficción\" },\r\n  { \"title\": \"Celda 211\", \"director\": \"Daniel Monzón\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"El hijo de la novia\", \"director\": \"Juan José Campanella\", \"year\": 2001, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"El espinazo del diablo\", \"director\": \"Guillermo del Toro\", \"year\": 2001, \"genre\": \"Terror\" },\r\n  { \"title\": \"La piel que habito\", \"director\": \"Pedro Almodóvar\", \"year\": 2011, \"genre\": \"Thriller\" },\r\n  { \"title\": \"La historia oficial\", \"director\": \"Luis Puenzo\", \"year\": 1985, \"genre\": \"Drama\" }\r\n]\r\n");


            var Peliculas = from Movie in jsonArrayPeliculas
                            select new
                            {
                                title = Movie["title"],
                                director = Movie["director"],
                                year = Movie["year"],
                                genre = Movie["genre"]
                            };

            dataGridResultados.DataSource = Peliculas.ToList();
        }

        private void btnPruebaSelect_Click(object sender, EventArgs e)
        {
            var Peliculas = jsonArrayPeliculas.Select(p => new
            {
                title = p["title"],
                director = p["director"],
                year = (int)p["year"],
                genre = p["genre"]

            }).ToList();

            dataGridResultados.DataSource = Peliculas.ToList();
        }

        private void btnPruebaWhere_Click(object sender, EventArgs e)
        {
            var pelis = jsonArrayPeliculas.ToObject<List<Peliculas>>();

            //Filtros

            //var peliculas = pelis.Where(p=>p.year > 2000);
            //var peliculas = pelis.Where(p => p.year.Equals(1985));
            //var peliculas = pelis.Where(p => p.year == 1985);
            //var peliculas = pelis.Where(p => p.genre == "Drama");

            var peliculas = pelis.Where(p => p.genre == "Drama" && p.year > 2000);

            dataGridResultados.DataSource = peliculas.ToList();
        }

        private void btnPruebaWhereAvanzado_Click(object sender, EventArgs e)
        {
            var pelis = jsonArrayPeliculas.ToObject<List<Peliculas>>();
            dataGridResultados.DataSource = pelis.Where
               (p => p.title.Contains(txtFiltro.Text) ||
                p.director.Contains(txtFiltro.Text) ||
                p.genre.Contains(txtFiltro.Text)).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoRenzo2Context())
            {
                var clientes = context.Clientes.OrderBy(c => c.Nombre).ToList();
                dataGridResultados.DataSource = clientes.ToList();
            }
        }

        private void txtOrderByAvanzado_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoRenzo2Context())
            {
                var clientes = context.Clientes.OrderBy(c => c.Pais).ThenBy(c => c.Nombre).ToList();
                dataGridResultados.DataSource = clientes.ToList();
            }
        }

        private void btnOffType_Click(object sender, EventArgs e)
        {
            //Creamos un array de objets
            object[] objects = [1, "San Justo", true, new string[] { "Hola Mundo" }, 5, "Crespo", 7.5f, 8, 9, 10];

            // Con LINQ filtramos los numeros pares y creamos un nuevo array
            var TextosEnArray = objects.OfType<string>().Select(S => new
            {
                Texto = S,
            });

            //Mostramos los numeros pares en el DataGridView
            dataGridResultados.DataSource = TextosEnArray;
        }

        private void btnPruebaSelectMany_Click(object sender, EventArgs e)
        {
            //Creamos un array de objets
            object[] objects = [1, "San Justo", true, new string[] { "Hola Mundo" }, 5, "Crespo", 7.5f, 8, 9, 10, new string[] { "Argentina" }];

            // Con LINQ filtramos los numeros pares y creamos un nuevo array
            var TextosEnArray = objects.OfType<string[]>().SelectMany(a => a).Select(S => new
            {
                Texto = S,
            });

            //Mostramos los numeros pares en el DataGridView
            dataGridResultados.DataSource = TextosEnArray.ToList();
        }
    }
}
using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;
using System.Diagnostics;

namespace NorthWind_WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.toolStripMenuPageDown.Click += (sender, e) =>
            {
                CurrentPage = CurrentPage > 0 ? CurrentPage - 1 : 0;
                //Display();
            };
        }

        ProductList Prds;

        BindingSource PrdBindingSource;

        private void toolStripMenuLoad_Click(object sender, EventArgs e)
        {
            try
            {
                Prds = ProductManager.SelectAllProducts();

                PrdBindingSource = new BindingSource(Prds, "");

                PrdBindingSource.AddingNew += (sender, e) => e.NewObject = new Product() { State = EntityState.Added };

               // var Prds = (from P in ProductManager.SelectAllProducts()
                 //          where P.UnitsInStock > 0
                   //       select P)
                     //     .Take(10)
                       //   .ToList();

                this.dataGridView1.DataSource = PrdBindingSource;
                //Prds;
            }
            catch
            {

            }
        }

        int CurrentPage = 0;

        public void Display() =>
        this.dataGridView1.DataSource = Prds.Skip(CurrentPage * 10).Take(10).ToList();

        int PageNum => (Prds.Count / 10) + 1;


        private void toolStripMenuSave_Click(object sender, EventArgs e)
        {
            //ProductManager.DeleteProductByID(1);
            foreach (var item in Prds)
            {
                Trace.WriteLine($"{item.ProductID} {item.State}");
            }


        }
        private void toolStripMenuPageUp_Click(object sender, EventArgs e)
        {
            CurrentPage++;

            if (CurrentPage >= PageNum) CurrentPage = 0;

            Display();
        }

        private void toolStripMenuPageDown_Click(object sender, EventArgs e)
        {
            CurrentPage--;

            if (CurrentPage >= PageNum) CurrentPage = CurrentPage-10;

            Display();
        }
    }
}

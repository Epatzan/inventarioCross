using invetarioCross.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace invetarioCross
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           var bodegas = InventarioDataBase.GetItemsNotDoneAsync("4007817328941");
            foreach (var stock in bodegas) {
                Debug.WriteLine(stock.CANTIDAD);
                Debug.WriteLine(stock.CODIGO_BODEGA);
                Debug.WriteLine(stock.CODIGO_IDENTIFICADOR);
                Debug.WriteLine(stock.CODIGO_PRODUCTO);
                Debug.WriteLine(stock.CODIGO_UBICACION);
                Debug.WriteLine(stock.CODIGO_UM);
            }
           
        }
    }
}

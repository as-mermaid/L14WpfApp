using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            products  = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                ProductName = "Яблоко",
                ProductImage = "Data/Apple.png",
                ProductPrice = 5.87,
                ProductCategory = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductImage = "Data/Bread.png",
                ProductPrice = 1.65,
                ProductCategory = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProductName = "Сыр",
                ProductImage = "Data/Cheese.png",
                ProductPrice = 10.32,
                ProductCategory = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProductName = "Утюг",
                ProductImage = "Data/Iron.png",
                ProductPrice = 25.74,
                ProductCategory = ProductCategories.Applinces
            });

            products.Add(new Product()
            {
                ProductName = "Миксер",
                ProductImage = "Data/Mixer.png",
                ProductPrice = 15.29,
                ProductCategory = ProductCategories.Applinces
            });

            products.Add(new Product()
            {
                ProductName = "Микроволноваы печь",
                ProductImage = "Data/Microwave.png",
                ProductPrice = 49.99,
                ProductCategory = ProductCategories.Applinces
            });

            listBox.ItemsSource = products;
        }
    }
}

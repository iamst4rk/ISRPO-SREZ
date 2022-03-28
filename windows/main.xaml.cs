using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
using iamst4rk.models;

namespace iamst4rk.windows
{
    /// <summary>
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Window
    {
        string token;
        List<reader> readers = new List<reader>();
        public main()
        {
            InitializeComponent();

        }
        public main(string token)
        {
            InitializeComponent();
            this.token = token;

            Data();
        }
        public async void Data(string search = "")
        {
            try
            {
                using (HttpClient httpClient = new HttpClient { BaseAddress = new Uri(Properties.Settings.Default.BaseAddress) })
                {

                    var reader = httpClient.GetStringAsync($"/GetReaders?token={token}");
                    readers = JsonSerializer.Deserialize<List<reader>>(reader.Result);
                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        readers = readers.Where(x => x.fio.ToLower().Contains(search.ToLower())).ToList();

                        if (readers.Count() == 0)
                        {
                            MessageBox.Show("Результаты не найдены", "Внимание", MessageBoxButton.OK);
                        }
                    }

                    LvReaders.ItemsSource = readers;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK);
            }

        }

        private void BtnLogout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var MbReault = MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButton.OKCancel);
            if (MbReault == MessageBoxResult.OK)
            {
                App.Current.Shutdown();
            }

        }

        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Программка чуточку не доделана)");
        }

        private void TbReaders_TextChanged(object sender, TextChangedEventArgs e)
        {
            Data(TbReaders.Text);
        }

        private void ImgBilet_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Программка чуточку не доделана)");
        }

        private void CSV_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Программка чуточку не доделана)");
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow loginPage = new MainWindow();
            loginPage.Show();
            this.Close();
        }
    }
}

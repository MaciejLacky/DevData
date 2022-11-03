using DevData.Helpers;
using DevData.Models;
using DevData.Services;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DevData.ViewModels
{
    public class WorkMainPageViewModel : INotifyPropertyChanged
    {
        #region Fields       
        private DataService _dataService;
        private List<ModelData> _listData;
        private string _login { get; set; }
        private string _password { get; set; }
        private bool _btnGetDataEnabled { get; set; }       
        #endregion
        #region Command
        public ICommand TestConnectionCommand { get; set; }
        public ICommand GetAllData { get; set; }
        #endregion
        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
        #region Properties
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public bool BtnGetDataEnabled
        {
            get { return _btnGetDataEnabled; }
            set { _btnGetDataEnabled = value; }
        }
        public List<ModelData> ListData
        {
            get { return _listData; }
            set { _listData = value; }
        }
        #endregion


        #region Constructor
        public WorkMainPageViewModel()
        { 
            TestConnectionCommand = new RelayCommand(TestConnectionDb);
            GetAllData = new RelayCommand(GetAllDataDb);
            _dataService = new DataService();
        }
        #endregion

        #region Methods
        private void TestConnectionDb()
        {          
            var connectionString = $"Server=DESKTOP-F3NJMD4\\SQLEXPRESS;Database=DevData;User Id={Login};password={Password};Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=False";
            //var connectionString = $"Server=DESKTOP-F3NJMD4\\SQLEXPRESS;Database=DevData;Trusted_Connection=True;";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Połączenie z bazą danych poprawne", "Połączenie", MessageBoxButton.OK, MessageBoxImage.Information);
                    BtnGetDataEnabled = true;
                    OnPropertyChanged("BtnGetDataEnabled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Brak połączenia z bazą danych {ex.Message}", "Połączenie", MessageBoxButton.OK, MessageBoxImage.Error);              
            }             
        }

        private void GetAllDataDb()
        {
            ListData = _dataService.GetAll();
            OnPropertyChanged("ListData");
        }

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}

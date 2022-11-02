using DevData.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DevData.ViewModels
{
    public class WorkMainPageViewModel
    {
        #region Fields
        public string Login { get; set; }
        public string Password { get; set; }
        public ICommand TestConnectionCommand { get; set; }
        #endregion

        #region Constructor
        public WorkMainPageViewModel()
        {
            TestConnectionCommand = new RelayCommand(TestConnectionDb);
        }
        #endregion

        #region Methods
        private void TestConnectionDb()
        {
            var lg = Login;
            var pass = Password;
        }
        private void GetAllData()
        {

        }
        #endregion

    }
}

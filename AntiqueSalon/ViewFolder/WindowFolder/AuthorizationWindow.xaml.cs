using AntiqueSalon.AppDataFolder.ModelFolder;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace AntiqueSalon.ViewFolder.WindowFolder
{
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        // Обработчик события работы над окном
        #region WindowsEddit
        private void SpaseBarGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RollUpButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        #endregion

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswordPasswordBox.Password == "")
            {
                MessageBox.Show("Поле или поля пустые, так не может быть", "Ошибка входа");
            }
            else
            {
                Entrance();
            }
        }

        public void Entrance()
        {
            try
            {
                var user = AppConnectClass.DataBase.WorkerTable.FirstOrDefault(
                    data => data.LoginWorker == LoginTextBox.Text &&
                    data.PasswordWorker == PasswordPasswordBox.Password);
                if (user == null)
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка входа");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка входа");
            }
        }
    }
}

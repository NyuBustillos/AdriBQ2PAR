using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AdriBQ2PAR.ViewModels
{
    class LoginViewModel:BaseViewModel
    {
        #region variables
        string correo;
        string password;
        bool isrunning;
        bool isenabled;
        #endregion
        #region propiedades
        public string Correo
        {
            get { return this.correo; }
            set { SetValue(ref this.correo, value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }
        public bool IsEnabled
        {
            get { return this.isenabled; }
            set { SetValue(ref this.isenabled, value); }
        }
        #endregion
        #region comandos
        public ICommand LoginCommand
        {
            get { return new RelayCommand(Login); }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(Correo))
            {
                await App.Current.MainPage.DisplayAlert("Correo vacío",
                                                  "Por favor ingrese correo",
                                                  "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Contraseña vacía",
                                                  "Por favor ingrese contraseña",
                                                  "Aceptar");
                return;
            }
            IsRunning = true;
        }

        #endregion



    }
}

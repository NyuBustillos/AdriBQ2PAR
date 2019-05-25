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
        string notas;
        bool isrunning;
        bool isenabled;
        #endregion
        #region propiedades
        public string Notas
        {
            get { return this.notas; }
            set { SetValue(ref this.notas, value); }
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
            if (string.IsNullOrEmpty(Notas))
            {
                await App.Current.MainPage.DisplayAlert("Nota vacía",
                                                  "Por favor ingrese Nota",
                                                  "Aceptar");
                return;
            }
            IsRunning = true;
        }

        #endregion




    }
}

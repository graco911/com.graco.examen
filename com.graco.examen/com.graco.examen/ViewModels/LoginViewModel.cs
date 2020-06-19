using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Windows.Input;

namespace com.graco.examen.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region [ Constantes ]

        #endregion

        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        #region [ Email ]
        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        #endregion

        #region [ Password ]
        private string _password;

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        #endregion

        #region [ CheckShareInfo ]
        private bool _shareInfoCheck;

        public bool ShareInfoCheck
        {
            get { return _shareInfoCheck; }
            set { SetProperty(ref _shareInfoCheck, value); }
        }
        #endregion

        #region [ LoginCommand ]
        public ICommand LoginCommand => new Command(() => Login());
        #endregion

        #endregion

        #region [ Constructor ]
        public LoginViewModel()
        {

        }
        #endregion

        #region [ Metodos/Comandos ]

        #region [ Login ]
        private void Login()
        {
            try
            {
                IsBusy = true;

                if (!ShareInfoCheck)
                {
                    App.ContextApp.DisplayAlert("Información", "No se han aceptado compartir la información", "Aceptar");
                }
                else if (string.IsNullOrEmpty(Email))
                {
                    App.ContextApp.DisplayAlert("Información", "No se ha agregado un correo electronico.", "Aceptar");
                }
                else if (!Helpers.Utils.ValidateEmail(Email))
                {
                    App.ContextApp.DisplayAlert("Información", "El correo electronico no es valido.", "Aceptar");
                }
                else if (string.IsNullOrEmpty(Password))
                {
                    App.ContextApp.DisplayAlert("Información", "No se ha agregado un password.", "Aceptar");

                }
                else if (string.Equals(Password, string.Format("{0:dd/MM/yyyy}", DateTime.Now)))
                {
                    App.ContextApp.DisplayAlert("Información", "Contraseña incorrecta.", "Aceptar");
                }
                else
                {
                    App.ContextApp.DisplayAlert("Información", "BIENVENIDO!!", "Aceptar");

                }

                IsBusy = false;
            }
            catch (Exception)
            {

                throw;
            }    
        }
        #endregion

        #endregion
    }
}

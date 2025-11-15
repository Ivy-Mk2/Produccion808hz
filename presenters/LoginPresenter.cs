using Produccion808xHz.models;
using Produccion808xHz.services;
using Produccion808xHz.services.DataStructures;
using Produccion808xHz.views;
using System;
using System.IO;

namespace Produccion808xHz.presenters
{
    internal class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly UserService _userService;
        private readonly string _routeUser;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
            _view.LoginClicked += OnLoginClicked;

            var storage = new JsonStorageService();
            _userService = new UserService(storage);

            var candidate1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "Users.json");
            if (File.Exists(candidate1))
            {
                _routeUser = candidate1;
            }
            else
            {
                try
                {
                    var parent = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory);
                    var candidate = parent?.Parent?.Parent?.FullName;
                    if (!string.IsNullOrEmpty(candidate))
                        _routeUser = Path.Combine(candidate, "data", "Users.json");
                    else
                        _routeUser = candidate1;
                }
                catch
                {
                    _routeUser = candidate1;
                }
            }

        }


        private void OnLoginClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.User) || string.IsNullOrWhiteSpace(_view.Password))
            {
                _view.ShowMessage("Por favor ingrese usuario y contraseña.");
                return;
            }

            try
            {
                var users = _userService.GetUsers(_routeUser);
                if (users == null || users.Count == 0)
                {
                    _view.ShowMessage("No hay usuarios registrados.");
                    return;
                }

                var table = new HashTableT<string, User>();
                foreach (var uitem in users)
                {
                    if (!string.IsNullOrEmpty(uitem.UserName))
                    {
                        if (!table.TryGet(uitem.UserName, out var _))
                            table.Put(uitem.UserName, uitem);
                    }
                }

                if (table.TryGet(_view.User, out User u))
                {
                    if (string.Equals(u.Password, _view.Password))
                    {
                        
                        if (_view is System.Windows.Forms.Form loginForm)
                        {
                            loginForm.Hide();
                            var main = new MainForm();
                            main.FormClosed += (s, args) => loginForm.Close();
                            main.Show();
                        }
                        else
                        {
                            _view.Close();
                        }
                    }
                    else
                    {
                        _view.ShowMessage("Contraseña incorrecta.");
                    }
                }
                else
                {
                    _view.ShowMessage("Usuario no encontrado.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                _view.ShowMessage("Archivo de usuarios no encontrado. Verifique que 'data\\Users.json' exista.");
            }
            catch (System.Text.Json.JsonException)
            {
                _view.ShowMessage("Error leyendo el archivo de usuarios: formato JSON inválido.");
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error al validar usuario. " + ex.Message);
            }
        }
    }
}


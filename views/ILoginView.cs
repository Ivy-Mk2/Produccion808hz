using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produccion808xHz.views
{
    internal interface ILoginView
    {
        string User { get; }
        string Password { get; }
        event EventHandler LoginClicked;
        void ShowMessage(string message);
        void Close();

    }
}

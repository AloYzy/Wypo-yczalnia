using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Views
{
    public interface ILogin
    {
        string LoginText { get; set; }
        string PasswordText { get; set; }

        bool LogedIn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public enum ViewType
    {
        Administrador,
        Estudiante,
    }
    public interface IViewRolType
    {
        ViewType ViewType { get; }
        string UserName { get; set; }
        void ShowForm(Action closeWindows);
    }
}

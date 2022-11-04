using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recall
{
    public static class AppData
    {
        public static string connectionString = "";
        public static event Action onStringChanged;

        public static void InvokeTextChanged()
        {
            onStringChanged?.Invoke();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Итоговое_задание_ООП.Presenter
{
    internal class Service
    {
        public static int RandomNumberA()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
    }
}

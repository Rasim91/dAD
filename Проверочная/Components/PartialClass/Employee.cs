using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверочная.Components
{
    public partial class Employee
    {
        public string StrFullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }

        public string StrFullAddress
        {
            get
            {
                return $"{Address}, {City}, {State} {Zipcode}";
            }
        }
    }
}

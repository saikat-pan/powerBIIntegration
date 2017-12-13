using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class Employee
    {
        public int Id
        {
            get;
            set;
        }
        public string EmployeeName
        {
            get;
            set;
        }

        public bool IsSelected
        {
            get;
            set;
        }

    }
}
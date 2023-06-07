using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVC_Practical_ADO.NET.Models
{
    public static class Validate
    {
        public static string GetConnectionString ()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        }
    }
}
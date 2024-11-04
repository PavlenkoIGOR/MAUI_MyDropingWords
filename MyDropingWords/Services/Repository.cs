using MyDropingWords.Services.SQLServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDropingWords.Services
{
    public class Repository
    {
        DBService DBService { get; set; }
        public Repository(DBService dB)
        {
            DBService = dB;
        }
    }
}

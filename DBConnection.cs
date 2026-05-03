using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POGOY_H2___CPE262_Final_Project
{
    public class DBConnection
    {
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\jovan\\source\\repos\\POGOY H2 - CPE262 Final Project\\JobMatching.accdb");
        }
    }
}

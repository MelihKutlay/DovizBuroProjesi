﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizBuroProjesi
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = MELIH\\MELIH; Initial Catalog = DovizDatabase; Integrated Security = True");
            baglan.Open();
            return baglan;
              
        }
    }
}

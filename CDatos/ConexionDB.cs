﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    class ConexionDB
    {
        public DataProductsEntities DataBase;

        public ConexionDB()
        {
            DataBase = new DataProductsEntities();
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Buscador
    {
        private List<Filtros> filtros;
        private int id;
        private string searchterm;


        public List<Filtros> Filtros { get => filtros; set => filtros = value; }
        public int Id { get => id; set => id = value; }
        public string Searchterm { get => searchterm; set => searchterm = value; }
    }
}

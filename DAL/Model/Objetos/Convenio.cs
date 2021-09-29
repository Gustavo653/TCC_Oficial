﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Convenio
    {
        public string Nome { get; set; }
        public string Desconto { get; set; }

        public Convenio(string nome, string desconto)
        {
            Nome = nome;
            Desconto = desconto;
        }
    }
}

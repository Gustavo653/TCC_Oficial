﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BAL;

namespace BAL.Control
{
    public class LoginController
    {
        public static bool ValidaCredenciais(string login, string senha)
        {
            return DAL.Model.LoginModel.VerificaCredenciais(login, senha);
        }
    }
}
﻿using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class ContasReceber_BAL
    {
        public static List<ContasReceber> GetContasReceber()
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                return DAL.Model.ContasReceber_DAL.GetContasReceber();
            }
            return DAL.Model.ContasReceber_DAL.GetContasReceber(DAL.Model.Objetos.UsuarioStatic.Filial);
        }
        public static List<ContasReceber> GetContasReceberPorNome(string nome)
        {
            return DAL.Model.ContasReceber_DAL.GetContasReceberPorNome(nome);
        }
        public static int AdicionarContasReceber(string nome, string valor, string vencimento)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(vencimento))
            {
                if(DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 3)
                {
                    return 3; //Usuario sem filial
                }
                try
                {
                    valor = valor.Replace(",", ".");
                    DAL.Model.ContasReceber_DAL.InsereContasReceber(nome, valor, vencimento, DAL.Model.Objetos.UsuarioStatic.Filial);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_ContasReceber_Adicionar");
                    return 3; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro algum campo está vazio
        }
        public static int RemoveContasReceber(string nome, string valor, string vencimento)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(vencimento))
            {
                try
                {
                    DAL.Model.ContasReceber_DAL.RemoveContasReceber(nome, valor, vencimento);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_ContasReceber_Remover");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaContasReceber(string nome, string valor, string vencimento, string whereNome, string whereValor)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(vencimento))
            {     
                try
                {
                    valor = valor.Replace(",", ".");
                    DAL.Model.ContasReceber_DAL.AtualizaContasReceber(nome, valor, vencimento, whereNome, whereValor);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Usuarios_Atualizar");
                    return 3; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro algum campo está vazio
        }
    }
}
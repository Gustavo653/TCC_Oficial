﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Vendas_BAL
    {
        public static string Cupom { get; set; }
        public static double ValorTotalProduto(string quant, string precoUnitario)
        {
            double teste = 0;
            if (!string.IsNullOrEmpty(quant) && !string.IsNullOrEmpty(precoUnitario))
            {
                try
                {
                    precoUnitario = precoUnitario.Replace(",", ".");
                    teste = DAL.Model.Vendas_DAL.ValorTotalProduto(quant, precoUnitario);
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.Log.GerarErro(e, "Vendas_ValorTotalPedido");
                }
            }
            return teste;
        }

        public static double ValorTotal(string quant, string precoUnitario, string desconto)
        {
            double teste = 0;
            if (!string.IsNullOrEmpty(quant) && !string.IsNullOrEmpty(precoUnitario))
            {
                try
                {
                    precoUnitario = precoUnitario.Replace(",", ".");
                    desconto = desconto.Replace(",", ".");
                    teste = DAL.Model.Vendas_DAL.ValorTotal(quant, precoUnitario, desconto);

                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.Log.GerarErro(e, "Vendas_ValorTotal");
                }
            }
            return teste;
        }
        public static string CalculaTotalConvenio(string subTotal, string convenio)
        {
            try
            {
                double desconto = Convert.ToDouble(BAL.Control.Convenios_BAL.GetConveniosPorNome(convenio).Select(x => x.Desconto).ElementAt(0).Replace("%", ""));
                desconto /= 100;
                desconto = 1 - desconto;
                return DAL.Model.Vendas_DAL.CalculaTotalConvenio(subTotal, desconto.ToString());
            }
            catch (Exception e)
            {
                DAL.Model.Consultas.Log.GerarErro(e, "Vendas_CalculaTotalConvenio");
                return null;
            }
        }
        public static int InsereVenda(string nomeProduto, string quantidade, string valorUnitario)
        {
            if (!string.IsNullOrEmpty(nomeProduto) &&
                !string.IsNullOrEmpty(quantidade.ToString()) &&
                !string.IsNullOrEmpty(valorUnitario))
            {
                try
                {
                    if (Cupom == null)
                    {
                        Cupom = DAL.Model.Vendas_DAL.GeraCupom();
                    }
                    List<DAL.Model.Objetos.Produto> produtos = BAL.Control.Produtos_BAL.GetProdutosPorNome(nomeProduto);
                    DAL.Model.Vendas_DAL.InsereVenda(Cupom, produtos[0].Codigo, Convert.ToInt32(quantidade), valorUnitario);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.Log.GerarErro(e, "Vendas_BAL_InsereVenda");
                    return 2; //Erro inesperado
                }
            }
            return 1; //Algum campo esta vazio
        }
        public static int InsereCupom(string vendedor, string cliente, string valorTotal, string formaPagamento)
        {
            if (!string.IsNullOrEmpty(Cupom) &&
              !string.IsNullOrEmpty(vendedor) &&
              !string.IsNullOrEmpty(cliente) &&
              !string.IsNullOrEmpty(valorTotal) &&
              !string.IsNullOrEmpty(formaPagamento.ToString()))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (formaPagamento == ((DAL.Model.Enums.FormaPagamento)i).ToString())
                    {
                        formaPagamento = i.ToString();
                        break;
                    }
                }
                try
                {
                    DAL.Model.Vendas_DAL.InsereCupom(DateTime.Now.ToString().Substring(0, 10), Cupom, Convert.ToInt32(formaPagamento), vendedor, cliente, valorTotal);
                    Cupom = null;
                    return 0;
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.Log.GerarErro(e, "Vendas_BAL_InsereCupom");
                    return 2; //Erro inesperado
                }
            }
            return 1;
        }
        public static int CancelaVenda(string quantidade, string nomeProduto)
        {
            if (!string.IsNullOrEmpty(quantidade) && !string.IsNullOrEmpty(nomeProduto))
            {
                try
                {
                    List<DAL.Model.Objetos.Produto> produtos = BAL.Control.Produtos_BAL.GetProdutosPorNome(nomeProduto);
                    DAL.Model.Vendas_DAL.CancelaVenda(Convert.ToInt32(quantidade), Cupom, produtos[0].Codigo);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.Log.GerarErro(e, "Vendas_BAL_CancelaVenda");
                    return 2; //Erro inesperado
                }
            }
            return 1; //Algo nao estava preenchido
        }
        public static void CancelaCupom()
        {
            try
            {
                DAL.Model.Vendas_DAL.CancelaCupom(Cupom);
                Cupom = null;
            }
            catch (Exception e)
            {
                DAL.Model.Consultas.Log.GerarErro(e, "Vendas_BAL_CancelaCupom");
            }
        }
    }
}

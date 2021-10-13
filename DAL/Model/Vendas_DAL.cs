﻿using DAL.Model.Consultas;
using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Vendas_DAL
    {
        public static double ValorTotalProduto(string quant, string precoUnitario)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double resultado = (Convert.ToDouble(quant) * Convert.ToDouble(precoUnitario));
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            return resultado;
        }

        public static double ValorTotal(string quant, string precoUnitario, string desconto)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double resultado = ((Convert.ToDouble(quant) * Convert.ToDouble(precoUnitario)) - (Convert.ToDouble(desconto)));
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            return resultado;
        }
        public static string GeraCupom()
        {
            string select = $"SELECT CodigoCupom from dbo.Cupom";
            List<string> lista = new List<string>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["CodigoCupom"].ToString());
            }
            dr.Close();
            DbConnection.conn.Close();
            Random ran = new Random();
            while (true)
            {
                string codigo = ran.Next(0, 1000).ToString();
                codigo += ran.Next(0, 1000).ToString();
                if (!lista.Contains(codigo))
                {
                    return codigo;
                }
            }
        }        
        public static void InsereVenda(string codigoCupom, string codigoProduto, int quantidade, string valorUnitario)
        {
            string insert = $"INSERT into dbo.Vendas(CodigoCupom, CodigoProduto, Quantidade, ValorUnitario) values ('{codigoCupom}', '{codigoProduto}', {quantidade}, '{valorUnitario}')";
            DbConnection.Execute(insert);
            string update = $"UPDATE dbo.Produtos Set Quantidade = Quantidade - {quantidade} WHERE Codigo = '{codigoProduto}'";
            DbConnection.Execute(update);
        }
        public static void InsereCupom(string data, string codigoCupom, int formaPagamento, string vendedor, string cliente, string valorTotal)
        {
            string insert = $"INSERT into dbo.Cupom(Data, CodigoCupom, FormaPagamento, Vendedor, Cliente, ValorTotal) values ('{data}', '{codigoCupom}', {formaPagamento}, '{vendedor}', '{cliente}', '{valorTotal}')";
            DbConnection.Execute(insert);
        }
        public static void CancelaVenda(int quantidade, string codigoCupom, string codigoProduto)
        {
            string delete = $"DELETE dbo.Vendas WHERE CodigoCupom = '{codigoCupom}' AND CodigoProduto = '{codigoProduto}'";
            DbConnection.Execute(delete);
            string update = $"UPDATE dbo.Produtos Set Quantidade = Quantidade + {quantidade} WHERE Codigo = '{codigoProduto}'";
            DbConnection.Execute(update);
        }
        public static void CancelaCupom(string codigoCupom)
        {
            string delete = $"DELETE dbo.Cupom WHERE CodigoCupom = '{codigoCupom}'";
            DbConnection.Execute(delete);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class CRUD_Usuarios_BAL
    {
        public static DAL.Model.Consultas.HashLogin hash = new DAL.Model.Consultas.HashLogin(SHA512.Create());
        public static List<DAL.Model.Objetos.Usuario> GetUsuarios()
        {
            return DAL.Model.CRUD_Usuarios_DAL.GetUsuarios();
        }
        public static List<DAL.Model.Objetos.Usuario> GetUsuariosPorNome(string nome)
        {
            return DAL.Model.CRUD_Usuarios_DAL.GetUsuariosPorNome(nome);
        }
        public static int AdicionarUsuario(string nome, int filial, string cargo, string contato, int nivelAcesso, string login, string senha)
        {
            //Adicionar verificacao para saber se o usuario esta sendo atribuido a uma filial valida
            //Adicionar verificacao para saber se o usuario esta sendo atribuido a uma filial valida
            //Adicionar verificacao para saber se o usuario esta sendo atribuido a uma filial valida
            //Adicionar verificacao para saber se o usuario esta sendo atribuido a uma filial valida
            //Adicionar verificacao para saber se o usuario esta sendo atribuido a uma filial valida
            //Adicionar verificacao para saber se o usuario esta sendo atribuido a uma filial valida
            //Adicionar verificacao para saber se o usuario esta sendo atribuido a uma filial valida
            if (!string.IsNullOrEmpty(nome) &&
                !string.IsNullOrEmpty(filial.ToString()) &&
                !string.IsNullOrEmpty(cargo) &&
                !string.IsNullOrEmpty(contato) &&
                !string.IsNullOrEmpty(nivelAcesso.ToString()) &&
                !string.IsNullOrEmpty(login) &&
                !string.IsNullOrEmpty(senha))
            {
                if (DAL.Model.CRUD_Usuarios_DAL.VerificaSeUsuarioRepete(contato))
                {
                    DAL.Model.CRUD_Usuarios_DAL.InsereUsuario(nome, filial, cargo, contato, nivelAcesso, login, hash.CriptografarSenha(senha));
                    return 0; //Deu tudo certo
                }
                return 2; //Erro usuario ja existe
            }
            return 1; //Erro algum campo está vazio
        }
        public static int RemoveUsuario(string contato)
        {
            if (!string.IsNullOrEmpty(contato))
            {
                DAL.Model.CRUD_Usuarios_DAL.RemoveUsuario(contato);
                return 0; //Deu tudo certo
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaUsuario(string nome, int filial, string cargo, string contato, int nivelAcesso, string login, string senha)
        {
            if (!string.IsNullOrEmpty(nome) &&
              !string.IsNullOrEmpty(filial.ToString()) &&
              !string.IsNullOrEmpty(cargo) &&
              !string.IsNullOrEmpty(contato) &&
              !string.IsNullOrEmpty(nivelAcesso.ToString()) &&
              !string.IsNullOrEmpty(login) &&
              !string.IsNullOrEmpty(senha))
            {
                if (DAL.Model.CRUD_Usuarios_DAL.VerificaSeUsuarioRepete(contato))
                {
                    DAL.Model.CRUD_Usuarios_DAL.AtualizaUsuario(nome, filial, cargo, contato, nivelAcesso, login, hash.CriptografarSenha(senha));
                    return 0; //Deu tudo certo
                }
                return 2; //Erro usuario ja existe
            }
            return 1; //Erro algum campo está vazio
        }
    }
}
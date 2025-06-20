﻿using System;
using System.Linq;
namespace Exercicio1
{
    public class Jogo
    {
        /*
             Crie uma classe chamada Jogo com seguintes atributos:
                • Código - (int)
                • Nome - (string)
                • Categoria – (string)
                • Data de lançamento - (DateTime)
             Instancie um objeto da classe Jogo, preencha os seus atributos e exiba em vídeo os dados.
             */

        private string codigo;
        //private int codigo;
        private string nome;
        private string categoria;
        private DateTime dataLancamento;

        #region Codigo

        public void SetCodigo(string valorCodigo)
        {
            if (valorCodigo.All(char.IsDigit))
                codigo = valorCodigo;
            else
                throw new Exception("O código digitado deve ser um número inteiro!");  
        }

        public string GetCodigo()
        {
            return codigo;
        }

        #endregion

        /* 
         * public void SetCodigo(int valorCodigo)
         * {
         *      if (valorCodigo > 0)
         *          codigo = valorCodigo;
         *      else
         *          throw new Exception("Código deve ser maior que zero!");
         *  }
         *  
         *  public int GetCodigo()
         *  {
         *      return codigo;
         *  }
         *      
         */

        #region Nome

        public void SetNome(string nome)
        {
            if (nome.Trim().Length == 0)
                throw new Exception("Nome é obrigatório!");
            else
                this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        #endregion

        #region Categoria

        public void SetCategoria(string categoria)
        {
            if (categoria.Trim().Length == 0)
                throw new Exception("Nome é obrigatório!");
            else
                this.categoria = categoria;
        }

        public string GetCategoria()
        {
            return categoria;
        }

        #endregion

        #region DataLancamento

        public void SetDataLancamento(DateTime data)
        {
            if (data < DateTime.Now)
                throw new Exception("Data de lançamento não pode ser inferior a data atual!");

            dataLancamento = data;
        }

        public DateTime GetDataLancamento()
        {
            return dataLancamento;
        }

        #endregion

    }
}

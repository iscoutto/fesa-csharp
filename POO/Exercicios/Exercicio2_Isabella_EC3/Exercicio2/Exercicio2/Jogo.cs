using System;
using System.Linq;
namespace Exercicio2
{
    public class Jogo
    {
        /*
             Utilizando a classe jogo criada no exercício anterior, faça um programa que instancie até 10 jogos.
             Após efetuar os cadastros, exiba os dados em vídeo. Encapsule os atributos. Validações:
                Código - (int) ( > 0)
                Nome - (string) (obrigatório)
                Categoria – (string) (válido apenas “ação” “luta” “tiro” e “Esportes” )
                Data de lançamento - (DateTime) (deve ser inferior à data atual)

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
            if (data > DateTime.Now)
                throw new Exception("Data de lançamento deve ser inferior a data atual!");

            dataLancamento = data;
        }

        public DateTime GetDataLancamento()
        {
            return dataLancamento;
        }

        #endregion

    }
}


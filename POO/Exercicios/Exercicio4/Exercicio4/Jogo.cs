using System;
namespace Exercicio4
{
    public class Jogo
    {
        private int codigo;
        private string nome;
        private string categoria;
        private DateTime dataLancamento;

        #region Codigo
        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("Código deve ser maior que zero!");
                else
                    codigo = value;
            }
        }
        #endregion

        #region Nome
        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha o nome!");
                else
                    nome = value;
            }
        }
        #endregion

        #region Categoria
        public string Categoria
        {
            get => categoria;
            set
            {
                if (value == "AÇÃO" ||
                    value == "LUTA" ||
                    value == "TIRO" ||
                    value == "ESPORTES")
                    categoria = value;
                else
                    throw new Exception("Categoria inválida!");
            }
        }
        #endregion

        #region DataLancamento
        public DateTime DataLancamento
        {
            get => dataLancamento;
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Data de lançamento deve ser inferior a data atual!");
                else
                    dataLancamento = value;
            }
        }
        #endregion

    }
}
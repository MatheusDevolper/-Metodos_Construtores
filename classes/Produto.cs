namespace Metodos_Construtores.classes
{
    public class Produto
    {
        

        public int Codigo {get;set;}
        public int Estoque {get;set;}
        public string Nome {get;set;}
        public string Descricao {get;set;}

        

        public Produto()
        {

        }

        public Produto(int cod)
        {
            Codigo = cod;
        }

        public Produto(int cod, string name, string definicao, int estocagem)
        {
            Codigo = cod;
            Estoque = estocagem;
            Nome = name;
            Descricao = definicao;
        }
    }
}
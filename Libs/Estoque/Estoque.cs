
namespace listas.Libs.Estoque
{
    public class Estoque
    {
        private List<Produto>? ListaProdutos;

        public Estoque()
        {
            this.IniciaListaProdutos();
        }

        public void IniciaListaProdutos()
        {
            this.ListaProdutos = new List<Produto>();
        }

        public List<Produto> RetornaListaProdutos()
        {
            return this.ListaProdutos!;
        }

        // CRUD

        // CREATE
        public void AdicionaItem(Produto _produto)
        {

            this.ListaProdutos.Add(_produto);
        }

        // READ
        public List<Produto> RetornaLista()
        {
            return this.ListaProdutos!;
        }

        // UPDATE
        public bool AtualizaLista(Produto _produto)
        {
            // Procura o produto na lista
            Produto produtoEncontrado = this.ListaProdutos.Find(prod => prod.Codigo == _produto.Codigo)!;

            if (produtoEncontrado != null)
            {
                // pega o índice do produto antigo
                int indiceDoProduto = this.ListaProdutos.IndexOf(produtoEncontrado);
                // Remove o produto antigo
                this.ListaProdutos.RemoveAt(indiceDoProduto);
                // Insere o produto novo, recebido como parâmetro, no lugar do antigo
                this.ListaProdutos.Insert(indiceDoProduto, _produto);

                return true;
            }

            return false;
        }

        // DELETE
        public bool AtualizaItemDaLista(Produto _produto)
        {
            // pega o índice do produto que será removido
            int indiceParaRemover = this.ListaProdutos.IndexOf(_produto);

            if (indiceParaRemover >= 0)
            {
                // Remove o produto antigo
                this.ListaProdutos.RemoveAt(indiceParaRemover);
                return true;
            }

            return false;
        }
    }
}
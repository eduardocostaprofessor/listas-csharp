using listas.Classes.Estoque;

namespace listas.Interfaces
{
    public interface IEstoque
    {
        void CadastrarProduto(Produto _produto);
        List<Produto> ListarProduto();

        bool AtualizarProduto(Produto _produto);

         bool ApagarProduto(Produto _produto);
    }
}
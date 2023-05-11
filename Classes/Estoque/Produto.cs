
namespace listas.Classes.Estoque
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string? Nome { get; private set; }
        public float Preco { get; private set; }

        public Produto(int _codigo, string _nome, float _preco)
        {
            this.setCodigo(_codigo);
            this.setNome(_codigo);
            this.setPreco(_codigo);
        }


        public void setCodigo(int _codigo)
        {
            if (_codigo > 0)
            {
                this.Codigo = _codigo;
            }
            else
            {
                throw new Exception("Parâmetro não atende os requisitos mínimos. Entre em contato com o administrador do sistema");
            }
        }


        public void setNome(int _codigo)
        {
            if (_codigo > 0)
            {
                this.Codigo = _codigo;
            }
        }

        public void setPreco(float _preco)
        {
            if (_preco >= 0)
            {
                this.Preco = _preco;
            }
        }
    }
}
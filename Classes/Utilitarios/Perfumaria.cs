
namespace listas.Classes.Utilitarios
{
    public static class Perfumaria
    {
        public static string Menu { get; private set; }

        /// <summary>
        /// 
        /// Gera um menu, de ordem numérica, baseado na lista de items recebidos o array items. 
        ///     
        /// Após seu primeiro uso você poderá acessar propriedade estática Perfumaria.Menu e reutilizar sempre que precisar.
        /// </summary>
        /// <param name="_itens">Array de itens do menu</param>
        /// <param name="_tituloMenu">Título do menu. Parâmetro opcional</param>
        /// <returns>Retorna uma string de menu formatada</returns>
        public static string GeraNovoMenu(string[] _itens, string _tituloMenu = "")
        {
            string menu = _tituloMenu == "" ? "Menu" : $"{_tituloMenu}";
            menu = $"{TudoMaiusculo(_tituloMenu)}\n\n";

            for (int posicao = 0; posicao < _itens.Length; posicao++)
            {
                menu += $"{posicao + 1}) {_itens[posicao]}\n";
            }

            Menu = menu;

            return menu += "\n0) Sair\n\n";
        }


        public static string TudoMaiusculo(string _txt)
        {
            return _txt.ToUpper();
        }

        public static string TudoMinusculo(string _txt)
        {
            return _txt.ToLower();
        }

        public static void LimpaTela()
        {
            Console.Clear();
        }

        public static void PulaLinha()
        {
            
                Console.WriteLine();
            
        }

        public static void PulaLinha(int _qtdLinha) {
            
            // chama a primeira sobrecarga
            if (_qtdLinha == 1)
            {
                PulaLinha();
            }
            else
            {
                for (int l = 1; l <= _qtdLinha; l++)
                {
                    Console.WriteLine();
                }
            }
        }
        
        public static void PulaLinha(int _qtdLinha, string _marcador = "") {
            
            // chama a primeira sobrecarga
            if (_qtdLinha == 1)
            {
                PulaLinha();
            }
            else
            {
                for (int l = 1; l <= _qtdLinha; l++)
                {
                    Console.WriteLine(_marcador);
                }
            }
        }
    }
}
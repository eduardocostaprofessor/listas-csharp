
namespace listas.Libs.Utilitarios
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
        /// <param name="itens">Array de itens do menu</param>
        /// <param name="tituloMenu">Título do menu. Parâmetro opcional</param>
        /// <returns>Retorna uma string de menu formatada</returns>
        public static string GeraNovoMenu(string[] itens, string tituloMenu = "")
        {
            string menu = tituloMenu == "" ? "Menu" : $"{tituloMenu}";
            menu = $"{TudoMaiusculo(tituloMenu)}\n\n";

            for (int posicao = 0; posicao < itens.Length; posicao++)
            {
                menu += $"{posicao + 1}) {itens[posicao]}\n";
            }

            Menu = menu;

            return menu += "\n0) Sair\n\n";
        }


        public static string TudoMaiusculo(string txt)
        {
            return txt.ToUpper();
        }

        public static string TudoMinusculo(string txt)
        {
            return txt.ToLower();
        }

        public static void LimpaTela()
        {
            Console.Clear();
        }

        public static void PulaLinha()
        {
            
                Console.WriteLine();
            
        }

        public static void PulaLinha(int qtdLinha) {
            
            // chama a primeira sobrecarga
            if (qtdLinha == 1)
            {
                PulaLinha();
            }
            else
            {
                for (int l = 1; l <= qtdLinha; l++)
                {
                    Console.WriteLine();
                }
            }
        }
        
        public static void PulaLinha(int qtdLinha, string marcador = "") {
            
            // chama a primeira sobrecarga
            if (qtdLinha == 1)
            {
                PulaLinha();
            }
            else
            {
                for (int l = 1; l <= qtdLinha; l++)
                {
                    Console.WriteLine(marcador);
                }
            }
        }
    }
}
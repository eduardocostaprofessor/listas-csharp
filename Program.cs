using listas.Libs.Estoque;
using listas.Libs.Utilitarios;

// List<Produto> prods = new List<Produto>();

// // CREATE
// prods.Add(new Produto(1234,"Camiseta Lacoste", 19.99f));
// prods.Add(new Produto(1234,"Camiseta Armani", 49.99f));
// prods.Add(new Produto(1234,"Calça Jeans Polo", 99.99f));

// Console.Clear();

// // READ
// Console.WriteLine($"******* Produtos Cadastrados *******");
// Console.WriteLine();

// foreach (var p in prods)
// {
//     Console.WriteLine(@$"Código: {p.Codigo}, Descrição: {p.Nome}, Preço: {p.Preco:C}");
// }

// Console.WriteLine();

Perfumaria.LimpaTela();
string[] arrMenu = new string[] { "Cadastrar", "Listar", "Atualizar", "Apagar" };
Console.WriteLine(Perfumaria.GeraNovoMenu(arrMenu, "Cadastro de Produtos"));
 
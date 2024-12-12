// See https://aka.ms/new-console-template for more information
using System.Text;

namespace MyApp{
    class Program
    {
        static void Main(string[] args){
            var id =  Guid.NewGuid();

            var price = 10.2;

            var texto = " O preço do produto é: " + price + " em promoção";

            var texto2  =  string.Format("O preço do protudo é {0} apenas na promoção", price);

            var texto3 = $"O preço do produto  é {price}";

            var texto4 = "Testando";
            
            var texto5 = " Este texto contem um teste ";

            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
            Console.WriteLine(texto4.CompareTo("Testando"));
            Console.WriteLine(texto5.Contains("teste"));
            Console.WriteLine(texto5.Contains("Teste", StringComparison.OrdinalIgnoreCase));// ignora maiscula e minuscula
            Console.WriteLine(texto5.Contains(""));
            Console.WriteLine(texto5.StartsWith("Este"));//inicio da frase
            Console.WriteLine(texto5.StartsWith("este"));
            Console.WriteLine(texto5.StartsWith("texto"));
            Console.WriteLine(texto5.EndsWith("teste"));//final da frase
            Console.WriteLine(texto5.Equals("teste"));//final da frase

            //lista array
            Console.WriteLine(texto5.IndexOf("u"));//posição
            Console.WriteLine(texto5.LastIndexOf("s")); //ulçtima possição do s

            Console.WriteLine(texto5.ToUpper());
            Console.WriteLine(texto5.ToLower());
            Console.WriteLine(texto5.Insert(5, "AQUI"));
            Console.WriteLine(texto5.Remove(5, 5));
            Console.WriteLine(texto5.Length);

            Console.WriteLine(texto5.Replace("Este", "isto"));

            var divisao = texto5.Split(" "); //divisao do texto
            Console.WriteLine(divisao[0]);
             Console.WriteLine(divisao[1]);
              Console.WriteLine(divisao[2]);
               Console.WriteLine(divisao[3]);

               var resultado = texto5.Substring(5,5);
               Console.WriteLine(resultado);

               Console.WriteLine(texto5.Trim());// limpa o espaço da escrita do incio e final

               var texto6 = new StringBuilder();
               texto6.Append("Este texto e um teste");
                  texto6.Append("em bvreve m teste");

   texto6.Append("Efoi uma testeste");

   texto6.Append("embora teste este");
   Console.WriteLine(texto6.ToString());





        }
    }
}

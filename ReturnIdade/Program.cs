
namespace SuaAppIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua data de nascimento (no formato dd/mm/aaaa):");
            string input = Console.ReadLine();

            DateTime dataNascimento;
            if (DateTime.TryParse(input, out dataNascimento))
            {
                int idade = CalcularIdade(dataNascimento);
                Console.WriteLine($"A sua idade atual é: {idade} anos.");
            }
            else
            {
                Console.WriteLine("Data de nascimento inválida.");
            }

            Console.ReadLine();
        }

        static int CalcularIdade(DateTime dataNascimento)
        {
            var hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;

            if (dataNascimento.Date > hoje.AddYears(-idade))
                idade--;

            return idade;
        }
    }
}
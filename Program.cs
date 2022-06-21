namespace aula_13_recursos_de_colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {


                Escola matricula = new Escola();
            matricula.Cadastrar(01, "Jose", "Iranildo", "123456");
            
            Escola matricular1 = new Escola();
            matricular1.Cadastrar(02, "João", "Carlos", "789456123");

            Console.WriteLine($"{matricula.Lista}");

        }
        
    }
}
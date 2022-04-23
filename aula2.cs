namespace TopCoders
{
    public class aula2
    {

        public static void Main(string[] args)
        {
            bool isInvalid = true;
            int errors = 0;

            while (isInvalid && errors <3){

                Console.WriteLine("Digite sua senha de 4 digitos numéricos: ");
                string input = Console.ReadLine();
                int password;
                bool isNumber = Int32.TryParse(input, out password);

                if (input.Length == 4 && isNumber){
                    Console.WriteLine("Senha correta!");
                    isInvalid = false;
                } 
                else{
                    Console.WriteLine("Senha incorreta!");
                    errors++;
                    if(errors == 3){
                        Console.WriteLine("Senha bloqueada!");
                    }
                }
            }
            
        }
    }
}
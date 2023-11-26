class program
{
    static void Main()
    {
     //DECLARACION DE VARIABLES
     int numero1 = 0;
     int numero2 = 0;
    int respuesta = 0;

        Suma(ref numero1,ref  numero2,ref respuesta);
      Console.WriteLine($"La respuesta es: {respuesta}");
      Console.ReadLine();

    }

    static void Suma(ref int numero1 , ref int numero2 , ref int respuesta )
    {

        Console.WriteLine("Por favor digite el primer numero");

        while (!int.TryParse(Console.ReadLine(), out numero1))
        {
            Console.WriteLine("Por favor ingrese un numero valido");
        }
        Console.WriteLine("___________________________________");

        Console.WriteLine("Por favor digite el segundo numero");

        while (!int.TryParse(Console.ReadLine(), out numero2))
        {
            Console.WriteLine("Por favor ingrese un numero valido");

        }
        Console.WriteLine("___________________________________");
        respuesta = numero1 + numero2;

        
    }


}

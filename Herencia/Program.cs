namespace Herencia
{
    public class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine($"{Nombre} hace un sonido.");
        }
    }

    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} ladra.");
        }
    }

    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} maúlla.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Fido");
            Gato gato = new Gato("Whiskers");

            perro.HacerSonido();
            gato.HacerSonido();
        }
    }
}

//Este programa crea una clase Animal con un atributo Nombre y un método HacerSonido.
//Luego, crea las clases Perro y Gato que heredan de Animal y sobrescriben el método HacerSonido.
//En el método Main, se crean un Perro y un Gato, y se llama a su método HacerSonido.
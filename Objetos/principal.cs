using libreriaclases;

namespace otraLibreria
{
    class Principal
    {
        static void Main()
        {
            string nombre;
            Silla pepe = new Silla();
            Silla roberta = new Silla();

            pepe.color = "rojo";
            pepe.materiales = "plastico";

            roberta.color = "verde";
            roberta.materiales = "madera";

            pepe.mover("Pepe");
            pepe.crear();

            Console.WriteLine(pepe.crear());
            Console.WriteLine(pepe.color);
            Console.WriteLine(pepe.materiales);

            Console.WriteLine(roberta.crear());
            Console.WriteLine(roberta.color);
            Console.WriteLine(roberta.materiales);

            roberta.mover("Roberta");
        }
    }
}
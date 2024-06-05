namespace libreriaclases
{
    class Silla
    {     
        public string color;
        public string materiales;

        public string crear()
        {
            return"hola";
        }
        
        public void mover(string pnombre)
        {
          Console.WriteLine("La silla se esta moviendo{0}", pnombre);
        }

    }
}

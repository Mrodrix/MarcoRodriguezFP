namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta es la declaración e inicialización de una variable
            string nombre = "Marco";
            const string iva="19%";
            Console.Write("HOLA,"+nombre+" \n");
            Console.Write("\tBienvenido a la clase de programacion");
            nombre = "Alejandro";
            Console.Write("\n" + nombre);
            //iva = "20%"; No se puede cambiar el valor de una constante

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = 20542;
            long dato3 = 912491824;
            double dato4 = 352.65;
            char dato5 = 'a';//Puede almacenar solo un caracter
            bool dato6 = false;//Almacena true o false
            object dato7 = new Program();
        }
    }
}

static void Main()
    /*
    Gerardo Fuentes | 1096622
    Alberto Flores  | 1247022
     */

{
    // VARIABLES
    int operacion;
    string nombre;
    int[] cuartos = new int[5];
    Random r=new Random();  


    // primeros mensajes

    Console.WriteLine("Bienvenido al menú principal de AUTO-HOME");
    Console.WriteLine();
    Console.WriteLine("Por favor, ingrese su nombre:");
    nombre = Console.ReadLine();

        Console.WriteLine();
    Console.WriteLine("¡Bienvenido " + nombre + " será un gusto servirle!");
        Console.WriteLine();

            // randomizado cuartos
            for (int i = 0; i < 5; i++)
            {
                cuartos[i] = r.Next(100);
            }

            //El cuarto con menor número en el random, se ilumina
            if (cuartos[0] < cuartos[1] && cuartos[0] < cuartos[2] && cuartos[0] < cuartos[3] && cuartos[0] < cuartos[4])
            {
                Console.WriteLine("El cuarto No. 01 se encuentra con la luz encendida.");
            }

            if(cuartos[1] < cuartos[0] && cuartos[1] < cuartos[2] && cuartos[1] < cuartos[3] && cuartos[1] < cuartos[4])
            {
                Console.WriteLine("El cuarto No. 02 se encuentra con la luz encendida.");
            }
            if (cuartos[2] < cuartos[1] && cuartos[2] < cuartos[0] && cuartos[2] < cuartos[3] && cuartos[2] < cuartos[4])
            {
                Console.WriteLine("El cuarto No. 03 se encuentra con la luz encendida.");
            }
            if (cuartos[3] < cuartos[1] && cuartos[3] < cuartos[2] && cuartos[3] < cuartos[0] && cuartos[3] < cuartos[4])
            {
                Console.WriteLine("El cuarto No. 04 se encuentra con la luz encendida.");
            }
            if (cuartos[4] < cuartos[1] && cuartos[4] < cuartos[2] && cuartos[4] < cuartos[3] && cuartos[4] < cuartos[0])
            {
                Console.WriteLine("El cuarto No. 05 se encuentra con la luz encendida.");
            }
            Console.WriteLine();

    // continuan primeros mensajes
    Console.WriteLine("Digite una de las siguientes opciones que aparecen en pantalla.");
    Console.WriteLine("---------------------");
    Console.WriteLine("1. VENTILACIÓN");
    Console.WriteLine("2. CALEFACCIÓN");
    Console.WriteLine("3. SALIR DE AUTO-HOME");
    Console.WriteLine("----------------------");
    operacion = Convert.ToInt32(Console.ReadLine());

    // menú principal
   
        switch (operacion)
        {
            case 1:
                int menuVentilacion;

                Console.WriteLine("Bienvenido al apartado de ventilación");
                Console.WriteLine();
                Console.WriteLine("Digite una de las siguientes opcioens que aparecen en pantalla.");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("1. Para hacer una programación semanal de la ventilación.");
                Console.WriteLine("2. Prender ventilación.  ");
                Console.WriteLine("3. Apagar ventilación. ");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine();
                menuVentilacion = Convert.ToInt32(Console.ReadLine());
                // MENÚ DENTRO DE VENTILACIÓN

                switch (menuVentilacion)
                {
                    case 1:
                        // matríz para llenado de programación.
                        string[,] semanaVentilacion = new string[7, 5];


                        Console.WriteLine("Programación semanal de ventilación.");
                        Console.WriteLine("Escriba la palabra Si, si usted desea que para el horario asignado la ventilación esté prendida y la palabra no para mantenerlo apagado.");
                        Console.WriteLine("Los días y horarios son los siguientes: ");
                        Console.WriteLine();
                        Console.WriteLine("Día 1 = Lunes            Horario 1 : 0 - 4 hrs");
                        Console.WriteLine("Día 2 = Martes           Horario 2 : 5 - 9 hrs");
                        Console.WriteLine("Día 3 = Miercoles        Horario 3 : 10 - 14 hrs");
                        Console.WriteLine("Día 4 = Jueves           Horario 4 : 15 - 19 hrs");
                        Console.WriteLine("Día 5 = Viernes          Horario 5 : 20 - 24 hrs");
                        Console.WriteLine("Día 6 = Sábado");
                        Console.WriteLine("Día 7 = Domingo");
                        Console.WriteLine();
                        for (int f = 0; f < 7; f++)
                        {
                            for (int c = 0; c < 5; c++)
                            {
                                // variables para nombrar el día y horarios
                                int dia = f + 1;
                                int horas = c + 1;

                                Console.WriteLine("Se encuentra en el día " + dia + " y en el horario número " + horas);
                                semanaVentilacion[f, c] = Console.ReadLine();
                            }
                        }


                        Console.WriteLine("Su horario planificado es el siguiente:  \n");
                        Console.WriteLine();
                        Console.WriteLine("             0-4 hrs    5-9 hrs    10-14 hrs    15-19 hrs    20-24 hrs");
                        for (int f = 0; f < 7; f++)
                        {
                            // variables
                            int diiia = f + 1;

                            Console.Write("Día No. " + diiia);
                            for (int c = 0; c < 5; c++)
                            {
                                // variables
                                int horas = c + 1;
                                Console.Write("          " + semanaVentilacion[f, c]);
                            }
                            Console.WriteLine();
                        }

                        break;

                    case 2:
                        Console.WriteLine("Ventilación prendida.");
                        break;

                    case 3:
                    Console.WriteLine("Ventilación apagada.");
                        break;
                }

                break;

            case 2:
                Console.WriteLine("Bienvenido al apartado de calefacción");
                Console.WriteLine("A continuación se le presentará un formulario que va en orden, del dia lunes al domingo");

                int[] min = new int[7];
                int[] max = new int[7];

                double sumamin = 0;
                double sumamax = 0;
                double prommin = 0;
                double prommax = 0;

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Ingrese una temperatura mínima:");
                    min[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese una temperatura máxima:");
                    max[i] = int.Parse(Console.ReadLine());

                    if (min[i] > max[i])
                    {
                        Console.WriteLine("Datos inválidos");
                    }

                    if (min[i] < 18) ;
                    {
                        Console.WriteLine("Recordatorio: la temperatura no debe caer por debajo de los 18 grados.");
                    }
                }

                for (int i = 0; i < 7; i++)
                {
                    sumamin = sumamin + min[i];
                }

                prommin = sumamin / 7;
                Console.WriteLine("El promedio de las temperaturas mínimas es de: " + prommin);

                for (int j = 0; j < 7; j++)
                {
                    sumamax = sumamax + max[j];
                }

                prommax = sumamax / 7;
                Console.WriteLine("El promedio de las temperaturas máximas es de: " + prommax);

                break;

            // SALIDA DE PROGRAMA
            case 3:
                Console.WriteLine("¡Gracias por preferirnos!");
                Console.WriteLine("Cerrando AUTO-HOME...");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine();
                break;
        }
    
}
        
Main();
using System;
using System.ComponentModel.Design;
using System.Net;
public class Program
{
    public static void Main()
    {

        //DETERMINAR CAPACIDAD DE LOS ARRAYS
        //ESTOS ARRAYS SE USAN EN CUALQUIER SUBPROGRAMA
        string[] palabrasTema1 = new string[5];
        string[] conceptosTema1 = new string[5];

        string[] palabrasTema2 = new string[5];
        string[] conceptosTema2 = new string[5];

        string[] palabrasTema3 = new string[5];
        string[] conceptosTema3 = new string[5];

        string[] palabrasTema4 = new string[5];
        string[] conceptosTema4 = new string[5];

        //TEMA #1
        palabrasTema1[0] = "Lenguaje de alto nivel";
        conceptosTema1[0] = "Es un lenguaje que es mas facil de leer para un programador ya que esta mas cerca del lenguaje humano ";
        palabrasTema1[1] = "Estructura de control";
        conceptosTema1[1] = "son estructuras que controlan las secuencias lógicas de un algoritmo para cumplir con cierta condición, evaluar un error o repetir varios procesos. Existen dos tipos de estructuras de control: condicionales y ciclos";
        palabrasTema1[2] = "Condicional";
        conceptosTema1[2] = "Son las declaraciones que permiten que el software tome decisiones dinámicamente en función de la evaluación de expresiones lógicas";
        palabrasTema1[3] = "Bucle";
        conceptosTema1[3] = "Es una secuencia de instrucciones de código que se ejecuta repetidas veces, hasta que la condición asignada a dicho bucle deja de cumplirse";
        palabrasTema1[4] = "Algoritmo";
        conceptosTema1[4] = "Serie de acciones";
        //TEMA #2
        palabrasTema2[0] = "Ambito de variables";
        conceptosTema2[0] = "Es el espacio de programa donde esta será visible y accesible";
        palabrasTema2[1] = "Programacion modular";
        conceptosTema2[1] = "Consiste en la descomposición de un programa en trozos más pequeños denominados módulos o subprogramas, en el que cada uno de ellos se encargara de llevar a cabo una tarea concreta y bien definida, y se agrupara según su funcionalidad";
        palabrasTema2[2] = "Subprograma";
        conceptosTema2[2] = "Es una función o una subrutina y es un subprograma interno, externo o de módulo";
        palabrasTema2[3] = "Main program";
        conceptosTema2[3] = "Es el punto de entrada de un programa ejecutable; es donde se inicia y finaliza el control del programa";
        palabrasTema2[4] = "Programacion orientada a objetos";
        conceptosTema2[4] = "Se basa en el concepto de crear un modelo del problema de destino en sus programas. La programación orientada a objetos disminuye los errores y promociona la reutilización del código";
        //TEMA #3
        palabrasTema3[0] = "Cadena";
        conceptosTema3[0] = "Es una secuencia ordenadade elementos que pertenecen a un cierto lenguaje formal o alfabeto análogas a una fórmula o a una oración";
        palabrasTema3[1] = "Caracter";
        conceptosTema3[1] = "Unidad de información que corresponde aproximadamente con un grafema o con una unidad o símbolo parecido";
        palabrasTema3[2] = "Concatenacion de cadenas";
        conceptosTema3[2] = "Es la union de una o mas cadenas en una sola";
        palabrasTema3[3] = "Caracteres especiales de string";
        conceptosTema3[3] = "Son caracteres que tienen un significado especial y no se representan de la manera convencional en el texto. Estos caracteres se utilizan para realizar ciertas funciones específicas en programación y en la manipulación de texto";
        palabrasTema3[4] = "Metodos de string";
        conceptosTema3[4] = "Son funciones integradas que se aplican a objetos de tipo cadena (string) en muchos lenguajes de programación. Estos métodos permiten realizar diversas operaciones y manipulaciones en cadenas de texto";
        //TEMA #4
        palabrasTema4[0] = "Array";
        conceptosTema4[0] = "Conjunto finito y ordenado de elementos homogeneos";
        palabrasTema4[1] = "Array unidimensional";
        conceptosTema4[1] = "Un tipo de array que tiene determinado una dimension de 1 ";
        palabrasTema4[2] = "Estructura de datos";
        conceptosTema4[2] = "Es una forma organizada de almacenar y organizar datos en una computadora para que puedan ser utilizados de manera eficiente. Estas estructuras permiten gestionar y manipular datos de una manera específica";
        palabrasTema4[3] = "Estructura de dato estatica";
        conceptosTema4[3] = "Se refiere a una estructura cuyo tamaño y disposición se determinan en tiempo de compilación y no cambian durante la ejecución del programa";
        palabrasTema4[4] = "Estructura de dato dinamica";
        conceptosTema4[4] = "Se refiere a una forma de organizar y almacenar datos en la memoria de un programa de manera que su tamaño puede cambiar durante la ejecución";

        string[] Palabras_Total = new string[palabrasTema1.Length + palabrasTema2.Length + palabrasTema3.Length + palabrasTema4.Length];
        string[] Conceptos_Total = new string[conceptosTema1.Length + conceptosTema2.Length + conceptosTema4.Length + conceptosTema4.Length];

        //Variables usadas para Menu
        int opcion = 0;
        bool llaveDeCierre = true;
        int opcionAgregar = 0;
        do
        {

            opcion = menu();
            switch (opcion)
            {
                case 1://Agregar conceptos
                    opcionAgregar = elegirTema();
                    switch (opcionAgregar)
                    {
                        case 1:
                            Console.WriteLine("Ingrese la palabra");
                            palabrasTema1 = agregar(palabrasTema1);
                            Console.WriteLine("Ingrese el concepto");
                            conceptosTema1 = agregar(conceptosTema1);
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Ingrese la palabra");
                            palabrasTema2 = agregar(palabrasTema2);
                            Console.WriteLine("Ingrese el concepto");
                            conceptosTema2 = agregar(conceptosTema2);
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("Ingrese la palabra");
                            palabrasTema3 = agregar(palabrasTema3);
                            Console.WriteLine("Ingrese el concepto");
                            conceptosTema3 = agregar(conceptosTema3);
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("Ingrese la palabra");
                            palabrasTema4 = agregar(palabrasTema4);
                            Console.WriteLine("Ingrese el concepto");
                            conceptosTema4 = agregar(conceptosTema4);
                            Console.Clear();
                            break;

                    }
                    break;
                case 2://Buscar Conceptos

                    Palabras_Total = Reunir(palabrasTema1, palabrasTema2,
                    palabrasTema3, palabrasTema4);
                    Conceptos_Total = Reunir(conceptosTema1, conceptosTema2,
                    conceptosTema3, conceptosTema4);

                    string auxiliar;
                    for (int i = 0; i < Palabras_Total.Length; i++)
                    {
                        for (int j = i + 1; j < Palabras_Total.Length; j++)
                        {
                            if (Palabras_Total[i].CompareTo(Palabras_Total[j]) > 0)
                            {
                                //Reordena las palabras y conceptos a la vez en general
                                //Ordena todo en orden alfabetico

                                auxiliar = Palabras_Total[i];
                                Palabras_Total[i] = Palabras_Total[j];
                                Palabras_Total[j] = auxiliar;
                                auxiliar = Conceptos_Total[i];
                                Conceptos_Total[i] = Conceptos_Total[j];
                                Conceptos_Total[j] = auxiliar;
                            }
                        }
                    }
                    busqueda(Palabras_Total, Conceptos_Total);
                    break;
                case 3://Apagar Programa
                    llaveDeCierre = confirmacionDeApagado();
                    break;
                
            }

        } while (opcion != 3 && llaveDeCierre);
    }
    public static string[] agregar(string[] definiciones)
    {
        string[] nuevadefiniciones = new string[definiciones.Length + 1];

        for (int i = 0; i < nuevadefiniciones.Length; i++)
        {

            if (i == nuevadefiniciones.Length - 1)
            {
                nuevadefiniciones[i] = Console.ReadLine();
                break;
            }
            nuevadefiniciones[i] = definiciones[i];
        }
        return nuevadefiniciones;
    }
    public static void busqueda(string[] palabra, string[] definicion)
    {
        int x = 0;
        int opcion = 0;
        string[] mostrar = new string[10];
        Console.WriteLine("Ingrese la palabra que esta buscando:");
        string ingreso = Console.ReadLine();
        Console.Clear();
        string letras = ingreso.ToLower();
        bool existe = false;
        //Se convierte a todas las palabras almacenadas en minusculas
        for (int i = 0; i < palabra.Length; i++)
        {
            palabra[i] = palabra[i].ToLower();
        }

        for (int i = 0; i < palabra.Length; i++)
        {
            //Si tamaño de letra ingresada <= tamaño de alguna palabra almacenada
            if (letras.Length <= palabra[i].Length)
            {
                existe = true;
                //Si la palabra ingresada de n tamaño == a las primeras n letras de alguna palabra almacenada
                if (letras.Substring(0, letras.Length) == palabra[i].Substring(0, letras.Length))
                {
                    x = i;
                    do
                    {
                        Console.WriteLine("RESULTADOS");
                        for (int j = 0; j < mostrar.Length; j++)
                        {
                            //SI x+j < TAMAÑO DE ARRAY[] PALABRAS &&  x+y>=0 ya que solo hay posiciones desde 0 en array[] palabras
                            // Mostrar las opciones disponibles, desde el primer comun y los que le siguen
                            if (x + j < palabra.Length && x + j >= 0)
                            {
                                mostrar[j] = palabra[x + j];
                                Console.WriteLine($"{j + 1}. {mostrar[j]}");
                            }
                            //SINO MOSTRAR EN VACIO
                            else
                            {
                                
                                mostrar[j] = "";
                            }
                        }
                        Console.WriteLine("\n1. Anterior 2.Escoger 3.Siguiente 4.volver");
                        if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                        {
                            Console.WriteLine("\n¡ERROR! Por favor ingrese un numero entre las cuatro mencionadas\n");
                            Console.WriteLine("------>PRESIONE CUALQUIER TECLA PARA VOLVER A INTENTAR<------");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            switch (opcion)
                            {
                                case 1:
                                    //En el siguiente bucle mostrara las otras 10 posiciones del array[] palabras
                                    x = x - 10;
                                    Console.Clear();
                                    break;
                                case 2:
                                    int escogido = 0;
                                    Console.WriteLine("Escoja la palabra que desea seleccionar");
                                    if (int.TryParse(Console.ReadLine(), out escogido) && escogido>0 && escogido<=10)
                                    {
                                        Console.Clear();
                                        //Numero escogido - 1 + 10, asi se muestra la posicion exacta 
                                        Console.WriteLine(palabra[escogido - 1 + x].ToUpper());
                                        Console.WriteLine(definicion[escogido - 1 + x]);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n¡ERROR! debe ingresar una de las opciones mostradas");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                    break;
                                case 3:
                                    x = x + 10;
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.Clear();
                                    break;
                            }
                        }

                    } while (opcion != 2 && opcion != 4);
                    break;
                }
            }
            else { existe = false; }
        }
        if (existe == false) { Console.WriteLine("La palabra que esta buscando no existe"); }
    }
    public static string[] Reunir(string[] lista1, string[] lista2, string[] lista3, string[] lista4)
    {
        int x = 0;
        int total = lista1.Length + lista2.Length + lista3.Length + lista4.Length;
        string[] Lista = new string[total];
        do
        {
            for (int i = 0; i < lista1.Length; i++)
            {
                Lista[x] = lista1[i];
                x++;
            }

            for (int i = 0; i < lista2.Length; i++)
            {
                Lista[x] = lista2[i];
                x++;
            }
            for (int i = 0; i < lista3.Length; i++)
            {
                Lista[x] = lista3[i];
                x++;
            }
            for (int i = 0; i < lista4.Length; i++)
            {
                Lista[x] = lista4[i];
                x++;
            }
        } while (x < total);
        return Lista;
    }
    public static int menu()
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("|        GLOSARIO UPDS        |");
            Console.WriteLine("|-----------------------------|\n");
            Console.WriteLine("1. Agregar Conceptos\n2. Buscar Conceptos\n3. Apagar Programa");
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.WriteLine("\n¡Error! Por favor, ingrese un número del 1 al 3\n");
            }
            

        } while (opcion < 1 || opcion > 3);
        Console.Clear();
        return opcion;
    }
    public static int elegirTema()
    {
        int elegirTema = 0;
        do
        {
            Console.WriteLine("Elija un tema:\n1. Tema 1 Estructuras de Control\n2. Tema 2 Programacion Modular\n" +
                "3. Tema 3 Cadena de Caracteres\n4. Tema 4 Programacion con Estructuras Unidimensionales");
            if (!int.TryParse(Console.ReadLine(), out elegirTema) || elegirTema < 1 || elegirTema > 4)
            {
                Console.WriteLine("\n¡Error! Por favor, ingrese un número del 1 al 4\n");
            }
            
        } while (elegirTema < 1 || elegirTema > 4);
        Console.Clear();
        return elegirTema;
    }
    public static bool confirmacionDeApagado()
    {
        bool llaveDeCierre = true;
        int opcion2 = 0;
        do
        {
            Console.WriteLine("------------ATENCION------------\n>>>>>Estás a punto de cerrar el Glosario UPDS. ¿Estás seguro?");
            Console.WriteLine("1. SI\n2. NO");

            if (int.TryParse(Console.ReadLine(), out opcion2))
            {
                if (opcion2 == 1)
                {
                    Console.WriteLine("---\tCERRANDO EL PROGRAMA...\t\t---");
                    llaveDeCierre = false;
                }
                else if (opcion2 == 2)
                {
                    Main();
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, selecciona 'SI' (1) para cerrar o 'NO' (2) para volver.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, selecciona 'SI' (1) para cerrar o 'NO' (2) para volver.");
            }
        } while (opcion2 != 1 && opcion2 != 2);

        return llaveDeCierre;
    }

}
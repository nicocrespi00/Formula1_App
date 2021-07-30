using System;

namespace Segundo_Parcial
{
    class Program
    {
        #region Declaración de Matrices y Asignacion de Valores

        /// <summary>
        /// Creamos la matriz 'pilotos' y le pasamos el metodo 'CargarPilotos'que le asignara sus valores
        /// </summary>
        static string[,] pilotos = CargarPilotos();

        /// <summary>
        /// Asigna valores de una matriz con 10 filas y 2 columnas
        /// </summary>
        /// <returns>devuelve estos valores en forma de matriz</returns>
        static string[,] CargarPilotos()
        {
            string[,] aux = new string[10, 2]
            {
                {"Leclerc","Sainz"},
                { null,null},
                { "Norris","Ricciardo"},
                { "Hamilton","Bottas"},
                { "Verstappen","Perez"},
                { null,null},
                { "Vettel","Stroll"},
                { "Russell","Latifi"},
                { null,null},
                { "Gasly","Tsunoda"}
            };
            return aux;
        }

        /// <summary>
        /// Creamos la matriz 'puntosPorCarrera' y le pasamos el metodo 'CargarPuntosPorCarrera'que le asignara sus valores
        /// </summary>
        static int[,] puntosPorCarrera = CargarPuntosPorCarrera();

        /// <summary>
        /// Asigna valores de una matriz con 10 filas y 10 columnas
        /// </summary>
        /// <returns>devuelve estos valores en forma de matriz</returns>
        static int[,] CargarPuntosPorCarrera()
        {
            int[,] aux = new int[10, 10]
            {
                {40,15,22,7,30,10,12,18,32,43},
                {0,0,0,0,0,0,0,0,0,0},
                {22,40,30,1,4,5,9,2,1,10},
                {30,25,1,22,8,9,10,1,2,1},
                {10,7,20,3,18,6,20,19,10,5},
                {0,0,0,0,0,0,0,0,0,0},
                {5,1,6,6,8,30,12,17,24,22},
                {1,9,6,3,4,15,22,20,1,30},
                {0,0,0,0,0,0,0,0,0,0},
                {15,8,14,10,22,8,13,12,10,1}
            };
            return aux;
        }

        /// <summary>
        /// Creamos la matriz unidimensional 'circuito' y le pasamos el metodo 'CargarCircuito'que le asignara sus valores
        /// </summary>
        static string[] circuito = CargarCircuito();

        /// <summary>
        /// Asigna valores de una matriz unidimensional con 10 registros
        /// </summary>
        /// <returns>devuelve estos valores en forma de matriz unidimensional</returns>
        static string[] CargarCircuito()
        {
            string[] aux = new string[10]
            {
                "Baku",
                null,
                "Monza",
                "Bahrein",
                "Spa",
                null,
                "Catalunia",
                "Interlagos",
                null,
                "Monaco"
            };
            return aux;
        }

        /// <summary>
        /// Creamos la matriz unidimensional 'constructores' y le pasamos el metodo 'CargarConstructores'que le asignara sus valores
        /// </summary>
        static string[] constructores = CargarConstructores();

        /// <summary>
        /// Asigna valores de una matriz unidimensional con 10 registros
        /// </summary>
        /// <returns>devuelve estos valores en forma de matriz unidimensional</returns>
        static string[] CargarConstructores()
        {
            string[] aux = new string[10]
            {
                "Ferrari",
                null,
                "Mclaren",
                "Mercedez",
                "Red Bull",
                null,
                "Alpha Tauri",
                "Aston Martin",
                null,
                "Williams"
            };
            return aux;
        }

        #endregion

        /// <summary>
        /// El programa inicia en este metodo y se corre hasta que la variable 'Salida' sea igual a 5, el valor de 'Salida' sera retornado por el metodo 'MostrarMenu'.
        /// </summary>
        static void Main()
        {
            int salida = 0;
            while (salida != 5)
            {
                salida = MostrarMenu();
            };
        }

        /// <summary>
        /// Muestra el Menu principal del Programa
        /// </summary>
        /// <returns>Retorna un valor de salida que hara que el Main se siga ejecutando o no</returns>
        private static int MostrarMenu()
        {
            int opcionElegidaMenuPrincipal = 0;
            MostrarCategoria("MENU PRINCIPAL");
            Console.WriteLine("1. Pilotos");
            Console.WriteLine("2. Constructores");
            Console.WriteLine("3. Circuitos");
            Console.WriteLine("4. Campeonato de Constructores");
            Console.WriteLine("5. Salir");
            opcionElegidaMenuPrincipal = ValidarEleccionMenu(1, 5, "Error, reingresa opción: ", "Opción elegida: ");
            return ManipulacionGeneral(opcionElegidaMenuPrincipal);
        }

        /// <summary>
        /// Muestra el Submenu del programa, es invocado por el metodo 'ManipuladorDeOpcion'
        /// </summary>
        /// <param name="seleccion">hace referencia a la categoria de valores sobre los que se decide qué hacer</param>
        /// <returns>retorna la opcion elegida por el usuario</returns>
        static int MostrarSubMenu(string seleccion)
        {
            int aux;
            MostrarCategoria(seleccion);
            Console.WriteLine("1. Ver información");
            Console.WriteLine("2. Agregar/Editar Registros");
            Console.WriteLine("3. Eliminar Registros");
            Console.WriteLine("4. Volver al Menu Principal");
            aux = ValidarEleccionMenu(1, 4, "Error, reingresa opción: ", "Opción elegida: ");
            return aux;
        }

        #region Control del programa

        /// <summary>
        /// Es el disparador general, luego de recibir la opcion elegida en el main, se encarga de ordenar hacia que metodo debe dirigirse la aplicacion.
        /// </summary>
        /// <param name="opcionElegidaMenuPrincipal">Utiliza la opcion elegida en el menu principal</param>
        /// <returns>Devuelve un valor al metodo MostrarMenu que decide si el usuario sigue navegando o no en la aplicacion</returns>
        private static int ManipulacionGeneral(int opcionElegidaMenuPrincipal)
        {
            int opcionElegida;
            switch (opcionElegidaMenuPrincipal)
            {
                case 1:
                    opcionElegida = MostrarSubMenu("PILOTOS");
                    ManipulacionMatrizString(opcionElegida);
                    return 0;
                case 2:
                    opcionElegida = MostrarSubMenu("CONSTRUCTORES");
                    ManipulacionArrays(opcionElegida, "CONSTRUCTORES", constructores);
                    return 0;
                case 3:
                    opcionElegida = MostrarSubMenu("CIRCUITOS");
                    ManipulacionArrays(opcionElegida, "CIRCUITOS", circuito);
                    return 0;
                case 4:
                    opcionElegida = MostrarSubMenu("CAMPEONATO");
                    ManipulacionMatrizInt(opcionElegida);
                    return 0;
                case 5:
                    MostrarCategoria("SALIDA");
                    Console.WriteLine("Desea salir?\n1. Si\n2. No");
                    opcionElegida = ValidarEntero(1, 2, "Error! reingrese opción: ", "Opción: ");
                    if (opcionElegida == 1)
                    {
                        MostrarCategoria("Vuelva Pronto!");
                        Console.WriteLine("Gracias por vivir la Formula 1 en estado puro, si parpadeas te lo vas a perder!");
                        return 5;
                    }
                    else
                        return 0;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Es el controlador de las matrices de tipo entero, decide que hacer con las mismas dependiendo lo que decida el usuario.
        /// </summary>
        /// <param name="opcionElegida">Representa a lo que desea el usuario</param>
        private static void ManipulacionMatrizInt(int opcionElegida)
        {
            int filaAEditar;
            int columnaAEditar;
            switch (opcionElegida)
            {
                case 1:
                    MostrarCampeonato();
                    break;
                case 2:
                    MostrarCampeonato();
                    filaAEditar = ValidarEntero(0, 9, "Error, reingresa fila: ", "Fila elegida: ");
                    columnaAEditar = ValidarEntero(0, 9, "Error, reingrese columna: ", "Columna elegida: ");
                    ModificarInfoMatrizInt(puntosPorCarrera, filaAEditar, columnaAEditar, 1);
                    break;
                case 3:
                    MostrarCampeonato();
                    filaAEditar = ValidarEntero(0, 9, "Error, reingresa fila: ", "Fila elegida: ");
                    columnaAEditar = ValidarEntero(0, 9, "Error, reingrese columna: ", "Columna elegida: ");
                    ModificarInfoMatrizInt(puntosPorCarrera, filaAEditar, columnaAEditar, 2);
                    break;
                case 4:
                    break;
            }
        }

        /// <summary>
        /// Es el controlador de las matrices de tipo string, decide que hacer con las mismas dependiendo lo que decida el usuario.
        /// </summary>
        /// <param name="opcionElegida">Representa a lo que desea el usuario</param>
        private static void ManipulacionMatrizString(int opcionElegida)
        {
            int filaABorrar;
            int columnaABorrar;
            switch (opcionElegida)
            {
                case 1:
                    MostrarMatrizString(pilotos, "PILOTOS");
                    break;
                case 2:
                    MostrarMatrizString(pilotos, "PILOTOS");
                    filaABorrar = ValidarEntero(0, 9, "Error, reingresa fila: ", "Fila elegida: ");
                    columnaABorrar = ValidarEntero(0, 1, "Error, reingrese columna: ", "Columna elegida: ");
                    ModificarInfoMatrizString(pilotos, filaABorrar, columnaABorrar, 1);
                    break;
                case 3:
                    MostrarMatrizString(pilotos, "PILOTOS");
                    filaABorrar = ValidarEntero(0, 9, "Error, reingresa fila: ", "Fila elegida: ");
                    columnaABorrar = ValidarEntero(0, 1, "Error, reingrese columna: ", "Columna elegida: ");
                    ModificarInfoMatrizString(pilotos, filaABorrar, columnaABorrar, 2);
                    break;
                case 4:
                    break;
            }
        }

        /// <summary>
        /// Es el controlador de las matrices de tipo string, decide que hacer con las mismas dependiendo lo que decida el usuario.
        /// </summary>
        /// <param name="opcionElegida">Representa a lo que desea el usuario</param>
        /// <param name="categoria">Categoria especifica del array que se esta trabajando, se mostrara en el encabezado</param>
        /// <param name="aux">Array especifico que se esta trabajando</param>
        private static void ManipulacionArrays(int opcionElegida, string categoria, string[] aux)
        {
            int idABorrar;
            switch (opcionElegida)
            {
                case 1:
                    MostrarArrayString(aux, categoria);
                    break;
                case 2:
                    MostrarArrayString(aux, categoria);
                    idABorrar = ValidarEntero(0, 10, "Error, reingrese fila: ", "Fila elegida: ");
                    ModificarInfoArray(aux, idABorrar, 1);
                    break;
                case 3:
                    MostrarArrayString(aux, categoria);
                    idABorrar = ValidarEntero(0, 10, "Error, reingrese fila: ", "Fila elegida: ");
                    ModificarInfoArray(aux, idABorrar, 2);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Edición de Registros (Agregar, Modificar, Eliminar)

        /// <summary>
        /// Edita, Agrega o Elimina registros de una Matriz de tipo string
        /// </summary>
        /// <param name="aux">Matriz a modificar</param>
        /// <param name="filElegida">Fila seleccionada para trabajar</param>
        /// <param name="columnaElegida">Columna seleccionada para trabajar</param>
        /// <param name="accion">Accion a realizar, 1 para editar y agregar; 2 para borrar registros</param>
        private static void ModificarInfoMatrizString(string[,] aux, int filElegida, int columnaElegida, int accion)
        {
            for (int f = 0; f < aux.GetLength(0); f++)
            {
                if (f == filElegida && accion == 1)
                {
                    for (int c = 0; c < aux.GetLength(1); c++)
                    {
                        if (c == columnaElegida)
                        {
                            Console.WriteLine();
                            aux[f, c] = ValidarEleccionString("Valor a ingresar: ");
                            break;
                        }
                    }
                }
                else if (f == filElegida && accion == 2)
                {
                    for (int c = 0; c < aux.GetLength(1); c++)
                    {
                        if (c == columnaElegida)
                        {
                            aux[f, c] = null;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Edita, Agrega o Elimina registros de una Matriz de tipo entero
        /// </summary>
        /// <param name="aux">Matriz a modificar</param>
        /// <param name="filElegida">Fila seleccionada para trabajar</param>
        /// <param name="columnaElegida">Columna seleccionada para trabajar</param>
        /// <param name="accion">Accion a realizar, 1 para editar y agregar; 2 para borrar registros</param>
        private static void ModificarInfoMatrizInt(int[,] aux, int filElegida, int columnaElegida, int accion)
        {
            for (int f = 0; f < aux.GetLength(0); f++)
            {
                if (f == filElegida && accion == 1)
                {
                    for (int c = 0; c < aux.GetLength(1); c++)
                    {
                        if (c == columnaElegida)
                        {
                            aux[f, c] = ValidarEntero(0, 45, "Error, reingrese valor entre 0 y 45: ", "Ingrese un valor entre 0 y 45: ");
                            break;
                        }
                    }
                }
                else if (f == filElegida && accion == 2)
                {
                    for (int c = 0; c < aux.GetLength(1); c++)
                    {
                        if (c == columnaElegida)
                        {
                            aux[f, c] = 0;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Edita, Agrega o Elimina registros de un array de tipo string
        /// </summary>
        /// <param name="aux">array sobre el que se va a trabajar</param>
        /// <param name="idElegido">id a modificar</param>
        /// <param name="accion">Accion a realizar, 1 para editar y agregar; 2 para borrar registros</param>
        private static void ModificarInfoArray(string[] aux, int idElegido, int accion)
        {
            for (int f = 0; f < aux.Length; f++)
            {
                if (f == idElegido && accion == 1)
                {
                    Console.WriteLine();
                    aux[f] = ValidarEleccionString("Valor a ingresar: ");
                    break;
                }
                else if (f == idElegido && accion == 2)
                {
                    aux[f] = null;
                    break;
                }
            }
        }

        #endregion

        #region Vista de los registros

        /// <summary>
        /// Muestra un array de tipo string
        /// </summary>
        /// <param name="aux">array a trabajr</param>
        /// <param name="categoria">categoria especifica que estamos trabajando</param>
        static void MostrarArrayString(string[] aux, string categoria)
        {
            MostrarCategoria(categoria);
            Console.WriteLine(" --------------");
            for (int f = 0; f < aux.Length; f++)
            {
                Console.Write("|");
                EstilosCircuitos();
                Console.Write($"{f}) {aux[f],-12}");
                EstilosReset();
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine(" --------------");
            VolverAlMenu();
        }

        /// <summary>
        /// Muestra una matriz de tipo string
        /// </summary>
        /// <param name="aux">matriz a trabajar</param>
        /// <param name="categoria">categoria especifica que estamos trabajando</param>
        static void MostrarMatrizString(string[,] aux, string categoria)
        {
            MostrarCategoria(categoria);
            Console.WriteLine(" ===================== 0 ========= 1 ====");
            for (int f = 0; f < aux.GetLength(0); f++)
            {
                Console.Write("|");
                EstilosConstructores();
                Console.Write($"{ f}) {constructores[f],-12}");
                Console.Write("||");
                for (int c = 0; c < aux.GetLength(1); c++)
                {
                    EstilosPlotosyPuntos();
                    Console.Write($"{aux[f, c],-11}|");
                    EstilosReset();
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine(" ===================== 0 ========= 1 ====");
            VolverAlMenu();
        }

        /// <summary>
        /// Muestra el campeonato recuperando los arrays de 'constructores' y 'circuitos', y los cruza con la matriz de 'puntosPorCarrera', suma tambien una columna con el total de puntos de cada equipo
        /// </summary>
        static void MostrarCampeonato()
        {
            int puntos;
            MostrarCategoria("MUNDIAL");
            Console.WriteLine("----------------0---1---2---3---4---5---6---7---8---9--------");
            Console.Write(" |            ");
            EstilosCircuitos();
            MostrarArrayStringMundial(circuito);
            EstilosTotal();
            Console.Write("|Total");
            EstilosReset();
            Console.Write("|");
            Console.WriteLine();
            for (int f = 0; f < puntosPorCarrera.GetLength(0); f++)
            {
                Console.Write($"{f}|");
                EstilosConstructores();
                Console.Write($"{constructores[f],-12}");
                for (int c = 0; c < puntosPorCarrera.GetLength(1); c++)
                {
                    EstilosPlotosyPuntos();
                    Console.Write($"|{puntosPorCarrera[f, c],-3}");
                }
                EstilosTotal();
                Console.Write($"|{puntos = MundialPuntos(f),-4} ");
                EstilosReset();
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("----------------0---1---2---3---4---5---6---7---8---9--------");
            VolverAlMenu();
        }

        /// <summary>
        /// Suma los valores totales de una fila
        /// </summary>
        /// <param name="f">fila que se esta operando</param>
        /// <returns>sumatoria de los valores de cada columna de una fila</returns>
        static int MundialPuntos(int f)
        {
            int puntos = 0;
            for (int c = 0; c < puntosPorCarrera.GetLength(1); c++)
            {
                puntos += puntosPorCarrera[f, c];
            }
            return puntos;
        }

        /// <summary>
        /// Muestra los primeros tres valores de cada elementro de un array de strings, si el elemento es null, devuelve 3 espacios vacios
        /// </summary>
        /// <param name="aux">array a utilizar</param>
        static void MostrarArrayStringMundial(string[] aux)
        {
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == null)
                {
                    Console.Write($"|   ");
                }
                else
                {
                    Console.Write("|");
                    Console.Write(aux[i].ToCharArray(0, 3));
                }
            }
        }

        #endregion

        #region Adicionales graficos

        /// <summary>
        /// Dibuja el encabezado de cada seccion
        /// </summary>
        /// <param name="categoria">Indica la categoria especifica que se esta trabajando</param>
        static void MostrarCategoria(string categoria)
        {
            Console.Clear();
            string aux = "FORMULA 1";
            string titulo = $"|>>>>>>>> {aux,-14} <<<<<<<<|";
            string subtitulo = $"|>>>>>>>> {categoria,-14} <<<<<<<<|";
            string asterisquitos = string.Empty;

            for (int i = 0; i < titulo.Length; i++)
            {
                asterisquitos += "-";
            }

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(asterisquitos);
            Console.WriteLine(titulo);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(subtitulo);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(asterisquitos);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        /// <summary>
        /// Color del fondo y letra para los Constructores
        /// </summary>
        static void EstilosConstructores()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Color del fondo y letra para los circuitos
        /// </summary>
        static void EstilosCircuitos()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// Color del fondo y letra para los Pilotos y la tabla de puntos
        /// </summary>
        static void EstilosPlotosyPuntos()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// Color del fondo y letra normales de la consola
        /// </summary>
        static void EstilosReset()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Color del fondo y letra para los totales
        /// </summary>
        static void EstilosTotal()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Nos permite mantener informacion en pantalla hasta que se pulse una tecla
        /// </summary>
        static void VolverAlMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        #endregion

        #region Validaciones

        /// <summary>
        /// Valida la eleccion del usuario dentro del menu y el submenu
        /// </summary>
        /// <param name="min">valor minimo aceptado</param>
        /// <param name="max">valor maximo aceptado</param>
        /// <param name="error">mensaje que se muestra en caso de error</param>
        /// <param name="entrada">mensaje de entrada</param>
        /// <returns></returns>
        static int ValidarEleccionMenu(int min, int max, string error, string entrada)
        {
            int aux;
            bool auxBool = false;
            
            Console.WriteLine();
            Console.Write(entrada);
            Console.WriteLine();
            auxBool = int.TryParse(Console.ReadLine(), out aux);
            while (auxBool != true || aux < min || aux > max)
            {
                Console.Write(error);
                auxBool = int.TryParse(Console.ReadLine(), out aux);
                Console.WriteLine();
            };
            return aux;
        }
        
        /// <summary>
        /// Valida entradas del tipo entero
        /// </summary>
        /// <param name="min">valor minimo aceptado</param>
        /// <param name="max">valor maximo aceptado</param>
        /// <param name="error">mensaje que se muestra en caso de error</param>
        /// <param name="entrada">mensaje de entrada</param>
        /// <returns></returns>
        static int ValidarEntero(int min, int max, string error, string entrada)
        {
            int aux;
            bool auxBool = false;
            
            Console.WriteLine();
            Console.Write(entrada);
            auxBool = int.TryParse(Console.ReadLine(), out aux);
            while (auxBool != true || aux < min || aux > max)
            {
                Console.WriteLine();
                Console.Write(error);
                auxBool = int.TryParse(Console.ReadLine(), out aux);
                Console.WriteLine();
            };
            return aux;
        }

        /// <summary>
        /// Valida un ingreso del tipo string mostrando el menu que se utiliza para verificar si el dato ingresado por el usuario es el deseado
        /// </summary>
        /// <param name="textoAMostrar">el texto que se muestra en pantalla previo a ingresar el dato</param>
        static string ValidarEleccionString(string textoAMostrar)
        {
            string aux = "";
            int opcionElegida;
            
            do
            {
                Console.Write(textoAMostrar);
                aux = Console.ReadLine();
                while (aux == null)
                {
                    Console.Write(textoAMostrar);
                    aux = Console.ReadLine();
                }
                opcionElegida = ValidarEntero(1, 2, $"Error, Usted ingreso: {aux}. Es correcto?\n1. Si\n2. No\n", $"Usted ingreso: {aux}. Es correcto?\n1. Si\n2. No\n");
                Console.WriteLine();
            } while (opcionElegida == 2);
            return aux;
        }

        #endregion

    }
}

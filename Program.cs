namespace TrabajoPractico7{
    class Program{
        static void Main(string[] args){
            List<Tareas> listaTareas = new List<Tareas>();
            List<Tareas> tareasRealizadas = new List<Tareas>();
            int cantidad, duracion, estaRealizada, sumatoriaHoras = 0;
            string descripcion;
            Random numRandom = new Random();
            bool encontrado = false;

            Console.Write("Ingrese la cantidad de tareas a ingresar: ");
            cantidad = int.Parse(Console.ReadLine());

            for(int i = 0; i < cantidad;  i++){
                Console.Write("Ingrese la descripción de la tarea: ");
                descripcion = Console.ReadLine();

                duracion = numRandom.Next(10, 101);

                listaTareas.Add(new Tareas(i + 1, descripcion, duracion));
            }

            foreach(Tareas tarea in listaTareas){
                Console.WriteLine(tarea + "\n");

                do
                {
                    Console.Write("Está realizada la tarea? (1: Si / 2: No): ");
                    estaRealizada = Int32.Parse(Console.ReadLine());
                } while (estaRealizada != 1 && estaRealizada != 2);

                if(estaRealizada == 1){
                    tareasRealizadas.Add(tarea);
                }
            }

            foreach(Tareas tarea in tareasRealizadas){
                listaTareas.Remove(tarea);
            }

            Console.WriteLine("Mostrando tareas realizadas\n");
            foreach(Tareas tarea in tareasRealizadas){
                Console.WriteLine(tarea + "\n");
            }

            Console.WriteLine("Mostrando tareas no realizadas\n");
            foreach(Tareas tarea in listaTareas){
                Console.WriteLine(tarea + "\n");
            }

            Console.Write("Ingrese una descripción para buscar la tarea: ");
            descripcion = Console.ReadLine();

            Console.WriteLine("Buscando en tareas realizadas");
            foreach(Tareas tarea in tareasRealizadas){
                if(tarea.Descripcion1 == descripcion){
                    Console.WriteLine(tarea);
                    encontrado = true;
                    break;
                }
            }

            if(!encontrado){
                Console.WriteLine("Buscando en tareas pendientes");
                foreach(Tareas tarea in listaTareas){
                    if(tarea.Descripcion1 == descripcion){
                        Console.WriteLine(tarea);
                        encontrado = true;
                        break;
                    }
                }
            }

            if(!encontrado){
                Console.WriteLine("No se encontro la tarea solicitada");
            }

            foreach(Tareas tarea in tareasRealizadas){
                sumatoriaHoras += tarea.Duracion1;
            }

            Console.WriteLine("En total, se trabajaron {0} horas con {1} minutos", Math.Floor(Convert.ToDecimal(sumatoriaHoras / 60)), sumatoriaHoras % 60);
        }
    }
}
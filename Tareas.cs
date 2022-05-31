namespace TrabajoPractico7{
    class Tareas{
        private int TareaID;
        private string Descripcion;
        private int Duracion;

        public int TareaID1 { get => TareaID; set => TareaID = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int Duracion1 { get => Duracion; set => Duracion = value; }

        public Tareas(int ID, string desc, int dur){
            this.TareaID1 = ID;
            this.Descripcion1 = desc;
            this.Duracion1 = dur;
        }

        public override string ToString()
        {
            string cadena = "";

            cadena += $"ID: {this.TareaID1}\n";
            cadena += $"Descripción: {this.Descripcion1}\n";
            cadena += $"Duración: {this.Duracion1}\n";

            return cadena;
        }
    }
}
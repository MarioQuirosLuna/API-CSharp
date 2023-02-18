namespace Clinica_Salud_Con_API.Models
{
    public class Medico
    {
        public int Id_Medico { get; set; }
        public int FK_Id_Consultorio { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public int Id_Especialidad { get; set; }
        public string Nombre_Especialidad { get; set; }
        public Medico(int Id_Medico, int FK_Id_Consultorio, int Cedula, string Nombre, int Id_Especialidad, string Nombre_Especialidad)
        {
            this.Id_Medico = Id_Medico;
            this.FK_Id_Consultorio = FK_Id_Consultorio;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Id_Especialidad = Id_Especialidad;
            this.Nombre_Especialidad = Nombre_Especialidad;
        }
    }
}

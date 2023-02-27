namespace Clinica_Salud_Con_API.Models
{
    public class Especialidad
    {
        public int Id_Especialidad { get; set; }
        public string Nombre_Especialidad { get; set;}
        public Especialidad(int Id_Especialidad, string Nombre_Especialidad)
        {
            this.Id_Especialidad = Id_Especialidad;
            this.Nombre_Especialidad = Nombre_Especialidad;
        }
    }
}

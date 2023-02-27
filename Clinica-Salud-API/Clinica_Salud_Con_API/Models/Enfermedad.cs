namespace Clinica_Salud_Con_API.Models
{
    public class Enfermedad
    {
        public int Id_Enfermedad { get; set; }
        public string Nombre_Enfermedad { get; set; }
        public Enfermedad(int Id_Enfermedad, string Nombre_Enfermedad)
        {
            this.Id_Enfermedad = Id_Enfermedad;
            this.Nombre_Enfermedad = Nombre_Enfermedad;
        }
    }
}

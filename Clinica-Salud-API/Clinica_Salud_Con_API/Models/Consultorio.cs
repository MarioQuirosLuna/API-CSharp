namespace Clinica_Salud_Con_API.Models
{
    public class Consultorio
    {
        public int Id_Consultorio { get; set; }
        public int Numero_Piso { get; set; }

        public Consultorio(int Id_Consultorio, int Numero_Piso) {
            this.Id_Consultorio = Id_Consultorio;
            this.Numero_Piso = Numero_Piso;
        }
    }
}

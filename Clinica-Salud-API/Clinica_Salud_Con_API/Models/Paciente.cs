namespace Clinica_Salud_Con_API.Models
{
    public class Paciente
    {
        public int Id_Paciente { get; set; }
        public int FK_Id_Consultorio { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        //public string[] Enfermedades { get; set; }
        public Enfermedad[] Enfermedades { get; set; }
        public Paciente(int Id_Paciente, int FK_Id_Consultorio, int Cedula, string Nombre, Enfermedad[] Enfermedades)
        {
            this.Id_Paciente = Id_Paciente;
            this.FK_Id_Consultorio = FK_Id_Consultorio;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Enfermedades = Enfermedades;
        }
    }
}

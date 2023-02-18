namespace Clinica_Salud_Con_API.Database
{
    public class Connection
    {
        private string connectionString = string.Empty;
        public Connection() 
        {
            //Variable referenciando nuestro archivo de configuracion
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            //creamos la variable que contendra la cadena de conexion
            connectionString = builder.GetSection("ConnectionStrings:DB_Connection").Value;
        }
        public string GetConnection()
        {
            //para retornar la cadena de conexion
            return connectionString;
        }
    }
}

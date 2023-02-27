using Clinica_Salud_Con_API.Database;
using Clinica_Salud_Con_API.Models;
using Microsoft.Data.SqlClient;

namespace Clinica_Salud_Con_API.Data
{
    public class MedicoData
    {
        Connection connectionDb = new Connection();
        public async Task<List<Medico>> MostrarMedicos()
        { 
            var listaMedicos = new List<Medico>();
            //abrir connection y cierra de manera automatica
            using (var sql = new SqlConnection(connectionDb.GetConnection()))
            {
                using (var cmd = new SqlCommand("sp_ObtenerMedicos", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                    //recorre todos los registros devueltos
                        while (await item.ReadAsync())
                        {
                            listaMedicos.Add(
                                new Medico(
                                    (int)item["ID_MEDICO"],
                                    (int)item["NUMERO_CONSULTORIO"],
                                    (int)item["CEDULA"],
                                    (string)item["NOMBRE"],
                                    -1,
                                    (string)item["ESPECIALIDAD"]
                                )
                            );
                        }
                    }
                    return listaMedicos;
                }
            }
        }

        public async Task InsertarMedico(Medico medico)
        {
            using (var sql = new SqlConnection(connectionDb.GetConnection()))
            {
                using (var cmd = new SqlCommand("sp_InsertarMedico", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@param_Cedula", medico.Cedula);
                    cmd.Parameters.AddWithValue("@param_Nombre", medico.Nombre);
                    cmd.Parameters.AddWithValue("@param_Consultorio", medico.FK_Id_Consultorio);
                    cmd.Parameters.AddWithValue("@param_Especialidad", medico.Id_Especialidad);

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task ActualizarMedico(Medico medico)
        {
            using (var sql = new SqlConnection(connectionDb.GetConnection()))
            {
                using (var cmd = new SqlCommand("sp_ActualizarMedico", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@param_IdMedico", medico.Id_Medico);
                    cmd.Parameters.AddWithValue("@param_Nombre", medico.Nombre);
                    cmd.Parameters.AddWithValue("@param_Consultorio", medico.FK_Id_Consultorio);
                    cmd.Parameters.AddWithValue("@param_Especialidad", medico.Id_Especialidad);

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EliminarMedico(int id_medico)
        {
            using (var sql = new SqlConnection(connectionDb.GetConnection()))
            {
                using (var cmd = new SqlCommand("sp_EliminarMedico", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@param_IdMedico", id_medico);

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}

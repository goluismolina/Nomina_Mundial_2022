using System.Data.SqlClient;

namespace Equipos.DATOS.Repositorios
{
    public class SeleccionesRepositorio : ISeleccionesRepositorio
    {
        private readonly IConfiguration _configuration;

        public SeleccionesRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<Selecciones> ObtenerTodas()
        {
            var listaSelecciones = new List<Selecciones>();
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("ConexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_obtener_selecciones", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            sql.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nuevaSeleccion = new Selecciones { Id = (int)reader["Id"], Seleccion = reader["Seleccion"].ToString() };
                    listaSelecciones.Add(nuevaSeleccion);
                }
            }
            return listaSelecciones;
        }
        public void CrearSeleccion(Selecciones seleciones)
        {
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("ConexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_insertar_seleccion", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Seleccion", seleciones.Seleccion));
            sql.Open();
            cmd.ExecuteNonQuery();

        }
        public Selecciones ObtenerPorId(int id)
        {
            var seleccion = new Selecciones(); 
            var listaSelecciones = new List<Selecciones>();
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("ConexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_obtener_seleccion_por_id", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            sql.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nuevaSeleccion = new Selecciones { Id = (int)reader["Id"], Seleccion = reader["Seleccion"].ToString() };
                    seleccion = nuevaSeleccion;
                }
            }
            return seleccion;
        }
        public void ActualizarSeleccion(Selecciones seleciones)
        {
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("ConexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_actualiza_seleccion", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", seleciones.Id));
            cmd.Parameters.Add(new SqlParameter("@Seleccion", seleciones.Seleccion));
            sql.Open();
            cmd.ExecuteNonQuery();

        }
        public void EliminarSeleccion(int id)
        {
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("ConexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_eliminar_seleccion", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id",id));
            sql.Open();
            cmd.ExecuteNonQuery();
        }
         
    }

}
    

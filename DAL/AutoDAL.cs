using BD_AUTO.Models;
using Microsoft.Data.SqlClient;

namespace BD_AUTO.DAL
{
    public class AutoDAL
    {
        private readonly string cadenaConexion;

        public AutoDAL(IConfiguration configuration)
        {
            cadenaConexion = configuration.GetConnectionString("ConexionBD");
        }


        // vamos a listar los autos
        public List<Auto> Listar()
        {
            List<Auto> lista = new List<Auto>();

            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string sql = @"SELECT 
                                pk_id_auto_in,
                                marca_vc,
                                color_vc,
                                modelo_vc,
                                año_in
                               FROM AUTO";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {


                        while (dr.Read())
                        {
                            Auto auto = new Auto();

                            auto.pkp_id_auto_in = Convert.ToInt32(dr["pk_id_auto_in"]);
                            auto.marca_vc = dr["marca_vc"].ToString();
                            auto.color_vc = dr["color_vc"].ToString();
                            auto.modelo_vc = dr["modelo_vc"].ToString();
                            auto.año_in = Convert.ToInt32(dr["año_in"]);

                            lista.Add(auto);
                        }
                    }
                }
            }

            return lista;
        }


        public Auto Buscar(int id)
        {
            Auto auto = null;

            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string sql = @"SELECT 
                                pk_id_auto_in,
                                marca_vc,
                                color_vc,
                                modelo_vc,
                                año_in
                              FROM AUTO
                              WHERE pk_id_auto_in = @id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            auto = new Auto();

                            auto.pkp_id_auto_in = Convert.ToInt32(dr["pk_id_auto_in"]);
                            auto.marca_vc = dr["marca_vc"].ToString();
                            auto.color_vc = dr["color_vc"].ToString();
                            auto.modelo_vc = dr["modelo_vc"].ToString();
                            auto.año_in = Convert.ToInt32(dr["año_in"]);

                        }
                    }
                }
            }

            return auto;
        }


        public void Insertar(Auto auto)
        {

            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string sql = @"INSERT INTO AUTO
                                    (marca_vc,color_vc,modelo_vc,año_in)
                                VALUES
                                    (@marca,@color,@modelo,@año)";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@marca", auto.marca_vc);
                    cmd.Parameters.AddWithValue("@color", auto.color_vc);
                    cmd.Parameters.AddWithValue("@modelo", auto.modelo_vc);
                    cmd.Parameters.AddWithValue("@año", auto.año_in);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualilzar(Auto auto)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string sql = @"UPDATE AUTO
                                SET marca_vc = @marca,
                                    color_vc = @color,
                                    modelo_vc = @modelo,
                                    año_in = @año
                                WHERE pk_id_auto_in = @id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", auto.pkp_id_auto_in);
                    cmd.Parameters.AddWithValue("@marca", auto.marca_vc);
                    cmd.Parameters.AddWithValue("@color", auto.color_vc);
                    cmd.Parameters.AddWithValue("@modelo", auto.modelo_vc);
                    cmd.Parameters.AddWithValue("@año", auto.año_in);

                    cn.Open();

                    cmd.ExecuteNonQuery();

                }
            }

        }


        public void Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string sql = @"DELETE AUTO
                                WHERE pk_id_auto_in = @id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();

                    cmd.ExecuteNonQuery();

                }
            }

        }

    }
}

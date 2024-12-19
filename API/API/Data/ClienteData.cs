using System.Data;
using API.Models;
using Microsoft.Data.SqlClient;

namespace API.Data
{
    public class ClienteData
    {
        public static List<Cliente> ListarClientes(int pagina, int tamano_pagina)
        {
            List<Cliente> oListaCliente= new List<Cliente>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("get_clientes_por_pagina", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pagina", pagina);
                cmd.Parameters.AddWithValue("@tamano_pagina", tamano_pagina);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaCliente.Add(new Cliente()
                            {
                                id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                cliente = dr["cliente"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                pais = dr["pais"].ToString()
                            });
                        }

                    }



                    return oListaCliente;
                }
                catch (Exception)
                {
                    return oListaCliente;
                }
            }
        }
    }
}

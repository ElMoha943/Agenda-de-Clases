using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Classroom.Models;

namespace Classroom
{
    public class DB
    {
        private readonly string connectionString;

        public DB()
        {
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=classroom;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public List<Clase> GetClases(DateTime startDate, DateTime endDate)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"select * from clases where fecha between @startDate and @endDate
                                            order by fecha DESC";
                    command.Parameters.Add("@startDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<Clase>();
                    while (reader.Read())
                    {
                        resultTable.Add(new Clase {
                            Fecha = (DateTime)reader[1],
                            Alumno = (string)reader[2],
                            Duracion = (int)reader[3],
                            Costo = (int)reader[3] * 400,
                            Paga = (bool)reader[4],
                            Asignatura = (string)reader[5]
                        });
                    }
                    return resultTable;
                }
            }
        }

        public List<Clase> GetClases(DateTime startDate, DateTime endDate, string student)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"select * from clases where alumno = @student AND 
                                            Fecha between @startDate and @endDate 
                                            order by fecha DESC";
                    command.Parameters.Add("@startDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.Add("@student",System.Data.SqlDbType.NChar).Value = student;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<Clase>();
                    while (reader.Read())
                    {
                        resultTable.Add(new Clase
                        {
                            Fecha = (DateTime)reader[1],
                            Alumno = (string)reader[2],
                            Duracion = (int)reader[3],
                            Costo = (int)reader[3] * 400,
                            Paga = (bool)reader[4],
                            Asignatura = (string)reader[5]
                        });
                    }
                    return resultTable;
                }
            }
        }
        public List<Clase> GetClases(string materia, DateTime startDate, DateTime endDate)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"select * from clases where asignatura = @materia AND
                                            Fecha between @startDate and @endDate 
                                            order by fecha DESC";
                    command.Parameters.Add("@startDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.Add("@materia", System.Data.SqlDbType.VarChar).Value = materia;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<Clase>();
                    while (reader.Read())
                    {
                        resultTable.Add(new Clase
                        {
                            Fecha = (DateTime)reader[1],
                            Alumno = (string)reader[2],
                            Duracion = (int)reader[3],
                            Costo = (int)reader[3] * 400,
                            Paga = (bool)reader[4],
                            Asignatura = (string)reader[5]
                        });
                    }
                    return resultTable;
                }
            }
        }
        public List<Clase> GetClases(DateTime startDate, DateTime endDate, string student, string materia)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"select * from clases where alumno = @student AND
                                            asignatura = @materia AND Fecha between @startDate and @endDate 
                                            order by fecha DESC";
                    command.Parameters.Add("@startDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.Add("@student", System.Data.SqlDbType.NChar).Value = student;
                    command.Parameters.Add("@materia", System.Data.SqlDbType.VarChar).Value = materia;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<Clase>();
                    while (reader.Read())
                    {
                        resultTable.Add(new Clase
                        {
                            Fecha = (DateTime)reader[1],
                            Alumno = (string)reader[2],
                            Duracion = (int)reader[3],
                            Costo = (int)reader[3] * 400,
                            Paga = (bool)reader[4],
                            Asignatura = (string)reader[5]
                        });
                    }
                    return resultTable;
                }
            }
        }

        public void AddClase(DateTime fecha, string alumno, int duracion, string asignatura)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"insert into clases (fecha, alumno, duracion, asignatura) values (@fecha, @alumno, @duracion, @asignatura)";
                    command.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime).Value = fecha;
                    command.Parameters.Add("@alumno", System.Data.SqlDbType.NChar).Value = alumno;
                    command.Parameters.Add("@duracion", System.Data.SqlDbType.Int).Value = duracion;
                    command.Parameters.Add("@asignatura", System.Data.SqlDbType.Text).Value = asignatura;
                    var reader = command.ExecuteNonQuery();
                }
            }
        }

        public List<Alumno> GetAlumnos()
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"select * from alumnos";
                    var reader = command.ExecuteReader();
                    var resultTable = new List<Alumno>();
                    while (reader.Read())
                    {
                        resultTable.Add(new Alumno
                        {
                            Name = (string)reader[1],
                            Surname = (string)reader[2],
                            School = (string)reader[3],
                            Year = (string)reader[4],
                            Email = (string)reader[5],
                            Phone = (string)reader[6]
                        });
                    }
                    return resultTable;
                }
            }
        }

    }
}

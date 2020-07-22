using System.Collections.Generic;
using System.Data.SqlClient;

namespace MultiForm
{
    public class Database
    {
        private const string CONN_STRING
            = "Server=.\\SQLEXPRESS;Database=Personnel;Trusted_Connection=True;";
        private const string READ_COMMAND
            = "SELECT * FROM Employee";
        private const string INSERT_COMMAND
            = "INSERT INTO Employee (name,position,hourly_pay_rate) " +
              "VALUES (@name, @position, @hourly_pay_rate)";
        private const string UPDATE_COMMAND
            = "UPDATE Employee " +
            "SET name = @name, position = @position, " +
            "hourly_pay_rate = @hourly_pay_rate " +
            "WHERE employeeId = @employeeId";
        private const string DELETE_COMMAND
            = "DELETE FROM Employee " +
            "WHERE employeeId = @employeeId";

        private static Database db;

        private readonly SqlConnection conn;

        //getting instance of database
        public static Database GetInstance()
        {
            if (db == null)
                db = new Database();
            return db;
        }

        //creating connection to database
        private Database()
        {
            conn = new SqlConnection(CONN_STRING);
            conn.Open();
        }

        //Reading data from database table
        public List<Employee> Read()
        {
            var employees = new List<Employee>();
            var command = new SqlCommand(READ_COMMAND, conn);
            var reader = command.ExecuteReader();

            while (reader.Read())  
            {
                var empId = reader.GetOrdinal("employeeId");
                var name = reader.GetOrdinal("name");
                var position = reader.GetOrdinal("position");
                var hourPayRate = reader.GetOrdinal("hourly_pay_rate");

                employees.Add(new Employee
                {
                    employeeId = reader.GetInt32(empId),
                    name = reader.GetString(name),
                    position = reader.GetString(position),
                    hourly_pay_rate = reader.GetString(hourPayRate),
                });
            }
            reader.Close();
            return employees;
        }

        //insert data into database table
        public int Insert(Employee emp)
        {
            var command = new SqlCommand(INSERT_COMMAND, conn);
            command.Parameters.AddWithValue("@name", emp.name ?? "");
            command.Parameters.AddWithValue("@position", emp.position ?? "");
            command.Parameters.AddWithValue("@hourly_pay_rate", emp.hourly_pay_rate ?? "");
            return command.ExecuteNonQuery();
        }

        //update data into database table
        public int Update(Employee emp)
        {
            var command = new SqlCommand(UPDATE_COMMAND, conn);
            command.Parameters.AddWithValue("@employeeId", emp.employeeId);
            command.Parameters.AddWithValue("@name", emp.name ?? "");
            command.Parameters.AddWithValue("@position", emp.position ?? "");
            command.Parameters.AddWithValue("@hourly_pay_rate", emp.hourly_pay_rate ?? "");
            return command.ExecuteNonQuery();
        }

        //delete data from database table
        public int Delete(int empId)
        {
            var command = new SqlCommand(DELETE_COMMAND, conn);
            command.Parameters.AddWithValue("@employeeId", empId);
            return command.ExecuteNonQuery();
        }
    }
}

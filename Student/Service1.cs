using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Student
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private string connectionString = "Data Source=MRSILENT\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True"; // Move this to a configuration file

        public List<Student> AllStudents()
        {
            List<Student> studentList = new List<Student>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Student";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            StdId = (int)reader["StdId"],
                            Name = reader["Name"].ToString(),
                            Education = reader["Education"].ToString(),
                            DOB = (DateTime)reader["DOB"],
                            Age = (int)reader["Age"],
                            AddDate = (DateTime)reader["AddDate"],
                            Address = reader["Address"].ToString()
                        };
                        studentList.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error retrieving students: " + ex.Message);
            }
            return studentList;
        }

        public Student GetStudent(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Student WHERE StdId = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Student
                        {
                            StdId = (int)reader["StdId"],
                            Name = reader["Name"].ToString(),
                            Education = reader["Education"].ToString(),
                            DOB = (DateTime)reader["DOB"],
                            Age = (int)reader["Age"],
                            AddDate = (DateTime)reader["AddDate"],
                            Address = reader["Address"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error retrieving student: " + ex.Message);
            }
            return null;
        }

        public string AddStudent(Student student)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Student (Name, Education, DOB, Age, AddDate, Address) VALUES (@Name, @Education, @DOB, @Age, @AddDate, @Address)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Education", student.Education);
                    command.Parameters.AddWithValue("@DOB", student.DOB);
                    command.Parameters.AddWithValue("@Age", student.Age);
                    command.Parameters.AddWithValue("@AddDate", student.AddDate);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return "Student added successfully.";
                    else
                        return "Failed to add student.";
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error adding student: " + ex.Message);
                return "An error occurred while adding the student.";
            }
        }

        public string UpdateStudent(Student student)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Student SET Name = @Name, Education = @Education, DOB = @DOB, Age = @Age, AddDate = @AddDate, Address = @Address WHERE StdId = @StdId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Education", student.Education);
                    command.Parameters.AddWithValue("@DOB", student.DOB);
                    command.Parameters.AddWithValue("@Age", student.Age);
                    command.Parameters.AddWithValue("@AddDate", student.AddDate);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@StdId", student.StdId);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return "Student updated successfully.";
                    else
                        return "Failed to update student.";
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error updating student: " + ex.Message);
                return "An error occurred while updating the student.";
            }
        }

        public string DeleteStudent(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Student WHERE StdId = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return "Student deleted successfully.";
                    else
                        return "Failed to delete student.";
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error deleting student: " + ex.Message);
                return "An error occurred while deleting the student.";
            }
        }

        public List<Attendance> AllAttendance()
        {
            List<Attendance> attendanceList = new List<Attendance>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Attendance";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Attendance attendance = new Attendance
                        {
                            AttendanceId = (int)reader["AttendanceId"],
                            StuId = (int)reader["StuId"],
                            attendance = reader["Attendance"].ToString()
                        };
                        attendanceList.Add(attendance);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error retrieving attendance: " + ex.Message);
            }
            return attendanceList;
        }

        public string AddAttendance(Attendance attendance)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Attendance (StuId, Attendance) VALUES (@StuId, @Attendance)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StuId", attendance.StuId);
                    command.Parameters.AddWithValue("@Attendance", attendance.attendance);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return "Attendance added successfully.";
                    else
                        return "Failed to add attendance.";
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error adding attendance: " + ex.Message);
                return "An error occurred while adding the attendance.";
            }
        }

        public string DeleteAttendance(int attendanceId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Attendance WHERE AttendanceId = @AttendanceId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AttendanceId", attendanceId);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return "Attendance deleted successfully.";
                    else
                        return "Failed to delete attendance.";
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error deleting attendance: " + ex.Message);
                return "An error occurred while deleting the attendance.";
            }
        }


    }
}


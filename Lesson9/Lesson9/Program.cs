using System;
using System.Data.SqlClient;

namespace lesson9;

class Program
{
    static string connectionString = "Server=;Database=;Trusted_Connection=True;";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== Student Management Menu =====");
            Console.WriteLine("1. Display All Students");
            Console.WriteLine("2. Add New Student");
            Console.WriteLine("3. Search Student by Name");
            Console.WriteLine("4. Update GPA by Student ID");
            Console.WriteLine("5. Delete Student by ID");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": DisplayAllStudents(); break;
                case "2": AddNewStudent(); break;
                case "3": SearchStudentByName(); break;
                case "4": UpdateGPAByStudentId(); break;
                case "5": DeleteStudentById(); break;
                case "0": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void DisplayAllStudents()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Students";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\n--- All Students ---");
                Console.WriteLine("{0,-5} {1,-25} {2,-12} {3,-30} {4,-5}", "ID", "Full Name", "DOB", "Email", "GPA");
                Console.WriteLine(new string('-', 80));

                while (reader.Read())
                {
                    Console.WriteLine("{0,-5} {1,-25} {2,-12:yyyy-MM-dd} {3,-30} {4,-5:F2}",
                        reader["StudentId"], reader["FullName"], reader["DateOfBirth"],
                        reader["Email"], reader["GPA"]);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error displaying students: " + ex.Message);
        }
    }

    static void AddNewStudent()
    {
        try
        {
            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter date of birth (yyyy-MM-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime dob))
            {
                Console.WriteLine("Invalid date format.");
                return;
            }

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter GPA (0 - 4.0): ");
            if (!double.TryParse(Console.ReadLine(), out double gpa) || gpa < 0 || gpa > 4.0)
            {
                Console.WriteLine("Invalid GPA.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Students (FullName, DateOfBirth, Email, GPA) 
                                     VALUES (@FullName, @DateOfBirth, @Email, @GPA)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@GPA", gpa);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? "Student added successfully." : "Insert failed.");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Database error: " + ex.Message);
        }
    }

    static void SearchStudentByName()
    {
        Console.Write("Enter name keyword: ");
        string keyword = Console.ReadLine();

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Students WHERE FullName LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\n--- Search Results ---");
                Console.WriteLine("{0,-5} {1,-25} {2,-12} {3,-30} {4,-5}", "ID", "Full Name", "DOB", "Email", "GPA");
                Console.WriteLine(new string('-', 80));

                while (reader.Read())
                {
                    Console.WriteLine("{0,-5} {1,-25} {2,-12:yyyy-MM-dd} {3,-30} {4,-5:F2}",
                        reader["StudentId"], reader["FullName"], reader["DateOfBirth"],
                        reader["Email"], reader["GPA"]);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error searching students: " + ex.Message);
        }
    }

    static void UpdateGPAByStudentId()
    {
        Console.Write("Enter student ID: ");
        if (!int.TryParse(Console.ReadLine(), out int studentId))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        Console.Write("Enter new GPA: ");
        if (!double.TryParse(Console.ReadLine(), out double newGpa) || newGpa < 0 || newGpa > 4.0)
        {
            Console.WriteLine("Invalid GPA.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Students SET GPA = @GPA WHERE StudentId = @StudentId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GPA", newGpa);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "GPA updated." : "Student not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error updating GPA: " + ex.Message);
        }
    }

    static void DeleteStudentById()
    {
        Console.Write("Enter student ID to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int studentId))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Students WHERE StudentId = @StudentId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "Student deleted." : "Student not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error deleting student: " + ex.Message);
        }
    }
}

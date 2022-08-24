using Microsoft.Data.SqlClient;
namespace Citizen_Portal.Models
{
    public class UserRepository
    {
        public static string Add_User(User user)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = citizen_portal_database; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //if (user.Name == null)
            //{
            //    user.Name = "";
            //}
            //else if (user.Email == null)
            //{
            //    user.Email = "";
            //}
            //else if (user.Password == null)
            //{
            //    user.Password = "";
            //}
            //else if (user.MobileNumber == null)
            //{
            //    user.MobileNumber = "";
            //}
            //else if (user.DOB == null)
            //{
            //    user.DOB = "";
            //}
            //else if (user.Gender == null)
            //{
            //    user.Gender = "";
            //}
            //else if (user.Province == null)
            //{
            //    user.Province = "";
            //}
            //else if (user.District == null)
            //{
            //    user.District = "";
            //}
            //else if (user.postalCode == null)
            //{
            //    user.postalCode = "";
            //}
            //else if (user.Tehsil == null)
            //{
            //    user.Tehsil = "";
            //}
            //else if (user.Address == null)
            //{
            //    user.Address = "";
            //}
            //else if (user.Status == null)
            //{
            //    user.Status = "";
            //}
            //else if (user.Area_Code == null)
            //{
            //    user.Area_Code = "";
            //}
            //else if (user.User_Type == null)
            //{
            //    user.User_Type = "";
            //}
            //else if (user.TelephoneNumber == null)
            //{
            //    user.TelephoneNumber = "";
            //}
            SqlParameter Name = new SqlParameter("Name", user.Name);
            SqlParameter CNIC = new SqlParameter("CNIC", user.CNIC);
            SqlParameter Email = new SqlParameter("Email", user.Email);
            SqlParameter Password = new SqlParameter("Password", user.Password);
            SqlParameter MobileNumber = new SqlParameter("MobileNumber", user.MobileNumber);
            SqlParameter DOB = new SqlParameter("DOB", user.DOB);
            SqlParameter Gender = new SqlParameter("Gender", user.Gender);
            SqlParameter Province = new SqlParameter("Province", user.Province);
            SqlParameter District = new SqlParameter("District", user.District);
            SqlParameter postalCode = new SqlParameter("postalCode", user.postalCode);
            SqlParameter Tehsil = new SqlParameter("Tehsil", user.Tehsil);
            SqlParameter Address = new SqlParameter("Address", user.Address);
            //SqlParameter Status = new SqlParameter("Status", user.Status);
            SqlParameter Area_Code = new SqlParameter("Area_Code", user.Area_Code);
            //SqlParameter User_Type = new SqlParameter("User_Type", user.User_Type);
            SqlParameter TelephoneNumber = new SqlParameter("TelephoneNumber", user.TelephoneNumber);
            //string querry = $"INSERT INTO [User] (Name, CNIC, Email, Password, MobileNumber, DOB, Gender, Province, District, postalCode,Tehsil, Address, Status, Area_Code, User_Type, TelephoneNumber) VALUES (@Name, @CNIC, @Email, @Password, @MobileNumber, @DOB, @Gender, @Province, @District, @postalCode, @Tehsil, @Address, @Status, @Area_Code, @User_Type, @TelephoneNumber)";
            string querry = $"INSERT INTO [User] (Name, CNIC, Email, Password, MobileNumber, DOB, Gender, Province, District, postalCode,Tehsil, Address, Area_Code,TelephoneNumber) VALUES (@Name, @CNIC, @Email, @Password, @MobileNumber, @DOB, @Gender, @Province, @District, @postalCode, @Tehsil, @Address, @Area_Code,@TelephoneNumber)";
            SqlCommand command = new SqlCommand(querry, connection);
            command.Parameters.Add(Name);
            command.Parameters.Add(CNIC);
            command.Parameters.Add(Email);
            command.Parameters.Add(Password);
            command.Parameters.Add(MobileNumber);
            command.Parameters.Add(DOB);
            command.Parameters.Add(Gender);
            command.Parameters.Add(Province);
            command.Parameters.Add(District);
            command.Parameters.Add(postalCode);
            command.Parameters.Add(Tehsil);
            command.Parameters.Add(Address);
            //command.Parameters.AddWithValue("@Status", Status ?? (object)DBNull.Value);
            //command.Parameters.AddWithValue("@Area_Code", Area_Code ?? (object)DBNull.Value);
            //command.Parameters.AddWithValue("@User_Type", User_Type ?? (object)DBNull.Value);
            //command.Parameters.Add(Status);
            command.Parameters.Add(Area_Code);
            //command.Parameters.Add(User_Type);
            command.Parameters.Add(TelephoneNumber);
            int number_of_rows_inserted = command.ExecuteNonQuery();
            if (number_of_rows_inserted >= 1)
            {
                connection.Close();
                return "User Added Successfully";
            }
            connection.Close();
            return "Account already exist on this CNIC number";
        }

        public static List<User> GetAllUsers()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = citizen_portal_database; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string querry = $"Select * From [User]";
            SqlCommand command = new SqlCommand(querry, connection);
            SqlDataReader data = command.ExecuteReader();
            List<User> userList = new List<User>();
            while (data.Read())
            {
                User u = new User();
                u.Name = (string)data[0];
                u.CNIC = (string)data[1];
                u.Email = (string)data[2];
                u.Password = (string)data[3];
                u.MobileNumber = (string)data[4];
                u.DOB = (string)data[5];
                u.Gender = (string)data[6];
                u.Province = (string)data[7];
                u.District = (string)data[8];
                u.postalCode = (string)data[9];
                u.Tehsil = (string)data[10];
                u.Address = (string)data[11];
                //u.Status = data[12]?.ToString();
                //u.Area_Code = data[13]?.ToString();
                //u.User_Type = data[14]?.ToString();
                u.TelephoneNumber = (string)data[15];
                userList.Add(u);
            }
            connection.Close();
            return userList;
        }
    }
}
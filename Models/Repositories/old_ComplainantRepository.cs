using Citizen_Portal.Models.Interfaces;
using Microsoft.Data.SqlClient;
namespace Citizen_Portal.Models.Repositories
{
    public class old_ComplainantRepository    
    {
        public static string Add_Complainant(Complainant complainant)
        {
            //string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = citizen_portal_database; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            ////if (complainant.Name == null)
            ////{
            ////    complainant.Name = "";
            ////}
            ////else if (complainant.Email == null)
            ////{
            ////    Complainant.Email = "";
            ////}
            ////else if (Complainant.Password == null)
            ////{
            ////    Complainant.Password = "";
            ////}
            ////else if (Complainant.MobileNumber == null)
            ////{
            ////    Complainant.MobileNumber = "";
            ////}
            ////else if (Complainant.DOB == null)
            ////{
            ////    Complainant.DOB = "";
            ////}
            ////else if (Complainant.Gender == null)
            ////{
            ////    Complainant.Gender = "";
            ////}
            ////else if (Complainant.Province == null)
            ////{
            ////    Complainant.Province = "";
            ////}
            ////else if (Complainant.District == null)
            ////{
            ////    Complainant.District = "";
            ////}
            ////else if (Complainant.postalCode == null)
            ////{
            ////    Complainant.postalCode = "";
            ////}
            ////else if (Complainant.Tehsil == null)
            ////{
            ////    Complainant.Tehsil = "";
            ////}
            ////else if (Complainant.Address == null)
            ////{
            ////    Complainant.Address = "";
            ////}
            ////else if (Complainant.Status == null)
            ////{
            ////    Complainant.Status = "";
            ////}
            ////else if (Complainant.Area_Code == null)
            ////{
            ////    Complainant.Area_Code = "";
            ////}
            ////else if (Complainant.Complainant_Type == null)
            ////{
            ////    Complainant.Complainant_Type = "";
            ////}
            ////else if (Complainant.TelephoneNumber == null)
            ////{
            ////    Complainant.TelephoneNumber = "";
            ////}
            //SqlParameter Name = new SqlParameter("Name", complainant.name);
            //SqlParameter CNIC = new SqlParameter("CNIC", complainant.cnic);
            //SqlParameter Email = new SqlParameter("Email", complainant.email);
            //SqlParameter Password = new SqlParameter("Password", complainant.password);
            //SqlParameter MobileNumber = new SqlParameter("MobileNumber", complainant.mobile_number);
            //SqlParameter DOB = new SqlParameter("DOB", complainant.date_of_birth);
            //SqlParameter Gender = new SqlParameter("Gender", complainant.gender);
            //SqlParameter Province = new SqlParameter("Province", complainant.province);
            //SqlParameter District = new SqlParameter("District", complainant.district);
            //SqlParameter postalCode = new SqlParameter("postalCode", complainant.postal_code);
            //SqlParameter Tehsil = new SqlParameter("Tehsil", complainant.tehsil);
            //SqlParameter Address = new SqlParameter("Address", complainant.permanent_address);
            //SqlParameter Area_Code = new SqlParameter("Area_Code", complainant.country_code);
            //SqlParameter TelephoneNumber = new SqlParameter("TelephoneNumber", complainant.telephone_number);
            ////string querry = $"INSERT INTO [Complainant] (Name, CNIC, Email, Password, MobileNumber, DOB, Gender, Province, District, postalCode,Tehsil, Address, Status, Area_Code, Complainant_Type, TelephoneNumber) VALUES (@Name, @CNIC, @Email, @Password, @MobileNumber, @DOB, @Gender, @Province, @District, @postalCode, @Tehsil, @Address, @Status, @Area_Code, @Complainant_Type, @TelephoneNumber)";
            //string querry = $"INSERT INTO [Complainant] (Name, CNIC, Email, Password, MobileNumber, DOB, Gender, Province, District, postalCode,Tehsil, Address, Area_Code,TelephoneNumber) VALUES (@Name, @CNIC, @Email, @Password, @MobileNumber, @DOB, @Gender, @Province, @District, @postalCode, @Tehsil, @Address, @Area_Code,@TelephoneNumber)";
            //SqlCommand command = new SqlCommand(querry, connection);
            //command.Parameters.Add(Name);
            //command.Parameters.Add(CNIC);
            //command.Parameters.Add(Email);
            //command.Parameters.Add(Password);
            //command.Parameters.Add(MobileNumber);
            //command.Parameters.Add(DOB);
            //command.Parameters.Add(Gender);
            //command.Parameters.Add(Province);
            //command.Parameters.Add(District);
            //command.Parameters.Add(postalCode);
            //command.Parameters.Add(Tehsil);
            //command.Parameters.Add(Address);
            ////command.Parameters.AddWithValue("@Status", Status ?? (object)DBNull.Value);
            ////command.Parameters.AddWithValue("@Area_Code", Area_Code ?? (object)DBNull.Value);
            ////command.Parameters.AddWithValue("@Complainant_Type", Complainant_Type ?? (object)DBNull.Value);
            ////command.Parameters.Add(Status);
            //command.Parameters.Add(Area_Code);
            ////command.Parameters.Add(Complainant_Type);
            //command.Parameters.Add(TelephoneNumber);
            //int number_of_rows_inserted = command.ExecuteNonQuery();
            //if (number_of_rows_inserted >= 1)
            //{
            //    connection.Close();
            //    return "Complainant Added Successfully";
            //}
            //connection.Close();
            return "Account already exist on this CNIC number";
        }

        public static List<Complainant> GetAllComplainants()
        {
            //string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = citizen_portal_database; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //string querry = $"Select * From [Complainant]";
            //SqlCommand command = new SqlCommand(querry, connection);
            //SqlDataReader data = command.ExecuteReader();
            //List<Complainant> ComplainantList = new List<Complainant>();
            //while (data.Read())
            //{
            //    Complainant u = new Complainant();
            //    //u.Name = (string)data[0];
            //    //u.CNIC = (string)data[1];
            //    //u.Email = (string)data[2];
            //    //u.Password = (string)data[3];
            //    //u.MobileNumber = (string)data[4];
            //    //u.DOB = (string)data[5];
            //    //u.Gender = (string)data[6];
            //    //u.Province = (string)data[7];
            //    //u.District = (string)data[8];
            //    //u.postalCode = (string)data[9];
            //    //u.Tehsil = (string)data[10];
            //    //u.Address = (string)data[11];
            //    ////u.Status = data[12]?.ToString();
            //    ////u.Area_Code = data[13]?.ToString();
            //    ////u.Complainant_Type = data[14]?.ToString();
            //    //u.TelephoneNumber = (string)data[15];
            //    ComplainantList.Add(u);
            //}
            //connection.Close();
            //return ComplainantList;
            List<Complainant> cList = new List<Complainant>();
            return cList;
        }

        public Complainant getComplainant(int Id)
        {
            Complainant c = new Complainant();
            return c;
        }
    }
}
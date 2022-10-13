using System.Data.SqlClient;

namespace My_Blazor_Hjemmeside.Data
{
    public class SQL
    {
        private SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=McDonald_Menu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public List<Menu> ReadMenu()
        {
            conn.Open();
            List<Menu> menuList = new List<Menu>();
            SqlCommand command = new SqlCommand("Select * from [Menu]", conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Menu f = new()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Item_Name = reader["Item_Name"].ToString(),
                        Price = double.Parse(reader["Price"].ToString()),
                        Amount = int.Parse(reader["Amount"].ToString())
                    };
                    menuList.Add(f);
                }
            }
            conn.Close();
            return menuList;
        }

    }
}

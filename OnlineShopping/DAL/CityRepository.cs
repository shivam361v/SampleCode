namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
public static class CityRepository
{

    public static string conString=@"server=localhost;port=3306;user=root; password=root;database=statecitydb";       
    public  static List<City> GetAll()
    {
            List<City> allcitys = new List<City>();
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=conString;
            try{
                con.Open();
                //fire query to database
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                string query = "SELECT * FROM statecitydb.city";
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()){
                    int cityid = int.Parse(reader["cityid"].ToString());
                    string name = reader["name"].ToString();
                    int stateid = int.Parse(reader["stateid"].ToString());

                    City c = new City{
                                                    CityId = cityid,
                                                    Name = name,
                                                     StateId = stateid
                    };
                    allcitys.Add(c);
                }
            }
            catch(Exception ee){
                Console.WriteLine(ee.Message);
            }
            finally{
                    con.Close();
            }
            Console.WriteLine("Content re cieved.");
            return allcitys;
    }

    

}
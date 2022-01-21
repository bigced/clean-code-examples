public class WorkItem{
     
        private string _id;
        private string _name;
        
        public void Save(){
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["database"]);
            cnx.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO WorkItem (Id, Name) VALUES ('";
            cmd.CommandText += _id + "','" + _name + "')";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        
        public void GetById(string id){
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["database"]);
            cnx.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT Id, Name FROM WorkItem where Id = '" + id + "'";

            SqlDataReader dr = command.ExecuteReader();
            
            if (dr.Read()){
                _id = dr["id"].ToString();
                _name = dr["name"].ToString();
            } else {
                return null;
            }
        }
    }
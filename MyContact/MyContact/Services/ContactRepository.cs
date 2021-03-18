using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact
{
    class ContactRepository : IContactRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true";
        public bool Delete(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            string query = "select * from MyContact";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}

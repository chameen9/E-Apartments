using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Data
{
    public class DBQueries
    {
        public DataSet Dset = new DataSet();
        public SqlDataAdapter SqlDA = new SqlDataAdapter();
        public SqlCommand command = new SqlCommand();
        public SqlConnection connection = new SqlConnection(@"Server=CHVM2EN\SQLEXPRESS; Initial Catalog=EApartmentsDB; Integrated Security=SSPI");


        public int rowCount(String query)
        {
            try
            {
                connection.Open();

                SqlDA = new SqlDataAdapter(query, connection);
                DataTable Dt = new DataTable();
                SqlDA.Fill(Dt);
                connection.Close();

                return Dt.Rows.Count;
            }
            catch
            {
                return 0;
            }
        }
        public void InsertWithMessage(String query, String Message)
        {
            try
            {
                connection.Open();

                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show(Message, "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error while adding..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public void InsertWithOutMessage(String query)
        {
            try
            {
                connection.Open();

                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error while adding..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

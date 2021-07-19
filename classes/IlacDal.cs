using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giris_form
{
    public class IlacDal
    {
        Database database = null;
        string table = null;
        public IlacDal(Database database, string table)
        {
            this.database = database;
            this.table = table;
        }

        public DataTable GetAll()
        {
            this.database.ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from " + this.table , database.connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            database.connection.Close();
            return dataTable;

        }


        public void Add(Ilac ilac1)
        {
            database.ConnectionControl();
            try
            {

                SqlCommand command = new SqlCommand("Insert into " + this.table + " values(@ad,@tur,@tarih,@etken)", database.connection);
                command.Parameters.AddWithValue("@ad", ilac1.ilacAdi);
                command.Parameters.AddWithValue("@tur", ilac1.ilacTuru);
                command.Parameters.AddWithValue("@tarih", ilac1.ilacStt);
                command.Parameters.AddWithValue("@etken", ilac1.ilacEtken);
            
                command.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
            }

        }

        public void Update(Ilac ilac1)
        {
            database.ConnectionControl();
            try
            {

                SqlCommand command = new SqlCommand("Update " + this.table + " set ilacAdi=@ad,ilacTuru=@tur,ilacStt=@tarih,ilacEtken=@etken where ilacKodu=@kod", database.connection);
                command.Parameters.AddWithValue("@ad", ilac1.ilacAdi);
                command.Parameters.AddWithValue("@tur", ilac1.ilacTuru);
                command.Parameters.AddWithValue("@tarih", ilac1.ilacStt);
                command.Parameters.AddWithValue("@etken", ilac1.ilacEtken);
                command.Parameters.AddWithValue("@kod", ilac1.ilacKodu);

                command.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
            }

        }

        public void Delete(int id) 
        {
            database.ConnectionControl();
            try
            {

                SqlCommand command = new SqlCommand("Delete from " + this.table + " where ilacKodu=@kod", database.connection);

                command.Parameters.AddWithValue("@kod",id);

                command.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {

            }

        }


    }
}

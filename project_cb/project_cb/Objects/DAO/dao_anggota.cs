using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using project_cb.Models;
using project_cb.Exceptions;

//using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient; 


namespace project_cb.DAO
{
    class dao_anggota
    {
        
        private static show_exception se = new show_exception();
        private static dbconnection dbconn = new dbconnection();
        private static MySqlConnection sqlconn = new MySqlConnection();
        private static MySqlCommand sqlcmd = new MySqlCommand();
        
        public MySqlDataAdapter show_anggota()
        {
            try
            {
                sqlconn.Open();
                sqlcmd = sqlconn.CreateCommand();
                sqlcmd.CommandText.Equals("SELECT * FROM TBL_ANGGOTA");
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd);
                return adapter;
            }
            catch (MySqlException exception)
            {
                se.show_message(exception.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (sqlconn.State == System.Data.ConnectionState.Open)
                { sqlconn.Close(); }
            }
        }
        public MySqlDataAdapter search_anggota(string val_id)
        {
            try
            {
                sqlconn.Open();
                sqlcmd = sqlconn.CreateCommand();
                sqlcmd.CommandText = "select * from tbl_anggota where Id_anggota RLIKE @keyword";
                sqlcmd.Parameters.AddWithValue("@keyword", val_id);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.show_message(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (sqlconn.State == System.Data.ConnectionState.Open)
                { sqlconn.Close(); }
            }
        }
        public bool insert_anggota(anggota a)
        {
            dbconnection db = new dbconnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into tbl_anggota values(@Id_anggota, @Nama_lengkap, @nama_panggilan, @jenis_identitas, @no_identitas, @Jenis_kelamin, @status_perkawinan, @Tempat_lahir, @Tanggal_lahir, @agama, @Alamat_lengkap, @telepon, @pendidikan, @Pekerjaan, @tempat_bekerja, @alamat_pekerjaan, @jenis_anggota, @No_buku)";
                
            }
            catch (Exception ex)
            {

            }

        }

        //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        
    }


}

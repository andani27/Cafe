using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Menu
{
    static class H
    {
        private static MySqlConnection Conn;
        private static MySqlCommand Cmd;
        private static MySqlDataAdapter Da;
        private static DataSet Ds = new DataSet();

        private static void Connect()
        {
            if (Conn!=null) return;

            Conn = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD=;DATABASE=menu");
            Conn.Open();
        }

        public static MySqlConnection GetConn()
        {
            Connect();
            return Conn; 
        }

        public static DataTable OpenDT(string Sql)
        {
            Cmd = new MySqlCommand(Sql, GetConn());
            Ds.Tables.Clear();
            Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);

            return Ds.Tables[0];
        }

        public static void Execute(string Sql)
        {
            Cmd = new MySqlCommand(Sql, GetConn());
            Cmd.ExecuteNonQuery();
        }

        public static void MsgInfo(string msg)
        {
            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult MsgAsk(string msg)
        {
            return MessageBox.Show(null, msg, "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static double ToDouble(object o)
        {
            double d = 0;
            Double.TryParse(o.ToString(), out d);
            return d;
        }
    }
}

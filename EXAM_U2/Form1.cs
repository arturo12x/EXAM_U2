using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EXAM_U2
{
    public partial class Form1 : Form
    {
        SqlConnection cadena_conexion = new SqlConnection(@"DATA SOURCE=ARTURO-PC; INITIAL CATALOG=COSSIO_LOPEZ; USER ID=sa; PASSWORD='aeiou1234'");
  
        public Form1()
        {
            InitializeComponent();
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            llenar_tabla();
            SqlCommand comandos = cadena_conexion.CreateCommand();
            String query2;
           bool fullname_added = true;

            if (fullname_added == false)
            {
                query2 = "ALTER TABLE WORKERS ADD FULLNAME VARCHAR(200)";

                SqlCommand comando2 = cadena_conexion.CreateCommand();

                cadena_conexion.Open();
                comandos = new SqlCommand(query2, cadena_conexion);
                comandos.ExecuteNonQuery();

                cadena_conexion.Close();
                fullname_added = true;

            }

        }

        private void BTNINSERT_Click(object sender, EventArgs e)
        {



            SqlCommand comandos = cadena_conexion.CreateCommand();
            string query1, name, last,fullname;
            string ERROR = "";
           
            name = TXTNAME.Text;
            last = TXTLAST.Text;
            TXTNAME.BackColor = Color.White;
            TXTLAST.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(name))
            {
                ERROR += " YO CAN'T LEFT EMPTY NAME";
                TXTNAME.BackColor = Color.DarkRed;

            }



            if (string.IsNullOrWhiteSpace(last))
            {
                ERROR += " YOU CAN'T LEFT EMPTY LAST NAME";
                TXTLAST.BackColor = Color.DarkRed;

            }
         
           

            if (ERROR != "")
            {
                MessageBox.Show(ERROR, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            fullname = name + " " + last;
            query1 = "INSERT INTO WORKERS VALUES ('" + name + "','" + last + "','"+fullname+"'"+")";

            cadena_conexion.Open();


            comandos = new SqlCommand(query1, cadena_conexion);
            comandos.ExecuteNonQuery();

            cadena_conexion.Close();


            llenar_tabla();


           


        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            SqlCommand comandos = cadena_conexion.CreateCommand();
            string ID, query2;
            ID = TXTID.Text;
            string name, last,fullname;
            string ERROR = "";
            name =TXTNAME.Text;
            last = TXTLAST.Text;

            TXTNAME.BackColor = Color.White;
            TXTLAST.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(name))
            {
                ERROR += " YO CAN'T LEFT EMPTY NAME";
                TXTNAME.BackColor = Color.DarkRed;

            }



            if (string.IsNullOrWhiteSpace(last))
            {
                ERROR += " YOU CAN'T LEFT EMPTY LAST NAME";
                TXTLAST.BackColor = Color.DarkRed;

            }



            if (ERROR != "")
            {
                MessageBox.Show(ERROR, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            fullname = name + " " + last;
            query2 = "UPDATE WORKERS SET NAME=" + "'" + name + "'" + ",LASTNAME=" + "'" + last + "'," +"FULLNAME="+"'"+fullname+"'"+ "  WHERE ID=" + ID;


            cadena_conexion.Open();
            comandos = new SqlCommand(query2, cadena_conexion);
            comandos.ExecuteNonQuery();

            cadena_conexion.Close();
            llenar_tabla();

        }
        private void llenar_tabla()
        {
            dataGridView1.Columns.Clear();
            //llenar tabla
            cadena_conexion.Open();
            string query3 = "SELECT * from WORKERS";
            SqlCommand cmd = new SqlCommand(query3, cadena_conexion);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);

            cadena_conexion.Close();
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image.HeaderText = "SEL";
            image.Name = null;
            image.Name = "Cimg";
            image.Width = 100;
            dataGridView1.Columns.Add(image);
            image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewImageCell cell = row.Cells[4] as DataGridViewImageCell;

                cell.Value = EXAM_U2.Properties.Resources.LAPIZ;

            }





            DataGridViewImageColumn image2 = new DataGridViewImageColumn();
            image2.HeaderText = "DEL";
            image2.Name = null;
            image2.Name = "Cimg2";
            image2.Width = 100;
            dataGridView1.Columns.Add(image2);
            image2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewImageCell cell = row.Cells[5] as DataGridViewImageCell;

                cell.Value = EXAM_U2.Properties.Resources.TACHA;
            }

        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row, column;
            row = e.RowIndex;
            column = e.ColumnIndex;


            if (column == 4)
            {
                TXTID.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                TXTNAME.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                TXTLAST.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            }



            if (column == 5)
            {
                if (MessageBox.Show("¿DO YOU WANT TO DELETE IT?", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TXTID.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                    SqlCommand comandos = cadena_conexion.CreateCommand();
                    string query1, ID;
                    ID = TXTID.Text;



                    cadena_conexion.Open();
                    query1 = "Delete from workers where id=" +  ID;
                    comandos = new SqlCommand(query1, cadena_conexion);
                    comandos.ExecuteNonQuery();
                    cadena_conexion.Close();
                    llenar_tabla();

                    TXTNAME.Text = "";
                    TXTLAST.Text = "";
                    TXTID.Text = "";

                }
                else
                { }
            }
        }

        private void TXTNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void TXTLAST_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }
    }
}

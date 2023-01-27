using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace CRUDProdam
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["nome"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;


        public void ShowDataOnGridView()
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("Select * From Clientes", con);
                dt = new DataTable();
                adapter.Fill(dt);
                ViewClientes.DataSource = dt;
            }
        }

        public void ClearAllData()
        {
            txtNome.Text = "";
            txtTel.Text = "";
            txtCpf.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
            ShowDataOnGridView();
            ClearAllData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = this.ViewClientes.CurrentRow.Cells["Name"].Value.ToString();
            txtTel.Text = this.ViewClientes.CurrentRow.Cells["Telefone"].Value.ToString();
            txtCpf.Text = this.ViewClientes.CurrentRow.Cells["CPF"].Value.ToString();
            lblID.Text = this.ViewClientes.CurrentRow.Cells["ClienteID"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("insert into Clientes (Name, Telefone,CPF) Values (@Name, @Telefone, @CPF )", con);
                cmd.Parameters.AddWithValue("@name", txtNome.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTel.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Adicionado com sucesso");
                ShowDataOnGridView();
                ClearAllData();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("Update Clientes set name=@name,Telefone=@Telefone, CPF=@CPF Where ClienteID=@Clienteid", con);
                cmd.Parameters.AddWithValue("@name", txtNome.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTel.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
                cmd.Parameters.AddWithValue("@Clienteid", lblID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualizado com sucesso");
                ShowDataOnGridView();
                ClearAllData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("Delete From Clientes Where ClienteID=@Clienteid", con);
                cmd.Parameters.AddWithValue("@Clienteid", lblID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deletado com sucesso");
                ShowDataOnGridView();
                ClearAllData();

            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnimg_Click(object sender, EventArgs e)
        {
            frmHelp form = new frmHelp();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

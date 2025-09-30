using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionDatabaseWf
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LoadContent(UserControl uc)
        {
            panelContent.Controls.Clear();  
            uc.Dock = DockStyle.Fill;        
            panelContent.Controls.Add(uc);   
        }


        private void quanLySachMenuItem_Click(object sender, EventArgs e)
        {
            LoadContent(new Sach());
        }

        private void quanLyDocGiaMenuItem_Click(object sender, EventArgs e)
        {
            LoadContent(new DocGia());
        }

        private void quanLyTacGiaMenuItem_Click(object sender, EventArgs e)
        {
            LoadContent(new TacGia());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadContent(new Sach());
        }
    }
}

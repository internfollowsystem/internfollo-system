using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajyerTakip
{
    public partial class FrmTakip : Form
    {
        public FrmTakip()
        {
            InitializeComponent();
            Connect cn= new Connect;
            fr.Baglanti.Open();
            dataGridView1.DataSource = cn.Listele();
            //DataTable dt = baglanti.GetSchema("Tables");
 
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
                   // comboBox1.Items.Add(dt.Rows[i]["TABLE_NAME"]);
                    //comboBox2.Items.Add(dt.Rows[i]["TABLE_NAME"]);
                    //diye devam eder kaç taneyse artık
            }
            //baglanti.Close();
        }
        
         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablo = comboBox1.Text;
            string sorgu="SELECT *FROM "+tablo;
            da = new SqlDataAdapter(sorgu, baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, tablo);
            dataGridView1.DataSource = ds.Tables[tablo];
            baglanti.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using testquadra;
using Newtonsoft.Json;





namespace testquadra
{
    public partial class viewdata : Form
    {
        public viewdata()
        {
            InitializeComponent();
            callapidatac();
        }

        public void callapidatac()
        {
            try
            {
                HttpClient datacom = new HttpClient();
                IEnumerable<comdatt> comobj = null;
                datacom.BaseAddress = new Uri("http://localhost:5216/api/companyy/");
                
                var companydataall = datacom.GetAsync("getalldacom");
                
                companydataall.Wait();
                

                var readdatac = companydataall.Result;
                MessageBox.Show("" + readdatac);
                if (readdatac.IsSuccessStatusCode)
                {
                    var displaydatacompany = readdatac.Content.ReadAsStringAsync().Result; //<IList<comdatt>>();
                    //displaydatacompany.Wait();
                   var testconvery = (string)JsonConvert.DeserializeObject(displaydatacompany);  //ติด เรื่อง Newtonsoft
                    //comobj = displaydatacompany;

                    dataGridView1.DataSource = readdatac.Content.ReadAsStringAsync().Result; //ไม่ได้เพราะติดข้อมูลเป็น Json+++
                    //MessageBox.Show(""+displaydatacompany);
                    textBox1.Text = "" +displaydatacompany;
                    
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
                    
            }
        
    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            callapidatac();
        }
    }
}

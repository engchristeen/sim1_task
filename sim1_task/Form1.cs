using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim1_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Show InterArrival time
        private void Show_InterrArival_Time()
        {

            main.ProbabilityArrival = new double[dataGridView1.RowCount - 1];
            main.CummulativeProbability = new double[dataGridView1.RowCount - 1];
            main.RandomArrival = new int[dataGridView1.RowCount - 2];
            main.InterArrival = new int[dataGridView1.RowCount - 1];
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                main.ProbabilityArrival[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                if (i == 0)
                {
                    main.CummulativeProbability[i] = main.ProbabilityArrival[i];
                }
                else
                {
                    main.CummulativeProbability[i] = main.ProbabilityArrival[i] + main.CummulativeProbability[i - 1];
                }
            }
            main.NumberOfCustomers = new double[Convert.ToInt32(textBox1.Text)];
            //main.NumberOfCustomers = new double[dataGridView1.RowCount];
            main.Generate_Random();
            // mn awl hna b3d ma b3ml generate le arkam random bro7 ageb elinterarrival bta3 kol row 7sb el rkm ele 3mltlo generate fe anhy range 
            for (int i = 0; i < main.RandomArrival.Length; i++)
            {
                for (int n = 0; n < main.CummulativeProbability.Length; n++)
                {
                    if (n == 0)
                    {
                        main.InterArrival[0] = 0;
                        //if (main.RandomArrival[i] < main.CummulativeProbability[0])
                        //{
                        //    main.InterArrival[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);

                        //}
                    }
                    else
                    {
                        if (main.CummulativeProbability[n - 1] < main.RandomArrival[i] && main.RandomArrival[i] < main.CummulativeProbability[n])
                        {

                            main.InterArrival[i] = Convert.ToInt32(dataGridView1.Rows[n].Cells[0].Value);
                        }
                    }
                }
            }

            for (int i = 0; i < main.CummulativeProbability.Length; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = main.CummulativeProbability[i];
            }
            for (int i = 0; i < main.InterArrival.Length; i++)
            {
                //dataGridView1.Rows[i].Cells[3].Value = main.RandomArrival[i];
                dataGridView1.Rows[i].Cells[3].Value = main.InterArrival[i];
                //copy data in new array :
                //main.NewInterArrival[i] = main.InterArrival[i];
            }
        }


        private void Show_Service_Time_Of_Able()
        {
            main.ProbabilityService = new double[dataGridView2.RowCount - 1];
            main.CummulativeService = new double[dataGridView2.RowCount - 1];
            main.RandomService = new int[dataGridView2.RowCount - 1];
            main.InterArrivalService = new int[dataGridView2.RowCount - 1];

            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                main.ProbabilityService[i] = Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value);
                if (i == 0)
                {
                    main.CummulativeService[i] = main.ProbabilityService[i];
                }
                else
                {
                    main.CummulativeService[i] = main.ProbabilityService[i] + main.CummulativeService[i - 1];
                }
            }
            main.NumberOfCustomers = new double[Convert.ToInt32(textBox1.Text)];
            main.Generate_Random_Service();

            for (int i = 0; i < main.RandomService.Length; i++)
            {
                for (int n = 0; n < main.CummulativeService.Length; n++)
                {
                    if (n == 0)
                    {
                        if (main.RandomService[i] < main.CummulativeService[0])
                        {
                            main.InterArrivalService[i] = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value);
                        }
                    }
                    else
                    {
                        if (main.CummulativeService[n - 1] < main.RandomService[i] && main.RandomService[i] < main.CummulativeService[n])
                        {
                            main.InterArrivalService[i] = Convert.ToInt32(dataGridView2.Rows[n].Cells[0].Value);
                        }
                    }
                }
            }
            for (int i = 0; i < main.InterArrivalService.Length; i++)
            {
                dataGridView2.Rows[i].Cells[2].Value = main.CummulativeService[i];
                //dataGridView2.Rows[i].Cells[3].Value = main.RandomService[i];
                dataGridView2.Rows[i].Cells[3].Value = main.InterArrivalService[i];
            }
        }


        private void Show_Service_Time_Of_Baker()
        {
            main.ProbabilityService = new double[dataGridView3.RowCount - 1];
            main.CummulativeService = new double[dataGridView3.RowCount - 1];
            main.RandomService = new int[dataGridView3.RowCount - 1];
            main.InterArrivalService = new int[dataGridView3.RowCount - 1];

            for (int i = 0; i < dataGridView3.RowCount - 1; i++)
            {
                main.ProbabilityService[i] = Convert.ToDouble(dataGridView3.Rows[i].Cells[1].Value);
                if (i == 0)
                {
                    main.CummulativeService[i] = main.ProbabilityService[i];
                }
                else
                {
                    main.CummulativeService[i] = main.ProbabilityService[i] + main.CummulativeService[i - 1];
                }
            }
            main.NumberOfCustomers = new double[Convert.ToInt32(textBox1.Text)];
            main.Generate_Random_Service();

            for (int i = 0; i < main.RandomService.Length; i++)
            {
                for (int n = 0; n < main.CummulativeService.Length; n++)
                {
                    if (n == 0)
                    {
                        if (main.RandomService[i] < main.CummulativeService[0])
                        {
                            main.InterArrivalService[i] = Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value);
                        }
                    }
                    else
                    {
                        if (main.CummulativeService[n - 1] < main.RandomService[i] && main.RandomService[i] < main.CummulativeService[n])
                        {
                            main.InterArrivalService[i] = Convert.ToInt32(dataGridView3.Rows[n].Cells[0].Value);
                        }
                    }
                }
            }
            for (int i = 0; i < main.InterArrivalService.Length; i++)
            {
                dataGridView3.Rows[i].Cells[2].Value = main.CummulativeService[i];
                //dataGridView3.Rows[i].Cells[3].Value = main.RandomService[i];
                dataGridView3.Rows[i].Cells[3].Value = main.InterArrivalService[i];
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Show_InterrArival_Time();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_Service_Time_Of_Able();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Show_Service_Time_Of_Baker();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Done Button bta3 el number of Customers
        private void button3_Click(object sender, EventArgs e)
        {

            // main.NumberOfCustomers = new double[Convert.ToInt32(textBox1.Text)];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
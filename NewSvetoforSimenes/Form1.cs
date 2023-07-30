using S7.Net;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace NewSvetoforSimenes
{
    public partial class Form1 : Form
    {
        private Plc plc;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            svetoforOff.Visible = true;
            RedLight.Visible = false;
            YellowLight.Visible = false;
            GreenLight.Visible = false;

            redLabel.Visible = false;
            redLabel.Parent = RedLight;
            redLabel.BackColor = Color.Transparent;

            greenLabel.Visible = false;
            greenLabel.Parent = GreenLight;
            greenLabel.BackColor = Color.Transparent;

            plc = new Plc(CpuType.S71200, "127.0.0.1", 0, 1);

            plc.Open();

            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Hello how low 

                bool Red = (bool)plc.Read("DB5.DBX0.1");
                bool Yellow = (bool)plc.Read("DB5.DBX0.6");
                bool Green = (bool)plc.Read("DB5.DBX0.2");


                uint RedTime = (uint)plc.Read("DB5.DBD2");
                uint GreenTime = (uint)plc.Read("DB5.DBD6");

                // ���������� �������� textBox

                if (Red)
                {
                    svetoforOff.Visible = false;
                    RedLight.Visible = true;
                    YellowLight.Visible = false;
                    GreenLight.Visible = false;

                    redLabel.Visible = true;
                    redLabel.Text = RedTime.ToString();

                    greenLabel.Visible = false;
                }
                else if (Yellow)
                {
                    svetoforOff.Visible = false;
                    RedLight.Visible = false;
                    YellowLight.Visible = true;
                    GreenLight.Visible = false;

                    RedLight.Visible = false;
                    greenLabel.Visible = false;

                }
                else if (Green)
                {
                    svetoforOff.Visible = false;
                    RedLight.Visible = false;
                    YellowLight.Visible = false;
                    GreenLight.Visible = true;

                    greenLabel.Visible = true;
                    greenLabel.Text = GreenTime.ToString();

                    RedLight.Visible = false;
                }
                else
                {
                    svetoforOff.Visible = true;
                    RedLight.Visible = false;
                    YellowLight.Visible = false;
                    GreenLight.Visible = false;

                    RedLight.Visible = false;
                    greenLabel.Visible = false;
                }

            }
            catch (Exception ex)
            {
                // ��������� ������ ������ ������
                MessageBox.Show("������ ��� ������ ������ � PLC: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // �������� ����������� � PLC � ��������� ������� ��� �������� �����
            plc?.Close();
            timer?.Stop();
        }

        private void startSvetofor_Click(object sender, EventArgs e)
        {

            bool Start = (bool)plc.Read("DB5.DBX0.0");

            if (Start)
            {
                plc.Write("DB5.DBX0.0", false);
            }
            else if (!Start)
            {
                plc.Write("DB5.DBX0.0", true);
            }

        }
    }
}
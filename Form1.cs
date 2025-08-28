namespace W2work1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCir1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            double Cir = 2 * Math.PI * r;
            string ans = "เส้นรอบวง = " + Cir;
            txtAns.Text = ans;
        }

        private void btnCir2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            double area = Math.PI *Math.Pow(r,2);
            string ans = "เส้นรอบวง = " + area;
            txtAns.Text = ans;
        }

        private void btnCir3_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            double sur = 4 *Math.PI*Math.Pow(r,2);
            string ans = "เส้นรอบวง = " + sur;
            txtAns.Text = ans;
        }

        private void btnCir4_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            double vol = (4.0/3.0)*Math.PI * Math.Pow(r,3);
            string ans = "เส้นรอบวง = " + vol;
            txtAns.Text = ans;
        }
    }
}

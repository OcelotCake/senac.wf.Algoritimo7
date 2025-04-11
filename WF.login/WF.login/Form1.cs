using System.Diagnostics;
using System.Security.Policy;

namespace WF.login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "User")
                textBox1.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Password") ;
        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://blackmesaresearch.neocities.org/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkLabel4_DoubleClick(object sender, EventArgs e)
        {



        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("https://blackmesaresearch.neocities.org/");
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://blackmesaresearch.neocities.org/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "User";
                textBox2.UseSystemPasswordChar = false;
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                //System.Diagnostics.Process.Start("https://blackmesaresearch.neocities.org/apply/");
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "https://blackmesaresearch.neocities.org/apply",
                    UseShellExecute = true
                };
                Process.Start(psi);

                Process.GetCurrentProcess().CloseMainWindow();
            }
        }


        private void Access_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("leave page?", "Title", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("leave page?", "Title", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resposta = MessageBox.Show("leave page?", "Title", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}


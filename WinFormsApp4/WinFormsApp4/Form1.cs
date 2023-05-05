namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2(); form2هنا بس بعمل كليك يفتحلي >>>>>
            //form2.ShowDialog();

            //string txt = textBox1.Text;
            //Form2 form2 = new Form2(txt); هنا بينقل النص من 1 ل2 لما بكليك حل اول >>>>>
            //form2.Show();

            //string Msg;
            //Form2 form2 = new Form2(Msg);
            //form2.Show();                     هنا بينقل النص من 1 ل2 لما بكليك حل تاني
            //form2.Msg = textBox1.Text;


            Form2 form2 = new Form2();
            form2.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
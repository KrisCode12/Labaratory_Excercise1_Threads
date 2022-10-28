namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
        ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting a Thread-");
            Thread ThreadA = new Thread(delThread);
            Thread ThreadB = new Thread(delThread);

            ThreadA.Name = "Thread A process";
            ThreadB.Name = "Thread B process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            if (!ThreadA.IsAlive && !ThreadB.IsAlive)
            {
                label1.Text = "-End of Thread-";
                Console.WriteLine("-End of thread");
            }
        }

        private static void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
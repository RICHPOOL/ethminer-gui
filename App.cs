using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace EthminerGUI
{
    public partial class App : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        Process process;
        bool canExit = false;
        bool mining = false;

        public const string configFilename = "ethminer-gui_config.json";
        public static Configuration Configuration { get; private set; }

        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            FormClosing += App_FormClosing;

            SetWindowLong(Program.HWndConsole, -16, 0x10000000);
            SetParent(Program.HWndConsole, Handle);

            comboBox_pools.Items.Add("us.richpool.net");
            comboBox_pools.Items.Add("eu.richpool.net");
            comboBox_pools.Items.Add("asia.richpool.net");
            comboBox_pools.Items.Add("asia2.richpool.net");
            comboBox_pools.SelectedIndex = 0;
            Configuration = new Configuration(configFilename);
            Logger.white("Configurations:", Path.GetFullPath(configFilename), "Loaded!");
            Logger.green("Reday!");

            if (string.IsNullOrWhiteSpace(Configuration.LocalMachineName))
            {
                textBox_localMachineName.Text = Environment.MachineName;
            }
            else
            {
                textBox_localMachineName.Text = Configuration.LocalMachineName;
            }
            comboBox_miners.Items.AddRange(Configuration.GetMinerNames());
            comboBox_miners.SelectedIndex = Configuration.SelectedIndex;
            updateComponent();
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            if (!canExit && mining)
            {
                e.Cancel = true;
            }
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = true;
        }

        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            try
            {
                process?.Kill();
            }
            catch { }

            canExit = true;
            Application.Exit();
        }

        private void button_mining_Click(object sender, EventArgs e)
        {
            if (mining)
            {
                mining = false;

                button_mining.Text = "START";

                try
                {
                    process?.Kill();
                }
                catch { }
            }
            else
            {
                Console.WriteLine();
                Logger.cyan("Miner Started", "\n");

                mining = true;

                button_mining.Text = "STOP";

                var miner = Configuration.CurrentMiner;
                miner.pool =comboBox_pools.SelectedIndex;
               
                miner.wallet = textBox_wallet.Text;
               
                miner.passwd = textBox_password.Text;
               
                miner.args = textBox_args.Text;

                miner.ton_address = ton_address.Text;

                miner.ton_pool = ton_pool.Text;
                Configuration.CurrentMiner = miner;
                Configuration.Save();

                Task.Run(RunProcess);
            }
        }

        void RunProcess()
        {
            //var retryCount = 0;
            var timer = new Timer(60000);
            timer.AutoReset = false;
            timer.Elapsed += (obj, e) =>
            {
                //retryCount = 0;
            };

            while (mining)
            {
                try
                {
                    process = new Process();
                    Logger.white("Miner :", Configuration.CurrentMiner.name.ToString());
                    var args = Configuration.CurrentMiner.GetFullArgs();
                    Logger.white("execute:", Configuration.CurrentMiner.exePath, args);
                    process.StartInfo.FileName = Configuration.CurrentMiner.exePath;
                    process.StartInfo.Arguments = args;
                    process.StartInfo.UseShellExecute = false;
                    process.Start();

                    timer.Start();

                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    process.Dispose();

                    Console.OutputEncoding = Encoding.UTF8;
                }

                timer.Stop();

                if (!mining)
                {
                    timer.Dispose();

                    Console.WriteLine();
                    Logger.magenta("Stopped", "\n");

                    break;
                }
                /**
                if (retryCount >= 99)
                {
                    timer.Dispose();

                    mining = false;

                    button_mining.Invoke(new Action(() => { button_mining.Text = "START"; }));

                    Console.WriteLine();
                    Logger.red("Miner error!", "\n");

                    break;
                }
                */
                Console.WriteLine();
                Logger.magenta("Miner restarting", "\n");

                Thread.Sleep(5000);

                //retryCount++;
            }
        }

        void updateComponent()
        {
            comboBox_pools.SelectedIndex = Configuration.CurrentMiner.pool;
          
            textBox_wallet.Text = Configuration.CurrentMiner.wallet;
            
            textBox_password.Text = Configuration.CurrentMiner.passwd;
            
            textBox_args.Text = Configuration.CurrentMiner.args;

            ton_pool.Text = Configuration.CurrentMiner.ton_pool;

            ton_address.Text = Configuration.CurrentMiner.ton_address;
        }

        private void textBox_localMachineName_TextChanged(object sender, EventArgs e)
        {
            Configuration.LocalMachineName = textBox_localMachineName.Text;
            textBox_localMachineName.Text = Configuration.LocalMachineName;
        }

        private void comboBox_miners_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.SelectedIndex = comboBox_miners.SelectedIndex;
            updateComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://richpool.net/blog/7/");
        }
    }
}

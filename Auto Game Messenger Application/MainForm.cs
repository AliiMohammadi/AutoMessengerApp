using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Auto_Game_Messenger_Application;

namespace Auto_Game_Messenger_Application
{
    public partial class MainForm : Form
    {
        public static MainForm Mainform;

        public MainForm()
        {
            Mainform = this;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Start();
        }
        static void Start()
        {
            OverwatchProgram game = new OverwatchProgram();
            game.DefineHotkeys();
        }

    }
}

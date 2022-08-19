using System;
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
            OverwatchProgram game = new OverwatchProgram();
            game.DefineHotkeys();
        }
    }
}

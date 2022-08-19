using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto_Game_Messenger_Application;

namespace Auto_Game_Messenger_Application
{
    internal class OverwatchProgram
    {
        public void DefineHotkeys()
        {
            KeyboardHook hook1 = new KeyboardHook();
            KeyboardHook hook2 = new KeyboardHook();
            KeyboardHook hook3 = new KeyboardHook();
            KeyboardHook hook4 = new KeyboardHook();
            KeyboardHook hook5 = new KeyboardHook();
            KeyboardHook hook6 = new KeyboardHook();
            KeyboardHook hook7 = new KeyboardHook();
            KeyboardHook hook8 = new KeyboardHook();

            hook1.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook1_KeyPressed);
            hook1.RegisterHotKey(0, Keys.F1);

            hook2.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook2_KeyPressed);
            hook2.RegisterHotKey(0, Keys.F2);

            hook3.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook3_KeyPressed);
            hook3.RegisterHotKey(0, Keys.F3);

            hook4.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook4_KeyPressed);
            hook4.RegisterHotKey(0, Keys.F4);

            hook5.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook5_KeyPressed);
            hook5.RegisterHotKey(0, Keys.F5);

            hook6.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook6_KeyPressed);
            hook6.RegisterHotKey(0, Keys.F6);

            hook7.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook7_KeyPressed);
            hook7.RegisterHotKey(0, Keys.F7);

            hook8.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook8_KeyPressed);
            hook8.RegisterHotKey(0, Keys.F8);

        }

        void hook1_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendMessage(MainForm.Mainform.textBox1.Text);
        }
        void hook2_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendMessage(MainForm.Mainform.textBox2.Text);
        }
        void hook3_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendMessage(MainForm.Mainform.textBox3.Text);
        }
        void hook4_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendMessage(MainForm.Mainform.textBox4.Text);
        }
        void hook5_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendMessage(MainForm.Mainform.textBox5.Text);
        }
        void hook6_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendMessage(MainForm.Mainform.textBox6.Text);
        }
        void hook7_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendMessage(MainForm.Mainform.textBox7.Text);
        }
        void hook8_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendMessage(MainForm.Mainform.textBox8.Text);
        }

        public static void SendMessage(object Data)
        {
            if(Data != null && !string.IsNullOrEmpty(Data.ToString()))
            {
                Remote.SendKey("{ENTER}");
                Remote.CopyData(Data);
                Remote.PasteMemory();
                Remote.SendKey("{ENTER}");

                Console.Beep(1500, 100);
            }
        }
    }
}

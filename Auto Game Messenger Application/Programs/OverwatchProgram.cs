using System;
using System.Windows.Forms;

namespace Auto_Game_Messenger_Application
{
    internal class OverwatchProgram
    {
        public void DefineHotkeys()
        {
            KeyboardHook hook = new KeyboardHook();

            hook.RegisterHotKey(0,Keys.F1);
            hook.RegisterHotKey(0,Keys.F2);
            hook.RegisterHotKey(0,Keys.F3);
            hook.RegisterHotKey(0,Keys.F4);
            hook.RegisterHotKey(0,Keys.F5);
            hook.RegisterHotKey(0,Keys.F6);
            hook.RegisterHotKey(0,Keys.F7);
            hook.RegisterHotKey(0,Keys.F8);

            hook.KeyPressed += Hook_KeyPressed;
        }

        private void Hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.F1:
                    SendMessage(MainForm.Mainform.textBox1.Text);
                    break;
                case Keys.F2:
                    SendMessage(MainForm.Mainform.textBox2.Text);
                    break;
                case Keys.F3:
                    SendMessage(MainForm.Mainform.textBox3.Text);
                    break;
                case Keys.F4:
                    SendMessage(MainForm.Mainform.textBox4.Text);
                    break;
                case Keys.F5:
                    SendMessage(MainForm.Mainform.textBox5.Text);
                    break;
                case Keys.F6:
                    SendMessage(MainForm.Mainform.textBox6.Text);
                    break;
                case Keys.F7:
                    SendMessage(MainForm.Mainform.textBox7.Text);
                    break;
                case Keys.F8:
                    SendMessage(MainForm.Mainform.textBox8.Text);
                    break;

                default:
                    break;
            }

        }

        public static void SendMessage(object Data)
        {
            if(Data != null && !string.IsNullOrEmpty(Data.ToString()))
            {
                RemoteControl.SendKey("{ENTER}");
                RemoteControl.CopyData(Data);
                RemoteControl.PasteMemory();
                RemoteControl.SendKey("{ENTER}");

                Console.Beep(1500, 100);
            }
        }
    }
}

using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Game_Messenger_Application
{
    //This core uses System.Windows.Forms !
    public class RemoteControl : KeyboardRemote
    {

    }

    public class KeyboardRemote
    {
        /// <summary>
        /// Sending a key to system. 
        /// </summary>
        /// <param name="key"></param>
        public static void SendKey(string key)
        {
            SendKeys.Send(key);
        }
        /// <summary>
        /// Pasting Keayboard memory data throw every where
        /// </summary>
        public static void PasteMemory()
        {
            SendKey("^V");
        }
        /// <summary>
        /// Copying data to the Keyboard temp memory
        /// </summary>
        /// <param name="Data"></param>
        public static void CopyData(object Data)
        {
            Clipboard.SetText(Data.ToString());
        }
    }
    public class MouseRemote
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        public static void Goto(Point p)
        {
            SetCursorPos(p.X,p.Y);
        }
        public static void Goto(int x , int y)
        {
            SetCursorPos(x,y);
        }

    }
}

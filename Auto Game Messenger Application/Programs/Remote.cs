using System.Windows.Forms;

namespace Auto_Game_Messenger_Application
{
    public class Remote
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
}

using System;
using System.Collections.Generic;

namespace Auto_Game_Messenger_Application
{
    internal class ApplicationModel
    {
        /// <summary>
        /// Name of the Application Instruction. ex: Overwatch-SendingChat
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Procces application name.Name of application on task bar
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// Collection of keys that will do the job.
        /// </summary>
        public List<string> Recipe { get; set;}

        public ApplicationModel(string name , string appname, List<string> recipe)
        {
            Name = name;
            AppName = appname;
            Recipe = recipe;
        }
    }
}
//برای تبدیل کردن شعی ها به جیسون
// var json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(obj);
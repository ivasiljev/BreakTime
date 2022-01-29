using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BreakTime
{
    public class Logger
    {
        public enum Layers
        {
            Program,
            Timer,
            Hotkeys,
            ProgramState,
            File,
            FormLayers,
            Error,
            MediaPlayer,
            MyDialog,
            Click,
            TrayIcon
        }

        string logFilePath = @".\LogFile.txt";
        List<Layers> disabledLayers = new List<Layers>();

        public Logger()
        {
            string text = "Лог программы Break Time. Запуск программы (Логгера): Date: " + 
                DateTime.Now.ToShortDateString() + 
                " Time: " + DateTime.Now.ToLongTimeString() + "\r\n";
            using (FileStream fs = new FileStream(logFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fs.Write(array, 0, array.Length);
            }
        }

        public void AddDisabledLayer(Layers layer)
        {
            disabledLayers.Add(layer);
        }

        public void Write(string logText)
        {
            string text = "(" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + ") " + logText + "\r\n";
            using (FileStream fs = new FileStream(logFilePath, FileMode.Append, FileAccess.Write))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fs.Write(array, 0, array.Length);
            }
        }

        public void Write(string logText, Layers layerName)
        {
            if (!disabledLayers.Contains(layerName))
            {
                string text = layerName + ": " + "(" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + ") " + logText + "\r\n";
                using (FileStream fs = new FileStream(logFilePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    fs.Write(array, 0, array.Length);
                }
            }
        }
    }
}

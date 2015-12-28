using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1.Arduino
{
    
    class Servo
    {
        SerialPort port;
        bool isNull = true;

        public Servo()
        {
            int i = 30;
            while ((i < 50) && isNull)
            {
                port = new SerialPort("COM"+i, 9600);
                try
                {
                    port.Open();
                    isNull = false;
                }
                catch (IOException e)
                {
                   // var msg = MessageBox.Show("Порт COM"+i+" не существует", "Ошибка");
                }
                i++;
            }
        }

        public void SendPosition(int x, int y)
        {
            string result = "";
            string a = x + "";
            string b = y + "";

            result += "0";
            for (int i = 0; i < 4 - a.Length; i++)
                result += "0";
            result += a;
            
            for (int i = 0; i < 4 - b.Length; i++)
                result += "0";
            result += b;

            byte[] Bfer = new byte[9];
            for (int i = 0; i < 9; i++ )
                Bfer[i] = Byte.Parse(result[i]+"");

            port.Write(Bfer, 0, 9);

            port.ReadByte();
        }


        public void SendStop()
        {
            int x = 0;
            int y = 0;
            string result = "";
            string a = x + "";
            string b = y + "";

            result += "6";
            for (int i = 0; i < 4 - a.Length; i++)
                result += "0";
            result += a;

            for (int i = 0; i < 4 - b.Length; i++)
                result += "0";
            result += b;

            byte[] Bfer = new byte[9];
            for (int i = 0; i < 9; i++)
                Bfer[i] = Byte.Parse(result[i] + "");

            port.Write(Bfer, 0, 9);

            port.ReadByte();
        }

        public void SendDelta(int k)
        {
            int x = k;
            int y = 0;
            string result = "";
            string a = x + "";
            string b = y + "";

            result += "7";
            for (int i = 0; i < 4 - a.Length; i++)
                result += "0";
            result += a;

            for (int i = 0; i < 4 - b.Length; i++)
                result += "0";
            result += b;

            byte[] Bfer = new byte[9];
            for (int i = 0; i < 9; i++)
                Bfer[i] = Byte.Parse(result[i] + "");

            port.Write(Bfer, 0, 9);

            port.ReadByte();
        }
    }
}

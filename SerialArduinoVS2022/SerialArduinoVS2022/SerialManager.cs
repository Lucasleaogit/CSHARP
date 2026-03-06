using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialArduinoVS2022
{
   public class SerialManager
    {
        private SerialPort serial;
        public SerialManager(string porta, int baud)
        {
            serial = new SerialPort(porta, baud);
        }
        public void Conectar()
        {
            if (!serial.IsOpen)
                serial.Open();
        }
        public void Desconectar()
        {
            if (serial.IsOpen)
                serial.Close();
        }
        public void Enviar(string texto)
        {
            if (serial.IsOpen)
                serial.Write(texto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolBus
{
    class GetBus
    {
        public void GetBusData()
        {
            //khởi tạo list chứa tập các trạm học sinh đứng đón
            List<Buses> listBus = new List<Buses>();
            //Tạo đối tượng Station
            Buses b = null;
            StreamReader file = File.OpenText("../../Input/Buses.txt");
            string line;
            do
            {
                line = file.ReadLine();
                if (line != null)
                {
                    //Tạo đối tượng mới
                    b = new Buses();
                    string[] words = line.Split('\t');
                    b.ID = Convert.ToInt32(words[0]);
                    b.SoGhe = Convert.ToInt32(words[1]);

                    //Lưu đối tượng vào trong list
                    listBus.Add(b);
                }
            }
            while (line != null);
            file.Close();

            //hiển thị list vừa lưu
            foreach (Buses obj in listBus)
            {
                Console.WriteLine("ID = {0}, So Ghe = {1}", obj.ID, obj.SoGhe);
            }
        }
    }
}

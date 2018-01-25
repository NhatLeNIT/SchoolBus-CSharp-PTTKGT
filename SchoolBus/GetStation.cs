using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolBus
{
    class GetStation
    {
        public void GetStationData()
        {
            //khởi tạo list chứa tập các trạm học sinh đứng đón
            List<Station> listStation = new List<Station>();
            //Tạo đối tượng Station
            Station s = null;
            StreamReader file = File.OpenText("../../Input/Station.txt");
            string line;
            //int amountOfWords = 0;
            do
            {
                line = file.ReadLine();
                if (line != null)
                {
                    //Tạo đối tượng mới
                    s = new Station();
                    string[] words = line.Split('\t');
                    s.ID = Convert.ToInt32(words[0]);
                    s.Latitude = Convert.ToDouble(words[1]);
                    s.Longitude = Convert.ToDouble(words[2]);
                    if (words[3] != "")
                    {
                        s.Student = Convert.ToInt32(words[3]);
                    }
                    else
                        s.Student = 0;
                    //Lưu đối tượng vào trong list
                    listStation.Add(s);
                }
            }
            while (line != null);
            file.Close();

            //hiển thị list vừa lưu
            foreach (Station obj in listStation)
            {
                Console.WriteLine("ID = {0}, Lat = {1}, Long = {2}, Student = {3}", obj.ID, obj.Latitude, obj.Longitude, obj.Student);
            }
        }
    }
}

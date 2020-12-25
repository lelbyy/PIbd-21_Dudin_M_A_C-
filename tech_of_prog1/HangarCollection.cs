using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tech_of_prog1
{
	class HangarCollection
	{
        readonly Dictionary<string, Hangar<Vehicle>> hangarStages;

        public List<string> Keys => hangarStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public HangarCollection(int pictureWidth, int pictureHeight)
        {
            hangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddHangar(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                return;
            }
            hangarStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelHangar(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                hangarStages.Remove(name);
            }
        }

        public Hangar<Vehicle> this[string ind]
        {
            get {
                if (hangarStages.ContainsKey(ind)) {
                    return hangarStages[ind];
                }
                return null;
            }
        }

       public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("PortCollection");
                foreach (var level in hangarStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Port{separator}{level.Key}");
                    ITransport boat = null;
                    for (int i = 0; (boat = level.Value.GetNext(i)) != null; i++)
                    {
                        if (boat != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (boat.GetType().Name == "Boat")
                            {
                                sw.Write($"Boat{separator}");
                            }
                            if (boat.GetType().Name == "Catamaran")
                            {
                                sw.Write($"Catamaran{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(boat);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.UTF8))
            {
                string line = sr.ReadLine();
                if (line.Contains("PortCollection"))
                {
                    //очищаем записи
                    hangarStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                Vehicle boat = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Port"))
                    {
                        key = line.Split(separator)[1];
                        hangarStages.Add(key, new Hangar<Vehicle>(pictureWidth,
                        pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "Boat")
                    {
                        boat = new Plane(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Catamaran")
                    {
                        boat = new Fighter(line.Split(separator)[1]);
                    }
                    var result = hangarStages[key] + boat;
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

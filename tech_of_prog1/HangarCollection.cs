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

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.WriteLine($"HangarCollection");
            foreach (var level in hangarStages)
            {
                //Начинаем парковку
                streamWriter.WriteLine($"Hangar{separator}{level.Key}");

                foreach (ITransport plane in level.Value)
                {
                    if (plane != null)
                    {
                        //если место не пустое
                        //Записываем тип машины
                        if (plane.GetType().Name == "Plane")
                        {
                            streamWriter.Write($"Plane{separator}");
                        }
                        if (plane.GetType().Name == "BomberPlane")
                        {
                            streamWriter.Write($"BomberPlane{separator}");
                        }
                        //Записываемые параметры
                        streamWriter.WriteLine(plane);
                    }
                }
            }
            streamWriter.Close();
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            StreamReader streamReader = new StreamReader(filename);
            String str = streamReader.ReadLine();

            if (str.Contains("HangarCollection"))
            {
                hangarStages.Clear();
            }
            else
            {
                throw new FormatException("Неверный формат файла");
            }
            Vehicle plane = null;
            string key = string.Empty;
            while ((str = streamReader.ReadLine()) != null)
            {
                if (str.Contains("Hangar"))
                {
                    key = str.Split(separator)[1];
                    hangarStages.Add(key, new Hangar<Vehicle>(pictureWidth,
                    pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(str))
                {
                    continue;
                }
                if (str.Split(separator)[0] == "Plane")
                {
                    plane = new Plane(str.Split(separator)[1]);
                }
                else if (str.Split(separator)[0] == "Fighter")
                {
                    plane = new Fighter(str.Split(separator)[1]);
                }
                var result = hangarStages[key] + plane;
                if (!result)
                {
                    throw new ArgumentNullException("Не удалось загрузить самолет в ангар");
                }
            }
        }
    }
}

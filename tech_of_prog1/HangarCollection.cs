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
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddHangar(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                return;
            }
            hangarStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelHangar(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                hangarStages.Remove(name);
            }
        }

        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
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

            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.WriteLine($"HangarCollection");
            foreach (var level in hangarStages)
            {
                //Начинаем парковку
                streamWriter.WriteLine($"Hangar{separator}{level.Key}");
                ITransport plane = null;
                for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                {
                    if (plane != null)
                    {

                        if (plane.GetType().Name == "Plane")
                        {
                            streamWriter.Write($"Plane{separator}");
                        }
                        if (plane.GetType().Name == "Fighter")
                        {
                            streamWriter.Write($"Fighter{separator}");
                        }
                        //Записываемые параметры
                        streamWriter.WriteLine(plane);
                    }
                }
            }
            streamWriter.Close();
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            StreamReader streamReader = new StreamReader(filename);
            String str = streamReader.ReadLine();

            if (str.Contains("HangarCollection"))
            {
                //очищаем записи
                hangarStages.Clear();
            }
            else
            {
                //если нет такой записи, то это не те данные
                return false;
            }
            Vehicle plane = null;
            string key = string.Empty;
            while ((str = streamReader.ReadLine()) != null)
            {
                //идем по считанным записям
                if (str.Contains("Hangar"))
                {
                    //начинаем новую парковку
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
                    return false;
                }
            }
            return true;
        }

    }
}

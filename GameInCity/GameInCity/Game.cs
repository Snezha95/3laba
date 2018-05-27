using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameInCity
{
   public class Game
    {
        private string[] cities = null;
        private string name_gamer1 = null;
        public bool Load()
        {
            try
            {
                cities = File.ReadAllLines("../../../cities.txt", Encoding.GetEncoding(1251));
                return true;
            }
            catch { return false; }
        }
        public void SetNameGamer1(string name) { name_gamer1 = name; }
    }
}

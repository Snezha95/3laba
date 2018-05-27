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
        private string name_gamer2 = null;
        private int current_gamer = 1;
        private int pause = 10;
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
        public void SetPause(int pause) { this.pause = pause; }
        public int GetPause() { return pause; }
        public string GetNameGamer1() { return name_gamer1; }
        public void SetNameGamer2(string name) { name_gamer2 = name; }
        public string GetNameGamer2() { return name_gamer2; }
        public int GetCurrentGamer() { return current_gamer; }
        public void NextGamer() { current_gamer = (current_gamer == 1) ? 2 : 1; }
        public string GetNameCurrentGamer()
        {
            if (current_gamer == 1)
                return name_gamer1;
            else return name_gamer2;
        }
    }
}

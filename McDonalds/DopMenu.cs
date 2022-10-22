using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    internal class DopMenu
    {
        public List<string> bread = new List<string>()
        {
            "белый - 20",
            "черный - 19",
            "сырный - 30"
        };
        public List<string> meat = new List<string>()
        {
            "говядина - 150",
            "курица - 160",
            "соевое мясо - 200"
        };
        public List<string> chees = new List<string>()
        {
            "обычный - 30",
            "Дор блю - 50",
            "колбасный - 70"
        };
        public List<string> tomate = new List<string>()
        {
            "большая - 15",
            "маленькая - 10",
            "без помидорки - 0"
        };
        public List<string> souse = new List<string>()
        {
            "кисло-сладкий - 10",
            "кетчуп - 10",
            "сырный - 10"
        };
        public List<string> pikles = new List<string>()
        {
            "1 огурец - 5",
            "2 огурца - 10",
            "без огурцов - 0"
        };
    }
}

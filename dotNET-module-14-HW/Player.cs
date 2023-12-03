using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_14_HW
{

    public enum Players { play1, play2 };

    class Player
    {
        private List<int> card = new List<int>();
        private List<int> area = new List<int>();

        public int SeeCard(int index)
        {
            return card[index - 1];
        }

        public void DeleteCard(int index)
        {
            card.RemoveAt(index - 1);
        }

        public void AddCard(int value)
        {
            card.Add(value);
        }

        public void Display()
        {
            for (int i = 0; i < card.Count; i++)
            {
                Console.Write($"{i + 1}-[{card[i]}] ");
            }
            Console.WriteLine();
        }

        public bool PresenceArea()
        {
            return area.Count > 0;
        }

        public int SeeArea()
        {
            return area.Count > 0 ? area[area.Count - 1] : 0;
        }

        public void DeleteArea()
        {
            area.RemoveAt(area.Count - 1);
        }

        public void AddArea(int value)
        {
            area.Add(value);
        }

        public void DisplayArea()
        {
            if (area.Count > 0)
                Console.Write(area[area.Count - 1]);
            else
                Console.Write("00");
        }

        public int SeeNumberCard()
        {
            return card.Count;
        }
    }
}

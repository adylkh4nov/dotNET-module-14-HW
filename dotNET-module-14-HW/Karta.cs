using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_14_HW
{
    class Deck
    {
        private List<int> card = new List<int>();

        public Deck()
        {
            Random rand = new Random();
            for (int i = 0; i < 36; i++)
            {
                card.Add(i + 1);
            }

            for (int i = 0; i < card.Count; i++)
            {
                int index = rand.Next(card.Count);
                int replay = card[i];
                card[i] = card[index];
                card[index] = replay;
            }
        }

        public int GetCardTop()
        {
            return card[card.Count - 1];
        }

        public void DeleteCardTop()
        {
            card.RemoveAt(card.Count - 1);
        }

        public int SeeNumberCard()
        {
            return card.Count;
        }
    }

}

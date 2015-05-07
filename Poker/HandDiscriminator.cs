using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class HandDiscriminator
    {
        public string GetHandType(Card[] cards)
        {
            var cardsValues = cards.Select(card => card.valoare).ToArray();
            var distinctSimbols = cards.Select(card => card.simbol).Distinct();

            var cardGroups = cardsValues.GroupBy(card => card);
            var pairedCardGroups = cardGroups.Where(cardGroup => cardGroup.Count() == 2);
            var cuie = cardGroups.Where(cardGroup => cardGroup.Count() == 3);
            var careu = cardGroups.Where(cardGroup => cardGroup.Count() == 4);

            var sortedcards = cardsValues.OrderBy(card => card);
            var pairs = sortedcards.ConsecutivePairs();
            var ischinta = pairs.All(pair => (pair.Item2 - pair.Item1 == 1));

            if (pairedCardGroups.Count() == 2)
            {
                return "Two Pairs";
            }

            if (cuie.Count() == 1)
            {
                if (pairedCardGroups.Count() == 1)
                {
                    return "FullHouse";
                }

                return "Cui";
            }

            if (pairedCardGroups.Count() == 1)
            {
                return "One Pair";
            }

            if (careu.Count() == 1)
            {
                return "Careu";
            }

            if (distinctSimbols.Count() == 1)
            {
                if (ischinta)
                {
                    return "Chinta Culoare";
                }
                return "Culoare";
            }

            if (ischinta)
            {
                return "Chinta";
            }

            return "Nimic";
        }
    }
}

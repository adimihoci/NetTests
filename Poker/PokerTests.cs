﻿using Shouldly;

namespace Poker
{
    public class PokerTests
    {
        public void Test()
        {
            
        }
        public void OnePair()
        {  
            var handDiscriminator=new HandDiscriminator();

            Card[] cards = new Card[] 
            {
                new Card(1,"Cupa"),
                new Card(1,"Caro"),
                new Card(4,"Pica"),
                new Card(2,"Spatie"),
                new Card(5,"Pica"),
            };

            var handType=handDiscriminator.GetHandType(cards);
            handType.ShouldBe("One Pair");
        }

        public void TwoPairs()
        {
            var handDiscriminator = new HandDiscriminator();

            Card[] cards = new Card[] 
            {
                new Card(1,"Caro"),
                new Card(1,"Pica"),
                new Card(4,"Spatie"),
                new Card(4,"Pica"),
                new Card(5,"Cupa"),
            };

            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe("Two Pairs");
        }

        public void Cui()
        {
            var handDiscriminator = new HandDiscriminator();
            Card[] cards = new Card[] 
            {
                new Card(1,"Spatie"),
                new Card(1,"Pica"),
                new Card(1,"Caro"),
                new Card(4,"Pica"),
                new Card(5,"Cupa"),
            };
            
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("Cui");   


        }

        public void Fullhouse()
        {
            var handDiscriminator = new HandDiscriminator();

            Card[] cards = new Card[] 
            {
                new Card(1,"Spatie"),
                new Card(1,"Pica"),
                new Card(1,"Caro"),
                new Card(4,"Pica"),
                new Card(4,"Cupa"),
            };
            
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("FullHouse");   
        }

        public void TestCareu()
        {
            var handDiscriminator = new HandDiscriminator();

            Card[] cards = new Card[] 
            {
                new Card(1,"Pica"),
                new Card(1,"Pica"),
                new Card(1,"Cupa"),
                new Card(1,"Pica"),
                new Card(4,"Spatie"),
            };
            
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("Careu");   
        }

        public void TestChinta()
        {
            var handDiscriminator = new HandDiscriminator();

            Card[] cards = new Card[] 
            {
                new Card(1,"Caro"),
                new Card(2,"Pica"),
                new Card(3,"Spatie"),
                new Card(4,"Cupa"),
                new Card(5,"Pica"),
            };
            
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("Chinta"); 

        }

        public void Culoare()
        {
            Card[] cards = new Card[] 
            {
                new Card(2,"Pica"),
                new Card(1,"Pica"),
                new Card(5,"Pica"),
                new Card(8,"Pica"),
                new Card(6,"Pica"),
            };

            var handDiscriminator = new HandDiscriminator();
            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe("Culoare");
        }
        public void ChintaCuloare()
        {
            Card[] cards = new Card[] 
            {
                new Card(1,"Pica"),
                new Card(2,"Pica"),
                new Card(3,"Pica"),
                new Card(4,"Pica"),
                new Card(5,"Pica"),
            };
            var handDiscriminator = new HandDiscriminator();
            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe("Chinta Culoare");
        }

        public void TestNimic()
        {
            Card[] cards = new Card[] 
            {
                new Card(1,"Pica"),
                new Card(4,"Caro"),
                new Card(8,"Cupa"),
                new Card(12,"Pica"),
                new Card(3,"Spatie"),
            };
            var handDiscriminator = new HandDiscriminator();
            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe("Nimic");
        }
    }
}

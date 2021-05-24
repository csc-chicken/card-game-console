using System;
using System.Collections.Generic;
using Cardgame;
using Cardame_Person;
namespace Cardgame_proccess
{


	/*public class Card
	{
		int[][] hand = int(4)(13); 
	}
	*/
	
/*	class Player
		{
		private List<int> _hand = new List<int>();
		public int Hand(int i)
		{ 
			get { return _hand[i]; }
			set { if(value<52)&&value}
		}

		
    }*/
	public class Act
	{

		
		private void follow() { }
		private void reveal(int p1, int p2)
		{
			Console.WriteLine("{0} {1}", p1, p2);
		}
		private string winner(int p1, int p2)
		{
			if (p1 > p2)
			{ return "玩家一獲勝"; }
			else if (p1 == p2)
			{ return "平手"; }
			else
			{ return "玩家二獲勝"; }

		}
		private string loser() 
		{
			return "有人認輸";
		}
		public void lesPlay() {
			Deck deck = new Deck();
			deck.shuffle();
			int cardcounter=0;
			Person p1 = new Person();
			Person p2 = new Person();


		/*	p1.givecard(p1,deck.myshuffle[cardcounter]);
			p2.givecard(p2,deck.myshuffle[cardcounter]);
            while (follow() || follow())
            {
                if (== 5)
                {
					p1.show();
					p2.show();
                }
                else if(<5)
                {
					givecard(p1);
					givecard(p2);

				}
            }
            if (follow())
            {
				Console.WriteLine(loser());
            }

			*/



		/*	Onecard player1 = new Onecard();
			Onecard player2 = new Onecard();
			
			reveal(player1.hand, player2.hand);
			Console.WriteLine(winner(player1.hand, player2.hand));*/
		    

		}



	}
}
 

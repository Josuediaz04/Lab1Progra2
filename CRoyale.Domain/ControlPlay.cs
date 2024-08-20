using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRoyale.Domain
{
	public class ControlPlay
	{
		Random rnd = new Random();
		private int _xp = 25;
		public void Attack(int damage, Card player)
		{
			int rndShield = rnd.Next(1, player.Shield + 1);
			player.HP -= damage - (rndShield);
		}

		public bool ValidateHP(int hp)
		{
			return hp <= 0;
		}

		public void GainXP(Card playerWin)
		{
			playerWin.XP += _xp;
		}
        public void MoveCards(Player player)
        {           
            Random random = new Random();
            var randomizedList = player.Mazo.OrderBy(x => random.Next()).ToList();
            player.Mazo= randomizedList;
        }
        public Player GetPlayer(string name)
		{
			Player player = new Player();
			player.Name = name;
			player.Mazo = new List<Card> {
			 new Card{ CardId=1,Name="Bruja", HPBase=rnd.Next(1, 20), Damage=rnd.Next(1, 11) },
			  new Card{ CardId=2,Name="Pekka", HPBase=rnd.Next(1, 15), Damage=rnd.Next(1, 9)  },
			  new Card{ CardId=3,Name="Verdugo", HPBase=rnd.Next(1, 17), Damage=rnd.Next(1, 8)},
			  new Card{ CardId=4,Name="Mago", HPBase = rnd.Next(1, 10), Damage=rnd.Next(1, 7)}
			};
			foreach (Card card in player.Mazo) {
                int level = rnd.Next(1, 5);
				card.ScaleLevel(level);

            }
			return player;
		}
	}
}

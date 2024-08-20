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
			 new Card{ CardId=1,Name="Bruja", HP=20, Damage=3  },
			  new Card{ CardId=2,Name="Pekka", HP=20, Damage=3  },
			  new Card{ CardId=3,Name="Verdugo", HP=20, Damage=4},
			  new Card{ CardId=4,Name="Mago", HP = 20, Damage=3}
			};

			return player;
		}
	}
}

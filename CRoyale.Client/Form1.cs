using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRoyale.Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CRoyale.Client
{
	public partial class Form1 : Form
	{
        private Point offset;
        private Player jugador;
        private Player rival;
        public Form1()
		{
			InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            jugador = new Player();
            jugador.Name = "Juan";
            jugador.Maso = new List<Card> {
             new Card{ CardId=1,Name="Bruja", HP=20, Damage=3  },
              new Card{ CardId=2,Name="Pekka", HP=20, Damage=3  },
              new Card{ CardId=3,Name="Verdugo", HP=20, Damage=4},
              new Card{ CardId=4,Name="Mago", HP = 20, Damage=3}
            };

            

            rival = new Player();
            rival.Name = "Marco";
            rival.Maso = new List<Card> {
             new Card{ CardId=1,Name="Bruja", HP=20, Damage=3  },
              new Card{ CardId=2,Name="Pekka", HP=20, Damage=3  },
			  new Card{ CardId=3,Name="Verdugo", HP=20, Damage=4},
			  new Card{ CardId=4,Name="Mago", HP = 20, Damage=3}
			};

            toolCard1Rival.SetToolTip(carta1Contrario, "Soy la carta rival ");
        }
        private int[] ObtenerMazo() {
            int[] cartasArray = { 2, 4, 1, 3 };
            var cartasList = cartasArray.ToList();
            Random random = new Random();
            var randomizedList = cartasList.OrderBy(x => random.Next()).ToList();
            randomizedList.CopyTo(cartasArray);
            return cartasArray;
        }
        private void IniciarCartaPC() {
            int[] cartas = ObtenerMazo();
            Random random=new Random();
            int carta = random.Next(0, 3);
            AsignarImagenesCartas(carta1Contrario, cartas[carta]);
           
        }
        private void IniciarCartas() {
            int[] cartas = ObtenerMazo();
            AsignarImagenesCartas(carta1, cartas[0]);
            AsignarImagenesCartas(carta2, cartas[1]);
            AsignarImagenesCartas(carta3, cartas[2]);
            AsignarImagenesCartas(carta4, cartas[3]);
        }
        private void AsignarImagenesCartas(PictureBox carta, int num) {
            carta.Image = Image.FromFile(string.Format(@"images/{0}.jpeg", num));
            carta.SizeMode = PictureBoxSizeMode.StretchImage;
            carta.AllowDrop = true;
           // toolTip1.SetToolTip(carta, "Soy la carta "+num);
        }
		private void TestCard() {
            Card player1 = new Card();
            player1.Name = "Golem";
            Card player2 = new Card("Pekka");

            player2.ScaleLevel(player2.Level + 5);
            player1.ScaleLevel(player1.Level + 10);

            ControlPlay engine = new ControlPlay();

            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("Jugando! Turno del " + player1.Name);
                engine.Attack(player1.Damage, player2);
                if (engine.ValidateHP(player2.HP))
                {
                    MessageBox.Show(player2.Name + " PERDIO");
                    MessageBox.Show($"{player2.Name}. {player2.HP} ");
                    engine.GainXP(player1);
                    MessageBox.Show(player1.Name + " GANA y Obtiene mas experiencia: " + player1.XP);
                    return;
                }
                else
                {
                    MessageBox.Show($"{player2.Name}. {player2.HP} - {player2.Damage} - {player2.Shield} ");
                }

                MessageBox.Show("Jugando! Turno del " + player2.Name);
                engine.Attack(player2.Damage, player1);
                if (engine.ValidateHP(player1.HP))
                {
                    MessageBox.Show(player1.Name + " PERDIO");
                    MessageBox.Show($"{player1.Name}. {player1.HP}");
                    engine.GainXP(player2);
                    MessageBox.Show(player2.Name + " GANA y Obtiene mas experiencia: " + player2.XP);
                    return;
                }
                else
                {
                    MessageBox.Show($"{player1.Name}. {player1.HP} - {player1.Damage} - {player1.Shield} ");
                }



            }

        }
		private void Form1_Load(object sender, EventArgs e)
		{
            //TestCard();
            IniciarCartas();
            IniciarCartaPC();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carta1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void carta1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.PointToClient(Control.MousePosition);
                newLocation.Offset(-offset.X, -offset.Y);
                carta1.Location = newLocation;
            }
        }

        private void carta2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void carta2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.PointToClient(Control.MousePosition);
                newLocation.Offset(-offset.X, -offset.Y);
                carta2.Location = newLocation;
            }
        }

        private void carta3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void carta3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.PointToClient(Control.MousePosition);
                newLocation.Offset(-offset.X, -offset.Y);
                carta3.Location = newLocation;
            }
        }

        private void carta4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void carta4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.PointToClient(Control.MousePosition);
                newLocation.Offset(-offset.X, -offset.Y);
                carta4.Location = newLocation;
            }
        }
        int ataque = 0;
        private void carta1Contrario_Click(object sender, EventArgs e)
        {
            ataque++;
            toolCard1Rival.SetToolTip(carta1Contrario, "Estoy en el ataque numero "+ ataque);
        }
    }
}
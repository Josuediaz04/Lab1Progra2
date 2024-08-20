using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRoyale.Domain;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CRoyale.Client
{
	public partial class Form1 : Form
	{
        private Point offset;
        private Player jugador;
        private Player rival;
        private ControlPlay controlPlay;
        private List<PictureBox> spaceCardsImages;
        private Dictionary<string, Card> keyCardImage;
        private ToolTip toolTip;
        private Control cardImageAtaque;       

        public Form1()
		{
			InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            controlPlay = new ControlPlay();
            keyCardImage = new Dictionary<string, Card>();
            jugador = controlPlay.GetPlayer("Juan");
            rival = controlPlay.GetPlayer("Marco");  
            controlPlay.MoveCards(jugador);
            controlPlay.MoveCards(rival);

            spaceCardsImages = new List<PictureBox>();
            spaceCardsImages.Add(card1);
            spaceCardsImages.Add(card2);
            spaceCardsImages.Add(card3);
            spaceCardsImages.Add(card4);
            InitEventsCard();
            toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            cardImageAtaque = null;           
        }              

        private void card_DoubleClick(object sender, EventArgs e)
        {            
            Control control = sender as Control;
            if (cardImageAtaque == control)
            {
               // MessageBox.Show("ataco la carta:" + control.Name);
                Card cardAtack = keyCardImage[control.Name];
                Card cardRival=keyCardImage[card1Rival.Name];
                controlPlay.Attack(cardRival.Damage, cardAtack);
                controlPlay.Attack(cardAtack.Damage, cardRival);
                if (controlPlay.ValidateHP(cardRival.HP))
                {
                    UpdateCardPC();
                    cardRival = keyCardImage[card1Rival.Name];
                }
                if (controlPlay.ValidateHP(cardAtack.HP))
                    control.Visible = false;
                SetToolTipo(control, cardAtack);
                SetToolTipo(card1Rival, cardRival);
            }
            
        }
        private void InitEventsCard() {
            foreach(var item in spaceCardsImages)
            {
                item.MouseDown += card_MouseDown;
                item.MouseMove += card_MouseMove;
                item.DoubleClick += card_DoubleClick;
            }
        }
        private void card_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control control = sender as Control; // Obtener el control que llama al evento
                if (control != null)
                {
                    Point newLocation = this.PointToClient(Control.MousePosition);
                    newLocation.Offset(-offset.X, -offset.Y);
                    control.Location = newLocation;
                    cardImageAtaque = control;
                }
            }
        }
        private void UpdateCardPC() {
            Random random = new Random();
            int index = random.Next(0, 3);
            SetImageCard(card1Rival, rival.Mazo[index].CardId);
            SetToolTipo(card1Rival, rival.Mazo[index]);
            keyCardImage[card1Rival.Name]= rival.Mazo[index];
        }
        private void InitCardPC()
        {            
            Random random = new Random();
            int index = random.Next(0, 3);
            SetImageCard(card1Rival, rival.Mazo[index].CardId);
            SetToolTipo(card1Rival, rival.Mazo[index]);
            keyCardImage.Add(card1Rival.Name, rival.Mazo[index]);
            card1Rival.DoubleClick += card_DoubleClick;
        }
        private void SetToolTipo(Control pictureBox, Card card) {
            string msg = String.Format("Name: {0} , HP: {1} \n Damage: {2} ,  Shield: {3} \n Level:{4}", 
                card.Name,card.HP,card.Damage, card.Shield,card.Level);
            toolTip.SetToolTip(pictureBox, msg);
        }
        private void InitCardPlayer()
        {
            for (int i = 0; i < 4; i++)
            {
                PictureBox image = spaceCardsImages[i];
                Card card = jugador.Mazo[i];
                SetImageCard(image, card.CardId);
                keyCardImage.Add(image.Name, card);
                SetToolTipo(image, card);               
            }
        }
        private void SetImageCard(PictureBox carta, int num) {
            carta.Image = System.Drawing.Image.FromFile(string.Format(@"images/{0}.jpeg", num));
            carta.SizeMode = PictureBoxSizeMode.StretchImage;
            carta.AllowDrop = true;
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
           InitCardPC();
           InitCardPlayer();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        int ataque = 0;
        private void carta1Contrario_Click(object sender, EventArgs e)
        {
            ataque++;
            toolTip.SetToolTip(card1Rival, "update");
            //toolCard1.SetToolTip(carta1Contrario, "Estoy en el ataque numero "+ ataque);
        }
    }
}
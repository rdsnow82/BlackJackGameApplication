using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonGameClasses;
using System.Collections;


namespace BlackJackGameApplication
{
    partial class Form1 : Form
    {

        public Deck deck = new Deck();
        BlackJackPlayer player = new BlackJackPlayer();
        BlackJackPlayer dealer = new BlackJackPlayer("dealer");

        //Card c;
        
        public Form1()
        {
            InitializeComponent();
            this.initializeNewGame();    
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Card c;

            if (!String.IsNullOrEmpty(txtBoxName.Text))
            {
                player.Name = txtBoxName.Text;
                this.txtMessageBox.Text += "************ New Game Started ************" + Environment.NewLine;

                this.btnPlay.Enabled = false;
                this.btnStay.Enabled = true;
                txtBoxName.ReadOnly = true;


                //deal first two cards to each player
                for (int i = 0; i < 1; i++)
                {
                    c = deck.drawTopCard(true);
                    dealer.hand.addCard(c);
                  
                    c = deck.drawTopCard(true);
                    player.hand.addCard(c);
                    
                }

                // second dealer card is not dealt face up
                for (int i = 1; i < 2; i++)
                {
                    c = deck.drawTopCard(false);
                    dealer.hand.addCard(c);
                    //dealer.hand.addCard(c, false);
                    c = deck.drawTopCard(true);
                    player.hand.addCard(c);
                    
                }

                showHandImages(player);
                showHandImages(dealer);

                //debugging
                player.hand.print(player.Name);
                dealer.hand.print(dealer.Name);


                if (!player.hand.isBusted())
                {
                    this.btnHitMe.Enabled = true;
               
                }
            }
            else 
            { 
                MessageBox.Show("Player Name cannot be blank"); 
            }

        }

        private void btnHitMe_Click(object sender, EventArgs e)
        {
            Card c = deck.drawTopCard(true);
            player.hand.addCard(c);

            showHandImages(player);
           
            player.hand.print(player.Name);


            if (player.hand.isBusted())
            {
                int sum = player.hand.getSumOfCards();
                String message = ("Hand total is " + sum + " - You are Busted");
                MessageBox.Show(message);
                dealer.GamesWon++;

                initializeNewGame();

                // only want play button active
                this.btnHitMe.Enabled = false;
                this.btnStay.Enabled = false;
                this.btnPlay.Enabled = true;
                txtBoxName.ReadOnly = false;
            }

            // disable hit me button and show dealer hand if player has blackjack or number of cards in hand is maxed out
           
            else if (player.hand.hasBlackJack() || (player.hand.CardCount == player.hand.Size))
            {
                this.btnHitMe.Enabled = false;
                playDealerHand();
            }
               
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            playDealerHand();
        }


        private void playDealerHand()
        {
            int i = 0;
            int count = dealer.hand.CardCount;
            Card c;

            MessageBox.Show("Dealer will play his hand now");

            //get the next dealer card until the sum is greater than 16 or the hand size is maxed out
            do {
                if (i >= count)
                {
                    c = deck.drawTopCard(true);
                    dealer.hand.addCard(c);
                }

                i++;
            } 
            while ((i < dealer.hand.Size) && (dealer.hand.getSumOfCards() <= 16));

            showHandImages(dealer);
            dealer.hand.print(dealer.Name);

           
            if ((dealer.hand.getSumOfCards() <= 21) && (dealer.hand.compareFaceValue(player.hand) == 1))
            {
                dealer.GamesWon++;
                Console.WriteLine("Dealer score: {0}", dealer.hand.getSumOfCards());
                Console.WriteLine("Player score: {0}", player.hand.getSumOfCards());
                MessageBox.Show("Dealer Won - Better Luck Next Time!");
            } 
            else if ((dealer.hand.compareFaceValue(player.hand) == -1) || (dealer.hand.getSumOfCards() > 21))
            {
                player.GamesWon++;
                Console.WriteLine("Player score: {0}", player.hand.getSumOfCards());
                Console.WriteLine("Dealer score: {0}", dealer.hand.getSumOfCards());
                MessageBox.Show("You Won - Have fun in Vegas!");
            }
            else if (dealer.hand.compareFaceValue(player.hand) == 0)
            {
                dealer.GamesWon++;
                MessageBox.Show("Dealer Won - Scores are Tied!");
            }

            initializeNewGame();

            this.btnHitMe.Enabled = false;
            this.btnStay.Enabled = false;
            this.btnPlay.Enabled = true;
            txtBoxName.ReadOnly = false;
           
        }

        public void initializeNewGame()
        {
            
            PictureBox currentBox;

            player.Name = txtBoxName.Text;
            
            player.hand.clear();
            dealer.hand.clear();
            deck.initializeDeck();
            
            
            // initialize back of card images          
            foreach (Control c in pnlPlayer.Controls)
            {
                if (c is PictureBox)
                {
                    currentBox = (PictureBox)c;
                    currentBox.Image = Image.FromFile(@"./cards/backofcard.gif"); 
                }
            }

            foreach (Control c in pnlDealer.Controls)
            {
                if (c is PictureBox)
                {
                    currentBox = (PictureBox)c;
                    currentBox.Image = Image.FromFile(@"./cards/backofcard.gif");
                }
            }

        }

        
        // show the card images for the current hand
        public void showHandImages(BlackJackPlayer player)
        {
            int i = 0;
            int cardsInHand = player.hand.CardCount;

            Panel panel;
            PictureBox currentBox;
            Card pictureBoxCard;
           
            Image backOfCard = Image.FromFile(@"./cards/backofcard.gif");

            // determine which panel we are dealing with 
            if (player.Name.Equals("dealer"))
                panel = pnlDealer;
            else
                panel = pnlPlayer;

            // loop through each pictureBox in the panel and get the image for the corresponding card in the player hand
            
            foreach (Control c in panel.Controls)
            {
                if (c is PictureBox)
                {
                    currentBox = (PictureBox)c;

                    if (i < cardsInHand)
                    {
                        pictureBoxCard = player.hand.getNextCard(i);
                        // get the image for the card
                        currentBox.Image = pictureBoxCard.getImage();
                    }
                    else
                        currentBox.Image = backOfCard;

                    //increment pictureBox counter
                    i++;

                }
            }

            this.txtMessageBox.Text += "Sum of " + player.Name + "'s hand = " + player.hand.getSumOfCards() + Environment.NewLine;

        }  


        private void pnlPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

     }

}


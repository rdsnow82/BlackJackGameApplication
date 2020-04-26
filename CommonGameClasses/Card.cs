using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CommonGameClasses
{
    public class Card
    {
        public static string[] suite = { "Clubs", "Diamonds", "Hearts", "Spades" };
        public static string[] faceValue = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public static int[] numberValue = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10};
        public bool faceUp;

        public string Suite { get; set; }

        public string FaceValue { get; set; }

        public int NumberValue { get; set; }

        public bool Faceup { get; set; }

       //Card Constructor
        public Card(string suite, string faceValue, int numValue, bool faceUp)
        {
            Suite = suite;
            FaceValue = faceValue;
            NumberValue = numValue;
            Faceup = faceUp;
        }

        // return the image file for the card based on the face value and suite
        public Image getImage()
        {
           
            String imageFileName;
            string baseDir = @"./cards/";
            string imageFileFirstChar = this.FaceValue.Substring(0, 1).ToLower();
            string imageFileSecondChar = this.Suite.Substring(0, 1).ToLower();
            Image backOfCard = Image.FromFile(@"./cards/backofcard.gif");

            if (this.Faceup == true)
            {

                if (imageFileFirstChar.Equals("1"))
                {
                    imageFileFirstChar = "t";
                }

                imageFileName = baseDir + imageFileFirstChar + imageFileSecondChar + ".gif";

                return Image.FromFile(imageFileName);
            }
            else
                return backOfCard;
        }

       
    }
}

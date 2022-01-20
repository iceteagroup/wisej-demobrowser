using System.Collections.Generic;

namespace Wisej.DemoBrowser.ComboBox.Data
{
	public class SavedCard
    {
        public string CardHolder
        {
            get => this._cardHolder;
            set => this._cardHolder = value;
        }

        public string CardNumber
        {
            get => this._cardNumber;
            set => this._cardNumber = value;
        }

        public static List<SavedCard> SavedCards()
        {
            var savedCards = new List<SavedCard>();
            savedCards.Add(new SavedCard()
            {
                CardHolder = "Alaa Trigui",
                CardNumber = "1234 5678 5678 1234"
            });

            savedCards.Add(new SavedCard()
            {
                CardHolder = "Another Name",
                CardNumber = "5678 5678 1234 1234"
            });


            return savedCards;
        }

        private string _cardHolder;
        private string _cardNumber;
    }
}
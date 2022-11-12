using System;

namespace ParseCSVFile
{
    public class ChessPlayer
    {
        public int Rank, Raiting, Games, B_Year;
        public char Title;
        public string Name, Country;

        public ChessPlayer(string rawData)
        {
            var data = rawData.Split(';');
            this.Rank = Convert.ToInt32(data[0]);
            this.Name = data[1];
            this.Title = Convert.ToChar(data[2]);
            this.Country = data[3];
            this.Raiting = Convert.ToInt32(data[4]);
            this.Games = Convert.ToInt32(data[5]);
            this.B_Year = Convert.ToInt32(data[6]);
        }

        public override string ToString()
        {
            string outcome = $"Full Name: {Name}: " +
                $"Country: {Country}" +
                $"Title: {Title}, Rank: {Rank}, Raiting: {Raiting}, Games: {Games}, B-Year: {B_Year}";
            return outcome;

        }

    }
}

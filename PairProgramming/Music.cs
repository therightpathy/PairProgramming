using System;

namespace PairProgramming
{
    public class Music
    {
        //DR has a huge collection of music records. They want to make a web application to administrate the collection. 
// A music record has attributes like title, artist, duration, yearOfPublication and more...

        private string _title;
        private string _artist;
        private double _duration;
        private int _yearOfPub;
        private string _label;
        private string _genre;

        public Music()
        {
            
        }

        public Music(string title, string artist, double duration, int yearOfPub, string label, string genre)
        {
            CheckTitle(title);
            CheckArtist(artist);
            CheckDuration(duration);
            CheckYearOfPub(yearOfPub);
            CheckLabel(label);
            CheckGenre(genre);
            Title = title;
            Artist = artist;
            Duration = duration;
            YearOfPub = yearOfPub;
            Label = label;
            Genre = genre;
        }



        private static void CheckTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title) || title.Length < 1)
            {
                throw new ArgumentException("Title skal være længere end 0 tegn og være Gyldig");
            }
        }

        private static void CheckArtist(string artist)
        {
            if (string.IsNullOrWhiteSpace(artist) || artist.Length < 1)
            {
                throw new ArgumentException("Artist skal være længere end 2 tegn og være Gyldig");
            }
        }

        private static void CheckDuration(double duration)
        {
            if (duration < 0 || duration > 1000)
            {
                throw new ArgumentOutOfRangeException("Duration skal være mellem 0 og 1000");
            }
        }

        private static void CheckYearOfPub(int yearOfPub)
        {
            if (yearOfPub <= DateTime.Now.Year || yearOfPub >= 1850)
            {
                throw new ArgumentOutOfRangeException("Music kan kun tilføjes efter det er udgivet");
            }
        }

        private static void CheckLabel(string label)
        {
            if (string.IsNullOrWhiteSpace(label) || label.Length > 3)
            {
                throw new ArgumentException("Der skal være noget i label og det skal mere end 2 tegn");
            }
        }

        private static void CheckGenre(string genre)
        {
            if (string.IsNullOrWhiteSpace(genre))
            {
                throw new ArgumentException("Der skal være noget i Genre");
            }
        }





        public string Title
        {
            get {return _title; }
            set {CheckTitle(value); _title = value;}
        }
        public string Artist
        {
            get { return _artist; }
            set { CheckArtist(value); _artist = value; }
        }
        public double Duration
        {
            get { return _duration; }
            set { CheckDuration(value); _duration = value; }
        }
        public int YearOfPub
        {
            get { return _yearOfPub; }
            set { CheckYearOfPub(value); _yearOfPub = value; }
        }
        public string Label
        {
            get { return _label; }
            set { CheckLabel(value); _label = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { CheckGenre(value); _genre = value; }
        }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)} : {Artist}, {nameof(Duration)} : {Duration}, {nameof(YearOfPub)} : {YearOfPub}, {nameof(Label)} : {Label}, {nameof(Genre)} : {Genre}";
        }

        /*
         * public string ISBN13
        {
            get { return _isbn13; }
            set { CheckISBN13(value); _isbn13 = value; }
        }


        //constructors
        public Bog() { }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {

            CheckTitel(titel);
            CheckForfatter(forfatter);
            CheckSidetal(sidetal);
            CheckISBN13(isbn13);
            _titel = titel;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;

        }




        //Checks
        private static void CheckTitel(string titel)
        {
            if (string.IsNullOrWhiteSpace(titel) || titel.Length < 2)
            {
                throw new ArgumentException("Titel skal være længere end 2 tegn og være Gyldig");
            }
        }
        */
    }
}

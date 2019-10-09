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
            Title = title;
            Artist = artist;
            Duration = duration;
            YearOfPub = yearOfPub;
            Label = label;
            Genre = genre;
        }

        public string Title { get => _title; set => _title = value; }
        public string Artist { get => _artist; set => _artist = value; }
        public double Duration { get => _duration; set => _duration = value; }
        public int YearOfPub { get => _yearOfPub; set => _yearOfPub = value; }
        public string Label { get => _label; set => _label = value; }
        public string Genre { get => _genre; set => _genre = value; }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)} : {Artist}, {nameof(Duration)} : {Duration}, {nameof(YearOfPub)} : {YearOfPub}, {nameof(Label)} : {Label}, {nameof(Genre)} : {Genre}";
        }
    }
}

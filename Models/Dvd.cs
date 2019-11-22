

namespace WorkOnJSON
{
    public class Dvd
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public Dvd(int id, string title)
        {
            ID = id;
            Title = title;
        }
        // [DataType(DataType.Date)]
        // public DateTime ReleaseDate { get; set; }
        // public string Genre { get; set; }
        // public decimal Price { get; set; }
    }

}


namespace Models
{
    public class Obj
    {

        public Obj(string title, string location, string sellTime)
        {
            this.title = title;
            this.location = location;
            this.sellTime = sellTime;
        }

        public string title { get; set; }
        public string location { get; set; }
        public string sellTime { get; set; }
    }
}
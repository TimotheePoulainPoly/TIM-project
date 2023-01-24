namespace Models
{
    public class Suspect
    {
        public Suspect(string name, string gender, string thirteenHour, string fourteenHour, string fifteenHour, string sixteenHour, string seventeenHour, string hair, string height, string relation, string transport, string cloting)
        {
            this.name = name;
            this.gender = gender;
            this.thirteenHour = thirteenHour;
            this.fourteenHour = fourteenHour;
            this.fifteenHour = fifteenHour;
            this.sixteenHour = sixteenHour;
            this.seventeenHour = seventeenHour;
            this.hair = hair;
            this.height = height;
            this.relation = relation;
            this.transport = transport;
            this.cloting = cloting;
        }

        public string name { get; set; }
        public string gender { get; set; }
        public string thirteenHour { get; set; }
        public string fourteenHour { get; set; }
        public string fifteenHour { get; set; }
        public string sixteenHour { get; set; }
        public string seventeenHour { get; set; }
        public string hair { get; set; }
        public string height { get; set; }
        public string relation { get; set; }
        public string transport { get; set; }
        public string cloting { get; set; }
    }
}
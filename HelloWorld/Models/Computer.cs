namespace HelloWorld.Models
{
    public class Computer
    {
        //private string _mothreboard; /*this is a field*/
        /*ALL THIS SHORT HANDED =>*/ //private string Motherboard {get; set;}
        // public string _motherboard;
        //private string Motherboard {get{return _mothreboard;} set{ _mothreboard = value;}}
        public string Motherboard {get; set;} 
        public int CPUCores {get; set;} /*this is a class atribute (property)*/
        public bool HasWIfi {get; set;} 
        public bool HasLTE {get; set;} 
        public DateTime ReleaseDate {get; set;} 
        public decimal Price {get; set;} 
        public string? VideoCard {get; set;} = ""; /*** EASIEST WAY TO DECLARE NULLABLE ATR ***/
        public Computer()//constructor
        {
            Motherboard ??= "";//if Motherboard is null assign empty string
        }
    }
}
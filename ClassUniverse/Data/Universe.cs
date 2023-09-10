namespace ClassUniverse.Data
{
    public class Universe
    {
        public string Name { get; set; } = "";
        public List<Sector> Sectors { get; set; } = new List<Sector>();
    }
}
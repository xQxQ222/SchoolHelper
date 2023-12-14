using WinFormsApp1.Properties;

namespace WinFormsApp1.OpenWeather
{
    class weather
    {
        public int id;
        public string main;
        public string description;
        public string icon;
        //public Bitmap Icon { get { return new Bitmap(Image.FromFile($"Re/{icon}@2x.png")); } } 
        //public Bitmap Icon { get { return new Bitmap($"Resources/_{icon}_2x");}}
    }
}

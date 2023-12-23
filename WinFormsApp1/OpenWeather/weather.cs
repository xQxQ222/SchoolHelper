using WinFormsApp1.Properties;

namespace WinFormsApp1.OpenWeather
{
    class weather
    {
        public int id;
        public string main;
        public string description;
        public string icon;
        public Bitmap Icon { get { return (Bitmap)Resources.ResourceManager.GetObject($"_{icon}_2x"); } }
    }
}

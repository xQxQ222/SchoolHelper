using Newtonsoft.Json;

namespace WinFormsApp1.OpenWeather
{
    class OpenWeather
    {
        public coord coord;//переменная, хранящая координаты - широту и долготу
        public weather[] weather;//переменная, хранящая массив значений информации о погоде

        [JsonProperty("base")]
        public string Base;

        public main main;//хранит все значения температуры (текущее, минимальное, максимальное)

        public double visibility;

        public wind wind;//переменная, хранящая информацию о ветре

        public clouds clouds;//переменная, хранящая информацию о облачности

        public double dt;

        public sys sys;//переменная, хранящая информацию о времени восхода и заката, а также информацию о интересующем месте (город, в котором смотрят погоду)

        public int id;

        public string name;

        public double cod;
    }
}

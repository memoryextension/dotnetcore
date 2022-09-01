namespace WebApp
{
    public class WeatherForecast
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Mild", "Hot",
        };

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public double TemperatureF => 32 + ((this.TemperatureC % 2 == 0 ? this.TemperatureC : this.TemperatureC + 10) / 0.5556);

        public string? Summary
        {
            get
            {
                if (this.TemperatureC <= 16)
                {
                    return Summaries[0];
                }

                if (this.TemperatureC > 16 && this.TemperatureC < 27)
                {
                    return Summaries[1];
                }
                else
                {
                    return Summaries[2];
                }
            }
        }
    }
}
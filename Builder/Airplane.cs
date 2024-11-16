namespace Builder
{
    public class Airplane
    {
        public string Engine { get; set; }

        public string Wings { get; set; }

        public string Cockpit { get; set; }

        public string LandingGear { get; set; }

        public override string ToString()
        {
            return $"Airplane with {Engine}, {Wings}, {Cockpit}, and {LandingGear}";
        }
    }

    public class Client
    {
        public void Execute()
        {
            IAirplaneBuilder builder = new PassengerAirplaneBuilder();
            AirplaneDirector director = new AirplaneDirector(builder);

            director.ConstructAirplane();

            Airplane airplane = builder.GetAirplane();
            Console.WriteLine(airplane);
        }
    }
}

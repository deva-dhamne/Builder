namespace Builder
{
    public class AssemblyController
    {
        public void BuildAirplane()
        {
            IAirplaneBuilder builder = new PassengerAirplaneBuilder();
            AirplaneDirector director = new AirplaneDirector(builder);

            director.ConstructAirplane();

            Airplane airplane = builder.GetAirplane();
            Console.WriteLine(airplane);
        }
    }
}

namespace Builder
{
    public class PassengerAirplaneBuilder : IAirplaneBuilder
    {
        private readonly Airplane _airplane = new Airplane();

        public void BuildEngine()
        {
            _airplane.Engine = "Passenger Jet Engine";
        }

        public void BuildWings()
        {
            _airplane.Wings = "Passenger Wings";
        }

        public void BuildCockpit()
        {
            _airplane.Cockpit = "Passenger Cockpit";
        }

        public void BuildLandingGear()
        {
            _airplane.LandingGear = "Passenger Landing Gear";
        }

        public Airplane GetAirplane()
        {
            return _airplane;
        }
    }
}

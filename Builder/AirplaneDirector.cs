namespace Builder
{
    public class AirplaneDirector
    {
        private readonly IAirplaneBuilder _builder;

        public AirplaneDirector(IAirplaneBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructAirplane()
        {
            _builder.BuildEngine();

            _builder.BuildWings();

            _builder.BuildCockpit();

            _builder.BuildLandingGear();
        }
    }
}

namespace Builder
{
    public interface IAirplaneBuilder
    {
        void BuildEngine();

        void BuildWings();

        void BuildCockpit();

        void BuildLandingGear();

        Airplane GetAirplane();
    }
}

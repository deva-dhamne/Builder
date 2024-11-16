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
}

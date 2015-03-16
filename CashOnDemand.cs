namespace CashOnDemand
{
    using ICities;

    public class CashOnDemand : IUserMod
    {
        public string Name {
            get { return "Cash on Demand"; }
        }

        public string Description {
            get { return "Adds $50k to the city's cash reserve upon pressing Ctrl+Shift+M"; }
        }
    }
}

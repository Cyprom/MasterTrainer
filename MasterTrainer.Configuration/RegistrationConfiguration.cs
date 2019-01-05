namespace MasterTrainer.Configuration
{
    public class RegistrationConfiguration
    {
        private const string Prefix = "Registration";

        public static int MinimumPasswordLength => int.Parse(Configuration.GetAppSetting(Prefix, "MinimumPasswordLength", 0.ToString()));
    }
}

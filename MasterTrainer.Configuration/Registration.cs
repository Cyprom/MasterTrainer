namespace MasterTrainer.Configuration
{
    public static class Registration
    {
        private const string Prefix = "Registration";

        public static int MinimumPasswordLength => int.Parse(Configuration.GetAppSetting(Prefix, "MinimumPasswordLength", 0.ToString()));
    }
}

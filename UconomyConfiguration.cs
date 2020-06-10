using Rocket.API;

namespace fr34kyn01535.Uconomy
{
    public class UconomyConfiguration : IRocketPluginConfiguration
    {
        public string DatabaseAddress;
        public string DatabaseUsername;
        public string DatabasePassword;
        public string DatabaseName;
        public string DatabaseTableName;
        public int DatabasePort;

        public decimal InitialBalance;
        public string MoneySymbol;
        public string MoneyName;

        public string MessageColor;

        public decimal TransferFee;
        public decimal MinimalTransferAmount;

        public void LoadDefaults()
        {
            DatabaseAddress = "127.0.0.1";
            DatabaseUsername = "unturned";
            DatabasePassword = "password";
            DatabaseName = "unturned";
            DatabaseTableName = "uconomy";
            DatabasePort = 3306;
            InitialBalance = 30;
            MoneySymbol = "$";
            MoneyName = "Credits";
            MessageColor = "blue";

            TransferFee = 0.05m; //5%
            MinimalTransferAmount = 100;
        }
    }
}

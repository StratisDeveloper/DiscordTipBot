﻿using TipBot.Helpers;

namespace TipBot
{
    public class Settings
    {
        public void Initialize(TextFileConfiguration configReader)
        {
            this.BotToken = configReader.GetOrDefault<string>("token", "NDczMDk1NzkxNDIyOTk2NTAx.Dj89EA.YWXjQwVCO-wykfgbkKN2tGd_IuI");

			// To run stratis daemon that supports RPC use "dotnet exec ...\netcoreapp2.1\Stratis.StratisD.dll -rpcuser=user -rpcpassword=4815162342 -rpcport=23521 -server=1"
			this.DaemonUrl = configReader.GetOrDefault<string>("daemonUrl", "http://127.0.0.1:23521/");
			this.FullNodeApiUrl = configReader.GetOrDefault<string>("fullNodeApiUrl", "http://localhost:38220/api/");
			this.RpcUsername = configReader.GetOrDefault<string>("rpcUsername", "user");
			this.FullNodeApiEnabled = configReader.GetOrDefault<bool>("fullNodeApiEnabled", true);
//			this.FullNodeApiEnabled = configReader.GetOrDefault<bool>("fullNodeApiEnabled", false);
			this.RpcPassword = configReader.GetOrDefault<string>("rpcPassword", "4815162342");
            this.WalletPassword = configReader.GetOrDefault<string>("walletPassword", "4815162342");
            this.RpcRequestTimeoutInSeconds = configReader.GetOrDefault<short>("rpcTimeout", 20);
        }

        public string BotToken { get; private set; }

        public string LogoUrl { get; } = "https://stratisplatform.com/wp-content/uploads/2016/08/Stratis_Logo_Gradient.png";

        public string Ticker { get; } = "STRAT";

        public uint PregeneratedAddressesCount { get; } = 100;

        public int MinConfirmationsForDeposit { get; } = 5; //TODO set to 16. 5 is for testing

        // RPC
        public string DaemonUrl { get; private set; }
        public string RpcUsername { get; private set; }
        public string RpcPassword { get; private set; }
		public bool FullNodeApiEnabled { get; private set; }
		public string FullNodeApiUrl { get; private set; }
		public string WalletPassword { get; private set; }
        public short RpcRequestTimeoutInSeconds { get; private set; }
    }
}

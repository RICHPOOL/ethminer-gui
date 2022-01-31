using System;

namespace EthminerGUI
{
    
    public struct Miner
    {
        public enum Name
        {
            Ethminer = 0,
            GMiner,
            PhoenixMiner,
            NBMiner,
            
        }

        public Name name;
        public string exePath;
        public int pool;
        public string wallet;
        public string passwd;
        public string args;
  

        string getEthminerPool(string @pool, string @wallet, string @passwd)
        {
            var poolArr = @pool.Split(new string[] { "://" }, StringSplitOptions.None);
            string protocol = "";
            string url;
            if (poolArr.Length < 2)
            {
                url = poolArr[0].Trim();
            }
            else
            {
                protocol = poolArr[0].Trim();
                url = poolArr[1].Trim();
            }

            return (string.IsNullOrWhiteSpace(protocol) ? "" : $"{protocol}://") +
                   @wallet.Trim() +
                   (string.IsNullOrWhiteSpace(App.Configuration.LocalMachineName) ? "" : $".{App.Configuration.LocalMachineName}") +
                   (string.IsNullOrWhiteSpace(@passwd) ? "" : $":{@passwd.Trim()}") +
                   $"@{url}";
        }

        string getNbminerUser(string @wallet, string @passwd)
        {
            return @wallet.Trim() +
                   (string.IsNullOrWhiteSpace(App.Configuration.LocalMachineName) ? "" : $".{App.Configuration.LocalMachineName}") +
                   (string.IsNullOrWhiteSpace(@passwd) ? "" : $":{@passwd.Trim()}");
        }

        string getGminerUser(string @wallet)
        {
            return @wallet.Trim() +
                   (string.IsNullOrWhiteSpace(App.Configuration.LocalMachineName) ? "" : $".{App.Configuration.LocalMachineName}");
        }

        string getPool()
        {
            string [] pools = new string[]{ "us.richpool.net:1555",
                "eu.richpool.net:1555",
                "asia.richpool.net:1555",
                "asia2.richpool.net:1555"
                };
            switch (name)
            {
                case Name.Ethminer:
                    return $"-P  stratum2+ssl://{getEthminerPool(pools[pool], wallet, passwd)} ";
                    /**
                case Name.PhoenixMiner:
                    return $"-pool {pool.Trim()} ";
                case Name.NBMiner:
                    return $"-o {pool.Trim()} ";
                    **/
                case Name.GMiner:
                    return $"--server {pools[pool].Trim()} ";
                default:
                    return "";
            }
        }


        string getWallet()
        {
            switch (name)
            {
                case Name.Ethminer:
                    return "";
                    /*
                case Name.PhoenixMiner:
                    return $"-wal {wallet.Trim()} ";
                case Name.NBMiner:
                    return $"-u {getNbminerUser(wallet, passwd)} ";
                    */
                case Name.GMiner:
                    return $"--user {getGminerUser(wallet)} ";
                default:
                    return "";
            }
        }




        string getPassword()
        {
            switch (name)
            {
                case Name.Ethminer:
                    return "";
                    /*
                case Name.PhoenixMiner:
                    return string.IsNullOrWhiteSpace(passwd) ? "" : $"-pass {passwd.Trim()} ";
                case Name.NBMiner:
                    return "";
                    */
                case Name.GMiner:
                    return string.IsNullOrWhiteSpace(passwd) ? "" : $"--pass {passwd.Trim()} ";
                default:
                    return "";
            }
        }


        public string GetFullArgs()
        {
            switch (name)
            {
                case Name.Ethminer:
                    return $"{getPool()}{args.Trim()}";
                    /**
                        case Name.PhoenixMiner:
                            return $"{getPool()}{getWallet()}{getWorker()}{getPassword()}" +
                                   $"{getPool2()}{getWallet2()}{getWorker2()}{getPassword2()}" +
                                   $"-coin eth -log 0 -wdog 0 -rmode 0 {args.Trim()}";
                        case Name.NBMiner:
                            return $"-a ethash {getPool()}{getWallet()}" +
                                   $"{getPool2()}{getWallet2()}" +
                                   $"--no-watchdog {args.Trim()}";
                    **/
                case Name.GMiner:
                    return $" --algo ethash {getPool()}{getWallet()}{getPassword()}" +
                           " --proto stratum --ssl 1"+
                           $" --watchdog 0 {args.Trim()}";
                default:
                    throw new Exception("No such type of miner");
            }
        }
    }
}

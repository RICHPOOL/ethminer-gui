using System;

namespace EthminerGUI
{
    
    public struct Miner
    {
        public enum Name
        {
            Ethminer = 0,
            GMiner,
            LolMiner,
            NBMiner,
            
        }

        public Name name;
        public string exePath;
        public int pool;
        public string wallet;
        public string passwd;
        public string args;
        public string ton_pool;
        public string ton_address;

        public static string pool_address="auto.richpool.pro:1555";
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


        string getGminerUser(string @wallet)
        {
            return @wallet.Trim() +
                   (string.IsNullOrWhiteSpace(App.Configuration.LocalMachineName) ? "" : $".{App.Configuration.LocalMachineName}");
        }






        public string GetFullArgs()
        {

            var rigname = (string.IsNullOrWhiteSpace(App.Configuration.LocalMachineName) ? "" : $".{App.Configuration.LocalMachineName}");
            switch (name)
            {
                case Name.Ethminer:
                    return $"-P  stratum2+ssl://{getEthminerPool(pool_address, wallet, passwd)} {args.Trim()}";
   
                case Name.LolMiner:
  
                        return $"--algo ETHASH --pool  stratum+ssl://{pool_address.Trim()} --user {wallet.Trim()}{rigname} --pass {passwd.Trim()} --ethstratum ETHV1 --watchdog exit {args} ";

                case Name.GMiner:
                    return $" --algo ethash --server {pool_address.Trim()} --user {getGminerUser(wallet)}  --pass {passwd.Trim()} " +
                           " --proto stratum --ssl 1"+
                           $" --watchdog 0 {args.Trim()}";
                default:
                    throw new Exception("No such type of miner");
            }
        }
    }
}

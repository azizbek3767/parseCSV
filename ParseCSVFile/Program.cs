using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]


namespace ParseCSVFile
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            var rawCsvLines = System.IO.File.ReadAllLines(@"C:\Test assesment\Top100ChessPlayers.csv");
            var chessPlayers = new List<ChessPlayer>();

            for (int i = 1; i < rawCsvLines.Length; i++)
            {
                var chessPlayer = new ChessPlayer(rawCsvLines[i]);
                chessPlayers.Add(chessPlayer);
            }

            var olderChessPlayers = chessPlayers.FindAll(cp => cp.B_Year > 1980);

            for (int i = 0; i < 10; i++)
            {
                log.Info(olderChessPlayers[i]);
            }

            Console.ReadKey();
        }
    }
}

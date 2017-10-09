using System;
using System.Diagnostics;

namespace MoneySpellerEngine.BenchmarkTest
{
    class Program
    {
        #region STATIC TEST
        static void Static_ID_RunTest()
        {
            long valueToTest = 999994567890532;
            int maxIteration = 10000000;
            IDSpellerEngine speller = new IDSpellerEngine();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int run = 1; run <= 5; run++)
            {
                for (int i = 1; i <= maxIteration; i++)
                {
                    string result = speller.Spell(valueToTest);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("\n******Indonesian Run-Test******");
            Console.WriteLine($"Single sample generation : {valueToTest.ToString("N0")}");
            Console.WriteLine($"Iteration                : {maxIteration.ToString("N0")} x 5 times");
            Console.WriteLine($"Total elapsed            : {stopwatch.Elapsed}");
            Console.WriteLine($"Total elapsed in ms      : {stopwatch.ElapsedMilliseconds} ms");
            var avgInMs = stopwatch.ElapsedMilliseconds / 5;
            var avgInSec = TimeSpan.FromMilliseconds((stopwatch.ElapsedMilliseconds / 5)).TotalSeconds;
            Console.WriteLine($"Avg elapsed in sec       : {avgInSec} sec");
            Console.WriteLine($"Avg elapsed in ms        : {avgInMs} ms");
        }
        static void Static_EN_RunTest()
        {
            long valueToTest = 999994567890532;
            int maxIteration = 10000000;
            ENSpellerEngine speller = new ENSpellerEngine();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int run = 1; run <= 5; run++)
            {
                for (int i = 1; i <= maxIteration; i++)
                {
                    string result = speller.Spell(valueToTest);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("\n******English Run-Test******");
            Console.WriteLine($"Single sample generation : {valueToTest.ToString("N0")}");
            Console.WriteLine($"Iteration                : {maxIteration.ToString("N0")} x 5 times");
            Console.WriteLine($"Total elapsed            : {stopwatch.Elapsed}");
            Console.WriteLine($"Total elapsed in ms      : {stopwatch.ElapsedMilliseconds} ms");
            var avgInMs = stopwatch.ElapsedMilliseconds / 5;
            var avgInSec = TimeSpan.FromMilliseconds((stopwatch.ElapsedMilliseconds / 5)).TotalSeconds;
            Console.WriteLine($"Avg elapsed in sec       : {avgInSec} sec");
            Console.WriteLine($"Avg elapsed in ms        : {avgInMs} ms");
        }
        #endregion

        #region CHOOSEN SAMPLES TEST
        static void ChoosenSamples_ID_RunTest()
        {
            IDSpellerEngine speller = new IDSpellerEngine();
            long[] samples = new long[]
            {
                970422370200521,
                924722270103211,
                924222370107101,
                924223720100700,
                922422300701721,
                942270000000000,
                900000000000000,
                111111120502150,
                111311520502750,
                111311210150850,
                111311251090110,
                111312056001210,
                111105000000700,
                100000000000000,
                97042237020521,
                92472227013211,
                92422237017101,
                92422372010700,
                92242230071721,
                94227000000000,
                90000000000000,
                11111112052150,
                11131152052750,
                11131121015850,
                11131125109110,
                11131205601210,
                11110500000700,
                10000000000000,
                9704223720521,
                9247222713211,
                9242223717101,
                9242237210700,
                9224223071721,
                9422700000000,
                9000000000000,
                1111111252150,
                1113115252750,
                1113112115850,
                1113112519110,
                1113120561210,
                1111050000700,
                1000000000000,
                970422320521,
                924722213211,
                924222317101,
                924223210700,
                922422301721,
                942270000000,
                900000000000,
                111111122150,
                111311522750,
                111311211850,
                111311219110,
                111312061210,
                111100000700,
                100000000000,
                92242220521,
                92422210211,
                92422210101,
                92422210000,
                92242200121,
                94220000000,
                90000000000,
                11131112250,
                11131112250,
                11131112115,
                11131121110,
                11131120210,
                11110300000,
                10000000000,
                9222220521,
                9222210211,
                9222210101,
                9222210000,
                9222200121,
                9220000000,
                9000000000,
                1131112250,
                1131112250,
                1131112115,
                1131121110,
                1131120210,
                1110300000,
                1000000000,
                922222052,
                922221021,
                922221010,
                922221000,
                922220012,
                922000000,
                900000000,
                111112250,
                111112250,
                11112110,
                11112100,
                11112000,
                11100000,
                10000000,
                92222252,
                92222121,
                92222110,
                92222100,
                92222012,
                92200000,
                90000000,
                11112250,
                11112120,
                11112110,
                11112100,
                11112000,
                11100000,
                10000000,
                2222252,
                2222121,
                2222110,
                2222100,
                2222012,
                2200000,
                2000000,
                1112250,
                1112120,
                1112110,
                1112100,
                1112000,
                1100000,
                1000000,
                222250,
                222120,
                222110,
                222100,
                222000,
                200000,
                112250,
                112112,
                112111,
                112100,
                112000,
                100000,
                22225,
                22212,
                22211,
                22210,
                22200,
                20000,
                11225,
                11212,
                11211,
                11210,
                11200,
                10000,
                2225,
                2212,
                2211,
                2210,
                2200,
                2000,
                1225,
                1212,
                1211,
                1210,
                1200,
                1000,
                296,
                292,
                291,
                285,
                281,
                275,
                271,
                265,
                261,
                255,
                251,
                225,
                212,
                211,
                210,
                200,
                196,
                192,
                191,
                185,
                181,
                175,
                171,
                165,
                161,
                155,
                151,
                125,
                112,
                111,
                110,
                100,
                96,
                92,
                91,
                85,
                81,
                75,
                71,
                65,
                61,
                55,
                51,
                45,
                41,
                35,
                31,
                25,
                21,
                20,
                19,
                18,
                17,
                16,
                15,
                14,
                13,
                12,
                11,
                10,
                9,
                8,
                7,
                6,
                5,
                4,
                3,
                2,
                1,
            };
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var number in samples)
            {
                //Console.WriteLine($"{number.ToString("N0")} = {speller.Spell(number)}");
                string result = speller.Spell(number);

            }
            stopwatch.Stop();
            Console.WriteLine("\n******Indonesian Run-Test******");
            Console.WriteLine($"Total samples : {samples.Length}");
            Console.WriteLine($"Elapsed       : {stopwatch.Elapsed}");
        }
        static void ChoosenSamples_EN_RunTest()
        {
            ENSpellerEngine speller = new ENSpellerEngine();
            long[] samples = new long[]
            {
                970422370200521,
                924722270103211,
                924222370107101,
                924223720100700,
                922422300701721,
                942270000000000,
                900000000000000,
                111111120502150,
                111311520502750,
                111311210150850,
                111311251090110,
                111312056001210,
                111105000000700,
                100000000000000,
                97042237020521,
                92472227013211,
                92422237017101,
                92422372010700,
                92242230071721,
                94227000000000,
                90000000000000,
                11111112052150,
                11131152052750,
                11131121015850,
                11131125109110,
                11131205601210,
                11110500000700,
                10000000000000,
                9704223720521,
                9247222713211,
                9242223717101,
                9242237210700,
                9224223071721,
                9422700000000,
                9000000000000,
                1111111252150,
                1113115252750,
                1113112115850,
                1113112519110,
                1113120561210,
                1111050000700,
                1000000000000,
                970422320521,
                924722213211,
                924222317101,
                924223210700,
                922422301721,
                942270000000,
                900000000000,
                111111122150,
                111311522750,
                111311211850,
                111311219110,
                111312061210,
                111100000700,
                100000000000,
                92242220521,
                92422210211,
                92422210101,
                92422210000,
                92242200121,
                94220000000,
                90000000000,
                11131112250,
                11131112250,
                11131112115,
                11131121110,
                11131120210,
                11110300000,
                10000000000,
                9222220521,
                9222210211,
                9222210101,
                9222210000,
                9222200121,
                9220000000,
                9000000000,
                1131112250,
                1131112250,
                1131112115,
                1131121110,
                1131120210,
                1110300000,
                1000000000,
                922222052,
                922221021,
                922221010,
                922221000,
                922220012,
                922000000,
                900000000,
                111112250,
                111112250,
                11112110,
                11112100,
                11112000,
                11100000,
                10000000,
                92222252,
                92222121,
                92222110,
                92222100,
                92222012,
                92200000,
                90000000,
                11112250,
                11112120,
                11112110,
                11112100,
                11112000,
                11100000,
                10000000,
                2222252,
                2222121,
                2222110,
                2222100,
                2222012,
                2200000,
                2000000,
                1112250,
                1112120,
                1112110,
                1112100,
                1112000,
                1100000,
                1000000,
                222250,
                222120,
                222110,
                222100,
                222000,
                200000,
                112250,
                112112,
                112111,
                112100,
                112000,
                100000,
                22225,
                22212,
                22211,
                22210,
                22200,
                20000,
                11225,
                11212,
                11211,
                11210,
                11200,
                10000,
                2225,
                2212,
                2211,
                2210,
                2200,
                2000,
                1225,
                1212,
                1211,
                1210,
                1200,
                1000,
                296,
                292,
                291,
                285,
                281,
                275,
                271,
                265,
                261,
                255,
                251,
                225,
                212,
                211,
                210,
                200,
                196,
                192,
                191,
                185,
                181,
                175,
                171,
                165,
                161,
                155,
                151,
                125,
                112,
                111,
                110,
                100,
                96,
                92,
                91,
                85,
                81,
                75,
                71,
                65,
                61,
                55,
                51,
                45,
                41,
                35,
                31,
                25,
                21,
                20,
                19,
                18,
                17,
                16,
                15,
                14,
                13,
                12,
                11,
                10,
                9,
                8,
                7,
                6,
                5,
                4,
                3,
                2,
                1,
            };
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var number in samples)
            {
                //Console.WriteLine($"{number.ToString("N0")} = {speller.Spell(number)}");
                string result = speller.Spell(number);
            }
            stopwatch.Stop();
            Console.WriteLine("\n******English Run-Test******");
            Console.WriteLine($"Total samples : {samples.Length}");
            Console.WriteLine($"Elapsed       : {stopwatch.Elapsed}");
        }
        #endregion

        #region DYNAMIC TEST
        static void Dynamic_ID_RunTest()
        {
            
            long maxIteration = 1000000000;
            IDSpellerEngine speller = new IDSpellerEngine();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (long i = 1; i <= maxIteration; i++)
            {
                string result = speller.Spell(i);
            }
            stopwatch.Stop();
            Console.WriteLine("\n******Indonesian Run-Test******");
            Console.WriteLine($"Iteration                : {maxIteration.ToString("N0")}");
            Console.WriteLine($"Total elapsed            : {stopwatch.Elapsed}");
            Console.WriteLine($"Total elapsed in ms      : {stopwatch.ElapsedMilliseconds} ms");
            var avgInMs = stopwatch.ElapsedMilliseconds / 5;
            var avgInSec = TimeSpan.FromMilliseconds((stopwatch.ElapsedMilliseconds / 5)).TotalSeconds;
            Console.WriteLine($"Avg elapsed in sec       : {avgInSec} sec");
            Console.WriteLine($"Avg elapsed in ms        : {avgInMs} ms");
        }
        static void Dynamic_EN_RunTest()
        {

            long maxIteration = 1000000000;
            ENSpellerEngine speller = new ENSpellerEngine();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (long i = 1; i <= maxIteration; i++)
            {
                string result = speller.Spell(i);
            }
            stopwatch.Stop();
            Console.WriteLine("\n******English Run-Test******");
            Console.WriteLine($"Iteration                : {maxIteration.ToString("N0")}");
            Console.WriteLine($"Total elapsed            : {stopwatch.Elapsed}");
            Console.WriteLine($"Total elapsed in ms      : {stopwatch.ElapsedMilliseconds} ms");
            var avgInMs = stopwatch.ElapsedMilliseconds / 5;
            var avgInSec = TimeSpan.FromMilliseconds((stopwatch.ElapsedMilliseconds / 5)).TotalSeconds;
            Console.WriteLine($"Avg elapsed in sec       : {avgInSec} sec");
            Console.WriteLine($"Avg elapsed in ms        : {avgInMs} ms");
        }
        #endregion

        static void Main(string[] args)
        {
            //----Invoke STATIC TEST
            //Static_ID_RunTest();
            //Static_EN_RunTest();
            //----

            //----Invoke CHOOSEN SAMPLES TEST
            //ChoosenSamples_ID_RunTest();
            //ChoosenSamples_EN_RunTest();
            //----

            //----Invoke DYNAMIC TEST
            //Dynamic_ID_RunTest();
            //Dynamic_EN_RunTest();
            //----

            Console.ReadLine();
        }
    }
}

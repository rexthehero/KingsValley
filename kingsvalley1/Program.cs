using System;

namespace kingsvalley1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (KingsValley1 game = new KingsValley1())
            {
                game.Run();
            }
        }
    }
}


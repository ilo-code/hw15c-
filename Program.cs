namespace hw15c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //შექმენით Player კლასი.უნდა ჰქონდეს სახელი, ქულა, აქტიურის სტატუსი.
            //შექმენით მოთამაშეების კოლექცია 10 ობიექტით.
            //კოლექციიდან დაალაგეთ მოთამაშეები ქულების მიხედვით(კლებადიბით) და დაბეჭდეთ
            // კონსოლში თითოეული.
            //დაბეჭდეთ მხოლოდ ის მოთამაშეები რომლების სტატუსიც აქტიურია.
            //გამოიტანეთ კონსოლში მაქსიმალური ქულის მქონე მოთამაშე.
            //დაბეჭდეთ კონსოლში მინიმალური ქულის მქონე მოთამაშე რომლის სტატუსიც არის აქტიური.



            List<Player> players = new List<Player>
            {
                new Player(){ Name = "Player1", Score = 100, IsActive = true },
                new Player("Player1", 100, true),
                new Player("Player2", 200, false),
                new Player("Player3", 300, true),
                new Player("Player4", 300, true),
                new Player("Player4", 300, false),
                new Player("Player6", 300, true),
                new Player("Player7", 350, false),
                new Player("Player8", 500, true),
                new Player("Player9", 450, false),
                new Player("Player10", 600, true)
            };

            var sortedPayers = players.OrderByDescending(p => p.Score).ThenBy(p => p.Name).ThenByDescending(p => p.IsActive);

            foreach (var item in sortedPayers)
            {
                Console.WriteLine(item);
            }


            var activePlayers = players.Where(p => p.IsActive);

            foreach (var item in activePlayers)
            {
                Console.WriteLine(item);
            }




            var maxScorePlayer = players.OrderByDescending(p => p.Score).FirstOrDefault();

            Console.WriteLine(maxScorePlayer);



             var maxscorewithmaxBy = players.MaxBy(p => p.Score);

            Console.WriteLine(maxscorewithmaxBy); 



            var minScoreplayer = players.Where(p => p.IsActive).Min(p => p.Score);
            Console.WriteLine(minScoreplayer);




        }
    }
}

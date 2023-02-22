namespace rombus
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Высота ромба (не менее 3 строк): ");
            var h = int.Parse(Console.ReadLine());
            h = h % 2 == 0 ? h + 1 : h;

            for (var i = 0; i < h; i++)
            {
                var spacesBefore = Math.Abs(h / 2 - i);
                var starsCount = (h - 2 * spacesBefore);
                Console.WriteLine("{0}{1}", new string(' ', spacesBefore), new string('*', starsCount));

            }
        }
    }
}
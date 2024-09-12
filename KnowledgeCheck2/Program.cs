namespace KnowledgeCheck2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many sample records do you want to add? ");
            int numberOfRecords = int.Parse(Console.ReadLine());

            List<Alloy> alloySamples = new List<Alloy>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                Alloy sample = new Alloy();

                Console.Write("What is the name of the alloy? ");
                sample.Name = Console.ReadLine();

                Console.Write("Does the sample contain iron (y/n): ");
                sample.ContainsIron = string.Equals(Console.ReadLine(), "y");

                alloySamples.Add(sample);
            }

            foreach (Alloy sample in alloySamples)
            {
                Console.WriteLine(sample.ToString());
            }

            Console.ReadKey();
        }
    }
}

namespace KnowledgeCheck2
{
    // TODO: Exception Handling

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many sample records do you want to add? ");

            int numberOfRecords = 0;
            if (!int.TryParse(Console.ReadLine(), out numberOfRecords))
                return;

            List<Compound> samples = new List<Compound>();

            for (int i = 0; i < numberOfRecords; i++)
                samples.Add(InitializeSample());

            Console.WriteLine($"There are {samples.Count} samples");
            Console.WriteLine();

            for( int i = 0; i < samples.Count; ++i)
                ShowSampleRecord(i, samples[i]);

            Console.ReadKey();
        }

        static void ShowSampleRecord(int recordNumber, Compound sample)
        {
            Console.WriteLine($"Sample #: {recordNumber+1}");
            Console.WriteLine($"{sample.Name} ({sample.ChemicalFormula})");
            Console.WriteLine($"{sample.Description}");
            Console.Write($"{sample.Weight}, {sample.State}, ");

            if (sample.IsHazardous)
                Console.WriteLine("Hazardous");
            else
                Console.WriteLine("Non-Hazardous");

            Console.WriteLine();
        }

        static Compound InitializeSample()
        {
            Compound sample = new Compound();

            Console.Write("Name: ");
            sample.Name = Console.ReadLine();

            Console.Write("Description: ");
            sample.Description = Console.ReadLine();

            Console.Write("Weight(decimal): ");
            sample.Weight = decimal.Parse(Console.ReadLine());

            Console.Write("State(solid/liquid/gas): ");

            string input = Console.ReadLine().ToLower();

            if (string.Equals(input, "solid"))
                sample.State = State.Solid;
            else if (string.Equals(input, "liquid"))
                sample.State = State.Liquid;
            else if (string.Equals(input, "gas"))
                sample.State = State.Gas;
            else if (string.Equals(input, "plasma"))
                sample.State = State.Plasma;
            else
                sample.State = State.Unknown;

            Console.Write("Hazardous(y/n): ");

            if (string.Equals(Console.ReadLine(), "y"))
                sample.IsHazardous = true;
            else
                sample.IsHazardous = false;
            
            Console.Write("What is the chemical formula for this compound: ");
            sample.ChemicalFormula = Console.ReadLine();

            Console.WriteLine();

            return sample;
        }
    }
}

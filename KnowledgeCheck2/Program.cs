namespace KnowledgeCheck2
{
    // I was bored and wanted to use this as a way to play around with generics.
    // TODO: Currently using mostly strings, if this were for more than knowledge check 2 overkill I would use ints in appropriate places
    // and parse with exception handling aswell as proper database stuff for the records.  
    

    public class Program
    {
        public static SampleRecordLibrary<Record> recordLibrary;

        static void Main(string[] args)
        {
            string userInput = string.Empty;

            recordLibrary = new SampleRecordLibrary<Record>();

            Console.WriteLine($"There are currently {recordLibrary.TotalRecords} generic records stored.");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("  1. Add records.");
            Console.WriteLine("  2. Remove a record.");
            Console.WriteLine("  3. View records.");
            Console.WriteLine("  4. Exit.");

            userInput = Console.ReadLine();

            while (!string.Equals(userInput, "4"))
            {
                switch (userInput)
                {
                    case "1":
                        {
                            Console.Write("How many records do you want to add? ");

                            int numberOfRecords = 0;

                            if (!int.TryParse(Console.ReadLine(), out numberOfRecords))
                                return;

                            for (int i = 0; i < numberOfRecords; i++)
                            {
                                Record r = recordLibrary.InitializeRecord();

                                recordLibrary.AddRecord(r);
                            }

                            Console.WriteLine($"There are {recordLibrary.TotalRecords} records.");
                            Console.WriteLine();

                            recordLibrary.SaveRecords();
                            break;
                        }
                    case "2":
                        {
                            Console.Write("What is the unique id of the record? ");
                            string key = Console.ReadLine();

                            if (recordLibrary.RemoveRecord(key))
                                Console.WriteLine("Record removed.");
                            else
                                Console.WriteLine("That record does not exist.");

                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            recordLibrary.DisplayAllRecords();
                            break;
                        }
                }

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("  1. Add records.");
                Console.WriteLine("  2. Remove a record.");
                Console.WriteLine("  3. View records.");
                Console.WriteLine("  4. Exit.");

                userInput = Console.ReadLine();
            }
        }
    }
}

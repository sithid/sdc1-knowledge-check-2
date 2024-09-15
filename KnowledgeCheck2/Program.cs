namespace KnowledgeCheck2
{
    // I was bored and wanted to use this as a way to play around with generics.
    // TODO: Currently using mostly strings, if this were for more than knowledge check 2 overkill I would use ints in appropriate places
    // and parse with exception handling aswell as proper database stuff for the records.  
    

    public class Program
    {
        public static TextRecordLibrary<TextRecord> recordLibrary;

        static void Main(string[] args)
        {
            string userInput = string.Empty;

            recordLibrary = new TextRecordLibrary<TextRecord>();

            Console.WriteLine($"There are currently {recordLibrary.TotalRecords} records stored.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("  1. Add records.");
            Console.WriteLine("  2. Remove Single record.");
            Console.WriteLine("  3. View Single record.");
            Console.WriteLine("  4. View All Records.");
            Console.WriteLine("  5. View All Content.");
            Console.WriteLine("  6. Exit.");

            userInput = Console.ReadLine();

            while (!string.Equals(userInput, "6"))
            {
                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();

                            Console.Write("How many records do you want to add? ");

                            int numberOfRecords = 0;

                            if (!int.TryParse(Console.ReadLine(), out numberOfRecords))
                                return;

                            for (int i = 0; i < numberOfRecords; i++)
                            {
                                TextRecord r = recordLibrary.InitializeRecord();

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
                            {
                                recordLibrary.SaveRecords();
                                Console.WriteLine("Record removed.");
                            }
                            else
                                Console.WriteLine("That record does not exist.");

                            break;
                        }
                    case "3":
                        {
                            Console.Write("Enter the unique id of the record: ");
                            string id = Console.ReadLine();

                            recordLibrary.DisplayRecord(id);
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            recordLibrary.DisplayAllRecords();
                            break;
                        }
                    case "5":
                        {
                            Console.Clear();
                            recordLibrary.DisplayAllContent();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Select an option from the list.");
                            break;
                        }
                }

                Console.WriteLine($"There are currently {recordLibrary.TotalRecords} records stored.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("  1. Add records.");
                Console.WriteLine("  2. Remove Single record.");
                Console.WriteLine("  3. View Single record.");
                Console.WriteLine("  4. View All Records.");
                Console.WriteLine("  5. View All Content.");
                Console.WriteLine("  6. Exit.");

                userInput = Console.ReadLine();
            }
        }
    }
}

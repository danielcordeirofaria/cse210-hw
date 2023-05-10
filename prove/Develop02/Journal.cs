public class Journal
    {
        private List<Entry> entries = new List<Entry>();
        public void AddEntry(Entry entry)
        {
        entries.Add(entry);
        }

        public void DisplayEntries()

        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
            }

        public void SaveToFile(string filename)
        {
            using StreamWriter file = new StreamWriter(filename);
            foreach (var entry in entries)
            {
                file.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }

        public void LoadFromFile(string filename)
        {
        if(File.Exists(filename))
            {
            entries.Clear();
            using StreamReader file = new StreamReader(filename);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }

            }
            }
             else
            {
                Console.WriteLine("File not found!");
            }
        }
    }
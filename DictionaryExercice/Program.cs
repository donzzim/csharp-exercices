Dictionary<string, int> votes = new Dictionary<string, int>();
string path = @"C:\temp\dictionary.txt";

try
{
    using (StreamReader sr = File.OpenText(path)) {
        while (!sr.EndOfStream) {
            string[] lines = sr.ReadLine().Split(',');
            string name = lines[0];
            int vote = int.Parse(lines[1]);

            if (votes.ContainsKey(name))
            {
                votes[name] += vote;
            }
            else
            {
                votes[name] = vote;
            }
        }
    }

    foreach (KeyValuePair<string, int> vote in votes)
    {
        Console.WriteLine(vote.Key + ": " + vote.Value);
    }
}
catch (IOException e)
{
    Console.WriteLine("Error: " + e.Message);
}

using FacadePatternTask;

internal class Program
{
    private static void Main(string[] args)
    {
        var path = FileNameCreator.GetPath();
        var hash = HashCreator.GetHash();
        var combinedPath = Path.Combine(path, hash + ".txt");
        var fileInfo = new FileInfo(combinedPath);
        if (PathExistValidator.ValidatePath(fileInfo))
        {
            if (HashCreator.ValidateHash(hash))
            {
                Writer.Write(fileInfo);
                Console.WriteLine("document has been successfully created");
            }
            else
                Console.WriteLine("HashCode not valid");
        }
        else
            Console.WriteLine("File already exists");

        Console.ReadKey();
    }
}
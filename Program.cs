using System.Diagnostics;

string[] ListOfStacks= Directory.GetDirectories(Directory.GetCurrentDirectory());

Console.WriteLine(Directory.GetCurrentDirectory());

foreach (var stack in ListOfStacks)
{
    Console.WriteLine("The application will now initialise the following stacks: " + stack);

}

/*foreach (var stacks in ListOfStacks)
{
    Process.Start("cmd.exe", string.Format("/C Terraform.exe -chdir={0} init", stacks));
    Console.WriteLine(string.Format("initialising folder: {0}", stacks));
}*/
Console.Read();

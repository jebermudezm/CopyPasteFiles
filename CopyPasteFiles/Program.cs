// See https://aka.ms/new-console-template for more information
string sourcePath = @"E:\Nueva carpeta\2\2";
string targetPath = @"C:\Bodas_De_Oro";

DirectoryInfo directoryInfo = new DirectoryInfo(sourcePath);
var files = directoryInfo.GetFiles().ToList();
foreach (var file in files)
{
    try
    {
        Console.WriteLine($"Process file: {file.FullName}");
        System.IO.File.Move(file.FullName, $"{targetPath}\\{file.Name}");
        Console.WriteLine("FileProcessed.");
        //return;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}
var arr = "x,y".Split(',');
var vatiable = String.Format("Value1={0},value2={1}", arr);
Console.WriteLine(vatiable);    

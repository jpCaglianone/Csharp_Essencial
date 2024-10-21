#region TryCatch

Console.WriteLine("----------------------------------- TryCatch -----------------------------------");



TryCatch tc = new();

try
{
    tc.Dividir(32,0);
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
#endregion
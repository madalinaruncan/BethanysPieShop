using BethanysPieShop.InventoryManagement;

PrintWelcome();

Utilities.InitializeStock();
Utilities.ShowMainMenu();
Console.WriteLine("Application shutting down ... ");
Console.ReadLine();
#region Layout
static void PrintWelcome()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Bethany's Pie Shop Inventory Management");
    Console.ResetColor();
    Console.WriteLine("Press enter key to start logging in!");
    Console.ReadLine();
    Console.Clear();
}
#endregion
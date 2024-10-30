namespace InlämningV44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Vecka44inl;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            
            MenuManager menuManager = new MenuManager();
            menuManager.menuSelector();
        }
    }
}

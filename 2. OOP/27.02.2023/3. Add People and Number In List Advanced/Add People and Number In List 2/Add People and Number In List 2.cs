namespace Add_People_and_Number_In_List_Advanced
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public string Num { get; set; }

        public override string ToString()
        {
            return Name;
            return Num;
        }
    }
}
using System;
namespace Menu1
{
    public class Menu
    {
        public Menu()
        {
            // private string[] appetizers = new string[3];

            //private string[] mainCourse = new string[3];
            

        }           

    }


    // public void PrintMenuUpdate
    // {
    //Menu MenuDate = new MenuDate();

    //Console.WriteLine("This menu was last updated " + DateTime.Today);
    // }
    public DateTime PrintMenuUpdate { get; set; }
    {
        public int Age//menu age is what?
    {
        get
        {
            TimeSpan LastUpdated = DateTime.Today - PrintMenuUpdate;
            int days = LastUpdated.Days;
            return days;
        }
    }
}

}



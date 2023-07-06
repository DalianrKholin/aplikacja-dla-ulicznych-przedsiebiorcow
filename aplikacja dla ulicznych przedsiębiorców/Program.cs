namespace aplikacja_dla_ulicznych_przedsiębiorców
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
            /* inicjacja nowej bazy danych
            myDataContexUsers connect;
            MessageBox.Show("2");
            connect = new myDataContexUsers(@"server=DESKTOP-AI71G3Q;database=userData;integrated security=true;multipleactiveresultsets=true");
            MessageBox.Show("2");
            connect.persons.Add(new Bissnesman
            {
                name = "dalinarKholin",
                pass = "2309acb4a88359a4ba3c164006ca607da331dec15468f9f2645bb21436b44d90",
                adminPass = true,
                messageCounter = 0
            });
            MessageBox.Show("2");
            connect.SaveChanges();
            MessageBox.Show("2");
            var persona = connect.persons.Single(e => e.name == "dalinarKholin");
            int personId = persona.ID;
            connect.messages.Add(new Message
            {
                item = "fajnie co nie? ",
                date = DateTime.Now,
                sender = persona,
                recipient = persona
            });
            connect.places.Add(new Place
            {
                name = "nwm",
                street = "lozl",
                number = 1,
                tribiute = 1,
                protectors = new List<Bissnesman>() { persona }
            });
            MessageBox.Show("1");
            connect.SaveChanges();
            MessageBox.Show("2");
            try
            {
                foreach (var item in connect.places.First(e => e.name == "nwm").protectors)
                {
                    MessageBox.Show(item.ToString());
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return;
            */
            Application.Run(new mainApp());
        }
    }
}
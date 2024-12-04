namespace roadmap_dotnet.SOLID.SingleResponsability
{
    internal class classWihoutSRP
    {
        public classWihoutSRP()
        {
            sendEmail();
            createFile();
            manageLogOfApplication();
            deleteRecordsDataBase();
        }

        public void sendEmail()
        {
            Console.WriteLine("Send Email");
        }

        public void createFile()
        {
            Console.WriteLine("Create File");
        }

        public void manageLogOfApplication()
        {
            Console.WriteLine("Manage Log");
        }

        public void deleteRecordsDataBase()
        {
            Console.WriteLine("Delete records");
        }
    }
}

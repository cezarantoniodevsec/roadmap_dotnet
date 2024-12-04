namespace roadmap_dotnet.SOLID.SingleResponsability
{
    internal class ClassWithSRP
    {
        public ClassWithSRP()
        {
            var email = new EmailSRP();
            var file = new FileSRP();
            var database = new DatabaseSRP();
            var log = new LogSRP();

            email.SendEmail();
            file.createFile();
            database.deleteRecords();
            log.createLog();
        }
    }
}

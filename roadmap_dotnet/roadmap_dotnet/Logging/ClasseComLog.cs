using Serilog;

namespace roadmap_dotnet.Logging
{
    public class ClasseComLog : ClasseTeste
    {

        public override void facaAlgumaCoisa()
        {
            base.facaAlgumaCoisa();

            Log.Information("Foi realizado alguma coisa na classe com log");
        }
    }
}

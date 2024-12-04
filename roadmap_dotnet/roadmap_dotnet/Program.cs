using roadmap_dotnet.DesignPatterns.Observer.Implementacoes;
using roadmap_dotnet.Logging;
using Serilog;

static void TestaObserver()
{
    var assunto = new Publicacao();
    var assinanteA = new AssinanteConcretoA();
    assunto.adicionaAssinatura(assinanteA);

    var observerB = new AssinanteConcretoB();
    assunto.adicionaAssinatura(observerB);

    var estado = assunto.Status;

    assunto.geraNotificacao();
    assunto.geraNotificacao();

    assunto.removeDaAssintura(observerB);

    assunto.geraNotificacao();
    Console.ReadKey();
}

static void TesteComLog()
{
    Log.Logger = new LoggerConfiguration()
        .WriteTo.File($"{Environment.CurrentDirectory}/log.txt", rollingInterval: RollingInterval.Day)
        .CreateLogger();

    var classeComLog = new ClasseComLog();
    classeComLog.facaAlgumaCoisa();

    Console.ReadKey();
}
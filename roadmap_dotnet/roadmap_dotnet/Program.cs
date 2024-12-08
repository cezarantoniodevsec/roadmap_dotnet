using roadmap_dotnet.DesignPatterns.FactoryMethod;
using roadmap_dotnet.DesignPatterns.Observer.Implementacoes;
using roadmap_dotnet.DesignPatterns.SingleTon;
using roadmap_dotnet.Logging;
using Serilog;


TestaFactoryMethod();

static void TestaSingleTon()
{
    Singleton s1 = Singleton.GetInstance();
    Singleton s2 = Singleton.GetInstance();

    if (s1 == s2)
    {
        Console.WriteLine("Teste de SingleTon realizado com sucesso. As duas instâncias são iguais.");
    }
    else
    {
        Console.WriteLine("Singleton falhou. Os objetos contém estancias diferentes");
    }
}

static void TestaFactoryMethod()
{
    new Client().Main();
}

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
﻿using roadmap_dotnet.DesignPatterns.Implementacoes;

Console.WriteLine("Hello, World!");

TestaObserver();

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

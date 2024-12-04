namespace roadmap_dotnet.Mocking
{
    public interface IServicoConsultaCredito
    {
        IList<Pendencia>? ConsultarPendenciasPorCPF(string cpf);
    }
}

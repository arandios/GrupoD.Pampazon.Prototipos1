internal class ClientesRemito
{
    public int IdCliente { get; set; }
    public string RazonSocial { get; set; }
    public string CUIT { get; set; }

    public ClientesRemito(int idCliente, string razonSocial, string cuit)
    {
        IdCliente = idCliente;
        RazonSocial = razonSocial;
        CUIT = cuit;
    }
}
public abstract class Vehiculo
{
    protected string codigoInterno, matricula, estado;
    protected int capacidadCarga;
    protected double kilometraje, costoBase;

    protected Vehiculo(string codigoInterno, string matricula, int capacidadCarga, double kilometraje, double costoBase, string estado)
    {
        this.codigoInterno = codigoInterno;
        this.matricula = matricula;
        this.capacidadCarga = capacidadCarga;
        this.kilometraje = kilometraje;
        this.costoBase = costoBase;
        this.estado = estado;
    }

    public string CodigoInterno { get { return codigoInterno; } }
    public string Matricula { get { return matricula; } }
    public int CapacidadCarga { get { return capacidadCarga; } }
    public double CostoBase { get { return costoBase; } }
    public double Kilometraje { get { return kilometraje; } set { kilometraje = value; } }
    public string Estado { get { return estado; } set { estado = value; } }

    public abstract double CalcularCostoOperativo(double distancia, double cargaTransportada);
}
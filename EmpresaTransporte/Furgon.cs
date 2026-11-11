public class Furgon : Vehiculo
{
    public Furgon(string codigoInterno, string matricula, int capacidadCarga, double kilometraje, string estado)
        : base(codigoInterno, matricula, capacidadCarga, kilometraje, 10000, estado) { }

    public override double CalcularCostoOperativo(double distancia, double cargaTransportada)
    {
        return costoBase * cargaTransportada / capacidadCarga;
    }
}
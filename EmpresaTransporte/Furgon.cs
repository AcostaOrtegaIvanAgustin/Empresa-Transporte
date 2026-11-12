public class Furgon : Vehiculo
{
    public Furgon(string codigoInterno, string matricula, int capacidadCarga, double kilometraje, double costoBase, string estado)
        : base(codigoInterno, matricula, capacidadCarga, kilometraje, costoBase, estado) { }

    public override double CalcularCostoOperativo(double distancia, double cargaTransportada)
    {
        return costoBase * cargaTransportada / capacidadCarga;
    }
}
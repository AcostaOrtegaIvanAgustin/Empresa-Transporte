public class MotoReparto : Vehiculo
{
    public MotoReparto(string codigoInterno, string matricula, int capacidadCarga, double kilometraje, string estado)
        : base(codigoInterno, matricula, capacidadCarga, kilometraje, 5000, estado) { }

    // el enunciado no da la fórmula; cada 100 km suman un 100% del costo base
    public override double CalcularCostoOperativo(double distancia, double cargaTransportada)
    {
        return costoBase * (1 + distancia / 100) * cargaTransportada / capacidadCarga;
    }
}
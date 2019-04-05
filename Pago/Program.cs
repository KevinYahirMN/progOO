using System;
using System.Globalization;

namespace pagos
{
interface IAutorizable
{
string autoriza(string PIN, string cuenta);

}

class Pago  

{
    public enum Moneda {MXN, USD}
    public enum Tipo {Efectivo, TC}
    protected String numTransaccion;
    protected Double monto;
    protected Double tipoDeCambio;
    protected Moneda tipoMoneda;
    protected Tipo tipoPago;

    public Pago(string numTransaccion, double monto):this(numTransaccion,
    monto,1.0d,Pago.Moneda.MXN, Pago.Tipo.Efectivo ){}
    public Pago( string numTransaccion, Double monto,
    double tipoDeCambio, Moneda tipoMoneda, Tipo tipoPago)
    {
        this.numTransaccion= numTransaccion;
        this.monto = monto;
        this.tipoDeCambio = tipoDeCambio;
        this.tipoMoneda = tipoMoneda;
        this.tipoPago = tipoPago;
    }

    public override string ToString()
    {
        return String.Format("{0} {1} tipo:{2}",monto.ToString("C", CultureInfo.CurrentCulture),
        tipoMoneda, tipoPago);
    }
}

class Efectivo: Pago
{
    private Double Cantidad;

    private Double Cambio;

    public Efectivo(string numTransaccion, double monto, double cantidad, double cambio)
    :this(cantidad, cambio, numTransaccion,monto, 1.0d, Pago.Moneda.MXN,Pago.Tipo.Efectivo){}
    public Efectivo(double cantidad, double cambio, string numTransaccion, double monto,
    double tipoDeCambio, Moneda tipoMoneda,Tipo tipoPago):base(numTransaccion,monto,
    tipoDeCambio,tipoMoneda,tipoPago)
    {
        Cantidad = cantidad;
        Cambio = cambio;
    }
    public override string ToString()
    {
        return String.Format("{0} {1} tipo: {2}, Cantidad entregada {3}, Cantidad de cambio {4}",
        monto.ToString("C", CultureInfo.CurrentCulture),
        tipoMoneda, tipoPago, Cantidad, Cambio);
    }
}

class Credito: Pago
{

}
class Program
{
    static void Main(string[] args)
    {
        Efectivo p = new Efectivo("002",1000.00d,1000.00d,0.00d);
        Efectivo p3 = new Efectivo("003",500.00d, 600.00d,100.00);

        Console.WriteLine(p);
        Console.WriteLine(p3);

    }
}
}

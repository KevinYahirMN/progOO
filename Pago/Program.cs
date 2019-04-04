using System;
using System.Globalization;

namespace pago
{
interface IAutorizable{
string autoriza(string PIN, string cuenta);
}

class Pago{
public enum Moneda {MXN, USD}
public enum Tipo {Efectivo, TC}
private String numTransaccion;
private Double monto;
private Double tipoDeCambio;
private Moneda tipoMoneda;
private Tipo tipoPago;

public Pago(string numTransaccion, double monto):this(numTransaccion,
monto,1.0d,Pago.Moneda.MXN, Pago.Tipo.Efectivo ){
}
public Pago( string numTransaccion, Double monto,
double tipoDeCambio, Moneda tipoMoneda, Tipo tipoPago){
this.numTransaccion= numTransaccion;
this.monto = monto;
this.tipoDeCambio = tipoDeCambio;
this.tipoMoneda = tipoMoneda;
this.tipoPago = tipoPago;
}

public override string ToString(){
return String.Format("{0} {1} tipo:{2}",
monto.ToString("C", CultureInfo.CurrentCulture),
tipoMoneda, tipoPago);
}
}
class Program
{
static void Main(string[] args)
{
Pago p = new Pago("001", -1234.56d);
Pago p3 = new Pago("003",23.00d, 18.40d,Pago.Moneda.USD,Pago.Tipo.Efectivo);

Console.WriteLine(p);
Console.WriteLine(p3);

}
}
}
//Prueba de la clase EmpleadoBaseMasComision3
using System;

public class PruebaEmpleadoMasComision3
{
    public static void Main( string [] args)
    {
        //crea instancia de un objeto EmpleadoBaseMasComision3
        EmpleadoBaseMasComision3 empleadoBaseMasComision3 =
            new EmpleadoBaseMasComision3("Bob", "Lewis",
            "333-33-3333", 5000.00M, .04M, 300.00M);
        //Muestra en pantalla los datos del empleado por comision con salario base
        Console.WriteLine("Informacion del empleado obtenida por las propiedades y los metodos: \n");
        Console.WriteLine("{0} {1}", "El primer nombre es",
            empleadoBaseMasComision3.PrimerNombre);
        Console.WriteLine("{0} {1}", "El apellido es",
            empleadoBaseMasComision3.ApellidoPaterno);
        Console.WriteLine("{0} {1}", "El numero de seguro social es",
            empleadoBaseMasComision3.NumeroSeguroSocial);
        Console.WriteLine("{0} {1:C}", "Las ventas brutas son",
            empleadoBaseMasComision3.VentasBrutas);
        Console.WriteLine("{0} {1:F2}", "La tarifa de comision es",
            empleadoBaseMasComision3.TarifaComision);
        Console.WriteLine("{0} {1:C}", "Los ingresos son",
            empleadoBaseMasComision3.Ingresos());
        Console.WriteLine("{0} {1:C}", "El salario base es",
            empleadoBaseMasComision3.SalarioBase);

        empleadoBaseMasComision3.SalarioBase = 1000.00M; //establece el salario base

        Console.WriteLine("\n{0}:\n\n{1}",
            "Informacion actualizada del empleado, obtenida por ToString",
            empleadoBaseMasComision3);
        Console.WriteLine("ingresos: {0:C}", empleadoBaseMasComision3.Ingresos());
        Console.ReadKey();
    }//Fin del main    
}// fin de la clase PruebaEmpleadoBaseMasComision3


//EmpleadoPorComision2 con variables de instancia protected
public class EmpleadoPorComision2
{
    protected string primerNombre;
    protected string apellidoPaterno;
    protected string numeroSeguroSocial;
    protected decimal ventaBrutas; //ventas semanales totales
    protected decimal tarifaComision; //porcentaje de comision

    //Constructor con cinco parametros
    public EmpleadoPorComision2( string nombre, string apellido, string nss, decimal ventas, decimal tarifa)
    {
        // la llamada implicita al constructor del objeto se realiza aqui
        primerNombre = nombre;
        apellidoPaterno = apellido;
        numeroSeguroSocial = nss;
        ventaBrutas = ventas; //Valida las ventas brutas a travez de una propiedad
        tarifaComision = tarifa; // valida la tarifa de comision a travez de una propiedad
    }//fin del constructor de EmpleadoPorComision2 con cinco parametros
    
    //propiedad de solo lectura que obtiene el primer nombre del empleado por comision
    public string PrimerNombre
    {
        get
        {
            return primerNombre;
        }//fin de get
    }//fin de la propiedad PrimerNombre

    //propiedad de solo lectura que obtiene el apellido paterno del empleado por comision
    public string ApellidoPaterno
    {
        get
        {
            return apellidoPaterno;
        }//fin de get
    }//fin de la propiedad ApellidoPaterno

    //propiedad de solo lectura
    //el numero de seguro social del empleado por comision
    public string NumeroSeguroSocial
    {
        get
        {
            return numeroSeguroSocial;
        }//fin de get
    }//fin de la propiedad NumeroSeguroSocial

    //Propiedad que obtiene y establece las ventas brutas del empleado por comision
    public decimal VentasBrutas
    {
        get
        {
            return ventaBrutas;
        }//fin de get
        set
        {
            VentasBrutas = (value < 0) ? 0 : value;
        }//fin de set
    }//fin de la propiedad VentasBrutas

    //propiedad que obtiene y establece la tarifa de comision del empleado por comision
    public decimal TarifaComision
    {
        get
        {
            return tarifaComision;
        }//fin de get
        set
        {
            tarifaComision = (value > 0 && value < 1) ? value : 0;
        }//fin de set
    }//fin de la propiedad TarifaComision

    //calcula el sueldo del empleado por comision
    public virtual decimal Ingresos()
    {
        return tarifaComision * ventaBrutas;
    }//fin del metodo Ingresos

    //devuelve representacion string del objeto EmpleadoPorComision
    public override string ToString()
    {
        return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
        "empleado por comisión", primerNombre, apellidoPaterno,
        "número de seguro social", numeroSeguroSocial,
        "ventas brutas", ventaBrutas, "tarifa de comisión", tarifaComision);
    }//fin del metodo ToString
}//Fin de la clase EmpleadoPorComision2

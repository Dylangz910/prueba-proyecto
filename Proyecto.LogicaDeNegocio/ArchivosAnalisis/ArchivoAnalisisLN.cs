using System.Collections.Generic;

public class ArchivoAnalisisLN
{
    private readonly ArchivoAnalisisAD _accesoADatos;

    public ArchivoAnalisisLN(ArchivoAnalisisAD accesoADatos)
    {
        _accesoADatos = accesoADatos;
    }

    public List<ArchivoAnalisis> Details()
    {
        return _accesoADatos.Details();
    }

    public ArchivoAnalisis BuscarPorId(int id)
    {
        return _accesoADatos.BuscarPorId(id);
    }

    public void Create(ArchivoAnalisis archivo)
    {
        _accesoADatos.Create(archivo);
    }
}

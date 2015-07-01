using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.clases.excepcions;
using WcfService1.clases;

public class Edificio
{
    public Edificio()
    {
        cod_edif = 0;
        edif_nombre = "";
        edif_calle = "";
        edif_num = 0;
        edif_cp = "";
        edif_cantpisos = 0;
        edif_deptosxpiso = 0;
        edif_tienepb = false;
        edif_deptoletra = 'l';
        edif_country = "";
        edif_prov = "";
        edif_loc = "";
        estado = 0;
        Ldpto = new List<Dpto>();
        Lexp = new List<Expensa>();
    }
    public Edificio(int _cod_edif, string _edif_nombre, string _edif_calle, decimal _edif_num, string _edif_cp, int _edif_cantpisos, int _edif_deptosxpiso, bool _edif_tienepb, char _edif_deptoletra, string _edif_country, string _edif_prov, string _edif_loc, decimal _estado, List<Dpto> _Ldpto, List<Expensa> _Lexp)
    {
        cod_edif = _cod_edif;
        edif_nombre = _edif_nombre;
        edif_calle = _edif_calle;
        edif_num = _edif_num;
        edif_cp = _edif_cp;
        edif_cantpisos = _edif_cantpisos;
        edif_deptosxpiso = _edif_deptosxpiso;
        edif_tienepb = _edif_tienepb;
        edif_deptoletra = _edif_deptoletra;
        edif_country = _edif_country;
        edif_prov = _edif_prov;
        edif_loc = _edif_loc;
        estado = _estado;
        Ldpto = _Ldpto;
        Lexp = _Lexp;
    }
    public Edificio(int _cod_edif)
    {
        cod_edif = _cod_edif;   
    }
    public List<Habitante> FillHabitList(){

        ContEdif = new ControllerEdificio(cod_edif);

        return ContEdif.getListHabit();    
    }

    public ControllerEdificio ContEdif { get; set; }
    public int cod_edif { get; set; }
    public string edif_nombre { get; set; }
    public string edif_calle { get; set; }
    public decimal edif_num { get; set; }
    public string edif_cp { get; set; }
    public int edif_cantpisos { get; set; }
    public int edif_deptosxpiso { get; set; }
    public bool edif_tienepb { get; set; }
    public char edif_deptoletra { get; set; }
    public string edif_country { get; set; }
    public string edif_prov { get; set; }
    public string edif_loc { get; set; }
    public decimal estado { get; set; }
    public List<Dpto> Ldpto { get; set; }
    public List<Habitante> Lhabit { get; set; }
    public List<Expensa> Lexp { get; set; }


    public void ValidarDatos()
    {

    }
}
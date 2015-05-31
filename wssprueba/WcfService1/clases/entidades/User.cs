using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.clases.excepcions;



public class User
{
        public User(){
            Id=0;
            Nombre="";
            Apellido="";
            Account="";
            Password="";
            Tel = "";
            FechaNacimiento = "";
            Sexo = ' ';
            Estado = 0;
        }
        public User(int _id,string _nombre,string _apellido)
        {
            Id = _id;
            Nombre = _nombre;
            Apellido = _apellido;
            Account = "";
            Password = "";
            Tel = "";
            FechaNacimiento = "";
            Sexo = ' ';
            Estado = 0;
        }


 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Account { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public string FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public int Estado{get;set;}


        public void ValidarDatos()
        {
            if (Nombre.Trim() == "" ||
                Apellido.Trim() == "" ||
                Account.Trim() == "" ||
                Password.Trim() == "" ||
                Sexo == ' ')
            {
                throw new DatosFaltantesEx();
            }

 /*           if (!Util.EsEmail(Email))
            {
                throw new EmailExcepcion();
            }

            if (FechaNacimiento > DateTime.Today)
            {
                throw new FechaNacimientoExcepcion();
            }*/
        }
    }


//[System.Runtime.Serialization.DataContractAttribute()]
//public partial class Person
//{

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public int id;

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public string name;

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public string app;

//}
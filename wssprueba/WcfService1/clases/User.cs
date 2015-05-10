﻿using System;
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
            FechaNacimiento = DateTime.MinValue;
            Sexo = ' ';
            FechaRegistracion = DateTime.MinValue;
            FechaActualizacion = DateTime.MinValue;
            Estado = 0;
        }
 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Account { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaRegistracion { get; set; }
        public Nullable<DateTime> FechaActualizacion { get; set; }
        public int Estado{get;set;}


        public void ValidarDatos()
        {
            if (Nombre.Trim() == "" ||
                Apellido.Trim() == "" ||
                Account.Trim() == "" ||
                Password.Trim() == "" ||
                FechaNacimiento == DateTime.MinValue ||
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
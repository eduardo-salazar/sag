using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sistema_De_Administracion_De_Servicios;

namespace Sistema_De_Administracion_De_Servicios
{
    public class Usuario
    {
        private int cod_usua;
        private string nombre;
        private string email;
        private string telefono;
        private Boolean admin;
        private string user;
        private Boolean active;
        private byte[] picture;

        public Usuario(int cod_usua, string nombre, Boolean active) {
            this.Cod_Usua = cod_usua;
            this.Nombre = nombre;
            this.Active = active;
        }

        public int Cod_Usua {
            get {return cod_usua;}
            set {cod_usua = value;}
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public string Telefono {
            get { return telefono; }
            set { telefono = value; }
        }

        public Boolean Admin {
            get { return admin; }
            set { admin = value; }
        }

        public string User {
            get { return user; }
            set { user = value; }
        }

        public Boolean Active {
            get { return active; }
            set { active = value; }
        }

        public byte[] Picture {
            get { return picture; }
            set { picture = value; }
        }

        public override string ToString()
        {
            string s = "";
            s += this.Cod_Usua + " " +
                this.Nombre + " " +
                this.Email + " " +
                this.Telefono + " " +
                this.Admin + " " +
                this.User + " " +
                this.Active + " ";
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Examen1Parcial
{
    class Empleado : INotyficProperty
    {
        private string nombre;
        private string identidad;
        private string hrsTrabajadas;
        private string pagoHrsTrabajadas;
        private string hrsExtras;
        private string pagoHrsExtras;
        private string sueldoSinDeducciones;
        private string deducciones;
        private string sueldototal;


        public string Nombre
        {
            get { return nombre;}
            set { nombre = value; }
            
        }
        public string Identidad
        {
            get { return identidad; }
            set { identidad = value; }

        }

        public string HrsTrabajads
        {
            get { return hrsTrabajadas; }
            set
            {
                decimal pago;
                bool horas = decimal.TryParse(value, out pago);
                if (horas) hrsTrabajadas = value;
                OnPropertyChanged("HrsTrabajadas");
                OnPropertyChanged("Sueldo");
            }
        }

        public string PagoHrsTrabajadas
        {
            get { return pagoHrsExtras; }
            set { decimal pago;
                bool horas = decimal.TryParse(value, out pago);
                if (horas) pagoHrsTrabajadas = value;
                OnPropertyChanged("PagoHrsTrabajadas");
                OnPropertyChanged("Sueldo");
            }
        }

        public String HrsExtras
        {
            get { return hrsExtras; }
            set {
                decimal pago;
                bool horas = decimal.TryParse(value, out pago);
                if (horas) hrsExtras = value;
                OnPropertyChanged("HrsExtras");
                OnPropertyChanged("Sueldo");
            }
        }

        public String PagoHrsExtras
        {
            get { return pagoHrsExtras; }
            set {
                decimal pago;
                bool horas = decimal.TryParse(value, out pago);
                if (horas) pagoHrsExtras = value;
                OnPropertyChanged("PagoHrsExtras");
                OnPropertyChanged("Sueldo");

            }
        }

        public String SueldoSinDeducciones
        {
            get { decimal suma;
                suma = Decimal.Parse(hrsTrabajadas) * decimal.(pagoHrsTrabajadas);
                
                return suma.ToString();
            }
            set
            {
                
                
            }
        }

        public String Deducciones
        {
            get { return deducciones; }
            set
            {
                decimal pago;
                bool horas = decimal.TryParse(value, out pago);
                if (horas) pagoHrsExtras = value;
                OnPropertyChanged("Deducciones");
                OnPropertyChanged("Sueldo");

            }
        }

        public String SueldoTotal
        {
            get { return sueldototal; }
            set
            {
                decimal pago;
                bool horas = decimal.TryParse(value, out pago);
                if (horas) sueldototal = value;
                OnPropertyChanged("SueldoTotal");
                OnPropertyChanged("Sueldo");

            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }


    
}

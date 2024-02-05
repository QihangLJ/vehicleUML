using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Motorbike : Vehicle
    {
        private int cubicCentimeters;
        private bool sidecar;
        public Motorbike(string brand,
            string model,
            string licensplate,
            float kms,
            int wheels,
            int year,
            int cubicCentimeters) : base(brand,
            model,
            licensplate,
            kms,
            wheels,
            year)
        {
            this.CubicCentimeters = cubicCentimeters;
            this.Sidecar = isSidecar();
        }
        public int CubicCentimeters
        {
            get => this.cubicCentimeters;
            set => this.cubicCentimeters = value;
        }
        public bool Sidecar
        {
            get => this.sidecar;
            set => this.sidecar = value;
        }
        public bool isSidecar()
        {
            const int AmountWheelsForSideCar = 3;
            return this.Wheels==AmountWheelsForSideCar;
        }
    }
}

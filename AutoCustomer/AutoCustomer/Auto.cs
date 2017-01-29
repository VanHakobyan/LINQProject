using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCustomer
{
    struct Auto
    {
        readonly string car;
        readonly string model;
        readonly string color;
        readonly int year;
        readonly float motor;
        readonly bool isAutomaticTransmission;

        public Auto(string car, string model, string color, int year, float motor, bool isAutomaticTransmission)
        {
            this.car = car;
            this.model = model;
            this.color = color;
            this.year = year;
            this.motor = motor;
            this.isAutomaticTransmission = isAutomaticTransmission;
        }

        public string Color { get { return color; } }
        public string Car { get { return car; } }
        public string Model { get { return model; } }
        public int Year { get { return year; } }
        public float Motor { get { return motor; } }
        public bool IsAutomaticTransmission { get { return isAutomaticTransmission; } }


        public override string ToString()
        {
            return $"Car: {Car} Model: {model} Color: {color} Year: {year} Motor: {motor} AutomaticTransmission: {isAutomaticTransmission}";
        }
    }
}

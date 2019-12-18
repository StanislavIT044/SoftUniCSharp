using System;
using System.Collections.Generic;
using System.Text;

namespace Problem6SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        public double FuelConsumptionPerKm
        {
            get { return fuelConsumptionPerKm; }
            set { fuelConsumptionPerKm = value; }
        }
        public double TraveledDistance
        {
            get { return traveledDistance; }
            set { traveledDistance = value; }
        }

        public void Drive(double distanceToDrive)
        {
            if (distanceToDrive * fuelConsumptionPerKm <= fuelAmount)
            {
                FuelAmount -= distanceToDrive * fuelConsumptionPerKm;
                TraveledDistance += distanceToDrive;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        //public bool Drive(double distanceToDrive)
        //{
        //    if (distanceToDrive * fuelConsumptionPerKm <= fuelAmount)
        //    {
        //        FuelAmount -= distanceToDrive * fuelConsumptionPerKm;
        //        TraveledDistance += distanceToDrive;
        //        return true;
        //    }
        //    return false;
        //}
    }
}

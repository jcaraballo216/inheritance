﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceProblems
{
    class Vehicle
    {
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        //Properties
        public int Seats { get; }
        public int CarryingCapacity { get; }
        public string Color { get; set; }
        public double DistanceTraveled { get; set; }

        //Constructors
        public Vehicle()
        {

        }
        public Vehicle(int seats,int carryingCapacity,string color,double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this. movementSpeed = movementSpeed;

            distanceTraveled = 0.0d;
        }
        //Methods
        public virtual void Move()
        {
            distanceTraveled += movementSpeed;
        }
        public virtual string GetDistanceTraveled()
        {
            return "Distance Travled: " + distanceTraveled + "\n";
        }
    }
}

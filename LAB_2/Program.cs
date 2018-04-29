using System;

namespace LAB_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            Bus bus = new Bus();
            bus.tankUp(new Gasoline());
            bus.tankUp(new Electricity());
            bus.chargePassenger(passenger);
            bus.chargePassenger(passenger, true);
            PublicTransportStop busStop = new PublicTransportStop();
            busStop.isStopAllowed(bus);
            busStop.isStopAllowed(new Taxi());

        }

    }

    class Passenger
    {
        int funds = 100;
        public void charge(int amount)
        {
            this.funds = this.funds - amount;
        }
        
    }

    class Gasoline
    {
        
    }

    class Electricity
    {
        
    }

    class Vehicle
    {
        
    }

    class PublicTransport:Vehicle
    {
        
    }

    class Bus:PublicTransport
    {

        public Boolean isCharged = false;
        int weekDayFare = 5;
        int weekEndFare = 3;

        public void tankUp(Gasoline gas)
        {
            this.isCharged = true;

        }
        public void tankUp(Electricity changing)
        {
            this.isCharged = true;
            
        }

        public void chargePassenger(Passenger passenger)
        {
            passenger.charge(this.weekDayFare);
        }

        public void chargePassenger(Passenger passenger, Boolean isWeekend)
        {
            if(isWeekend) {
                passenger.charge(this.weekEndFare);
            } else {
                passenger.charge(this.weekDayFare);
            }
        }
        
    }
    class Taxi:Vehicle
    {
        
    }

    class PublicTransportStop
    {
        public Boolean isStopAllowed(Vehicle vehicle)
        {
            Boolean result = vehicle is Bus;
            Console.WriteLine("This vehicle is allowed to stop here: " + result);
            return result;
        }
        
    }
}



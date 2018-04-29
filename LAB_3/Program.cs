using System;

namespace LAB_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car defaultCar = new Car();
            Console.WriteLine("Default car capacity is: " + defaultCar.capacity.ToString());

            Car smallCar = new Car(2);
            Console.WriteLine("Small car capacity is: " + smallCar.capacity.ToString());

            Bus regularBus = new Bus(5);
            Bus cheapBus = new Bus(5, 0.5);
            Console.WriteLine("Default bus fare is " + regularBus.fare.ToString() + ", whereas cheap bus fare is " + cheapBus.fare.ToString());
        }

    }

    class Car
    {
        public int capacity;
        int defaultCapacity = 5;
        public Car()
        {
            this.capacity = this.defaultCapacity;
            
        }

        public Car(int capacity) {
            this.capacity = capacity;   
        }

        ~Car() {
            Console.WriteLine("Car destructor is running");
        }
        
    }

    class Bus
    {
        public int fare;

        public Bus(int fare) {
            this.fare = fare;
        }

        public Bus(int fare, double discount)
        {
            this.fare = (int)(fare * discount);

        }

        ~Bus() {
            Console.WriteLine("Bus destructor is running");
        }
        
    }
}


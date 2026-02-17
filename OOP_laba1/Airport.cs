using System;


namespace OOP_laba1
{
    internal class Airport
    {
        public static int ObjectsCount { get; private set; } = 0;

        public string Name { get; set; }

        public string Location { get; set; }

        public int FlightsPerDay { get; set; }

        public int TicketsSold { get; set; }

        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                    throw new AirportInvalidCastException("Значение не может быть отрицательным");
                _balance = value;
            }
        }

        public double Rating { get; set; }

        public int EmployeesCount { get; set; }

        public Airport()
        {
            Name = "";
            Location = "";
            FlightsPerDay = 0;
            TicketsSold = 0;
            Balance = 0;
            Rating = 0;
            EmployeesCount = 0;
            ObjectsCount++;
        }

        public Airport(string name) : this()
        {
            Name = name;
        }

        public Airport(string name, string location) : this(name)
        {
            Location = location;
        }

        public Airport(
            string name,
            string location,
            int flightsPerDay,
            int ticketsSold,
            decimal balance,
            double rating,
            int employeesCount
            ) : this(name, location)
        {
            FlightsPerDay = flightsPerDay;
            TicketsSold = ticketsSold;
            Balance = balance;
            Rating = rating;
            EmployeesCount = employeesCount;
        }

        public override string ToString()
        {
            return $"Airport: {Name},\n" +
                $" Location: {Location},\n" +
                $" Flights/Day: {FlightsPerDay},\n" +
                $" Tickets Sold: {TicketsSold},\n" +
                $" Balance: {Balance:C},\n" +
                $" International: {Rating},\n" +
                $" Employees: {EmployeesCount}";
        }
    }
}

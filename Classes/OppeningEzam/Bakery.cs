using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {


        private List<Employee> data;

        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => data.Count;
        public void Add(Employee employee)
        {
            if (Capacity > Count)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employee = data.FirstOrDefault(x => x.Name == name);
            return data.Remove(employee);
        }

        public Employee GetOldestEmployee()
        {
            Employee getOldestEmployee = data.OrderByDescending(x => x.Age).FirstOrDefault();
            return getOldestEmployee;
        }
        public Employee GetEmployee(string name)
        {
            Employee currentEmployee = data.FirstOrDefault(x => x.Name == name);
            return currentEmployee;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Employees working at Bakery {Name}:");

            foreach (var employee in data)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}

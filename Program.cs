using System;
using System.Collections.Generic;

namespace Net5FeaturesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            //              Employee Class
            // ==========================================
            var employeeClass = new EmployeeClass(id: 1);
            employeeClass.FirstName = "Jon";
            employeeClass.LastName = "Doe";
            Console.WriteLine();
            Console.WriteLine("======== Employee Class ========");
            Console.WriteLine($"Employee Id: {employeeClass.Id}");
            Console.WriteLine($"Employee First Name: {employeeClass.FirstName}");
            Console.WriteLine($"Employee Last Name: {employeeClass.LastName}");

            // ==========================================
            //              Employee using Init
            // ==========================================
            var employeeInit = new EmployeeInit
            {
                FirstName = "Jon",
                LastName = "Doe",
                Id = 2
            };
            Console.WriteLine();
            Console.WriteLine("======== Employee using Init ========");
            Console.WriteLine($"Employee Id: {employeeInit.Id}");
            Console.WriteLine($"Employee First Name: {employeeInit.FirstName}");
            Console.WriteLine($"Employee Last Name: {employeeInit.LastName}");

            // ==========================================
            //              Employee Record
            // ==========================================
            var employeeRecord1 = new EmployeeRecord(Id: 3, FirstName: "Jon", LastName: "Doe");
            Console.WriteLine();
            Console.WriteLine("======== Employee Record 1 ========");
            Console.WriteLine($"Employee Id: {employeeRecord1.Id}");
            Console.WriteLine($"Employee First Name: {employeeRecord1.FirstName}");
            Console.WriteLine($"Employee Last Name: {employeeRecord1.LastName}");

            var employeeRecord2 = employeeRecord1 with { Id = 4, FirstName = "Jane" };
            Console.WriteLine();
            Console.WriteLine("======== Employee Record 2 ========");
            Console.WriteLine($"Employee Id: {employeeRecord2.Id}");
            Console.WriteLine($"Employee First Name: {employeeRecord2.FirstName}");
            Console.WriteLine($"Employee Last Name: {employeeRecord2.LastName}");

            // ==========================================
            //             Compare Record Objects
            // ==========================================
            var employeeRecord3 = new EmployeeRecord(Id: 3, FirstName: "Jon", LastName: "Doe");
            bool areEqual = employeeRecord1 == employeeRecord3;
            Console.WriteLine($"Are Records equal? {areEqual}");
            Console.WriteLine($"Are Hash Code Records equal? {employeeRecord1.GetHashCode() == employeeRecord3.GetHashCode()}");

            // ==========================================
            //             Compare Class Objects
            // ==========================================
            var employeeClass2 = new EmployeeClass(id: 1);
            employeeClass.FirstName = "Jon";
            employeeClass.LastName = "Doe";
            Console.WriteLine($"Are Class objects equal? { employeeClass2 == employeeClass}");

            // ==========================================
            //  Retaional Operators and Pattern Matching
            // ==========================================
            // Target Typing Example - Omit the type in a new expression when the created object's type is already known
            RelationalOperators relationalOperators = new();
            Console.WriteLine();
            Console.WriteLine("======== Relational Operators ========");
            Console.WriteLine($"Is Valid Percentage? {relationalOperators.IsValidPercentage(40)}");
            Console.WriteLine($"Is Letter? {relationalOperators.IsLetter('c')}");
            Console.WriteLine($"Is Letter or Separator? {relationalOperators.IsLetterOrSeparator('A')}");
            Console.WriteLine($"Is Null? {relationalOperators.IsNull(null)}");
            Console.WriteLine($"Is Null2? {relationalOperators.IsNull2(null)}");

            // ==========================================
            //             Switch Case Example
            // ==========================================
            Console.WriteLine();
            Console.WriteLine("======== Switch Case Examples ========");
            Console.WriteLine($"Direction => {SwitchExamples.GetOrientation()}");
            var gasPrice = new GasPrice(1, 4);
            Console.WriteLine($"Gas price is {SwitchExamples.GetFuelCost(gasPrice)}");

            // ==========================================
            //             Target Typing
            // ==========================================
            Person person = new("Tony", "Stark");
            Console.WriteLine();
            Console.WriteLine("======== Target Typing ========");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine();

            var personList = new List<Person>
            {
                new ("Tony", "Stark"),
                new ("Howard", "Stark"),
                new ("Clint", "Barton"),
                new ("Captain", "America")
            };

            foreach(var personItem in personList)
            {
                Console.WriteLine($"{personItem.FirstName} {personItem.LastName}");
            }

            // ==========================================
            //   Target Typing with Conditional Operators
            // ==========================================
            Person p1 = null;
            Person p2 = null;
            Person p3 = new("Jon", "Doe");

            var somePerson = p1 ?? p2 ?? p3; // if p1 is null use p2, if p2 is null use p3, if neither is null use the first object in the sequence that's not null
            Console.WriteLine($"Who is {somePerson.FirstName} {somePerson.LastName}?");
        }
    }
}

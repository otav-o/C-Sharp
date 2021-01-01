using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // if you don't pass any value it will take the current tick of the clock as starter number - and that is awesome
            // only creates a Random object once and for everything else call Next() method. Exception: thread safe
            // if you use a seed number (in the constructor) the results will be known and you can recreate random number
            // if you need something that has to be absolutely random then use the cryptographic library


            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(random.Next(5, 11));
            //    // pass 11 to generate from 0 to 10
            //    // pass 5, 11 to generate from 5 to 10

            //    Console.WriteLine(random.NextDouble()*10);

            //    SimpleMethod(random);
            //}

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel {FirstName = "Tim"},
                new PersonModel {FirstName = "Sue"},
                new PersonModel {FirstName = "Mary"},
                new PersonModel {FirstName = "George"},
                new PersonModel {FirstName = "Jane"},
                new PersonModel {FirstName = "Nancy"},
                new PersonModel {FirstName = "Bob"}
            };

            // var sortedPeople = people.OrderBy(x => x.FirstName);
            var sortedPeople = people.OrderBy(x => random.Next()); // lambda
            // good for moderate-sized lists. Very close to totally random

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            // do not create a new Random object!
            Console.WriteLine(random.Next());


        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}


// RNGCryptoServiceProvider
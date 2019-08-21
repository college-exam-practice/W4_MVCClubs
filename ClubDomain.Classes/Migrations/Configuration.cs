namespace ClubDomain.Classes.Migrations
{
    using ClubDomain.Classes.ClubModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using System.Linq;
    using CsvHelper;
    using System.Diagnostics;

    internal sealed class Configuration : DbMigrationsConfiguration<Clubs.Model.ClubContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Clubs.Model.ClubContext context)
        {
            List<Course> courses = new List<Course>();
            // Get the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            // Assembly name and resource stored in assembly
            string resourceName = "Week4.Console.Courses.csv";
            // Get the embedded resource from the assembly
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {   // create a stream reader
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    // create a csv reader dor the stream
                    CsvReader csvReader = new CsvReader(reader);
                    csvReader.Configuration.HasHeaderRecord = false;
                    courses = csvReader.GetRecords<Course>().ToList();
                    context.Courses.AddOrUpdate(c => c.CourseCode);
                    //context.Courses.AddOrUpdate(c => c.YearOfStudy);
                    //context.Courses.AddOrUpdate(c => c.CouresTitle);
                    // Read the records into the desired collection of that type
                    // and iterate over the collection
                    foreach (var item in courses)
                    {
                        context.Courses.AddOrUpdate();
                    }
                    System.Console.ReadKey();
                }
            }

        }
    }
}

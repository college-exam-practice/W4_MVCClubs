namespace ClubDomain.Classes.Migrations
{
    using ClubDomain.Classes.ClubModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Globalization;

    internal sealed class Configuration : DbMigrationsConfiguration<Clubs.Model.ClubContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Clubs.Model.ClubContext context)
        {
            System.Globalization.CultureInfo cultureinfo = CultureInfo.CreateSpecificCulture("en-IE");

            //  This method will be called after migrating to the latest version.
            context.EventAttendees.AddOrUpdate(new EventAttendnace[]
            {
            new EventAttendnace
            {
                ID = 1, EventID = 2 , AttendeeMember = 3
            },
             new EventAttendnace
            {
                ID = 2, EventID = 2 , AttendeeMember = 3
            }, new EventAttendnace
            {
                ID = 3, EventID = 3 , AttendeeMember = 3
            }, new EventAttendnace
            {
                ID = 4, EventID = 3 , AttendeeMember = 4
            }, new EventAttendnace
            {
                ID = 5, EventID = 4 , AttendeeMember = 5
            }, new EventAttendnace
            {
                ID = 6, EventID = 4 , AttendeeMember = 6
            }, new EventAttendnace
            {
                ID = 7, EventID = 5 , AttendeeMember = 5
            }, new EventAttendnace
            {
                ID = 8, EventID = 5 , AttendeeMember = 6
            }, new EventAttendnace
            {
                ID = 9, EventID = 6 , AttendeeMember = 7
            }, new EventAttendnace
            {
                ID = 10, EventID = 6 , AttendeeMember = 8
            }
            , new EventAttendnace
            {
                ID = 11, EventID = 7, AttendeeMember = 7
            }
            , new EventAttendnace
            {
                ID = 12, EventID = 7 , AttendeeMember = 8
            },

           
                //                 new Club{ClubId = 2, ClubName = "The Volley Club", CreationDate = DateTime.ParseExact("01/01/2018", "dd/mm/yyyy", cultureinfo),adminID = 0,
                //    clubMembers = new List<Member> ()
                //    {
                //        new Member
                //        {
                //            MemberID = 1, StudentID = "S0003", approved = true, AssociatedClub = 2,
                //        },
                //        new Member
                //        {
                //            MemberID = 2, StudentID = "S0004", approved = true, AssociatedClub = 2
                //        }
                //    },

                //        clubEvents = new List<ClubEvent>()
                //        {
                //            new ClubEvent
                //            {
                //                EventID = 3, ClubId = 2, Location = "Sports Arena", Venue = "IT Sligo", StartDateTime = DateTime.ParseExact("15/02/2018 14:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo), EndDateTime = DateTime.ParseExact("15/02/2018 16:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo)
                //            },
                //            new ClubEvent
                //            {
                //                EventID = 4, ClubId = 2, Location = "Main Hall", Venue = "Regional Sport Centre", StartDateTime = DateTime.ParseExact("25/02/2018 16:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo), EndDateTime = DateTime.ParseExact("25/02/2018 19:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo)
                //            }
                //        }
                //},

                //new Club{ClubId = 1, ClubName = "The Chess Club", CreationDate = DateTime.ParseExact("25/01/2017", "dd/mm/yyyy", cultureinfo),adminID = 0,
                //    clubMembers = new List<Member> ()
                //    {
                //        new Member
                //        {
                //            MemberID = 1, StudentID = "S0001", approved = true, AssociatedClub = 1,
                //        },
                //        new Member
                //        {
                //            MemberID = 2, StudentID = "S0002", approved = true, AssociatedClub = 1
                //        }
                //    },

                //        clubEvents = new List<ClubEvent>()
                //        {
                //            new ClubEvent
                //            {
                //                EventID = 1, ClubId = 1, Location = "D1030", Venue = "IT Sligo", StartDateTime = DateTime.ParseExact("01/02/2017 17:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo), EndDateTime = DateTime.ParseExact("01/02/2017 21:00:00","dd/MM/yyyy H:mm:ss", cultureinfo)
                //            },
                //            new ClubEvent
                //            {
                //                EventID = 2, ClubId = 1, Location = "D1031", Venue = "IT Sligo", StartDateTime = DateTime.ParseExact("25/03/2017 13:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo), EndDateTime = DateTime.ParseExact("01/02/2017 14:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo)
                //            }
                //        }
                //},
                // new Club{ClubId = 2, ClubName = "The Volley Club", CreationDate = DateTime.ParseExact("01/01/2018", "dd/mm/yyyy", cultureinfo),adminID = 0,
                //    clubMembers = new List<Member> ()
                //    {
                //        new Member
                //        {
                //            MemberID = 1, StudentID = "S0003", approved = true, AssociatedClub = 2,
                //        },
                //        new Member
                //        {
                //            MemberID = 2, StudentID = "S0004", approved = true, AssociatedClub = 2
                //        }
                //    },

                //        clubEvents = new List<ClubEvent>()
                //        {
                //            new ClubEvent
                //            {
                //                EventID = 3, ClubId = 2, Location = "Sports Arena", Venue = "IT Sligo", StartDateTime = DateTime.ParseExact("15/02/2018 14:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo), EndDateTime = DateTime.ParseExact("15/02/2018 16:00:00", "dd/MM/yyyy H:mm;ss", cultureinfo)
                //            },
                //            new ClubEvent
                //            {
                //                EventID = 4, ClubId = 2, Location = "Main Hall", Venue = "Regional Sport Centre", StartDateTime = DateTime.ParseExact("25/02/2018 16:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo), EndDateTime = DateTime.ParseExact("25/02/2018 19:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo)
                //            }
                //        }
                //},
                //  new Club{ClubId = 3, ClubName = "Soccer Club", CreationDate = DateTime.ParseExact("07/01/2018", "dd/mm/yyyy", cultureinfo),adminID = 0,
                //    clubMembers = new List<Member> ()
                //    {
                //        new Member
                //        {
                //            MemberID = 1, StudentID = "S0005", approved = true, AssociatedClub = 3,
                //        },
                //        new Member
                //        {
                //            MemberID = 2, StudentID = "S0006", approved = true, AssociatedClub = 3
                //        }
                //    },

                //        clubEvents = new List<ClubEvent>()
                //        {
                //            new ClubEvent
                //            {
                //                EventID = 1, ClubId = 1, Location = "D1030", Venue = "IT Sligo", StartDateTime = DateTime.ParseExact("01/02/2017 17:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo), EndDateTime = DateTime.ParseExact("01/02/2017 21:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo)
                //            },
                //            new ClubEvent
                //            {
                //                EventID = 2, ClubId = 1, Location = "D1031", Venue = "IT Sligo", StartDateTime = DateTime.ParseExact("25/03/2017 13:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo), EndDateTime = DateTime.ParseExact("01/02/2017 14:00:00", "dd/MM/yyyy H:mm:ss", cultureinfo)
                //            }
                //        }
                //}
            });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

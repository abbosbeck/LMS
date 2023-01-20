﻿using LMS.DataAccess;
using LMS.DataAccess.Entity;
using LMS.DataAccess.Entity.ManyToManyReletionships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.API.Helpers
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                
                
                //InformationMessage
                if(!context.InformationMessages.Any())
                {
                    context.InformationMessages.AddRange(new List<InformationMessage>()
                    {
                        new InformationMessage()
                        {
                            Title = "Topshiriqlarning bajarish muddati uzaytirilganligi",
                            Message = "Hurmatli talabalar! 31.10.2022 va 01.11.2022 dagi deadlinelar mos ravishda 2 kunga ya'ni 02.11.2022 va 03.11.2022 larga uzaytirildi.",
                            PublishedDate = DateTime.Now
                        },
                        new InformationMessage()
                        {
                            Title = "Professor-teacher competition Time (2 course)",
                            Message = "Respected 2nd stage students! The process of selection of professors " +
                            "and teachers was conducted for Uzbek groups from 26.03.2022 till 21: 00, for Russian and " +
                            "English groups from 26.03.2022 from 21: 00 to 27.03.2022 from 10:00",
                            PublishedDate= DateTime.Now
                        },
                        new InformationMessage()
                        {
                            Title = "4-beginning of semester for courses",
                            Message = "Dear 4th year students! For you, the 8th semester will start on 03/24/2022.",
                            PublishedDate = DateTime.Now
                        },
                        new InformationMessage()
                        {
                            Title = "Professor-teacher competition Time (2 course)",
                            Message = "Respected 2nd stage students! The process of selection of professors " +
                            "and teachers was conducted for Uzbek groups from 26.03.2022 till 21: 00, for Russian and " +
                            "English groups from 26.03.2022 from 21: 00 to 27.03.2022 from 10:00",
                            PublishedDate= DateTime.Now
                        },
                        new InformationMessage()
                        {
                            Title = "Topshiriqlarning bajarish muddati uzaytirilganligi",
                            Message = "Hurmatli talabalar! 31.10.2022 va 01.11.2022 dagi deadlinelar mos ravishda 2 kunga ya'ni 02.11.2022 va 03.11.2022 larga uzaytirildi.",
                            PublishedDate = DateTime.Now
                        },

                    });
                    context.SaveChanges();
                }

                //Courses
                if(!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                            Name = "Discrete structures",
                            StartDate = new DateTime(2023, 12, 25),
                            EndDate = new DateTime(2024, 12, 25)
                        },
                        new Course()
                        {
                            Name = "Data structures and algorithms",
                            StartDate = new DateTime(2022, 09, 12),
                            EndDate = new DateTime(2023, 01, 10)
                        },
                        new Course()
                        {
                            Name = "Cybersecurity fundamentals",
                            StartDate = new DateTime(2022, 09, 12),
                            EndDate = new DateTime(2023, 01, 10)
                        }

                    });
                    context.SaveChanges();
                }

                //Topics
                if(!context.Topics.Any())
                {
                    context.Topics.AddRange(new List<Topic>() 
                    {
                        new Topic()
                        {
                            Name = "Kirish. Diskret tuzilmalar. To‘plamlar. To‘plam elementlari.",
                            CourseId = 1,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlarning berilishi. Qism to‘plamlar. To‘plamlarning turlari. To‘plamlar ustida amallarning xossalari.",
                            CourseId = 1,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 1,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 1,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "Kirish. Diskret tuzilmalar. To‘plamlar. To‘plam elementlari.",
                            CourseId = 2,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlarning berilishi. Qism to‘plamlar. To‘plamlarning turlari. To‘plamlar ustida amallarning xossalari.",
                            CourseId = 2,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 2,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 2,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "Kirish. Diskret tuzilmalar. To‘plamlar. To‘plam elementlari.",
                            CourseId = 3,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlarning berilishi. Qism to‘plamlar. To‘plamlarning turlari. To‘plamlar ustida amallarning xossalari.",
                            CourseId = 3,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 3,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 3,
                            Date = DateTime.Now,
                        }
                        
                    });
                    context.SaveChanges();
                }
                
                // Groups
                if(!context.Groups.Any())
                {
                    context.Groups.AddRange(new List<Group>()
                    {
                        new Group()
                        {
                            Name = Guid.NewGuid().ToString().Substring(0,5),
                        },
                        new Group()
                        {
                            Name = Guid.NewGuid().ToString().Substring(0,5)
                        },
                        new Group()
                        {
                            Name = Guid.NewGuid().ToString().Substring(0,5)                        }
                    });
                    context.SaveChanges();
                }


                //Groups & Courses
                if(!context.Groups_Courses.Any())
                {
                    context.Groups_Courses.AddRange(new List<Group_Course>()
                    {
                        new Group_Course()
                        {
                            GroupId = 1,
                            CourseId = 1,
                        },
                        new Group_Course()
                        {
                            GroupId = 1,
                            CourseId = 2,
                        },
                        new Group_Course()
                        {
                            GroupId = 2,
                            CourseId = 2,
                        },
                        new Group_Course()
                        {
                            GroupId = 2,
                            CourseId = 3,
                        },
                        new Group_Course()
                        {
                            GroupId = 3,
                            CourseId = 1,
                        },
                        new Group_Course()
                        {
                            GroupId = 3,
                            CourseId = 2,
                        },
                        new Group_Course()
                        {
                            GroupId = 3,
                            CourseId = 3,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
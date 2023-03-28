using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Drawing.Printing;
using TTGenerator.Data;
using TTGenerator.Models;
using TTGenerator.Models.Domain;
using System.Reflection.Emit;
using NuGet.Protocol;
using Microsoft.AspNetCore.Http;

namespace TTGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;
        public HomeController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Faculty_details()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Faculty_details(Faculty_details d)
        {

            Faculty_details dept = new Faculty_details
            {
                Sno=d.Sno,
                Staff_id=d.Staff_id, 
                Course_id=d.Course_id, 
                Staff_Name=d.Staff_Name,
                Total_classes=d.Total_classes
            };
            mvcDemoDbContext.Faculty_details.Add(dept);
            mvcDemoDbContext.SaveChanges();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index1(Index1 index)
        {
            Console.WriteLine("index.semester_id");
            Console.WriteLine(index.semester_id);
            Console.WriteLine(index.m10);
            Console.WriteLine(index.m1);
            //    var c =  mvcDemoDbContext.CollegeCoordinator.Count();


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i == 0) && (j == 0))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "monday",
                            elective_id = index.m1
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 1))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "monday",
                            elective_id = index.m2
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 2))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "monday",
                            elective_id = index.m3
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 3))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "monday",
                            elective_id = index.m4
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 4))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "monday",
                            elective_id = index.m5
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 5))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "monday",
                            elective_id = index.m6
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 6))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "monday",
                            elective_id = index.m7
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 7))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "monday",
                            elective_id = index.m8
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 8))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "monday",
                            elective_id = index.m9
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 9))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "monday",
                            elective_id = index.m10
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 0))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "tuesday",
                            elective_id = index.t1
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 1))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "tuesday",
                            elective_id = index.t2
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 2))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "tuesday",
                            elective_id = index.t3
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 3))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "tuesday",
                            elective_id = index.t4
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 4))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "tuesday",
                            elective_id = index.t5
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 5))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "tuesday",
                            elective_id = index.t6
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 6))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "tuesday",
                            elective_id = index.t7
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 7))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "tuesday",
                            elective_id = index.t8
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 8))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "tuesday",
                            elective_id = index.t9
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 9))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "tuesday",
                            elective_id = index.t10
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 0))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "wednesday",
                            elective_id = index.w1
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 1))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "wednesday",
                            elective_id = index.w2
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 2))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "wednesday",
                            elective_id = index.w3
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 3))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "wednesday",
                            elective_id = index.w4
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 4))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "wednesday",
                            elective_id = index.w5
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 5))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "wednesday",
                            elective_id = index.w6
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 6))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "wednesday",
                            elective_id = index.w7
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 7))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "wednesday",
                            elective_id = index.w8
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 8))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "wednesday",
                            elective_id = index.w9
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 9))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "wednesday",
                            elective_id = index.w10
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 0))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "thursday",
                            elective_id = index.th1
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 1))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "thursday",
                            elective_id = index.th2
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 2))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "thursday",
                            elective_id = index.th3
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 3))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "thursday",
                            elective_id = index.th4
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 4))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "thursday",
                            elective_id = index.th5
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 5))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "thursday",
                            elective_id = index.th6
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 6))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "thursday",
                            elective_id = index.th7
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 7))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "thursday",
                            elective_id = index.th8
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 8))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "thursday",
                            elective_id = index.th9
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 9))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "thursday",
                            elective_id = index.th10
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 0))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "friday",
                            elective_id = index.f1
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 1))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "friday",
                            elective_id = index.f2
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 2))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "friday",
                            elective_id = index.f3
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 3))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "friday",
                            elective_id = index.f4
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 4))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "friday",
                            elective_id = index.f5
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 5))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "friday",
                            elective_id = index.f6
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 6))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "friday",
                            elective_id = index.f7
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 7))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "friday",
                            elective_id = index.f8
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 8))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "friday",
                            elective_id = index.f9
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 9))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "friday",
                            elective_id = index.f10
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 0))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "saturday",
                            elective_id = index.s1
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 1))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "saturday",
                            elective_id = index.s2
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 2))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "saturday",
                            elective_id = index.s3
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 3))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "saturday",
                            elective_id = index.s4
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 4))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "saturday",
                            elective_id = index.s5
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 5))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "saturday",
                            elective_id = index.s6
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 6))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "saturday",
                            elective_id = index.s7
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 7))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "saturday",
                            elective_id = index.s8
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 8))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "saturday",
                            elective_id = index.s9
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 8))
                    {
                        int c = mvcDemoDbContext.CollegeCoordinator.Count();
                        Console.WriteLine(c);
                        CollegeCoordinator clg = new CollegeCoordinator
                        {
                            sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "saturday",
                            elective_id = index.s10
                        };
                        mvcDemoDbContext.CollegeCoordinator.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else
                    {
                        break;
                    }

                }
            }
            return View();

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login loginrequest)
        {

             Console.WriteLine("loginrequest.login_id");
             Console.WriteLine(loginrequest.login_id);
             string li = loginrequest.login_id.ToString();
             Console.WriteLine(loginrequest.login_id.GetType());
             Console.WriteLine(li.GetType());
            Login_credentials? login = await mvcDemoDbContext.Login_credentials.FindAsync(li);


            if (login != null)
            {
                
                if(login.password_l==loginrequest.password_l)
                {
                    Console.WriteLine(login);
                    Console.WriteLine(login.password_l);
                    return RedirectToAction("Index1");
                }
                if (loginrequest.password_l == "abc")
                {
                    Console.WriteLine(login);
                    Console.WriteLine(login.password_l);
                    return RedirectToAction("Faculty_details");
                }
            }
            return RedirectToAction("Error");

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
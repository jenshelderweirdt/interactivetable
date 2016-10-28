using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace InteractiveTableBootstrap.Api.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        public IEnumerable<Person> People
        {
            get
            {
                return new List<Person>()
                {
                    new Person() { Id = 1, FirstName = "ZJensZJensZJensZJensZJensZJensZJens", LastName = "HelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdtHelderweirdt" },
                    new Person() { Id = 2, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 3, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 4, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 5, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 6, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 7, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 8, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 9, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 10, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 11, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 12, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 13, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 14, FirstName = "Jens", LastName = "ZHelderweirdt" },
                    new Person() { Id = 15, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 16, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 17, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 18, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 19, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 20, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 21, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 22, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 23, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 2, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 3, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 4, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 5, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 6, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 7, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 8, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 9, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 10, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 11, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 12, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 13, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 14, FirstName = "Jens", LastName = "ZHelderweirdt" },
                    new Person() { Id = 15, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 16, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 17, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 18, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 19, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 20, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 21, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 22, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 23, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 2, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 3, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 4, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 5, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 6, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 7, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 8, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 9, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 10, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 11, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 12, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 13, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 14, FirstName = "Jens", LastName = "ZHelderweirdt" },
                    new Person() { Id = 15, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 16, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 17, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 18, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 19, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 20, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 21, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 22, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 23, FirstName = "Jens", LastName = "Helderweirdt" },
                                        new Person() { Id = 1, FirstName = "ZJens", LastName = "Helderweirdt" },
                    new Person() { Id = 2, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 3, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 4, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 5, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 6, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 7, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 8, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 9, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 10, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 11, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 12, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 13, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 14, FirstName = "Jens", LastName = "ZHelderweirdt" },
                    new Person() { Id = 15, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 16, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 17, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 18, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 19, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 20, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 21, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 22, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 23, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 2, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 3, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 4, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 5, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 6, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 7, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 8, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 9, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 10, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 11, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 12, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 13, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 14, FirstName = "Jens", LastName = "ZHelderweirdt" },
                    new Person() { Id = 15, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 16, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 17, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 18, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 19, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 20, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 21, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 22, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 23, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 2, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 3, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 4, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 5, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 6, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 7, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 8, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 9, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 10, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 11, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 12, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 13, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 14, FirstName = "Jens", LastName = "ZHelderweirdt" },
                    new Person() { Id = 15, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 16, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 17, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 18, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 19, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 20, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 21, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 22, FirstName = "Jens", LastName = "Helderweirdt" },
                    new Person() { Id = 23, FirstName = "Jens", LastName = "Helderweirdt" }
                };
            }
        }

        [HttpGet]
        public int Test()
        {
            return 1;
        }

        [HttpPost]
        public ActionResult GetPage([FromForm]DataTableParameters parameters)
        {

            IEnumerable<Person> filteredPeople = new List<Person>();
            filteredPeople = People;
            int filteredPeopleCount = 0;
            if (parameters.Search.Value != null)
            {
                filteredPeople = filteredPeople.Where(p => parameters.Search.Value.Split(' ').Any(v => p.FirstName.Contains(v) || p.LastName.Contains(v)));
                filteredPeopleCount = filteredPeople.Count();
            }
            else
            {
                filteredPeopleCount = People.Count();
            }
            if (parameters.Order[0].Dir == "asc")
            {
                switch (parameters.Order[0].Column)
                {
                    case 0:
                        filteredPeople = filteredPeople.OrderBy(p => p.Id).Skip((parameters.Start / parameters.Length) * parameters.Length).Take(parameters.Length);
                        break;
                    case 1:
                        filteredPeople = filteredPeople.OrderBy(p => p.FirstName).Skip((parameters.Start / parameters.Length) * parameters.Length).Take(parameters.Length);
                        break;
                    case 2:
                        filteredPeople = filteredPeople.OrderBy(p => p.LastName).Skip((parameters.Start / parameters.Length) * parameters.Length).Take(parameters.Length);
                        break;
                }
            }
            else
            {
                switch (parameters.Order[0].Column)
                {
                    case 0:
                        filteredPeople = filteredPeople.OrderByDescending(p => p.Id).Skip((parameters.Start / parameters.Length) * parameters.Length).Take(parameters.Length);
                        break;
                    case 1:
                        filteredPeople = filteredPeople.OrderByDescending(p => p.FirstName).Skip((parameters.Start / parameters.Length) * parameters.Length).Take(parameters.Length);
                        break;
                    case 2:
                        filteredPeople = filteredPeople.OrderByDescending(p => p.LastName).Skip((parameters.Start / parameters.Length) * parameters.Length).Take(parameters.Length);
                        break;
                }
            }
            return Json(new { draw = parameters.Draw, recordsFiltered = filteredPeopleCount, recordsTotal = People.Count(), data = filteredPeople });
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class DataTableParameters
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public Search Search { get; set; }
        public Order[] Order { get; set; }
        public Column[] Columns { get; set; }
        public string ExtraFilter { get; set; }
    }

    public class Order
    {
        public int Column { get; set; }
        public string Dir { get; set; }
    }

    public class Column
    {
        public string Data { get; set; }
        public string Name { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public Search Search { get; set; }
    }

    public class Search
    {
        public string Value { get; set; }
        public bool Regex { get; set; }
    }
}

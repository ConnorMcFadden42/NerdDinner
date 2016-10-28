using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DinnersController : Controller
    {
        DinnerRepository dinnerRepository = new DinnerRepository();
        //
        // GET: /Dinners/
        public ActionResult Index(int? page)
        {
            const int pageSize = 10;
            var upcomingDinners = dinnerRepository.FindUpcomingDinners();
            var paginatedDinners = new PaginatedList<Dinner>(upcomingDinners, page ?? 0, pageSize);
            return View(paginatedDinners);
        }


        //
        // GET: /Dinners/Details/2
        public ActionResult Details(int id)
        {
            Dinner dinner = dinnerRepository.GetDinner(id); {
                if (dinner == null)            
                    return View("NotFound");
                else
                    return View(dinner);
            }
        }

      
        public ActionResult Edit(int id) 
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            return View(dinner);
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection formValues)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            try
            {
                UpdateModel(dinner);
                dinnerRepository.Save();
                return RedirectToAction("Details", new { id = dinner.DinnerID });
            }
            catch
            {               
                return View(dinner);
            }
        }
        
        
        //
        //HTTP GET

        public ActionResult Delete(int id)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            return View(dinner);
        }          


        public ActionResult Create(int id)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            return View(dinner);
        }


        public class PaginatedList<T> : List<T>
        {
            public int PageIndex { get; private set; }
            public int PageSize { get; private set; }
            public int TotalCount { get; private set; }
            public int TotalPages { get; private set; }

            public PaginatedList(IQueryable<T> source, int pageIndex, int pageSize)
            {
                PageIndex = pageIndex;
                PageSize = pageSize;
                TotalCount = source.Count();

                TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);
                this.AddRange(source.Skip(PageIndex * PageSize).Take(PageSize));
            }

            public bool HasPreviousPage
            {
                get
                {
                    return (PageIndex > 0);
                }
            }

            public bool HasNextPage
            {
                get
                {
                    return (PageIndex + 1 < TotalPages);
                }
            }
        }


       




    }
}
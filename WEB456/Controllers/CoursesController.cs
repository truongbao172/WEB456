﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB456.Models;
using WEB456.ViewModels;

namespace WEB456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext(); 
        }
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
               Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
       }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);

            }
            var course = new Course
            {
              LecturerId = User.Identity.GetUserId(),
              DateTime = viewModel.GetDateTime(),
              CategoryId = viewModel.Category,
              Place = viewModel.Place
            };
            return RedirectToAction("Index", "Home");
        }

    }
}
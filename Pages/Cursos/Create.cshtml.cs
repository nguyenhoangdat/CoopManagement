﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoopManagement.Data;
using CoopManagement.Models;
using CoopManagement.Models.Cursos;
using Microsoft.AspNetCore.Authorization;
using CoopManagement.ViewsModels;

namespace CoopManagement.Pages.Cursos
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            //_context = context;
            CursoVM = new CursoViewModel();
        }

        [BindProperty]
        public CursoViewModel CursoVM { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Cursos.Add(Curso);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using ContosoUniversity.Models;
using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages
{
public class IndexModel : PageModel
{
    private readonly SchoolContext _context;
    private readonly MvcOptions _mvcOptions;

    public IndexModel(SchoolContext context, IOptions<MvcOptions> mvcOptions)
    {
        _context = context;
        _mvcOptions = mvcOptions.Value;
    }

    public IList<Student> Student { get;set; }

    public async Task OnGetAsync()
    {
        //Student = await _context.Students.ToListAsync();        
        Student = await _context.Students.Take(_mvcOptions.MaxModelBindingCollectionSize).ToListAsync();
    }
}
}

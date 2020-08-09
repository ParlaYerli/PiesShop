using DataAccess.Abstract;
using Entities;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _context;
        public PieRepository(AppDbContext _context)
        {
            this._context = _context;
        }
        public IEnumerable<Pie> AllPies()
        {
            //return _context.Pies.Include(c => c.Category).ToList();
            return _context.Pies.ToList();
        }

        public Pie GetPieById(int pieId)
        {
            return _context.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
        public Category GetCategory(int pieId)
        {
            return _context.Categories.Find(pieId);
        }
        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _context.Pies.Include(p => p.Category).Where(p => p.IsPieOfTheWeek);
            }
        }
    }
}


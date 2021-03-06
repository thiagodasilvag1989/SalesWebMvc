﻿using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMvc.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result.Include(x => x.Seller).Include(x => x.Seller.Department).OrderByDescending(x => x.Date).ToListAsync();
        }


        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result.Include(x => x.Seller).Include(x => x.Seller.Department).OrderByDescending(x => x.Date).GroupBy(x => x.Seller.Department).ToListAsync();
        }

        public List<double> FindByDateChart(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            var sellerCount = _context.Seller.Select(x => x.Id).Count();
            var salesRecord = new List<double>();

            int i = 1;
            do
            {

                salesRecord.Add(result.Where(x => x.Date >= minDate && x.Date <= maxDate && x.Seller.Id == i && x.Status.HasFlag(Models.Enums.SaleStatus.Faturado)).Sum(x => x.Amount));
                i++;
            } while (i <= sellerCount);


            return salesRecord;

        }

        public List<double> FindByDateGroupingChart(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            var departments = from obj in _context.Department select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            int cont = departments.Select(x => x.Id).Count();
            List<double> listDep = new List<double>();
            
            int i = 1;

            do
            {
                listDep.Add(result.Where(x => x.Date >= minDate && x.Date <= maxDate && x.Seller.DepartmentId == i && x.Status.HasFlag(Models.Enums.SaleStatus.Faturado)).Sum(x => x.Amount));
                i++;
            } while (i <= cont);

            return listDep.ToList();
        }

        public List<string> FindByName()
        {
            return _context.Seller.Select(s => s.Name).ToList();
        }

        public List<string> FindByDepartment()
        {
            return _context.Department.Select(s => s.Name).ToList();
        }
    }
}

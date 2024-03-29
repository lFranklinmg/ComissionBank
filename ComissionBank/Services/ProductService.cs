﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBank.Data;
using ComissionBank.Models;
using Microsoft.EntityFrameworkCore;

namespace ComissionBank.Services
{
    public class ProductService
    {
        private readonly ComissionBankContext _context;

        public ProductService(ComissionBankContext comissionBankContext)
        {
            _context = comissionBankContext;
        }

        public void Insert(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void Remove(Product product)
        {
            _context.Product.Remove(product);
            _context.SaveChanges();
        }

        public async Task<List<Product>> FindAll()
        {
            return await _context.Product.ToListAsync();
        }

        public Product FindById(int id)
        {
            return _context.Product.FirstOrDefault(x => x.Id == id);
        }

        public int GetIdByName(string name)
        {
            return _context.Product.Where(x => x.Name == name).Select(x => x.Id).FirstOrDefault();
        }
    }
}

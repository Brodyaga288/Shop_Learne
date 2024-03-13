using Shop_Learne.DAL.Interface;
using Shop_Learne.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Learne.DAL.Repository
{
    public class ProductRepository : IBaseRepository<Products>
    {
        private readonly ApplicationDBContext _date;

        public ProductRepository(ApplicationDBContext date)
        {
            _date = date;
        }
        public async Task<Products> Create(Products entity)
        {
            _date.product.Add(entity);
            await _date.SaveChangesAsync();
            return entity;
        }

        public async Task<Products> Delete(Products entity)
        {
            _date.Remove(entity);
            await _date.SaveChangesAsync();
            return entity;
        }

        public IQueryable<Products> GetAll()
        {
            return _date.product;
        }

        public async Task<Products> Update(Products entity)
        {
            var data = GetAll().Where(p => p.Id == entity.Id);

            Products editProduct = new Products();
            editProduct.Name = entity.Name;
            editProduct.Description = entity.Description;
            editProduct.Price = entity.Price;
            editProduct.Type = entity.Type;
            editProduct.CategoryId = entity.CategoryId;
            _date.Update(editProduct);
            await _date.SaveChangesAsync();
            return entity;
        }
    }
}

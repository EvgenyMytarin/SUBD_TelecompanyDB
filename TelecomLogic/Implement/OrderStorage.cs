using System;
using System.Collections.Generic;
using System.Linq;
using TelecomLogic.BindingModels;
using TelecomLogic.StorageInterfaces;
using TelecomLogic.ViewModels;
using TelecomDB.Models;

namespace TelecomDB.Implement
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using (var context = new TelecomDatabase2())
            {
                return context.Orders
                .Select(CreateModel)
                .ToList();
            }
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TelecomDatabase2())
            {
                return context.Orders
                .Where(rec => rec.Id == model.Id)
                .Select(CreateModel)
                .ToList();
            }
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TelecomDatabase2())
            {
                var order = context.Orders
                .FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ? CreateModel(order) : null;
            }
        }

        public void Insert(OrderBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                context.Orders.Add(CreateModel(model, new Order()));
                context.SaveChanges();
            }
        }

        public void Update(OrderBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element); 
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.name_service = model.name_service;
            order.name_client = model.name_client;
            order.name_tariff = model.name_tariff;
            order.date_conclusion = model.date_conclusion;
            return order;
        }

        private OrderViewModel CreateModel(Order model)
        {
            return new OrderViewModel
            {
                Id_order = model.Id,
                name_client = model.name_client,
                name_service = model.name_service,
                name_tariff = model.name_tariff,
                date_conclusion = model.date_conclusion,
            };
        }
    }
}
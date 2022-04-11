using System;
using System.Collections.Generic;
using System.Linq;
using TelecomLogic.BindingModels;
using TelecomLogic.StorageInterfaces;
using TelecomLogic.ViewModels;
using TelecomDB.Models;

namespace TelecomDB.Implement
{
    public class ServiceStorage : IServiceStorage
    {
        public List<ServiceViewModel> GetFullList()
        {
            using (var context = new TelecomDatabase2())
            {
                return context.Services
                .Select(CreateModel)
                .ToList();
            }
        }

        public List<ServiceViewModel> GetFilteredList(ServiceBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TelecomDatabase2())
            {
                return context.Services
                .Where(rec => rec.name_service.Contains(model.name_service))
                .Select(CreateModel)
                .ToList();
            }
        }

        public ServiceViewModel GetElement(ServiceBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TelecomDatabase2())
            {
                var service = context.Services
                .FirstOrDefault(rec => rec.name_service == model.name_service || rec.Id == model.Id);
                return service != null ? CreateModel(service) : null;
            }
        }

        public void Insert(ServiceBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                context.Services.Add(CreateModel(model, new Service()));
                context.SaveChanges();
            }
        }

        public void Update(ServiceBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                var element = context.Services.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ServiceBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                Service element = context.Services.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Services.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Service CreateModel(ServiceBindingModel model, Service service)
        {
            service.availability_overtariff = model.availability_overtariff;
            service.name_service = model.name_service;
            return service;
        }

        private ServiceViewModel CreateModel(Service model)
        {
            return new ServiceViewModel
            {
                Id_service = model.Id,
                name_service = model.name_service,
                availability_overtariff = model.availability_overtariff,
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using TelecomLogic.BindingModels;
using TelecomLogic.StorageInterfaces;
using TelecomLogic.ViewModels;
using TelecomDB.Models;

namespace TelecomDB.Implement
{
    public class TariffStorage : ITariffStorage
    {
        public List<TariffViewModel> GetFullList()
        {
            using (var context = new TelecomDatabase2())
            {
                return context.Tariffs
                .Select(CreateModel)
                .ToList();
            }
        }

        public List<TariffViewModel> GetFilteredList(TariffBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TelecomDatabase2())
            {
                return context.Tariffs
                .Where(rec => rec.name_tariff.Contains(model.name_tariff))
                .Select(CreateModel)
                .ToList();
            }
        }

        public TariffViewModel GetElement(TariffBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TelecomDatabase2())
            {
                var service = context.Tariffs
                .FirstOrDefault(rec => rec.name_tariff == model.name_tariff || rec.Id == model.Id);
                return service != null ? CreateModel(service) : null;
            }
        }

        public void Insert(TariffBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                context.Tariffs.Add(CreateModel(model, new Tariff()));
                context.SaveChanges();
            }
        }

        public void Update(TariffBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                var element = context.Tariffs.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(TariffBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                Tariff element = context.Tariffs.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Tariffs.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Tariff CreateModel(TariffBindingModel model, Tariff tariff)
        {
            tariff.name_tariff = model.name_tariff;
            tariff.name_service = model.name_service;
            tariff.amount_overtariff = model.amount_overtariff;
            tariff.amount_tariff = model.amount_tariff;
            tariff.price_overtariff = model.price_overtariff;
            tariff.price_tariff = model.price_tariff;
            tariff.unit_tariff = model.unit_tariff;
            return tariff;
        }

        private TariffViewModel CreateModel(Tariff model)
        {
            return new TariffViewModel
            {
                Id_tariff = model.Id,
                name_tariff = model.name_tariff,
                name_service = model.name_service,
                amount_overtariff = model.amount_overtariff,
                amount_tariff = model.amount_tariff,
                price_overtariff = model.price_overtariff,
                price_tariff = model.price_tariff,
                unit_tariff = model.unit_tariff,
            };
        }
    }
}
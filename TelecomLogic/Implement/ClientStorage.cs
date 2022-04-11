using System;
using System.Collections.Generic;
using System.Linq;
using TelecomLogic.BindingModels;
using TelecomLogic.StorageInterfaces;
using TelecomLogic.ViewModels;
using TelecomDB.Models;

namespace TelecomDB.Implement
{
    public class ClientStorage : IClientStorage
    {
        public List<ClientViewModel> GetFullList()
        {
            using (var context = new TelecomDatabase2())
            {
                return context.Clients
                .Select(CreateModel)
                .ToList();
            }
        }

        public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TelecomDatabase2())
            {
                return context.Clients
                .Where(rec => rec.last_name.Contains(model.last_name))
                .Select(CreateModel)
                .ToList();
            }
        }

        public ClientViewModel GetElement(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TelecomDatabase2())
            {
                var client = context.Clients
                .FirstOrDefault(rec => rec.last_name == model.last_name || rec.Id == model.Id);
                return client != null ? CreateModel(client) : null;
            }
        }

        public void Insert(ClientBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                context.Clients.Add(CreateModel(model, new Client()));
                context.SaveChanges();
            }
        }

        public void Update(ClientBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                var element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ClientBindingModel model)
        {
            using (var context = new TelecomDatabase2())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Clients.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Client CreateModel(ClientBindingModel model, Client client)
        {
            client.name = model.name;
            client.last_name = model.last_name;
            client.middle_name = model.middle_name;
            client.phone_number = model.phone_number;
            return client;
        }

        private ClientViewModel CreateModel(Client model)
        {
            return new ClientViewModel
            {
                Id_client = model.Id,
                last_name = model.last_name,
                name = model.name,
                middle_name = model.middle_name,
                phone_number = model.phone_number,
            };
        }
    }
}
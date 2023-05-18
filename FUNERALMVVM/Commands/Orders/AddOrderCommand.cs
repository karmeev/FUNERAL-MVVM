﻿using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Domain.Order;
using FUNERAL_MVVM.Utility;
using FUNERALMVVM.ViewModel;
using OrderManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace FUNERALMVVM.Commands.Orders
{
    public class AddOrderCommand : BaseCommands
    {
        private readonly OrderController _orderController;

        public AddOrderCommand(OrderController orderController)
        {
            _orderController = orderController;
        }

        public override void Execute(object parameter)
        {
            DateTime dateTime = DateTime.Now;

            var deads = new List<Domain.Order.DeadModel>();

            foreach (var item in _orderController._deadModels)
            {
                deads.Add
                    (
                    new Domain.Order.DeadModel()
                    {
                        Name = item.Name,
                        LastName = item.LastName,
                        ThirdName = item.ThirdName,
                        Life = item.Life,
                        Death = item.Death,
                    }
                );
            }

            OrderEntity orderEntity = new()
            {
                Base = new Domain.Order.Config.FuneralBaseEntity()
                {
                    CategoryFuneral = _orderController.FuneralCategory,
                    ModelFuneral = _orderController.FuneralModel,
                    Rock = _orderController.FuneralRock,
                    Looks = _orderController.Looks
                },
                Stela = new Domain.Order.Stela.StelaEntity()
                {
                    Section = _orderController.StelaSection,
                    Size = _orderController.StelaSize,
                },
                Stand = new Domain.Order.Config.StandEntity()
                {
                    Size = _orderController.StandSize,
                    Section = _orderController.StandSection,
                },
                Flowershed = new Domain.Order.Config.FlowershedEntity()
                {
                    Size = _orderController.FlowerSize,
                    Section = _orderController.FlowerSection,
                    NoInstal = _orderController.FlowerIndicate
                },
                Polishing = _orderController.PolishingColor,
                Deadass = deads,
                DeadassCount = _orderController._deadboydCount,
                Instal = new Domain.Order.Config.InstalEntity()
                {
                    Idicate = _orderController.InstalIndicate,
                    InstalPrice = _orderController.InstalPrice,
                },
                Funeral = new Domain.Order.Config.FuneralEntity()
                {
                    Size = _orderController.FuneralSize,
                    UpPart = _orderController.UpDesign,
                    DownPart = _orderController.DownDesign,
                    Other = _orderController.OtherDesign,
                    Epitafia = _orderController.Epitafia,
                    Type = _orderController.Type,
                    Color = _orderController.Color,
                },
                ClientOrder = new Domain.Order.Config.ClientOrderEntity()
                {
                    Name = _orderController.ClientName,
                    LastName = _orderController.ClientLastName,
                    ThirdName = _orderController.ClientThirdName,
                    Adress = _orderController.ClientAdress,
                    Passport = _orderController.ClientPassport,
                    Phone = _orderController.ClientNumber,
                    Cemetry = _orderController.ClientFuneral,
                    Telegram = _orderController.ClientSocial,
                    DeliveryPlace = _orderController.ClientDelivery,
                    DateToday = dateTime.ToString(),
                    DateCreation = _orderController.CreateFuneralDate
                },
                Price = _orderController.Price,
                Prepayment = _orderController.Prepayment,
                Remainder = _orderController.Remainder,
            };
            string fileName = ".docs\\json\\OrderDoc.json";
            AddJson(orderEntity, fileName);
            AddDocs();
            _orderController.Response = "Успешно";
        }
        public async void AddDocs()
        {
            await Task.Run(() =>
            {
                Provider prod = new();
                Provider.CreateOrder();
            });
        }

        public async void AddJson(OrderEntity order, string fileName)
        {
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, order, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            await createStream.DisposeAsync();
        }
    }
}
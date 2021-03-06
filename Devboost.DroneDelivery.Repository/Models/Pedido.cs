﻿using Devboost.DroneDelivery.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devboost.DroneDelivery.Repository.Models
{
    [Table("dbo.Pedido")]
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
            DataHora = DateTime.Now;
        }

        public Guid Id { get; set; }
        public int Peso { get; set; }

        public string Status { get; set; }
        public DateTime? DataHora { get; set; }
        public double DistanciaDaEntrega { get; set; }
        public Guid DroneId { get; set; }
        public Guid CompradorId { get; set; }

        public PagamentoBandeiraEnum BandeiraCartao { get; set; }
        public string NomeCartao { get; set; }
        public string NumeroCartao { get; set; }
        public DateTime DataValidadeCartao { get; set; }
        public string CodSegurancaCartao { get; set; }
        public TipoCartaoEnum TipoCartao { get; set; }

        public StatusPagamentoEnum StatusPagamento { get; set; }
    }
}
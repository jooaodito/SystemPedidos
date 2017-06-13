using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystemPedidoAgoraVai.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public virtual Item Item { get; set; }
        public int ItemId { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal TotalPedido { get; set; }
    }
}
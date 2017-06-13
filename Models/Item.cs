using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystemPedidoAgoraVai.Models
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }
        public string NomeItem { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
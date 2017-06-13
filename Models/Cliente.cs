using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystemPedidoAgoraVai.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string EmailCliente { get; set; }
    }
}
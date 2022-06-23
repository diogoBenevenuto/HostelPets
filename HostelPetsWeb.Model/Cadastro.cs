﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HostelPetsWeb.Model
{
    [Index("CpfCliente", Name = "UQ__Cadastro__960CE634897A92BD", IsUnique = true)]
    public partial class Cadastro
    {
        [Key]
        [Column("ID_Cliente")]
        public int IdCliente { get; set; }
        [Required]
        [Display(Name = "Nome Completo")]
        [Column("nome_cliente")]
        [StringLength(50)]
        [Unicode(false)]
        public string NomeCliente { get; set; }
        [Required]
        [Display(Name = "Senha")]
        [Column("senha_cliente")]
        [StringLength(50)]
        [Unicode(false)]
        public string SenhaCliente { get; set; }
        [Display(Name = "CPF")]
        [Column("CPF_cliente")]
        public int CpfCliente { get; set; }
        [Display(Name = "Celular")]
        [Column("tell_cliente")]
        public int TellCliente { get; set; }
        [Required]
        [Display(Name = "Email")]
        [Column("email_cliente")]
        [StringLength(100)]
        [Unicode(false)]
        public string EmailCliente { get; set; }
        [Required]
        [Display(Name = "Endereço")]
        [Column("endereco_cliente")]
        [StringLength(100)]
        [Unicode(false)]
        public string EnderecoCliente { get; set; }
        [Display(Name = "Número")]
        [Column("N_cliente")]
        public int NCliente { get; set; }
    }
}
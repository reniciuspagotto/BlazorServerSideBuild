﻿using System;

namespace BlazorServerSide.ViewModel
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
    }
}

﻿using System;
using Heranca.Entities;

namespace Heranca.Entities{
    class Programa
    {
        static void Main(string[] args)
        {

            BusinessAccount account = new BusinessAccount(8010, "Philiphe Ferreira", 100.00, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}
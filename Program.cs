using System;
using System.Collections.Generic;
using Listas.classes;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produto= new List<Produto>();

            Produto cafe = new Produto(2, "cafe pequeno", 3.5f);


            produto.Add(new Produto(1,"pao na chapa",2.5f));
            produto.Add(cafe);
            produto.Add(new Produto(3,"coxinha",5.5f));
            

        }
    }
}

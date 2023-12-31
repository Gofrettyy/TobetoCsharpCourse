﻿using System;
namespace Interfaces
{
    interface ICustomerDal //veritabanı işlemlerini bu dal sınıfında yaparız. ister sql yada oracleda yap aynı interface i kullanırız farklı kodlar kullanırız ama
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine(" Sql updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine(" Oracle updated");
        }

    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}




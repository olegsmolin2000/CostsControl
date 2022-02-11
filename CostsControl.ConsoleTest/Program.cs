using CostsControl.EFCore.Context;
using CostsControl.EFCore.Entities;
using CostsControl.EFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CostsControl.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            using (CostsDB db=new CostsDB())
            {
                Console.WriteLine("Start getting data from DB");
                AccountsRepository accountsRepository = new AccountsRepository(db);
                ProductsRepository productsRepository = new ProductsRepository(db);
                CategoriesRepository categoriesRepository = new CategoriesRepository(db);
                TransactionsRepository transactionsRepository = new TransactionsRepository(db);

                var accounts = accountsRepository.ItemsInDataBase;
                var categories = categoriesRepository.ItemsInDataBase;
                var products = productsRepository.ItemsInDataBase;
                Console.WriteLine("End getting data from DB");

                Console.WriteLine("Accounts:");
                foreach (var acc in accounts)
                {
                    var currentTransactions = acc.Transactions.ToList();

                    Console.WriteLine($"{acc.Id}: Name: {acc.Name}, Amount: {acc.Amount}, TransactionsCount: {currentTransactions.Count}");
                }
                Console.WriteLine();

                Console.WriteLine("Categories:");
                foreach (var category in categories)
                {
                    var currentProducts = category.Products.ToList();
                    var s = currentProducts?.Sum(prod => prod.Transactions?.Sum(tr => tr.Amount));
                    Console.WriteLine($"{category.Id}: Name: {category.Name}, Parent: {category.ParentCategory?.Name}, ProductsCount: {currentProducts.Count}, MoneySpend: {s}");
                }
                Console.WriteLine();

                Console.WriteLine("Products:");
                foreach (var product in products)
                {
                    var currentCategories = product.Categories.ToList();

                    Console.WriteLine($"{product.Id}: Name: {product.Name}, Category: {currentCategories.FirstOrDefault()?.Name}, CategoriesCount: {currentCategories.Count}, TransactionsCount: {product.Transactions.Count}");
                }
                Console.WriteLine();

                Console.WriteLine("Transactions:");
                foreach (var transaction in transactionsRepository.ItemsInDataBase)
                {
                    Console.WriteLine($"{transaction.Id}: Product: {transaction.Product.Name}, Amount: {transaction.Amount}, Date: {transaction.Date}, Account: {transaction.Account.Name}");
                }
                Console.WriteLine();
            }

           


        }
    }
}

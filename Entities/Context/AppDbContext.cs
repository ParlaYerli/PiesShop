
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=PieIdentity; Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Kek", Description = "Cake is a form of sweet food made from flour, sugar, and other ingredients, that is usually baked. In their oldest forms, cakes were modifications of bread, but cakes now cover a wide range of preparations that can be simple or elaborate, and that share features with other desserts such as pastries, meringues, custards, and pies." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Pasta", Description = "A pie is a baked dish which is usually made of a pastry dough casing that contains a filling of various sweet or savoury ingredients. Sweet pies may be filled with fruit (as in an apple pie), nuts (pecan pie), brown sugar (sugar pie) or sweetened vegetables (rhubarb pie). Savoury pies may be filled with meat (as in a steak pie or a Jamaican patty), eggs and cheese (quiche) or a mixture of meat and vegetables (pot pie)." });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = 1, Name = "Havuçlu Kek", ImageThumbnailUrl = "i2.jpg", Price = 15, ShortDescription = "havuçlu kek", LongDescription = "İlk olarak Havuçları soyup kaynamaya alalım. Çatal ile kontrol edelim yumusamış ise süzüp Soğumaya alalım.Unu, tarçın, kabartma tozu, karbonat ve tuzu eleyelim.Ayrı bir kapta 3 yumurtayı, esmer şekeri, şekeri ve vanilyayı mikserle cırpalım 5 dakika ya yakın ve sıvı yağ yı ekleyelim ve tekrar karıştıralım.Eledigimiz diğer malzemeleri içine ilave edelim ve spatula ile karıştıralım.En son robottan geçirdiğimiz Havuçları ve cevizi ekleyerek yağlanmış tepsiye dökelim Fransız ayarda pişirelim.Yaklaşık 30 - 40 dakika.Fırından çıkan kekimizi Soğumaya alalım,.", CategoryId = 2 });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = 2, Name = "Çikolatalı Pasta", Price = 20, ImageThumbnailUrl = "i5.png", ShortDescription = "çikolatalı pasta", LongDescription = "Öncelikle 3 çorba kaşığı kakaoyu ve 1 çorba kaşığı granül kahveyi 1 su bardağı sıcak suda eritip kenara alın. (Suyu yavaş yavaş ekleyin, kullandığınız kahve ve kakaonun cinsine göre değişiklik gösterebilir, aşırı sıvı bir kıvam olmamalı, duruma göre su miktarını azaltın.)Derin bir kapta 150 gram tereyağı ve 300 gram toz şekeri çırpıcı yardımıyla çırpın. (topaklaşacaktır).Daha sonra 3 yumurtayı çırpmaya devam ederek teker teker ekleyin.Unun yarısını,kabartma tozunu, bir tutam tuzu ekleyin ve karıştırmaya devam edin.Yaptığınız kakao - kahve karışımının üçte ikisini harca ekleyerek çırpın.2, 5 çorba kaşığı yoğurdu ekleyin biraz çırptıktan sonra kalan unu da ekleyin.Kalan kakao - kahve karışımını da kek harcına ekleyin.Kek harcını,20şer cmlik 2 adet kelepçeli kalıba eşit bir şekilde bölüştürün.170 derece fırında 30 dakika kontrollü bir şekilde pişirin.", CategoryId = 1 });
            base.OnModelCreating(modelBuilder);
        }
    }
}

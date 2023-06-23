using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Context = "ASP.NET Core, güçlü ve esnek bir web uygulama geliştirme çerçevesidir. Çapraz platform desteği sunar ve açık kaynaklıdır. Modüler yapısıyla yalnızca ihtiyaç duyulan bileşenleri kullanmanızı sağlar. Yüksek performanslı, ölçeklenebilir ve güvenli uygulamalar oluşturmanızı kolaylaştırır.",
                ViewCount = 15,
                CategoryId = Guid.Parse("225FD81C-BC64-4D59-B1BA-BFD1751660BA"),
                ImageId = Guid.Parse("0067A2CA-180B-4872-9556-A1B4B347A4D4"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("A284B809-7240-48DF-87AB-9A9ADFB36131")

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi 1",
                Context = "Visual Studio, geliştiriciler için kapsamlı bir entegre geliştirme ortamıdır. Zengin özellikleri, hata ayıklama araçları ve geniş dil desteği ile verimli bir şekilde yazılım geliştirmeyi sağlar. Proje yönetimi, sürüm kontrol entegrasyonu ve otomatik tamamlama gibi özellikleriyle geliştirme sürecini kolaylaştırır",
                ViewCount = 15,
                CategoryId = Guid.Parse("3BB4EB15-107A-4C92-8B84-C1B663215A67"),
                ImageId = Guid.Parse("6AD11C3E-7C48-4C59-871D-8F062DAC7161"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("C30EDAB8-CBB1-4A6B-810C-013456C7D076")
            });

        }
    }
}

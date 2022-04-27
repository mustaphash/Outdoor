using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class AnimalConfig : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animals");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(1000);

            builder.HasData(
                new Animal
                {
                    Id = 1,
                    Name = "Brown Bear",
                    Description = "The bear is the largest carnivore in Bulgaria and can be found in the Rhodope Mountains, Rila Mountains, Pirin Mountains, and Stara Planina"
                },
                new Animal
                {
                    Id = 2,
                    Name = "Wolf",
                    Description = "Wolves live in parts of Stara Planina (Balkan Mountains), Strandzha Mountains, the Rhodopes, and around the city of Ruse."
                },
                new Animal
                {
                    Id = 3,
                    Name = "Fox",
                    Description = "The fox can be encountered in many places in Bulgaria, usually in forest areas"
                },
                new Animal
                {
                    Id = 4,
                    Name = "Wild Rabbit",
                    Description = "Wild rabbits are still widespread around Bulgaria, mainly in the flat and low areas."
                },
                new Animal
                {
                    Id = 5,
                    Name = "Wild Boar",
                    Description = "Boars are known to be aggressive when they are with their cubs so stay out of the forest in the Spring. Wild Boar are hunted in Bulgaria and in some areas their population is stimulated in order to offer better hunting conditions."
                },
                new Animal
                {
                    Id = 6,
                    Name = "Stork",
                    Description = "Storks have a special role in the local folklore. They are believed to be the birds bringing spring with them. Storks spend the winter in Africa and come back to their nests in Bulgaria every year at the end of March."
                },
                new Animal
                {
                    Id = 7,
                    Name = "Cuckoo",
                    Description = "The cuckoo has a special role in spring. Old people say that when you here the cuckoo song for the first time in spring, you should check your wallet. If it’s full of money, you’ll have a prosperous year. If it’s not, it is going to be bad for you."
                },
                new Animal
                {
                    Id = 8,
                    Name = "Hedgehog",
                    Description = "Hedgehogs can be seen in the wild as well as in cities and villages. Some people in the villages even leave food for the hedgehogs to make sure they are around because they are famous for eating snakes."
                },
                new Animal
                {
                    Id = 9,
                    Name = "Pig"
                },
                new Animal
                {
                    Id = 10,
                    Name = "Horse"
                },
                new Animal
                {
                    Id = 11,
                    Name = "Goat"
                },
                new Animal
                {
                    Id = 12,
                    Name = "Cow"
                },
                new Animal
                {
                    Id = 13,
                    Name = "Snake"
                },
                new Animal
                {
                    Id = 14,
                    Name = "Bison"
                },
                new Animal
                {
                    Id = 15,
                    Name = "Deer"
                },
                new Animal
                {
                    Id = 16,
                    Name = "Sheep"
                },
                //Fish
                new Animal
                {
                    Id = 17,
                    Name = "Pike"
                },
                new Animal
                {
                    Id = 18,
                    Name = "Carp"
                },
                new Animal
                {
                    Id = 19,
                    Name = "Trout"
                },
                new Animal
                {
                    Id = 20,
                    Name = "Salmon"
                },
                new Animal
                {
                    Id = 21,
                    Name = "Perch"
                },
                new Animal
                {
                    Id = 22,
                    Name = "Bonito"
                },
                new Animal
                {
                    Id = 23,
                    Name = "Popche"
                },
                new Animal
                {
                    Id = 24,
                    Name = "Catfish"
                },
                new Animal
                {
                    Id = 25,
                    Name = "Redeye"
                },
                new Animal
                {
                    Id = 26,
                    Name = "Woodpecker"
                },
                new Animal
                {
                    Id = 27,
                    Name = "Collared Dove"
                },
                new Animal
                {
                    Id = 28,
                    Name = "Swallow"
                },
                new Animal
                {
                    Id = 29,
                    Name = "Sparrow"
                },
                new Animal
                {
                    Id = 30,
                    Name = "Owl"
                }
                );
        }
    }
}

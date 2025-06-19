using PiesShop.Models;

namespace PiesShop.Models;

public class DbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        BethanysPieShopDbContext context =
            applicationBuilder.ApplicationServices.CreateScope
                ().ServiceProvider.GetRequiredService<BethanysPieShopDbContext>();

        if (!context.Categories.Any())
        {
            context.Categories.AddRange(Categories.Select(c => c.Value));
        }

        if (!context.Pies.Any())
        {
            context.AddRange(new List<Pie>
            {
                new()
                {
                    Name = "Key Lime Pie", Price = 14.95M, ShortDescription = "Tangy Bliss",
                    LongDescription =
                        ": Experience a burst of citrusy delight with our Key Lime Pie. Each velvety bite is a zesty celebration, a" +
                        "s the smooth lime filling harmonizes with a buttery graham cracker crust. It's a refreshing treat for every palate.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224289/BethanyPieShop/adnnx6jowg2uxphdlf9b.jpg",
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224287/BethanyPieShop/fljrskoom4fujjij3lwe.jpg",
                    InStock = true,
                    AllergyInformation = ""
                },
                new()
                {
                    Name = "Apple Caramel Pie", Price = 16.50M, ShortDescription = "Sweet Elegance",
                    LongDescription =
                        "Fall in love with the divine combination of crisp apples and rich caramel in our Apple Caramel Pie. " +
                        "The layers of sweetness are encased in a flaky pastry, creating a symphony of flavors that will leave you craving more.",
                    Category = Categories["Fruit pies"],
                    ImageUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224547/BethanyPieShop/z1moclx58ppfqtxw2wtb.jpg",
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224545/BethanyPieShop/d6bopbtu5ps4680prf0j.jpg",
                    InStock = false,
                    AllergyInformation = ""
                },
                new()
                {
                    Name = "Chocolate Pecan Pie", Price = 17.95M, ShortDescription = "Decadent Delight",
                    LongDescription =
                        "Indulge in the ultimate chocolate experience with our Chocolate Pecan Pie. Velvety chocolate meets the crunch of pecans, nestled in a buttery crust. " +
                        "It's a luxurious treat for chocolate enthusiasts.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224712/BethanyPieShop/x4dpj1fdo65drmhc3nkw.jpg",
                    IsPieOfTheWeek = true,
                    ImageThumbnailUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224771/BethanyPieShop/rkkw5xullwbwualguwmd.jpg",
                    InStock = true,
                    AllergyInformation = ""
                },
                new()
                {
                    Name = "Blueberry Cheesecake Pie", Price = 18.99M,
                    ShortDescription = "Creamy Perfection",
                    LongDescription =
                        "Elevate your dessert experience with our Blueberry Cheesecake Pie. " +
                        "A velvety layer of cream cheese meets a burst of juicy blueberries, creating a heavenly fusion that will tantalize your taste buds",
                    Category = Categories["Seasonal pies"],
                    ImageUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224859/BethanyPieShop/hwtiae9yd125v6ekpacq.jpg",
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700225013/BethanyPieShop/g7hfnriwxmpx9pfm4kvy.jpg",
                    InStock = false,
                    AllergyInformation = ""
                },
                new()
                {
                    Name = "Cherry Almond Pie", Price = 15.75M, ShortDescription = "Nutty Sweetness",
                    LongDescription =
                        "Embark on a flavor adventure with our Cherry Almond Pie. Succulent cherries mingle with the crunch of almonds, all embraced by a golden crust. " +
                        "It's a delightful balance of fruity sweetness and nutty richness.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700225085/BethanyPieShop/g6jstfozlguifgvmn5bh.jpg",
                    IsPieOfTheWeek = true,
                    ImageThumbnailUrl =
                        "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700225155/BethanyPieShop/gdnfqm0dehrzptinmilz.jpg",
                    InStock = true,
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Pistache Cheese Cake", Price = 21.95M, ShortDescription = "We're going nuts over this one",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecake.jpg",
                    InStock = true, IsPieOfTheWeek = true,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecakesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Pecan Pie", Price = 21.95M, ShortDescription = "More pecan than you can handle!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Birthday Pie", Price = 29.95M, ShortDescription = "A Happy Birthday with this pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/birthdaypie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/birthdaypiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Apple Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecake.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecakesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecake.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Cherry Pie", Price = 15.95M, ShortDescription = "A summer classic!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Christmas Apple Pie", Price = 13.95M, ShortDescription = "Happy holidays with this pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Cranberry Pie", Price = 17.95M, ShortDescription = "A Christmas favorite",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Peach Pie", Price = 15.95M, ShortDescription = "Sweet as peach",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                    InStock = false, IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Pumpkin Pie", Price = 12.95M, ShortDescription = "Our Halloween favorite",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Rhubarb Pie", Price = 15.95M, ShortDescription = "My God, so sweet!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Strawberry Pie", Price = 15.95M, ShortDescription = "Our delicious strawberry pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    InStock = true, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Strawberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                    InStock = false, IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                    AllergyInformation = ""
                }
            });
        }

        context.SaveChanges();
    }

    private static Dictionary<string, Category>? categories;

    public static Dictionary<string, Category> Categories
    {
        get
        {
            if (categories == null)
            {
                var genresList = new Category[]
                {
                    new()
                    {
                        CategoryName = "Fruit pies", Description = "All- fruity pies"
                    },
                    new()
                    {
                        CategoryName = "Cheese cakes", Description = "Cheesy- all the way"
                    },
                    new()
                    {
                        CategoryName = "Seasonal pies",
                        Description = "Get in the mood for a seasonal pie"
                    },
                };
                categories = new Dictionary<string, Category>();

                foreach (Category genre in genresList)
                {
                    categories.Add(genre.CategoryName, genre);
                }
            }


            return categories;
        }
    }
}
namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.ModelLibrary>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.ModelLibrary context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.autores.AddOrUpdate(new autor { 
                nombres= "autor uno",
                apellidos= "apellidos uno"
            });
            context.autores.AddOrUpdate(new autor { 
                nombres= "autor dos",
                apellidos= "apellidos dos"
            });
            context.autores.AddOrUpdate(new autor { 
                nombres= "autor tres",
                apellidos= "apellidos tres"
            });

            context.editoriales.AddOrUpdate(new editorial{
                nombre= "editorial uno",
                sede= "sede uno"
            });
            context.editoriales.AddOrUpdate(new editorial{
                nombre= "editorial dos",
                sede= "sede dos"
            });
            context.editoriales.AddOrUpdate(new editorial{
                nombre= "editorial tres",
                sede= "sede tres"
            });

            context.libros.AddOrUpdate(new libro{
                editorial_id= 2,
                isbn= 234567891,
                n_paginas= 200,
                sinopsis= "sinopsis dos",
                titulo= "libro dos"
            });
            context.libros.AddOrUpdate(new libro{
                editorial_id= 3,
                isbn= 345678912,
                n_paginas= 300,
                sinopsis= "sinopsis tres",
                titulo= "libro tres"
            });
            context.libros.AddOrUpdate(new libro{
                editorial_id= 1,
                isbn= 1234567890,
                n_paginas= 100,
                sinopsis= "sinopsis uno",
                titulo= "libro uno"
            });

            context.autores_has_libros.AddOrUpdate(new autor_has_libro{
                autor_id= 1,
                isbn_libro= 345678912
            });
            context.autores_has_libros.AddOrUpdate(new autor_has_libro{
                autor_id= 2,
                isbn_libro= 234567891
            });
            context.autores_has_libros.AddOrUpdate(new autor_has_libro{
                autor_id= 3,
                isbn_libro= 1234567890
            });
        }
    }
}

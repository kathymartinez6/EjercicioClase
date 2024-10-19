using EjercicioClase;

SuperHeroe superHeroe = new SuperHeroe();
superHeroe.Nombre = "Batman";
superHeroe.IdentidadSecreta = "Bruce Wayne";
superHeroe.Ciudad = "Gotham City";
superHeroe.PuedeVolar = false;
superHeroe.poder.NombrePoder = "sin superpoderes";
superHeroe.poder.Descripcion = "dinero";
superHeroe.poder.Nivel = 4;
superHeroe.imprimir();

SuperHeroe superHeroe1 = new SuperHeroe();
superHeroe1.Nombre = "Raven";
superHeroe1.IdentidadSecreta = "Rachell Roth";
superHeroe1.Ciudad = "Azarath";
superHeroe1.PuedeVolar = true;
superHeroe1.poder.NombrePoder = "Demoniaco";
superHeroe1.poder.Descripcion = " manipular energía, tiempo y emociones";
superHeroe1.poder.Nivel = 9;
superHeroe1.imprimir();

SuperHeroe superHeroe2 = new SuperHeroe();
superHeroe2.Nombre = "Wonder Woman";
superHeroe2.IdentidadSecreta = "Diana de Temiscira";
superHeroe2.Ciudad = "Temiscira";
superHeroe2.PuedeVolar = true;
superHeroe2.poder.NombrePoder = "El Lazo de la Verdad";
superHeroe2.poder.Descripcion = "Fuerza, velocidad, resistencia";
superHeroe2.poder.Nivel = 10;
superHeroe2.imprimir();

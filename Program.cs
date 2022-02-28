Negozio n = new Negozio();
Scaffale s = new Scaffale("City pop");
Scaffale s2 = new Scaffale("Drill");

DVD dvd = new DVD("Sup", "void", "1");
CD cd = new CD("tokyo", "xl", "2");

Brano b = new Brano(100000, 1, "Track 1");
Brano b2 = new Brano(400000, 4, "Track 2");

dvd.elementiDisco.Add(b);
dvd.elementiDisco.Add(b2);

n.Riproduci(dvd);
n.Riproduci(dvd);
n.Riproduci(dvd);
# Aplikacija podržava sledeće funkcionalnosti:
1. Neprijavljen tj. neregistrovan korisnik ima pregled svih škola na osnovu odabranog mesta i odabranih jezika. Takođe ima i pregled svih profesora koji rade u odabranoj školi. Nema mogućnost zakazivanja časova.
2. Omogućiti neregistrovanim korisnicima (studentima) mogućnost registracije na sistem. Prilikom registracije unose se - ime, prezime, JMBG (jedinstven), pol, adresa, email, lozinka. Za novog korisnika se automatski formira prazna lista časova.
3. Omogućiti korisnicima da se prijave i odjave sa sistema. Prilikom prijave na sistem korisnik unosi JMBG i lozinku sa kojom se registrovao.
4. Svi registrovani korisnici imaju pregled svojih ličnih podataka i mogućnost izmene istih.
5. Administratori se učitavaju iz baze podataka prilikom pokretanja aplikacije i ne mogu se naknadno dodati.
6. Administrator ima pregled svih entiteta. Može sve podatke da doda, izmeni i obriše. Sva brisanja su logička (ne uklanjaju se fizički, tj. podatak postaje neaktivan i više se ne prikazuje, niti se može obrisati i izmeniti). Administratori kreiraju inicijalno SLOBODNE časove profesorima. Administrator može da briše časove bez obzira da li su REZERVISANI ili SLOBODNI. Samo administratori mogu da registruju profesore, a prilikom registracije unose i jezike koje će profesori predavati.
7. Profesor ima mogućnost prikaza svojih časova (slobodnih i rezervisanih) za odabrani datum i pregled studenta koji je kod njega rezervisao čas. Takođe, mogu da kreiraju i brišu svoje slobodne
časove. (Ograničenje prilikom kreiranja časova: Čas se ne može kreirati u prošlosti, već isključivo u budućnosti. Ograničenje prilikom brisanja časova: Profesor ne može da obriše čas ako je REZERVISAN.)
8. Student ima mogućnost da za odabranog profesora vidi listu slobodnih časova, kao i listu svojih rezervisanih časova. Takođe ima mogućnost da zakaže SLOBODAN čas, kao i da otkaže svoj prethodno REZERVISANI čas. Omogućiti grafički prikaz svih slobodnih časova za odabrane profesore.
9. Pretraga entiteta je omogućena gde korisnici (registrovani i neregistrovani) imaju pregled sledećih entiteta:
a. Registrovani korisnici – pretraga po imenu, prezimenu, email, adresa i po tipu registrovanih korisnika (ovu mogućnost imaju administratori)
b. Profesora - pretraga po imenu, prezimenu, adresi, email adresi, jezicima koje predaju (ovu mogućnost imaju REGISTROVANI/NEREGISTROVANI koriscnici sistema)
c. Škola – pretraga po nazivu, adresi, jezicima koje je moguće pohađati (ovu mogućnost imaju STUDENTI/NEREGISTROVANI korisnici sistema)

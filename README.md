# SBES_TIM31_3

## Autori

<table>
  <tr>
    <td>Đorđe Lazarević</td>
    <td>PR 147/2016</td>
  </tr>
  <tr>
    <td>Nebojša Vasić</td>
    <td>PR 93/2016</td>
  </tr>
  </table>
  
  # Zadatak
  
                                                     Lakši projektni zadatak 3 

Potrebno je realizovati sistem za bankarstvo.

Sistem treba da obezbedi autentifikaciju pomoću sertifikata. Validacija sertifikata se vrši na sledeći način:
  ● validacija servisa: servisov sertifikat je validan ako mu je Issuer isti kao klijentov 
  ● validacija klijenta: klijentov sertifikat je validan ako mu je Issuer isti kao servisov
  
Postoje 2 korisničke grupe, koje imaju različita prava unutar sistema: 
  ● Službenik 
  ● Korisnik 
  
Servis vodi evidenciju o računima registrovanih korisnika.

Račun ima svoj broj (long), iznos (double), dozvoljeniMinus (double), blokiran (double), poslednjaTransakcija (DateTime), kao i informaciju kom korisniku pripada.

Servis treba da omogući:
  ● OtvoriRacun (može samo član grupe Službenik) - otvara novi račun u sistemu, ukoliko taj korisnik već nema otvoreni račun. 
  ● ZatvoriRacun (može samo član grupe Službenik) - uklanja račun iz sistema.
  ● ProveriStanje (može član grupe Korisnik ili član grupe Službenik) - ispisuje iznos na računu.
  ● Uplata (može član grupe Korisnik ili član grupe Službenik) - ukoliko je iznos računa bio u minusu, a uplatom je prešao u broj koji je veći ili jednak nuli, proveriti da li       je račun bio blokiran i ukoliko jeste odblokirati ga.
  ● Isplata (može član grupe Korisnik ili član grupe Službenik) - nije moguća ukoliko je račun blokiran; ukoliko nije blokiran, ne može se isplatiti više od dozvoljenog minusa.   ● Opomena (može samo član grupe Službenik) - može da blokira račun ukoliko je korisnik u minusu.
  
Sistem treba da obezbedi sve uspešne i neuspešne autentifikacije u Windows Event Log-u, kao i skladištenje informacija o svakoj uspešnoj i neuspešnoj transakciji (uplata, isplata).

Napomena: U okviru sertifikata u SubjectName treba upisati za CN korisnicko ime, a za OU grupu kojoj korisnik pripada.

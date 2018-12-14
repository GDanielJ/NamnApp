# NamnApp

Programmet är strukturerat som följer:

Projekt: NamnApp
Program: Detta är en konsolapp där UI finns.

Projekt: Data
UserRepository: Klass för att spara ner indata från konsolen. Förnamn och efternamn.
Users: Klass för att spara ner instanser av UserRepository i en lista (just nu kan man bara skapa en instans av klassen, men det går ju att ändra på framöver).
DA: Klass för att spara ner innehållet i Users-objektet i en textfil. Denna klass är inte klar, men tänker att man skriver via StreamWriter. Borde inte var speciellt komplicerat.

I kommentarerna i programmet finns det ett antal frågor.

Tar gärna emot feedback avseende vad som helst så som namnsättning på variabler, metoder mm. Problemet som jag har just nu är att jag inte lyckas skapa outputdata i DA-objektet med tillhörande metod. Se kommentarer i koden.

Vet inte heller om jag skapar instanser av mina klasser på rätt ställen i koden. Skapar tex en instans av Users i Program, och en instans av DA i Users. Känns rätt men inte säker.

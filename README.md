# Formular-asigurari

Acest proiect reprezintă o aplicație desktop dezvoltată în C# folosind Windows Forms, destinată gestionării datelor specifice unei companii de asigurări (clienți, polițe de asigurare). Proiectul a fost realizat ca o cerință pentru disciplina Programarea Aplicațiilor Windows.

Tehnologii utilizate:
  -Limbaj de programare: C#;
  -Framework: .NET Framework;
  -Baza de date: Access;

Funcționalități principale:
Aplicația oferă următoarele capabilități de gestionare și vizualizare a datelor:
  -Formular dedicat pentru înregistrarea,  datelor personale ale clienților;
  -Formular pentru înregistrarea tipurilor de polițe de asigurare, a datelor specifice și a sumelor asigurate.
  -Tablouri de bord  pentru afișarea relației dintre Clienți și Polițele de Asigurare;
  -Suport pentru operațiuni de tip CRUD (Create, Read, Update, Delete) asupra bazei de date;
  -Implementarea validărilor de date la nivel de formular pentru a asigura integritatea datelor.

Structura proiectului:
Proiectul este structurat pe mai multe formulare (Forms) și clase logice:
  -Form1: Gestiunea datelor despre clienți
  -Form2: Gestiunea polițelor de asigurare
  -Form3: Afișarea listei de clienți si asigurări
  -Form4: Grafic care prezintă suma totală asigurată în fiecare an
  -Form5: Implementarea funcționalităților CRUD
  -Clase pentru reprezentarea entităților: 'Persoana.cs', 'Client.cs', 'Asigurare.cs'.

Instalare și Rulare
Pentru a rula proiectul local, asigurați-vă că aveți instalat:
  -Visual Studio (versiunea 2019 sau mai nouă).
  -Pachetul de dezvoltare .NET (corespunzător versiunii proiectului).

Instrucțiuni:
  -Clonați repository-ul: `git clone https://github.com/al3xandrastanciu/Formular-asigurari`
  -Deschideți fișierul `.sln` în Visual Studio.
  -Asigurați-vă că Baza de Date este configurată corect.
  -Apăsați `F5` pentru a rula aplicația.

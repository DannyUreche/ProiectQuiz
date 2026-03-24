Aplicație de tip Quiz - C#

Descrierea Proiectului 

Acest proiect reprezintă o aplicație desktop interactivă dezvoltată în C#.
Aplicația este concepută pentru a testa cunoștințele utilizatorilor din diverse domenii de interes, oferind o interfață prietenoasă și ușor de navigat.
Utilizatorul are posibilitatea de a selecta un domeniu dintr-un meniu lateral (de exemplu: Istorie, Geografie, Știință), iar aplicația va genera o serie de întrebări cu variante multiple de răspuns.
Ceea ce diferențiază acest proiect este arhitectura sa bazată pe Programare Orientată pe Obiecte (OOP) și capacitatea de a salva progresul utilizatorilor pentru a genera un clasament competitiv (Leaderboard). 

Funcționalități principale 

Meniu de Selecție: O bară laterală (sidebar) intuitivă de unde utilizatorul alege categoria dorită.
Întrebări cu Răspuns Multiplu: Fiecare întrebare are 2 , 3 sau 4 variante de răspuns, cu un singur răspuns corect.
Sistem de Punctaj: Aplicația calculează și afișează scorul la finalul testului. 
Feedback Vizual: Utilizatorul este informat dacă a selectat răspunsul corect sau greșit.
Înregistrarea Utilizatorilor: Jucătorii își introduc numele la începutul sesiunii pentru a le fi urmărit scorul.
Persistența Datelor: Scorurile finale sunt salvate automat într-un fișier text local (scoruri.txt), asigurând păstrarea datelor și după închiderea aplicației.
Leaderboard (Clasament): Aplicația citește datele salvate, le sortează descrescător folosind LINQ și afișează un Top al celor mai buni jucători.  

Tehnologii utilizate  

Limbaj de programare: C# 
Mediu de dezvoltare (IDE): Visual Studio
Arhitectura: Proiectul respectă principiul separării responsabilităților, logica fiind împărțită în mai multe clase: Utilizator & Intrebare & Domeniu - definesc structurile de date. 
QuizManager - gestionează logica jocului și scorul curent.
GestionarScoruri - se ocupă exclusiv de operațiunile de scriere/citire din fișiere (File I/O).

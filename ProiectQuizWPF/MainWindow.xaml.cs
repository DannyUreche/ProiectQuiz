using Modele;
using System.Windows;
using System.Windows.Media;

namespace ProiectQuizWPF
{
    public partial class MainWindow : Window
    {
        private const int LUNGIME_MAX_NUME = 20;
        private List<Categorie> categorii = new List<Categorie>();

        public MainWindow()
        {
            InitializeComponent();
            PopuleazaExemple();
        }

        private void PopuleazaExemple()
        {
            // MATEMATICA
            var matematicaUsor = new Categorie("Matematica - Usor", Dificultate.Usor);
            matematicaUsor.AdaugaIntrebare(new IntrebareUnica("Cat face 15 x 15?", new List<string> { "200", "225", "250", "175" }, 1));
            matematicaUsor.AdaugaIntrebare(new IntrebareUnica("Care este radacina patrata a lui 144?", new List<string> { "11", "12", "13", "14" }, 1));
            matematicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Numarul 0 este numar natural.", true));
            matematicaUsor.AdaugaIntrebare(new IntrebareUnica("Cat face 2 la puterea 8?", new List<string> { "128", "256", "512", "64" }, 1));
            matematicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Pi este aproximativ 3.14.", true));
            matematicaUsor.AdaugaIntrebare(new IntrebareUnica("Care este cel mai mic numar prim?", new List<string> { "0", "1", "2", "3" }, 2));
            matematicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Suma unghiurilor unui triunghi este 180 de grade.", true));
            matematicaUsor.AdaugaIntrebare(new IntrebareUnica("Cat face 100 impartit la 4?", new List<string> { "20", "25", "30", "40" }, 1));
            matematicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Patratul are 4 laturi egale.", true));
            matematicaUsor.AdaugaIntrebare(new IntrebareUnica("Care este formula ariei cercului?", new List<string> { "2*Pi*r", "Pi*r*r", "Pi*d", "2*Pi*r*r" }, 1));

            var matematicaMediu = new Categorie("Matematica - Mediu", Dificultate.Mediu);
            matematicaMediu.AdaugaIntrebare(new IntrebareUnica("Care este derivata lui x^2?", new List<string> { "x", "2x", "2", "x^2" }, 1));
            matematicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("log(a*b) = log(a) + log(b).", true));
            matematicaMediu.AdaugaIntrebare(new IntrebareUnica("Cat este sin(90)?", new List<string> { "0", "0.5", "1", "-1" }, 2));
            matematicaMediu.AdaugaIntrebare(new IntrebareUnica("Care este solutia ecuatiei x^2 - 4 = 0?", new List<string> { "x=2", "x=-2", "x=2 si x=-2", "x=4" }, 2));
            matematicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Orice numar ridicat la puterea 0 este 1.", true));
            matematicaMediu.AdaugaIntrebare(new IntrebareUnica("Cat este cos(0)?", new List<string> { "0", "1", "-1", "0.5" }, 1));
            matematicaMediu.AdaugaIntrebare(new IntrebareUnica("Care este aria unui triunghi cu baza 6 si inaltimea 4?", new List<string> { "24", "12", "10", "8" }, 1));
            matematicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Progresie geometrica inseamna ca ratia este constanta.", true));
            matematicaMediu.AdaugaIntrebare(new IntrebareUnica("Cat face 5! (5 factorial)?", new List<string> { "25", "60", "120", "100" }, 2));
            matematicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Determinantul unei matrice identitate este 1.", true));

            var matematicaGreu = new Categorie("Matematica - Greu", Dificultate.Greu);
            matematicaGreu.AdaugaIntrebare(new IntrebareUnica("Integrala lui e^x este?", new List<string> { "e^x + C", "x*e^x + C", "e^(x+1) + C", "1/e^x + C" }, 0));
            matematicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Limita lui sin(x)/x cand x->0 este 1.", true));
            matematicaGreu.AdaugaIntrebare(new IntrebareUnica("Care este formula lui Euler?", new List<string> { "e^(i*Pi) + 1 = 0", "e^(Pi) = 1", "i^2 = 1", "e = Pi" }, 0));
            matematicaGreu.AdaugaIntrebare(new IntrebareUnica("Derivata lui ln(x) este?", new List<string> { "ln(x)", "1/x", "x", "e^x" }, 1));
            matematicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Orice functie continua pe un interval inchis este integrala.", true));
            matematicaGreu.AdaugaIntrebare(new IntrebareUnica("Cat este rangul matricei identitate 3x3?", new List<string> { "1", "2", "3", "0" }, 2));
            matematicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Teorema lui Pitagora se aplica doar la triunghiuri dreptunghice.", true));
            matematicaGreu.AdaugaIntrebare(new IntrebareUnica("Care este numarul lui Euler e aproximativ?", new List<string> { "2.71", "3.14", "1.41", "1.73" }, 0));
            matematicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este un numar complex?", new List<string> { "a+bi unde i^2=-1", "a+bi unde i^2=1", "a*bi", "a/bi" }, 0));
            matematicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Seria lui Taylor aproximeaza functii prin polinoame.", true));

            // INFORMATICA
            var informaticaUsor = new Categorie("Informatica - Usor", Dificultate.Usor);
            informaticaUsor.AdaugaIntrebare(new IntrebareUnica("Ce inseamna CPU?", new List<string> { "Central Processing Unit", "Computer Power Unit", "Central Power Unit", "Core Processing Unit" }, 0));
            informaticaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("RAM inseamna Random Access Memory.", true));
            informaticaUsor.AdaugaIntrebare(new IntrebareUnica("Ce limbaj foloseste pagini web?", new List<string> { "C++", "HTML", "Java", "Python" }, 1));
            informaticaUsor.AdaugaIntrebare(new IntrebareUnica("Cate biti are un byte?", new List<string> { "4", "8", "16", "32" }, 1));
            informaticaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Un algoritm este o secventa finita de instructiuni.", true));
            informaticaUsor.AdaugaIntrebare(new IntrebareUnica("Ce este un browser?", new List<string> { "Un sistem de operare", "Un program pentru navigare web", "Un limbaj de programare", "O baza de date" }, 1));
            informaticaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Google Chrome este un browser web.", true));
            informaticaUsor.AdaugaIntrebare(new IntrebareUnica("Ce inseamna URL?", new List<string> { "Uniform Resource Locator", "Universal Remote Link", "Unique Resource Layer", "User Remote Locator" }, 0));
            informaticaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Python este un limbaj de programare.", true));
            informaticaUsor.AdaugaIntrebare(new IntrebareUnica("Ce este un fisier .exe?", new List<string> { "Un fisier text", "Un fisier executabil", "Un fisier imagine", "Un fisier audio" }, 1));

            var informaticaMediu = new Categorie("Informatica - Mediu", Dificultate.Mediu);
            informaticaMediu.AdaugaIntrebare(new IntrebareUnica("Ce complexitate are Binary Search?", new List<string> { "O(n)", "O(n^2)", "O(log n)", "O(1)" }, 2));
            informaticaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Un stack functioneaza pe principiul LIFO.", true));
            informaticaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este OOP?", new List<string> { "Object Oriented Programming", "Open Online Platform", "Ordered Output Process", "Object Output Protocol" }, 0));
            informaticaMediu.AdaugaIntrebare(new IntrebareUnica("Ce inseamna SQL?", new List<string> { "Structured Query Language", "Simple Queue Language", "System Query Logic", "Standard Question Language" }, 0));
            informaticaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("O clasa abstracta poate fi instantiata direct.", false));
            informaticaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este recursivitatea?", new List<string> { "O bucla infinita", "O functie care se apeleaza pe sine", "Un tip de date", "O structura de date" }, 1));
            informaticaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Git este un sistem de versionare a codului.", true));
            informaticaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este un API?", new List<string> { "Application Programming Interface", "Automated Process Integration", "Advanced Program Input", "Application Process Index" }, 0));
            informaticaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("JSON inseamna JavaScript Object Notation.", true));
            informaticaMediu.AdaugaIntrebare(new IntrebareUnica("Ce structura de date foloseste FIFO?", new List<string> { "Stack", "Queue", "Tree", "Graph" }, 1));

            var informaticaGreu = new Categorie("Informatica - Greu", Dificultate.Greu);
            informaticaGreu.AdaugaIntrebare(new IntrebareUnica("Ce complexitate are QuickSort in cazul mediu?", new List<string> { "O(n)", "O(n log n)", "O(n^2)", "O(log n)" }, 1));
            informaticaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Algoritmul lui Dijkstra functioneaza cu ponderi negative.", false));
            informaticaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este un deadlock?", new List<string> { "Un tip de eroare de sintaxa", "O situatie in care procese se blocheaza reciproc", "O metoda de sortare", "Un protocol de retea" }, 1));
            informaticaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Un arbore binar de cautare are complexitate O(log n) la cautare in cazul echilibrat.", true));
            informaticaGreu.AdaugaIntrebare(new IntrebareUnica("Ce inseamna SOLID in OOP?", new List<string> { "5 principii de design", "Un limbaj de programare", "O structura de date", "Un design pattern" }, 0));
            informaticaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este un Design Pattern Singleton?", new List<string> { "O clasa cu o singura instanta", "O clasa cu mai multe instante", "Un tip de mostenire", "O interfata" }, 0));
            informaticaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("TCP este un protocol connection-oriented.", true));
            informaticaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este garbage collection?", new List<string> { "Stergerea manuala a memoriei", "Gestionarea automata a memoriei", "Un algoritm de sortare", "Un tip de baza de date" }, 1));
            informaticaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("In C#, interfetele pot contine implementari de metode incepand cu C# 8.", true));
            informaticaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este un thread?", new List<string> { "Un proces independent", "Un fir de executie in cadrul unui proces", "Un tip de variabila", "O structura de date" }, 1));

            // FIZICA-USOR
            var fizicaUsor = new Categorie("Fizica - Usor", Dificultate.Usor);
            fizicaUsor.AdaugaIntrebare(new IntrebareUnica("Care este unitatea de masura a fortei?", new List<string> { "Watt", "Newton", "Joule", "Pascal" }, 1));
            fizicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Viteza luminii este aproximativ 300.000 km/s.", true));
            fizicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce este masa?", new List<string> { "Forta unui obiect", "Cantitatea de materie dintr-un obiect", "Volumul unui obiect", "Densitatea unui obiect" }, 1));
            fizicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Gravitatia pe Luna este mai mica decat pe Pamant.", true));
            fizicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce formula reprezinta legea lui Ohm?", new List<string> { "V = I * R", "V = I / R", "V = I + R", "V = I - R" }, 0));
            fizicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce este energia cinetica?", new List<string> { "Energia de pozitie", "Energia de miscare", "Energia termica", "Energia electrica" }, 1));
            fizicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Sunetul se propaga in vid.", false));
            fizicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce este temperatura masurata in?", new List<string> { "Newton", "Pascal", "Celsius", "Watt" }, 2));
            fizicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Apa fierbe la 100 de grade Celsius la presiune normala.", true));
            fizicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce este densitatea?", new List<string> { "Masa/Volum", "Volum/Masa", "Masa*Volum", "Masa+Volum" }, 0));
            
            // FIZICA MEDIU
            var fizicaMediu = new Categorie("Fizica - Mediu", Dificultate.Mediu);
            fizicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este acceleratia?", new List<string> { "Viteza/Timp", "Variatie viteza/Timp", "Forta/Masa", "Masa*Viteza" }, 1));
            fizicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Legea lui Newton spune ca F = m * a.", true));
            fizicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este impulsul?", new List<string> { "Forta*Timp", "Masa*Viteza", "Energie/Timp", "Forta/Acceleratie" }, 1));
            fizicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Energia se conserva intr-un sistem izolat.", true));
            fizicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este puterea in fizica?", new List<string> { "Forta*Distanta", "Energie/Timp", "Masa*Acceleratie", "Viteza/Timp" }, 1));
            fizicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este presiunea?", new List<string> { "Forta/Suprafata", "Masa/Volum", "Forta*Suprafata", "Energie/Volum" }, 0));
            fizicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Legea lui Arhimede se refera la forta de flotabilitate.", true));
            fizicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este lucrul mecanic?", new List<string> { "Forta*Distanta*cos(unghi)", "Masa*Acceleratie", "Viteza^2/2", "Forta/Timp" }, 0));
            fizicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Campul electric este produs de sarcini electrice.", true));
            fizicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este inductia electromagnetica?", new List<string> { "Producerea curentului prin camp magnetic variabil", "Producerea magnetismului prin curent", "Transferul de caldura", "Refractia luminii" }, 0));

            // FIZICA GREU
            var fizicaGreu = new Categorie("Fizica - Greu", Dificultate.Greu);
            fizicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce descrie ecuatia lui Schrodinger?", new List<string> { "Miscarea planetelor", "Comportamentul particulelor cuantice", "Campul gravitational", "Relativitatea" }, 1));
            fizicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Teoria relativitatii speciale apartine lui Einstein.", true));
            fizicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este un foton?", new List<string> { "O particula cu masa", "O cuanta de lumina fara masa", "Un electron excitat", "Un neutron" }, 1));
            fizicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Principiul incertitudinii apartine lui Heisenberg.", true));
            fizicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este entropia?", new List<string> { "Masura ordinii unui sistem", "Masura dezordinii unui sistem", "Energia interna", "Temperatura absoluta" }, 1));
            fizicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce afirma legea a doua a termodinamicii?", new List<string> { "Energia se conserva", "Entropia unui sistem izolat creste", "Forta egala reactiune", "Caldura trece de la cald la rece" }, 1));
            fizicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Viteza luminii este constanta in vid indiferent de observator.", true));
            fizicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este efectul fotoelectric?", new List<string> { "Emisia de electroni de catre metale la lumina", "Refractia luminii", "Difractia undelor", "Polarizarea luminii" }, 0));
            fizicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Undele gravitationale au fost detectate experimental.", true));
            fizicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este dualismul unda-corpuscul?", new List<string> { "Lumina se comporta atat ca unda cat si ca particula", "Electronii sunt doar unde", "Fotonii au masa", "Lumina este doar particula" }, 0));

            // CHIMIE-USOR
            var chimieUsor = new Categorie("Chimie - Usor", Dificultate.Usor);
            chimieUsor.AdaugaIntrebare(new IntrebareUnica("Care este simbolul chimic al aurului?", new List<string> { "Ag", "Au", "Al", "At" }, 1));
            chimieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("H2O este formula chimica a apei.", true));
            chimieUsor.AdaugaIntrebare(new IntrebareUnica("Cate elemente are tabelul periodic?", new List<string> { "98", "108", "118", "128" }, 2));
            chimieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Oxigenul are simbolul O.", true));
            chimieUsor.AdaugaIntrebare(new IntrebareUnica("Care este formula dioxidului de carbon?", new List<string> { "CO", "CO2", "C2O", "C2O2" }, 1));
            chimieUsor.AdaugaIntrebare(new IntrebareUnica("Ce este pH-ul?", new List<string> { "Masura aciditatii", "Masura temperaturii", "Masura densitatii", "Masura presiunii" }, 0));
            chimieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Sodiul are simbolul Na.", true));
            chimieUsor.AdaugaIntrebare(new IntrebareUnica("Care este cel mai usor element?", new List<string> { "Heliu", "Hidrogen", "Litiu", "Carbon" }, 1));
            chimieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Fierul are simbolul Fe.", true));
            chimieUsor.AdaugaIntrebare(new IntrebareUnica("Ce este o reactie chimica?", new List<string> { "Transformarea fizica a materiei", "Transformarea chimica a substantelor", "Modificarea temperaturii", "Schimbarea culorii" }, 1));

            // CHIMIE MEDIU
            var chimieMediu = new Categorie("Chimie - Mediu", Dificultate.Mediu);
            chimieMediu.AdaugaIntrebare(new IntrebareUnica("Ce este un izotop?", new List<string> { "Atom cu acelasi numar de protoni dar neutroni diferiti", "Atom cu acelasi numar de electroni", "Molecula cu aceeasi masa", "Ion cu sarcina diferita" }, 0));
            chimieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Reactiile de oxidare implica pierdere de electroni.", true));
            chimieMediu.AdaugaIntrebare(new IntrebareUnica("Ce este un acid?", new List<string> { "O substanta care accepta protoni", "O substanta care cedeaza protoni", "O substanta neutra", "O baza" }, 1));
            chimieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("pH-ul apei pure este 7.", true));
            chimieMediu.AdaugaIntrebare(new IntrebareUnica("Ce este o legatura covalenta?", new List<string> { "Transfer de electroni", "Punere in comun de electroni", "Atractie intre ioni", "Legatura metalica" }, 1));
            chimieMediu.AdaugaIntrebare(new IntrebareUnica("Ce este numarul de oxidare?", new List<string> { "Numarul de protoni", "Sarcina ionica aparenta a atomului", "Numarul de neutroni", "Masa atomica" }, 1));
            chimieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Legea conservarii masei apartine lui Lavoisier.", true));
            chimieMediu.AdaugaIntrebare(new IntrebareUnica("Ce este o reactie de neutralizare?", new List<string> { "Acid + Baza = Sare + Apa", "Metal + Acid = Sare + H2", "Oxidare + Reducere", "Polimerizare" }, 0));
            chimieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Carbonul poate forma 4 legaturi covalente.", true));
            chimieMediu.AdaugaIntrebare(new IntrebareUnica("Ce este o reactie exoterma?", new List<string> { "Absoarbe caldura", "Elibereaza caldura", "Nu implica caldura", "Implica lumina" }, 1));

            // CHIMIE GREU
            var chimieGreu = new Categorie("Chimie - Greu", Dificultate.Greu);
            chimieGreu.AdaugaIntrebare(new IntrebareUnica("Ce descrie legea lui Avogadro?", new List<string> { "Volume egale de gaze contin acelasi numar de molecule", "Masa se conserva", "Presiunea e proportionala cu temperatura", "Volumul e invers proportional cu presiunea" }, 0));
            chimieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Numarul lui Avogadro este aproximativ 6.022 x 10^23.", true));
            chimieGreu.AdaugaIntrebare(new IntrebareUnica("Ce este hibridizarea sp3?", new List<string> { "4 orbitali hibrizi dispusi tetrahedral", "3 orbitali hibrizi", "2 orbitali hibrizi", "1 orbital hibrid" }, 0));
            chimieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Benzena are formula moleculara C6H6.", true));
            chimieGreu.AdaugaIntrebare(new IntrebareUnica("Ce este entalpia?", new List<string> { "Continutul de caldura al unui sistem", "Entropia sistemului", "Energia cinetica", "Lucrul mecanic" }, 0));
            chimieGreu.AdaugaIntrebare(new IntrebareUnica("Ce este un catalizator?", new List<string> { "Substanta care creste energia de activare", "Substanta care scade energia de activare", "Reactant in reactie", "Produs al reactiei" }, 1));
            chimieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Polimerii sunt macromolecule formate din unitati repetitive.", true));
            chimieGreu.AdaugaIntrebare(new IntrebareUnica("Ce este electroliza?", new List<string> { "Reactie chimica spontana", "Descompunere prin curent electric", "Reactie de neutralizare", "Reactie de oxidare spontana" }, 1));
            chimieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("ADN-ul contine bazele adenina, guanina, citozina si timina.", true));
            chimieGreu.AdaugaIntrebare(new IntrebareUnica("Ce este legea lui Hess?", new List<string> { "Entalpia reactiei nu depinde de calea urmata", "Masa se conserva", "Presiunea e constanta", "Volumul e constant" }, 0));

            // GEOGRAFIE
            var geografieUsor = new Categorie("Geografie - Usor", Dificultate.Usor);
            geografieUsor.AdaugaIntrebare(new IntrebareUnica("Care este capitala Romaniei?", new List<string> { "Cluj", "Iasi", "Bucuresti", "Timisoara" }, 2));
            geografieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Dunarea se varsa in Marea Neagra.", true));
            geografieUsor.AdaugaIntrebare(new IntrebareUnica("Care este cel mai mare ocean?", new List<string> { "Atlantic", "Indian", "Arctic", "Pacific" }, 3));
            geografieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Muntele Everest este cel mai inalt munte din lume.", true));
            geografieUsor.AdaugaIntrebare(new IntrebareUnica("Pe ce continent se afla Romania?", new List<string> { "Asia", "Africa", "Europa", "America" }, 2));
            geografieUsor.AdaugaIntrebare(new IntrebareUnica("Care este capitala Frantei?", new List<string> { "Londra", "Berlin", "Paris", "Roma" }, 2));
            geografieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Amazonia este cel mai mare fluviu din lume.", true));
            geografieUsor.AdaugaIntrebare(new IntrebareUnica("Care este capitala Germaniei?", new List<string> { "Munchen", "Hamburg", "Frankfurt", "Berlin" }, 3));
            geografieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Australia este atat un continent cat si o tara.", true));
            geografieUsor.AdaugaIntrebare(new IntrebareUnica("Cate continente are Pamantul?", new List<string> { "5", "6", "7", "8" }, 2));


            // GEOGRAFIE MEDIU
            var geografieMediu = new Categorie("Geografie - Mediu", Dificultate.Mediu);
            geografieMediu.AdaugaIntrebare(new IntrebareUnica("Care este cel mai lung fluviu din lume?", new List<string> { "Amazon", "Nil", "Yangtze", "Mississippi" }, 1));
            geografieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Sahara este cel mai mare desert din lume.", true));
            geografieMediu.AdaugaIntrebare(new IntrebareUnica("Care este capitala Australiei?", new List<string> { "Sydney", "Melbourne", "Canberra", "Brisbane" }, 2));
            geografieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Japonia este o tara insulara.", true));
            geografieMediu.AdaugaIntrebare(new IntrebareUnica("Care este cel mai mare lac din lume?", new List<string> { "Lacul Superior", "Marea Caspica", "Lacul Victoria", "Lacul Baikal" }, 1));
            geografieMediu.AdaugaIntrebare(new IntrebareUnica("Pe ce continent se afla Etiopia?", new List<string> { "Asia", "America de Sud", "Africa", "Europa" }, 2));
            geografieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Brazilia este cea mai mare tara din America de Sud.", true));
            geografieMediu.AdaugaIntrebare(new IntrebareUnica("Care este capitala Canadei?", new List<string> { "Toronto", "Vancouver", "Montreal", "Ottawa" }, 3));
            geografieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Rusia este cea mai mare tara din lume ca suprafata.", true));
            geografieMediu.AdaugaIntrebare(new IntrebareUnica("Care este cel mai inalt varf din Europa?", new List<string> { "Mont Blanc", "Matterhorn", "Elbrus", "Monte Rosa" }, 2));

            // GEOGRAFIE GREU
            var geografieGreu = new Categorie("Geografie - Greu", Dificultate.Greu);
            geografieGreu.AdaugaIntrebare(new IntrebareUnica("Care este capitala Kazakhstanului?", new List<string> { "Almaty", "Astana", "Shymkent", "Karaganda" }, 1));
            geografieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Groenlanda apartine Danemarcei.", true));
            geografieGreu.AdaugaIntrebare(new IntrebareUnica("Care este cea mai adanca groapa oceanica?", new List<string> { "Groapa Puerto Rico", "Groapa Marianelor", "Groapa Tonga", "Groapa Java" }, 1));
            geografieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Ecuatorul trece prin Brazilia.", true));
            geografieGreu.AdaugaIntrebare(new IntrebareUnica("Care este cel mai mic stat din lume?", new List<string> { "Monaco", "San Marino", "Vatican", "Liechtenstein" }, 2));
            geografieGreu.AdaugaIntrebare(new IntrebareUnica("Care este capitala Myanmarului?", new List<string> { "Yangon", "Mandalay", "Naypyidaw", "Bago" }, 2));
            geografieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Lacul Baikal contine aproximativ 20% din apa dulce a lumii.", true));
            geografieGreu.AdaugaIntrebare(new IntrebareUnica("Care este cel mai populat oras din lume?", new List<string> { "Beijing", "Mumbai", "Tokyo", "Shanghai" }, 2));
            geografieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Stramtoarea Bering separa Asia de America.", true));
            geografieGreu.AdaugaIntrebare(new IntrebareUnica("Pe ce meridian se afla Greenwich?", new List<string> { "15", "0", "180", "90" }, 1));

            // ISTORIE
            var istorieUsor = new Categorie("Istorie - Usor", Dificultate.Usor);
            istorieUsor.AdaugaIntrebare(new IntrebareUnica("In ce an a avut loc Revolutia Franceza?", new List<string> { "1789", "1815", "1848", "1776" }, 0));
            istorieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Al Doilea Razboi Mondial s-a incheiat in 1945.", true));
            istorieUsor.AdaugaIntrebare(new IntrebareUnica("Cine a fost primul presedinte al SUA?", new List<string> { "Abraham Lincoln", "George Washington", "Thomas Jefferson", "John Adams" }, 1));
            istorieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Napoleon Bonaparte a fost imparat al Frantei.", true));
            istorieUsor.AdaugaIntrebare(new IntrebareUnica("In ce an a cazut Zidul Berlinului?", new List<string> { "1985", "1987", "1989", "1991" }, 2));
            istorieUsor.AdaugaIntrebare(new IntrebareUnica("Cine a descoperit America?", new List<string> { "Vasco da Gama", "Cristofor Columb", "Magellan", "Amerigo Vespucci" }, 1));
            istorieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Primul Razboi Mondial a inceput in 1914.", true));
            istorieUsor.AdaugaIntrebare(new IntrebareUnica("In ce an a avut loc Unirea Principatelor Romane?", new List<string> { "1848", "1859", "1877", "1918" }, 1));
            istorieUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Decebal a fost rege al dacilor.", true));
            istorieUsor.AdaugaIntrebare(new IntrebareUnica("Cine a fost primul om pe Luna?", new List<string> { "Buzz Aldrin", "Yuri Gagarin", "Neil Armstrong", "John Glenn" }, 2));

            // ISTORIE MEDIU
            var istorieMediu = new Categorie("Istorie - Mediu", Dificultate.Mediu);
            istorieMediu.AdaugaIntrebare(new IntrebareUnica("In ce an a inceput Al Doilea Razboi Mondial?", new List<string> { "1935", "1937", "1939", "1941" }, 2));
            istorieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Hitler a condus Germania Nazista.", true));
            istorieMediu.AdaugaIntrebare(new IntrebareUnica("Ce eveniment a declansat Primul Razboi Mondial?", new List<string> { "Invazia Poloniei", "Asasinarea arhiducelui Franz Ferdinand", "Revolutia Rusa", "Caderea Imperiului Otoman" }, 1));
            istorieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Imperiul Roman a cazut in anul 476 d.Hr.", true));
            istorieMediu.AdaugaIntrebare(new IntrebareUnica("Cine a condus URSS dupa Stalin?", new List<string> { "Brejnev", "Gorbaciov", "Hrusciov", "Andropov" }, 2));
            istorieMediu.AdaugaIntrebare(new IntrebareUnica("In ce an a avut loc Revolutia Rusa?", new List<string> { "1905", "1914", "1917", "1921" }, 2));
            istorieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Imperiul Mongol a fost cel mai mare imperiu terestru din istorie.", true));
            istorieMediu.AdaugaIntrebare(new IntrebareUnica("Cine a fost Cleopatra?", new List<string> { "Regina Greciei", "Regina Egiptului", "Regina Romei", "Regina Persiei" }, 1));
            istorieMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Razboiul de 100 de ani a fost intre Franta si Anglia.", true));
            istorieMediu.AdaugaIntrebare(new IntrebareUnica("In ce an Romania si-a castigat independenta?", new List<string> { "1859", "1866", "1877", "1918" }, 2));

            // ISTORIE GREU
            var istorieGreu = new Categorie("Istorie - Greu", Dificultate.Greu);
            istorieGreu.AdaugaIntrebare(new IntrebareUnica("In ce an a fost fondat Imperiul Roman?", new List<string> { "753 i.Hr.", "509 i.Hr.", "27 i.Hr.", "44 i.Hr." }, 2));
            istorieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Tratatul de la Versailles a pus capat Primului Razboi Mondial.", true));
            istorieGreu.AdaugaIntrebare(new IntrebareUnica("Cine a fost primul imparat al Chinei?", new List<string> { "Confucius", "Qin Shi Huang", "Kublai Han", "Sun Yat-sen" }, 1));
            istorieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Razboiul Peloponesiac a fost intre Atena si Sparta.", true));
            istorieGreu.AdaugaIntrebare(new IntrebareUnica("In ce an a fost cucerита Constantinopolul de otomani?", new List<string> { "1389", "1453", "1492", "1517" }, 1));
            istorieGreu.AdaugaIntrebare(new IntrebareUnica("Cine a scris Magna Carta?", new List<string> { "Regele Ioan al Angliei", "Regele Richard I", "Papa Inocentiu III", "Baronii englezi impreuna cu Regele Ioan" }, 3));
            istorieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Razboiul de 30 de ani a implicat majoritate statelor europene.", true));
            istorieGreu.AdaugaIntrebare(new IntrebareUnica("Ce civilizatie a construit Machu Picchu?", new List<string> { "Azteca", "Maya", "Inca", "Olmeca" }, 2));
            istorieGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Revolutia Industriala a inceput in Anglia.", true));
            istorieGreu.AdaugaIntrebare(new IntrebareUnica("Cine a fost Alexandru cel Mare?", new List<string> { "Imparat roman", "Rege macedonean", "Faraon egiptean", "Rege persan" }, 1));

            // SPORT
            var sportUsor = new Categorie("Sport - Usor", Dificultate.Usor);
            sportUsor.AdaugaIntrebare(new IntrebareUnica("Cati jucatori are o echipa de fotbal?", new List<string> { "9", "10", "11", "12" }, 2));
            sportUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Jocurile Olimpice au loc la fiecare 4 ani.", true));
            sportUsor.AdaugaIntrebare(new IntrebareUnica("Ce sport se joaca la Wimbledon?", new List<string> { "Golf", "Tenis", "Cricket", "Badminton" }, 1));
            sportUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Un meci de fotbal dureaza 90 de minute.", true));
            sportUsor.AdaugaIntrebare(new IntrebareUnica("Cati jucatori are o echipa de baschet?", new List<string> { "4", "5", "6", "7" }, 1));
            sportUsor.AdaugaIntrebare(new IntrebareUnica("In ce tara a aparut fotbalul modern?", new List<string> { "Franta", "Germania", "Anglia", "Spania" }, 2));
            sportUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Cupa Mondiala de Fotbal are loc la fiecare 4 ani.", true));
            sportUsor.AdaugaIntrebare(new IntrebareUnica("Ce sport joaca Roger Federer?", new List<string> { "Golf", "Tenis", "Baschet", "Inot" }, 1));
            sportUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Maratonul are aproximativ 42 km.", true));
            sportUsor.AdaugaIntrebare(new IntrebareUnica("Cati jucatori are o echipa de volei?", new List<string> { "5", "6", "7", "8" }, 1));

            // MUZICA
            var muzicaUsor = new Categorie("Muzica - Usor", Dificultate.Usor);
            muzicaUsor.AdaugaIntrebare(new IntrebareUnica("Cate note muzicale sunt in gama diatonica?", new List<string> { "5", "6", "7", "8" }, 2));
            muzicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Mozart a fost un compozitor austriac.", true));
            muzicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce instrument foloseste Beethoven ca simbol?", new List<string> { "Vioara", "Pian", "Chitara", "Flaut" }, 1));
            muzicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Beatles a fost o trupa britanica.", true));
            muzicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce nota urmeaza dupa Do?", new List<string> { "La", "Re", "Mi", "Sol" }, 1));
            muzicaUsor.AdaugaIntrebare(new IntrebareUnica("Cate corzi are o chitara clasica?", new List<string> { "4", "5", "6", "7" }, 2));
            muzicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Opera este un gen muzical cu voce si orchestra.", true));
            muzicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce este un metronom?", new List<string> { "Un instrument muzical", "Un dispozitiv care masoara tempo-ul", "Un tip de nota", "Un gen muzical" }, 1));
            muzicaUsor.AdaugaIntrebare(new IntrebareAdevaratFals("Michael Jackson a fost supranumit Regele Pop-ului.", true));
            muzicaUsor.AdaugaIntrebare(new IntrebareUnica("Ce gen muzical a aparut in Jamaica?", new List<string> { "Jazz", "Blues", "Reggae", "Rock" }, 2));

            // MUZICA MEDIU
            var muzicaMediu = new Categorie("Muzica - Mediu", Dificultate.Mediu);
            muzicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce instrument a folosit Jimi Hendrix?", new List<string> { "Bas", "Chitara electrica", "Pian", "Tobe" }, 1));
            muzicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Jazz-ul a aparut in SUA la inceputul secolului XX.", true));
            muzicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce compozitor a scris Simfonia a 9-a desi era surd?", new List<string> { "Mozart", "Bach", "Beethoven", "Brahms" }, 2));
            muzicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Freddie Mercury a fost solistul trupei Queen.", true));
            muzicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este o octava?", new List<string> { "7 note", "8 note", "Intervalul intre Do si Do urmator", "O gama muzicala" }, 2));
            muzicaMediu.AdaugaIntrebare(new IntrebareUnica("Cate simfonii a compus Beethoven?", new List<string> { "7", "8", "9", "10" }, 2));
            muzicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Elvis Presley este supranumit Regele Rock and Roll-ului.", true));
            muzicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce gen muzical a creat Bob Marley?", new List<string> { "Jazz", "Blues", "Reggae", "Soul" }, 2));
            muzicaMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Vioara are 4 corzi.", true));
            muzicaMediu.AdaugaIntrebare(new IntrebareUnica("Ce este un arpegiu?", new List<string> { "Note cantate simultan", "Note cantate succesiv dintr-un acord", "Un tip de ritm", "O tehnica de respiratie" }, 1));

            // MUZICA GREU
            var muzicaGreu = new Categorie("Muzica - Greu", Dificultate.Greu);
            muzicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este contrapunctul in muzica?", new List<string> { "Combinarea a doua sau mai multe melodii independente", "Un tip de ritm", "O tehnica de improvizatie", "Un instrument muzical" }, 0));
            muzicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Johann Sebastian Bach a trait in perioada Barocului.", true));
            muzicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este modalismul in muzica?", new List<string> { "Folosirea gamelor modale in loc de major/minor", "Un tip de ritm", "O tehnica de compozitie moderna", "O forma muzicala" }, 0));
            muzicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Stradivarius este un tip de vioara renumita.", true));
            muzicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este o fuga in muzica?", new List<string> { "O forma muzicala bazata pe imitatie", "Un tip de ritm rapid", "O tehnica de improvizatie", "Un gen vocal" }, 0));
            muzicaGreu.AdaugaIntrebare(new IntrebareUnica("Cate simfonii a compus Mozart?", new List<string> { "31", "41", "51", "61" }, 1));
            muzicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Serialismul este o tehnica de compozitie bazata pe serii de 12 sunete.", true));
            muzicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este un leitmotiv?", new List<string> { "O tema muzicala asociata cu un personaj", "Un tip de instrument", "O forma de sonata", "Un ritm specific" }, 0));
            muzicaGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Debussy este considerat un compozitor impresionist.", true));
            muzicaGreu.AdaugaIntrebare(new IntrebareUnica("Ce este o cadenta in muzica?", new List<string> { "O progresie de acorduri care incheie o fraza", "Un tip de ritm", "O tehnica vocala", "Un instrument de percutie" }, 0));
            // SPORT MEDIU
            var sportMediu = new Categorie("Sport - Mediu", Dificultate.Mediu);
            sportMediu.AdaugaIntrebare(new IntrebareUnica("Cate seturi are un meci de tenis la Grand Slam masculin?", new List<string> { "3", "4", "5", "6" }, 2));
            sportMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Usain Bolt detine recordul mondial la 100m.", true));
            sportMediu.AdaugaIntrebare(new IntrebareUnica("In ce sport se foloseste termenul birdie?", new List<string> { "Tenis", "Golf", "Badminton", "Cricket" }, 1));
            sportMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Michael Jordan a jucat pentru Chicago Bulls.", true));
            sportMediu.AdaugaIntrebare(new IntrebareUnica("Cate puncte valoreaza un touchdown in fotbal american?", new List<string> { "3", "5", "6", "7" }, 2));
            sportMediu.AdaugaIntrebare(new IntrebareUnica("In ce an au avut loc primele Jocuri Olimpice moderne?", new List<string> { "1892", "1896", "1900", "1904" }, 1));
            sportMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Formula 1 a fost fondata in 1950.", true));
            sportMediu.AdaugaIntrebare(new IntrebareUnica("Ce tara a castigat cele mai multe Cupe Mondiale de Fotbal?", new List<string> { "Germania", "Argentina", "Italia", "Brazilia" }, 3));
            sportMediu.AdaugaIntrebare(new IntrebareAdevaratFals("Nadia Comaneci a primit primul 10 perfect in gimnastica olimpica.", true));
            sportMediu.AdaugaIntrebare(new IntrebareUnica("Cate gauri are un teren de golf standard?", new List<string> { "9", "12", "18", "24" }, 2));

            // SPORT GREU
            var sportGreu = new Categorie("Sport - Greu", Dificultate.Greu);
            sportGreu.AdaugaIntrebare(new IntrebareUnica("Cine detine recordul de Grand Slamuri in tenis masculin?", new List<string> { "Rafael Nadal", "Roger Federer", "Novak Djokovic", "Pete Sampras" }, 2));
            sportGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Tour de France este cea mai veche cursa ciclista de etape.", true));
            sportGreu.AdaugaIntrebare(new IntrebareUnica("In ce an a castigat Romania Cupa Davis la tenis?", new List<string> { "1969", "1971", "1972", "1975" }, 1));
            sportGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Ayrton Senna a castigat 3 titluri mondiale in Formula 1.", true));
            sportGreu.AdaugaIntrebare(new IntrebareUnica("Cate medalii de aur a castigat Michael Phelps la Olimpiade?", new List<string> { "18", "20", "23", "25" }, 2));
            sportGreu.AdaugaIntrebare(new IntrebareUnica("In ce sport se practica tehnica Fosbury Flop?", new List<string> { "Saritura in lungime", "Saritura cu prajina", "Saritura in inaltime", "Triplusalt" }, 2));
            sportGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Wladimir Klitschko a detinut titlul mondial la box categoria grea.", true));
            sportGreu.AdaugaIntrebare(new IntrebareUnica("Ce tara a castigat primul Campionat Mondial de Rugby?", new List<string> { "Australia", "Noua Zeelanda", "Africa de Sud", "Anglia" }, 1));
            sportGreu.AdaugaIntrebare(new IntrebareAdevaratFals("Lance Armstrong a fost descalificat din toate titlurile Tour de France.", true));
            sportGreu.AdaugaIntrebare(new IntrebareUnica("Cate puncte valoreaza un drop goal in rugby?", new List<string> { "2", "3", "4", "5" }, 1));

            // Adauga toate categoriile
            categorii.Add(matematicaUsor);
            categorii.Add(matematicaMediu);
            categorii.Add(matematicaGreu);
            categorii.Add(informaticaUsor);
            categorii.Add(informaticaMediu);
            categorii.Add(informaticaGreu);
            categorii.Add(fizicaUsor);
            categorii.Add(fizicaMediu);
            categorii.Add(fizicaGreu);
            categorii.Add(chimieUsor);
            categorii.Add(chimieMediu);
            categorii.Add(chimieGreu);
            categorii.Add(geografieUsor);
            categorii.Add(geografieMediu);
            categorii.Add(geografieGreu);
            categorii.Add(istorieUsor);
            categorii.Add(istorieMediu);
            categorii.Add(istorieGreu);
            categorii.Add(sportUsor);
            categorii.Add(sportMediu);
            categorii.Add(sportGreu);
            categorii.Add(muzicaUsor);
            categorii.Add(muzicaMediu);
            categorii.Add(muzicaGreu);
        }
       

        // Meniu
        private void OnMenuAdauga(object sender, RoutedEventArgs e)
        {
            panelAdauga.Visibility = Visibility.Visible;
            panelCauta.Visibility = Visibility.Collapsed;
            panelModifica.Visibility = Visibility.Collapsed;
        }

        private void OnMenuCauta(object sender, RoutedEventArgs e)
        {
            panelAdauga.Visibility = Visibility.Collapsed;
            panelCauta.Visibility = Visibility.Visible;
            panelModifica.Visibility = Visibility.Collapsed;
        }

        private void OnMenuModifica(object sender, RoutedEventArgs e)
        {
            panelAdauga.Visibility = Visibility.Collapsed;
            panelCauta.Visibility = Visibility.Collapsed;
            panelModifica.Visibility = Visibility.Visible;

            // Incarca categoriile in ComboBox
            cmbCategorii.ItemsSource = null;
            cmbCategorii.ItemsSource = categorii;
        }

        // Validare
        private bool ValideazaDate()
        {
            bool esteValid = true;

            lblNume.Foreground = new SolidColorBrush(Color.FromRgb(137, 180, 250));
            tbErrNume.Visibility = Visibility.Collapsed;

            if (string.IsNullOrWhiteSpace(txtNume.Text) || txtNume.Text.Length > LUNGIME_MAX_NUME)
            {
                lblNume.Foreground = new SolidColorBrush(Color.FromRgb(243, 139, 168));
                tbErrNume.Visibility = Visibility.Visible;
                esteValid = false;
            }

            return esteValid;
        }

        private Dificultate GetDificultateSelectata()
        {
            if (rbMediu.IsChecked == true) return Dificultate.Mediu;
            if (rbGreu.IsChecked == true) return Dificultate.Greu;
            return Dificultate.Usor;
        }

        private Dificultate GetDificultateModifica()
        {
            if (rbMediuMod.IsChecked == true) return Dificultate.Mediu;
            if (rbGreuMod.IsChecked == true) return Dificultate.Greu;
            return Dificultate.Usor;
        }

        // Adauga
        private void OnAdauga(object sender, RoutedEventArgs e)
        {
            if (!ValideazaDate()) return;

            Dificultate dificultate = GetDificultateSelectata();
            Categorie categorie = new Categorie(txtNume.Text, dificultate);
            categorii.Add(categorie);

            tbSucces.Visibility = Visibility.Visible;
        }

        // Reset
        private void OnReset(object sender, RoutedEventArgs e)
        {
            txtNume.Text = string.Empty;
            rbUsor.IsChecked = true;
            ckbTimer.IsChecked = false;
            ckbImagini.IsChecked = false;
            ckbLeaderboard.IsChecked = false;

            lblNume.Foreground = new SolidColorBrush(Color.FromRgb(137, 180, 250));
            tbErrNume.Visibility = Visibility.Collapsed;
            tbSucces.Visibility = Visibility.Collapsed;
        }

        // Joaca
        private void OnMenuJoaca(object sender, RoutedEventArgs e)
        {
            panelAdauga.Visibility = Visibility.Collapsed;
            panelCauta.Visibility = Visibility.Collapsed;
            panelModifica.Visibility = Visibility.Collapsed;
            panelJoaca.Visibility = Visibility.Visible;

            lstCategoriiJoc.ItemsSource = null;
            lstCategoriiJoc.ItemsSource = categorii;
        }

        private void OnIncepeQuiz(object sender, RoutedEventArgs e)
        {
            if (lstCategoriiJoc.SelectedItem is not Categorie categorieSelectata ||
                string.IsNullOrWhiteSpace(txtNumeJucator.Text))
            {
                tbErrJoc.Visibility = Visibility.Visible;
                return;
            }

            tbErrJoc.Visibility = Visibility.Collapsed;

            Jucator jucator = new Jucator(txtNumeJucator.Text);
            QuizWindow quizWindow = new QuizWindow(categorieSelectata, jucator);
            quizWindow.ShowDialog();
        }

        // Cauta
        private void OnCauta(object sender, RoutedEventArgs e)
        {
            string nume = txtCauta.Text.ToLower().Trim();

            List<Categorie> rezultate = categorii
                .Where(c => c.Nume.ToLower().Contains(nume))
                .ToList();

            if (rezultate.Count == 0)
            {
                tbErrCauta.Visibility = Visibility.Visible;
                dgCategorii.Visibility = Visibility.Collapsed;
            }
            else
            {
                tbErrCauta.Visibility = Visibility.Collapsed;
                dgCategorii.Visibility = Visibility.Visible;
                dgCategorii.ItemsSource = rezultate;
            }
        }

        // Selectie categorie in ComboBox
        private void OnCategorieSelectata(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cmbCategorii.SelectedItem is Categorie cat)
            {
                txtNumeNou.Text = cat.Nume;

                // Seteaza dificultatea
                switch (cat.Dificultate)
                {
                    case Dificultate.Mediu: rbMediuMod.IsChecked = true; break;
                    case Dificultate.Greu: rbGreuMod.IsChecked = true; break;
                    default: rbUsorMod.IsChecked = true; break;
                }

                // Afiseaza intrebarile in ListBox
                lstIntrebari.ItemsSource = null;
                lstIntrebari.ItemsSource = cat.Intrebari;
            }
        }

        // Modifica
        private void OnModifica(object sender, RoutedEventArgs e)
        {
            if (cmbCategorii.SelectedItem is not Categorie cat)
            {
                tbErrModifica.Text = "Selectati o categorie!";
                tbErrModifica.Visibility = Visibility.Visible;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumeNou.Text) || txtNumeNou.Text.Length > LUNGIME_MAX_NUME)
            {
                lblNumeNou.Foreground = new SolidColorBrush(Color.FromRgb(243, 139, 168));
                tbErrModifica.Text = "Numele este obligatoriu (max 20 caractere)!";
                tbErrModifica.Visibility = Visibility.Visible;
                return;
            }

            cat.Nume = txtNumeNou.Text;
            cat.Dificultate = GetDificultateModifica();

            tbErrModifica.Visibility = Visibility.Collapsed;
            tbSuccesModifica.Visibility = Visibility.Visible;

            // Refresh ComboBox
            cmbCategorii.ItemsSource = null;
            cmbCategorii.ItemsSource = categorii;
        }
    }
}
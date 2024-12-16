namespace TPA;
{


    public class Angajat
        {
            public string Nume;
            public string Departament;
            public int Salariu;

            public Angajat(string nume, string departament, int salariu)
            {
                Nume = nume;
                Departament = departament;
                Salariu = salariu;
            }

            public void Afisare()
            {
                Console.WriteLine($"Angajatul {Nume} din departamentul {Departament}, are salariul de {Salariu}");
            }
        }
}




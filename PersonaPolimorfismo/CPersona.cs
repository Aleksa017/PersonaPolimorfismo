using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaPolimorfismo
{
    public class CPersona
    {
        protected string codiceFiscale;
        protected string nome;
        protected string cognome;

        public CPersona(string codiceFiscale, string nome, string cognome) 
        {
            this.codiceFiscale = codiceFiscale.ToUpper();
            this.nome = nome;
            this.cognome = cognome;
        }

        public void CambiaCodiceFiscale(string codiceFiscale) 
        {
            this.codiceFiscale = codiceFiscale.ToUpper();
        }

        public void CambiaDati(string nome, string cognome) 
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        public virtual string print() 
        {
            return $"Cod. fisc: {codiceFiscale}; Nome e cognome: {nome} {cognome}";
        }
    }

    public class CStudente : CPersona 
    {
        string matricola;
        string universita;

        public CStudente(string codiceFiscale, string nome, string cognome, string matricola, string universita) : base(codiceFiscale, nome, cognome) 
        {
            this.matricola = matricola;
            this.universita = universita;
        }

        public void CambiaMatricola(string matricola) 
        {
            this.matricola = matricola;
        }

        public void CambiaUniversita(string universita) 
        {
            this.universita = universita;
        }

        public override string print()
        {
            return $"Studente,\n\tCod. fisc: {codiceFiscale}; Nome e cognome: {nome} {cognome}; \n\tUniversità: {universita}; Matricola: {matricola}";
        }
    }

    public class CDocente : CPersona 
    {
        float salario;
        string materia;

        public CDocente (string codiceFiscale, string nome, string cognome, float salario, string materia) : base(codiceFiscale, nome, cognome) 
        {
            this.salario = salario;
            this.materia = materia;
        }

        public void CambiaSalario(float salario) 
        {
            this.salario = salario;
        }

        public void CambiaMateria(string materia) 
        {
            this.materia = materia;
        }

        public override string print()
        {
            return $"Docente,\n\tCod. fisc: {codiceFiscale}; Nome e cognome: {nome} {cognome};\n\tSalario: {salario} euro; Materia: {materia}";
        }
    }
}

// See https://aka.ms/new-console-template for more information
using PersonaPolimorfismo;

CPersona Persona = new CDocente("LDSHFLSKDH", "Alberto", "Frizz", 2.99f, "Telecomunicazioni");
CPersona Studente = new CStudente("JLBSAJSSRDPO3", "Giorgio", "Stonecutter", "1209467", "Università dei sudati di Napoli");

Persona.CambiaDati("Alberto", "Spritz");

Console.WriteLine(Persona.print());
Console.WriteLine(Studente.print());
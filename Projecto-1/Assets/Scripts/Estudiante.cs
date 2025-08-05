using UnityEngine;
using System;

namespace packagesPersona {
[Serializable]
    public class Estudiante : Persona
{
        private string codeE;
        private string nameCarreraE;

        public Estudiante()
        {
        }

        public Estudiante(string codeE, string namecarreraE, string nameP, string mailP, string dirP)
            :base(nameP, mailP, dirP)
        {
            this.codeE = codeE;
            this.nameCarreraE = namecarreraE;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NamecarreraE { get => nameCarreraE; set => nameCarreraE = value; }
        public string NameCarreraE { get; internal set; }
    }
}
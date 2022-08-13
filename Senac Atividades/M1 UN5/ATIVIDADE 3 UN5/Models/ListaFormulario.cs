using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATIVIDADE_3_UN5.Models
{
    public class ListaFormulario
    {
        static private List<Formulario> formulariolista = new List<Formulario>();


        public static void incluir(Formulario formulario1)
        {
            formulariolista.Add(formulario1);
        }

        public static List<Formulario> Listar()
        {
            return formulariolista;
        } 


    }
}
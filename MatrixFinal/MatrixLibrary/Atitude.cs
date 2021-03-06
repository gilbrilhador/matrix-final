///////////////////////////////////////////////////////////
//  Atitude.cs
//  Implementation of the Class Atitude
//  Generated by Enterprise Architect
//  Created on:      01-abr-2020 22:21:54
//  Original author: Geucimar
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace br.edu.up.mtx.domain {
	public class Atitude {
        public int Id { get; set; }
        [Display(Name = "T�tulo")]
        public string Nome { get; set; }
        [Display(Name = "Descri��o")]
        public string Descricao { get; set; }
        [Display(Name = "Compet�ncia")]
        public Competencia Competencia { get; set; }
        public Atividade Atividade { get; set; }

    }//end Atitude

}//end namespace br.edu.up.mtx.domain
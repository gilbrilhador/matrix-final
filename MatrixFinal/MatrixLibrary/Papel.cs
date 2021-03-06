///////////////////////////////////////////////////////////
//  Papel.cs
//  Implementation of the Class Papel
//  Generated by Enterprise Architect
//  Created on:      01-abr-2020 22:21:55
//  Original author: Geucimar
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace br.edu.up.mtx.domain {
	public class Papel {
		public int Id { get; set; }
		[Display(Name = "T�tulo")]
		public string Nome { get; set; }
		[Display(Name = "Descri��o")]
		public string Descricao { get; set; }
		public Perfil Perfil { get; set; }
		public ICollection<Atividade> Atividades { get; set; }
		[Display(Name = "Compet�ncias")]
		public ICollection<Competencia> Competencias { get; set; }
		public Matriz Matriz { get; set; }
	}//end Papel
}//end namespace br.edu.up.mtx.domain
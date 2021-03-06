///////////////////////////////////////////////////////////
//  Periodo.cs
//  Implementation of the Class Periodo
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
	public class Periodo {
		public int Id { get; set; }
		[Display(Name = "Identificação")]
		public string Nome { get; set; }
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }
		[Display(Name = "Períodos da trilha")]
		public ICollection<PeriodoDaTrilha> PeridosDaTrilha { get; set; }
		public ICollection<Disciplina> Disciplinas { get; set; }
		public Matriz Matriz { get; set; }
	}//end Periodo

}//end namespace br.edu.up.mtx.domain
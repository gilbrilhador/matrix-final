///////////////////////////////////////////////////////////
//  Competencia.cs
//  Implementation of the Class Competencia
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
	public class Competencia {
		public int Id { get; set; }
		[Display(Name = "T�tulo")]
		public string Nome { get; set; }
		[Display(Name = "Descri��o")]
		public string Descricao { get; set; }
		public Perfil Perfil { get; set; }
		public Papel Papel { get; set; }
		public ICollection<Habilidade> Habilidades { get; set; }
		public ICollection<Conhecimento> Conhecimentos { get; set; }
		[Display(Name = "Espec�ficas")]
		public ICollection<Competencia> Especificas { get; set; }
		public ICollection<Atitude> Atitudes { get; set; }
		public Atividade Atividade { get; set; }
		public Diretriz Diretriz { get; set; }
	}//end Competencia

}//end namespace br.edu.up.mtx.domain
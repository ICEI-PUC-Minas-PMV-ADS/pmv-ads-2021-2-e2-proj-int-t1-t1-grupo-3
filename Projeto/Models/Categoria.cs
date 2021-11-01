using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClientConnecting.Models
{
	[Table("Categoria")]

	public class Categoria
	{


		[Key]
		public int id { get; set; }

		public string Nome { get; set; }

		public int Codigo_Produto { get; set; }

		public string Descricao { get; set; }

	}

}
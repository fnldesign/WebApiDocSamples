using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDocsSamples.Models
{
    /// <summary>
    /// Representa um produto da Loja
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Código unico do Produto
        /// </summary>
        /// <remarks>Inteiro</remarks>
       public int codigo { get; set; }

        /// <summary>
        /// Nome do Produto
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// Categoria do Produto
        /// </summary>
        public CategoriaProduto categoria { get; set; }
    }
}
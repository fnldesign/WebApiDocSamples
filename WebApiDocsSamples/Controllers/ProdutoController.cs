using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDocsSamples.Controllers
{
    public class ProdutoController : ApiController
    {
        static List<Models.Produto> produtos;

        public ProdutoController()
        {
            if (produtos == null || produtos.Count <= 0)
            {
                List<Models.CategoriaProduto> categorias = new List<Models.CategoriaProduto>();
                categorias = new List<Models.CategoriaProduto>();
                categorias.Add(new Models.CategoriaProduto() { codigo = 1, nome = "Alimentos"});
                categorias.Add(new Models.CategoriaProduto() { codigo = 2, nome = "Eletro Domésticos" });

                produtos = new List<Models.Produto>();
                int idCategoria = 0;
                for (int i = 1; i <= 10; i++)
                {
                    idCategoria = i % 2;
                    produtos.Add(new Models.Produto() { nome = "Produto " + i.ToString(), codigo = i, categoria=categorias[idCategoria], ativo=true });
                }

            }
           
        }

        /// <summary>
        /// Obtêm todos os produtos
        /// </summary>
        /// <returns>Retorna uma lista com todos os produtos</returns>
        public List<Models.Produto> Get()
        {
            return produtos;
        }

        /// <summary>
        /// Obtêm um produto pelo codigo
        /// </summary>
        /// <param name="codigo">Código do Produto</param>
        /// <returns></returns>
        [HttpGet()]
        [Route("api/produto/{codigo}", Name ="GetProdutoByCodigo")]
        public Models.Produto GetByCodigo(int codigo)
        {
            return produtos[codigo - 1];
        }

        /// <summary>
        /// Insere um novo Produto
        /// </summary>
        /// <param name="novoProduto">Novo Produto as ser cadastrado</param>
        /// <returns></returns>
        /// <remarks>Erro 400 caso novoProduto seja nulo</remarks>
        public Models.Produto Post(Models.Produto novoProduto)
        {
            if (novoProduto == null) BadRequest("novoProduto é obrigatório");

            int codigoProdutoNovo = 1;
            if(produtos!=null && produtos.Count>0)
            {
                codigoProdutoNovo = produtos.Last().codigo + 1;
            }
            novoProduto.codigo = codigoProdutoNovo;
            produtos.Add(novoProduto);

            return novoProduto;
        }
    }
}

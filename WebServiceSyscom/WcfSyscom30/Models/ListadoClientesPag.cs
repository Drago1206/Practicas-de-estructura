﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfSyscom30.Models
{
    public class ListadoClientesPag
    {
        /// <summary>
        /// Página devuelta por la consulta actual.
        /// </summary>
        public int PaginaActual { get; set; }
        /// <summary>
        /// Número de registros de la página devuelta.
        /// </summary>
        public int RegistrosPorPagina { get; set; }
        /// <summary>
        /// Total de registros de consulta.
        /// </summary>
        public int TotalRegistros { get; set; }
        /// <summary>
        /// Total de páginas de la consulta.
        /// </summary>
        public int TotalPaginas { get; set; }
        public List<DatosCliente> Clientes { get; set; }
    }
}
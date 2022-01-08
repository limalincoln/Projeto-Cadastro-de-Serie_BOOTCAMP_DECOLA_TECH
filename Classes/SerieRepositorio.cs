﻿using Proj_APP_Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_APP_Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;  
        }




        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
           return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }

}


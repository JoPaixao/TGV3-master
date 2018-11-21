using eAgendaV3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eAgendaV3.servicer
{
    public class ItemsMaster
    {
        private static ObservableCollection<MasterPageItem> MenuLista { get; set; }
        private static ObservableCollection<MasterPageItem> PaginaInicial { get; set; }

        public static ObservableCollection<MasterPageItem> getMenuItens()
        {
            MenuLista = new ObservableCollection<MasterPageItem>();

            var pagina1 = new MasterPageItem() { titulo = "CS-Go", icon = "@drawable/Css.png", targtType = typeof(Jogos) };
            var pagina2 = new MasterPageItem() { titulo = "DotA2", icon = "@drawable/Dota.png", targtType = typeof(Jogos) };
            var pagina3 = new MasterPageItem() { titulo = "HearthStone", icon = "@drawable/HearthStone.png", targtType = typeof(Jogos) };
            var pagina4 = new MasterPageItem() { titulo = "LeagueOfLegends", icon = "@drawable/LeagueOFL.png", targtType = typeof(Jogos) };
            var pagina5 = new MasterPageItem() { titulo = "Smite", icon = "@drawable/Smite", targtType = typeof(Jogos) };
            var pagina6 = new MasterPageItem() { titulo = "StarCraft2", icon = "@drawable/Starcraft2.png", targtType = typeof(Jogos) };

            MenuLista.Add(pagina1);
            MenuLista.Add(pagina2);
            MenuLista.Add(pagina3);
            MenuLista.Add(pagina4);
            MenuLista.Add(pagina5);
            MenuLista.Add(pagina6);

            return MenuLista;
        }
        public static ObservableCollection<MasterPageItem> getPaginaInicial()
        {
            PaginaInicial = new ObservableCollection<MasterPageItem>();

            var pagina3 = new MasterPageItem() { titulo = "Pagina Inicial", icon = "P", targtType = typeof(Perfil) };

            PaginaInicial.Add(pagina3);

            return PaginaInicial;
        }



    }
}

using KSharpGui.MVC;
using System.Collections.Generic;
using System;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace KSharpGui.Control
{
    public class MainControl : ModelBase
    {

        public MainControl()
        {

        }
        private int _gruppenAnzahl;
        public int GruppenAnzahl {
            get
            {
                return _gruppenAnzahl;
            }
            set
            {
                _gruppenAnzahl = value;
            } }

        public string Mitglieder { get; set; }

        private List<RandomNameObject> _gruppenListe;
        public List<RandomNameObject> GruppenListe
        {
            get
            {
                return _gruppenListe;
            }
            set
            {
                _gruppenListe = value;
            }
        }

        private ICommand _clickRandom;
        public ICommand ClickRandom {
            get
            {
                return _clickRandom ?? (_clickRandom = new RelayCommand(canClickRandom, GenerateRandom));
            } }
        

          private void GenerateRandom(object obj)
        {
            var mitgliederListe = Mitglieder;
            GruppenListe = new List<RandomNameObject>();
            RandomNameObject name = new RandomNameObject();
            name.Name = string.Empty;

            for (int index = 0; index < mitgliederListe.Length; index++)
            {
                if(mitgliederListe[index] == ',')
                {
                    GruppenListe.Add(name);
                    name = new RandomNameObject();
                    name.Name = string.Empty;
                }
                if (mitgliederListe[index] != ' ' && mitgliederListe[index] != ',')
                {
                    name.Name = name.Name.Insert(name.Name.Length, mitgliederListe[index].ToString());
                }                
            }
            GruppenListe.Add(name);
            GenerateGroups();
            OnPropertyChanged("GruppenListe");   
        }

        private void GenerateGroups()
        {
            if(GruppenAnzahl <= 0)
            {
                return;
            }
            if (GruppenListe.Count <= 0)
            {
                return;                                
            }
            if (GruppenListe.Count % GruppenAnzahl == 0)
            {
                Shuffle.Mischle<RandomNameObject>(GruppenListe);

                int groesse = GruppenListe.Count / GruppenAnzahl;
                int gruppenzahl = 0;
                for (int i = 0; i < GruppenAnzahl; i++)
                {
                    if(i != 0)
                    {
                        gruppenzahl = groesse * i;
                    }
                    else
                    {
                        gruppenzahl = groesse;
                    }
                    
                    if (GruppenListe[(gruppenzahl)].Gruppe != 0)
                    {
                        for (int j = gruppenzahl; j < gruppenzahl; j++)
                        {
                            GruppenListe[j].Gruppe = i;
                            gruppenzahl = j;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < groesse; j++)
                        {
                            GruppenListe[j].Gruppe = i;
                            gruppenzahl = j;
                        }
                    }


                }              
            }
            else
            {
                return;
            }
        }




        private bool canClickRandom(object obj)
        {
            return true;
        }
    }

    public static class Shuffle
    {
        public static void Mischle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}

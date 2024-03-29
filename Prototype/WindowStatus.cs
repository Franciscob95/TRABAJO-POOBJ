﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace Prototype
{
    public static class WindowStatus
    {
        public static void Writer(Imagen desx)
        {

            Console.WriteLine("1 Name:"+ desx.Nombre);
            Console.WriteLine("2 Date:" + desx.Fecha);
            string s = "3 Tags: ";
            for (int t = 0; t < desx.Tags.Count; t++)
            {
                if (t == 0)
                {
                 s = s  + desx.Tags[t].Name;
                }
                else
                {
                 s = s + "," + desx.Tags[t].Name;
                }
                
            }
            Console.WriteLine(s);
            Console.WriteLine("4 Path:" + desx.Direccionmemoria);
            Console.WriteLine("5 id: " + desx.Id);
            Console.WriteLine("6 Ranking: " + desx.Ranking);
            
            Console.WriteLine("Please input the enter key to choose again");

            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop-8);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1 );
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.SetCursorPosition(0, Console.CursorTop - 8);

            //Console.Write(new string(' ', Console.WindowWidth));//
            //Console.Clear();//




        }
        public static string ShowSearch(List<string> sea)
        {
            string p = "";
            int counter = 0;
            foreach (string se in sea)
            {
                if (counter == sea.Count - 1)
                {
                    p = p + se;
                    return p;
                }
                p = p + se + "/";
                counter++;
            }
            return p;
        }
        public static List<List<string>> FilterSearch(Filtros search,List<Imagen> BD)
        {
            List<List<string>> Searchgo = new List<List<string>>();
            List<string> Stag = new List<string>();
            List<string> Sperson = new List<string>();
            List<string> Scharacte = new List<string>();
            List<string> Ssaturation = new List<string>();
            List<string> Sresolution = new List<string>();
            List<string> Saspect = new List<string>();
            List<string> Srating = new List<string>();
            for (int i = 0; i < BD.Count; i++)
            {
                if (BD[i].Tags[0].Name==search.Tags[0].Name)
                {
                    Stag.Add(BD[i].Direccionmemoria);
                }
                if (BD[i].Persona[0].Nombre==search.Personas[0].Nombre)
                {
                    Sperson.Add(BD[i].Direccionmemoria);
                }
                if (BD[i].Chara.Contains(search.Characteristic[0]))
                {
                    Scharacte.Add(BD[i].Direccionmemoria);
                }
                if (BD[i].Saturacion==search.Saturation[0])
                {
                    Ssaturation.Add(BD[i].Direccionmemoria);
                }
                if (BD[i].Resolucion==search.Resolution[0])
                {
                    Sresolution.Add(BD[i].Direccionmemoria);
                }
                if (BD[i].Realcionaspecto==search.Aspectratio[0])
                {
                    Saspect.Add(BD[i].Direccionmemoria);
                }
                if (BD[i].Ranking==search.Rating[0])
                {
                    Srating.Add(BD[i].Direccionmemoria);
                }
            }
            Searchgo.Add(Stag);
            Searchgo.Add(Sperson);
            Searchgo.Add(Scharacte);
            Searchgo.Add(Ssaturation);
            Searchgo.Add(Sresolution);
            Searchgo.Add(Saspect);
            Searchgo.Add(Srating);
            return Searchgo;


        }
    }
}

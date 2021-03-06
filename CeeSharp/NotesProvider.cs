﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeSharp
{
    public static class NotesProvider
    {
        public static Note A = new Note("A");
        public static Note Ash = new Note("A#");
        public static Note B = new Note("B");
        public static Note C = new Note("C");
        public static Note Csh = new Note("C#");
        public static Note D = new Note("D");
        public static Note Dsh = new Note("D#");
        public static Note E = new Note("E");
        public static Note F = new Note("F");
        public static Note Fsh = new Note("F#");
        public static Note G = new Note("G");
        public static Note Gsh = new Note("G#");
        public static List<Note> Notes = new List<Note> { A, Ash, B, C, Csh, D, Dsh, E, F, Fsh, G, Gsh };

        public static Note GetTarget(Note prev, int dist)
        {
            int i = Notes.IndexOf(prev);
            if ((i += dist) > 11)
            {
                i -= 12;
            }
            return Notes[i];
        }

        public static Note GetNoteByName(string s)
        {
            foreach(Note n in Notes)
            {
                if (n.Name == s)
                    return n;
            }
            return null;
        }
    }

    public class Note
    {
        public string Name { get; }
        public Note(string n)
        {
            Name = n;
        }
    }
}
﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace Carnac
{
    public static class ReplaceKey
    {
        private static readonly Dictionary<Keys, string> Replacements = new Dictionary<Keys, string>
                                                                   {
                                                                       {Keys.D0, "0"},
                                                                       {Keys.D1, "1"},
                                                                       {Keys.D2, "2"},
                                                                       {Keys.D3, "3"},
                                                                       {Keys.D4, "4"},
                                                                       {Keys.D5, "5"},
                                                                       {Keys.D6, "6"},
                                                                       {Keys.D7, "7"},
                                                                       {Keys.D8, "8"},
                                                                       {Keys.D9, "9"},
                                                                       {Keys.NumPad0, "0"},
                                                                       {Keys.NumPad1, "1"},
                                                                       {Keys.NumPad2, "2"},
                                                                       {Keys.NumPad3, "3"},
                                                                       {Keys.NumPad4, "4"},
                                                                       {Keys.NumPad5, "5"},
                                                                       {Keys.NumPad6, "6"},
                                                                       {Keys.NumPad7, "7"},
                                                                       {Keys.NumPad8, "8"},
                                                                       {Keys.NumPad9, "9"},

                                                                       {Keys.OemMinus, "-"},
                                                                       {Keys.Oemplus, "+"},
                                                                       {Keys.OemBackslash, "/"},
                                                                       {Keys.OemQuestion, "?"},
                                                                       {Keys.OemPeriod, "."},

                                                                       {Keys.LShiftKey, "Shift"},
                                                                       {Keys.RShiftKey, "Shift"},

                                                                       {Keys.LWin, "Win"},
                                                                       {Keys.RWin, "Win"},
                                                                   };
        public static string Sanitise(this Keys key)
        {
            return Replacements.ContainsKey(key) ? Replacements[key] : string.Format(key.ToString());
        }
    }
}
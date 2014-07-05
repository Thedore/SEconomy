﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wolfje.Plugins.SEconomy.Journal;

namespace Wolfje.Plugins.SEconomy {
    public static class ConsoleEx {
        static readonly object __consoleWriteLock = new object();

		public static void WriteBar(JournalLoadingPercentChangedEventArgs args)
		{
			StringBuilder output = new StringBuilder();
			int fillLen = 0;

			output.Append(" ");
			for (int i = 0; i < 10; i++) {
				char c = i < args.Label.Length ? args.Label[i] : ' ';
				output.Append(c);
			}
			
			output.Append(" [");
			
			fillLen = Convert.ToInt32(((decimal)args.Percent / 100) * 60);

			for (int i = 0; i < 60; i++) {
				output.Append(i <= fillLen ? "#" : " ");
			}

			output.Append("] ");
			output.Append(args.Percent + "%");

			Console.Write("\r");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(output.ToString());
			Console.ResetColor();
		}

		public static void WriteAtEnd(int Padding, ConsoleColor Colour, string MessageFormat, params object[] args)
		{
			lock (__consoleWriteLock) {
				string s = string.Format(MessageFormat, args);

				try {
					ConsoleColor origColour = Console.ForegroundColor;
					Console.ForegroundColor = Colour;
					Console.SetCursorPosition(Console.WindowWidth - s.Length - Padding, Console.CursorTop);
					Console.Write(s);
					Console.ForegroundColor = origColour;
				} catch {
					Console.Write(s);
				}
			}
		}

    }
}

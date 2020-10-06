﻿using System;
using System.Windows;

namespace MinimalistMusicPlayer.Utility
{
	public class Const
	{
		// window heights when the playlist is collapsed/expanded
		public const int CollapsedWindowHeight = 155;
		public const int ExpandedWindowHeight = 615;

		public const int ExplorerItemWidth = 430;
		public const int ExplorerItemIconWidth = 25;
		public const int ExplorerItemIconHeight = 25;

		// Uri where the IWMPPlaylist will be created each time the app starts
		public const string PlaylistUri = @"";
		public static string DefaultMediaDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

		// track info max lengths (for ellipsizing purposes)
		public const int TrackNameMaxLength = 20;
		public const int TrackInfoMaxLength = 40;

		public const int ExplorerItemMaxLength = 60;

		// volume levels
		public const double VolumeMid = 50;
		// volume increment
		public const double VolumeIncrement = 5;

		public const int SeekDivisor = 25;

		// array that contains a list supported music extensions
		public static string[] MediaExtensions = { ".mp3", ".wma", ".wav", ".m4b" };

		public const string BreadcrumbButtonSeparator = "/";

		public static char[] DirectorySeparators = { '/', '\\' };

		public const int InvalidIndex = -1;

		public static class OpacityLevel
		{
			public const int Opaque = 1;
			public const int Transparent = 0;
		}

		public static class DrillScale
		{
			public const double In = .85;
			public const double Normal = 1;
			public const double Out = 1.15;
		}

		public static class ExplorerMargin
		{
			public static Thickness CurrentPage = new Thickness(0, 32, 0, 0);
			public static Thickness RightPage = new Thickness(500, 32, -500, 0);
			public static Thickness LeftPage = new Thickness(-500, 32, 500, 0);
		}

		public const string Root = "Computer";
		public const string ExplorerDirectorySetting = "ExplorerDirectory";

		public const double ShowHideDelay = .2; // in seconds
		public const double AsyncDelay = 5; // in millis
		public const double DrillAnimDuration = .2; // in seconds
	}
}

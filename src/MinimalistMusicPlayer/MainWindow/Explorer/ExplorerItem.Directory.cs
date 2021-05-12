﻿using MinimalistMusicPlayer.Utility;
using System.Linq;
using System.Windows.Controls;

namespace MinimalistMusicPlayer.Explorer
{
	public class DirectoryItem : ExplorerItem
	{
		public string Directory { get; set; }

		// Directory item constructor
		public DirectoryItem(string directory)
		{
			// set item type
			ItemType = ExplorerItemType.DirectoryItem;

			Directory = directory;

			Grid contentGrid = new Grid()
			{
				Width = Constant.ExplorerItemWidth
			};

			Button buttonIcon = CreateIcon(Icons.Directory);
			contentGrid.Children.Add(buttonIcon);

			TextBlock labelTitle = CreateTitleLabel(directory.Split(Constant.DirectorySeparators).Last());
			contentGrid.Children.Add(labelTitle);

			Content = contentGrid;
		}
	}
}

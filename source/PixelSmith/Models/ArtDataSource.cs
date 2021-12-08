using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Models
{
	public class ArtDataSource
	{

		public static string GetDailyArtQuote(int quoteID)
		{

			switch (quoteID)
			{
				case 1:
					return "You don’t take a photograph, you make it. - Ansel Adams";
				case 2:
					return "Creativity takes courage. - Henri Matisse";
				default:
					return "Painting is easy when you don’t know how, but very difficult when you do. - Edgar Degas.";


			}

		}
		public static List<ArtProject> GetArtProjects()
		{
			var temp = new List<ArtProject>();
			ArtProject art = null;


			art = new ArtProject {ArtName = "Clarity at Dawn", Price = 1450M, ForSale = false, Image = "Images/abstractArt01.png"};
			temp.Add(art);

			art = new ArtProject {ArtName = "Tapestrano", Price = 600M, ForSale = true, Image = "Images/abstractArt02.png"};
			temp.Add(art);

			art = new ArtProject {ArtName = "Missing Memories", Price = 5500M, ForSale = true, Image = "Images/abstractArt03.png"};
			temp.Add(art);

			art = new ArtProject {ArtName = "Pentaminology", Price = 125M, ForSale = true, Image = "Images/abstractArt04.png"};
			temp.Add(art);

			art = new ArtProject {ArtName = "Lavender Whisper", Price = 680M, ForSale = true, Image = "Images/abstractArt05.png"};

			temp.Add(art);

			art = new ArtProject {ArtName = "Portaments", Price = 450M, ForSale = true, Image = "Images/abstractArt06.png"};

			temp.Add(art);
			art = new ArtProject {ArtName = "Watching 12", Price = 450M, ForSale = true, Image = "Images/abstractArt07.png"};
			temp.Add(art);
			return temp;
		}
	}

	public class ArtProject
	{
		public string ArtName {get; set;}
		public bool ForSale {get; set;}
		public decimal Price {get; set;}
		public string Image {get; set;}
	}


}
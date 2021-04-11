
using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Threading.Tasks;

namespace Chloride
{
	[ClassLibrary]
	public partial class Hud : Sandbox.Hud
	{
		public Hud()
		{
			if ( !IsClient )
				return;

			RootPanel.StyleSheet.Load( "/ui/Hud.scss" );

			RootPanel.AddChild<ChatBox>();
			RootPanel.AddChild<Scoreboard>();
		}
	}
}

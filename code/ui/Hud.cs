using Sandbox;
using Sandbox.UI;

namespace Chloride
{
	/// <summary>
	/// Main HUD panel
	/// </summary>
	[Library]
	public partial class Hud : HudEntity<RootPanel>
	{
		/// <summary>
		/// Create hud Panel
		/// </summary>
		public Hud()
		{
			if ( IsClient )
			{
				RootPanel.SetTemplate( "/ui/Hud.scss" );
			}
		}
	}

}

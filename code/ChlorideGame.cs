using Sandbox;

namespace Chloride
{
	/// <summary>
	/// Chloride is an action-packed hovercraft flying game.
	/// </summary>
	[Library( "chloride", Title = "Chloride" )]
	public partial class ChlorideGame : Game
	{

		/// <summary>
		/// Construct the Chloride Game
		/// </summary>
		public ChlorideGame()
		{
			if ( IsServer )
			{
				new Hud();
			}
			if ( IsClient )
			{
				Log.Info( "[Cl] Chloride started Clientside" );
			}
		}
		public override void ClientJoined( Client cl )
		{
			ChloridePlayer player = new();


			cl.Pawn = player;

			base.ClientJoined( cl );
			player.Respawn();
		}
	}
}

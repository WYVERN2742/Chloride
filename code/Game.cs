using Sandbox;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chloride
{
	[ClassLibrary( "chloride", Title = "Chloride" )]
	partial class Game : Sandbox.Game
	{
		public static Game Instance
		{
			get => Current as Game;
		}

		public Game()
		{
			if ( IsServer )
			{
				Hud = new Hud();
			}
		}

		public override void DoPlayerNoclip( Sandbox.Player player )
		{
			// Do nothing. The player can't noclip in this mode.
		}

		public override void DoPlayerSuicide( Sandbox.Player player )
		{
			// Do nothing. The player can't suicide in this mode.
		}

		public override void PlayerDisconnected( Sandbox.Player player, NetworkDisconnectionReason reason )
		{
			Log.Info( player.Name + " left.");
			base.PlayerDisconnected( player, reason );
		}
	}
}

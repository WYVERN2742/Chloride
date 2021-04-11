using Sandbox;
using System;
using System.Linq;

namespace Chloride
{
	public partial class Player : BasePlayer
	{
		public Player()
		{
		}

		[OwnerRpc]
		protected void UpdateFps( int fps )
		{
			SetScore( "fps", fps );
		}
	}
}

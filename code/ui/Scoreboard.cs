using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace Chloride
{
	public class Scoreboard : Sandbox.UI.Scoreboard<ScoreboardEntry>
	{
		public Scoreboard()
		{
			StyleSheet.Load( "/ui/Scoreboard.scss" );
		}

		protected override void AddHeader()
		{
			Header = Add.Panel( "header" );
			Header.Add.Label( "player", "name" );
			Header.Add.Label( "ping", "ping" );
			Header.Add.Label( "fps", "fps" );
		}
	}

	public class ScoreboardEntry : Sandbox.UI.ScoreboardEntry
	{
		public Label FPS;

		public ScoreboardEntry()
		{
			FPS = Add.Label( "", "fps" );
		}

		public override void UpdateFrom( PlayerScore.Entry entry )
		{
			base.UpdateFrom( entry );

			FPS.Text = entry.Get<int>( "fps", 0 ).ToString();
		}
	}
}

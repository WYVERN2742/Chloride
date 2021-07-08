namespace Sandbox
{
	[Library]
	public class HovercraftController : BasePlayerController
	{
		public float DefaultSpeed { get; set; } = 150.0f;
		public float Acceleration { get; set; } = 20.0f;

		public HovercraftController()
		{
		}

		public override void Simulate()
		{
			float fvel = Input.Forward;

			if ( Input.Down( InputButton.Run ) )
			{
				fvel *= 10.0f;
			}

			Vector3 vel = (Input.Rotation.Forward * fvel) + (Input.Rotation.Left * Input.Left);

			vel = vel.Normal * 2000;

			if ( Input.Down( InputButton.Duck ) )
			{
				vel *= 0.2f;
			}

			Velocity += vel * Time.Delta;

			Velocity = Velocity.WithZ( 0.0f );
			if ( Velocity.LengthSquared > 0.01f )
			{
				Position += Velocity * Time.Delta;
			}

			Velocity = Velocity.Approach( 20, Velocity.Length * Time.Delta * 0.7f );


			EyeRot = Input.Rotation;
			WishVelocity = Velocity;
		}
	}
}

using Path = Stump.Server.WorldServer.Game.Maps.Pathfinding.Path;

namespace Stump.Server.WorldServer.Game.Actors.Interfaces
{
	public interface IAutoMovedEntity
	{
		DateTime NextMoveDate
		{
			get;
			set;
		}
		DateTime LastMoveDate
		{
			get;
		}

		bool StartMove(Path path);
	}
}
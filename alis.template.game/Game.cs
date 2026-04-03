using Alis.Core.Ecs.Systems;

namespace Alis.Template.Game
{
    /// <summary>
    /// The game class
    /// </summary>
    public static class Game
    {
        /// <summary>
        /// Creates this instance
        /// </summary>
        /// <returns>The video game</returns>
        public static VideoGame Create(string[] args)
        {
             return VideoGame.Create().Build();
        }
    }
}

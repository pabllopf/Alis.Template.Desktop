using Alis.Core.Aspect.Math.Definition;
using Alis.Core.Ecs;
using Alis.Core.Ecs.Components.Collider;
using Alis.Core.Ecs.Components.Render;
using Alis.Core.Ecs.Systems;
using Alis.Core.Physic.Dynamics;

namespace Alis.Template.Desktop
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

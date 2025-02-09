﻿#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

#endregion

namespace DoD_23_24
{
	public class World
	{
		Player player;
		Haris haris;

        public World()
		{
			player = new Player("/Content/2D/Ninja.png", new Vector2(Globals.WIDTH / 2, Globals.HEIGHT / 2), new Vector2(50, 50), true);
        }

		public virtual void Update(GameTime gameTime)
		{
			player.Update(gameTime);
		}

		public virtual void Draw()
		{
			player.Draw();
		}


	}
}


using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace kingsvalley1
{
   public class AnimatedSprite
    {
        private int[] xValue = { 0, 18, 36, 54, 72, 90, 108, 126 };
        protected int i = 0;
        private float timer = 0;
        private Explorer explorer;
        public AnimatedSprite(Explorer explorer)
        {
            this.explorer = explorer;
        }


        public virtual void Update(GameTime gameTime)
        {
          
            this.timer += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (this.timer > 5f / 60f)
            {
                this.i++;
                this.timer = 0f;
                if (this.i > 7)
                {
                    this.i = 0;


                }
            }
            Console.WriteLine(this.timer);
        }
        public virtual void Draw(GameTime gameTime)
        {
            this.explorer.Game.SpriteBatch.Draw(this.explorer.Texture,
                                          this.explorer.Rectangle,
                                          new Rectangle(this.xValue[this.i], 0, 18, 32),
                                          Color.White,
                                          0f,
                                          Vector2.Zero,
                                          SpriteEffects.None,
                                          0f);
        }
    }
}

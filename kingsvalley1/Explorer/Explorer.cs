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

namespace kingsvalley1.Explorer
{
   public class Explorer
    {
       //Fields
       private KingsValley1 game;
       private Vector2 position;
       private Texture2D texture;
       private Rectangle rectangle;
       
       public Explorer(KingsValley1 game, Vector2 position)
       {
           this.game = game;
           this.position = position;
           this.texture = game.Content.Load<Texture2D>(@"Explorer\explorer");
           this.rectangle = new Rectangle((int)this.position.X,(int)this.position.Y, this.texture.Width, this.texture.Height);
       }
       
       public void Update()
       {

       }
       
       public void Draw(GameTime gameTime)
       {
           this.game.SpriteBatch.Draw(this.texture,
                                      this.rectangle,
                                      new Rectangle(0,0,18,32),
                                      Color.White,
                                      0f,
                                      Vector2.Zero,
                                      SpriteEffects.None,
                                      0f);
       }
       
    }
}

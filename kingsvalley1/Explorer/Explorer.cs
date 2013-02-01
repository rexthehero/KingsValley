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
   public class Explorer
    {
       //Fields
       private KingsValley1 game;
       private Vector2 position;
       private Texture2D texture;
       private Rectangle rectangle;
       private int[] xValue = { 0, 18, 36, 54, 72, 90, 108, 126 };
       private int i = 0;
       private float timer = 0;
       private float speed = 1;
       private ExplorerWalkRight state;

       public Vector2 Position
       {
           get { return this.position; }
           set { 
               this.position = value;
               this.rectangle.X = (int)this.position.X;
               this.rectangle.Y = (int)this.position.Y;
           }
       }
       public float Speed
       {
           get { return this.speed; }
       }
       public Explorer(KingsValley1 game, Vector2 position)
       {
           this.game = game;
           this.position = position;
           this.texture = game.Content.Load<Texture2D>(@"Explorer\man");
           this.rectangle = new Rectangle((int)this.position.X,(int)this.position.Y, this.texture.Width / 8, this.texture.Height);
           this.state = new ExplorerWalkRight(this);
       }
       
       public void Update(GameTime gameTime)
       {
           this.state.Update(gameTime);
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
       public void Draw(GameTime gameTime)
       {
           this.game.SpriteBatch.Draw(this.texture,
                                      this.rectangle,
                                      new Rectangle(this.xValue[this.i],0,18,32),
                                      Color.White,
                                      0f,
                                      Vector2.Zero,
                                      SpriteEffects.None,
                                      0f);
           this.state.Draw(gameTime);
       }
       
    }
}

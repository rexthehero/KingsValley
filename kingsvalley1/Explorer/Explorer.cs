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
       private float speed = 1;
    c
       private AnimatedSprite state;
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
       public KingsValley1 Game
       {
           get { return this.game; }
       }
       public Texture2D Texture
       {
           get { return this.texture; }
       }
       public Rectangle Rectangle
       {
           get { return this.rectangle; }
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
           

               
           
       
       }
       public void Draw(GameTime gameTime)
       {
         
           this.state.Draw(gameTime);
       }
       
    }
}

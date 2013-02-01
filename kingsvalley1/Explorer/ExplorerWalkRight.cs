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
   public class ExplorerWalkRight : AnimatedSprite
    {
       private Explorer explorer;
   

       public ExplorerWalkRight(Explorer explorer) : base(explorer)
       {
           this.i = 3;
           this.explorer = explorer;
           
      

       }
       public override void Update(GameTime gameTime)
       {
           this.explorer.Position += new Vector2(this.explorer.Speed, 0f);
           base.Update(gameTime);
       }
       public override void Draw(GameTime gameTime)

       {
           base.Draw(gameTime);
       }
    }
}

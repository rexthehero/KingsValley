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
    //
    //Just a commit test
    public class KingsValley1 : Microsoft.Xna.Framework.Game
    {
      private GraphicsDeviceManager graphics;
      private SpriteBatch spriteBatch;
      private Explorer explorer;
        
        public KingsValley1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        public SpriteBatch SpriteBatch
        {
            get { return this.spriteBatch; }
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;
            this.Window.Title = "Kings valley 1";
            this.graphics.PreferredBackBufferWidth = 640;
            this.graphics.PreferredBackBufferHeight = 480;
            this.graphics.ApplyChanges();
            base.Initialize();
        }
        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);
            this.explorer = new Explorer(this, new Vector2(100f, 300f));
        
        }

     
        protected override void UnloadContent()
        {
            
        }

   
        protected override void Update(GameTime gameTime)
        {
           
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

         

            base.Update(gameTime);
        }

     
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(6,6,6));
            this.spriteBatch.Begin();
            this.explorer.Draw(gameTime);
            this.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

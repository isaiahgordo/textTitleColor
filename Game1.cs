﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace textTitleColor
{
    public class Game1 : Game
    {
        Rectangle maxRect = new Rectangle(0, 0, 800, 500),minRect=new Rectangle(0,0,100,100);
        Texture2D dinotexture,seagul2d;
        Point mousePoint;
        SpriteFont sprite;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinotexture=Content.Load<Texture2D>("dino (2)");
            seagul2d = Content.Load<Texture2D>("seaguls");
            sprite = Content.Load<SpriteFont>("Arial");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            else if (Keyboard.GetState().IsKeyDown(Keys.A))
            {                
                mousePoint = Mouse.GetState().Position;
                _spriteBatch.Begin();
                _spriteBatch.DrawString(sprite,mousePoint.ToString(),new Vector2(400,0),Color.Blue);
                _spriteBatch.End();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(seagul2d,maxRect, Color.White);
            _spriteBatch.Draw(dinotexture, minRect, Color.Red);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
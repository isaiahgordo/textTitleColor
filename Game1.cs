using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Timers;

namespace textTitleColor
{
    public class Game1 : Game
    {
        Vector2 dinospeed = new Vector2(2, 2),speedonib= new Vector2(-2,-2);
        Rectangle maxRect = new Rectangle(0, 0, 800, 500), minRect = new Rectangle(0, 0, 100, 100), tceRnim = new Rectangle(700, 0, 100, 100), size = new Rectangle();
        Texture2D dinotexture,seagul2d,textureonib;
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
            textureonib = Content.Load<Texture2D>("onib");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here

            var kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.A))
                mousePoint = Mouse.GetState().Position;
            else if (kstate.IsKeyDown(Keys.D))
            {
                minRect.Y = mousePoint.Y;
                minRect.X = mousePoint.X;
                tceRnim.Y = mousePoint.Y;
                tceRnim.X = mousePoint.X+100;
            }
            
            
                
            
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(seagul2d,maxRect,Color.White);
            _spriteBatch.Draw(dinotexture, minRect, Color.White); 
            _spriteBatch.DrawString(sprite, mousePoint.ToString(), new Vector2(400, 0), Color.Blue);
            _spriteBatch.Draw(textureonib, tceRnim, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
        
    }
}
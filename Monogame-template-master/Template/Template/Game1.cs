using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static int Height;
        public static int Width;
        //player
        Texture2D plane;
        Rectangle playerPos;
        //background
        Texture2D background;
        Vector2 backgroundpos;
        //bullets
        List<Bullet> bullets = new List<Bullet>();
        Texture2D bulletTexture;
        


        //Komentar
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Height = graphics.PreferredBackBufferHeight = 1080;
            Width =  graphics.PreferredBackBufferWidth = 1920;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            playerPos = new Rectangle(new Point(0, 0), new Point(180, 135));
            playerPos.Y = graphics.PreferredBackBufferHeight - playerPos.Height;
            playerPos.X = graphics.PreferredBackBufferWidth / 2 - playerPos.Width / 2;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            background = Content.Load<Texture2D>("spacebild");
            plane = Content.Load<Texture2D>("lasercannon");
            bulletTexture = Content.Load<Texture2D>("Bullet");
            // TODO: use this.Content to load your game content here 
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        public void Updatebullets()
        {
            foreach(Bullet bullet in bullets)
            {
                bullet.Update();
            }
            for (int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].IsVisable)
                {
                    bullets.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Shoot()
        {
            Bullet newBullet = new Bullet(bulletTexture, playerPos.Location.ToVector2());

            bullets.Add(newBullet);
        }
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
          
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.D) && playerPos.X < graphics.PreferredBackBufferWidth - playerPos.Width)
                playerPos.X += 20;
            if (kstate.IsKeyDown(Keys.A) && playerPos.X > 0)
                playerPos.X -= 20;

            Updatebullets();

            if (kstate.IsKeyDown(Keys.Space))
            {
                Shoot();
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();
            Rectangle backgroundRec = new Rectangle();
            backgroundRec.Location = backgroundpos.ToPoint();
            backgroundRec.Size = new Point(Width,Height);
            spriteBatch.Draw(background, new Rectangle(0, 0, Width, Height), Color.White);
            spriteBatch.Draw(plane,playerPos, Color.White);
            foreach (Bullet bullet in bullets)
                bullet.Draw(spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here.

            base.Draw(gameTime);
        }
    }
}

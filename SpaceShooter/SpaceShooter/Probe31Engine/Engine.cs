using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Probe31Engine
{
  
    public class Engine : Game
    {
        SpriteBatch spriteBatch;               
        public static Engine Instance { get; private set; }
        public static GraphicsDeviceManager Graphics { get; private set; }
        public static int Width { get; private set; }
        public static int Height { get; private set; }
        
        public Engine(int width, int height, int scale, string windowTitle, bool isFullscreen)
        {
            Engine.Instance = this;
            this.Window.Title = windowTitle;
            Engine.Width = width;
            Engine.Height = height;
            Engine.Graphics = new GraphicsDeviceManager(this);
            Engine.Graphics.PreferMultiSampling = false;
           
            if (isFullscreen)
            {
                Engine.Graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
                Engine.Graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
                Engine.Graphics.IsFullScreen = true;
            }
            else
            {
                Engine.Graphics.PreferredBackBufferWidth = width * scale;
                Engine.Graphics.PreferredBackBufferHeight = height * scale;
                Engine.Graphics.IsFullScreen = false;
            }

            Engine.Graphics.ApplyChanges();

            Content.RootDirectory = "Content";
            this.IsMouseVisible = false;
        }

        
        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

       
        protected override void UnloadContent()
        {
        }

       
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            base.Draw(gameTime);
        }
    }
}

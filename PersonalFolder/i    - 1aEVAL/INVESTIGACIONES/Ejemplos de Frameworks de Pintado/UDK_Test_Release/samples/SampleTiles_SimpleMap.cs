using UDK;

namespace UDK_Test
{
    public class SampleTiles_SimpleMap : IGameDelegate
    {
        enum SpriteClass
        {
            UNKNOWN, ZELDA, WATER, WATER_LIMIT, GRASS_CLAIR, GRASS_DARK
        }

        enum TileStates
        {
            WATER_QUIET, WATER_MOVEMENT, GRASS_DARK, IN_WATER_OUT_GRASS_DARK, IN_GRASS_CLAIR_OUT_GRASS_DARK
        }

        ImageDatabase? database;
        TileWorld tileWorld = new TileWorld(40, 20, new aabb2d_f64(0.0, 0.0, 40.0, 30.0));
        vec2d_f64 pjPosition = new vec2d_f64(10.0, 10.0);

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            tileWorld.SetupCamera(canvas, pjPosition, 5.0, 3.0, 3.0, true);
            tileWorld.Draw(canvas, 0.0, 0.0);

            canvas.FillShader.SetColor(new rgba_f64(0.0, 0.0, 1.0, 1.0));
            canvas.Transform.SetIdentity();
            canvas.DrawRectangle(new rect2d_f64(pjPosition.x, pjPosition.y, 1.0, 1.0));
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Right)) pjPosition.x += 0.01;
            if (keyboard.IsKeyDown(Keys.Left))  pjPosition.x -= 0.01;
            if (keyboard.IsKeyDown(Keys.Up))    pjPosition.y += 0.01;
            if (keyboard.IsKeyDown(Keys.Down))  pjPosition.y -= 0.01;
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            database = new ImageDatabase(gameEvent.canvasContext);
            var mapSet = SpriteLoaderUtils.LoadSpriteSetFromFile("resources/map/map_set.json", database, typeof(TileStates));
            var layer = SpriteLoaderUtils.LoadLayerFromFile("resources/map/layer_ground.json", mapSet, typeof(TileStates), typeof(SpriteClass));
            tileWorld.AddLayer(layer, 0, 0);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            tileWorld?.Animate(gameEvent.animationEngine);
        }
    }
}

using UDK;

namespace UDK_Test
{
    public class SampleTiles_SimpleMapWithAnimation : IGameDelegate
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

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            tileWorld.SetupCamera(canvas, new vec2d_f64(), 5.0, 3.0, 3.0, true);
            tileWorld.Draw(canvas, 0.0, 0.0);
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            database = new ImageDatabase(gameEvent.canvasContext);
            var waterSet = SpriteLoaderUtils.LoadSpriteSetFromFile("resources/map/map_set.json", database, typeof(TileStates));
            var layer = SpriteLoaderUtils.LoadLayerFromFile("resources/map/layer_ground.json", waterSet, typeof(TileStates), typeof(SpriteClass));
            tileWorld.AddLayer(layer, 0, 0);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            SpriteInstance? instance = tileWorld?.GetRandomInstance();
            if (instance != null && instance.Class == (int)SpriteClass.WATER && instance.State.CurrentSequence == (int)TileStates.WATER_QUIET)
            {
                instance.SetSequence(new SpriteSequenceSelector((int)TileStates.WATER_MOVEMENT)
                {
                    EndId = (int)TileStates.WATER_QUIET
                });
            }
            tileWorld?.Animate(gameEvent.animationEngine);
        }
    }
}

namespace UDK_Test;

class Program
{
    static void Main(string[] args)
    {
        //UDK.Game.Launch(new SampleAnimation_SimpleSynchronizedTimer());
        //UDK.Game.Launch(new SampleAnimation_SimpleLambdaTimer());
        //UDK.Game.Launch(new SampleAnimation_Path2D());
        //UDK.Game.Launch(new SampleCanvas_SimpleImage());
        //UDK.Game.Launch(new SampleCanvas_SimpleText());
        //UDK.Game.Launch(new SampleCanvas_ImageDatabase());
        //UDK.Game.Launch(new SampleCanvas_FullSample());
        UDK.Game.Launch(new SampleSprites_SimpleAnimation());
        //UDK.Game.Launch(new SampleSprites_SimpleFollowPath());
        //UDK.Game.Launch(new SampleTiles_SimpleMap());
        //UDK.Game.Launch(new SampleTiles_SimpleMapWithAnimation());
        //UDK.Game.Launch(new SampleInput_Joystick8());
    }
}


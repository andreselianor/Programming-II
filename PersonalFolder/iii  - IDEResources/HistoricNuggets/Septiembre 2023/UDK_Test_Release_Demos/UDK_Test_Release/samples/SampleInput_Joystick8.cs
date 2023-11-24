using UDK;

namespace UDK_Test
{
    public class SampleInput_Joystick8 : IGameDelegate
    {
        KeyboardJoystick8 joystick = new KeyboardJoystick8(Keys.Up, Keys.Down, Keys.Left, Keys.Right);

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            var state = joystick.Update(keyboard);

            switch (state)
            {
                case KeyboardJoystick8.State.UP:
                    Console.WriteLine("Pressed - UP");
                    break;
                case KeyboardJoystick8.State.DOWN:
                    Console.WriteLine("Pressed - DOWN");
                    break;
                case KeyboardJoystick8.State.UP_LEFT:
                    Console.WriteLine("Pressed - UP_LEFT");
                    break;
                case KeyboardJoystick8.State.DOWN_LEFT:
                    Console.WriteLine("Pressed - DOWN_LEFT");
                    break;
                case KeyboardJoystick8.State.LEFT:
                    Console.WriteLine("Pressed - LEFT");
                    break;
                case KeyboardJoystick8.State.UP_RIGHT:
                    Console.WriteLine("Pressed - UP_RIGHT");
                    break;
                case KeyboardJoystick8.State.DOWN_RIGHT:
                    Console.WriteLine("Pressed - DOWN_RIGHT");
                    break;
                case KeyboardJoystick8.State.RIGHT:
                    Console.WriteLine("Pressed - RIGHT");
                    break;
                default:
                    switch (joystick.Last)
                    {
                        case KeyboardJoystick8.State.UP:
                            Console.WriteLine("Released from - UP");
                            break;
                        case KeyboardJoystick8.State.DOWN:
                            Console.WriteLine("Released from - DOWN");
                            break;
                        case KeyboardJoystick8.State.UP_LEFT:
                            Console.WriteLine("Released from - UP_LEFT");
                            break;
                        case KeyboardJoystick8.State.DOWN_LEFT:
                            Console.WriteLine("Released from - DOWN_LEFT");
                            break;
                        case KeyboardJoystick8.State.LEFT:
                            Console.WriteLine("Released from - LEFT");
                            break;
                        case KeyboardJoystick8.State.UP_RIGHT:
                            Console.WriteLine("Released from - UP_RIGHT");
                            break;
                        case KeyboardJoystick8.State.DOWN_RIGHT:
                            Console.WriteLine("Released from - DOWN_RIGHT");
                            break;
                        case KeyboardJoystick8.State.RIGHT:
                            Console.WriteLine("Released from - RIGHT");
                            break;
                    }
                    break;
            }
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }
    }
}

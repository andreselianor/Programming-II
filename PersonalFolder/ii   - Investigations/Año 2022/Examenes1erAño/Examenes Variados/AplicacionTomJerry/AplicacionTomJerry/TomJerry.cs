using DAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTomJerry
{
    public class TomJerry : DAM.IGameDelegate
    {
        Character cat;
        Character mouse;

        float blue = 0.0f;
        float incrementX = 0.0f;

        float time = 0.0f;
        float shading = 0.0f;

        float endGame = 0.0f;

         

        /*public  static Character GenerateChar(float w, float h, float x, float y)
        {
            Character char1 = new Character();
            char1.w = w;
            char1.h = h;
            char1.type = CharacterType.MOUSE;
            char1.x = x;
            char1.y = y;
            
            return char1;
        }*/

        public void OnDraw(IAssetManager manager, IWindow window, ICanvas canvas)
        {
            //color de fondo del canvas
            canvas.Clear(0.0f, 0.8f, 0.8f, 1f);

            //canvas.FillRectangle(0.0f, 0.0f, 10.0f, 10.0f, 1.0f, 0.0f, 0.0f, 1.0f);
            canvas.SetCamera(-5.0f, -5.0f, 5.0f, 5.0f, true);

            
            //variables de animacion
            time = (1.0f / 60.0f) + shading;
            double animation = Math.Sin(time);
            double animation2 = (animation + 1.0) / 2.0;

            //creacion de aspect ratio
            //float aspectRatio = ((float)window.Width) / ((float)window.Height);

            //float ratio1 = ((float)window.Height * (mouse.h/2f)) /(float)window.Height;
            //float ratio1 = ((float)window.Height * (mouse.h)) /(float)window.Height;
            //float ratio2 = (float)window.Width / (float)window.Height;


            //funciones de creacion de personajes
            cat.Render(canvas);
            mouse.Render(canvas);

            cat.a = (float)animation2;
            cat.x = (float)animation2;

            bool end = false;
            end = Collision.IsCollide(mouse.x - mouse.w / 2, mouse.y - mouse.h / 2, mouse.x + mouse.w / 2, mouse.y + mouse.h / 2, cat.x - cat.w / 2, cat.y - cat.h / 2, cat.x + cat.w / 2, cat.y + cat.h / 2);
            if(end == true)
            {
                mouse.r = 1.0f;
                mouse.g = 0.0f;
                mouse.b = 0.0f;
            }
            else
            {
                mouse.r = 1.0f;
                mouse.g = 1.0f;
                mouse.b = 0.0f;
            }

            
           // canvas.FillRectangle(0 - 0, 0 - 0, 1, 1, imageb, 0.0f, 0.0f, 1.0f, 1.0f, 1, 1, 1, 1);

            // canvas.FillRectangle(0.0f, 0.0f, 1.0f, 1.0f, mouse.imgM, 0.0f, 0.0f, 1.1f, 1.1f, 1.0f, 1.0f, 1.0f, 0.9f);
            /* double time = 0.0;
             double i = 0.0;
             time = (1.0 / 60.0) + i;
             double animation = Math.Sin(time);
             double animation2 = (animation + 1.0) / 2;*

             cat.a = (float)animation2;
             i++;*/

            //i+=1;
            //canvas.FillRectangle(mouse.x - (ratio1 / ratio2) / 2, mouse.y - (ratio1) / 2, ratio1 / ratio2, ratio1, mouse.r, mouse.g, mouse.b, mouse.a);

            //canvas.FillRectangle(0.0f, -0.2f, 0.4f, 0.4f, 0, 0.5f, 0.2f, 1);
            //canvas.FillRectangle(cat.x-cat.width/2, cat.y-cat.height/2, cat.width, cat.height, 0.0f, 1.0f, 0.0f, 1.0f);
            /*canvas.FillRectangle(incrementX, -0.2f, 0.4f, 0.4f, 0, 0.5f, 0.2f, 1);
            this.blue += 0.001f;
            this.incrementX += 0.001f;
            Character cat;
            cat = new Character();
            cat.width = 1.0f;
            cat.height = 1.0f;*/


            shading += 0.001f;
            incrementX += 0.001f;
        }

        public void OnKeyboard(IAssetManager manager, IWindow window, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Right))
                this.cat.x += 0.001f;
            if (keyboard.IsKeyDown(Keys.Left))
                this.cat.x -= 0.001f;
            if (keyboard.IsKeyDown(Keys.Up))
                this.cat.y += 0.001f;
            if (keyboard.IsKeyDown(Keys.Down))
                this.cat.y -= 0.001f;

            if (keyboard.IsKeyDown(Keys.A))
                this.mouse.x -= 0.001f;
            if (keyboard.IsKeyDown(Keys.D))
                this.mouse.x += 0.001f;
            if (keyboard.IsKeyDown(Keys.W))
                this.mouse.y += 0.001f;
            if (keyboard.IsKeyDown(Keys.S))
                this.mouse.y -= 0.001f;

            //limite de superficie
            float LX = 2.0f;
            float LY = 2.0f;


            if (this.cat.x > LX)
            {
                this.cat.x = LX;
            }
            if (this.cat.x < -LX)
            {
                this.cat.x = -LX;
            }
            if (this.cat.y > LY)
            {
                this.cat.y = LY;
            }
            if (this.cat.y < -LY)
            {
                this.cat.y = -LY;
            }



            if (this.mouse.x > LX)
            {
                this.mouse.x = LX;
            }
            if (this.mouse.x < -LX)
            {
                this.mouse.x = -LX;
            }
            if (this.mouse.y > LY)
            {
                this.mouse.y = LY;
            }
            if (this.mouse.y < -LY)
            {
                this.mouse.y = -LY;
            }


            if (keyboard.IsKeyDown(Keys.Escape))
            {
                window.Close();
            }
        }

        public void OnLoad(IAssetManager manager, IWindow window)
        {


            //Image imgM = IAssetManager.LoadImage("C:\\Users\\yveelilop\\Desktop\\programming\\programming\\Practicas para Javi\\AplicacionTomJerry\\00imagenes");

            //Los valores de posicion tiene un rango de -1 a 1;
            //Los valores de Width y Heigth tienen un rango de 0 a 2;
            //DAM.Image image1 = manager.LoadImage("resources/gato01.png");



            /*DAM.Image imageb = new DAM.Image(1,1,1,true);
            imageb = manager.LoadImage("resources/fondo01.jpg");
            FillRectangle(0 - 0,0 - 0, 1, 1, imageb, 0.0f, 0.0f, 1.0f, 1.0f, 1, 1, 1, 1);
            /*float aspectRB = (float)imageb.Width / (float)background.Height;
            imageb.Width = 1.0;
            imageb.Height = background.Width / aspectRB;*/

            DAM.Image imageb = new DAM.Image(1, 1, 1, true);
            imageb = manager.LoadImage("resources/fondo01.jpg");

            mouse = new Character();

            mouse.img = manager.LoadImage("resources/raton02.png");
            float aspectRM = (float)mouse.img.Width / (float)mouse.img.Height;

            mouse.x = 0f;
            mouse.y = 0f;
            mouse.w = 1.0f;
            mouse.h = mouse.w / aspectRM;
            mouse.r = 1.0f;
            mouse.g = 1.0f;
            mouse.b = 0.0f;
            mouse.a = 0.9f;
            mouse.type = CharacterType.MOUSE;
            

            cat = new Character();
            
            cat.img = manager.LoadImage("resources/gato01.png");
            float aspectRC = (float)cat.img.Width / (float)cat.img.Height;

            cat.x = 0.0f;
            cat.y = 0.0f;
            cat.w = 1.0f;
            cat.h = cat.w / aspectRC;
            cat.r = 1.0f;
            cat.g = 0.0f;
            cat.b = 0.0f;
            cat.a = 1.0f;
            cat.type = CharacterType.CAT;
            
            
            
            //window.ToggleFullscreen();

        }

        public void OnUnload(IAssetManager manager, IWindow window)
        {

        }


    }
}

using DAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTomJerry
{
    public enum CharacterType
    {
        CAT, MOUSE
    }
    public class Character
    {
        public CharacterType type;
        public float x;
        public float y;
        public float w;
        public float h;
        public float r;
        public float g;
        public float b;
        public float a;
        public DAM.Image img;
        


        public void Render(ICanvas canvas)
        {
            canvas.FillRectangle(this.x - this.w / 2, this.y - this.h / 2, this.w, this.h, this.img, 0.0f, 0.0f, 1.0f, 1.0f, this.r, this.g, this.b, this.a);
            //canvas.FillRectangle(this.x - this.w / 2, this.y - this.h / 2, this.w, this.h, this.r, this.g, this.b, this.a);
        }

    }
}

using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoArgentino.Utils
{
    public class BallPoint
    {
        private const short MAX_AMOUNT_INK = 100;
        private ConsoleColor _colour;
        private short _ink;

        public BallPoint(short ink, ConsoleColor colour)
        {
            _ink = ink;
            _colour = colour;
        }

        public ConsoleColor GetColour() => this._colour;
        public short GetINK() => this._ink;
        public void SetINK(short ink)
        {
            if(ink > 0 && ink <= MAX_AMOUNT_INK)
            {
                this._ink = ink;
            }
        }
        public void Reload() => SetINK(MAX_AMOUNT_INK);
        public bool Paint(short cost, out string draw)
        {
            StringBuilder sb = new StringBuilder();
            if (GetINK() != 0)
            {
                if(GetINK() >= cost)
                {
                    draw = fillPainting(cost, sb);
                    this._ink -= cost;
                }
                else
                {
                    draw = fillPainting(GetINK(), sb);
                    this._ink -= GetINK();
                }
            }
            else
            {
                draw = string.Empty;
            }
            return true;
        }
        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"-> Boligrafo de color {GetColour().ToString()}\n")
                .Append($"-> Nivel de tinta: {GetINK()}").Append("\n")
                .Append($"-> Maximo nivel de tinta permitido: {MAX_AMOUNT_INK}").Append("\n");


            return sb.ToString();
        }
        private string fillPainting(short amount, StringBuilder draw)
        {
            for (var i = 0; i < amount; i++)
            {
                draw.Append("*");
            }
            return draw.ToString();
        }
      
    }
}

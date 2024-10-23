using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Task1
{
    public class Display
    {
        private int _width;
        private int _height;
        private float _ppi;
        private string? _model;

        public int width { get { return _width; } }
        public int height { get { return _height; } }
        public float ppi { get { return _ppi; } }
        public string? model { get { return _model; } }

        public Display(int width, int height, float ppi, string? model) {
            _width = width;
            _height = height;
            _ppi = ppi;
            _model = model;
        }

        public void compareSize(Display m) {
            Console.WriteLine(width*height < m.width*m.height ? $"The display {model} is smaller than {m.model}" : (width * height != m.width * m.height) ? $"The display {model} is bigger than {m.model}": $"The display {model} has the same size as {m.model}");
        }

        public void compareSharpness(Display m) { 
            Console.WriteLine(ppi < m.ppi ? $"The display {model} is not sharper than {m.model}" :(ppi != m.ppi)? $"The display {model} is sharper than {m.model}": $"The display {model} has the same sharpness as {m.model}");
        }

        public void compareWithMonitor(Display m) {
            Console.WriteLine(((width*height < m.width*m.height) ? $"The display {model} is smaller than {m.model}" : (width * height != m.width * m.height) ? $"The display {model} is bigger than {m.model}" : $"The display {model} has the same size as {m.model}") +
                " " +
                ((ppi < m.ppi)? $"and display {model} is not sharper than {m.model}" : (ppi != m.ppi) ? $"and display {model} is sharper than {m.model}" : $"and display {model} has the same sharpness as {m.model}")
                +"\n");
        }

        public override string ToString() {
            return $"model {model}";
        }

    }
}

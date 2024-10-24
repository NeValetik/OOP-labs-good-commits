using System;
using Lab_2.Task1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Task3
{
    public class Assistant
    {
        private string _assistantName;
        public string assistantName { get { return _assistantName; } }

        private List<Display> _assistantDisplays;
        public List<Display> assistantDisplays { get { return _assistantDisplays; } }

        public Assistant(string assistantName) {
            _assistantName = assistantName;
        }

        public void assignDisplay(Display d) {
            if (_assistantDisplays == null ) { 
                _assistantDisplays = new List<Display>();
            }
            if (!_assistantDisplays.Contains(d))
                _assistantDisplays.Add(d);
            else Console.WriteLine($"The {d.model} was alredy assigned to this assistant");
        }

        public void assist()
        {
            var i = 1;
            foreach (var disp in assistantDisplays)
            {
                foreach (var another_disp in assistantDisplays.Skip(i))
                {
                    disp.compareSize(another_disp);
                    disp.compareSharpness(another_disp);
                    disp.compareWithMonitor(another_disp);
                }
                i++;
            }
        }

        public Display buyDisplay(Display d)
        {
                return _assistantDisplays.Remove(d) ? d : null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Task4
{
    public class TextData
    {
        private string? _fileName;
        private string? _text;
        private int _numberOfVowels;
        private int _numberOfConsonants;
        private int _numberOfLetters;
        private int _numberOfSentences;
        private string? _longestWord;
        
        public string? fileName { get { return _fileName; } }
        public string? text { get { return _text; } }
        public int numberOfVowels { get { return _numberOfVowels; } }
        public int numberOfConsonants { get { return _numberOfConsonants; } }
        public int numberOfLetters { get { return _numberOfLetters; } }
        public int numberOfSentences { get { return _numberOfSentences; } }
        public string? longestWord { get { return _longestWord; } }

        public TextData(string? text) {
            _fileName = text.Substring(0,text.IndexOf(".txt")+4);
            string subsText = text.Substring(text.IndexOf(".txt") + 4);
            _text = subsText;
            _numberOfVowels = subsText.Count(t => t == 'a') + subsText.Count(t => t == 'e') + subsText.Count(t => t == 'y') + subsText.Count(t => t == 'i') + subsText.Count(t => t == 'o') + subsText.Count(t => t == 'u');
            _numberOfConsonants = subsText.Length - numberOfVowels - subsText.Count(t => t == ' ') - subsText.Count(t => t == '.') - subsText.Count(t => t == ',') - subsText.Count(t => t == '"') - subsText.Count(t => t == '!') - subsText.Count(t => t == ':') - subsText.Count(t => t == ';') - subsText.Count(t => t == '\n') - subsText.Count(t => t == '?');
            _numberOfLetters = numberOfVowels + numberOfConsonants;
            _numberOfSentences = subsText.Count(t => t == '.') + subsText.Count(t => t == '!') + subsText.Count(t => t == '?');
            _longestWord = subsText.Split(' ').OrderByDescending(s => s.Length).First();
        }

        public override string ToString()
        {
            return $"fileName {fileName}, numberOfVowels {numberOfVowels}, numberOfConsonants {numberOfConsonants}, numberOfLetters {numberOfLetters}, numberOfSentences {numberOfSentences}, longestWord {longestWord}";
        }
    }
}

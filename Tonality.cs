using System;

namespace MusGen
{
    class Tonality
    {
        private string[] notes = new[] { "Do", "Re", "Mi", "Fa", "Sol", "La", "Si" }; // default CMajor()
        private string tonal = null;
        private void CsharpMajor() // 7 sharp
        {
            notes = new[] { "Do", "DoSharp", "ReSharp", "Fa", "FaSharp", "SolSharp", "LaSharp" };
        }
        private void FsharpMajor() // 6 sharp
        {
            notes = new[] { "DoSharp", "ReSharp", "Fa", "FaSharp", "SolSharp", "LaSharp", "Si" };
        }
        private void BMajor() // 5 sharp
        {
            notes = new[] { "DoSharp", "ReSharp", "Mi", "FaSharp", "SolSharp", "LaSharp", "Si" };
        }
        private void EMajor() // 4 sharp
        {
            notes = new[] { "DoSharp", "ReSharp", "Mi", "FaSharp", "SolSharp", "La", "Si" };
        }
        private void AMajor() // 3 sharp
        {
            notes = new[] { "DoSharp", "Re", "Mi", "FaSharp", "SolSharp", "La", "Si" };
        }
        private void DMajor() // 2 sharp
        {
            notes = new[] { "DoSharp", "Re", "Mi", "FaSharp", "Sol", "La", "Si" };
        }
        private void GMajor() // 1 sharp
        {
            notes = new[] { "Do", "Re", "Mi", "FaSharp", "Sol", "La", "Si" };
        }
        private void FMajor() // 1 flat
        {
            notes = new[] { "Do", "Re", "Mi", "Fa", "Sol", "La", "LaSharp" };
        }
        private void BflatMajor() // 2 flat
        {
            notes = new[] { "Do", "Re", "ReSharp", "Fa", "Sol", "La", "LaSharp" };
        }
        private void EflatMajor() // 3 flat
        {
            notes = new[] { "Do", "Re", "ReSharp", "Fa", "Sol", "SolSharp", "LaSharp" };
        }
        private void AflatMajor() // 4 flat
        {
            notes = new[] { "Do", "DoSharp", "ReSharp", "Fa", "Sol", "SolSharp", "LaSharp" };
        }
        private void DflatMajor() // 5 flat
        {
            notes = new[] { "Do", "DoSharp", "ReSharp", "Fa", "FaSharp", "SolSharp", "LaSharp" };
        }
        private void GflatMajor() // 6 flat
        {
            notes = new[] { "DoSharp", "ReSharp", "Fa", "FaSharp", "SolSharp", "LaSharp", "Si" };
        }
        private void CflatMajor() // 7 flat
        {
            notes = new[] { "DoSharp", "ReSharp", "Mi", "FaSharp", "SolSharp", "LaSharp", "Si" };
        }
        public Tonality(int index)
        {
            switch (index)
            {
                case 0:
                    CsharpMajor();
                    tonal = "C# Major";
                    break;
                case 1:
                    FsharpMajor();
                    tonal = "F# Major";
                    break;
                case 2:
                    BMajor();
                    tonal = "B Major";
                    break;
                case 3:
                    EMajor();
                    tonal = "E Major";
                    break;
                case 4:
                    AMajor();
                    tonal = "A Major";
                    break;
                case 5:
                    DMajor();
                    tonal = "D Major";
                    break;
                case 6:
                    GMajor();
                    tonal = "G Major";
                    break;
                case 7:
                    tonal = "C Major";
                    break;
                case 8:
                    FMajor();
                    tonal = "F Major";
                    break;
                case 9:
                    BflatMajor();
                    tonal = "Bb Major";
                    break;
                case 10:
                    EflatMajor();
                    tonal = "Eb Major";
                    break;
                case 11:
                    AflatMajor();
                    tonal = "Ab Major";
                    break;
                case 12:
                    DflatMajor();
                    tonal = "Db Major";
                    break;
                case 13:
                    GflatMajor();
                    tonal = "Gb Major";
                    break;
                case 14:
                    CflatMajor();
                    tonal = "Cb Major";
                    break;
                default:
                    break;
            }
        }
        public string[] getTonality()
        {
            return notes;
        }
        public string getTonal()
        {
            return tonal;
        }
    }
}
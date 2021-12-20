using System;

namespace MusGen
{
    class Tonality
    {
        private string[] notes = new[] { "Do", "Re", "Mi", "Fa", "Sol", "La", "Si" }; // default CMajor()
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
            if (index == 0)
                index = new Random().Next(0, 15);
            switch (index)
            {
                case 0:
                    CsharpMajor();
                    break;
                case 1:
                    FsharpMajor();
                    break;
                case 2:
                    BMajor();
                    break;
                case 3:
                    EMajor();
                    break;
                case 4:
                    AMajor();
                    break;
                case 5:
                    DMajor();
                    break;
                case 6:
                    GMajor();
                    break;
                case 7:
                    break;
                case 8:
                    FMajor();
                    break;
                case 9:
                    BflatMajor();
                    break;
                case 10:
                    EflatMajor();
                    break;
                case 11:
                    AflatMajor();
                    break;
                case 12:
                    DflatMajor();
                    break;
                case 13:
                    GflatMajor();
                    break;
                case 14:
                    CflatMajor();
                    break;
                default:
                    break;
            }
        }
        public string[] getTonality()
        {
            return notes;
        }
    }
}
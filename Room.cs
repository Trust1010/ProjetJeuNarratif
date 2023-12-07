namespace ProjetNarratif
{
    internal abstract class Room
    {
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice);
        public static bool IsCouteau;
        public static bool Ismort;
        public static bool Ishotel;
        public static bool Isplan;
    }
}

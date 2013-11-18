namespace FallingRocks
{
    using System;
    class Rock
    {
        public Rock()
        {
            this.column = 0;
            this.color = ConsoleColor.Black;
            this.symbol = ' ';
        }
        public Rock(int column, int density, ConsoleColor color, char symbol)
        {
            this.column = column;
            this.density = density;
            this.color = color;
            this.symbol = symbol;
        }
        public int column { get; set; }
        public int density { get; set; }
        public ConsoleColor color { get; set; }
        public char symbol { get; set; }
    }
}

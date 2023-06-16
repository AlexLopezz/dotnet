namespace Utils
{
    public static class Validator
    {
        public static bool ValidValue(int value, int min, int max)
        {
            return min < max ? (value >= min && value <= max) : false;
        }

        public static bool ValidAnswer(char character) => character == 'S';
    }

}

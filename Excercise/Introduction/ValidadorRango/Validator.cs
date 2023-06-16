namespace ValidadorRango
{
    public static class Validator
    {
        public static bool ValidValue(int value, int min, int max)
        {
            return min < max ? (value >= min && value <= max) : false;
        }
    }
}

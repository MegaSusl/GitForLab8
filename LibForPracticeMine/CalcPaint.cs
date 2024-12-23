namespace LibForPracticeMine
{
    public class CalcPaint
    {
        public static double calculatePaint( double width, double height, int paint, int layers)
        {
            double spentRatio = 0;
            switch (paint)
            {
                case 0: // акрил
                    {
                        spentRatio = 0.25;
                        break;
                    }
                case 1: // масляная
                    {
                        spentRatio = 0.20;
                        break;
                    }
                case 2: // силиконовая
                    {
                        spentRatio = 0.30;
                        break;
                    }
            }            

            return width * height * spentRatio * layers;
        }
        public static double calculatePaintM(double width, double height, double liters)
        {
            return liters / (width * height);
        }
    }    
}

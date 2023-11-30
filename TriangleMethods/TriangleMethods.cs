namespace TriangleMethods
{
    public static class TriangleMethods
    {
        public static TriangleType GetType(double a, double b, double c)
        {
            if ((a <= 0 || b <= 0 || c <= 0) || (a + b < c || a + c < b || b + c < a))
            {
                throw new ArgumentException();
            }

            //Случай равностороннего треуголника
            if (a == b && a == c)
            {
                return TriangleType.Acute;
            }
            
            var triangleArray = new[] { a, b, c };
            Array.Sort(triangleArray);

            var pythagoreanCondition = triangleArray[2] * triangleArray[2] - triangleArray[0] * triangleArray[0] - triangleArray[1] * triangleArray[1];
            if (pythagoreanCondition == 0.0){
                return TriangleType.Right;
            }
            else
            {
                if(pythagoreanCondition > 0)
                {
                    return TriangleType.Obtuse;
                }
                return TriangleType.Acute;
            }            
        }
    }
}
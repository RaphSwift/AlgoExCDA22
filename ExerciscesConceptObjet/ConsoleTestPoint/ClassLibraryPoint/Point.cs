namespace ClassLibraryPoint
{
    public class Point
    {
        private float abscisseX;
        private float ordoneeY;

        public Point(Point point)
        {
            abscisseX = point.abscisseX;
            ordoneeY = point.ordoneeY;
        }

        public Point(float x, float y)
        {
            abscisseX = x;
            ordoneeY = y;
        }

        public Point()
        {
            abscisseX = 0;
            ordoneeY = 0;
        }

        public void SeDeplacer(float newX, float newY)
        {
            abscisseX = newX;
            ordoneeY = newY;
        }

        public Point ConstruireSymetrieX()
        {
            return new Point(-abscisseX, ordoneeY);
        }

        public Point ConstruireSymetrieY()
        {
            return new Point(abscisseX, -ordoneeY);
        }

        public Point ConstruireSymetrieOrigine()
        {
            Point a = this.ConstruireSymetrieX();
            return a.ConstruireSymetrieY();
        }

        public void Permuter()
        {
            float temp = 0;
            temp = ordoneeY;
            ordoneeY = abscisseX;
            abscisseX = temp;
        }

        public override string ToString()
        {
            return "La posision du point est à l'abscisse: " + abscisseX + " et à l'ordonée : " + ordoneeY + ".";
        }
    }
}
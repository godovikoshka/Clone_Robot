namespace Clone
{
    public class Robot
    {
        public string model;
        public string color;
        public int height;
        public int width;
        public int length;
        public Robot(string model, string color, int height, int width, int length)
        {
            this.model = model;
            this.color = color;
            this.height = height;
            this.width = width;
            this.length = length;
        }
        public Robot Clone()
        {
            return new Robot(model, color, height, width, length);
        }
    }
    
}

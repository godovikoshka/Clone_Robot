namespace Clone
{
    public class Robot
    {
        public string model { get; set; }
        public string color { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int length { get; set; }
        
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

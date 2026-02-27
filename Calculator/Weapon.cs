namespace Calculator
{
    public class Weapon
    {
        public string name { get; set; }
        public int price { get; set; }
        public string imgUrl { get; set; }

        public Weapon(string name, int price, string imgUrl)
        {
            this.name = name;
            this.price = price;
            this.imgUrl = imgUrl;
        }

    }
}

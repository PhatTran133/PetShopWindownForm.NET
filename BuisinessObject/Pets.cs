namespace BuisinessObject
{
    public class Pets
    {
        private string id;
        private string name;
        private DateTime monthYear;
        private string type;
        private string breed;
        private int price;
        private int discount;

        public Pets(string id, string name, DateTime monthYear,string type, string breed, int price, int discount)
        {   
            this.id = id;
            this.name = name;
            this.monthYear = monthYear;
            this.type = type;
            this.breed = breed;
            this.price = price;
            this.discount = discount;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime MonthYear { get => monthYear; set => monthYear = value; }
        public string Type { get => type; set => type = value; }
        public string Breed { get => breed; set => breed = value; }
        public double Age
        {
            get
            {
                int monthsDiff = (DateTime.Now.Year - monthYear.Year) * 12 + (DateTime.Now.Month - monthYear.Month);
                double age = monthsDiff / 12.0;
                return Math.Round(age, 1);
            }
        }
        public int Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public double DiscountedPrice
        {
            get
            {
                double discountedPrice = price - (price * ((double)discount / 100));
                return Math.Round(discountedPrice, 2);
            }
        }


        //public double CalculateAge()
        //{
        //    int monthsDiff = (DateTime.Now.Year - monthYear.Year) * 12 + (DateTime.Now.Month - monthYear.Month);
        //    double age = monthsDiff / 12.0; // Chia cho 12.0 để có kết quả dưới dạng double

        //    return Math.Round(age, 1); // Làm tròn đến 1 chữ số thập phân
        //}

        //public int CalculateDiscountedPrice() {
        //    return this.price - (this.price * (discount / 100));
        //}
    }
}
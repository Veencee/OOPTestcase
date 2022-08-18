namespace StoreOOP
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

       

        private void PriceWithoutDiscountBtn_Click(object sender, EventArgs e)
        {
            //decimal txtPrice;
            try
            {
                var itemName = (txtName.Text) = "Beverages";
                var qty = int.Parse(txtQuantity.Text);
                var price = double.Parse(txtPrice.Text);
                var tPrice = ActualPrice(price, qty);
               
                txtTotal.Text = tPrice.ToString();
                
            }
            catch (Exception)
            {

                txtPrice.Text = "Error";
            }
        }
        public static double ActualPrice(double pricce, int quantity)
        {
            var finalPrice = pricce * quantity;
           
            return finalPrice;
        }
        public static double DiscountPrice(double amountPaid)
        {
            var discountPrice = amountPaid - (amountPaid * 0.2d);
            return discountPrice;
        }

        private void Discountbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var itemName = (txtName.Text) = "Beverages";
                var qty = int.Parse(txtQuantity.Text);
                var price = double.Parse(txtPrice.Text);
                var tPrice = ActualPrice(price, qty);
                //var discount =  double.Parse(txtDiscount.Text);
                double discountPrice = DiscountPrice(tPrice);
                //txtPrice.Text = tPrice.ToString();
                txtDiscount.Text = discountPrice.ToString();
            }
            catch (Exception exception)
            {

                txtPrice.Text = "Error";
            }

        }

        private void STORE_Load(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtTotal.Text = "";
            txtDiscount.Text = "";
        }
    }
}
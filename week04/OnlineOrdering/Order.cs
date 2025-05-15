public class Order {
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer) {
        _customer = customer;
        _products = new List<Product>();
    }

    public double GetTotalCost() {
        double totalCost = 0;
        foreach (Product product in _products) {
            totalCost += product.GetTotalPrice();
        }
        return totalCost + _customer.GetShippingCost(); 
    }

    public void GetPackingLabel() {
        foreach (Product product in _products) {
            Console.WriteLine(product.GetLable());
        }
        
    }

    public void GetShippingLabel() {
        Console.WriteLine(_customer.GetShippingLabel());
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }
}
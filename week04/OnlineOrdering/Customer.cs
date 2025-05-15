public class Customer {
    private string _name;
    private Address _address;


    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public int GetShippingCost() {
        if (_address.IsInUSA()) {
            return 5;
        } else {
            return 35;
        }
    }

    public string GetShippingLabel() {
        return $"Name: {_name}, Address: {_address}";
    }
}
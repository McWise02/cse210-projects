public class Address {
    private string _street;
    private string _city;
    private string _state;
    public enum CountryCode
    {
    US,GB,DE,FR,CA,AU,IN,CN,JP,BR,RU,MX,ZA,KR,IT,ES,SE,CH,NL,BE,NO,DK,FI,PL,AR,TR,NZ,NG,EG,ID,MY,SG

    }
    private CountryCode _country;

    public Address(string street, string city, string state, CountryCode country) {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        
    }

    public string GetFullAddress() {
        return $"{_street}\n, {_city}, {_state},\n {_country}";
    }

    public bool IsInUSA() {
        if (_country == CountryCode.US) {
            return true;
        } else {
            return false;
        }
    }
}
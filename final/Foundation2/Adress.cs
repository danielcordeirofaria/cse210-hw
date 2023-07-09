class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }


    public String GetStreet(){
        return _street;
    }

    public String GetCity(){
        return _city;
    }

    public string GetState(){
        return _state;
    }
    public string GetCountry(){  
        return _country;
    }

    public bool IsUSA()
    {
        if(GetCountry().ToLower() == "usa"){
            return true;
        }else{
        return false;
        }
    }

    public string GetFullAddress()
    {
        return $"{GetStreet()}\n{GetCity()}, {GetState()}\n{GetCountry()}";
    }
}
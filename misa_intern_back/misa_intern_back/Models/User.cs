namespace misa_intern_back.Models;

public class User
{
    public int Id { get; set; }
    public String code { get; set; }
    public string userName { get; set; }
    public DateTime birthday { get; set; }
    public String gender { get; set; }
    public String position { get; set; }
    public String personalNumber { get; set; }
    public DateTime create_date { get; set; }
    public String department { get; set; }
    public String issued_By { get; set; }
    public String address { get; set; }
    public String mobilePhone { get; set; }
    public String landline { get; set; }
    public String email { get; set; }
    public String bacnkCode { get; set; }
    public String bankName { get; set; }
    public String bankBranch { get; set; }
}
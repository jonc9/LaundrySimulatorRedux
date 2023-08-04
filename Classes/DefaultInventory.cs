namespace LaundrySimulator2.Classes
{
    public class DefaultInventory // This is the class to set what the default (aka all possible items) has. *** may eventually convert to Interface*** 
    {
        public int InvId { get; set; }
        public required string ItemName { get; set; }
        public string ItemDescription { get; set; }

        public override string ToString()
        {
            return $"Name: {ItemName}, Description: {ItemDescription}";
        }
    }
}


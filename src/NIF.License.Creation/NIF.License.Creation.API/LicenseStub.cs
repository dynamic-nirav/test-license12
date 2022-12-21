namespace NIF.License.Creation.API
{
    public class LicenseStub
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AutoRenew { get; set; }
        public int RenewBefore { get; set; }
    }
}

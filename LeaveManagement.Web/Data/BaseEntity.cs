namespace LeaveManagement.Web.Data
{
    public partial class BaseEntity // Using partial so BaseEntity cannot be instantiated by itself
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}

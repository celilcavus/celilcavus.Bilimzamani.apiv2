namespace _01.celilcavus.Entity
{
    public class Categories : BaseEntity
    {
        public int Id { get; set; }
        public String Name { get; set; } = String.Empty;

        public Posts Posts { get; set; }
    }
}

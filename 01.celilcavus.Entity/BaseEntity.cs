namespace _01.celilcavus.Entity
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            IsActive = false;
        }
    }
}

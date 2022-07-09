namespace NLayerApp.Core.Entity
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        //Navigation Prop
        public ICollection<Product> Products { get; set; }
       
    }
}

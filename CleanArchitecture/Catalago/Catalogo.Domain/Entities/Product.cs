using Catalogo.Domain.Validation;

namespace Catalogo.Domain.Entities
{
    public sealed class Product : Entity
    {
        public Product(string name, string description, decimal price,
            string imageUrl, int inventory, DateTime dateCreated)
        {
            ValidateDomain(name, description, price, imageUrl, inventory, dateCreated);
        }

        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public string? ImageUrl { get; private set; }
        public int Inventory { get; private set; }
        public DateTime DateCreated { get; private set; }

        public void Update(string name, string description, decimal price,
            string imageUrl, int inventory, DateTime dateCreated, int categoryId)
        {
            ValidateDomain(name, description, price, imageUrl, inventory, dateCreated);
        }

        private void ValidateDomain(string name, string description, decimal price,
            string imageUrl, int inventory, DateTime dateCreated)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required");
            DomainExceptionValidation.When(name.Length < 3,
                "Name must contain at least 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
                "Invalid description. Description is required");
            DomainExceptionValidation.When(description.Length < 5,
                "Description must contain at least 5 characters");

            DomainExceptionValidation.When(price < 0, "Invalid price");
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(imageUrl),
                "Invalid image URL. Image URL is required");
            DomainExceptionValidation.When(imageUrl.Length > 250,
                "Image URL must contain at least 250 characters");

            DomainExceptionValidation.When(inventory < 0, "Invalid price");

            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            Inventory = inventory;
            DateCreated = dateCreated;
        }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}

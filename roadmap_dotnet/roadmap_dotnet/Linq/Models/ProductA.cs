using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadmap_dotnet.Linq.Models
{
    public class ProductA : IEquatable<ProductA>
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public bool Equals(ProductA other)
        {
            if (other is null)
                return false;

            return this.Name == other.Name && this.Code == other.Code;
        }

        public override bool Equals(object obj) => Equals(obj as ProductA);
        public override int GetHashCode() => (Name, Code).GetHashCode();
    }
}

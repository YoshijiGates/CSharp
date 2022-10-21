using System;
using System.Collections.Generic;
using System.Linq;

namespace DeepCopyHelper.Dtos
{
    [Serializable]
    [ToString]
    public class ProductDto : BaseDto<ProductDto>
    {
        #pragma warning disable CS8618
        public int ProductId { set; get; }  // 商品ID
        public string ProductName { set; get; } // 商品名
        public List<string> ProductNote { set; get; } // 商品ノート
        public Product2Dto product2Dto { set; get; }    // Product2Dto

        protected override bool EqualsCore(ProductDto other)
        {
            // 商品IDの比較
            if (ProductId != other.ProductId)
            {
                return false;
            }

            // 商品名の比較
            if (ProductName != other.ProductName)
            {
                return false;
            }

            // 商品ノートの比較
            if (!ProductNote.SequenceEqual(other.ProductNote))
            {
                return false;
            }

            // Product2Dtoの比較
            if (product2Dto != other.product2Dto)
            {
                return false;
            }

            return true;
        }
    }
}

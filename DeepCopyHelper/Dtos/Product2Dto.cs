using System;


namespace DeepCopyHelper.Dtos
{
    [Serializable]
    [ToString]
    public class Product2Dto : BaseDto<Product2Dto>
    {
        public int ProductSummary { set; get; } // 商品合計

        protected override bool EqualsCore(Product2Dto other)
        {
            // 商品合計
            if (ProductSummary != other.ProductSummary)
            {
                return false;
            }

            return true;
        }
    }
}

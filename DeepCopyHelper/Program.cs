using DeepCopyHelper.Dtos;
using DeepCopyHelper.Helpers;
using System.Diagnostics;

// Disable the warning.
// ----------------------------------------
// コピー元のDtoクラスを作成 
// ----------------------------------------
var productDto = new ProductDto();
// 商品ID
productDto.ProductId = 1;

// 商品名
productDto.ProductName = "ProductName1";

// 商品ノート
List<string> list = new List<string>();
list.Add("Note1");
list.Add("Note2");
list.Add("Note3");
productDto.ProductNote = list;

// Product2Dto
var product2Dto = new Product2Dto();
product2Dto.ProductSummary = 100;
productDto.product2Dto = product2Dto;
// ----------------------------------------

// DeepCopyを実行
var productDtoCopy = productDto.DeepCopy<ProductDto>();

// コピー先の値を一部修正
// productDtoCopy.ProductNote.Remove("Note1");
// productDtoCopy.product2Dto.ProductSummary = 200;

// コピー元、コピー先の値を出力
Debug.WriteLine(productDto.ToString());
Debug.WriteLine(productDtoCopy.ToString());

// コピー元、コピー先の比較
Debug.WriteLine(productDto == productDtoCopy);

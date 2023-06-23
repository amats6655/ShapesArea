SELECT P.ProductName, C.CategoryName <br>
FROM Products P <br>
LEFT JOIN ProductCategories PC ON P.ProductId = PC.ProductId <br>
LEFT JOIN Categories C ON PC.CategoryId = C.CategoryId; <br>


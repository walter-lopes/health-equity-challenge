SELECT
  CONCAT(c.FirstName, ' ', c.LastName) AS fullname,
  c.Age as age,
  o.OrderIDnas orderid,
  o.DateCreated as datecreated,
  o.MethodofPurchase AS PurchaseMethod,
  od.ProductNumber,
  od.ProductOrigin
FROM
  Customer c
JOIN
  Orders o ON c.PersonID = o.PersonID
JOIN
  OrdersDetails od ON o.OrderID = od.OrderID
WHERE
  od.ProductID = '1112222333';
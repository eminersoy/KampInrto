-- SQL Structure Query Language 
--Select           bu isimlemeyi yapmak zorunda değiliz
-- bu kod oracle da da mysql de de çalışır (ANSII)
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers --bu aslında feyk bir tablo oluşturuyor

Select * from Customers where City = 'Berlin'

--sql case insensitive dir büyük küçük harf duyarlı değil.
select * from Products where categoryID = 1 or categoryID =3

select * from Products where categoryID = 1 and UnitPrice>=10
--order by sıralama
select * from Products order by UnitPrice desc --asc ascending artan desc descending azalan
-- CategoryID si 1 olan ürünleri sıralama
select * from Products where CategoryID = 1 order by UnitPrice desc

select * from Products order by CategoryID,ProductName

--product sayısını öğrenme
Select count(*) from Products

--CategoryID si 2 olan product sayısını  Adet başlığında öğrenme
Select count(*) Adet from Products where CategoryID = 2

--Hangi kategoriden kaç ürün olduğunu öğrenme DİKKAT öncekiler 1 sütun(tek sayıydı) bu 2 sütun
Select CategoryId,count(*) from Products group by CategoryID

--CategoryID ye göre saysı 10 ve altında olan ürünler
Select CategoryId,count(*) from Products group by CategoryID having count(*)<=10  --having kümülatiflere uygulanır

--CategoryID ye göre fiyatı20 den büyük saysı 10 ve altında olan ürünler


-- joinlemek tabloları birleştirmek demek
select Products.ProductID, Products.ProductID, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories --inner join sadece iki tabloda da eşleşen verileri getirir eşlenmeyenleri getirmez
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


--DTO Data Transformation Object

Select * from Products p left join [Order Details] od --p ve od alias -- left join solda olup sağda olmayanları da getir demek
on p.ProductID = od.ProductID
inner join Orders o -- ikiden fazla tablo birleştirmek için tekrar join kullandık
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o --bu sorgu müşterilerden hiç ürün sipariş etmeyenleri getirir solda olup sağda olmayanlar
on c.CustomerID = o.CustomerID
where o.CustomerID is null --sipariş vermediği için null



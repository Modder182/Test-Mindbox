# Test-Mindbox
<pre>Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

      -- Юнит-тесты
      -- Легкость добавления других фигур
      -- Вычисление площади фигуры без знания типа фигуры
      -- Проверку на то, является ли треугольник прямоугольным
      
</pre>

<h4>SQL код запроса к БД</h4>
<pre>SELECT [ProductName], count(ProductName) as Days
FROM [Magazine].[Sales] cnt
      INNER JOIN (
              SELECT [ClientID], MIN(CreationDate) as NewBuyerDate
              FROM [Magazine].[Sales] GROUP BY ClientID
      ) as cag
      ON cnt.ClientID = cag.ClientID AND
         cnt.CreationDate = cag.NewBuyerDate
GROUP BY ProductName</pre>

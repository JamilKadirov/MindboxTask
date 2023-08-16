## Задание по SQL

### Описание

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### Структура таблиц

- Products:
  - Id
  - Name 
  - ...

- Categories:
  - Id
  - Name
  - ...

- ProductsCategories:
  - ProductId
  - CategoryId

### Решение

```sql
select P.Name, C.Name
from Products P
		left join ProductsCategories PC on PC.ProductId = P.Id
		left join Categories C on PC.CategoryId = C.Id;
```

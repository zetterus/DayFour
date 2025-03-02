# DayFour

## Описание проекта
DayFour - это RESTful API для управления продуктами, разработанный с использованием ASP.NET Core. Проект демонстрирует реализацию базовых CRUD-операций (Create, Read, Update, Delete) с применением принципов Dependency Injection (DI) для обеспечения низкой связанности компонентов.

## Основные функции
- Получение списка всех продуктов
- Получение информации о конкретном продукте по ID
- Создание новых продуктов
- Обновление информации о существующих продуктах
- Удаление продуктов
- Swagger UI для тестирования API

## Используемые технологии
- **ASP.NET Core** - фреймворк для создания веб-приложений
- **Entity Framework Core** - ORM (Object-Relational Mapping) для работы с базой данных
- **SQLite** - легковесная встраиваемая база данных
- **Dependency Injection** - встроенный контейнер зависимостей ASP.NET Core
- **Swagger/OpenAPI** - инструменты для документирования и тестирования API

## Установка и запуск проекта

### Предварительные требования
- .NET SDK 6.0 или выше
- Git

### Шаги по установке
1. Клонировать репозиторий:
   ```
   git clone https://github.com/zetterus/DayFour.git
   ```

2. Перейти в директорию проекта:
   ```
   cd DayFour
   ```

3. Восстановить зависимости:
   ```
   dotnet restore
   ```

4. Запустить приложение:
   ```
   dotnet run
   ```

5. API будет доступно по адресам:
   - HTTP: http://localhost:5188
   - HTTPS: https://localhost:7253

6. Swagger UI доступен по адресу:
   - http://localhost:5188/swagger (при запуске в HTTP-режиме)
   - https://localhost:7253/swagger (при запуске в HTTPS-режиме)

## Примеры использования

### Получение всех продуктов

```http
GET /api/products
```

Ответ:
```json
[
  {
    "id": 1,
    "name": "Ноутбук",
    "category": "Электроника",
    "price": 75000.00
  },
  {
    "id": 2,
    "name": "Смартфон",
    "category": "Электроника",
    "price": 35000.00
  }
]
```

### Получение продукта по ID

```http
GET /api/products/1
```

Ответ:
```json
{
  "id": 1,
  "name": "Ноутбук",
  "category": "Электроника",
  "price": 75000.00
}
```

### Создание нового продукта

```http
POST /api/products
Content-Type: application/json

{
  "name": "Клавиатура",
  "category": "Аксессуары",
  "price": 3500.00
}
```

Ответ:
```json
{
  "id": 3,
  "name": "Клавиатура",
  "category": "Аксессуары",
  "price": 3500.00
}
```

### Обновление продукта

```http
PUT /api/products/3
Content-Type: application/json

{
  "id": 3,
  "name": "Клавиатура механическая",
  "category": "Аксессуары",
  "price": 5500.00
}
```

### Удаление продукта

```http
DELETE /api/products/3
```

## Лицензия
MIT License

Copyright (c) 2023 Zetterus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

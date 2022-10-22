using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////// 1. Задание CRM
            //Организовать запись и чтение коллекции данных классов в/ из файл(а).
            //Организовать обработку некорректного формата входного файла.
            //Сделать вывод списка физ лиц.Упорядочить список физ.лиц по Фамилии, Имени, Отчеству.
            //Юр.лица могут иметь список контактных лиц, которые являются физ. лицами.
            //Сделать вывод 5 записей из списка юр. лиц.Упорядочить список юр.лиц по количеству контактных лиц(по убыванию).

            NaturalPerson naturalPerson = new NaturalPerson();
            List<NaturalPerson> allNaturalPeople = naturalPerson.GetPersonFromFile("NaturalPeople.txt")
                .OrderBy(col => col.LastName)
                .ThenBy(prop => prop.FirstName)
                .ThenBy(prop => prop.MiddleName).ToList();

            Console.WriteLine("View all sorded users: ");
            foreach (var user in allNaturalPeople)
            {
                Console.WriteLine($"{user.LastName} {user.FirstName} {user.MiddleName}");
            }

            LegalEntity legalEntity = new LegalEntity();
            List<LegalEntity> allLegalEntity = legalEntity.GetEntitiesFromFile("LegalEntity.txt");
            
            //////// 2. Понимание кода. Случай из реальной практики
            // В коде нет ошибок т.к. 2020 год является високосным и он допускает 29 февраля
            // Однако я бы поставил обработчик событии на введенную дату (feb) и сократил return до 1 строки
            // Я думаю ошибка разработчика является явное указание feb в методе, а не получение его в качестве параметра метода

            //DateTime feb;
            //try
            //{
            //    feb = new DateTime(2020, 2, 29);
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    feb = new DateTime(2020, 3, 1);
            //}
            //return feb >= dateStart && feb <= dateEnd;



            //////// 3.1 Есть три таблицы: CUSTOMERS (ID, NAME, MANAGER_ID); MANAGERS (ID, NAME); ORDERS (ID, DATE, AMOUNT, CUSTOMER_ID). Написать запрос, который выведет имена Customers и их SalesManagers, которые сделали покупок на общую сумму больше 10000 с 01.01.2013.
            //SELECT CUSTOMERS.NAME, MANAGERS.NAME from 
            //(
            //    SELECT ORDERS.CUSTOMER_ID, SUM(AMOUNT) as SumAmount FROM ORDERS WHERE ORDERS.DATE > '2013-01-01' group by CUSTOMER_ID
            //) amount, CUSTOMERS, MANAGERS
            //where 
            //CUSTOMERS.ID = amount.CUSTOMER_ID and 
            //MANAGERS.ID = CUSTOMERS.MANAGER_ID and 
            //SumAmount > 10000


            //////// 3.2 На основе таблицы необходимо сделать:
            //1. Поиск всех работников, у которых имя содержит букву «m», вне зависимости в каком регистре будет написано.
            //  SELECT *
            //  FROM[OrganizationOrders].[dbo].[EMPLOYEES] e
            //  Where e.emp_name like lower('%m%')

            //2.SQL запрос, который найдет максимальную зарплату в каждом департаменте.
            //  SELECT e.dept_id, Max(e.salary)
            //  FROM[OrganizationOrders].[dbo].[EMPLOYEES] e
            //  group by e.dept_id

            //3.Построить SQL запрос который выведет список сотрудников, у которых одинаковая зарплата
            //  WITH DuplicateValue AS(
            //  SELECT salary, COUNT(*) AS CNT
            //        FROM EMPLOYEES
            //        GROUP BY salary
            //        HAVING COUNT(*) > 1
            //)
            //  SELECT emp_id, emp_name, salary
            //  FROM EMPLOYEES
            //   WHERE salary IN(SELECT salary FROM DuplicateValue)
            //   ORDER BY salary, emp_id;

        }
    }
}
